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

namespace HarderEnemies.UnitModifications.Demons.Abrikandilu {
    internal class AbrikandiluAdjusts {

        private static BlueprintFeature SuperToughness = BlueprintTools.GetModBlueprint<BlueprintFeature>(HEContext, "SuperToughnessFeature");
        private static BlueprintBrain AbrikandiluBrain = BlueprintTools.GetModBlueprint<BlueprintBrain>(HEContext, "AbrikandiluBrain");

        public static void Handler() {
            AdjustHP();
            AbrikandiluAbilities();
            AbrikandiluBuffs();
        }

        private static void AdjustHP() {
            if (HEContext.HPChanges.HPBoosts.IsDisabled("AdjustDemonsHp")) { return; }

            foreach (BlueprintUnit thisUnit in UnitLists.DemonAbrikandiluList) {
                thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(SuperToughness.ToReference<BlueprintUnitFactReference>());
            }
            HEContext.Logger.LogHeader("Adjusted Demons HP");
        }

        private static void AbrikandiluAbilities() {
            if (HEContext.AbilityChanges.DemonChanges.IsDisabled("AbrikandiluAbilities")) { return; }
            foreach (BlueprintUnit thisUnit in UnitLists.DemonAbrikandiluList) {
                Utils.CustomHelpers.AddFactsToUnit(thisUnit, AbilityLists.AbrikanduAbilities);
                thisUnit.AlternativeBrains = new BlueprintBrainReference[0] { };
                thisUnit.m_Brain = AbrikandiluBrain.ToReference<BlueprintBrainReference>();
            }
            HEContext.Logger.LogHeader("Updated Abrikandilu abilities");
        }

        private static void AbrikandiluBuffs() {
            if (HEContext.Prebuffs.DemonBuffs.IsDisabled("AbrikandiluBuffs")) { return; }
            foreach (BlueprintUnit thisUnit in UnitLists.DemonAbrikandiluList) {
                Utils.CustomHelpers.AddFactListsToUnit(thisUnit, thisUnit.CR + 8, BuffLists.AbrikanduBuffs);
            }
            HEContext.Logger.LogHeader("Updated Abrikandilu buffs");
        }

    }
}
