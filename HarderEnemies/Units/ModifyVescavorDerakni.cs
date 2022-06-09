using Kingmaker.Blueprints;
using Kingmaker.Blueprints.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TabletopTweaks.Core.Utilities;
using static HarderEnemies.Main;
using HarderEnemies.Blueprints;
using HarderEnemies.Features;
using Kingmaker.UnitLogic.Abilities.Components;
using Kingmaker.UnitLogic.Mechanics.Actions;
using Kingmaker.AI.Blueprints;

namespace HarderEnemies.Units {
    public class ModifyVescavors {
        private static BlueprintFeature SuperToughness = BlueprintTools.GetModBlueprint<BlueprintFeature>(HEContext, "SuperToughnessFeature");
        private static BlueprintBrain DerakniNewStandardBrain = BlueprintTools.GetModBlueprint<BlueprintBrain>(HEContext, "DerakniNewStandardBrain");
        public static void HandleChanges() {
            AdjustHP();
            HandleVescavorAbilities();
            HandleVescavorBuffs();
        }

        private static void AdjustHP() {
            if (HEContext.HPChanges.HPBoosts.IsDisabled("AdjustVescavorDerakniHp")) { return; }

            foreach (BlueprintUnit thisUnit in Vescavor.VescavorList) {
                thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(SuperToughness.ToReference<BlueprintUnitFactReference>());
            }
            foreach (BlueprintUnit thisUnit in Vescavor.DerakniList) {
                thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(SuperToughness.ToReference<BlueprintUnitFactReference>());
            }
            HEContext.Logger.LogHeader("Adjusted Vescavor&Derakni HP");

        }


        public static void HandleVescavorAbilities() {
            if (HEContext.AbilityChanges.OtherChanges.IsDisabled("VescavorChanges")) { return; }
            //VESCAVORS
            foreach (BlueprintUnit thisUnit in Vescavor.VescavorList) {
                thisUnit.m_AddFacts = thisUnit.m_AddFacts.RemoveFromArray(FeatureList.VescavorQueenGibberAbility.ToReference<BlueprintUnitFactReference>());
                thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(FeatureList.TripBite.ToReference<BlueprintUnitFactReference>());
            }

            // add sunder armor action to acid spit
            var acidSpit = Abilities.VescavorGuardSpitAcidAbility.GetComponent<AbilityEffectRunAction>();
            acidSpit.Actions.Actions = acidSpit.Actions.Actions.AppendToArray(Helpers.Create<ContextActionCombatManeuver>(c => {
                c.Type = Kingmaker.RuleSystem.Rules.CombatManeuver.SunderArmor;
            }));

            // DERAKNIS -> teleport -> strike -> trip / confuse
            foreach (BlueprintUnit thisUnit in Vescavor.DerakniList) {
                if (!thisUnit.AddFacts.Contains(Abilities.DimensionDoorHell.ToReference<BlueprintUnitFactReference>())) {
                    thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(Abilities.DimensionDoorHell.ToReference<BlueprintUnitFactReference>());
                }
                thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(FeatureList.TripBite.ToReference<BlueprintUnitFactReference>());
                thisUnit.AlternativeBrains = new BlueprintBrainReference[] { };
                thisUnit.m_Brain = DerakniNewStandardBrain.ToReference<BlueprintBrainReference>();
            }
            HEContext.Logger.LogHeader("Updated Vescavor/Derakni Abilities");
        }

        public static void HandleVescavorBuffs() {
            if (HEContext.Prebuffs.OtherBuffs.IsDisabled("VescavorBuffs")) { return; }

            HEContext.Logger.LogHeader("Updated Vescavor/Derakni Buffs");
        }

    }
}
//public static BlueprintUnit CR14_VescavorQueenBoss = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("3d59b2d00f92a244ea887bd74f96dd85");
//public static BlueprintUnit CR19_VescavorGuard = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("0413e0164ae24d9d9d78348a186ce375");
//public static BlueprintUnit CR8_VescavorGuardStandard = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("17a0d2b9a532ff641bc122778fa80e05");
//public static BlueprintUnit DaeranAlienSwarm = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("0264a9119a0737447a226cdd4ba1f79b");
//public static BlueprintUnit LocustVescavorQueen = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("e3cbfef493c4a3f4fa2abb660ba6aad6");
//public static BlueprintUnit RavenousVescavorSwarm = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("d1add298a78c9744c89c9b4f87df5316");
//public static BlueprintUnit AreeluLab_Derakni = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("9a07422abebed6e44be52b88abbdfa7a");
//public static BlueprintUnit CR10_DerakniStandard = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("1f8c87fde2d7be342b90a58d0180884b");
//public static BlueprintUnit CR10_DerakniStandard_RE_high = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("edd5319f92515d74ea02873b77230a30");
//public static BlueprintUnit CR12_DerakniAdvanced_RE_low = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("a4730df1e4da4fd389b8295de151051b");
//public static BlueprintUnit CR13_DerakniAdvanced = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("43233c4df8cbbde4c8168ad7d70dc639");
//public static BlueprintUnit CR13_DerakniAdvanced_RE_high = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("0bdd872da4d44bb390f2c31b7a41cb23");
//public static BlueprintUnit CR22_MythicDerakniFighter = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("bd78f369ef376ad478061cd73555efc2");
//public static BlueprintUnit CR9_DerakniStandard_RE_low = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("9299782d53344be78c58eaf371878d83");
//public static BlueprintUnit WintersunDerakniAdvanced = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("5ece6c29406ee1247864f8586a2e292b");