using HarderEnemies.Features;
using Kingmaker.AI.Blueprints;
using Kingmaker.Blueprints;
using Kingmaker.Blueprints.Classes;
using Kingmaker.UnitLogic.Abilities.Blueprints;
using Kingmaker.UnitLogic.FactLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TabletopTweaks.Core.Utilities;
using HarderEnemies.Blueprints;
using static HarderEnemies.Main;


namespace HarderEnemies.Units.BuffLists {
    internal class EliteCasterList {

        private static BlueprintFeature SuperiorQuickenMetaFeature = BlueprintTools.GetModBlueprint<BlueprintFeature>(HEContext, "SuperiorQuickenMetaMagicFeature");
        private static BlueprintFeature SuperiorEmpowerMetaFeature = BlueprintTools.GetModBlueprint<BlueprintFeature>(HEContext, "SuperiorEmporedMetaMagicFeature");
        private static BlueprintFeature SuperiorMaximizedMetaMagicFeature = BlueprintTools.GetModBlueprint<BlueprintFeature>(HEContext, "SuperiorMaximizedMetaMagicFeature");
        private static BlueprintFeature SuperiorBolsteredMetaMagicFeature = BlueprintTools.GetModBlueprint<BlueprintFeature>(HEContext, "SuperiorBolsteredMetaMagicFeature");

        private static BlueprintAbility ErineysSummon = BlueprintTools.GetModBlueprint<BlueprintAbility>(HEContext, "ErineysSummon");

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

        public static BlueprintUnitFactReference[] EliteCasterAbilities =  {
            Abilities.EdictOfInvulnerability.ToReference<BlueprintUnitFactReference>(),
            Abilities.DispelGreater.ToReference<BlueprintUnitFactReference>(),
            Abilities.Stormbolts.ToReference<BlueprintUnitFactReference>(),
                Abilities.RiftOfRuin.ToReference<BlueprintUnitFactReference>(),
                Abilities.Firestorm.ToReference<BlueprintUnitFactReference>(),
                Abilities.OverwhelmingPresence.ToReference<BlueprintUnitFactReference>(),
                Abilities.WailOfBanshee.ToReference<BlueprintUnitFactReference>(),
                Abilities.InvisibilityGreater.ToReference<BlueprintUnitFactReference>(),
                Abilities.HorridWilting.ToReference<BlueprintUnitFactReference>(),
                Abilities.HellfireRay.ToReference<BlueprintUnitFactReference>(),
                ErineysSummon.ToReference<BlueprintUnitFactReference>(),
                SuperiorQuickenMetaFeature.ToReference<BlueprintUnitFactReference>(),
            SuperiorBolsteredMetaMagicFeature.ToReference<BlueprintUnitFactReference>(),
            SuperiorMaximizedMetaMagicFeature.ToReference<BlueprintUnitFactReference>(),
            SuperiorEmpowerMetaFeature.ToReference<BlueprintUnitFactReference>(),
        };

        public static BlueprintUnitFactReference[] SemiEliteCasterAbilities =  {
            Abilities.HoldPersonMass.ToReference<BlueprintUnitFactReference>(),
            Abilities.Stormbolts.ToReference<BlueprintUnitFactReference>(),
            Abilities.AcidPit.ToReference<BlueprintUnitFactReference>(),
            Abilities.CommandGreaterFall.ToReference<BlueprintUnitFactReference>(),
            Abilities.InvisibilityGreater.ToReference<BlueprintUnitFactReference>(),
            Abilities.Blasphemy.ToReference<BlueprintUnitFactReference>(),
            Abilities.ShoutGreater.ToReference<BlueprintUnitFactReference>(),   
            Abilities.Disintegrate.ToReference<BlueprintUnitFactReference>(),
            Abilities.Sirocco.ToReference<BlueprintUnitFactReference>(),
            SuperiorQuickenMetaFeature.ToReference<BlueprintUnitFactReference>(),
            SuperiorBolsteredMetaMagicFeature.ToReference<BlueprintUnitFactReference>(),
            SuperiorMaximizedMetaMagicFeature.ToReference<BlueprintUnitFactReference>(),
            SuperiorEmpowerMetaFeature.ToReference<BlueprintUnitFactReference>(),
        };
    }
}
