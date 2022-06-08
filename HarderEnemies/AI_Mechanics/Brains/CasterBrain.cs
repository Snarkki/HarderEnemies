using Kingmaker.AI.Blueprints;
using Kingmaker.Blueprints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TabletopTweaks.Core.Utilities;
using static HarderEnemies.Main;


namespace HarderEnemies.AI_Mechanics.Brains {
    public class CasterBrains {

        private static BlueprintAiCastSpell GreaterDispelAiSpellSwift = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "GreaterDispelAiSpellSwift");
        private static BlueprintAiCastSpell BlasphemyAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "BlasphemyAiSpell");
        private static BlueprintAiCastSpell UnholyBlightAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "UnholyBlightAiSpell");
        private static BlueprintAiCastSpell StormBoltAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "StormBoltAiSpell");

        private static BlueprintAiCastSpell CreateRiftOfRuinAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "CreateRiftOfRuinAiSpell");
        private static BlueprintAiCastSpell FirestormEmpoweredAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "FirestormEmpoweredAiSpell");
        private static BlueprintAiCastSpell EdictOfInvulnerabilityAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "EdictOfInvulnerabilityAiSpell");
        private static BlueprintAiCastSpell CreateMythicSwarmsAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "CreateMythicSwarmsAiSpell");
        private static BlueprintAiCastSpell OpenGateAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "OpenGateAiSpell");
        private static BlueprintAiCastSpell GreaterInvisibilityAiSpellSwift = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "GreaterInvisibilityAiSpellSwift");
        private static BlueprintAiCastSpell SummonErineyesAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "SummonErineyesAiSpell");
        private static BlueprintAiCastSpell CreateAcitPitAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "CreateAcitPitAiSpell");
        private static BlueprintAiCastSpell DisintregrateMaximized = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "DisintregrateMaximized");
        private static BlueprintAiCastSpell HellFireMaximized = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "HellFireMaximized");
        
        public static void BrainHandler() {
            CreateDragonAlternativeBrain();
            CreateDemonLordsAlternativeBrains();
            CreateEliteCasterBrains();
        }


        public static void CreateEliteCasterBrains() {

            var SemiEliteCasterAltBrain = Helpers.CreateBlueprint<BlueprintBrain>(HEContext, "SemiEliteCasterAltBrain", bp => {
                bp.m_Actions = new BlueprintAiActionReference[]
               {
                    GreaterDispelAiSpellSwift.ToReference<BlueprintAiActionReference>(),
                    StormBoltAiSpell.ToReference<BlueprintAiActionReference>(),
                    CreateAcitPitAiSpell.ToReference<BlueprintAiActionReference>(),
                    GreaterInvisibilityAiSpellSwift.ToReference<BlueprintAiActionReference>(),
                    DisintregrateMaximized.ToReference<BlueprintAiActionReference>(),
               };
            });

            var EliteCasterAltBrain = Helpers.CreateBlueprint<BlueprintBrain>(HEContext, "EliteCasterAltBrain", bp => {
                bp.m_Actions = new BlueprintAiActionReference[]
               {
                    GreaterDispelAiSpellSwift.ToReference<BlueprintAiActionReference>(),
                    StormBoltAiSpell.ToReference<BlueprintAiActionReference>(),
                    CreateRiftOfRuinAiSpell.ToReference<BlueprintAiActionReference>(),
                    GreaterDispelAiSpellSwift.ToReference<BlueprintAiActionReference>(),
                    FirestormEmpoweredAiSpell.ToReference<BlueprintAiActionReference>(),
                    EdictOfInvulnerabilityAiSpell.ToReference<BlueprintAiActionReference>(),
                    GreaterInvisibilityAiSpellSwift.ToReference<BlueprintAiActionReference>(),
                    Blueprints.AiCastSpellList.OverWhelmingPrecenceAiSpell.ToReference<BlueprintAiActionReference>(),
                    SummonErineyesAiSpell.ToReference<BlueprintAiActionReference>(),
                    HellFireMaximized.ToReference<BlueprintAiActionReference>(),
                    Blueprints.AiCastSpellList.FullCasterBoss_Wail_AiSpell.ToReference<BlueprintAiActionReference>(),
                    Blueprints.AiCastSpellList.Xorges_HorridWilting_AiSpell.ToReference<BlueprintAiActionReference>(),
               };
            });
        }
   

        public static void CreateDragonAlternativeBrain() {

            var DragonAltBrain = Helpers.CreateBlueprint<BlueprintBrain>(HEContext, "DragonAltBrain", bp => {
                bp.m_Actions = new BlueprintAiActionReference[]
               {
                    GreaterDispelAiSpellSwift.ToReference<BlueprintAiActionReference>(),
                    BlasphemyAiSpell.ToReference<BlueprintAiActionReference>(),
                    UnholyBlightAiSpell.ToReference<BlueprintAiActionReference>(),
                    StormBoltAiSpell.ToReference<BlueprintAiActionReference>()
               };
            });
        }

        public static void CreateDemonLordsAlternativeBrains() {
            
            var NocticulaAltBrain = Helpers.CreateBlueprint<BlueprintBrain>(HEContext, "NocticulaAltBrain", bp => {
                bp.m_Actions = new BlueprintAiActionReference[]
               {
                    GreaterDispelAiSpellSwift.ToReference<BlueprintAiActionReference>(),
                    StormBoltAiSpell.ToReference<BlueprintAiActionReference>(),
                    CreateRiftOfRuinAiSpell.ToReference<BlueprintAiActionReference>(),
                    FirestormEmpoweredAiSpell.ToReference<BlueprintAiActionReference>(),
               };
            });

            var DeskariAltBrain = Helpers.CreateBlueprint<BlueprintBrain>(HEContext, "DeskariAltBrain", bp => {
                bp.m_Actions = new BlueprintAiActionReference[]
               {
                    EdictOfInvulnerabilityAiSpell.ToReference<BlueprintAiActionReference>(),
                    CreateMythicSwarmsAiSpell.ToReference<BlueprintAiActionReference>(),

               };
            });

            var AreeluAltBrain = Helpers.CreateBlueprint<BlueprintBrain>(HEContext, "AreeluAltBrain", bp => {
                bp.m_Actions = new BlueprintAiActionReference[]
               {
                    EdictOfInvulnerabilityAiSpell.ToReference<BlueprintAiActionReference>(),
                    OpenGateAiSpell.ToReference<BlueprintAiActionReference>(),
                    Blueprints.AiCastSpellList.CommandGreaterFallAiSpell.ToReference<BlueprintAiActionReference>(),
                    StormBoltAiSpell.ToReference<BlueprintAiActionReference>(),
                    GreaterDispelAiSpellSwift.ToReference<BlueprintAiActionReference>(),
                    Blueprints.AiCastSpellList.OverWhelmingPrecenceAiSpell.ToReference<BlueprintAiActionReference>(),
               };
            });
        }


    }
}