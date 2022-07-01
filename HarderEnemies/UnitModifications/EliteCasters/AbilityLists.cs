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

namespace HarderEnemies.UnitModifications.EliteCasters {
    internal class AbilityLists {

        private static BlueprintFeature SuperiorQuickenMetaFeature = BlueprintTools.GetModBlueprint<BlueprintFeature>(HEContext, "SuperiorQuickenMetaMagicFeature");
        private static BlueprintFeature SuperiorEmpowerMetaFeature = BlueprintTools.GetModBlueprint<BlueprintFeature>(HEContext, "SuperiorEmporedMetaMagicFeature");
        private static BlueprintFeature SuperiorMaximizedMetaMagicFeature = BlueprintTools.GetModBlueprint<BlueprintFeature>(HEContext, "SuperiorMaximizedMetaMagicFeature");
        private static BlueprintFeature SuperiorBolsteredMetaMagicFeature = BlueprintTools.GetModBlueprint<BlueprintFeature>(HEContext, "SuperiorBolsteredMetaMagicFeature");

        private static BlueprintAbility ErineysSummon = BlueprintTools.GetModBlueprint<BlueprintAbility>(HEContext, "ErineysSummon");


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
