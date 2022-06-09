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
using static HarderEnemies.Main;
using HarderEnemies.Blueprints;
using Kingmaker.Blueprints.Items.Weapons;
using Kingmaker.UnitLogic.Abilities.Blueprints;
using Kingmaker.Designers.Mechanics.Facts;
using Kingmaker.UnitLogic.Abilities.Components;
using Kingmaker.UnitLogic.Mechanics.Actions;

namespace HarderEnemies.Units.Adjustments {
    internal class AdjustRandomBosses {
        private static BlueprintFeature SuperiorQuickenMetaFeature = BlueprintTools.GetModBlueprint<BlueprintFeature>(HEContext, "SuperiorQuickenMetaMagicFeature");
        private static BlueprintFeature SuperiorEmpowerMetaFeature = BlueprintTools.GetModBlueprint<BlueprintFeature>(HEContext, "SuperiorEmporedMetaMagicFeature");
        private static BlueprintFeature SuperToughness = BlueprintTools.GetModBlueprint<BlueprintFeature>(HEContext, "SuperToughnessFeature");
        private static BlueprintAiCastSpell GreaterDispelAiSpellSwift = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "GreaterDispelAiSpellSwift");
        private static BlueprintAiCastSpell BlasphemyAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "BlasphemyAiSpell");
        private static BlueprintAiCastSpell UnholyBlightAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "UnholyBlightAiSpell");
        private static BlueprintAiCastSpell StormBoltAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "StormBoltAiSpell");
        private static BlueprintAiCastSpell SummonMonsterViiAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "SummonMonsterViiAiSpell");
        private static BlueprintAiCastSpell FearAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "FearAiSpell");
        private static BlueprintAiCastSpell FirestormEmpoweredAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "FirestormEmpoweredAiSpell");
        private static BlueprintAiCastSpell GreaterInvisibilityAiSpellSwift = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "GreaterInvisibilityAiSpellSwift");
        private static BlueprintAiCastSpell NewFlameStrikeAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "NewFlameStrikeAiSpell");
        private static BlueprintItemWeapon HolyEvilBane5Sword = BlueprintTools.GetModBlueprint<BlueprintItemWeapon>(HEContext, "HolyEvilBane5Sword");

        private static BlueprintAbility GreaterSwarmSummon = BlueprintTools.GetModBlueprint<BlueprintAbility>(HEContext, "GreaterSwarmSummon");
        private static BlueprintAbility GateSpell = BlueprintTools.GetModBlueprint<BlueprintAbility>(HEContext, "GateSpell");

        private static BlueprintBrain NocticulaAltBrain = BlueprintTools.GetModBlueprint<BlueprintBrain>(HEContext, "NocticulaAltBrain");
        private static BlueprintBrain DeskariAltBrain = BlueprintTools.GetModBlueprint<BlueprintBrain>(HEContext, "DeskariAltBrain");


        //Balor weapons
        private static BlueprintItemWeapon BalorNewSword = BlueprintTools.GetModBlueprint<BlueprintItemWeapon>(HEContext, "BalorNewSword");
        private static BlueprintAbility PullingStrikeAbility = BlueprintTools.GetModBlueprint<BlueprintAbility>(HEContext, "PullingStrikeAbility");
        private static BlueprintAiCastSpell PullingStrikeAiAction = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "PullingStrikeAiAction");

        public static void HandleRandomBosses() {
            RandomBossAbilities();
            RandomBossBuffs();
        }

        private static void RandomBossAbilities() {
            if (HEContext.AbilityChanges.BossChanges.IsDisabled("RandomBossChanges")) { return; }

            Utils.CustomHelpers.AddFactListsToUnit(Bosses.Mutasafen, Bosses.Mutasafen.CR, BuffLists.RandomBossBuffLists.MutasafenAbilities);

            BrainList.Mutasafen_Brain.m_Actions = BrainList.Mutasafen_Brain.m_Actions.AppendToArray(
                GreaterInvisibilityAiSpellSwift.ToReference<BlueprintAiActionReference>(),
                AiCastSpellList.MythicShadow_Demon_LegendaryProportions_AiAction.ToReference<BlueprintAiActionReference>()
            );


            // This should be the priestress fight in midnight fane, party level should be 15~ 
            //MidnightFane_NocticulaPriestess

        }
        private static void RandomBossBuffs() {
            if (HEContext.Prebuffs.BossBuffs.IsDisabled("RandomBossBuffs")) { return; }


            Utils.CustomHelpers.AddFactListsToUnit(Bosses.Maugla, Bosses.Maugla.CR, BuffLists.RandomBossBuffLists.MauglaBuffs);


            foreach (BlueprintUnit thisUnit in Bosses.MutafasenList) {
                Utils.CustomHelpers.AddFactListsToUnit(thisUnit, thisUnit.CR, BuffLists.RandomBossBuffLists.MutasafenGangBuffs);
            }


            Utils.CustomHelpers.AddFactListsToUnit(Bosses.XanthirPhase1, Bosses.XanthirPhase1.CR, BuffLists.RandomBossBuffLists.XanthirBuffs);

        }
    }
}
