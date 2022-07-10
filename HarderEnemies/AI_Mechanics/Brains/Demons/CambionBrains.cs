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
    internal class CambionBrains {


        public static void Handler() {
            CreateCambionRangedBrain();
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
    }
}
