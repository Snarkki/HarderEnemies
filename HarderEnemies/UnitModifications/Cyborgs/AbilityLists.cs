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

namespace HarderEnemies.UnitModifications.Cyborgs {
    internal class AbilityLists {

        public static BlueprintAbilityReference[] CyborgCasterSpells = {
                Abilities.MirrorImage.ToReference<BlueprintAbilityReference>(),
                Abilities.MirrorImage.ToReference<BlueprintAbilityReference>(),
                Abilities.MagicMissile.ToReference<BlueprintAbilityReference>(),
                Abilities.MagicMissile.ToReference<BlueprintAbilityReference>(),
                Abilities.MagicMissile.ToReference<BlueprintAbilityReference>(),
                Abilities.InvisibilityGreater.ToReference<BlueprintAbilityReference>(),
                Abilities.InvisibilityGreater.ToReference<BlueprintAbilityReference>(),
                Abilities.Grease.ToReference<BlueprintAbilityReference>(),
                Abilities.AnimateDead.ToReference<BlueprintAbilityReference>(),
                Abilities.AnimateDead.ToReference<BlueprintAbilityReference>(),
                Abilities.StinkingCloud.ToReference<BlueprintAbilityReference>(),
                Abilities.Fireball.ToReference<BlueprintAbilityReference>(),
                Abilities.Fireball.ToReference<BlueprintAbilityReference>(),
                Abilities.SummonMonsterVBase.ToReference<BlueprintAbilityReference>(),
                Abilities.HungryPit.ToReference<BlueprintAbilityReference>(),
                Abilities.BurningArc.ToReference<BlueprintAbilityReference>(),
                Abilities.BurningArc.ToReference<BlueprintAbilityReference>(),
                Abilities.IcyPrison.ToReference<BlueprintAbilityReference>(),
            };

        public static BlueprintUnitFactReference[] CyborgTankFeatures = {
                FeatureList.IntimidatingProwess.ToReference<BlueprintUnitFactReference>(),
                FeatureList.Persuasive.ToReference<BlueprintUnitFactReference>(),
                FeatureList.SkillFocusDiplomacy.ToReference<BlueprintUnitFactReference>(),
                FeatureList.DazzlingDisplayFeature.ToReference<BlueprintUnitFactReference>(),
                FeatureList.ShatterDefenses.ToReference<BlueprintUnitFactReference>(),
                FeatureList.CornugonSmash.ToReference<BlueprintUnitFactReference>(),
                FeatureList.ThugFrightening.ToReference<BlueprintUnitFactReference>(),
                FeatureList.Outflank.ToReference<BlueprintUnitFactReference>(),
            };

        public static BlueprintUnitFactReference[] Cyborg2hFeatures = {
                FeatureList.VitalStrikeFeature.ToReference<BlueprintUnitFactReference>(),
                FeatureList.VitalStrikeFeatureGreater.ToReference<BlueprintUnitFactReference>(),
                FeatureList.VitalStrikeFeatureImproved.ToReference<BlueprintUnitFactReference>(),
                FeatureList.Outflank.ToReference<BlueprintUnitFactReference>(),
            };
        public static BlueprintUnitFactReference[] IncubusAssassinFeatures = {
                FeatureList.Outflank.ToReference<BlueprintUnitFactReference>(),
            };
        public static BlueprintUnitFactReference[] SuccubusSorcererFeatures = {
                Abilities.Slow.ToReference<BlueprintUnitFactReference>(),
                Abilities.InvisibilityGreater.ToReference<BlueprintUnitFactReference>(),
                Abilities.OverwhelmingGrief.ToReference<BlueprintUnitFactReference>(),
            };
    }
}
