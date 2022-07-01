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

namespace HarderEnemies.UnitModifications.Bosses.Jerribeth {
    internal class JerribethAdjusts {


        private static BlueprintAiCastSpell GreaterDispelAiSpellSwift = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "GreaterDispelAiSpellSwift");
        private static BlueprintAiCastSpell StormBoltAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "StormBoltAiSpell");
        private static BlueprintAiCastSpell SummonMonsterViiAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "SummonMonsterViiAiSpell");
        private static BlueprintAiCastSpell FearAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "FearAiSpell");
        private static BlueprintFeature AbyssalToughnessFeature = BlueprintTools.GetModBlueprint<BlueprintFeature>(HEContext, "AbyssalToughnessFeature");



        public static void Handler() {
            HandleHPBuff();
            JerribethAbilities();
            JerribethBuffs();
        }


        private static void HandleHPBuff() {
            //Adjust HP if enabled
            if (!HEContext.HPChanges.HPBoosts.IsDisabled("AdjustBossHp")) {
                foreach (BlueprintUnit thisUnit in UnitLists.JerribethList) {
                    thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(AbyssalToughnessFeature.ToReference<BlueprintUnitFactReference>());
                }
            }
        }

        private static void JerribethAbilities() {
            if (HEContext.AbilityChanges.BossChanges.IsDisabled("JerribethChanges")) { return; }

            foreach (BlueprintUnit thisUnit in UnitLists.JerribethList) {
                Utils.CustomHelpers.AddFactListsToUnit(thisUnit, thisUnit.CR, AbilityLists.JerribethAbilities);
            }

            BrainList.JerribethBrain.m_Actions = BrainList.JerribethBrain.m_Actions.AppendToArray(
                GreaterDispelAiSpellSwift.ToReference<BlueprintAiActionReference>(),
                StormBoltAiSpell.ToReference<BlueprintAiActionReference>(),
                SummonMonsterViiAiSpell.ToReference<BlueprintAiActionReference>(),
                FearAiSpell.ToReference<BlueprintAiActionReference>(),
                AiCastSpellList.Nabasu_MassHoldPersonHigh_AiAction.ToReference<BlueprintAiActionReference>(),
                AiCastSpellList.ScorchingRayAiAction.ToReference<BlueprintAiActionReference>(),
                AiCastSpellList.BurningArcAiAction.ToReference<BlueprintAiActionReference>(),
                AiCastSpellList.Xantir_SlowAIAction.ToReference<BlueprintAiActionReference>()

                );
            HEContext.Logger.LogHeader("Updated Jerribeth Abilities");
        }

        private static void JerribethBuffs() {
            if (HEContext.Prebuffs.BossBuffs.IsDisabled("JerribethBuffs")) { return; }

            foreach (BlueprintUnit thisUnit in UnitLists.JerribethList) {
                Utils.CustomHelpers.AddFactListsToUnit(thisUnit, thisUnit.CR, BuffLists.JerribethBuffs);
            }


            HEContext.Logger.LogHeader("Updated Jerribeth Buffs");
        }
    }
}
