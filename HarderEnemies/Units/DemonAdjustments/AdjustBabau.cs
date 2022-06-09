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
    internal class AdjustBabau {




        public static void BabauHandler() {
            BabauAbilities();
            BabauBuffs();
        }

        private static void BabauAbilities() {
            if (HEContext.AbilityChanges.DemonChanges.IsDisabled("BabauAbilities")) { return; }
            foreach (BlueprintUnit thisUnit in Demons.DemonBabauList) {
                // get rid of dispellers
                thisUnit.AlternativeBrains = new BlueprintBrainReference[] { };
                if (thisUnit.CR > 6) {
                    // Adds outflank & dispelling strike
                    thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(BuffLists.DemonBuffLists.BabauAbilities);
                }
            }


        }

        private static void BabauBuffs() {
            if (HEContext.Prebuffs.DemonBuffs.IsDisabled("BabauBuffs")) { return; }
            foreach (BlueprintUnit thisUnit in Demons.DemonBabauList) {

            }
            HEContext.Logger.LogHeader("Updated Oolioddroo");
        }

    }
}
