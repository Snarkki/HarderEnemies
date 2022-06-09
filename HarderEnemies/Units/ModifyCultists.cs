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

        private static BlueprintBrain NewCultistClericBrain = BlueprintTools.GetModBlueprint<BlueprintBrain>(HEContext, "NewCultistClericBrain");
        private static BlueprintBrain NewCultistClericEliteBrain = BlueprintTools.GetModBlueprint<BlueprintBrain>(HEContext, "NewCultistClericEliteBrain");
        
        
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
                Utils.CustomHelpers.AddFactListsToUnit(thisUnit, thisUnit.CR, BuffLists.CultistBuffLists.CultistCasterAbilities);
                thisUnit.AlternativeBrains = new BlueprintBrainReference[] { };
            }

            BrainList.CultistEvokerBrain.m_Actions = BrainList.CultistEvokerBrain.m_Actions.AppendToArray(
                AiCastSpellList.CultistConjurerHasteAiAction.ToReference<BlueprintAiActionReference>(),
                CreatePitAiSpell.ToReference<BlueprintAiActionReference>()
                );

            BrainList.CultistConjurerBrain.m_Actions = BrainList.CultistConjurerBrain.m_Actions.AppendToArray(
                GreaseAiSpell.ToReference<BlueprintAiActionReference>(),
                AnimateDeadAiSpell.ToReference<BlueprintAiActionReference>(),
                AiCastSpellList.StinkingCloudAiAction.ToReference<BlueprintAiActionReference>(),
                CreatePitAiSpell.ToReference<BlueprintAiActionReference>()
                );


            // MELEE CASTERIT!
            foreach (BlueprintUnit thisUnit in Cultists.CultistClericList) {
                if (thisUnit.CR <= 10) {
                    Utils.CustomHelpers.AddFactListsToUnit(thisUnit, thisUnit.CR, BuffLists.CultistBuffLists.CultistClericAbilities);
                    thisUnit.AlternativeBrains = new BlueprintBrainReference[] { };
                    thisUnit.m_Brain = NewCultistClericBrain.ToReference<BlueprintBrainReference>();
                }
                else {
                    Utils.CustomHelpers.AddFactListsToUnit(thisUnit, thisUnit.CR, BuffLists.CultistBuffLists.CultistEliteClericAbilities);
                    thisUnit.AlternativeBrains = new BlueprintBrainReference[] { };
                    thisUnit.m_Brain = NewCultistClericEliteBrain.ToReference<BlueprintBrainReference>();
                }
            }

            HEContext.Logger.LogHeader("Updated Cultist Casters");
        }
        public static void CasterBuffs() {

            if (HEContext.Prebuffs.OtherBuffs.IsDisabled("CultistCasterBuffs")) { return; }

            foreach (BlueprintUnit thisUnit in Cultists.CultistCasterList) {
                Utils.CustomHelpers.AddFactListsToUnit(thisUnit, thisUnit.CR, BuffLists.CultistBuffLists.CultistCasterBuffs);
            }

            foreach (BlueprintUnit thisUnit in Cultists.CultistClericList) {
                if (thisUnit.CR <= 10) {
                    Utils.CustomHelpers.AddFactListsToUnit(thisUnit, thisUnit.CR, BuffLists.CultistBuffLists.CultistClericBuffs);
                } else {
                    Utils.CustomHelpers.AddFactListsToUnit(thisUnit, thisUnit.CR, BuffLists.CultistBuffLists.CultistEliteClericBuffs);
                }
            }

            HEContext.Logger.LogHeader("Updated Cultist Casters");
        }
    }
}

