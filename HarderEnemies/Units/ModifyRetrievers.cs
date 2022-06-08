using Kingmaker.Blueprints;
using Kingmaker.Blueprints.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TabletopTweaks.Core.Utilities;
using HarderEnemies.Blueprints;
using static HarderEnemies.Main;


namespace HarderEnemies.Units {
    public class ModifyRetrievers {
        private static BlueprintFeature SuperToughness = BlueprintTools.GetModBlueprint<BlueprintFeature>(HEContext, "SuperToughnessFeature");
        public static void HandleChanges() {
            AdjustHP();
            EditExisting();
        }

        private static void AdjustHP() {
            if (HEContext.HPChanges.HPBoosts.IsDisabled("AdjustRetrieverHp")) { return; }

            foreach (BlueprintUnit thisUnit in Retrievers.RetrieverList) {
                thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(SuperToughness.ToReference<BlueprintUnitFactReference>());
            }
            HEContext.Logger.LogHeader("Adjusted Retriever HP");
        }


        private static void EditExisting() {


            foreach (BlueprintUnit thisUnit in Retrievers.RetrieverList) {
                thisUnit.m_AddFacts = thisUnit.m_AddFacts.RemoveFromArray(FeatureList.ElectricityImmunity.ToReference<BlueprintUnitFactReference>());
                if (thisUnit.CR >= 0 && thisUnit.CR <= 10) {
                    thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(SuperToughness.ToReference<BlueprintUnitFactReference>());
                    thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(FeatureList.Fortification25.ToReference<BlueprintUnitFactReference>());
                    thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(FeatureList.DR5.ToReference<BlueprintUnitFactReference>());
                }
                else if (thisUnit.CR >= 11 && thisUnit.CR <= 15) {
                    thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(SuperToughness.ToReference<BlueprintUnitFactReference>());
                    thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(FeatureList.Fortification50.ToReference<BlueprintUnitFactReference>());
                    thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(FeatureList.DR10.ToReference<BlueprintUnitFactReference>());
                }
                else {
                    thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(SuperToughness.ToReference<BlueprintUnitFactReference>());
                    thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(FeatureList.Fortification50.ToReference<BlueprintUnitFactReference>());
                    thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(FeatureList.DR15.ToReference<BlueprintUnitFactReference>());
                }
            }
            HEContext.Logger.LogHeader("Updated retriever ");
        }

        private static void EditExisting() {


            foreach (BlueprintUnit thisUnit in Retrievers.RetrieverList) {
                thisUnit.m_AddFacts = thisUnit.m_AddFacts.RemoveFromArray(FeatureList.ElectricityImmunity.ToReference<BlueprintUnitFactReference>());
                if (thisUnit.CR >= 0 && thisUnit.CR <= 10) {
                    thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(SuperToughness.ToReference<BlueprintUnitFactReference>());
                    thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(FeatureList.Fortification25.ToReference<BlueprintUnitFactReference>());
                    thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(FeatureList.DR5.ToReference<BlueprintUnitFactReference>());
                } else if (thisUnit.CR >= 11 && thisUnit.CR <= 15) {
                    thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(SuperToughness.ToReference<BlueprintUnitFactReference>());
                    thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(FeatureList.Fortification50.ToReference<BlueprintUnitFactReference>());
                    thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(FeatureList.DR10.ToReference<BlueprintUnitFactReference>());
                } else {
                    thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(SuperToughness.ToReference<BlueprintUnitFactReference>());
                    thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(FeatureList.Fortification50.ToReference<BlueprintUnitFactReference>());
                    thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(FeatureList.DR15.ToReference<BlueprintUnitFactReference>());
                }
            }
            HEContext.Logger.LogHeader("Updated retriever ");
        }

    }
}
