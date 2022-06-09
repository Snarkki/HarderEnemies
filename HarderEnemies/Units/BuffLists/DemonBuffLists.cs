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
    internal class DemonBuffLists {

        private static BlueprintFeature BabauDispellingStrike = BlueprintTools.GetModBlueprint<BlueprintFeature>(HEContext, "BabauDispellingStrike");

        public static BlueprintUnitFactReference[] BabauAbilities = {
            FeatureList.Outflank.ToReference<BlueprintUnitFactReference>(),
            BabauDispellingStrike.ToReference<BlueprintUnitFactReference>(),
        };

        public static BlueprintUnitFactReference[] AbrikanduAbilities = {
            FeatureList.IntimidatingProwess.ToReference<BlueprintUnitFactReference>(),
            FeatureList.CornugonSmash.ToReference<BlueprintUnitFactReference>()
        };
        public static BlueprintUnitFactReference[] AbrikanduBuffs = {
            Buffs.HasteBuff.ToReference<BlueprintUnitFactReference>()
        };

        public static BlueprintUnitFactReference[] ColoxusBuffs = {
            Buffs.HasteBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.MageShieldBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.MageArmorBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.ProtectionFromArrowsBuff.ToReference<BlueprintUnitFactReference>(),
        };


        public static BlueprintUnitFactReference[] DemodandStringyBuffs = {
            Buffs.MageArmorBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.MageShieldBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.BlinkBuff.ToReference<BlueprintUnitFactReference>(),
        };
        public static BlueprintUnitFactReference[] DemodandTarryBuffs = {
            Buffs.MageArmorBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.MageShieldBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.HasteBuff.ToReference<BlueprintUnitFactReference>(),
        };
        public static BlueprintUnitFactReference[] GibrilithAbilities = {
            Abilities.UnholyBlight.ToReference<BlueprintUnitFactReference>(),
        };
        public static BlueprintUnitFactReference[] GibrilithBuffs = {
            Buffs.UnholyAuraBuff.ToReference<BlueprintUnitFactReference>(),
        };
        public static BlueprintUnitFactReference[] OolioddrooBuffs = {
            Buffs.MageArmorBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.MageShieldBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.BlinkBuff.ToReference<BlueprintUnitFactReference>(),
        };
    }
    
}
