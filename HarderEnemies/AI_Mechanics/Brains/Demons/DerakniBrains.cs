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

namespace HarderEnemies.AI_Mechanics.Brains.DemonsByType {
    internal class DerakniBrains {

        public static void CreateDerakniBrain() {
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
    }
}
