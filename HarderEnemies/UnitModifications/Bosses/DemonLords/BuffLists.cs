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
using Kingmaker.UnitLogic.Abilities.Blueprints;

namespace HarderEnemies.UnitModifications.Bosses.DemonLords {
    internal class BuffLists {




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



        /// <summary>
        /// ///
        /// </summary>

        public static BlueprintUnitFactReference[] NocticulaBuffList =  {
            Buffs.BloodHaze.ToReference<BlueprintUnitFactReference>(),
            Buffs.BoneShieldBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.MindBlankBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.TrueSeeingBuff.ToReference<BlueprintUnitFactReference>(),
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




        /// <summary>
        /// ///
        /// </summary>

        public static BlueprintUnitFactReference[] CR30_AreshkagalBossBuffs =  {
            FeatureList.DR15.ToReference<BlueprintUnitFactReference>(),
            FeatureList.DestructiveShockwave.ToReference<BlueprintUnitFactReference>(),
        };


    }
}
