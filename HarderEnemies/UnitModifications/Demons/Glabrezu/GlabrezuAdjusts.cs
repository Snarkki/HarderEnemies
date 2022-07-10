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

namespace HarderEnemies.UnitModifications.Demons.Glabrezu {
    internal class GlabrezuAdjusts {

        private static BlueprintFeature SuperToughness = BlueprintTools.GetModBlueprint<BlueprintFeature>(HEContext, "SuperToughnessFeature");
        private static BlueprintBrain StandardGlabrezuBrain = BlueprintTools.GetModBlueprint<BlueprintBrain>(HEContext, "StandardGlabrezuBrain");
        private static BlueprintBrain AdvancedGlabrezuBrain = BlueprintTools.GetModBlueprint<BlueprintBrain>(HEContext, "AdvancedGlabrezuBrain");
        private static BlueprintBrain MythicGlabrezuBrain = BlueprintTools.GetModBlueprint<BlueprintBrain>(HEContext, "MythicGlabrezuBrain");


        public static void Handler() {
            AdjustHP();
            GlabrezuAbilities();
            GlabrezuBuffs();
        }


        private static void AdjustHP() {
            if (HEContext.HPChanges.HPBoosts.IsDisabled("AdjustDemonsHp")) { return; }

            foreach (BlueprintUnit thisUnit in UnitLists.DemonGlabrezuList) {
                thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(SuperToughness.ToReference<BlueprintUnitFactReference>());
            }
            HEContext.Logger.LogHeader("Adjusted Demons HP");
        }

        private static void GlabrezuAbilities() {
            if (HEContext.AbilityChanges.DemonChanges.IsDisabled("GlabrezuAbilities")) { return; }

            // standard glabrezu > mirror image, dispel magic & hit
            foreach (BlueprintUnit thisUnit in UnitLists.StandardGlabrezuList) {
                thisUnit.m_Brain = StandardGlabrezuBrain.ToReference<BlueprintBrainReference>();
                thisUnit.AlternativeBrains = new BlueprintBrainReference[0] { };
            }

            // advanced glabrezu > mirror image, confusion,  greater dispel magic, powerwordstun & hit
            foreach (BlueprintUnit thisUnit in UnitLists.AdvancedGlabrezuList) {
                Utils.CustomHelpers.AddFactsToUnit(thisUnit, AbilityLists.AdvancedGlabrezuAbilities);
                thisUnit.m_Brain = AdvancedGlabrezuBrain.ToReference<BlueprintBrainReference>();
                thisUnit.AlternativeBrains = new BlueprintBrainReference[0] { };
            }

            // mythic glabrezu > mirror image, prismatic spray, confusion, swift greater dispel magic, powerwordstun & hit
            foreach (BlueprintUnit thisUnit in UnitLists.AdvancedGlabrezuList) {
                Utils.CustomHelpers.AddFactsToUnit(thisUnit, AbilityLists.MythicGlabrezuAbilities);
                thisUnit.m_Brain = MythicGlabrezuBrain.ToReference<BlueprintBrainReference>();
                thisUnit.AlternativeBrains = new BlueprintBrainReference[0] { };
            }

            HEContext.Logger.LogHeader("Updated GlabrezuList");
        }

        private static void GlabrezuBuffs() {
            if (HEContext.Prebuffs.DemonBuffs.IsDisabled("GlabrezuBuffs")) { return; }
            foreach (BlueprintUnit thisUnit in UnitLists.DemonGlabrezuList) {
                thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(BuffLists.GlabrezuBuffs);
            }

            foreach (BlueprintUnit thisUnit in UnitLists.MythicGlabrezuList) {
                thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(BuffLists.GlabrezuBuffs);
            }
            HEContext.Logger.LogHeader("Updated GlabrezuListB");
        }

    }
}
