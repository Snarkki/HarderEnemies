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
    internal class MinotaurBrains {


        private static BlueprintAiCastSpell MinotaurTrampleAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "MinotaurTrampleAiSpell");
        private static BlueprintAiCastSpell MinotaurBullRushAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "MinotaurBullRushAiSpell");



        public static void Handler() {
            CreateCleaveMinotaurBrain();
            CreateChargingMinotaurBrain();
        }


        public static void CreateCleaveMinotaurBrain() {
            var CleaveMinotaurBrain = Helpers.CreateBlueprint<BlueprintBrain>(HEContext, "CleaveMinotaurBrain", bp => {
                bp.m_Actions = new BlueprintAiActionReference[]
               {
                    AiCastSpellList.AttackAiAction.ToReference<BlueprintAiActionReference>(),
                    AiCastSpellList.ChargeAiAction.ToReference<BlueprintAiActionReference>(),
                    AiCastSpellList.GreatCleaveAiAction.ToReference<BlueprintAiActionReference>(),
               };
            });
        }

        public static void CreateChargingMinotaurBrain() {
            var CleaveMinotaurBrain = Helpers.CreateBlueprint<BlueprintBrain>(HEContext, "CleaveMinotaurBrain", bp => {
                bp.m_Actions = new BlueprintAiActionReference[]
               {
                    AiCastSpellList.AttackAiAction.ToReference<BlueprintAiActionReference>(),
                    MinotaurTrampleAiSpell.ToReference<BlueprintAiActionReference>(),
                    MinotaurBullRushAiSpell.ToReference<BlueprintAiActionReference>(),
               };
            });
        }

    }
}
