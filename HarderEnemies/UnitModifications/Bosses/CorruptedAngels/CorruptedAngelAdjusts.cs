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
using Kingmaker.Blueprints.Items.Weapons;

namespace HarderEnemies.UnitModifications.Bosses.CorruptedAngels {
    internal class CorruptedAngelAdjusts {

        private static BlueprintItemWeapon HolyEvilBane5Sword = BlueprintTools.GetModBlueprint<BlueprintItemWeapon>(HEContext, "HolyEvilBane5Sword");
        private static BlueprintFeature AbyssalToughnessFeature = BlueprintTools.GetModBlueprint<BlueprintFeature>(HEContext, "AbyssalToughnessFeature");

        public static void Handler() {
            HandleHPBuff();
            CorruptedAngelAbilities();
            CorruptedAngelBuffs();
        }

        private static void HandleHPBuff() {
            //Adjust HP if enabled
            if (!HEContext.HPChanges.HPBoosts.IsDisabled("AdjustBossHp")) {
                foreach (BlueprintUnit thisUnit in UnitLists.CorruptHeraldsList) {
                    thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(AbyssalToughnessFeature.ToReference<BlueprintUnitFactReference>());
                }
            }
        }

        private static void CorruptedAngelAbilities() {
            if (HEContext.AbilityChanges.BossChanges.IsDisabled("CorruptedAngelChanges")) { return; }
            foreach (BlueprintUnit thisUnit in UnitLists.CorruptHeraldsList) {
                thisUnit.Body.m_PrimaryHand = HolyEvilBane5Sword.ToReference<BlueprintItemEquipmentHandReference>();
                Utils.CustomHelpers.AddFactsToUnit(thisUnit, AbilityLists.CorruptedAngelAbilities);

            }
            HEContext.Logger.LogHeader("Updated Corrupted Heralds");
        }

        private static void CorruptedAngelBuffs() {
            if (HEContext.Prebuffs.BossBuffs.IsDisabled("CorruptedAngelBuffs")) { return; }

            foreach (BlueprintUnit thisUnit in UnitLists.CorruptHeraldsList) {
                Utils.CustomHelpers.AddFactListsToUnit(thisUnit, BuffLists.CorruptedAngelBuffs);
            }
            HEContext.Logger.LogHeader("Updated Corrupted Heralds");
        }

    }
}
