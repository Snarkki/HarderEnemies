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
    internal class Level8 {
        private static BuffConsideration NoMindBlankConsideration = BlueprintTools.GetModBlueprint<BuffConsideration>(HEContext, "NoMindBlankConsideration");
        public static void Handler() {

            var CreateRiftOfRuinAiSpell = AiCastSpellList.StinkingCloudAiAction.CreateCopy(HEContext, "CreateRiftOfRuinAiSpell", bp => {
                bp.BaseScore = 6.0f;
                bp.CooldownRounds = 6;
                bp.CooldownDice = new DiceFormula(3, DiceType.D4);
                bp.m_Ability = Abilities.RiftOfRuin.ToReference<BlueprintAbilityReference>();
                bp.m_ActorConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.ChaoticBehaviour.ToReference<ConsiderationReference>()
                };
                bp.m_TargetConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.AoE_AvoidSelf.ToReference<ConsiderationReference>(),
                    AiConsiderationList.AoE_ChooseMoreEnemies.ToReference<ConsiderationReference>()
                };
            });
            var FirestormEmpoweredAiSpell = AiCastSpellList.Mielara_AiAction_Stormbolts.CreateCopy(HEContext, "FirestormEmpoweredAiSpell", bp => {
                bp.BaseScore = 8.0f;
                bp.CombatCount = 3;
                bp.CooldownRounds = 8;
                bp.CheckCasterDistance = true;
                bp.CooldownDice = new DiceFormula(3, DiceType.D4);
                bp.m_Ability = Abilities.Firestorm.ToReference<BlueprintAbilityReference>();
                bp.m_TargetConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.AoE_ChooseMoreEnemies.ToReference<ConsiderationReference>(),
                    AiConsiderationList.AttackTargetsPriority.ToReference<ConsiderationReference>()
                };
                bp.m_ActorConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.ChaoticBehaviour.ToReference<ConsiderationReference>()
                };
            });

            var StormBoltAiSpell = AiCastSpellList.Mielara_AiAction_Stormbolts.CreateCopy(HEContext, "StormBoltAiSpell", bp => {
                bp.BaseScore = 8.0f;
                bp.CombatCount = 3;
                bp.CooldownRounds = 8;
                bp.CooldownDice = new DiceFormula(3, DiceType.D4);
                bp.m_TargetConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.AoE_ChooseMoreEnemies.ToReference<ConsiderationReference>()
                };
                bp.m_ActorConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.ChaoticBehaviour.ToReference<ConsiderationReference>(),
                    AiConsiderationList.IsThreatedConsideration.ToReference<ConsiderationReference>()
                };
            });

            var MindBlankAiSpell = AiCastSpellList.CultistDivineFavorAiAction.CreateCopy(HEContext, "MindBlankAiSpell", bp => {
                bp.BaseScore = 8.0f;
                bp.CooldownRounds = 5;
                bp.StartCooldownRounds = 2;
                bp.CooldownDice = new DiceFormula(3, DiceType.D4);
                bp.m_Ability = Abilities.MindBlank.ToReference<BlueprintAbilityReference>();
                bp.m_ActorConsiderations = new ConsiderationReference[] {
                    NoMindBlankConsideration.ToReference<ConsiderationReference>(),
                    AiConsiderationList.ChaoticBehaviour.ToReference<ConsiderationReference>()
                };
            });

            var PowerWordStunAiSpell = AiCastSpellList.Glabrezu_AiAction_PowerWordStun.CreateCopy(HEContext, "PowerWordStunAiSpell", bp => {
                bp.BaseScore = 8.0f;
                bp.CooldownRounds = 3;
                bp.StartCooldownRounds = 2;
                bp.CooldownDice = new DiceFormula(3, DiceType.D4);
                bp.m_ActorConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.NoThreateningUnitsConsideration.ToReference<ConsiderationReference>(),
                    AiConsiderationList.ChaoticBehaviour.ToReference<ConsiderationReference>()
                };
            });
        }
    }
}
