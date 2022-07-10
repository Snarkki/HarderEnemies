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
    internal class AngelBrains {
        private static BlueprintAiCastSpell MirrorImageAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "MirrorImageAiSpell");
        private static BlueprintAiCastSpell InvisibilityGreaterAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "InvisibilityGreaterAiSpell");
        private static BlueprintAiCastSpell LegendaryProportionsAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "LegendaryProportionsAiSpell");


        public static void Handler() {
            CreateMidnightFaneBrain();

        }

        private static void CreateMidnightFaneBrain() {
            var AngelMidnightFaneBrain = Helpers.CreateBlueprint<BlueprintBrain>(HEContext, "AngelMidnightFaneBrain", bp => {
                bp.m_Actions = new BlueprintAiActionReference[]
               {
                    AiCastSpellList.AttackAiAction.ToReference<BlueprintAiActionReference>(),
                    AiCastSpellList.MonadicDevaHealAiAction.ToReference<BlueprintAiActionReference>(),
                    AiCastSpellList.MonadicDevaHolyAuraAiAction.ToReference<BlueprintAiActionReference>(),
                    AiCastSpellList.MovanicDevaHolySmiteAiAction.ToReference<BlueprintAiActionReference>(),
                    MirrorImageAiSpell.ToReference<BlueprintAiActionReference>(),
                    InvisibilityGreaterAiSpell.ToReference<BlueprintAiActionReference>(),
                    LegendaryProportionsAiSpell.ToReference<BlueprintAiActionReference>(),
               };
            });
        }
    }
}
