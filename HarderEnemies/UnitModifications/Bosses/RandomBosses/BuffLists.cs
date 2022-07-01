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

namespace HarderEnemies.UnitModifications.Bosses.RandomBosses {
    internal class BuffLists {


     

        public static BlueprintUnitFactReference[] MauglaBuffs = {
            Buffs.MageArmorBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.MageShieldBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.ProtectionFromArrowsBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.StoneskinBuff.ToReference<BlueprintUnitFactReference>()
        };
        // MULTIPLE UNITS, NOT ONLY MUTAFASEN
        public static BlueprintUnitFactReference[] MutasafenGangBuffs = {
            Buffs.DeathWardBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.FreedomOfMovementBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.BarkskinBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.MageShieldBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.HasteBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.StoneskinBuff.ToReference<BlueprintUnitFactReference>()
        };


        public static BlueprintUnitFactReference[] XanthirBuffs = {
            Buffs.FrigtfulAspectBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.SeamantleBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.DeathWardBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.FreedomOfMovementBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.BarkskinBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.MindBlankBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.TrueSeeingBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.MageShieldBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.StoneskinBuff.ToReference<BlueprintUnitFactReference>(),
        };


    }
}
