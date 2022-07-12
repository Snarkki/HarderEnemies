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

namespace HarderEnemies.UnitModifications.Dragons {
    internal class DragonAdjusts {


        private static BlueprintFeature AbyssalToughnessFeature = BlueprintTools.GetModBlueprint<BlueprintFeature>(HEContext, "AbyssalToughnessFeature");
        private static BlueprintBrain NewBlackDragonBrain = BlueprintTools.GetModBlueprint<BlueprintBrain>(HEContext, "NewBlackDragonBrain");



        public static void Handler() {
            AdjustHP();
            DragonAbilities();
            DragonBuffs();
            LesserDragonAbilities();
            LesserDragonBuffs();
        }

        private static void AdjustHP() {
            if (HEContext.HPChanges.HPBoosts.IsDisabled("AdjustDragonHp")) { return; }

            foreach (BlueprintUnit thisUnit in UnitLists.DragonList) {
                thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(AbyssalToughnessFeature.ToReference<BlueprintUnitFactReference>());
            }
            foreach (BlueprintUnit thisUnit in UnitLists.LesserDragonsList) {
                thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(AbyssalToughnessFeature.ToReference<BlueprintUnitFactReference>());
            }

            HEContext.Logger.LogHeader("Adjusted Dragon HP");
        }

        private static void DragonAbilities() {
            if (HEContext.AbilityChanges.OtherChanges.IsDisabled("DragonChanges")) { return; }

            foreach (BlueprintUnit thisUnit in UnitLists.DragonList) {
                Utils.CustomHelpers.AddFactsToUnit(thisUnit, AbilityLists.GreaterDragonAbilities);
            }
            UnitLists.CR16_BlackDragonAncient.m_Brain = NewBlackDragonBrain.ToReference<BlueprintBrainReference>();
        }

        private static void DragonBuffs() {
            if (HEContext.Prebuffs.OtherBuffs.IsDisabled("DragonBuffs")) { return; }
            foreach (BlueprintUnit thisUnit in UnitLists.DragonList) {
                Utils.CustomHelpers.AddFactListsToUnit(thisUnit, thisUnit.CR + 8, BuffLists.GreaterDragonBuffs);
            }
        }

        private static void LesserDragonAbilities() {
            if (HEContext.AbilityChanges.OtherChanges.IsDisabled("LesserDragonChanges")) { return; }
        }

        private static void LesserDragonBuffs() {
            if (HEContext.Prebuffs.OtherBuffs.IsDisabled("LesserDragonBuffs")) { return; }

            foreach (BlueprintUnit thisUnit in UnitLists.LesserDragonsList) {
                Utils.CustomHelpers.AddFactListsToUnit(thisUnit, 26, BuffLists.LesserDragonBuffs);

            }
            HEContext.Logger.LogHeader("Updated Dragons");
        }


    }
}

