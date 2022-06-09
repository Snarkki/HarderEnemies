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

namespace HarderEnemies.AI_Mechanics.Brains {
    internal class DemonBrains {

        public static void DemonBrainHandler() {
            CreateDerakniBrain();
            CreateDevastatorBrain();
        }

        private static void CreateDerakniBrain() {
            var DerakniNewStandardBrain = Helpers.CreateBlueprint<BlueprintBrain>(HEContext, "DerakniNewStandardBrain", bp => {
                bp.m_Actions = new BlueprintAiActionReference[]
               {
                    AiCastSpellList.AttackAiAction.ToReference<BlueprintAiActionReference>(),
                    AiCastSpellList.DerakniDroneAiAction.ToReference<BlueprintAiActionReference>(),
                    AiCastSpellList.Derakni_AiAction_BacklineTeleportation.ToReference<BlueprintAiActionReference>(),
                    AiCastSpellList.Derakni_AiAction_Enervation.ToReference<BlueprintAiActionReference>(),
               };
            });
        }
        private static void CreateDevastatorBrain() {
            var DevastatorNewStandardBrain = Helpers.CreateBlueprint<BlueprintBrain>(HEContext, "DevastatorNewStandardBrain", bp => {
                bp.m_Actions = new BlueprintAiActionReference[]
               {
                    AiCastSpellList.AttackAiAction.ToReference<BlueprintAiActionReference>(),
                    AiCastSpellList.Devastator_AiAction_BladeBarrier.ToReference<BlueprintAiActionReference>(),
                    AiCastSpellList.Devastator_AiAction_Blasphemy.ToReference<BlueprintAiActionReference>(),
                    AiCastSpellList.Devastator_AiAction_Destruction.ToReference<BlueprintAiActionReference>(),
               };
            });
        }
    }
}
