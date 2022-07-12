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

namespace HarderEnemies.UnitModifications.Bosses.Minagho {
    internal class MinaghoAdjusts {



        private static BlueprintFeature AbyssalToughnessFeature = BlueprintTools.GetModBlueprint<BlueprintFeature>(HEContext, "AbyssalToughnessFeature");
        private static BlueprintAiCastSpell GreaterDispelAiSpellSwift = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "GreaterDispelAiSpellSwift");
        private static BlueprintAiCastSpell PowerWordBlindAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "PowerWordBlindAiSpell");
        private static BlueprintAiCastSpell CreateRiftOfRuinAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "CreateRiftOfRuinAiSpell");
        private static BlueprintAiCastSpell FirestormEmpoweredAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "FirestormEmpoweredAiSpell");
        private static BlueprintAiCastSpell ChainLightningAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "ChainLightningAiSpell");


        private static BlueprintBrain MinaghoBrain = BlueprintTools.GetModBlueprint<BlueprintBrain>(HEContext, "MinaghoBrain");

        public static void Handler() {
            HandleHPBuff();
            MinaghoAbilities();
            MinaghoBuffs();
        }

        private static void HandleHPBuff() {
            //Adjust HP if enabled
            if (!HEContext.HPChanges.HPBoosts.IsDisabled("AdjustBossHp")) {
                foreach (BlueprintUnit thisUnit in UnitLists.MinaghoList) {
                    thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(AbyssalToughnessFeature.ToReference<BlueprintUnitFactReference>());
                }
            }
        }

        private static void MinaghoAbilities() {
            if (HEContext.AbilityChanges.BossChanges.IsDisabled("MinaghoChanges")) { return; }

            foreach (BlueprintUnit thisUnit in UnitLists.MinaghoList) {
                Utils.CustomHelpers.AddFactsToUnit(thisUnit, AbilityLists.MinaghoAbilities);
            }

            UnitLists.Alushinyrra_Minagho.m_Brain = MinaghoBrain.ToReference<BlueprintBrainReference>();
            UnitLists.Alushinyrra_Minagho.AlternativeBrains = new BlueprintBrainReference[0] { };


            BrainList.Alushinyrra_Minagho_Brain.m_Actions = BrainList.Alushinyrra_Minagho_Brain.m_Actions.AppendToArray(
                GreaterDispelAiSpellSwift.ToReference<BlueprintAiActionReference>(),
                AiCastSpellList.Minagho_PhantasmalPutrefactionAIAction.ToReference<BlueprintAiActionReference>(),
                PowerWordBlindAiSpell.ToReference<BlueprintAiActionReference>(),
                FirestormEmpoweredAiSpell.ToReference<BlueprintAiActionReference>(),
                ChainLightningAiSpell.ToReference<BlueprintAiActionReference>(),
                CreateRiftOfRuinAiSpell.ToReference<BlueprintAiActionReference>()
                );


            //BrainList.MinaghoBrain.m_Actions.AppendToArray(GreaterDispelAiSpell.ToReference<BlueprintAiActionReference>());
            HEContext.Logger.LogHeader("Updated Minaghos");
        }

        private static void MinaghoBuffs() {
            if (HEContext.Prebuffs.BossBuffs.IsDisabled("MinaghoBuffs")) { return; }

            foreach (BlueprintUnit thisUnit in UnitLists.MinaghoList) {
                Utils.CustomHelpers.AddFactListsToUnit(thisUnit, 32, BuffLists.MinaghoBuffs);
            }

            //BrainList.MinaghoBrain.m_Actions.AppendToArray(GreaterDispelAiSpell.ToReference<BlueprintAiActionReference>());
            HEContext.Logger.LogHeader("Updated Minaghos");
        }
    }
}
