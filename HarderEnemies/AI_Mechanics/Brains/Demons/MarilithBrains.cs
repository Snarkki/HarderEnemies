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


namespace HarderEnemies.AI_Mechanics.Brains.DemonsByType {
    internal class MarilithBrains {
        private static BlueprintAiCastSpell BladeBarrierAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "BladeBarrierAiSpell");



        public static void CreateMarilithBrains() {
            var StandardMarilithBrain = Helpers.CreateBlueprint<BlueprintBrain>(HEContext, "StandardMarilithBrain", bp => {
                bp.m_Actions = new BlueprintAiActionReference[]
               {
                    AiCastSpellList.AttackAiAction.ToReference<BlueprintAiActionReference>(),
                    BladeBarrierAiSpell.ToReference<BlueprintAiActionReference>(),

               };
            });

            var SlayerMarilithBrain = Helpers.CreateBlueprint<BlueprintBrain>(HEContext, "SlayerMarilithBrain", bp => {
                bp.m_Actions = new BlueprintAiActionReference[]
               {
                   AiCastSpellList.AttackAiAction.ToReference<BlueprintAiActionReference>(),
                   AiCastSpellList.Slayer_AiAction_StudySwift.ToReference<BlueprintAiActionReference>(),
                   BladeBarrierAiSpell.ToReference<BlueprintAiActionReference>(),
               };
            });
        }
    }
}
