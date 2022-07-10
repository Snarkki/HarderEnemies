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

namespace HarderEnemies.AI_Mechanics.Brains.Others {
    internal class DevastatorBrains {
        public static void CreateDevastatorBrain() {
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
