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

namespace HarderEnemies.UnitModifications.Bosses.Minagho {
    internal class BuffLists {

        public static BlueprintUnitFactReference[] MinaghoBuffs =  {
            Buffs.BarkskinBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.ShielfOfFaithBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.MageShieldBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.StoneskinBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.MindBlankBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.TrueSeeingBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.DeadlyBeauty.ToReference<BlueprintUnitFactReference>(),
            Buffs.CloakofDreamsBuff.ToReference<BlueprintUnitFactReference>(),

        };
    }
}
