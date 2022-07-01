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
using HarderEnemies.Blueprints;
using static HarderEnemies.Main;

namespace HarderEnemies.UnitModifications.Bosses.Balors {
    internal class BuffLists {

        public static BlueprintUnitFactReference[] BalorBuffsList = {
            Buffs.MageShieldBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.HeroismGreaterBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.FalseLifeGreaterbuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.BarkskinBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.BlurBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.WindsOfVengeanceBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.FrigtfulAspectBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.SeamantleBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.DeathWardBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.FreedomOfMovementBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.MindBlankBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.TrueSeeingBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.ResistAcidBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.ResistFireBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.FieryBodyBuff.ToReference<BlueprintUnitFactReference>(),
        };
    }
}
