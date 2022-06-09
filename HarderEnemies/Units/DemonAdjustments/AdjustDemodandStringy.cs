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
    internal class AdjustDemodandStringy {


        public static void DemodandStringyHandler() {
            DemodandStringyAbilities();
            DemodandStringyBuffs();
        }

        private static void DemodandStringyAbilities() {
            if (HEContext.AbilityChanges.DemonChanges.IsDisabled("DemodandStringyAbilities")) { return; }
            HEContext.Logger.LogHeader("Updated DemodandStringyAbilities");
        }

        private static void DemodandStringyBuffs() {
            if (HEContext.Prebuffs.DemonBuffs.IsDisabled("DemodandStringyBuffs")) { return; }
            
            foreach (BlueprintUnit thisUnit in Demons.DemodandStringyList) {
                thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(BuffLists.DemonBuffLists.DemodandStringyBuffs);
            }
            HEContext.Logger.LogHeader("Updated DemodandStringyBuffs");
        }

    }
}
