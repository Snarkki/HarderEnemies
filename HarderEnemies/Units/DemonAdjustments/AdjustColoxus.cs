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
    internal class AdjustColoxus {


        public static void ColoxaiHandler() {
            ColoxaiAbilities();
            ColoxaiBuffs();
        }

        private static void ColoxaiAbilities() {
            if (HEContext.AbilityChanges.DemonChanges.IsDisabled("ColoxusAbilities")) { return; }
        }

        private static void ColoxaiBuffs() {
            if (HEContext.Prebuffs.DemonBuffs.IsDisabled("ColoxusBuffs")) { return; }
            
            foreach (BlueprintUnit thisUnit in Demons.DemonColoxusList) {
                thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(BuffLists.DemonBuffLists.ColoxusBuffs);
            }
            HEContext.Logger.LogHeader("Updated ColoxusList");
        }

    }
}
