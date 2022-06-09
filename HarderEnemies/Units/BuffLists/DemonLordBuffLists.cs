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
    internal class DemonLordBuffLists {
        private static BlueprintFeature SuperiorQuickenMetaFeature = BlueprintTools.GetModBlueprint<BlueprintFeature>(HEContext, "SuperiorQuickenMetaMagicFeature");
        private static BlueprintFeature SuperiorEmpowerMetaFeature = BlueprintTools.GetModBlueprint<BlueprintFeature>(HEContext, "SuperiorEmporedMetaMagicFeature");


        private static BlueprintAbility GreaterSwarmSummon = BlueprintTools.GetModBlueprint<BlueprintAbility>(HEContext, "GreaterSwarmSummon");
        private static BlueprintAbility GateSpell = BlueprintTools.GetModBlueprint<BlueprintAbility>(HEContext, "GateSpell");


        public static BlueprintUnitFactReference[] DeskariBuffList =  {
            Buffs.FlamesOfTheAbyssBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.BloodHaze.ToReference<BlueprintUnitFactReference>(),
            Buffs.BoneShieldBuff.ToReference<BlueprintUnitFactReference>(),
            FeatureList.DR15.ToReference<BlueprintUnitFactReference>(),
            FeatureList.AlwaysAChange.ToReference<BlueprintUnitFactReference>(),
            FeatureList.ThunderingBlows.ToReference<BlueprintUnitFactReference>(),
            FeatureList.DestructiveShockwave.ToReference<BlueprintUnitFactReference>(),
            FeatureList.AscendentElementFire.ToReference<BlueprintUnitFactReference>(),
        };

        public static BlueprintUnitFactReference[] DeskariAbilityList =  {
            GreaterSwarmSummon.ToReference<BlueprintUnitFactReference>(),
            Abilities.EdictOfInvulnerability.ToReference<BlueprintUnitFactReference>(),
        };

        /// <summary>
        /// ///
        /// </summary>

        public static BlueprintUnitFactReference[] NocticulaBuffList =  {
            Buffs.BloodHaze.ToReference<BlueprintUnitFactReference>(),
            Buffs.BoneShieldBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.MindBlankBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.TrueSeeingBuff.ToReference<BlueprintUnitFactReference>(),
        };

        public static BlueprintUnitFactReference[] NocticulaAbilityList =  {
            Abilities.DispelGreater.ToReference<BlueprintUnitFactReference>(),
            Abilities.Stormbolts.ToReference<BlueprintUnitFactReference>(),
            Abilities.RiftOfRuin.ToReference<BlueprintUnitFactReference>(),
            Abilities.Firestorm.ToReference<BlueprintUnitFactReference>(),
            SuperiorQuickenMetaFeature.ToReference<BlueprintUnitFactReference>(),
            SuperiorEmpowerMetaFeature.ToReference<BlueprintUnitFactReference>(),
        };

        // <summary>
        /// ///////
        /// </summary>

        public static BlueprintUnitFactReference[] AreeluBuffList =  {
            Buffs.BloodHaze.ToReference<BlueprintUnitFactReference>(),
            Buffs.BoneShieldBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.MindBlankBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.TrueSeeingBuff.ToReference<BlueprintUnitFactReference>(),
            FeatureList.AlwaysAChange.ToReference<BlueprintUnitFactReference>(),
            FeatureList.DestructiveShockwave.ToReference<BlueprintUnitFactReference>(),
        };

        public static BlueprintUnitFactReference[] AreeluAbilityList =  {
            Abilities.OverwhelmingPresence.ToReference<BlueprintUnitFactReference>(),
            Abilities.DispelGreater.ToReference<BlueprintUnitFactReference>(),
            Abilities.Stormbolts.ToReference<BlueprintUnitFactReference>(),
            Abilities.CommandGreaterFall.ToReference<BlueprintUnitFactReference>(),
            SuperiorQuickenMetaFeature.ToReference<BlueprintUnitFactReference>(),
            SuperiorEmpowerMetaFeature.ToReference<BlueprintUnitFactReference>(),
            GateSpell.ToReference<BlueprintUnitFactReference>(),
        };


        /// <summary>
        /// ///
        /// </summary>

        public static BlueprintUnitFactReference[] CR30_AreshkagalBossBuffs =  {
            FeatureList.DR15.ToReference<BlueprintUnitFactReference>(),
            FeatureList.DestructiveShockwave.ToReference<BlueprintUnitFactReference>(),
        };

        public static BlueprintUnitFactReference[] CR30_AreshkagalAbilities =  {

        };
    }
}
