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

namespace HarderEnemies.UnitModifications.Demons.Cambion {
    internal class CambionAdjusts {

        private static BlueprintFeature SuperToughness = BlueprintTools.GetModBlueprint<BlueprintFeature>(HEContext, "SuperToughnessFeature");
        private static BlueprintBrain CambionRangedBrain = BlueprintTools.GetModBlueprint<BlueprintBrain>(HEContext, "CambionRangedBrain");
        private static BlueprintBrain CambionCR3BardBrain = BlueprintTools.GetModBlueprint<BlueprintBrain>(HEContext, "CambionCR3BardBrain");
        private static BlueprintBrain CambionCr19BardBrainCambionRangedBrain = BlueprintTools.GetModBlueprint<BlueprintBrain>(HEContext, "CambionCr19BardBrain");
        private static BlueprintBrain CambionCr14BardBrain = BlueprintTools.GetModBlueprint<BlueprintBrain>(HEContext, "CambionCr14BardBrain");


        public static void Handler() {
            AdjustHP();
            CambionAbilities();
            CambionBuffs();
        }

        private static void AdjustHP() {
            if (HEContext.HPChanges.HPBoosts.IsDisabled("AdjustDemonsHp")) { return; }

            foreach (BlueprintUnit thisUnit in UnitLists.DemonCambionList) {
                thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(SuperToughness.ToReference<BlueprintUnitFactReference>());
            }

            HEContext.Logger.LogHeader("Adjusted Demons HP");
        }

        private static void CambionAbilities() {
            if (HEContext.AbilityChanges.DemonChanges.IsDisabled("CambionAbilities")) { return; }
            foreach (BlueprintUnit thisUnit in UnitLists.DemonCambionList) {
                //thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(BuffLists.DemonBuffLists.Cam);
            }

            foreach (BlueprintUnit thisUnit in UnitLists.DemonRangedCambionList) {
                thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(AbilityLists.CambionRangedAbilities);
                thisUnit.m_Brain = CambionRangedBrain.ToReference<BlueprintBrainReference>();
            }


            // CAMBION BARDS
            foreach (BlueprintUnit thisUnit in UnitLists.CambionBards) {
                thisUnit.m_AddFacts = thisUnit.m_AddFacts.RemoveFromArray(FeatureList.BanditInspireCourageFeature.ToReference<BlueprintUnitFactReference>());
                thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(Abilities.Nurah_InspirecourageAbility.ToReference<BlueprintUnitFactReference>());
            }

            UnitLists.CR14_CambionBard_Ranged.AlternativeBrains = new BlueprintBrainReference[0] { };
            UnitLists.CR14_CambionBard_Ranged.m_Brain = CambionCr14BardBrain.ToReference<BlueprintBrainReference>();

            UnitLists.CR19_CambionBard_Melee.AlternativeBrains = new BlueprintBrainReference[0] { };
            UnitLists.CR19_CambionBard_Melee.m_Brain = CambionCr19BardBrainCambionRangedBrain.ToReference<BlueprintBrainReference>();


            UnitLists.CR3_CambionBard_Ranged.m_AddFacts = UnitLists.CR3_CambionBard_Ranged.m_AddFacts.AppendToArray(Abilities.HideousLaughter.ToReference<BlueprintUnitFactReference>());
            UnitLists.CR3_CambionBard_Ranged.AlternativeBrains = new BlueprintBrainReference[0] { };
            UnitLists.CR3_CambionBard_Ranged.m_Brain = CambionCR3BardBrain.ToReference<BlueprintBrainReference>();



            HEContext.Logger.LogHeader("Updated CambionAbilities");

        }

        private static void CambionBuffs() {
            if (HEContext.Prebuffs.DemonBuffs.IsDisabled("CambionBuffs")) { return; }

            foreach (BlueprintUnit thisUnit in UnitLists.DemonCambionList) {
                // thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(BuffLists.DemonBuffLists.DemodandTarryBuffs);
            }

            foreach (BlueprintUnit thisUnit in UnitLists.CambionBards) {
                Utils.CustomHelpers.AddFactListsToUnit(thisUnit, BuffLists.BardBuffs);
            }

            HEContext.Logger.LogHeader("Updated CambionBuffs");
        }

    }
}
