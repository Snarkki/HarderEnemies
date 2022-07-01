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

namespace HarderEnemies.UnitModifications.Cultists.Casters {
    internal class AbilityLists {

        public static BlueprintAbilityReference[] CR4DamageWizardSpells = {
                Abilities.MirrorImage.ToReference<BlueprintAbilityReference>(),
                Abilities.MagicMissile.ToReference<BlueprintAbilityReference>(),
                Abilities.ColorSpray.ToReference<BlueprintAbilityReference>(),
                Abilities.Scare.ToReference<BlueprintAbilityReference>(),
                Abilities.ScorchingRay.ToReference<BlueprintAbilityReference>(),
                Abilities.ScorchingRay.ToReference<BlueprintAbilityReference>(),
                Abilities.BurningArc.ToReference<BlueprintAbilityReference>(),
                Abilities.BurningArc.ToReference<BlueprintAbilityReference>(),
            };

        public static BlueprintAbilityReference[] CR4SummonWizardSpells = {
                Abilities.MirrorImage.ToReference<BlueprintAbilityReference>(),
                Abilities.MagicMissile.ToReference<BlueprintAbilityReference>(),
                Abilities.Grease.ToReference<BlueprintAbilityReference>(),
                Abilities.Grease.ToReference<BlueprintAbilityReference>(),
                Abilities.HideousLaughter.ToReference<BlueprintAbilityReference>(),
                Abilities.HideousLaughter.ToReference<BlueprintAbilityReference>(),
                Abilities.BurningArc.ToReference<BlueprintAbilityReference>(),
                Abilities.BurningArc.ToReference<BlueprintAbilityReference>(),
            };

        public static BlueprintAbilityReference[] CR6DamageWizardSpells = {
                Abilities.MirrorImage.ToReference<BlueprintAbilityReference>(),
                Abilities.MagicMissile.ToReference<BlueprintAbilityReference>(),
                Abilities.MagicMissile.ToReference<BlueprintAbilityReference>(),
                Abilities.MagicMissile.ToReference<BlueprintAbilityReference>(),
                Abilities.ScorchingRay.ToReference<BlueprintAbilityReference>(),
                Abilities.ScorchingRay.ToReference<BlueprintAbilityReference>(),
                Abilities.BurningArc.ToReference<BlueprintAbilityReference>(),
                Abilities.BurningArc.ToReference<BlueprintAbilityReference>(),
                Abilities.Fireball.ToReference<BlueprintAbilityReference>(),
                Abilities.Fireball.ToReference<BlueprintAbilityReference>(),
                Abilities.Slow.ToReference<BlueprintAbilityReference>(),
                Abilities.Haste.ToReference<BlueprintAbilityReference>(),
            };

        public static BlueprintAbilityReference[] CR6SummonWizardSpells = {
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
            };

        public static BlueprintAbilityReference[] CR8DamageWizardSpells = {
                Abilities.MirrorImage.ToReference<BlueprintAbilityReference>(),
                Abilities.MirrorImage.ToReference<BlueprintAbilityReference>(),
                Abilities.MagicMissile.ToReference<BlueprintAbilityReference>(),
                Abilities.MagicMissile.ToReference<BlueprintAbilityReference>(),
                Abilities.MagicMissile.ToReference<BlueprintAbilityReference>(),
                Abilities.ScorchingRay.ToReference<BlueprintAbilityReference>(),
                Abilities.ScorchingRay.ToReference<BlueprintAbilityReference>(),
                Abilities.BurningArc.ToReference<BlueprintAbilityReference>(),
                Abilities.BurningArc.ToReference<BlueprintAbilityReference>(),
                Abilities.Fireball.ToReference<BlueprintAbilityReference>(),
                Abilities.Fireball.ToReference<BlueprintAbilityReference>(),
                Abilities.Slow.ToReference<BlueprintAbilityReference>(),
                Abilities.Haste.ToReference<BlueprintAbilityReference>(),
                Abilities.IcyPrison.ToReference<BlueprintAbilityReference>(),
                Abilities.PhantasmalWeb.ToReference<BlueprintAbilityReference>(),
            };

        public static BlueprintAbilityReference[] CR8SummonWizardSpells = {
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
