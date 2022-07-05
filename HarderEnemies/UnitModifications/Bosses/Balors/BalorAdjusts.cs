using Kingmaker.AI.Blueprints;
using Kingmaker.Blueprints;
using Kingmaker.Blueprints.Classes;
using Kingmaker.UnitLogic.FactLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TabletopTweaks.Core.Utilities;
using HarderEnemies.Features;
using HarderEnemies.AI_Mechanics.Brains;
using HarderEnemies.AI_Mechanics.Actions;
using HarderEnemies.Blueprints;
using static HarderEnemies.Main;
using Kingmaker.Blueprints.Items.Weapons;
using HarderEnemies.UnitModifications.Bosses.Balors;
using Kingmaker.Designers.Mechanics.Facts;

namespace HarderEnemies.UnitModifications.Bosses.Balors {
    internal class BalorAdjusts {



        //Balor weapons
        private static BlueprintItemWeapon BalorNewSword = BlueprintTools.GetModBlueprint<BlueprintItemWeapon>(HEContext, "BalorNewSword");
        private static BlueprintAiCastSpell PullingStrikeAiAction = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "PullingStrikeAiAction");
        private static BlueprintAiCastSpell StormBoltAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "StormBoltAiSpell");
        private static BlueprintAiCastSpell FirestormEmpoweredAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "FirestormEmpoweredAiSpell");
        private static BlueprintAiCastSpell BlasphemyAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "BlasphemyAiSpell");
        private static BlueprintAiCastSpell NewFlameStrikeAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "NewFlameStrikeAiSpell");
        private static BlueprintAiCastSpell MirrorImageAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "MirrorImageAiSpell");
        private static BlueprintAiCastSpell InvisibilityGreaterAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "InvisibilityGreaterAiSpell");
        private static BlueprintAiCastSpell MindBlankAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "MindBlankAiSpell");
        private static BlueprintAiCastSpell LegendaryProportionsAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "LegendaryProportionsAiSpell");
        private static BlueprintAiCastSpell GreaterDispelAiSpellSwift = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "GreaterDispelAiSpellSwift");
        private static BlueprintAiCastSpell OverwhelmingPresenceAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "OverwhelmingPresenceAiSpell");
        private static BlueprintAiCastSpell HoldPersonMassAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "HoldPersonMassAiSpell");
        private static BlueprintAiCastSpell GreaterShoutAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "GreaterShoutAiSpell");
        private static BlueprintFeature AbyssalToughnessFeature = BlueprintTools.GetModBlueprint<BlueprintFeature>(HEContext, "AbyssalToughnessFeature");

        private static BlueprintAiAttack ThreatenedAiAttack = BlueprintTools.GetModBlueprint<BlueprintAiAttack>(HEContext, "ThreatenedAiAttack");


        public static void Handler() {
            HandleHPBuff();
            BalorAbilities();
            BalorBuffs();
        }

        private static void HandleHPBuff() {
            //Adjust HP if enabled
            if (!HEContext.HPChanges.HPBoosts.IsDisabled("AdjustBossHp")) {
                foreach (BlueprintUnit thisUnit in UnitLists.BalorList) {
                    thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(AbyssalToughnessFeature.ToReference<BlueprintUnitFactReference>());
                }            
            }
        }

        private static void BalorAbilities() {
            if (HEContext.AbilityChanges.BossChanges.IsDisabled("BalorChanges")) { return; }

            foreach (BlueprintUnit thisUnit in UnitLists.BalorList) {
                if (thisUnit == UnitLists.Darrazand) {
                    Utils.CustomHelpers.AddFactsToUnit(thisUnit, AbilityLists.DarrazandAbilities);
                } else if (thisUnit == UnitLists.BalorLeader ||
                      thisUnit == UnitLists.CR20_BalorStandard ||
                      thisUnit == UnitLists.CR20_BalorStandard_RE ||
                      thisUnit == UnitLists.CR21_BalorAdvanced ||
                      thisUnit == UnitLists.CR21_BalorAdvanced_RE ||
                      thisUnit == UnitLists.CR26_BalorMythicBloodrager ||
                      thisUnit == UnitLists.CR26_BalorMythicBloodrager_RE ||
                      thisUnit == UnitLists.CR28M_BalorMythicFighter ||
                      thisUnit == UnitLists.CR28M_BalorMythicFighter_RE
                      ) {
                    Utils.CustomHelpers.AddFactsToUnit(thisUnit, AbilityLists.BalorAbilities);
                    thisUnit.Body.m_PrimaryHand = BalorNewSword.ToReference<BlueprintItemEquipmentHandReference>();
                } else if (thisUnit == UnitLists.Alushynirra_BalorNocticulaGuard) {
                    thisUnit.Body.m_PrimaryHand = BalorNewSword.ToReference<BlueprintItemEquipmentHandReference>();
                }
                thisUnit.AddComponent<AddCasterLevel>(c => {
                    c.Bonus = thisUnit.CR;
                });
            }

            //1. tee erilaisia baloreita, caster > dama, caster control, melee (joku fear tapanen)
            //2. uudet aivot kaikille


                // BRAIN APPEND
                BrainList.DarrazandBrain.m_Actions = new BlueprintAiActionReference[] {
                        AiCastSpellList.AttackAiAction.ToReference<BlueprintAiActionReference>(),
                        ThreatenedAiAttack.ToReference<BlueprintAiActionReference>(),
                        PullingStrikeAiAction.ToReference<BlueprintAiActionReference>(),
                        BlasphemyAiSpell.ToReference<BlueprintAiActionReference>(),
                        NewFlameStrikeAiSpell.ToReference<BlueprintAiActionReference>(),
                        FirestormEmpoweredAiSpell.ToReference<BlueprintAiActionReference>(),
                        StormBoltAiSpell.ToReference<BlueprintAiActionReference>(),
                        MirrorImageAiSpell.ToReference<BlueprintAiActionReference>(),
                        InvisibilityGreaterAiSpell.ToReference<BlueprintAiActionReference>(),
                        MindBlankAiSpell.ToReference<BlueprintAiActionReference>(),
                        LegendaryProportionsAiSpell.ToReference<BlueprintAiActionReference>(),
                        GreaterDispelAiSpellSwift.ToReference<BlueprintAiActionReference>(),
                    };
                BrainList.BalorBrain.m_Actions = BrainList.BalorBrain.m_Actions.AppendToArray(
                    OverwhelmingPresenceAiSpell.ToReference<BlueprintAiActionReference>(),
                    NewFlameStrikeAiSpell.ToReference<BlueprintAiActionReference>(),
                    FirestormEmpoweredAiSpell.ToReference<BlueprintAiActionReference>(),
                    HoldPersonMassAiSpell.ToReference<BlueprintAiActionReference>(),
                    GreaterShoutAiSpell.ToReference<BlueprintAiActionReference>()
                    );
                BrainList.BalorMythic6_BloodragerBrain.m_Actions = BrainList.BalorMythic6_BloodragerBrain.m_Actions.AppendToArray(
                    OverwhelmingPresenceAiSpell.ToReference<BlueprintAiActionReference>(),
                    NewFlameStrikeAiSpell.ToReference<BlueprintAiActionReference>(),
                    FirestormEmpoweredAiSpell.ToReference<BlueprintAiActionReference>(),
                    HoldPersonMassAiSpell.ToReference<BlueprintAiActionReference>(),
                    GreaterShoutAiSpell.ToReference<BlueprintAiActionReference>()
                    );
            
            HEContext.Logger.LogHeader("Updated Balors");
        }

        private static void BalorBuffs() {
            if (HEContext.Prebuffs.BossBuffs.IsDisabled("BalorBuffs")) { return; }
            foreach (BlueprintUnit thisUnit in UnitLists.BalorList) {
                thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(FeatureList.CR22_AxiomiteCaster_Feature_CombatPrebuff.ToReference<BlueprintUnitFactReference>());
                Utils.CustomHelpers.AddFactListsToUnit(thisUnit, 35, BuffLists.BalorBuffsList);
            }
        }




    }
}
