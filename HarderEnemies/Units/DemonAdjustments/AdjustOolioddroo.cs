﻿using Kingmaker.AI.Blueprints;
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
    internal class AdjustOolioddroo {


        public static void OoliodroHandler() {
            OolioddrooAbilities();
            OolioddrooBuffs();
        }

        private static void OolioddrooAbilities () {
            if (HEContext.AbilityChanges.DemonChanges.IsDisabled("OolioddrooAbilities")) { return; }
        }

        private static void OolioddrooBuffs() {
            if (HEContext.Prebuffs.DemonBuffs.IsDisabled("OolioddrooBuffs")) { return; }
            foreach (BlueprintUnit thisUnit in Demons.OolioddrooList) {
                thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(BuffLists.DemonBuffLists.OolioddrooBuffs);
            }
            HEContext.Logger.LogHeader("Updated Oolioddroo");
        }

    }
}
