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


namespace HarderEnemies.Units {
    public class ModifyCyborgs {

        private static BlueprintFeature SuperToughness = BlueprintTools.GetModBlueprint<BlueprintFeature>(HEContext, "SuperToughnessFeature");
        
        
        public static void HandleChanges() {
            ModifyCyborgs.AdjustHP();
            ModifyCyborgs.CasterAbilities();
            ModifyCyborgs.CasterBuffs();
        }

        private static void AdjustHP() {
            if (HEContext.HPChanges.HPBoosts.IsDisabled("AdjustCyborgsHP")) { return; }

            foreach (BlueprintUnit thisUnit in Lists.Cyborgs.CyborgsList) {
                thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(SuperToughness.ToReference<BlueprintUnitFactReference>());
            }
            HEContext.Logger.LogHeader("Adjusted Cyborg Caster HP");
        }

        public static void CasterAbilities() {
            if (HEContext.AbilityChanges.OtherChanges.IsDisabled("CyborgChanges")) { return; }
            foreach (BlueprintUnit thisUnit in Lists.Cyborgs.CyborgsList) {
                //Utils.CustomHelpers.AddFactListsToUnit(thisUnit, thisUnit.CR, BuffLists.CultistBuffLists.CultistCasterAbilities);
                //thisUnit.AlternativeBrains = new BlueprintBrainReference[0] { };          
            }

            HEContext.Logger.LogHeader("Updated Cyborg Abilities");
        }
        public static void CasterBuffs() {

            if (HEContext.Prebuffs.OtherBuffs.IsDisabled("CyborgBuffs")) { return; }

            foreach (BlueprintUnit thisUnit in Lists.Cyborgs.CyborgsList) {
                //Utils.CustomHelpers.AddFactListsToUnit(thisUnit, thisUnit.CR, BuffLists.CultistBuffLists.CultistCasterBuffs);
            }

            HEContext.Logger.LogHeader("Updated Cyborg Buffs");
        }
    }
}

