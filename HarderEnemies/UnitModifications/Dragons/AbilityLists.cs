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

namespace HarderEnemies.UnitModifications.Dragons {
    internal class AbilityLists {

        private static BlueprintFeature SuperiorQuickenMetaFeature = BlueprintTools.GetModBlueprint<BlueprintFeature>(HEContext, "SuperiorQuickenMetaMagicFeature");

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


    }
}
