using HarderEnemies.AI_Mechanics.Brains;
using Kingmaker.Blueprints;
using Kingmaker.Blueprints.Classes;
using Kingmaker.UnitLogic.FactLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TabletopTweaks.Core.Utilities;
using HarderEnemies.AI_Mechanics.Actions;
using static HarderEnemies.Main;
using HarderEnemies.Blueprints;
using Kingmaker.AI.Blueprints;
using HarderEnemies.Units.DemonAdjustments;

namespace HarderEnemies.Units {
    public class ModifyDemons {

        private static BlueprintFeature SuperToughness = BlueprintTools.GetModBlueprint<BlueprintFeature>(HEContext, "SuperToughnessFeature");

        public static void HandleChanges() {

            // Balors are in bosses
            ModifyDemons.AdjustHP();

            AdjustAbrikandilu.AbrikandilHandler();
            AdjustBabau.BabauHandler();
            AdjustBrimorak.BrimorakHandler();
            AdjustColoxus.ColoxaiHandler();
            AdjustDemodandStringy.DemodandStringyHandler();
            AdjustDemodandTarry.DemodandTarryHandler();
            AdjustGibrileth.GibrilethHandler();
            AdjustGlabrezu.GlabrezuHandler();
            AdjustMariliths.MarilithHandler();
            AdjustOolioddroo.OoliodroHandler();
            AdjustDemonCambion.CambionHandler();
        }

        private static void AdjustHP() {
            if (HEContext.HPChanges.HPBoosts.IsDisabled("AdjustDemons")) { return; }

            foreach (BlueprintUnit thisUnit in Demons.DemonMegaList) {
                thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(SuperToughness.ToReference<BlueprintUnitFactReference>());
            }
            HEContext.Logger.LogHeader("Adjusted Demons HP");
        }

    }
}
