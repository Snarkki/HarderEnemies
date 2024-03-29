﻿using Kingmaker.AI.Blueprints;
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

namespace HarderEnemies.UnitModifications.Demons.DemodandTarry {
    internal class DemodandTarryAdjusts {




        private static BlueprintFeature SuperToughness = BlueprintTools.GetModBlueprint<BlueprintFeature>(HEContext, "SuperToughnessFeature");

        public static void Handler() {
            AdjustHP();
            DemodandTarryAbilities();
            DemodandTarryBuffs();
        }

        private static void AdjustHP() {
            if (HEContext.HPChanges.HPBoosts.IsDisabled("AdjustDemonsHp")) { return; }

            foreach (BlueprintUnit thisUnit in UnitLists.DemodandTarryList) {
                thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(SuperToughness.ToReference<BlueprintUnitFactReference>());
            }
            HEContext.Logger.LogHeader("Adjusted Demons HP");
        }

        private static void DemodandTarryAbilities() {
            if (HEContext.AbilityChanges.DemonChanges.IsDisabled("DemodandTarryAbilities")) { return; }
            // lisätään braineihin jo olemassa oelvia spellejä. lisättään pari damage spelliä

            // HUOM OSA NÄISTÄ ON KINETIICISTEJÄ, niille eri jutut/ei mitään
            HEContext.Logger.LogHeader("Updated DemonTarry abilities");
        }

        private static void DemodandTarryBuffs() {
            if (HEContext.Prebuffs.DemonBuffs.IsDisabled("DemodandTarryBuffs")) { return; }

            foreach (BlueprintUnit thisUnit in UnitLists.DemodandTarryList) {
                thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(BuffLists.DemodandTarryBuffs);
            }
            HEContext.Logger.LogHeader("Updated DemonTarry buffs");
        }

    }
}
