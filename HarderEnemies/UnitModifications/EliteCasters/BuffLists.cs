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

namespace HarderEnemies.UnitModifications.EliteCasters {
    internal class BuffLists {

        public static BlueprintUnitFactReference[] EliteCasterBuffs =  {
            Buffs.MageArmorBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.MageShieldBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.FalseLifeGreaterbuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.BarkskinBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.BlurBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.WindsOfVengeanceBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.FrigtfulAspectBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.SeamantleBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.DeathWardBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.FreedomOfMovementBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.BloodHaze.ToReference<BlueprintUnitFactReference>(),
            Buffs.BoneShieldBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.MindBlankBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.TrueSeeingBuff.ToReference<BlueprintUnitFactReference>(),
            FeatureList.DR15.ToReference<BlueprintUnitFactReference>(),
            FeatureList.AscendentElementFire.ToReference<BlueprintUnitFactReference>(),
            FeatureList.AscendentElementCold.ToReference<BlueprintUnitFactReference>(),
            FeatureList.AscendentElementElectricity.ToReference<BlueprintUnitFactReference>(),
            FeatureList.Fortification50.ToReference<BlueprintUnitFactReference>(),
        };

        public static BlueprintUnitFactReference[] SemiEliteCasterBuffs =  {
            Buffs.MageArmorBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.MageShieldBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.FalseLifeGreaterbuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.BarkskinBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.BlurBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.WindsOfVengeanceBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.FrigtfulAspectBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.SeamantleBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.DeathWardBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.FreedomOfMovementBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.TrueSeeingBuff.ToReference<BlueprintUnitFactReference>(),
            FeatureList.DR5.ToReference<BlueprintUnitFactReference>(),
        };

    }
}
