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


namespace HarderEnemies.Features {
    public class NewFeatures {
        private static BlueprintFeature Sevalros_QuickenFeature = BlueprintTools.GetBlueprint<BlueprintFeature>("37df72706c5f4b238535f6f96c0d644b");
        private static BlueprintFeature EmporedMetaMagicFeature = BlueprintTools.GetBlueprint<BlueprintFeature>("a1de1e4f92195b442adb946f0e2b9d4e");
        private static BlueprintFeature QuickenedMetaMagicFeature = BlueprintTools.GetBlueprint<BlueprintFeature>("ef7ece7bb5bb66a41b256976b27f424e");

        public static void CreateNewFeatures() {
            CreateSuperToughness();
            CreateMetaMagicFeature();
            CreatePullingStrike();
        }

        public static void CreateSuperToughness() {

            var SuperToughnessFeature = FeatureList.Toughness.CreateCopy(HEContext, "SuperToughnessFeature", bp => {
                bp.SetName(HEContext, "Superior Toughness");
                bp.SetDescription(HEContext, "You gain +25 hit points for every level.");
                bp.RemoveComponents<ToughnessLogic>();
                bp.AddComponent<SuperToughnessLogic>(c => {
                    c.CheckMythicLevel = false;
                });
            });         
        }

        public static void CreateMetaMagicFeature() {

            var quickenAbilities = new BlueprintAbilityReference[] {
                BlueprintTools.GetBlueprintReference<BlueprintAbilityReference>("486eaff58293f6441a5c2759c4872f98"),    // haste,
                BlueprintTools.GetBlueprintReference<BlueprintAbilityReference>("b9be852b03568064b8d2275a6cf9e2de"),    // GreaterDispelArea,
                BlueprintTools.GetBlueprintReference<BlueprintAbilityReference>("f0f761b808dc4b149b08eaf44b99f633"),    // DispelMagicGreater,
                BlueprintTools.GetBlueprintReference<BlueprintAbilityReference>("ecaa0def35b38f949bd1976a6c9539e0"),    // GreaterInvisbility,
            };

            var emporedAbilities = new BlueprintAbilityReference[] {
                BlueprintTools.GetBlueprintReference<BlueprintAbilityReference>("2d81362af43aeac4387a3d4fced489c3"),    // fireball,
                BlueprintTools.GetBlueprintReference<BlueprintAbilityReference>("700cfcbd0cb2975419bcab7dbb8c6210"),    // Hellfireray,
                BlueprintTools.GetBlueprintReference<BlueprintAbilityReference>("16ce660837fb2544e96c3b7eaad73c63"),    // Volcanic Storm,
                BlueprintTools.GetBlueprintReference<BlueprintAbilityReference>("e3d0dfe1c8527934294f241e0ae96a8d"),    // Firestorm ,
            };

            var maximizedAbilities = new BlueprintAbilityReference[] {
                BlueprintTools.GetBlueprintReference<BlueprintAbilityReference>("2d81362af43aeac4387a3d4fced489c3"),    // fireball,
                BlueprintTools.GetBlueprintReference<BlueprintAbilityReference>("700cfcbd0cb2975419bcab7dbb8c6210"),    // Hellfireray,
                BlueprintTools.GetBlueprintReference<BlueprintAbilityReference>("4aa7942c3e62a164387a73184bca3fc1"),    // Disintegrate,
            };

            var bolsteredAbilities = new BlueprintAbilityReference[] {
                BlueprintTools.GetBlueprintReference<BlueprintAbilityReference>("2d81362af43aeac4387a3d4fced489c3"),    // fireball,
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
                        }
                        );
                });

                bp.SetName(HEContext, "Whip Strike");
                bp.SetDescription(HEContext, "While striking with your whip, you also try to pull the target next to you.");
                bp.Range = AbilityRange.Close;
                bp.ActionType = Kingmaker.UnitLogic.Commands.Base.UnitCommand.CommandType.Standard;


            });
        }

    }
}
