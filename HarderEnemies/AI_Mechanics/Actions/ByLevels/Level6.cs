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
    internal class Level6 {

        public static void Handler() {

            var GreaterShoutAiSpell = AiCastSpellList.Baphomet_OverwhelmingPresence_AIAction.CreateCopy(HEContext, "GreaterShoutAiSpell", bp => {
                bp.BaseScore = 7.0f;
                bp.CooldownRounds = 5;
                bp.CooldownDice = new DiceFormula(3, DiceType.D4);
                bp.m_TargetConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.AoE_ChooseMoreEnemies.ToReference<ConsiderationReference>()
                };
                bp.m_ActorConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.ChaoticBehaviour.ToReference<ConsiderationReference>()
                };
                bp.m_Ability = Abilities.ShoutGreater.ToReference<BlueprintAbilityReference>();
            });
            var ColdIceStrikeAiSpell = AiCastSpellList.CultistEvokerFireSnakeAiAction.CreateCopy(HEContext, "ColdIceStrikeAiSpell", bp => {
                bp.BaseScore = 5.0f;
                bp.m_Ability = Abilities.ColdIceStrike.ToReference<BlueprintAbilityReference>();
                bp.m_ActorConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.ChaoticBehaviour.ToReference<ConsiderationReference>()
                };
            });
            var DisintregrateMaximized = AiCastSpellList.DLC2_Wizard_Empowered_MagicMissle_AiAction.CreateCopy(HEContext, "DisintregrateMaximized", bp => {
                bp.BaseScore = 6.0f;
                bp.CombatCount = 2;
                bp.CooldownRounds = 8;
                bp.CheckCasterDistance = true;
                bp.CooldownDice = new DiceFormula(3, DiceType.D4);
                bp.m_Ability = Abilities.Disintegrate.ToReference<BlueprintAbilityReference>();
                bp.m_ActorConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.ChaoticBehaviour.ToReference<ConsiderationReference>()
                };
            });


            var HellFireMaximized = AiCastSpellList.DLC2_Wizard_Empowered_MagicMissle_AiAction.CreateCopy(HEContext, "HellFireMaximized", bp => {
                bp.BaseScore = 6.0f;
                bp.CombatCount = 2;
                bp.CooldownRounds = 8;
                bp.CheckCasterDistance = true;
                bp.CooldownDice = new DiceFormula(2, DiceType.D3);
                bp.m_Ability = Abilities.HellfireRay.ToReference<BlueprintAbilityReference>();
                bp.m_ActorConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.ChaoticBehaviour.ToReference<ConsiderationReference>()
                };
            });
            var BlasphemyAiSpell = AiCastSpellList.Vavakia_AiAction_Blasphemy.CreateCopy(HEContext, "BlasphemyAiSpell", bp => {
                bp.BaseScore = 5.0f;
                bp.CombatCount = 1;
                bp.CooldownRounds = 6;
                bp.CooldownDice = new DiceFormula(3, DiceType.D4);
                bp.m_ActorConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.ChaoticBehaviour.ToReference<ConsiderationReference>(),
                    AiConsiderationList.IsThreatedConsideration.ToReference<ConsiderationReference>()
                };
            });

            var GreaterDispelAiSpellSwift = AiCastSpellList.CR27ColoxusDLC1_AiAction_GreaterDispel.CreateCopy(HEContext, "GreaterDispelAiSpellSwift", bp => {
                bp.BaseScore = 10.0f;
                bp.CooldownRounds = 3;
                bp.StartCooldownRounds = 8;
                bp.CooldownDice = new DiceFormula(1, DiceType.D2);
                bp.m_ActorConsiderations = new ConsiderationReference[] {
                   AiConsiderationList.SwiftActionOffCooldown.ToReference<ConsiderationReference>()
                };
                bp.m_TargetConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.AoE_AvoidSelf.ToReference<ConsiderationReference>(),
                    AiConsiderationList.AoE_ChooseMoreEnemies.ToReference<ConsiderationReference>()
                };
            });
        }
    }
}
