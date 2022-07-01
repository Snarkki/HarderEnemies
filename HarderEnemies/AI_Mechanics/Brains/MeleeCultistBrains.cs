using HarderEnemies.Blueprints;
using Kingmaker.AI.Blueprints;
using Kingmaker.Blueprints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TabletopTweaks.Core.Utilities;
using static HarderEnemies.Main;


namespace HarderEnemies.AI_Mechanics.Brains {
    internal class MeleeCultistBrains {

        private static BlueprintAiCastSpell HoldPersonAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "HoldPersonAiSpell");
        private static BlueprintAiCastSpell CommandAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "CommandAiSpell");
        private static BlueprintAiCastSpell CauseFearAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "CauseFearAiSpell");
        private static BlueprintAiCastSpell SoundBurstAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "SoundBurstAiSpell");
        private static BlueprintAiCastSpell BoneshakerAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "BoneshakerAiSpell");
        private static BlueprintAiCastSpell BlindnessAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "BlindnessAiSpell");
        private static BlueprintAiCastSpell PrayerAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "PrayerAiSpell");
        private static BlueprintAiCastSpell DivinePowerAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "DivinePowerAiSpell");
        private static BlueprintAiCastSpell NewFlameStrikeAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "NewFlameStrikeAiSpell");
        private static BlueprintAiCastSpell CommandGreaterAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "CommandGreaterAiSpell");
        private static BlueprintAiCastSpell ColdIceStrikeAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "ColdIceStrikeAiSpell");
        private static BlueprintAiCastSpell MirrorImageAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "MirrorImageAiSpell");


        
        public static void BrainHandler() {
            CreateCultistClericBrains();
            CreateCultistWizardBrains();
        }

        private static void CreateCultistClericBrains() {
            var LowLevelClericBrain = Helpers.CreateBlueprint<BlueprintBrain>(HEContext, "LowLevelClericBrain", bp => {
                bp.m_Actions = new BlueprintAiActionReference[]
               {
                   AiCastSpellList.AttackAiAction.ToReference<BlueprintAiActionReference>(),
                   AiCastSpellList.CultistChannelAiAction.ToReference<BlueprintAiActionReference>(),
                   HoldPersonAiSpell.ToReference<BlueprintAiActionReference>(),
                   CommandAiSpell.ToReference<BlueprintAiActionReference>(),
                   CauseFearAiSpell.ToReference<BlueprintAiActionReference>(),
                   BoneshakerAiSpell.ToReference<BlueprintAiActionReference>(),
                   SoundBurstAiSpell.ToReference<BlueprintAiActionReference>(),
               };
            });

            var CR6ClericBrain = Helpers.CreateBlueprint<BlueprintBrain>(HEContext, "CR6ClericBrain", bp => {
                bp.m_Actions = new BlueprintAiActionReference[]
               {
                   AiCastSpellList.AttackAiAction.ToReference<BlueprintAiActionReference>(),
                   AiCastSpellList.CultistChannelAiAction.ToReference<BlueprintAiActionReference>(),
                   HoldPersonAiSpell.ToReference<BlueprintAiActionReference>(),
                   CommandAiSpell.ToReference<BlueprintAiActionReference>(),
                   CauseFearAiSpell.ToReference<BlueprintAiActionReference>(),
                   BoneshakerAiSpell.ToReference<BlueprintAiActionReference>(),
                   SoundBurstAiSpell.ToReference<BlueprintAiActionReference>(),
                   BlindnessAiSpell.ToReference<BlueprintAiActionReference>(),
                   PrayerAiSpell.ToReference<BlueprintAiActionReference>(),
               };
            });

            var CR8ClericBrain = Helpers.CreateBlueprint<BlueprintBrain>(HEContext, "CR8ClericBrain", bp => {
                bp.m_Actions = new BlueprintAiActionReference[]
               {
                   AiCastSpellList.AttackAiAction.ToReference<BlueprintAiActionReference>(),
                   AiCastSpellList.CultistChannelAiAction.ToReference<BlueprintAiActionReference>(),
                   HoldPersonAiSpell.ToReference<BlueprintAiActionReference>(),
                   CommandAiSpell.ToReference<BlueprintAiActionReference>(),
                   CauseFearAiSpell.ToReference<BlueprintAiActionReference>(),
                   BoneshakerAiSpell.ToReference<BlueprintAiActionReference>(),
                   SoundBurstAiSpell.ToReference<BlueprintAiActionReference>(),
                   BlindnessAiSpell.ToReference<BlueprintAiActionReference>(),
                   PrayerAiSpell.ToReference<BlueprintAiActionReference>(),
                   DivinePowerAiSpell.ToReference<BlueprintAiActionReference>(),
               };
            });

            var HighLevelClericBrain = Helpers.CreateBlueprint<BlueprintBrain>(HEContext, "HighLevelClericBrain", bp => {
                bp.m_Actions = new BlueprintAiActionReference[]
               {
                   AiCastSpellList.AttackAiAction.ToReference<BlueprintAiActionReference>(),
                   AiCastSpellList.CultistChannelAiAction.ToReference<BlueprintAiActionReference>(),
                   BlindnessAiSpell.ToReference<BlueprintAiActionReference>(),
                   PrayerAiSpell.ToReference<BlueprintAiActionReference>(),
                   NewFlameStrikeAiSpell.ToReference<BlueprintAiActionReference>(),
                   CommandGreaterAiSpell.ToReference<BlueprintAiActionReference>(),
                   ColdIceStrikeAiSpell.ToReference<BlueprintAiActionReference>(),
               };
            });
        }
        private static void CreateCultistWizardBrains() {
            var CR4DamageWizardBrain = Helpers.CreateBlueprint<BlueprintBrain>(HEContext, "CR4DamageWizardBrain", bp => {
                bp.m_Actions = new BlueprintAiActionReference[]
               {
                   AiCastSpellList.AcidSplashAiAction.ToReference<BlueprintAiActionReference>(),
                   MirrorImageAiSpell.ToReference<BlueprintAiActionReference>(),
               };

               
                Abilities.MagicMissile.ToReference<BlueprintAbilityReference>(),
                Abilities.ColorSpray.ToReference<BlueprintAbilityReference>(),
                Abilities.Scare.ToReference<BlueprintAbilityReference>(),
                Abilities.ScorchingRay.ToReference<BlueprintAbilityReference>(),
                Abilities.ScorchingRay.ToReference<BlueprintAbilityReference>(),
                Abilities.BurningArc.ToReference<BlueprintAbilityReference>(),
                Abilities.BurningArc.ToReference<BlueprintAbilityReference>(),
            });

            var CR4SummonWizardBrain = Helpers.CreateBlueprint<BlueprintBrain>(HEContext, "CR4SummonWizardBrain", bp => {
                bp.m_Actions = new BlueprintAiActionReference[]
               {
                   AiCastSpellList.AcidSplashAiAction.ToReference<BlueprintAiActionReference>(),

               };

                Abilities.MirrorImage.ToReference<BlueprintAbilityReference>(),
                Abilities.MagicMissile.ToReference<BlueprintAbilityReference>(),
                Abilities.Grease.ToReference<BlueprintAbilityReference>(),
                Abilities.Grease.ToReference<BlueprintAbilityReference>(),
                Abilities.HideousLaughter.ToReference<BlueprintAbilityReference>(),
                Abilities.HideousLaughter.ToReference<BlueprintAbilityReference>(),
                Abilities.BurningArc.ToReference<BlueprintAbilityReference>(),
                Abilities.BurningArc.ToReference<BlueprintAbilityReference>(),
            });

            var CR6DamageWizardBrain = Helpers.CreateBlueprint<BlueprintBrain>(HEContext, "CR6DamageWizardBrain", bp => {
                bp.m_Actions = new BlueprintAiActionReference[]
               {
                   AiCastSpellList.AcidSplashAiAction.ToReference<BlueprintAiActionReference>(),

               };

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
            });

            var CR6SummonWizardBrain = Helpers.CreateBlueprint<BlueprintBrain>(HEContext, "CR6SummonWizardBrain", bp => {
                bp.m_Actions = new BlueprintAiActionReference[]
               {
                   AiCastSpellList.AcidSplashAiAction.ToReference<BlueprintAiActionReference>(),

               };

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
            });

            var CR8DamageWizardBrain = Helpers.CreateBlueprint<BlueprintBrain>(HEContext, "CR8DamageWizardBrain", bp => {
                bp.m_Actions = new BlueprintAiActionReference[]
               {
                   AiCastSpellList.AcidSplashAiAction.ToReference<BlueprintAiActionReference>(),

               };
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

            });

            var CR8SummonWizardBrain = Helpers.CreateBlueprint<BlueprintBrain>(HEContext, "CR8SummonWizardBrain", bp => {
                bp.m_Actions = new BlueprintAiActionReference[]
               {
                   AiCastSpellList.AcidSplashAiAction.ToReference<BlueprintAiActionReference>(),

               };

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
            });
        }
            
    }
}
