using Kingmaker.AI.Blueprints;
using Kingmaker.Blueprints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TabletopTweaks.Core.Utilities;
using HarderEnemies.Blueprints;
using static HarderEnemies.Main;

namespace HarderEnemies.AI_Mechanics.Brains.Cyborgs {
    internal class CyborgBrains {
        private static BlueprintAiCastSpell GreaterVitalStrikeAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "GreaterVitalStrikeAiSpell");


        private static BlueprintAiCastSpell MirrorImageAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "MirrorImageAiSpell");
        private static BlueprintAiCastSpell MagicMissileAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "MagicMissileAiSpell");
        private static BlueprintAiCastSpell BurningArcAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "BurningArcAiSpell");
        private static BlueprintAiCastSpell ScorchingRayAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "ScorchingRayAiSpell");
        private static BlueprintAiCastSpell FireballAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "FireballAiSpell");
        private static BlueprintAiCastSpell AnimateDeadAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "AnimateDeadAiSpell");
        private static BlueprintAiCastSpell InvisibilityGreaterAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "InvisibilityGreaterAiSpell");
        private static BlueprintAiCastSpell GreaseAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "GreaseAiSpell");
        private static BlueprintAiCastSpell StinkingCloudAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "StinkingCloudAiSpell");
        private static BlueprintAiCastSpell SummonMonsterVAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "SummonMonsterVAiSpell");
        private static BlueprintAiCastSpell HungryPitAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "HungryPitAiSpell");
        private static BlueprintAiCastSpell IcyPrisonAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "IcyPrisonAiSpell");





        public static void Handler() {
            CreateCyborgTankBrain();
            CreateCyborgMeleeBrain();
            CreateCyborgWizardBrain();
        }

        public static void CreateCyborgTankBrain() {

            var CyborgTankBrain = Helpers.CreateBlueprint<BlueprintBrain>(HEContext, "CyborgTankBrain", bp => {
                bp.m_Actions = new BlueprintAiActionReference[]
               {
                    AiCastSpellList.AttackAiAction.ToReference<BlueprintAiActionReference>(),
                    AiCastSpellList.MinotaurGhost_Boss_DazzlingDisplayAIAction.ToReference<BlueprintAiActionReference>(),

               };
            });
        }

        public static void CreateCyborgMeleeBrain() {

            var CyborgMeleeBrain = Helpers.CreateBlueprint<BlueprintBrain>(HEContext, "CyborgMeleeBrain", bp => {
                bp.m_Actions = new BlueprintAiActionReference[]
               {
                    AiCastSpellList.AttackAiAction.ToReference<BlueprintAiActionReference>(),
                    AiCastSpellList.ChargeAiAction.ToReference<BlueprintAiActionReference>(),
                    GreaterVitalStrikeAiSpell.ToReference<BlueprintAiActionReference>(),
               };
            });
        }

        public static void CreateCyborgWizardBrain() {

            var CyborgWizardBrain = Helpers.CreateBlueprint<BlueprintBrain>(HEContext, "CyborgWizardBrain", bp => {
                bp.m_Actions = new BlueprintAiActionReference[]
               {
                    AiCastSpellList.AcidSplashAiAction.ToReference<BlueprintAiActionReference>(),
                    MirrorImageAiSpell.ToReference<BlueprintAiActionReference>(),
                    MagicMissileAiSpell.ToReference<BlueprintAiActionReference>(),
                    InvisibilityGreaterAiSpell.ToReference<BlueprintAiActionReference>(),
                    GreaseAiSpell.ToReference<BlueprintAiActionReference>(),
                    AnimateDeadAiSpell.ToReference<BlueprintAiActionReference>(),
                    StinkingCloudAiSpell.ToReference<BlueprintAiActionReference>(),
                    SummonMonsterVAiSpell.ToReference<BlueprintAiActionReference>(),
                    HungryPitAiSpell.ToReference<BlueprintAiActionReference>(),
                    BurningArcAiSpell.ToReference<BlueprintAiActionReference>(),
                    IcyPrisonAiSpell.ToReference<BlueprintAiActionReference>(),
                    FireballAiSpell.ToReference<BlueprintAiActionReference>(),
               };
            });
        }
    }
}


