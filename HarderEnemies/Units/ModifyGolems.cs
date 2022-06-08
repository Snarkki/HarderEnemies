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
    public class ModifyGolems {

        private static BlueprintFeature SuperToughness = BlueprintTools.GetModBlueprint<BlueprintFeature>(HEContext, "SuperToughnessFeature");

        public static void HandleChanges() {
            AdjustHP();
            HandleGolemAbilities();
            HandleGolemAbilities();
        }

        private static void AdjustHP() {
            if (HEContext.HPChanges.HPBoosts.IsDisabled("AdjustGolemHp")) { return; }

            foreach (BlueprintUnit thisUnit in Golems.GolemList) {
                thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(SuperToughness.ToReference<BlueprintUnitFactReference>());
            }
            HEContext.Logger.LogHeader("Adjusted Golem HP");
        }

        private static void HandleGolemAbilities() {


            foreach (BlueprintUnit thisUnit in Golems.GolemList) {
                if (thisUnit.CR >= 0 && thisUnit.CR <= 15) {
                    thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(FeatureList.DR15.ToReference<BlueprintUnitFactReference>());
                }
                else {
                    thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(FeatureList.DR30.ToReference<BlueprintUnitFactReference>());
                }
            }
            HEContext.Logger.LogHeader("Updated Golems Abilities");
        }

        private static void HandleGolemBuffs() {


            foreach (BlueprintUnit thisUnit in Golems.GolemList) {

            }
            HEContext.Logger.LogHeader("Updated Golems Buffs");
        }

    }
}
