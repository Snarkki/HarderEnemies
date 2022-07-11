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
    internal class Level9 {

        public static void Handler() {

            var OverwhelmingPresenceAiSpell = AiCastSpellList.Baphomet_OverwhelmingPresence_AIAction.CreateCopy(HEContext, "OverwhelmingPresenceAiSpell", bp => {
                bp.BaseScore = 8.0f;
                bp.StartCooldownRounds = 1;
                bp.CombatCount = 1;
                bp.CooldownRounds = 2;
                bp.CooldownDice = new DiceFormula(3, DiceType.D4);
                bp.m_TargetConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.AoE_ChooseMoreEnemies.ToReference<ConsiderationReference>()
                };
                bp.m_ActorConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.ChaoticBehaviour.ToReference<ConsiderationReference>()
                };
            });

            var WailOfBansheeAiSpell = AiCastSpellList.Nocticula_AiAction_WailOfBanshee.CreateCopy(HEContext, "WailOfBansheeAiSpell", bp => {
                bp.BaseScore = 9.0f;
                bp.StartCooldownRounds = 1;
                bp.CombatCount = 1;
                bp.CooldownRounds = 2;
                bp.CooldownDice = new DiceFormula(3, DiceType.D4);
                bp.m_TargetConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.AoE_ChooseMoreEnemies.ToReference<ConsiderationReference>()
                };
                bp.m_ActorConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.ChaoticBehaviour.ToReference<ConsiderationReference>()
                };
            });


            var WeirdAiSpell = AiCastSpellList.Oolioddroo_WeirdAIAction.CreateCopy(HEContext, "WeirdAiSpell", bp => {
                bp.BaseScore = 9.0f;
                bp.StartCooldownRounds = 1;
                bp.CombatCount = 1;
                bp.CooldownRounds = 2;
                bp.CooldownDice = new DiceFormula(3, DiceType.D4);
                bp.m_TargetConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.AoE_ChooseMoreEnemies.ToReference<ConsiderationReference>()
                };
                bp.m_ActorConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.ChaoticBehaviour.ToReference<ConsiderationReference>()
                };
            });
        }
    }
}
