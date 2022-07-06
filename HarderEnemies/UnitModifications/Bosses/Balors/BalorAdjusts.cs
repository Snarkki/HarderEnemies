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
using Kingmaker.Blueprints.Items.Weapons;
using HarderEnemies.UnitModifications.Bosses.Balors;
using Kingmaker.Designers.Mechanics.Facts;

namespace HarderEnemies.UnitModifications.Bosses.Balors {
    internal class BalorAdjusts {



        //Balor weapons
        private static BlueprintItemWeapon BalorNewSword = BlueprintTools.GetModBlueprint<BlueprintItemWeapon>(HEContext, "BalorNewSword");
        private static BlueprintFeature AbyssalToughnessFeature = BlueprintTools.GetModBlueprint<BlueprintFeature>(HEContext, "AbyssalToughnessFeature");
        private static BlueprintBrain DarrazandBrain = BlueprintTools.GetModBlueprint<BlueprintBrain>(HEContext, "DarrazandBrain");
        private static BlueprintBrain MeleeBalorBrain = BlueprintTools.GetModBlueprint<BlueprintBrain>(HEContext, "MeleeBalorBrain");
        private static BlueprintBrain CasterBalorBrain = BlueprintTools.GetModBlueprint<BlueprintBrain>(HEContext, "CasterBalorBrain");
        private static BlueprintBrain MythicBalorBrain = BlueprintTools.GetModBlueprint<BlueprintBrain>(HEContext, "MythicBalorBrain");


        public static void Handler() {
            HandleHPBuff();
            BalorAbilities();
            BalorBuffs();
        }

        private static void HandleHPBuff() {
            //Adjust HP if enabled
            if (!HEContext.HPChanges.HPBoosts.IsDisabled("AdjustBossHp")) {
                foreach (BlueprintUnit thisUnit in UnitLists.BalorList) {
                    thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(AbyssalToughnessFeature.ToReference<BlueprintUnitFactReference>());
                }
                foreach (BlueprintUnit thisUnit in UnitLists.KhorramzadehList) {
                    thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(AbyssalToughnessFeature.ToReference<BlueprintUnitFactReference>());
                }
            }
        }

        private static void BalorAbilities() {
            if (HEContext.AbilityChanges.BossChanges.IsDisabled("BalorChanges")) { return; }

            foreach (BlueprintUnit thisUnit in UnitLists.BalorList) {
                thisUnit.Body.m_PrimaryHand = BalorNewSword.ToReference<BlueprintItemEquipmentHandReference>();
                //  Bonus caster level
                thisUnit.AddComponent<AddCasterLevel>(c => { c.Bonus = 15; });
            }

            // Adjust Darrazand
            Utils.CustomHelpers.AddFactsToUnit(UnitLists.Darrazand, AbilityLists.DarrazandAbilities);
            UnitLists.Darrazand.m_Brain = DarrazandBrain.ToReference<BlueprintBrainReference>();
            UnitLists.Darrazand.AlternativeBrains = new BlueprintBrainReference[0] { };


            // Create Melee Balors
            foreach (BlueprintUnit thisUnit in UnitLists.MeleeBalors) {
                Utils.CustomHelpers.AddFactsToUnit(thisUnit, AbilityLists.MeleeBalorAbilities);
                thisUnit.m_Brain = MeleeBalorBrain.ToReference<BlueprintBrainReference>();
                thisUnit.AlternativeBrains = new BlueprintBrainReference[0] { };
            }

            // Create Caster Balors
            foreach (BlueprintUnit thisUnit in UnitLists.CasterBalors) {
                Utils.CustomHelpers.AddFactsToUnit(thisUnit, AbilityLists.CasterBalorAbilities);
                thisUnit.m_Brain = CasterBalorBrain.ToReference<BlueprintBrainReference>();
                thisUnit.AlternativeBrains = new BlueprintBrainReference[0] { };
            }

            // Create Mythic Balors
            foreach (BlueprintUnit thisUnit in UnitLists.MythicBalors) {
                Utils.CustomHelpers.AddFactsToUnit(thisUnit, AbilityLists.MythicBalorAbilities);
                thisUnit.m_Brain = MythicBalorBrain.ToReference<BlueprintBrainReference>();
                thisUnit.AlternativeBrains = new BlueprintBrainReference[0] { };
            }
         
            HEContext.Logger.LogHeader("Updated Balors");
        }

        private static void BalorBuffs() {
            if (HEContext.Prebuffs.BossBuffs.IsDisabled("BalorBuffs")) { return; }
            foreach (BlueprintUnit thisUnit in UnitLists.BalorList) {
                thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(FeatureList.CR22_AxiomiteCaster_Feature_CombatPrebuff.ToReference<BlueprintUnitFactReference>());
                Utils.CustomHelpers.AddFactListsToUnit(thisUnit, 35, BuffLists.BalorBuffsList);
            }
        }




    }
}
