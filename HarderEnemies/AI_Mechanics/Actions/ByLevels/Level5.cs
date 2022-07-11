using Kingmaker.AI.Blueprints;
using Kingmaker.AI.Blueprints.Considerations;
using Kingmaker.Blueprints;
using Kingmaker.Blueprints.Classes;
using Kingmaker.RuleSystem;
using Kingmaker.UnitLogic.Abilities.Blueprints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TabletopTweaks.Core.Utilities;
using HarderEnemies.Blueprints;
using static HarderEnemies.Main;

namespace HarderEnemies.AI_Mechanics.Actions.ByLevels {
    internal class Level5 {

        public static void Handler() {
            var IcyPrisonAiSpell = AiCastSpellList.CultistEvokerIcyPrisonAiAction.CreateCopy(HEContext, "IcyPrisonAiSpell", bp => {
                bp.BaseScore = 5.0f;
                bp.StartCooldownRounds = 1;
                bp.CooldownRounds = 2;
                bp.CooldownDice = new DiceFormula(3, DiceType.D3);
                bp.m_ActorConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.ChaoticBehaviour.ToReference<ConsiderationReference>(),
                };
            });

            var PhantasmalWebAiSpell = AiCastSpellList.ShadowcasterPhantasmalWebAiAction.CreateCopy(HEContext, "PhantasmalWebAiSpell", bp => {
                bp.BaseScore = 5.0f;
                bp.StartCooldownRounds = 1;
                bp.CooldownRounds = 2;
                bp.CooldownDice = new DiceFormula(3, DiceType.D3);
                bp.m_ActorConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.ChaoticBehaviour.ToReference<ConsiderationReference>(),
                };
            });
            var CommandGreaterAiSpell = AiCastSpellList.Svendack_AiAction_CommandGreater.CreateCopy(HEContext, "CommandGreaterAiSpell", bp => {
                bp.BaseScore = 6.0f;
                bp.StartCooldownRounds = 1;
                bp.CooldownRounds = 2;
                bp.CooldownDice = new DiceFormula(3, DiceType.D3);
                bp.m_ActorConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.ChaoticBehaviour.ToReference<ConsiderationReference>(),
                    AiConsiderationList.NoThreateningUnitsConsideration.ToReference<ConsiderationReference>()
                };
            });

            var WavesOfFatigueAiSpell = AiCastSpellList.Minagho_WavesOfFatigueAiAction.CreateCopy(HEContext, "WavesOfFatigueAiSpell", bp => {
                bp.BaseScore = 6.0f;
                bp.StartCooldownRounds = 1;
                bp.CooldownRounds = 5;
                bp.CooldownDice = new DiceFormula(3, DiceType.D4);
                bp.m_ActorConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.ChaoticBehaviour.ToReference<ConsiderationReference>(),
                };
            });

            var HungryPitAiSpell = AiCastSpellList.StinkingCloudAiAction.CreateCopy(HEContext, "HungryPitAiSpell", bp => {
                bp.BaseScore = 4.0f;
                bp.StartCooldownRounds = 1;
                bp.CooldownRounds = 5;
                bp.CooldownDice = new DiceFormula(3, DiceType.D4);
                bp.m_Ability = Abilities.HungryPit.ToReference<BlueprintAbilityReference>();
                bp.m_ActorConsiderations = new ConsiderationReference[] {
                   AiConsiderationList.ChaoticBehaviour.ToReference<ConsiderationReference>()
                };
                bp.m_TargetConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.AoE_AvoidSelf.ToReference<ConsiderationReference>(),
                    AiConsiderationList.AoE_ChooseMoreEnemies.ToReference<ConsiderationReference>()
                };
            });

            var SummonMonsterVAiSpell = AiCastSpellList.Xantir_SummonMonsterVIAIAction.CreateCopy(HEContext, "SummonMonsterVAiSpell", bp => {
                bp.BaseScore = 4.0f;
                bp.StartCooldownRounds = 1;
                bp.CombatCount = 1;
                bp.CooldownRounds = 5;
                bp.CooldownDice = new DiceFormula(3, DiceType.D6);
                bp.m_Ability = Abilities.SummonMonsterVBase.ToReference<BlueprintAbilityReference>();
                bp.m_Variant = Abilities.SummonMonsterVd3.ToReference<BlueprintAbilityReference>();
                bp.m_ActorConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.ChaoticBehaviour.ToReference<ConsiderationReference>()
                };
            });
            var NewFlameStrikeAiSpell = AiCastSpellList.FlameStrikeAiAction.CreateCopy(HEContext, "NewFlameStrikeAiSpell", bp => {
                bp.BaseScore = 5.0f;
                bp.StartCooldownRounds = 1;
                bp.CombatCount = 1;
                bp.CooldownRounds = 8;
                bp.CheckCasterDistance = true;
                bp.CooldownDice = new DiceFormula(3, DiceType.D4);
                bp.m_ActorConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.ChaoticBehaviour.ToReference<ConsiderationReference>()
                };
                bp.m_TargetConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.AoE_ChooseMoreEnemies.ToReference<ConsiderationReference>(),
                    AiConsiderationList.AttackTargetsPriority.ToReference<ConsiderationReference>()
                };
            });

            var BladeBarrierAiSpell = AiCastSpellList.Marilith_AiAction_BladeBarrier.CreateCopy(HEContext, "BladeBarrierAiSpell", bp => {
                bp.BaseScore = 5.0f;
                bp.StartCooldownRounds = 1;
                bp.CombatCount = 1;
                bp.CooldownRounds = 2;
                bp.CooldownDice = new DiceFormula(1, DiceType.D3);
                bp.m_ActorConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.ChaoticBehaviour.ToReference<ConsiderationReference>(),
                    AiConsiderationList.NoThreateningUnitsConsideration.ToReference<ConsiderationReference>()
                };
            });

            var AcidicSprayAiSpell = AiCastSpellList.AcidicSprayAiAction.CreateCopy(HEContext, "AcidicSprayAiSpell", bp => {
                bp.BaseScore = 5.0f;
                bp.StartCooldownRounds = 1;
                bp.CombatCount = 1;
                bp.CooldownRounds = 2;
                bp.CooldownDice = new DiceFormula(1, DiceType.D3);
                bp.m_ActorConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.ChaoticBehaviour.ToReference<ConsiderationReference>(),
                };
            });

            var PhantasmalPutreficationAiSpell = AiCastSpellList.Minagho_PhantasmalPutrefactionAIAction.CreateCopy(HEContext, "PhantasmalPutreficationAiSpell", bp => {
                bp.BaseScore = 6.0f;
                bp.StartCooldownRounds = 1;
                bp.CombatCount = 1;
                bp.CooldownRounds = 2;
                bp.CooldownDice = new DiceFormula(2, DiceType.D3);
                bp.m_ActorConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.ChaoticBehaviour.ToReference<ConsiderationReference>(),
                };
            });
        }
    }
}
