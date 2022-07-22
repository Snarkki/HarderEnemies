using Kingmaker.AI.Blueprints;
using Kingmaker.Blueprints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TabletopTweaks.Core.Utilities;
using HarderEnemies.Blueprints;
using static HarderEnemies.Main;

namespace HarderEnemies.AI_Mechanics.Brains {
    internal class BrainHandler {
        // Handles brain additions, called by content adder. 
        public static void CreateBrains() {

            Bosses.BalorBrains.Handler();
            Bosses.DemonLords.Handler();
            Bosses.EliteCasters.Handler();
            Bosses.OtherBrains.Handler();

            Cultists.CultistClericBrains.CreateCultistClericBrains();
            Cultists.CultistWizardBrains.CreateCultistWizardBrains();

            Demons.AbrikandiluBrain.CreateAbrikandiluBrain();
            Demons.BrimorakBrain.CreateBrimorakBrain();
            Demons.MinotaurBrains.Handler();
            Demons.GlabrezuBrains.Handler();
            Demons.DerakniBrains.CreateDerakniBrain();
            Demons.CambionBrains.Handler();
            Demons.MarilithBrains.CreateMarilithBrains();
            Demons.GibrilithBrains.Handler();
            Demons.ColoxusBrains.Handler();

            Cyborgs.CyborgDemonBrains.Handler();
            Cyborgs.CyborgBrains.Handler();

            Dragons.DragonBrain.Handler();

            Others.AngelBrains.Handler();
            Others.DevastatorBrains.CreateDevastatorBrain();
        }




    }
}
