using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kingmaker.Blueprints;
using Kingmaker.Blueprints.Classes;
using Kingmaker.Designers.Mechanics.Facts;
using Kingmaker.ElementsSystem;
using Kingmaker.UnitLogic.Abilities.Blueprints;
using Kingmaker.UnitLogic.Abilities.Components;
using Kingmaker.UnitLogic.Buffs.Blueprints;
using Kingmaker.UnitLogic.FactLogic;
using Kingmaker.UnitLogic.Mechanics;
using Kingmaker.UnitLogic.Mechanics.Actions;
using TabletopTweaks.Core.Utilities;
using HarderEnemies.Blueprints;
using static HarderEnemies.Main;

namespace HarderEnemies.Features {
    public class NewSpells {

        private static BlueprintBuff SummonedCreatureSpawnMonsterVI = BlueprintTools.GetBlueprint<BlueprintBuff>("0dff842f06edace43baf8a2f44207045");
        private static BlueprintSummonPool SummonMonsterPool = BlueprintTools.GetBlueprint<BlueprintSummonPool>("d94c93e7240f10e41ae41db4c83d1cbe");
        private static BlueprintFaction SummonedFaction = BlueprintTools.GetBlueprint<BlueprintFaction>("1b08d9ed04518ec46a9b3e4e23cb5105");
        private static BlueprintUnit CR23_LocustSwarm = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("ac1fa7117065411fbd28daaea230e15d");
        private static BlueprintUnit Summoned_CR20_ErineysDevil = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("76ed98adcf7d4867b784eaa352d4fd0b");
        private static BlueprintUnit Summoned_CR20_ErineysDevilRanged = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("1a9d35e6232143a4bb809a87de10cd5e");

        public static void CreateNewSpells() {
            CreateGateSpell();
            CreateSwarmSummon();
            CreateSummonErineyes();
        }



        private static void CreateGateSpell() {
            var summonedBalor = UnitModifications.Bosses.Balors.UnitLists.CR21_BalorAdvanced.CreateCopy(HEContext, "SummonedBalors", bp => {
                bp.m_Faction = SummonedFaction.ToReference<BlueprintFactionReference>();
            });

            var GateSpell = Abilities.SummonMonsterIXd3.CreateCopy(HEContext, "GateSpell", bp => {
                bp.SetName(HEContext, "Gate");
                bp.SetDescription(HEContext, "You open a portal to abyss and summon 1d3 of Balors to help defend you.");
                bp.RemoveComponents<AbilityEffectRunAction>();
                bp.AddComponent<AbilityEffectRunAction>(c => {
                    c.Actions = new ActionList {
                        Actions = new GameAction[] { SummonContext(summonedBalor, Kingmaker.RuleSystem.DiceType.D3, 1) }
                    };
                });
            });
        }
        private static void CreateSummonErineyes() { 

            var ErineysSummon = Abilities.SummonMonsterIXd3.CreateCopy(HEContext, "ErineysSummon", bp => {
                bp.SetName(HEContext, "Summon Erineyes");
                bp.SetDescription(HEContext, "This spell summons 1d2+1d2 extraplanar Erineyes. Summoned monsters appear where you designate and act according to their initiative check results. They attack your opponents to the best of their ability.");
                bp.RemoveComponents<AbilityEffectRunAction>();
                bp.AddComponent<AbilityEffectRunAction>(c => {
                    c.Actions = new ActionList {
                        Actions = new GameAction[] { SummonContext(Summoned_CR20_ErineysDevil, Kingmaker.RuleSystem.DiceType.D2, 1), SummonContext(Summoned_CR20_ErineysDevilRanged, Kingmaker.RuleSystem.DiceType.D2, 1) }
                    };
                });
            });
        }

        private static void CreateSwarmSummon() {
            

            var SummonedEpicSwarms = CR23_LocustSwarm.CreateCopy(HEContext, "SummonedEpicSwarms", bp => {
                bp.m_Faction = SummonedFaction.ToReference<BlueprintFactionReference>();
            });

            var GreaterSwarmSummon = Abilities.SummonMonsterIXd3.CreateCopy(HEContext, "GreaterSwarmSummon", bp => {
                bp.SetName(HEContext, "Greater Swarm Summon");
                bp.SetDescription(HEContext, "This spell summons to your side 1d6 mythic swarms. The summoned swarms appear where you designate and act according to their initiative check results. They attack your opponents to the best of their ability.");
                bp.RemoveComponents<AbilityEffectRunAction>();
                bp.AddComponent<AbilityEffectRunAction>(c => {
                    c.Actions = new ActionList {
                        Actions = new GameAction[] { SummonContext(SummonedEpicSwarms, Kingmaker.RuleSystem.DiceType.D4, 2) }
                    };
                });
            });
        }

        private static ContextActionSpawnMonster SummonContext(BlueprintUnit unitToSummon, Kingmaker.RuleSystem.DiceType amount, int value) {

            var applyBuff = Helpers.Create<ContextActionApplyBuff>(buff => {
                buff.m_Buff = SummonedCreatureSpawnMonsterVI.ToReference<BlueprintBuffReference>();
                buff.Permanent = true;
                buff.IsNotDispelable = true;
                buff.AsChild = false;
                buff.DurationValue = new ContextDurationValue() {
                    Rate = DurationRate.Rounds,
                    DiceType = Kingmaker.RuleSystem.DiceType.Zero,
                    DiceCountValue = new ContextValue(),
                    BonusValue = new ContextValue()
                };
            });

            var summonBalors = Helpers.Create<ContextActionSpawnMonster>(summons => {
                summons.m_Blueprint = unitToSummon.ToReference<BlueprintUnitReference>();
                summons.AfterSpawn = new ActionList {
                    Actions = new GameAction[] { applyBuff }
                };
                summons.m_SummonPool = SummonMonsterPool.ToReference<BlueprintSummonPoolReference>();
                summons.DurationValue = new ContextDurationValue() {
                    Rate = DurationRate.Rounds,
                    DiceType = Kingmaker.RuleSystem.DiceType.Zero,
                    DiceCountValue = new ContextValue(),
                    BonusValue = new ContextValue()
                };
                summons.CountValue = new ContextDiceValue() {
                    DiceType = amount,
                    DiceCountValue = new ContextValue() {
                        Value = value,
                        ValueType = ContextValueType.Simple,
                        ValueRank = Kingmaker.Enums.AbilityRankType.Default,
                        ValueShared = Kingmaker.UnitLogic.Abilities.AbilitySharedValue.Damage,
                        Property = Kingmaker.UnitLogic.Mechanics.Properties.UnitProperty.None
                    }
                };
                summons.LevelValue = new ContextValue();

            });
            return summonBalors;
        }

    }
}
