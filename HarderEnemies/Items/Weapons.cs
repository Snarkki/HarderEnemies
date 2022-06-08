using Kingmaker.Blueprints;
using TabletopTweaks.Core.Utilities;
using static HarderEnemies.Main;
using HarderEnemies.Blueprints;


namespace HarderEnemies.Items {
    public class Weapons {

        public static void CreateNewWeapons() {
            CreateBalorSword();
            CreateHolyEvilBane5Sword();
        }

        public static void CreateBalorSword() {

            var BalorNewSword = ItemAndEnchs.LongswordUnholyPlus1.CreateCopy(HEContext, "BalorNewSword", bp => {
                bp.m_Enchantments = new BlueprintWeaponEnchantmentReference[] {
                    ItemAndEnchs.Enhancement5.ToReference<BlueprintWeaponEnchantmentReference>(),
                    ItemAndEnchs.Unholy.ToReference<BlueprintWeaponEnchantmentReference>()
                };
            });
        }

        public static void CreateHolyEvilBane5Sword() {

            var HolyEvilBane5Sword = ItemAndEnchs.ColdIronLongswordHolyEvilOutsiderBanePlus2.CreateCopy(HEContext, "HolyEvilBane5Sword", bp => {
                bp.m_Enchantments = new BlueprintWeaponEnchantmentReference[] {
                    ItemAndEnchs.Enhancement5.ToReference<BlueprintWeaponEnchantmentReference>(),
                    ItemAndEnchs.Holy.ToReference<BlueprintWeaponEnchantmentReference>(),
                    ItemAndEnchs.Speed.ToReference<BlueprintWeaponEnchantmentReference>(),
                    ItemAndEnchs.BaneOutsiderEvil.ToReference<BlueprintWeaponEnchantmentReference>(),
                    ItemAndEnchs.ColdIron.ToReference<BlueprintWeaponEnchantmentReference>(),
                };
            });

        }

    }
}
