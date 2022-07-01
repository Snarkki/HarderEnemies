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
    internal class AbilityLists {

        private static BlueprintFeature SuperiorQuickenMetaFeature = BlueprintTools.GetModBlueprint<BlueprintFeature>(HEContext, "SuperiorQuickenMetaMagicFeature");
        private static BlueprintFeature SuperiorEmpowerMetaFeature = BlueprintTools.GetModBlueprint<BlueprintFeature>(HEContext, "SuperiorEmporedMetaMagicFeature");


        private static BlueprintAbility GreaterSwarmSummon = BlueprintTools.GetModBlueprint<BlueprintAbility>(HEContext, "GreaterSwarmSummon");
        private static BlueprintAbility GateSpell = BlueprintTools.GetModBlueprint<BlueprintAbility>(HEContext, "GateSpell");

        public static BlueprintUnitFactReference[] DeskariAbilityList =  {
            GreaterSwarmSummon.ToReference<BlueprintUnitFactReference>(),
            Abilities.EdictOfInvulnerability.ToReference<BlueprintUnitFactReference>(),
        };

        public static BlueprintUnitFactReference[] NocticulaAbilityList =  {
            Abilities.DispelGreater.ToReference<BlueprintUnitFactReference>(),
            Abilities.Stormbolts.ToReference<BlueprintUnitFactReference>(),
            Abilities.RiftOfRuin.ToReference<BlueprintUnitFactReference>(),
            Abilities.Firestorm.ToReference<BlueprintUnitFactReference>(),
            SuperiorQuickenMetaFeature.ToReference<BlueprintUnitFactReference>(),
            SuperiorEmpowerMetaFeature.ToReference<BlueprintUnitFactReference>(),
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

        public static BlueprintUnitFactReference[] CR30_AreshkagalAbilities =  {

        };

    }
}
