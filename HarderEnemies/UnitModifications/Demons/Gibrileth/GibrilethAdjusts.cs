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

namespace HarderEnemies.UnitModifications.Demons.Gibrileth {
    internal class GibrilethAdjusts {

        private static BlueprintFeature SuperToughness = BlueprintTools.GetModBlueprint<BlueprintFeature>(HEContext, "SuperToughnessFeature");
        private static BlueprintBrain LowLevelGibrilithBrain = BlueprintTools.GetModBlueprint<BlueprintBrain>(HEContext, "LowLevelGibrilithBrain");
        private static BlueprintBrain HighLevelGibrilithBrain = BlueprintTools.GetModBlueprint<BlueprintBrain>(HEContext, "HighLevelGibrilithBrain");


        public static void Handler() {
            AdjustHP();
            GibrilethAbilities();
            GibrilethBuffs();
        }

        private static void AdjustHP() {
            if (HEContext.HPChanges.HPBoosts.IsDisabled("AdjustDemonsHp")) { return; }

            foreach (BlueprintUnit thisUnit in UnitLists.DemonGibrilethList) {
                thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(SuperToughness.ToReference<BlueprintUnitFactReference>());
            }
            HEContext.Logger.LogHeader("Adjusted Demons HP");
        }

        private static void GibrilethAbilities() {
            if (HEContext.AbilityChanges.DemonChanges.IsDisabled("GibrilethAbilities")) { return; }

            // split to two groups, both acid based damage and some control abilities
            foreach (BlueprintUnit thisUnit in UnitLists.LowLevelGibrilethList) {
                Utils.CustomHelpers.AddFactsToUnit(thisUnit, AbilityLists.LowLevelGibrilethAbilities);
                thisUnit.m_Brain = LowLevelGibrilithBrain.ToReference<BlueprintBrainReference>();
                thisUnit.AlternativeBrains = new BlueprintBrainReference[0] { };
            }

            foreach (BlueprintUnit thisUnit in UnitLists.HighLevellGibrilethList) {
                Utils.CustomHelpers.AddFactsToUnit(thisUnit, AbilityLists.HighLevelGibrilethAbilities);
                thisUnit.m_Brain = HighLevelGibrilithBrain.ToReference<BlueprintBrainReference>();
                thisUnit.AlternativeBrains = new BlueprintBrainReference[0] { };
            }

            HEContext.Logger.LogHeader("Updated GibrilethListAbililties");
        }

        private static void GibrilethBuffs() {
            if (HEContext.Prebuffs.DemonBuffs.IsDisabled("GibrilethBuffs")) { return; }

            foreach (BlueprintUnit thisUnit in UnitLists.DemonGibrilethList) {
                thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(BuffLists.GibrilithBuffs);
            }

            HEContext.Logger.LogHeader("Updated GibrilethListBuuffs");
        }

    }
}
