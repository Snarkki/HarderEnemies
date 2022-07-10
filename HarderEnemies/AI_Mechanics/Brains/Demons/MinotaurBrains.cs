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
        private static BlueprintAiCastSpell InvisibilityGreaterAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "InvisibilityGreaterAiSpell");
        private static BlueprintAiCastSpell SenseVitalsAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "SenseVitalsAiSpell");
        private static BlueprintAiCastSpell SwiftScorchingRayAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "SwiftScorchingRayAiSpell");
        private static BlueprintAiCastSpell HellFireMaximized = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "HellFireMaximized");
        private static BlueprintAiCastSpell SiroccoAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "SiroccoAiSpell");



        public static void Handler() {
            CreateCleaveMinotaurBrain();
            CreateChargingMinotaurBrain();
            CreateBlasterMinotaurBrain();
            CreateClericMinotaurBrain();
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
            var ChargingMinotaurBrain = Helpers.CreateBlueprint<BlueprintBrain>(HEContext, "ChargingMinotaurBrain", bp => {
                bp.m_Actions = new BlueprintAiActionReference[]
               {
                    AiCastSpellList.AttackAiAction.ToReference<BlueprintAiActionReference>(),
                    MinotaurTrampleAiSpell.ToReference<BlueprintAiActionReference>(),
                    MinotaurBullRushAiSpell.ToReference<BlueprintAiActionReference>(),
               };
            });
        }
        public static void CreateBlasterMinotaurBrain() {
            var BlasterMinotaurBrain = Helpers.CreateBlueprint<BlueprintBrain>(HEContext, "BlasterMinotaurBrain", bp => {
                bp.m_Actions = new BlueprintAiActionReference[]
               {
                    AiCastSpellList.AttackAiAction.ToReference<BlueprintAiActionReference>(),
                    InvisibilityGreaterAiSpell.ToReference<BlueprintAiActionReference>(),
                    SenseVitalsAiSpell.ToReference<BlueprintAiActionReference>(),
                    SwiftScorchingRayAiSpell.ToReference<BlueprintAiActionReference>(),
                    HellFireMaximized.ToReference<BlueprintAiActionReference>(),
                    SiroccoAiSpell.ToReference<BlueprintAiActionReference>(),
               };
            });
        }
        public static void CreateClericMinotaurBrain() {
            var ClericMinotaurBrain = Helpers.CreateBlueprint<BlueprintBrain>(HEContext, "ClericMinotaurBrain", bp => {
                bp.m_Actions = new BlueprintAiActionReference[]
               {
                    AiCastSpellList.AttackAiAction.ToReference<BlueprintAiActionReference>(),
                    AiCastSpellList.MinotaurCleric_BladeBarrierAiAction.ToReference<BlueprintAiActionReference>(),
                    AiCastSpellList.MinotaurCleric_BoneshakerAiAction.ToReference<BlueprintAiActionReference>(),
                    AiCastSpellList.MinotaurCleric_DispelMagicAiAction.ToReference<BlueprintAiActionReference>(),
                    AiCastSpellList.MinotaurCleric_FlameStrikeAiAction.ToReference<BlueprintAiActionReference>(),
                    AiCastSpellList.MinotaurCleric_HellfireRayAiAction.ToReference<BlueprintAiActionReference>(),
                    AiCastSpellList.MinotaurCleric_UnholyBlightAiAction.ToReference<BlueprintAiActionReference>(),
                    AiCastSpellList.MinotaurCleric_HealAiAction.ToReference<BlueprintAiActionReference>(),
               };
            });
        }

    }
}
