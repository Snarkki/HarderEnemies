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

namespace HarderEnemies.UnitModifications.Cultists.MeleeCasters {
    internal class BuffLists {

        public static BlueprintUnitFactReference[] LowLevelClericBuffs = {
            Buffs.ShielfOfFaithBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.ResistFireBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.BullsStrengthBuff.ToReference<BlueprintUnitFactReference>(),
            };
        // max cast lvl3
        public static BlueprintUnitFactReference[] CR6ClericBuffs = {
            Buffs.ShielfOfFaithBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.ResistFireBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.BullsStrengthBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.AidBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.ArchonsAuraBuff.ToReference<BlueprintUnitFactReference>(),
            };
        // Max cast lvl4
        public static BlueprintUnitFactReference[] CR8ClericBuffs = {
            Buffs.ShielfOfFaithBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.ResistFireBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.BullsStrengthBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.ArchonsAuraBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.MagicalVestmentArmorBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.MagicWeaponGreaterPrimaryBuff.ToReference<BlueprintUnitFactReference>(),
            };

        public static BlueprintUnitFactReference[] HighLevelClericBuffs = {
            Buffs.ShielfOfFaithBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.ResistFireBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.BullsStrengthBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.ArchonsAuraBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.MagicalVestmentArmorBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.MagicWeaponGreaterPrimaryBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.DivinePowerBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.DeathWardBuff.ToReference<BlueprintUnitFactReference>(),
            };
    }
}
