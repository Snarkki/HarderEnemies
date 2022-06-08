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
using static HarderEnemies.Main;
using HarderEnemies.Blueprints;
using Kingmaker.Blueprints.Items.Weapons;
using Kingmaker.UnitLogic.Abilities.Blueprints;
using Kingmaker.Designers.Mechanics.Facts;
using Kingmaker.UnitLogic.Abilities.Components;
using Kingmaker.UnitLogic.Mechanics.Actions;

namespace HarderEnemies.Units.Adjustments {
    internal class AdjustJerribeth {

        private static BlueprintFeature SuperiorQuickenMetaFeature = BlueprintTools.GetModBlueprint<BlueprintFeature>(HEContext, "SuperiorQuickenMetaMagicFeature");
        private static BlueprintAiCastSpell GreaterDispelAiSpellSwift = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "GreaterDispelAiSpellSwift");
        private static BlueprintAiCastSpell StormBoltAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "StormBoltAiSpell");
        private static BlueprintAiCastSpell SummonMonsterViiAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "SummonMonsterViiAiSpell");
        private static BlueprintAiCastSpell FearAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "FearAiSpell");

        public static void HandleJerribetth() {
            JerribethAbilities();
            JerribethBuffs();
        }


        private static void JerribethAbilities() {
            if (HEContext.AbilityChanges.DemonChanges.IsDisabled("JerribethChanges")) { return; }

            foreach (BlueprintUnit thisUnit in Bosses.JerribethList) {
                thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(
                        SuperiorQuickenMetaFeature.ToReference<BlueprintUnitFactReference>(),
                        Abilities.DispelGreater.ToReference<BlueprintUnitFactReference>()
                    );
                var newSpells = thisUnit.GetComponent<ApplyClassProgression>();
                newSpells.m_MemorizeSpells.AppendToArray(
                    Abilities.SummonMonsterVII.ToReference<BlueprintAbilityReference>(),
                    Abilities.HoldPersonMass.ToReference<BlueprintAbilityReference>(),
                    Abilities.StinkingCloud.ToReference<BlueprintAbilityReference>(),
                    Abilities.Fear.ToReference<BlueprintAbilityReference>(),
                    Abilities.Stormbolts.ToReference<BlueprintAbilityReference>()
                    );
                newSpells.m_SelectSpells.AppendToArray(
                    Abilities.SummonMonsterVII.ToReference<BlueprintAbilityReference>(),
                    Abilities.HoldPersonMass.ToReference<BlueprintAbilityReference>(),
                    Abilities.StinkingCloud.ToReference<BlueprintAbilityReference>(),
                    Abilities.Fear.ToReference<BlueprintAbilityReference>(),
                    Abilities.Stormbolts.ToReference<BlueprintAbilityReference>()
                    );
            }

            BrainList.JerribethBrain.m_Actions = BrainList.JerribethBrain.m_Actions.AppendToArray(
                GreaterDispelAiSpellSwift.ToReference<BlueprintAiActionReference>(),
                StormBoltAiSpell.ToReference<BlueprintAiActionReference>(),
                SummonMonsterViiAiSpell.ToReference<BlueprintAiActionReference>(),
                FearAiSpell.ToReference<BlueprintAiActionReference>(),
                AiCastSpellList.Nabasu_MassHoldPersonHigh_AiAction.ToReference<BlueprintAiActionReference>(),
                AiCastSpellList.StinkingCloudAiAction.ToReference<BlueprintAiActionReference>()
                );
            HEContext.Logger.LogHeader("Updated Jerribeth Abilities");
        }

        private static void JerribethBuffs() {
            if (HEContext.Prebuffs.DemonBuffs.IsDisabled("JerribethBuffs")) { return; }

            foreach (BlueprintUnit thisUnit in Bosses.JerribethList) {

                thisUnit.AddComponent<AddFacts>(c => {
                    c.CasterLevel = 17;
                    c.MinDifficulty = Kingmaker.Settings.GameDifficultyOption.Daring;
                    c.m_Facts = new BlueprintUnitFactReference[] {
                        Abilities.BarkskinBuff.ToReference<BlueprintUnitFactReference>(),
                        Abilities.ShielfOfFaithBuff.ToReference<BlueprintUnitFactReference>(),
                        Abilities.MageShieldBuff.ToReference<BlueprintUnitFactReference>(),
                        Abilities.StoneskinBuff.ToReference<BlueprintUnitFactReference>(),
                        Abilities.MindBlankBuff.ToReference<BlueprintUnitFactReference>(),
                        Abilities.TrueSeeingBuff.ToReference<BlueprintUnitFactReference>(),
                    };
                });
            }


            HEContext.Logger.LogHeader("Updated Jerribeth Buffs");
        }
    }
}
