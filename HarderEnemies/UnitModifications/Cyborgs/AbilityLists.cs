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
                Abilities.DeepSlumber.ToReference<BlueprintAbilityReference>(),
                Abilities.SummonMonsterVBase.ToReference<BlueprintAbilityReference>(),
                Abilities.HungryPit.ToReference<BlueprintAbilityReference>(),
            };
    }
}
