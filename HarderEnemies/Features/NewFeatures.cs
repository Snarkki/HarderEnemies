using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kingmaker.Blueprints;
using Kingmaker.Blueprints.Classes;
using Kingmaker.Designers.Mechanics.Facts;
using Kingmaker.UnitLogic.Abilities.Blueprints;
using Kingmaker.UnitLogic.Abilities.Components;
using Kingmaker.UnitLogic.FactLogic;
using Kingmaker.UnitLogic.Mechanics.Actions;
using TabletopTweaks.Core.Utilities;
using HarderEnemies.Blueprints;
using static HarderEnemies.Main;
using Kingmaker.Blueprints.Classes.Prerequisites;
using Kingmaker.UnitLogic.Mechanics.Components;
using Kingmaker.Blueprints.TurnBasedModifiers;
using HarderEnemies.Features.Logics;

namespace HarderEnemies.Features {
    public class NewFeatures {
        private static BlueprintFeature Sevalros_QuickenFeature = BlueprintTools.GetBlueprint<BlueprintFeature>("37df72706c5f4b238535f6f96c0d644b");
        private static BlueprintFeature EmporedMetaMagicFeature = BlueprintTools.GetBlueprint<BlueprintFeature>("a1de1e4f92195b442adb946f0e2b9d4e");
        private static BlueprintFeature QuickenedMetaMagicFeature = BlueprintTools.GetBlueprint<BlueprintFeature>("ef7ece7bb5bb66a41b256976b27f424e");


        public static void CreateNewFeatures() {
            CreateSuperToughness();
            CreateAbyssalToughness();
            CreatePullingStrike();
            CreateMetaMagicFeature();
            CreateBabauDispellingStrike();
        }

        public static void CreateSuperToughness() {

            var SuperToughnessFeature = FeatureList.Toughness.CreateCopy(HEContext, "SuperToughnessFeature", bp => {
                bp.SetName(HEContext, "Superior Toughness");
                bp.SetDescription(HEContext, "You gain +10 hit points for every level.");
                bp.RemoveComponents<ToughnessLogic>();
                bp.AddComponent<SuperToughnessLogic>(c => {
                    c.CheckMythicLevel = false;
                });
            });
        }

        public static void CreateAbyssalToughness() {

            var AbyssalToughnessFeature = FeatureList.Toughness.CreateCopy(HEContext, "AbyssalToughnessFeature", bp => {
                bp.SetName(HEContext, "Abyssal Toughness");
                bp.SetDescription(HEContext, "You gain +25 hit points for every level.");
                bp.RemoveComponents<ToughnessLogic>();
                bp.AddComponent<AbyssalToughnessLogic>(c => {
                    c.CheckMythicLevel = false;
                });
            });
        }

        public static void CreateBabauDispellingStrike() {

            var BabauDispellingStrike = FeatureList.DispellingStrike.CreateCopy(HEContext, "BabauDispellingStrike", bp => {
                bp.SetName(HEContext, "Dispelling Strike");
                bp.SetDescription(HEContext, "An opponent that is dealt sneak {g|Encyclopedia:Attack}attack{/g} {g|Encyclopedia:Damage}damage{/g} by a character with this ability is affected by a targeted dispel magic affecting one of the {g|Encyclopedia:Spell}spell{/g} effects active on the target.");
                bp.RemoveComponents<PrerequisiteFeature>();
                var RankConfig = bp.GetComponent<ContextRankConfig>();
                RankConfig.m_BaseValueType = ContextRankBaseValueType.ClassLevel;
                RankConfig.Archetype = null;
                RankConfig.m_Class = new BlueprintCharacterClassReference[] { CharacterClass.OutsiderClass.ToReference<BlueprintCharacterClassReference>() };
            });
        }


