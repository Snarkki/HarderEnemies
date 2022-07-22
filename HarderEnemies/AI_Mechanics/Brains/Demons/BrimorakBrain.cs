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
    internal class BrimorakBrain {

        private static BlueprintAiCastSpell AcidArrowAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "AcidArrowAiSpell");
        private static BlueprintAiCastSpell BurningArcAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "BurningArcAiSpell");
        private static BlueprintAiCastSpell FireballAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "FireballAiSpell");
        private static BlueprintAiCastSpell GreenDragonsBreathAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "BurningArcAiSpell");
        private static BlueprintAiCastSpell BrimorakBreathAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "BrimorakBreathAiSpell");


        public static void CreateBrimorakBrain() {
            var BrimorakBrain = Helpers.CreateBlueprint<BlueprintBrain>(HEContext, "BrimorakBrain", bp => {
                bp.m_Actions = new BlueprintAiActionReference[]
               {
                    AiCastSpellList.AttackAiAction.ToReference<BlueprintAiActionReference>(),
                    AcidArrowAiSpell.ToReference<BlueprintAiActionReference>(),
                    BurningArcAiSpell.ToReference<BlueprintAiActionReference>(),
                    FireballAiSpell.ToReference<BlueprintAiActionReference>(),
                    AcidArrowAiSpell.ToReference<BlueprintAiActionReference>(),
                    GreenDragonsBreathAiSpell.ToReference<BlueprintAiActionReference>(),
                    BrimorakBreathAiSpell.ToReference<BlueprintAiActionReference>(),
               };
            });
        }
    }
}
