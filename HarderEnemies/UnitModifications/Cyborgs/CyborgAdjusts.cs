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

            "melee cyborgien luonti: 2h -> intimidating tms, tower shield jäbät -> trip"

                "cyborg demonit: -ac ainaskin, joku mleee buiildi, vampiric touch succubuksilel jotain muutakin"
            CR13_CyborgGreaterKalavakusAdvanced,

            CR14_Cyborg_CrusaderTankLevel12,


            CR15_Cyborg_CrusaderMeleeLevel13,

            CR15_Cyborg_Incubus_Assasin,
            CR16_Cyborg_SuccubusSorc,


            Utils.CustomHelpers.AddMemorizedSpellsAndBrains(UnitLists.CR15_Cyborg_CrusaderCasterLevel13, CharacterClass.WizardClass, AbilityLists.CyborgCasterSpells, CR8ClericBrain);

            HEContext.Logger.LogHeader("Updated Cyborg Abilities");
        }
        public static void CasterBuffs() {

            if (HEContext.Prebuffs.OtherBuffs.IsDisabled("CyborgBuffs")) { return; }

            foreach (BlueprintUnit thisUnit in UnitLists.CyborgsList) {
                //Utils.CustomHelpers.AddFactListsToUnit(thisUnit, thisUnit.CR, BuffLists.CultistBuffLists.CultistCasterBuffs);
            }

            HEContext.Logger.LogHeader("Updated Cyborg Buffs");
        }
    }
}

