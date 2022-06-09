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
    internal class AdjustAbrikandilu {

        public static void AbrikandilHandler() {
            AbrikandiluAbilities();
            AbrikandiluBuffs();
        }

        private static void AbrikandiluAbilities() {
            if (HEContext.AbilityChanges.DemonChanges.IsDisabled("AbrikandiluAbilities")) { return; }
            foreach (BlueprintUnit thisUnit in Demons.DemonAbrikandiluList) {
                Utils.CustomHelpers.AddFactListsToUnit(thisUnit, thisUnit.CR, BuffLists.DemonBuffLists.AbrikanduAbilities);
            }
            HEContext.Logger.LogHeader("Updated Abrikandilu abilities");
        }

        private static void AbrikandiluBuffs() {
            if (HEContext.Prebuffs.DemonBuffs.IsDisabled("AbrikandiluBuffs")) { return; }
            foreach (BlueprintUnit thisUnit in Demons.DemonAbrikandiluList) {
                Utils.CustomHelpers.AddFactListsToUnit(thisUnit, thisUnit.CR, BuffLists.DemonBuffLists.AbrikanduBuffs);
            }
            HEContext.Logger.LogHeader("Updated Abrikandilu buffs");
        }

    }
}
