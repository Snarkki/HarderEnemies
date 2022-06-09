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

namespace HarderEnemies.Units.Adjustments {
    internal class AdjustCorruptedAngels {


        private static BlueprintItemWeapon HolyEvilBane5Sword = BlueprintTools.GetModBlueprint<BlueprintItemWeapon>(HEContext, "HolyEvilBane5Sword");


        public static void HandleCorruptedAngels() {
            CorruptedAngelAbilities();
            CorruptedAngelBuffs();
        }

        private static void CorruptedAngelAbilities() {
            if (HEContext.AbilityChanges.BossChanges.IsDisabled("CorruptedAngelChanges")) { return; }
            foreach (BlueprintUnit thisUnit in Bosses.CorruptHeraldsList) {
                thisUnit.Body.m_PrimaryHand = HolyEvilBane5Sword.ToReference<BlueprintItemEquipmentHandReference>();
                Utils.CustomHelpers.AddFactListsToUnit(thisUnit, thisUnit.CR, BuffLists.BossBuffLists.CorruptedAngelAbilities);

            }
            HEContext.Logger.LogHeader("Updated Corrupted Heralds");
        }

        private static void CorruptedAngelBuffs() {
            if (HEContext.Prebuffs.BossBuffs.IsDisabled("CorruptedAngelBuffs")) { return; }

            foreach (BlueprintUnit thisUnit in Bosses.CorruptHeraldsList) {
                Utils.CustomHelpers.AddFactListsToUnit(thisUnit, thisUnit.CR, BuffLists.BossBuffLists.CorruptedAngelBuffs);
            }
            HEContext.Logger.LogHeader("Updated Corrupted Heralds");
        }

    }
}
