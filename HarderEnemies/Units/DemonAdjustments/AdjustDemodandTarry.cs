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


namespace HarderEnemies.Units.DemonAdjustments {
    internal class AdjustDemodandTarry {


        public static void DemodandTarryHandler() {
            DemodandTarryAbilities();
            DemodandTarryBuffs();
        }

        private static void DemodandTarryAbilities() {
            if (HEContext.AbilityChanges.DemonChanges.IsDisabled("DemodandTarryAbilities")) { return; }
            // lisätään braineihin jo olemassa oelvia spellejä. lisättään pari damage spelliä

            // HUOM OSA NÄISTÄ ON KINETIICISTEJÄ, niille eri jutut/ei mitään
            HEContext.Logger.LogHeader("Updated DemonTarry abilities");
        }

        private static void DemodandTarryBuffs() {
            if (HEContext.Prebuffs.DemonBuffs.IsDisabled("DemodandTarryBuffs")) { return; }
            
            foreach (BlueprintUnit thisUnit in Demons.DemodandTarryList) {
                thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(BuffLists.DemonBuffLists.DemodandTarryBuffs);
            }
            HEContext.Logger.LogHeader("Updated DemonTarry buffs");
        }

    }
}
