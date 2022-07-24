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

namespace HarderEnemies.UnitModifications.Demons.Coloxus {
    internal class ColoxusAdjusts {

        private static BlueprintFeature SuperToughness = BlueprintTools.GetModBlueprint<BlueprintFeature>(HEContext, "SuperToughnessFeature");
        private static BlueprintBrain NormalColoxusBrain = BlueprintTools.GetModBlueprint<BlueprintBrain>(HEContext, "NormalColoxusBrain");
        private static BlueprintBrain CasterColoxusBrain = BlueprintTools.GetModBlueprint<BlueprintBrain>(HEContext, "CasterColoxusBrain");
        private static BlueprintBrain DiscordColoxusBrain = BlueprintTools.GetModBlueprint<BlueprintBrain>(HEContext, "DiscordColoxusBrain");



        public static void Handler() {
            AdjustHP();
            ColoxaiAbilities();
            ColoxaiBuffs();
        }

        private static void AdjustHP() {
            if (HEContext.HPChanges.HPBoosts.IsDisabled("AdjustDemonsHp")) { return; }

            foreach (BlueprintUnit thisUnit in UnitLists.DemonColoxusList) {
                thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(SuperToughness.ToReference<BlueprintUnitFactReference>());
            }
            HEContext.Logger.LogHeader("Adjusted Demons HP");
        }

        private static void ColoxaiAbilities() {
            if (HEContext.AbilityChanges.DemonChanges.IsDisabled("ColoxusAbilities")) { return; }

            //standard coloxus
            foreach (BlueprintUnit thisUnit in UnitLists.StandardColoxusList) {
                thisUnit.AlternativeBrains = new BlueprintBrainReference[0] { };
                thisUnit.m_Brain = NormalColoxusBrain.ToReference<BlueprintBrainReference>();
            }
            //discord coloxus
            foreach (BlueprintUnit thisUnit in UnitLists.StandardColoxusList) {
                thisUnit.AlternativeBrains = new BlueprintBrainReference[0] { };
                thisUnit.m_Brain = DiscordColoxusBrain.ToReference<BlueprintBrainReference>();
            }
            //Caster coloxus (overwhelming presence)
            foreach (BlueprintUnit thisUnit in UnitLists.StandardColoxusList) {
                thisUnit.AlternativeBrains = new BlueprintBrainReference[0] { };
                thisUnit.m_Brain = CasterColoxusBrain.ToReference<BlueprintBrainReference>();
            }
        }

        private static void ColoxaiBuffs() {
            if (HEContext.Prebuffs.DemonBuffs.IsDisabled("ColoxusBuffs")) { return; }

            foreach (BlueprintUnit thisUnit in UnitLists.DemonColoxusList) {
                thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(BuffLists.ColoxusBuffs);
            }
            HEContext.Logger.LogHeader("Updated ColoxusList");
        }

    }
}