        public static void CreateMetaMagicFeature() {

            var quickenAbilities = new BlueprintAbilityReference[] {
                BlueprintTools.GetBlueprintReference<BlueprintAbilityReference>("486eaff58293f6441a5c2759c4872f98"),    // haste,
                BlueprintTools.GetBlueprintReference<BlueprintAbilityReference>("b9be852b03568064b8d2275a6cf9e2de"),    // GreaterDispelArea,
                BlueprintTools.GetBlueprintReference<BlueprintAbilityReference>("f0f761b808dc4b149b08eaf44b99f633"),    // DispelMagicGreater,
                BlueprintTools.GetBlueprintReference<BlueprintAbilityReference>("ecaa0def35b38f949bd1976a6c9539e0"),    // GreaterInvisbility,
                BlueprintTools.GetBlueprintReference<BlueprintAbilityReference>("f492622e473d34747806bdb39356eb89"),    // Slow,
                BlueprintTools.GetBlueprintReference<BlueprintAbilityReference>("da1b292d91ba37948893cdbe9ea89e28"),    // LegendaryProportions,
                BlueprintTools.GetBlueprintReference<BlueprintAbilityReference>("cdb106d53c65bbc4086183d54c3b97c7"),    // ScorchingRay,
                BlueprintTools.GetBlueprintReference<BlueprintAbilityReference>("ff8f1534f66559c478448723e16b6624"),    // Heal,
                BlueprintTools.GetBlueprintReference<BlueprintAbilityReference>("3e4ab69ada402d145a5e0ad3ad4b8564"),    // MirrorImage,
            };

            var emporedAbilities = new BlueprintAbilityReference[] {
                BlueprintTools.GetBlueprintReference<BlueprintAbilityReference>("2d81362af43aeac4387a3d4fced489c3"),    // fireball,
                BlueprintTools.GetBlueprintReference<BlueprintAbilityReference>("700cfcbd0cb2975419bcab7dbb8c6210"),    // Hellfireray,
                BlueprintTools.GetBlueprintReference<BlueprintAbilityReference>("16ce660837fb2544e96c3b7eaad73c63"),    // Volcanic Storm,
                BlueprintTools.GetBlueprintReference<BlueprintAbilityReference>("e3d0dfe1c8527934294f241e0ae96a8d"),    // Firestorm ,
                BlueprintTools.GetBlueprintReference<BlueprintAbilityReference>("f9910c76efc34af41b6e43d5d8752f0f"),    // FlameStrike ,
                BlueprintTools.GetBlueprintReference<BlueprintAbilityReference>("645558d63604747428d55f0dd3a4cb58"),    // ChainLightning ,
            };

            var maximizedAbilities = new BlueprintAbilityReference[] {
                BlueprintTools.GetBlueprintReference<BlueprintAbilityReference>("2d81362af43aeac4387a3d4fced489c3"),    // fireball,
                BlueprintTools.GetBlueprintReference<BlueprintAbilityReference>("700cfcbd0cb2975419bcab7dbb8c6210"),    // Hellfireray,
                BlueprintTools.GetBlueprintReference<BlueprintAbilityReference>("4aa7942c3e62a164387a73184bca3fc1"),    // Disintegrate,
            };

            var bolsteredAbilities = new BlueprintAbilityReference[] {
                BlueprintTools.GetBlueprintReference<BlueprintAbilityReference>("2d81362af43aeac4387a3d4fced489c3"),    // fireball,
                BlueprintTools.GetBlueprintReference<BlueprintAbilityReference>("700cfcbd0cb2975419bcab7dbb8c6210"),    // Hellfireray,
                BlueprintTools.GetBlueprintReference<BlueprintAbilityReference>("9a46dfd390f943647ab4395fc997936d"),    // acid arrow,
                BlueprintTools.GetBlueprintReference<BlueprintAbilityReference>("eaac3d36e0336cb479209a6f65e25e7c"),    // BurningArc
                BlueprintTools.GetBlueprintReference<BlueprintAbilityReference>("cdb106d53c65bbc4086183d54c3b97c7"),    // ScorchingRay,
                BlueprintTools.GetBlueprintReference<BlueprintAbilityReference>("700cfcbd0cb2975419bcab7dbb8c6210"),    // Hellfireray,
            };


            var SuperiorQuickenMetaMagicFeature = Sevalros_QuickenFeature.CreateCopy(HEContext, "SuperiorQuickenMetaMagicFeature", bp => {
                bp.m_Icon = FeatureList.QuickenSpellFeature.Icon;
                bp.RemoveComponents<AutoMetamagic>();
                bp.SetName(HEContext, "Quicken Metamagic");
                bp.SetDescription(HEContext, "Allows you to add quicken metamagic to spells.");
                bp.AddComponent<AutoMetamagic>(c => {
                    c.m_AllowedAbilities = AutoMetamagic.AllowedType.Any;
                    c.Metamagic = Kingmaker.UnitLogic.Abilities.Metamagic.Quicken;
                    c.Once = false;
                    c.MaxSpellLevel = 0;
                    c.School = Kingmaker.Blueprints.Classes.Spells.SpellSchool.None;
                    c.CheckSpellbook = false;
                    c.m_Spellbook = null;
                    c.Descriptor.m_IntValue = 0;
                    c.Abilities = quickenAbilities.ToList();
                });
            });

            var SuperiorEmporedMetaMagicFeature = Sevalros_QuickenFeature.CreateCopy(HEContext, "SuperiorEmporedMetaMagicFeature", bp => {
                bp.RemoveComponents<AutoMetamagic>();
                bp.m_Icon = FeatureList.QuickenSpellFeature.Icon;
                bp.SetName(HEContext, "Empower Metamagic");
                bp.SetDescription(HEContext, "Allows you to add Empower metamagic to spells.");
                bp.AddComponent<AutoMetamagic>(c => {
                    c.m_AllowedAbilities = AutoMetamagic.AllowedType.SpellOrSpellLike;
                    c.Metamagic = Kingmaker.UnitLogic.Abilities.Metamagic.Empower;
                    c.Once = false;
                    c.MaxSpellLevel = 0;
                    c.School = Kingmaker.Blueprints.Classes.Spells.SpellSchool.None;
                    c.CheckSpellbook = false;
                    c.m_Spellbook = null;
                    c.Abilities = emporedAbilities.ToList();
                });
            });

            var SuperiorMaximizedMetaMagicFeature = Sevalros_QuickenFeature.CreateCopy(HEContext, "SuperiorMaximizedMetaMagicFeature", bp => {
                bp.RemoveComponents<AutoMetamagic>();
                bp.m_Icon = FeatureList.QuickenSpellFeature.Icon;
                bp.SetName(HEContext, "Maximized Metamagic");
                bp.SetDescription(HEContext, "Allows you to add Maximized metamagic to spells.");
                bp.AddComponent<AutoMetamagic>(c => {
                    c.m_AllowedAbilities = AutoMetamagic.AllowedType.SpellOrSpellLike;
                    c.Metamagic = Kingmaker.UnitLogic.Abilities.Metamagic.Maximize;
                    c.Once = false;
                    c.MaxSpellLevel = 0;
                    c.School = Kingmaker.Blueprints.Classes.Spells.SpellSchool.None;
                    c.CheckSpellbook = false;
                    c.m_Spellbook = null;
                    c.Abilities = maximizedAbilities.ToList();
                });
            });

            var SuperiorBolsteredMetaMagicFeature = Sevalros_QuickenFeature.CreateCopy(HEContext, "SuperiorBolsteredMetaMagicFeature", bp => {
                bp.RemoveComponents<AutoMetamagic>();
                bp.m_Icon = FeatureList.QuickenSpellFeature.Icon;
                bp.SetName(HEContext, "Bolstered Metamagic");
                bp.SetDescription(HEContext, "Allows you to add Bolster metamagic to spells.");
                bp.AddComponent<AutoMetamagic>(c => {
                    c.m_AllowedAbilities = AutoMetamagic.AllowedType.SpellOrSpellLike;
                    c.Metamagic = Kingmaker.UnitLogic.Abilities.Metamagic.Bolstered;
                    c.Once = false;
                    c.MaxSpellLevel = 0;
                    c.School = Kingmaker.Blueprints.Classes.Spells.SpellSchool.None;
                    c.CheckSpellbook = false;
                    c.m_Spellbook = null;
                    c.Abilities = bolsteredAbilities.ToList();
                });
            });
        }

