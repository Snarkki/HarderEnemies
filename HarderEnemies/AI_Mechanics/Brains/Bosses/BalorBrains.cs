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

namespace HarderEnemies.AI_Mechanics.Brains.Bosses {
    internal class BalorBrains {


        private static BlueprintAiCastSpell PullingStrikeAiAction = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "PullingStrikeAiAction");
        private static BlueprintAiCastSpell StormBoltAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "StormBoltAiSpell");
        private static BlueprintAiCastSpell FirestormEmpoweredAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "FirestormEmpoweredAiSpell");
        private static BlueprintAiCastSpell BlasphemyAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "BlasphemyAiSpell");
        private static BlueprintAiCastSpell NewFlameStrikeAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "NewFlameStrikeAiSpell");
        private static BlueprintAiCastSpell MirrorImageAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "MirrorImageAiSpell");
        private static BlueprintAiCastSpell InvisibilityGreaterAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "InvisibilityGreaterAiSpell");
        private static BlueprintAiCastSpell MindBlankAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "MindBlankAiSpell");
        private static BlueprintAiCastSpell LegendaryProportionsAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "LegendaryProportionsAiSpell");
        private static BlueprintAiCastSpell GreaterDispelAiSpellSwift = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "GreaterDispelAiSpellSwift");
        private static BlueprintAiCastSpell OverwhelmingPresenceAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "OverwhelmingPresenceAiSpell");
        private static BlueprintAiCastSpell HoldPersonMassAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "HoldPersonMassAiSpell");
        private static BlueprintAiCastSpell GreaterShoutAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "GreaterShoutAiSpell");
        private static BlueprintAiAttack ThreatenedAiAttack = BlueprintTools.GetModBlueprint<BlueprintAiAttack>(HEContext, "ThreatenedAiAttack");
        private static BlueprintAiCastSpell GreaterVitalStrikeAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "GreaterVitalStrikeAiSpell");


        public static void Handler() {
            CreateDarrazandBrain();
            CreateMeleeBalorBrain();
            CreateCasterBalorBrain();
            CreateMythicBalorBrain();
        }


        public static void CreateDarrazandBrain() {
            var DarrazandBrain = Helpers.CreateBlueprint<BlueprintBrain>(HEContext, "DarrazandBrain", bp => {
                bp.m_Actions = new BlueprintAiActionReference[]
               {
                    AiCastSpellList.AttackAiAction.ToReference<BlueprintAiActionReference>(),
                        ThreatenedAiAttack.ToReference<BlueprintAiActionReference>(),
                        PullingStrikeAiAction.ToReference<BlueprintAiActionReference>(),
                        BlasphemyAiSpell.ToReference<BlueprintAiActionReference>(),
                        NewFlameStrikeAiSpell.ToReference<BlueprintAiActionReference>(),
                        FirestormEmpoweredAiSpell.ToReference<BlueprintAiActionReference>(),
                        StormBoltAiSpell.ToReference<BlueprintAiActionReference>(),
                        MirrorImageAiSpell.ToReference<BlueprintAiActionReference>(),
                        InvisibilityGreaterAiSpell.ToReference<BlueprintAiActionReference>(),
                        MindBlankAiSpell.ToReference<BlueprintAiActionReference>(),
                        LegendaryProportionsAiSpell.ToReference<BlueprintAiActionReference>(),
                        GreaterDispelAiSpellSwift.ToReference<BlueprintAiActionReference>(),
               };
            });
        }

        public static void CreateMeleeBalorBrain() {
            var MeleeBalorBrain = Helpers.CreateBlueprint<BlueprintBrain>(HEContext, "MeleeBalorBrain", bp => {
                bp.m_Actions = new BlueprintAiActionReference[]
               {
                    AiCastSpellList.AttackAiAction.ToReference<BlueprintAiActionReference>(),
                    AiCastSpellList.Baphomet_DemonTeleportAIAction.ToReference<BlueprintAiActionReference>(),
                    PullingStrikeAiAction.ToReference<BlueprintAiActionReference>(),
                    BlasphemyAiSpell.ToReference<BlueprintAiActionReference>(),
                    MirrorImageAiSpell.ToReference<BlueprintAiActionReference>(),
                    InvisibilityGreaterAiSpell.ToReference<BlueprintAiActionReference>(),
                    MindBlankAiSpell.ToReference<BlueprintAiActionReference>(),
                    LegendaryProportionsAiSpell.ToReference<BlueprintAiActionReference>(),
                    GreaterDispelAiSpellSwift.ToReference<BlueprintAiActionReference>(),
               };
            });
        }

        public static void CreateCasterBalorBrain() {
            var CasterBalorBrain = Helpers.CreateBlueprint<BlueprintBrain>(HEContext, "CasterBalorBrain", bp => {
                bp.m_Actions = new BlueprintAiActionReference[]
               {
                    AiCastSpellList.AttackAiAction.ToReference<BlueprintAiActionReference>(),
                        BlasphemyAiSpell.ToReference<BlueprintAiActionReference>(),
                        NewFlameStrikeAiSpell.ToReference<BlueprintAiActionReference>(),
                        FirestormEmpoweredAiSpell.ToReference<BlueprintAiActionReference>(),
                        StormBoltAiSpell.ToReference<BlueprintAiActionReference>(),
                        MirrorImageAiSpell.ToReference<BlueprintAiActionReference>(),
                        InvisibilityGreaterAiSpell.ToReference<BlueprintAiActionReference>(),
                        MindBlankAiSpell.ToReference<BlueprintAiActionReference>(),
                        LegendaryProportionsAiSpell.ToReference<BlueprintAiActionReference>(),
                        GreaterDispelAiSpellSwift.ToReference<BlueprintAiActionReference>(),
                        HoldPersonMassAiSpell.ToReference<BlueprintAiActionReference>(),
                        GreaterShoutAiSpell.ToReference<BlueprintAiActionReference>(),
               };
            });
        }


        public static void CreateMythicBalorBrain() {
            var MythicBalorBrain = Helpers.CreateBlueprint<BlueprintBrain>(HEContext, "MythicBalorBrain", bp => {
                bp.m_Actions = new BlueprintAiActionReference[]
               {
                    AiCastSpellList.AttackAiAction.ToReference<BlueprintAiActionReference>(),
                    AiCastSpellList.Baphomet_DemonTeleportAIAction.ToReference<BlueprintAiActionReference>(),
                    GreaterVitalStrikeAiSpell.ToReference<BlueprintAiActionReference>(),
                    AiCastSpellList.BalorBlasphemyAiAction.ToReference<BlueprintAiActionReference>(),
                    AiCastSpellList.BalorMythic_AbyssalStormAIAction.ToReference<BlueprintAiActionReference>(),
                    AiCastSpellList.BalorMythic_BloodHazeAIAction.ToReference<BlueprintAiActionReference>(),
                    AiCastSpellList.BalorMythic_InfectiousRageAIAction.ToReference<BlueprintAiActionReference>(),
                    AiCastSpellList.BalorMythic_LifebaneAIAction.ToReference<BlueprintAiActionReference>(),
                    AiCastSpellList.BalorMythic_ProfaneHymnAIAction.ToReference<BlueprintAiActionReference>(),
                    MirrorImageAiSpell.ToReference<BlueprintAiActionReference>(),
                    InvisibilityGreaterAiSpell.ToReference<BlueprintAiActionReference>(),
                    MindBlankAiSpell.ToReference<BlueprintAiActionReference>(),
                    OverwhelmingPresenceAiSpell.ToReference<BlueprintAiActionReference>(),
                    GreaterDispelAiSpellSwift.ToReference<BlueprintAiActionReference>(),
               };
            });
        }

    }
}
