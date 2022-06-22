using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarmonyLib;
using Kingmaker.Blueprints;
using Kingmaker.Blueprints.JsonSystem;
using static HarderEnemies.Main;

namespace HarderEnemies {
    class ContentAdder {
        [HarmonyPatch(typeof(BlueprintsCache), "Init")]
        static class BlueprintsCache_Init_Patch {
            static bool Initialized;

            [HarmonyAfter(new string[] { "TabletopTweaks-Base" })]
            static void Postfix() {
                if (Initialized) return;
                Initialized = true;
                HEContext.Logger.LogHeader("Modifying enemies");
                Features.NewFeatures.CreateNewFeatures();
                Features.NewSpells.CreateNewSpells();
                AI_Mechanics.Actions.AiConsiderations.CreateNew();
                AI_Mechanics.Actions.New_AiCastSpell.CreateNew();
                Items.Weapons.CreateNewWeapons();
                AI_Mechanics.Brains.CasterBrains.BrainHandler();
                AI_Mechanics.Brains.DemonBrains.DemonBrainHandler();
                AI_Mechanics.Brains.DragonBrain.DragonBrainHandler();
                AI_Mechanics.Brains.AngelBrains.AngelBrainHandler();
                // 
                Units.ModifyRetrieversDevastators.HandleChanges();
                Units.ModifyDragons.HandleChanges();
                Units.ModifyBosses.HandleChanges();
                Units.ModifyGolems.HandleChanges();
                Units.ModifyVescavors.HandleChanges();
                Units.ModifyCultists.HandleChanges();
                Units.ModifyDemons.HandleChanges();
                Units.ModifyAngels.HandleChanges();
                Units.ModifyEliteCasters.HandleChanges();
                Units.ModifyCyborgs.HandleChanges();
                HEContext.Logger.LogHeader("Updates done");
            }


        }
    }
}
