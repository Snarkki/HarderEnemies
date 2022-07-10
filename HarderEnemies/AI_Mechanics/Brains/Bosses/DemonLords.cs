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

    internal class DemonLords {

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

        public static void Handler() {
            CreateNocticulaBrain();
            CreateDeskariBrain();
            CreateAreeluBrain();
        }

        private static void CreateNocticulaBrain() {

            var NocticulaAltBrain = Helpers.CreateBlueprint<BlueprintBrain>(HEContext, "NocticulaAltBrain", bp => {
                bp.m_Actions = new BlueprintAiActionReference[]
               {
                    GreaterDispelAiSpellSwift.ToReference<BlueprintAiActionReference>(),
                    StormBoltAiSpell.ToReference<BlueprintAiActionReference>(),
                    CreateRiftOfRuinAiSpell.ToReference<BlueprintAiActionReference>(),
                    FirestormEmpoweredAiSpell.ToReference<BlueprintAiActionReference>(),
               };
            });

        }
        private static void CreateDeskariBrain() {
            var DeskariAltBrain = Helpers.CreateBlueprint<BlueprintBrain>(HEContext, "DeskariAltBrain", bp => {
                bp.m_Actions = new BlueprintAiActionReference[]
               {
                    EdictOfInvulnerabilityAiSpell.ToReference<BlueprintAiActionReference>(),
                    CreateMythicSwarmsAiSpell.ToReference<BlueprintAiActionReference>(),

               };
            });
        }

        private static void CreateAreeluBrain() {
            var AreeluAltBrain = Helpers.CreateBlueprint<BlueprintBrain>(HEContext, "AreeluAltBrain", bp => {
                bp.m_Actions = new BlueprintAiActionReference[]
               {
                    EdictOfInvulnerabilityAiSpell.ToReference<BlueprintAiActionReference>(),
                    OpenGateAiSpell.ToReference<BlueprintAiActionReference>(),
                    Blueprints.AiCastSpellList.ColyphyrBaphomet_CommandGreater_AIAction.ToReference<BlueprintAiActionReference>(),
                    StormBoltAiSpell.ToReference<BlueprintAiActionReference>(),
                    GreaterDispelAiSpellSwift.ToReference<BlueprintAiActionReference>(),
                    Blueprints.AiCastSpellList.NocticulaPriestess_AiAction_OverwhelmingPrescence.ToReference<BlueprintAiActionReference>(),
               };
            });
        }
    }
}
