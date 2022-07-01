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

namespace HarderEnemies.UnitModifications.Demons.DemondandStringy {
    internal class DemodandStringyAdjust {




        private static BlueprintFeature SuperToughness = BlueprintTools.GetModBlueprint<BlueprintFeature>(HEContext, "SuperToughnessFeature");

        public static void Handler() {
            AdjustHP();
            DemodandStringyAbilities();
            DemodandStringyBuffs();
        }

        private static void AdjustHP() {
            if (HEContext.HPChanges.HPBoosts.IsDisabled("AdjustDemonsHp")) { return; }

            foreach (BlueprintUnit thisUnit in UnitLists.DemodandStringyList) {
                thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(SuperToughness.ToReference<BlueprintUnitFactReference>());
            }
            HEContext.Logger.LogHeader("Adjusted Demons HP");
        }

        private static void DemodandStringyAbilities() {
            if (HEContext.AbilityChanges.DemonChanges.IsDisabled("DemodandStringyAbilities")) { return; }
            HEContext.Logger.LogHeader("Updated DemodandStringyAbilities");
        }

        private static void DemodandStringyBuffs() {
            if (HEContext.Prebuffs.DemonBuffs.IsDisabled("DemodandStringyBuffs")) { return; }

            foreach (BlueprintUnit thisUnit in UnitLists.DemodandStringyList) {
                thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(BuffLists.DemodandStringyBuffs);
            }
            HEContext.Logger.LogHeader("Updated DemodandStringyBuffs");
        }

    }
}
