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

namespace HarderEnemies.UnitModifications.Demons.Marileth {
    internal class MarilethAdjusts {

        private static BlueprintBrain StandardMarilithBrain = BlueprintTools.GetModBlueprint<BlueprintBrain>(HEContext, "StandardMarilithBrain");
        private static BlueprintBrain SlayerMarilithBrain = BlueprintTools.GetModBlueprint<BlueprintBrain>(HEContext, "SlayerMarilithBrain");
        private static BlueprintFeature SuperToughness = BlueprintTools.GetModBlueprint<BlueprintFeature>(HEContext, "SuperToughnessFeature");

        public static void Handler() {
            AdjustHP();
            MarilithAbilities();
            MarilithBuffs();
        }

        private static void AdjustHP() {
            if (HEContext.HPChanges.HPBoosts.IsDisabled("AdjustDemonsHp")) { return; }

            foreach (BlueprintUnit thisUnit in UnitLists.DemonMarilithList) {
                thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(SuperToughness.ToReference<BlueprintUnitFactReference>());
            }
            HEContext.Logger.LogHeader("Adjusted Marilith  HP");
        }

        private static void MarilithAbilities() {
            if (HEContext.AbilityChanges.DemonChanges.IsDisabled("MarilithAbilities")) { return; }

            foreach (BlueprintUnit thisUnit in UnitLists.MarilithStandardList) {
                //Utils.CustomHelpers.AddFactsToUnit(thisUnit, AbilityLists.AdvancedGlabrezuAbilities);
                thisUnit.m_Brain = StandardMarilithBrain.ToReference<BlueprintBrainReference>();
                thisUnit.AlternativeBrains = new BlueprintBrainReference[0] { };
            }

            foreach (BlueprintUnit thisUnit in UnitLists.MarilithSlayerList) {
                thisUnit.m_Brain = SlayerMarilithBrain.ToReference<BlueprintBrainReference>();
                thisUnit.AlternativeBrains = new BlueprintBrainReference[0] { };
            }
        }

        private static void MarilithBuffs() {
            if (HEContext.Prebuffs.DemonBuffs.IsDisabled("MarilithBuffs")) { return; }

            foreach (BlueprintUnit thisUnit in UnitLists.DemonMarilithList) {
                thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(BuffLists.MarilithBuffs);
            }
            HEContext.Logger.LogHeader("Updated Marilith Buffs");
        }

    }
}
