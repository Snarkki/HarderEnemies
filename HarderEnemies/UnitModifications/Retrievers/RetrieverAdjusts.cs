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

namespace HarderEnemies.UnitModifications.Retrievers {
    internal class RetrieverAdjusts {


        private static BlueprintFeature SuperToughness = BlueprintTools.GetModBlueprint<BlueprintFeature>(HEContext, "SuperToughnessFeature");
        private static BlueprintBrain DevastatorNewStandardBrain = BlueprintTools.GetModBlueprint<BlueprintBrain>(HEContext, "DevastatorNewStandardBrain");
        public static void Handler() {
            AdjustHP();
            HandleRetrieverAbilities();
            HandleRetrieverBuffs();
        }

        private static void AdjustHP() {
            if (HEContext.HPChanges.HPBoosts.IsDisabled("AdjustRetrieverHp")) { return; }

            foreach (BlueprintUnit thisUnit in UnitLists.RetrieverList) {
                thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(SuperToughness.ToReference<BlueprintUnitFactReference>());
            }
            foreach (BlueprintUnit thisUnit in UnitLists.DevastatorList) {
                thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(SuperToughness.ToReference<BlueprintUnitFactReference>());
            }

            HEContext.Logger.LogHeader("Adjusted Retriever/Devastator HP");
        }


        private static void HandleRetrieverAbilities() {
            if (HEContext.AbilityChanges.OtherChanges.IsDisabled("RetrieverChanges")) { return; }

            foreach (BlueprintUnit thisUnit in UnitLists.RetrieverList) {
                thisUnit.m_AddFacts = thisUnit.m_AddFacts.RemoveFromArray(FeatureList.ElectricityImmunity.ToReference<BlueprintUnitFactReference>());
                if (thisUnit.CR >= 0 && thisUnit.CR <= 10) {
                    thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(FeatureList.Fortification25.ToReference<BlueprintUnitFactReference>());
                    thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(FeatureList.DR5.ToReference<BlueprintUnitFactReference>());
                } else if (thisUnit.CR >= 11 && thisUnit.CR <= 15) {
                    thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(FeatureList.Fortification50.ToReference<BlueprintUnitFactReference>());
                    thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(FeatureList.DR10.ToReference<BlueprintUnitFactReference>());
                } else {
                    thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(FeatureList.Fortification50.ToReference<BlueprintUnitFactReference>());
                    thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(FeatureList.DR15.ToReference<BlueprintUnitFactReference>());
                }
            }

            foreach (BlueprintUnit thisUnit in UnitLists.DevastatorList) {
                thisUnit.m_Brain = DevastatorNewStandardBrain.ToReference<BlueprintBrainReference>();
            }
            HEContext.Logger.LogHeader("Updated retriever abilities");
        }

        private static void HandleRetrieverBuffs() {
            if (HEContext.Prebuffs.OtherBuffs.IsDisabled("RetrieverBuffs")) { return; }

            foreach (BlueprintUnit thisUnit in UnitLists.RetrieverList) {

            }
            HEContext.Logger.LogHeader("Updated retriever buffs");
        }

    }
}
