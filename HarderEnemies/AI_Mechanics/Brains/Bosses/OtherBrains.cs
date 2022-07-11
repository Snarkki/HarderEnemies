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
    internal class OtherBrains {

        private static BlueprintAiCastSpell GreaterDispelAiSpellSwift = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "GreaterDispelAiSpellSwift");
        private static BlueprintAiCastSpell StormBoltAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "StormBoltAiSpell");
        private static BlueprintAiCastSpell BurningArcAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "BurningArcAiSpell");
        private static BlueprintAiCastSpell SlowAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "SlowAiSpell");
        private static BlueprintAiCastSpell ScorchingRayAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "ScorchingRayAiSpell");
        private static BlueprintAiCastSpell HoldPersonMassAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "HoldPersonMassAiSpell");
        private static BlueprintAiCastSpell FearAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "FearAiSpell");
        private static BlueprintAiCastSpell SummonMonsterViiAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "SummonMonsterViiAiSpell");
        private static BlueprintAiCastSpell GreaterInvisibilityAiSpellSwift = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "GreaterInvisibilityAiSpellSwift");
        private static BlueprintAiCastSpell PhantasmalPutreficationAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "PhantasmalPutreficationAiSpell");
        private static BlueprintAiCastSpell PowerWordBlindAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "PowerWordBlindAiSpell");
        private static BlueprintAiCastSpell FirestormEmpoweredAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "FirestormEmpoweredAiSpell");
        private static BlueprintAiCastSpell ChainLightningAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "ChainLightningAiSpell");
        private static BlueprintAiCastSpell CreateRiftOfRuinAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "CreateRiftOfRuinAiSpell");



        public static void Handler() {
            CreateJerribethBrain();
            CreateMinaghoBrain();
        }

        private static void CreateJerribethBrain() {

            AiCastSpellList.Jerribeth_FeeblemindAIAction.BaseScore = 9.0f;
            AiCastSpellList.Jerribeth_PhantasmalPutrefactionAIAction.BaseScore = 9.0f;
            AiCastSpellList.Jerribeth_SlumberAIAction.BaseScore = 5.5f;
            AiCastSpellList.Jerribeth_DeathClutchAIAction.BaseScore = 5.5f;

            var JerribethBrain = Helpers.CreateBlueprint<BlueprintBrain>(HEContext, "JerribethBrain", bp => {
                bp.m_Actions = new BlueprintAiActionReference[]
               {
                   AiCastSpellList.AttackAiAction.ToReference<BlueprintAiActionReference>(),
                   AiCastSpellList.Jerribeth_MindFogAIAction.ToReference<BlueprintAiActionReference>(),
                   AiCastSpellList.Jerribeth_DominateMonsterAIAction.ToReference<BlueprintAiActionReference>(),
                   BurningArcAiSpell.ToReference<BlueprintAiActionReference>(),
                   GreaterDispelAiSpellSwift.ToReference<BlueprintAiActionReference>(),
                   StormBoltAiSpell.ToReference<BlueprintAiActionReference>(),
                   SummonMonsterViiAiSpell.ToReference<BlueprintAiActionReference>(),
                   FearAiSpell.ToReference<BlueprintAiActionReference>(),
                   HoldPersonMassAiSpell.ToReference<BlueprintAiActionReference>(),
                   SlowAiSpell.ToReference<BlueprintAiActionReference>(),
                   ScorchingRayAiSpell.ToReference<BlueprintAiActionReference>(),
                   GreaterInvisibilityAiSpellSwift.ToReference<BlueprintAiActionReference>(),
                   AiCastSpellList.Jerribeth_FeeblemindAIAction.ToReference<BlueprintAiActionReference>(),
                   AiCastSpellList.Jerribeth_PhantasmalPutrefactionAIAction.ToReference<BlueprintAiActionReference>(),
                   AiCastSpellList.Jerribeth_SlumberAIAction.ToReference<BlueprintAiActionReference>(),
                   AiCastSpellList.Jerribeth_DeathClutchAIAction.ToReference<BlueprintAiActionReference>(),
               };
            });
        }

        private static void CreateMinaghoBrain() {

            AiCastSpellList.Minagho_WitchHexSlumberAiAction.BaseScore = 5.0f;

            var MinaghoBrain = Helpers.CreateBlueprint<BlueprintBrain>(HEContext, "MinaghoBrain", bp => {
                bp.m_Actions = new BlueprintAiActionReference[]
               {
                   AiCastSpellList.AttackAiActionNoSleep.ToReference<BlueprintAiActionReference>(),
                   AiCastSpellList.Minagho_AiAction_CombatInstantPrecast.ToReference<BlueprintAiActionReference>(),
                   AiCastSpellList.Minagho_WitchHexSlumberAiAction.ToReference<BlueprintAiActionReference>(),
                   GreaterDispelAiSpellSwift.ToReference<BlueprintAiActionReference>(),
                   PowerWordBlindAiSpell.ToReference<BlueprintAiActionReference>(),
                   FirestormEmpoweredAiSpell.ToReference<BlueprintAiActionReference>(),
                   ChainLightningAiSpell.ToReference<BlueprintAiActionReference>(),
                   CreateRiftOfRuinAiSpell.ToReference<BlueprintAiActionReference>(),
                   PhantasmalPutreficationAiSpell.ToReference<BlueprintAiActionReference>(),
               };
            });
        }

    }
}
