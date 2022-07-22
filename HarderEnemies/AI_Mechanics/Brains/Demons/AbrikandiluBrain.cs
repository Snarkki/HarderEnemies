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


namespace HarderEnemies.AI_Mechanics.Brains.Demons {
    internal class AbrikandiluBrain {
        private static BlueprintAiCastSpell HasteAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "HasteAiSpell");
        private static BlueprintAiCastSpell CauseFearAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "HasteAiSpell");


        public static void CreateAbrikandiluBrain() {
            var AbrikandiluBrain = Helpers.CreateBlueprint<BlueprintBrain>(HEContext, "AbrikandiluBrain", bp => {
                bp.m_Actions = new BlueprintAiActionReference[]
               {
                    AiCastSpellList.AttackAiAction.ToReference<BlueprintAiActionReference>(),
                    AiCastSpellList.SunderArmorAiAction.ToReference<BlueprintAiActionReference>(),
                    CauseFearAiSpell.ToReference<BlueprintAiActionReference>(),
                    HasteAiSpell.ToReference<BlueprintAiActionReference>(),
               };
            });
        }
    }
}
