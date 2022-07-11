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

namespace HarderEnemies.UnitModifications.Bosses.Jerribeth {
    internal class AbilityLists {

        private static BlueprintFeature SuperiorQuickenMetaFeature = BlueprintTools.GetModBlueprint<BlueprintFeature>(HEContext, "SuperiorQuickenMetaMagicFeature");

        public static BlueprintUnitFactReference[] JerribethAbilities =  {
            Abilities.SummonMonsterVII.ToReference<BlueprintUnitFactReference>(),
            Abilities.HoldPersonMass.ToReference<BlueprintUnitFactReference>(),
            Abilities.BurningArc.ToReference<BlueprintUnitFactReference>(),
            Abilities.ScorchingRay.ToReference<BlueprintUnitFactReference>(),
            Abilities.Slow.ToReference<BlueprintUnitFactReference>(),
            Abilities.Fear.ToReference<BlueprintUnitFactReference>(),
            Abilities.Stormbolts.ToReference<BlueprintUnitFactReference>(),
            SuperiorQuickenMetaFeature.ToReference<BlueprintUnitFactReference>(),
            Abilities.DispelGreater.ToReference<BlueprintUnitFactReference>(),
            Abilities.InvisibilityGreater.ToReference<BlueprintUnitFactReference>()
        };

    }
}
