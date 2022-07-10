﻿using Kingmaker.AI.Blueprints;
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

            Cultists.CultistClericBrains.CreateCultistClericBrains();
            Cultists.CultistWizardBrains.CreateCultistWizardBrains();

            DemonsByType.AbrikandiluBrain.CreateAbrikandiluBrain();
            DemonsByType.BrimorakBrain.CreateBrimorakBrain();
            DemonsByType.MinotaurBrains.Handler();
            DemonsByType.GlabrezuBrains.Handler();
            DemonsByType.DerakniBrains.CreateDerakniBrain();
            DemonsByType.CambionBrains.Handler();
            DemonsByType.MarilithBrains.CreateMarilithBrains();
            DemonsByType.GibrilithBrains.Handler();

            Cyborgs.CyborgDemonBrains.Handler();
            Cyborgs.CyborgBrains.Handler();

            Dragons.DragonBrain.Handler();

            Others.AngelBrains.Handler();
            Others.DevastatorBrains.CreateDevastatorBrain();
        }




    }
}