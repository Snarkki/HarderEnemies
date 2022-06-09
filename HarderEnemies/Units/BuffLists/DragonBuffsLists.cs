using System;
using HarderEnemies.Features;
using Kingmaker.AI.Blueprints;
using Kingmaker.Blueprints;
using Kingmaker.Blueprints.Classes;
using Kingmaker.UnitLogic.Abilities.Blueprints;
using Kingmaker.UnitLogic.FactLogic;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TabletopTweaks.Core.Utilities;
using HarderEnemies.Blueprints;
using static HarderEnemies.Main;



namespace HarderEnemies.Units.BuffLists {

    internal class DragonBuffsLists {
        private static BlueprintFeature SuperiorQuickenMetaFeature = BlueprintTools.GetModBlueprint<BlueprintFeature>(HEContext, "SuperiorQuickenMetaMagicFeature");
        

        public static BlueprintUnitFactReference[] GreaterDragonBuffs = {
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

        };

        public static BlueprintUnitFactReference[] GreaterDragonAbilities = {
            SuperiorQuickenMetaFeature.ToReference<BlueprintUnitFactReference>(),
            Abilities.DispelGreater.ToReference<BlueprintUnitFactReference>(),
            Abilities.Stormbolts.ToReference<BlueprintUnitFactReference>(),
            Abilities.AcidPit.ToReference<BlueprintUnitFactReference>(),
            Abilities.HoldPersonMass.ToReference<BlueprintUnitFactReference>(),
            Abilities.InvisibilityGreater.ToReference<BlueprintUnitFactReference>(),
            Abilities.AcidicSpray.ToReference<BlueprintUnitFactReference>(),
            Abilities.Sirocco.ToReference<BlueprintUnitFactReference>(),
            Abilities.Slow.ToReference<BlueprintUnitFactReference>(),
            Abilities.MirrorImage.ToReference<BlueprintUnitFactReference>(),
        };

        public static BlueprintUnitFactReference[] LesserDragonBuffs =  {
            Buffs.BarkskinBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.BlurBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.SeamantleBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.DeathWardBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.FreedomOfMovementBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.TrueSeeingBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.HeroismBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.HasteBuff.ToReference<BlueprintUnitFactReference>(),

        };
    }
}
