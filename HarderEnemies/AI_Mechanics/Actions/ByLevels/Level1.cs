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
    internal class Level1 {

        public static void Handler() {

            var MagicMissileAiSpell = AiCastSpellList.MagicMissileAiAction.CreateCopy(HEContext, "MagicMissileAiSpell", bp => {
                bp.BaseScore = 1.5f;
                bp.m_ActorConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.ChaoticBehaviour.ToReference<ConsiderationReference>()
                };
            });

            var ColorSprayAiSpell = AiCastSpellList.ColorSprayAiAction.CreateCopy(HEContext, "ColorSprayAiSpell", bp => {
                bp.BaseScore = 1.5f;
                bp.m_ActorConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.ChaoticBehaviour.ToReference<ConsiderationReference>(),
                };
            });

            var CommandAiSpell = AiCastSpellList.CultistHoldPersonAiAction.CreateCopy(HEContext, "CommandAiSpell", bp => {
                bp.BaseScore = 2.0f;
                bp.m_ActorConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.ChaoticBehaviour.ToReference<ConsiderationReference>(),
                    AiConsiderationList.NoThreateningUnitsConsideration.ToReference<ConsiderationReference>()
                };
                bp.m_TargetConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.AttackTargetsPriority.ToReference<ConsiderationReference>()
                };
                bp.m_Ability = Abilities.Command.ToReference<BlueprintAbilityReference>();
                bp.m_Variant = Abilities.CommandFall.ToReference<BlueprintAbilityReference>();
            });

            var CauseFearAiSpell = AiCastSpellList.CauseFearAiAction.CreateCopy(HEContext, "CauseFearAiSpell", bp => {
                bp.BaseScore = 5.0f;
                bp.m_ActorConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.ChaoticBehaviour.ToReference<ConsiderationReference>()
                };
            });

            var GreaseAiSpell = AiCastSpellList.StinkingCloudAiAction.CreateCopy(HEContext, "GreaseAiSpell", bp => {
                bp.BaseScore = 2.0f;
                bp.CooldownRounds = 4;
                bp.CooldownDice = new DiceFormula(3, DiceType.D4);
                bp.m_Ability = Abilities.Grease.ToReference<BlueprintAbilityReference>();
                bp.m_ActorConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.ChaoticBehaviour.ToReference<ConsiderationReference>(),
                };
                bp.m_TargetConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.AoE_AvoidSelf.ToReference<ConsiderationReference>(),
                    AiConsiderationList.AoE_ChooseMoreEnemies.ToReference<ConsiderationReference>()
                };
            });
        }
    }
}