        private static void CreatePullingStrike() {

            var PullingStrikeAbility = Abilities.TelekineticStrikePull.CreateCopy(HEContext, "PullingStrikeAbility", bp => {
                bp.RemoveComponents<AbilityEffectRunAction>();
                bp.AddComponent<AbilityEffectRunAction>(bp => {
                    bp.SavingThrowType = Kingmaker.EntitySystem.Stats.SavingThrowType.Unknown;
                    bp.Actions = Helpers.CreateActionList(
                        new ContextActionCombatManeuver() {
                            Type = Kingmaker.RuleSystem.Rules.CombatManeuver.Pull,
                            OnSuccess = Helpers.CreateActionList(
                            new ContextActionKnockdownTarget() {

                            },
                            new ContextActionProvokeAttackOfOpportunity() { ApplyToCaster = false }
                            )
                        }
                        );
                });
                bp.AddComponent<AbilityIsFullRoundInTurnBased>(abil => {
                    abil.FullRoundIfTurnBased = true;
                });
                bp.SetName(HEContext, "Whip Strike");
                bp.SetDescription(HEContext, "As a free action, you can try to pull an enemy towards you.");
                bp.Range = AbilityRange.Close;

                bp.NeedEquipWeapons = true;
                bp.Type = AbilityType.SpellLike;
                bp.ActionType = Kingmaker.UnitLogic.Commands.Base.UnitCommand.CommandType.Free;
            });

            var quickenAbilities = new BlueprintAbilityReference[] {
                BlueprintTools.GetBlueprintReference<BlueprintAbilityReference>("486eaff58293f6441a5c2759c4872f98"),    // haste,
                BlueprintTools.GetBlueprintReference<BlueprintAbilityReference>("b9be852b03568064b8d2275a6cf9e2de"),    // GreaterDispelArea,
                BlueprintTools.GetBlueprintReference<BlueprintAbilityReference>("f0f761b808dc4b149b08eaf44b99f633"),    // DispelMagicGreater,
                PullingStrikeAbility.ToReference<BlueprintAbilityReference>()
            };

            var DarrazandQuickenFeature = Sevalros_QuickenFeature.CreateCopy(HEContext, "DarrazandQuickenFeature", bp => {
                bp.m_Icon = FeatureList.QuickenSpellFeature.Icon;
                bp.RemoveComponents<AutoMetamagic>();
                bp.SetName(HEContext, "Quicken Metamagic");
                bp.SetDescription(HEContext, "Allows you to add quicken metamagic to spells.");
                bp.AddComponent<AutoMetamagic>(c => {
                    c.m_AllowedAbilities = AutoMetamagic.AllowedType.Any;
                    c.Metamagic = Kingmaker.UnitLogic.Abilities.Metamagic.Quicken;
                    c.Once = false;
                    c.MaxSpellLevel = 0;
                    c.School = Kingmaker.Blueprints.Classes.Spells.SpellSchool.None;
                    c.CheckSpellbook = false;
                    c.m_Spellbook = null;
                    c.Descriptor.m_IntValue = 0;
                    c.Abilities = quickenAbilities.ToList();
                });
            });


        }

    }
}
