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

namespace HarderEnemies.UnitModifications.Demons.Cambion {
    internal class BuffLists {

        public static BlueprintUnitFactReference[] BardBuffs = {
            Buffs.SenseVitalsBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.BlurBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.EaglesSplendorBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.CatsGraceBuff.ToReference<BlueprintUnitFactReference>(),
        };
    }
}
