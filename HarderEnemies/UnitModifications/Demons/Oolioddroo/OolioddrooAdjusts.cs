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

namespace HarderEnemies.UnitModifications.Demons.Oolioddroo {
    internal class OolioddrooAdjusts {




        private static BlueprintFeature SuperToughness = BlueprintTools.GetModBlueprint<BlueprintFeature>(HEContext, "SuperToughnessFeature");
        public static void Handler() {
            AdjustHP();
            OolioddrooAbilities();
            OolioddrooBuffs();
        }

        private static void AdjustHP() {
            if (HEContext.HPChanges.HPBoosts.IsDisabled("AdjustDemonsHp")) { return; }

            foreach (BlueprintUnit thisUnit in UnitLists.OolioddrooList) {
                thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(SuperToughness.ToReference<BlueprintUnitFactReference>());
            }
            HEContext.Logger.LogHeader("Adjusted Demons HP");
        }

        private static void OolioddrooAbilities() {
            if (HEContext.AbilityChanges.DemonChanges.IsDisabled("OolioddrooAbilities")) { return; }

            "aivot ja abilityt kuntoon"

        }

        private static void OolioddrooBuffs() {
            if (HEContext.Prebuffs.DemonBuffs.IsDisabled("OolioddrooBuffs")) { return; }
            foreach (BlueprintUnit thisUnit in UnitLists.OolioddrooList) {
                thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(BuffLists.OolioddrooBuffs);
            }
            HEContext.Logger.LogHeader("Updated Oolioddroo");
        }

    }
}
