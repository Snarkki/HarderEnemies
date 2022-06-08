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
using static HarderEnemies.Main;
using Kingmaker.Blueprints.Items.Weapons;

namespace HarderEnemies.Units {
    public class ModifyAngels {

        private static BlueprintFeature SuperToughness = BlueprintTools.GetModBlueprint<BlueprintFeature>(HEContext, "SuperToughnessFeature");
        //Holy+5 weapons
        private static BlueprintItemWeapon HolyEvilBane5Sword = BlueprintTools.GetModBlueprint<BlueprintItemWeapon>(HEContext, "HolyEvilBane5Sword");
        public static void HandleChanges() {
            ModifyAngels.AdjustHP();
            ModifyAngels.AngelAbilities();
            ModifyAngels.AngelBuffs();
        }

        private static void AdjustHP() {
            if (HEContext.HPChanges.HPBoosts.IsDisabled("AdjustAngelHp")) { return; }

            foreach (BlueprintUnit thisUnit in Lists.Angels.AngelsList) {
                thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(SuperToughness.ToReference<BlueprintUnitFactReference>());
            }
            HEContext.Logger.LogHeader("Adjusted Angel HP");
        }

        public static void AngelAbilities() {

            if (HEContext.AbilityChanges.OtherChanges.IsDisabled("AngelChanges")) { return; }

            foreach (BlueprintUnit thisUnit in Lists.Angels.AngelsList) {
                thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(SuperToughness.ToReference<BlueprintUnitFactReference>());
                thisUnit.Body.m_PrimaryHand = HolyEvilBane5Sword.ToReference<BlueprintItemEquipmentHandReference>();
                thisUnit.AddComponent<AddStatBonus>(c => {
                    c.Stat = Kingmaker.EntitySystem.Stats.StatType.HitPoints;
                    c.Value = 200;
                });
            }
        }
        public static void AngelBuffs() {

            if (HEContext.Prebuffs.OtherBuffs.IsDisabled("AngelBuffs")) { return; }

            foreach (BlueprintUnit thisUnit in Lists.Angels.AngelsList) {
                thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(SuperToughness.ToReference<BlueprintUnitFactReference>());
                thisUnit.Body.m_PrimaryHand = HolyEvilBane5Sword.ToReference<BlueprintItemEquipmentHandReference>();
                thisUnit.AddComponent<AddStatBonus>(c => {
                    c.Stat = Kingmaker.EntitySystem.Stats.StatType.HitPoints;
                    c.Value = 200;
                });
            }
        }


    }
}

