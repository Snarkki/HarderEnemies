using Kingmaker.Blueprints;
using Kingmaker.AI.Blueprints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TabletopTweaks.Core.Utilities;
using HarderEnemies.Blueprints;
using static HarderEnemies.Main;

namespace HarderEnemies.AI_Mechanics.Brains.Cultists {
    internal class CultistWizardBrains {
        private static BlueprintAiCastSpell MirrorImageAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "MirrorImageAiSpell");
        private static BlueprintAiCastSpell MagicMissileAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "MagicMissileAiSpell");
        private static BlueprintAiCastSpell BurningArcAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "BurningArcAiSpell");
        private static BlueprintAiCastSpell ScorchingRayAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "ScorchingRayAiSpell");
        private static BlueprintAiCastSpell FireballAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "FireballAiSpell");
        private static BlueprintAiCastSpell AnimateDeadAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "AnimateDeadAiSpell");
        private static BlueprintAiCastSpell InvisibilityGreaterAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "InvisibilityGreaterAiSpell");
        private static BlueprintAiCastSpell GreaseAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "GreaseAiSpell");
        private static BlueprintAiCastSpell StinkingCloudAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "StinkingCloudAiSpell");
        private static BlueprintAiCastSpell DeepSlumberAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "DeepSlumberAiSpell");
        private static BlueprintAiCastSpell SummonMonsterVAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "SummonMonsterVAiSpell");
        private static BlueprintAiCastSpell HungryPitAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "HungryPitAiSpell");
        private static BlueprintAiCastSpell SlowAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "SlowAiSpell");
        private static BlueprintAiCastSpell HasteAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "HasteAiSpell");
        private static BlueprintAiCastSpell IcyPrisonAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "IcyPrisonAiSpell");
        private static BlueprintAiCastSpell PhantasmalWebAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "PhantasmalWebAiSpell");
        private static BlueprintAiCastSpell HideousLaughterAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "HideousLaughterAiSpell");
        private static BlueprintAiCastSpell ColorSprayAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "ColorSprayAiSpell");
        private static BlueprintAiCastSpell ScareAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "ScareAiSpell");

        public static void CreateCultistWizardBrains() {
            var CR4DamageWizardBrain = Helpers.CreateBlueprint<BlueprintBrain>(HEContext, "CR4DamageWizardBrain", bp => {
                bp.m_Actions = new BlueprintAiActionReference[]
               {
                   AiCastSpellList.AcidSplashAiAction.ToReference<BlueprintAiActionReference>(),
                   MirrorImageAiSpell.ToReference<BlueprintAiActionReference>(),
                   MagicMissileAiSpell.ToReference<BlueprintAiActionReference>(),
                   BurningArcAiSpell.ToReference<BlueprintAiActionReference>(),
                   ScorchingRayAiSpell.ToReference<BlueprintAiActionReference>(),
                   ColorSprayAiSpell.ToReference<BlueprintAiActionReference>(),
                   ScareAiSpell.ToReference<BlueprintAiActionReference>(),
               };
            });

            var CR4SummonWizardBrain = Helpers.CreateBlueprint<BlueprintBrain>(HEContext, "CR4SummonWizardBrain", bp => {
                bp.m_Actions = new BlueprintAiActionReference[]
               {
                   AiCastSpellList.AcidSplashAiAction.ToReference<BlueprintAiActionReference>(),
                   MagicMissileAiSpell.ToReference<BlueprintAiActionReference>(),
                   MirrorImageAiSpell.ToReference<BlueprintAiActionReference>(),
                   BurningArcAiSpell.ToReference<BlueprintAiActionReference>(),
                   GreaseAiSpell.ToReference<BlueprintAiActionReference>(),
                   HideousLaughterAiSpell.ToReference<BlueprintAiActionReference>(),
               };
            });

            var CR6DamageWizardBrain = Helpers.CreateBlueprint<BlueprintBrain>(HEContext, "CR6DamageWizardBrain", bp => {
                bp.m_Actions = new BlueprintAiActionReference[]
               {
                   AiCastSpellList.AcidSplashAiAction.ToReference<BlueprintAiActionReference>(),
                   MirrorImageAiSpell.ToReference<BlueprintAiActionReference>(),
                   MagicMissileAiSpell.ToReference<BlueprintAiActionReference>(),
                   BurningArcAiSpell.ToReference<BlueprintAiActionReference>(),
                   ScorchingRayAiSpell.ToReference<BlueprintAiActionReference>(),
                   FireballAiSpell.ToReference<BlueprintAiActionReference>(),
                   SlowAiSpell.ToReference<BlueprintAiActionReference>(),
                   HasteAiSpell.ToReference<BlueprintAiActionReference>(),
               };
            });

            var CR6SummonWizardBrain = Helpers.CreateBlueprint<BlueprintBrain>(HEContext, "CR6SummonWizardBrain", bp => {
                bp.m_Actions = new BlueprintAiActionReference[]
               {
                   AiCastSpellList.AcidSplashAiAction.ToReference<BlueprintAiActionReference>(),
                   MirrorImageAiSpell.ToReference<BlueprintAiActionReference>(),
                   MagicMissileAiSpell.ToReference<BlueprintAiActionReference>(),
                   InvisibilityGreaterAiSpell.ToReference<BlueprintAiActionReference>(),
                   GreaseAiSpell.ToReference<BlueprintAiActionReference>(),
                   AnimateDeadAiSpell.ToReference<BlueprintAiActionReference>(),
                   StinkingCloudAiSpell.ToReference<BlueprintAiActionReference>(),
                   DeepSlumberAiSpell.ToReference<BlueprintAiActionReference>(),
               };
            });

            var CR8DamageWizardBrain = Helpers.CreateBlueprint<BlueprintBrain>(HEContext, "CR8DamageWizardBrain", bp => {
                bp.m_Actions = new BlueprintAiActionReference[]
               {
                   AiCastSpellList.AcidSplashAiAction.ToReference<BlueprintAiActionReference>(),
                   MirrorImageAiSpell.ToReference<BlueprintAiActionReference>(),
                   MagicMissileAiSpell.ToReference<BlueprintAiActionReference>(),
                   BurningArcAiSpell.ToReference<BlueprintAiActionReference>(),
                   ScorchingRayAiSpell.ToReference<BlueprintAiActionReference>(),
                   FireballAiSpell.ToReference<BlueprintAiActionReference>(),
                   SlowAiSpell.ToReference<BlueprintAiActionReference>(),
                   HasteAiSpell.ToReference<BlueprintAiActionReference>(),
                   IcyPrisonAiSpell.ToReference<BlueprintAiActionReference>(),
                   PhantasmalWebAiSpell.ToReference<BlueprintAiActionReference>(),
               };
            });

            var CR8SummonWizardBrain = Helpers.CreateBlueprint<BlueprintBrain>(HEContext, "CR8SummonWizardBrain", bp => {
                bp.m_Actions = new BlueprintAiActionReference[]
               {
                   AiCastSpellList.AcidSplashAiAction.ToReference<BlueprintAiActionReference>(),
                   MirrorImageAiSpell.ToReference<BlueprintAiActionReference>(),
                   MagicMissileAiSpell.ToReference<BlueprintAiActionReference>(),
                   InvisibilityGreaterAiSpell.ToReference<BlueprintAiActionReference>(),
                   GreaseAiSpell.ToReference<BlueprintAiActionReference>(),
                   StinkingCloudAiSpell.ToReference<BlueprintAiActionReference>(),
                   DeepSlumberAiSpell.ToReference<BlueprintAiActionReference>(),
                   SummonMonsterVAiSpell.ToReference<BlueprintAiActionReference>(),
                   HungryPitAiSpell.ToReference<BlueprintAiActionReference>(),
               };
            });
        }
    }
}
