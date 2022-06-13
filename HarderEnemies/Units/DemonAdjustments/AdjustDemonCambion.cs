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
using static HarderEnemies.Main;
using HarderEnemies.Blueprints;
using Kingmaker.Blueprints.Items.Weapons;
using Kingmaker.UnitLogic.Abilities.Blueprints;
using Kingmaker.Designers.Mechanics.Facts;
using Kingmaker.UnitLogic.Abilities.Components;
using Kingmaker.UnitLogic.Mechanics.Actions;

namespace HarderEnemies.Units.DemonAdjustments {
    internal class AdjustDemonCambion {

        private static BlueprintBrain CambionRangedBrain = BlueprintTools.GetModBlueprint<BlueprintBrain>(HEContext, "CambionRangedBrain");
        public static void CambionHandler() {
            CambionAbilities();
            CambionBuffs();
        }

        private static void CambionAbilities() {
            if (HEContext.AbilityChanges.DemonChanges.IsDisabled("CambionAbilities")) { return; }
            foreach (BlueprintUnit thisUnit in Demons.DemonCambionList) {
                //thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(BuffLists.DemonBuffLists.Cam);
            }

            foreach (BlueprintUnit thisUnit in Demons.DemonRangedCambionList) {
                thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(BuffLists.DemonBuffLists.CambionRangedAbilities);
                thisUnit.m_Brain = CambionRangedBrain.ToReference<BlueprintBrainReference>();
            }

            HEContext.Logger.LogHeader("Updated CambionAbilities");

        }

        private static void CambionBuffs() {
            if (HEContext.Prebuffs.DemonBuffs.IsDisabled("CambionBuffs")) { return; }

            foreach (BlueprintUnit thisUnit in Demons.DemonCambionList) {
               // thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(BuffLists.DemonBuffLists.DemodandTarryBuffs);
            }

            HEContext.Logger.LogHeader("Updated CambionBuffs");
        }

    }
}
