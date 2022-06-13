using System;
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
    internal class BossBuffLists {

        private static BlueprintFeature SuperiorQuickenMetaFeature = BlueprintTools.GetModBlueprint<BlueprintFeature>(HEContext, "SuperiorQuickenMetaMagicFeature");
        private static BlueprintFeature SuperiorEmpowerMetaFeature = BlueprintTools.GetModBlueprint<BlueprintFeature>(HEContext, "SuperiorEmporedMetaMagicFeature");
        //Balor weapons
        private static BlueprintAbility PullingStrikeAbility = BlueprintTools.GetModBlueprint<BlueprintAbility>(HEContext, "PullingStrikeAbility");




        public static BlueprintUnitFactReference[] DarrazandAbilities = {
            Abilities.Blasphemy.ToReference<BlueprintUnitFactReference>(),
            Abilities.FlameStrike.ToReference<BlueprintUnitFactReference>(),
            Abilities.Firestorm.ToReference<BlueprintUnitFactReference>(),
            FeatureList.AscendentElementFire.ToReference<BlueprintUnitFactReference>(),
            PullingStrikeAbility.ToReference<BlueprintUnitFactReference>(),
            Abilities.Stormbolts.ToReference<BlueprintUnitFactReference>(),
            SuperiorQuickenMetaFeature.ToReference<BlueprintUnitFactReference>(),
            SuperiorEmpowerMetaFeature.ToReference<BlueprintUnitFactReference>()
        };

        public static BlueprintUnitFactReference[] BalorAbilities = {
            Abilities.FlameStrike.ToReference<BlueprintUnitFactReference>(),
            Abilities.Firestorm.ToReference<BlueprintUnitFactReference>(),
            Abilities.HoldPersonMass.ToReference<BlueprintUnitFactReference>(),
            Abilities.OverwhelmingPresence.ToReference<BlueprintUnitFactReference>(),
            Abilities.ShoutGreater.ToReference<BlueprintUnitFactReference>(),
            FeatureList.AscendentElementFire.ToReference<BlueprintUnitFactReference>(),
            SuperiorEmpowerMetaFeature.ToReference<BlueprintUnitFactReference>()
        };

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

        public static BlueprintUnitFactReference[] CorruptedAngelBuffs = {
            Buffs.FrigtfulAspectBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.SeamantleBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.DeathWardBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.FreedomOfMovementBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.FlamesOfTheAbyssBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.BloodHaze.ToReference<BlueprintUnitFactReference>(),
            Buffs.BoneShieldBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.MindBlankBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.TrueSeeingBuff.ToReference<BlueprintUnitFactReference>(),
            FeatureList.DR15.ToReference<BlueprintUnitFactReference>(),
            FeatureList.AlwaysAChange.ToReference<BlueprintUnitFactReference>(),
            FeatureList.ThunderingBlows.ToReference<BlueprintUnitFactReference>(),
            FeatureList.DestructiveShockwave.ToReference<BlueprintUnitFactReference>(),
        };

        public static BlueprintUnitFactReference[] CorruptedAngelAbilities = {
            FeatureList.DR15.ToReference<BlueprintUnitFactReference>(),
            FeatureList.AlwaysAChange.ToReference<BlueprintUnitFactReference>(),
            FeatureList.ThunderingBlows.ToReference<BlueprintUnitFactReference>(),
            FeatureList.DestructiveShockwave.ToReference<BlueprintUnitFactReference>(),
        };




        public static BlueprintUnitFactReference[] JerribethAbilities =  {
            Abilities.SummonMonsterVII.ToReference<BlueprintUnitFactReference>(),
            Abilities.HoldPersonMass.ToReference<BlueprintUnitFactReference>(),
            Abilities.BurningArc.ToReference<BlueprintUnitFactReference>(),
            Abilities.ScorchingRay.ToReference<BlueprintUnitFactReference>(),
            Abilities.Slow.ToReference<BlueprintUnitFactReference>(),
            Abilities.Fear.ToReference<BlueprintUnitFactReference>(),
            Abilities.Stormbolts.ToReference<BlueprintUnitFactReference>(),
            SuperiorQuickenMetaFeature.ToReference<BlueprintUnitFactReference>(),
            Abilities.DispelGreater.ToReference<BlueprintUnitFactReference>()
        };

        public static BlueprintUnitFactReference[] JerribethBuffs =  {
            Buffs.BarkskinBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.ShielfOfFaithBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.MageShieldBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.StoneskinBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.MindBlankBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.TrueSeeingBuff.ToReference<BlueprintUnitFactReference>(),
        };

        public static BlueprintUnitFactReference[] MinaghoAbilities =  {
            SuperiorQuickenMetaFeature.ToReference<BlueprintUnitFactReference>(),
            Abilities.DispelGreater.ToReference<BlueprintUnitFactReference>(),
            Abilities.PhantasmalPutrefaction.ToReference<BlueprintUnitFactReference>(),
            Abilities.PowerWordBlind.ToReference<BlueprintUnitFactReference>(),
            Abilities.ChainLightning.ToReference<BlueprintUnitFactReference>(),
            Abilities.RiftOfRuin.ToReference<BlueprintUnitFactReference>(),
        };
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

