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

            foreach (BlueprintUnit thisUnit in UnitLists.DemonRangedCambionList) {
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

            HEContext.Logger.LogHeader("Updated CambionAbilities");

        }

        private static void CambionBuffs() {
            if (HEContext.Prebuffs.DemonBuffs.IsDisabled("CambionBuffs")) { return; }

            foreach (BlueprintUnit thisUnit in UnitLists.DemonCambionList) {
                // thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(BuffLists.DemonBuffLists.DemodandTarryBuffs);
            }

            HEContext.Logger.LogHeader("Updated CambionBuffs");
        }

    }
}
