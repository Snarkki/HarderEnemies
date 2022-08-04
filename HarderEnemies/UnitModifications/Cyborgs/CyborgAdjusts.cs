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

namespace HarderEnemies.UnitModifications.Cyborgs {
    internal class CyborgAdjusts {


        private static BlueprintFeature SuperToughness = BlueprintTools.GetModBlueprint<BlueprintFeature>(HEContext, "SuperToughnessFeature");
        private static BlueprintBrain KalavakusBrain = BlueprintTools.GetModBlueprint<BlueprintBrain>(HEContext, "KalavakusBrain");
        private static BlueprintBrain CyborgTankBrain = BlueprintTools.GetModBlueprint<BlueprintBrain>(HEContext, "CyborgTankBrain");
        private static BlueprintBrain CyborgMeleeBrain = BlueprintTools.GetModBlueprint<BlueprintBrain>(HEContext, "CyborgMeleeBrain");
        private static BlueprintBrain IncubusAssassinBrain = BlueprintTools.GetModBlueprint<BlueprintBrain>(HEContext, "IncubusAssassinBrain");
        private static BlueprintBrain SuccubusSorcererBrain = BlueprintTools.GetModBlueprint<BlueprintBrain>(HEContext, "SuccubusSorcererBrain");
        private static BlueprintBrain CyborgWizardBrain = BlueprintTools.GetModBlueprint<BlueprintBrain>(HEContext, "CyborgWizardBrain");



        public static void Handler() {
            AdjustHP();
            CasterAbilities();
            CasterBuffs();
        }

        private static void AdjustHP() {
            if (HEContext.HPChanges.HPBoosts.IsDisabled("AdjustCyborgsHP")) { return; }

            foreach (BlueprintUnit thisUnit in UnitLists.CyborgsList) {
                thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(SuperToughness.ToReference<BlueprintUnitFactReference>());
            }
            HEContext.Logger.LogHeader("Adjusted Cyborg Caster HP");
        }

        public static void CasterAbilities() {
            if (HEContext.AbilityChanges.OtherChanges.IsDisabled("CyborgChanges")) { return; }
            foreach (BlueprintUnit thisUnit in UnitLists.CyborgsList) {
                //Utils.CustomHelpers.AddFactListsToUnit(thisUnit, thisUnit.CR, BuffLists.CultistBuffLists.CultistCasterAbilities);
                //thisUnit.AlternativeBrains = new BlueprintBrainReference[0] { };          
            }

            // CYBORG GREATER KALAVAKUS -> CHARGE/HASTE/GCOMMAND/TRIP/DISARM
            UnitLists.CR13_CyborgGreaterKalavakusAdvanced.AddComponent<AddStatBonus>(c => {
                c.Value = -7;
                c.Descriptor = Kingmaker.Enums.ModifierDescriptor.UntypedStackable;
                c.Stat = Kingmaker.EntitySystem.Stats.StatType.AC;
            });
            UnitLists.CR13_CyborgGreaterKalavakusAdvanced.m_Brain = KalavakusBrain.ToReference<BlueprintBrainReference>();
            UnitLists.CR13_CyborgGreaterKalavakusAdvanced.AlternativeBrains = new BlueprintBrainReference[0] { };


            //Crusader Tank -> dazzling display bot
            Utils.CustomHelpers.AddFactsToUnit(UnitLists.CR14_Cyborg_CrusaderTankLevel12, AbilityLists.CyborgTankFeatures);
            UnitLists.CR14_Cyborg_CrusaderTankLevel12.m_Brain = CyborgTankBrain.ToReference<BlueprintBrainReference>();
            UnitLists.CR14_Cyborg_CrusaderTankLevel12.AlternativeBrains = new BlueprintBrainReference[0] { };

            //Crusader 2h -> cleave bot
            Utils.CustomHelpers.AddFactsToUnit(UnitLists.CR15_Cyborg_CrusaderMeleeLevel13, AbilityLists.Cyborg2hFeatures);
            UnitLists.CR15_Cyborg_CrusaderMeleeLevel13.m_Brain = CyborgMeleeBrain.ToReference<BlueprintBrainReference>();
            UnitLists.CR15_Cyborg_CrusaderMeleeLevel13.AlternativeBrains = new BlueprintBrainReference[0] { };


            //Assasin Incubus
            Utils.CustomHelpers.AddFactsToUnit(UnitLists.CR15_Cyborg_Incubus_Assasin, AbilityLists.IncubusAssassinFeatures);
            UnitLists.CR15_Cyborg_Incubus_Assasin.m_Brain = IncubusAssassinBrain.ToReference<BlueprintBrainReference>();
            UnitLists.CR15_Cyborg_Incubus_Assasin.AlternativeBrains = new BlueprintBrainReference[0] { };


            //CR16_Cyborg_SuccubusSorc
            Utils.CustomHelpers.AddFactsToUnit(UnitLists.CR16_Cyborg_SuccubusSorc, AbilityLists.SuccubusSorcererFeatures);
            UnitLists.CR16_Cyborg_SuccubusSorc.m_Brain = SuccubusSorcererBrain.ToReference<BlueprintBrainReference>();
            UnitLists.CR16_Cyborg_SuccubusSorc.AlternativeBrains = new BlueprintBrainReference[0] { };


            // Cyborg Caster Wizarad
            Utils.CustomHelpers.AddMemorizedSpellsAndBrains(UnitLists.CR15_Cyborg_CrusaderCasterLevel13, CharacterClass.WizardClass, CyborgWizardBrain,  AbilityLists.CyborgCasterSpells);
            Utils.CustomHelpers.AddFactsToUnit(UnitLists.CR15_Cyborg_CrusaderCasterLevel13, AbilityLists.CyborgCasterAbilities);


            HEContext.Logger.LogHeader("Updated Cyborg Abilities");
        }
        public static void CasterBuffs() {

            if (HEContext.Prebuffs.OtherBuffs.IsDisabled("CyborgBuffs")) { return; }

            foreach (BlueprintUnit thisUnit in UnitLists.CyborgsList) {
                //Utils.CustomHelpers.AddFactListsToUnit(thisUnit, thisUnit.CR, BuffLists.CultistBuffLists.CultistCasterBuffs);
            }
            Utils.CustomHelpers.AddFactListsToUnit(UnitLists.CR15_Cyborg_CrusaderMeleeLevel13,  BuffLists.Cyborg2HMeleeBuffs);


            HEContext.Logger.LogHeader("Updated Cyborg Buffs");
        }
    }
}

