using Kingmaker.AI.Blueprints;
using Kingmaker.Blueprints;
using Kingmaker.Blueprints.Classes;
using Kingmaker.UnitLogic.FactLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TabletopTweaks.Core.Utilities;
using HarderEnemies.Features;
using HarderEnemies.AI_Mechanics.Brains;
using HarderEnemies.AI_Mechanics.Actions;
using HarderEnemies.Blueprints;
using static HarderEnemies.Main;


namespace HarderEnemies.Units {
    public class ModifyCultists {

        private static BlueprintAiCastSpell CreatePitAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "CreatePitAiSpell");
        private static BlueprintAiCastSpell GreaseAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "GreaseAiSpell");
        private static BlueprintAiCastSpell AnimateDeadAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "AnimateDeadAiSpell");
        private static BlueprintFeature SuperToughness = BlueprintTools.GetModBlueprint<BlueprintFeature>(HEContext, "SuperToughnessFeature");

        public static void HandleChanges() {
            ModifyCultists.AdjustHP();
            ModifyCultists.CasterAbilities();
            ModifyCultists.CasterBuffs();
        }

        private static void AdjustHP() {
            if (HEContext.HPChanges.HPBoosts.IsDisabled("AdjustCultistCasters")) { return; }

            foreach (BlueprintUnit thisUnit in Cultists.CultistCasterList) {
                thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(SuperToughness.ToReference<BlueprintUnitFactReference>());
            }
            HEContext.Logger.LogHeader("Adjusted Cultist Caster HP");
        }

        public static void CasterAbilities() {
            if (HEContext.AbilityChanges.OtherChanges.IsDisabled("CultistCasterChanges")) { return; }
            foreach (BlueprintUnit thisUnit in Cultists.CultistCasterList) {
                thisUnit.AddComponent<AddFacts>(c => {
                    c.CasterLevel = (thisUnit.CR + 1);
                    c.MinDifficulty = Kingmaker.Settings.GameDifficultyOption.Daring;
                    c.m_Facts = new BlueprintUnitFactReference[] {
                        Abilities.MageShieldBuff.ToReference<BlueprintUnitFactReference>(),
                        Abilities.ProtectionFromArrowsBuff.ToReference<BlueprintUnitFactReference>(),
                        Abilities.BarkskinBuff.ToReference<BlueprintUnitFactReference>(),
                        Abilities.Grease.ToReference<BlueprintUnitFactReference>(),
                        Abilities.StinkingCloud.ToReference<BlueprintUnitFactReference>(),
                        Abilities.CreatePit.ToReference<BlueprintUnitFactReference>(),
                        Abilities.AnimateDead.ToReference<BlueprintUnitFactReference>(),
                    };
                });
            }

            BrainList.CultistEvokerBrain.m_Actions = BrainList.CultistEvokerBrain.m_Actions.AppendToArray(
                GreaseAiSpell.ToReference<BlueprintAiActionReference>(),
                AiCastSpellList.StinkingCloudAiAction.ToReference<BlueprintAiActionReference>()
                );
            BrainList.CultistEvokerBrain.m_Actions = BrainList.CultistEvokerBrain.m_Actions.AppendToArray(
                GreaseAiSpell.ToReference<BlueprintAiActionReference>(),
                CreatePitAiSpell.ToReference<BlueprintAiActionReference>(),
                AnimateDeadAiSpell.ToReference<BlueprintAiActionReference>(),
                AiCastSpellList.StinkingCloudAiAction.ToReference<BlueprintAiActionReference>()
                );
            HEContext.Logger.LogHeader("Updated Cultist Casters");
        }
        public static void CasterBuffs() {

            if (HEContext.Prebuffs.OtherBuffs.IsDisabled("CultistCasterBuffs")) { return; }

            HEContext.Logger.LogHeader("Updated Cultist Casters");
        }
    }
}

