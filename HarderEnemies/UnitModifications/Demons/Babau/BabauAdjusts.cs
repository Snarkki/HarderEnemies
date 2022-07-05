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

namespace HarderEnemies.UnitModifications.Demons.Babau {
    internal class BabauAdjusts {

        private static BlueprintFeature SuperToughness = BlueprintTools.GetModBlueprint<BlueprintFeature>(HEContext, "SuperToughnessFeature");

        public static void Handler() {
            BabauAbilities();
            BabauBuffs();
            AdjustHP();
        }

        private static void AdjustHP() {
            if (HEContext.HPChanges.HPBoosts.IsDisabled("AdjustDemonsHp")) { return; }

            foreach (BlueprintUnit thisUnit in UnitLists.DemonBabauList) {
                thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(SuperToughness.ToReference<BlueprintUnitFactReference>());
            }
            HEContext.Logger.LogHeader("Adjusted Demons HP");
        }

        private static void BabauAbilities() {
            if (HEContext.AbilityChanges.DemonChanges.IsDisabled("BabauAbilities")) { return; }
            foreach (BlueprintUnit thisUnit in UnitLists.DemonBabauList) {
                // get rid of dispellers
                thisUnit.m_Brain = BrainList.DumbBrain.ToReference<BlueprintBrainReference>();
                thisUnit.AlternativeBrains = new BlueprintBrainReference[0] { };
                if (thisUnit.CR > 6) {
                    // Adds outflank & dispelling strike
                    thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(AbilityLists.BabauAbilities);
                }
            }
            HEContext.Logger.LogHeader("Updated Babau Abilities");

        }

        private static void BabauBuffs() {
            if (HEContext.Prebuffs.DemonBuffs.IsDisabled("BabauBuffs")) { return; }
            foreach (BlueprintUnit thisUnit in UnitLists.DemonBabauList) {
                Utils.CustomHelpers.AddFactListsToUnit(thisUnit, thisUnit.CR, BuffLists.BabauBuffs);
            }
            HEContext.Logger.LogHeader("Updated BabauBuffs");
        }

    }
}
