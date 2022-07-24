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

namespace HarderEnemies.AI_Mechanics.Brains.Demons {
    internal class CambionBrains {

        private static BlueprintAiCastSpell HideousLaughterAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "HideousLaughterAiSpell");
        private static BlueprintAiCastSpell InvisibilityGreaterAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "InvisibilityGreaterAiSpell");
        private static BlueprintAiCastSpell DominatePersonAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "DominatePersonAiSpell");
        private static BlueprintAiCastSpell ShoutAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "ShoutAiSpell");
        private static BlueprintAiCastSpell SerenityAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "SerenityAiSpell");
        private static BlueprintAiCastSpell HasteAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "HasteAiSpell");



        public static void Handler() {
            CreateCambionRangedBrain();
            CreateCambionBardBrains();
        }
        private static void CreateCambionRangedBrain() {
            var CambionRangedBrain = Helpers.CreateBlueprint<BlueprintBrain>(HEContext, "CambionRangedBrain", bp => {
                bp.m_Actions = new BlueprintAiActionReference[]
               {
                   //AiCastSpellList.AttackAiAction.ToReference<BlueprintAiActionReference>(),
                   AiCastSpellList.SuccubusRangedFighter_AiAttack_FocusCasters.ToReference<BlueprintAiActionReference>(),
                  // AiCastSpellList.SwitchToMeleeAiAcition.ToReference<BlueprintAiActionReference>(),
               };
            });
        }

        private static void CreateCambionBardBrains() {

            //CR14_CambionBard_Ranged,
            //CR19_CambionBard_Melee,
            //CR3_CambionBard_Ranged
            var CambionCr14BardBrain = Helpers.CreateBlueprint<BlueprintBrain>(HEContext, "CambionCr14BardBrain", bp => {
                bp.m_Actions = new BlueprintAiActionReference[]
               {
                   AiCastSpellList.AttackAiAction.ToReference<BlueprintAiActionReference>(),
                   AiCastSpellList.Nurah_InspireCourageAiAction.ToReference<BlueprintAiActionReference>(),
                   SerenityAiSpell.ToReference<BlueprintAiActionReference>(),
                   ShoutAiSpell.ToReference<BlueprintAiActionReference>(),
                   DominatePersonAiSpell.ToReference<BlueprintAiActionReference>(),
                   InvisibilityGreaterAiSpell.ToReference<BlueprintAiActionReference>(),
               };
            });

            var CambionCr19BardBrain = Helpers.CreateBlueprint<BlueprintBrain>(HEContext, "CambionCr19BardBrain", bp => {
                bp.m_Actions = new BlueprintAiActionReference[]
               {
                   AiCastSpellList.AttackAiAction.ToReference<BlueprintAiActionReference>(),
                   AiCastSpellList.Nurah_InspireCourageAiAction.ToReference<BlueprintAiActionReference>(),
                   HasteAiSpell.ToReference<BlueprintAiActionReference>(),
                   AiCastSpellList.AssasinKitsuneMagus_AiAction_InspireTranquility.ToReference<BlueprintAiActionReference>(),
               };
            });

            var CambionCR3BardBrain = Helpers.CreateBlueprint<BlueprintBrain>(HEContext, "CambionCR3BardBrain", bp => {
                bp.m_Actions = new BlueprintAiActionReference[]
               {
                   AiCastSpellList.AttackAiAction.ToReference<BlueprintAiActionReference>(),
                   AiCastSpellList.Nurah_InspireCourageAiAction.ToReference<BlueprintAiActionReference>(),
                   HideousLaughterAiSpell.ToReference<BlueprintAiActionReference>(),

               };
            });
        }

    }
}

