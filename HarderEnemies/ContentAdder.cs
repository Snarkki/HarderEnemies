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
                AI_Mechanics.Brains.MeleeCultistBrains.BrainHandler();
                AI_Mechanics.Brains.BossBrains.BalorBrains.Handler();
                // 


                UnitModifications.Cultists.MeleeCasters.MeleeCasterAdjusts.Handler();
                UnitModifications.Cultists.Casters.CasterAdjusts.Handler();
                UnitModifications.Angels.AngelAdjusts.Handler();
                UnitModifications.Bosses.Balors.BalorAdjusts.Handler();
                UnitModifications.Bosses.CorruptedAngels.CorruptedAngelAdjusts.Handler();
                UnitModifications.Bosses.DemonLords.DemonLordAdjusts.Handler();
                UnitModifications.Bosses.Jerribeth.JerribethAdjusts.Handler();
                UnitModifications.Bosses.Minagho.MinaghoAdjusts.Handler();
                UnitModifications.Bosses.RandomBosses.RandomBossesAdjusts.Handler();
                UnitModifications.Cyborgs.CyborgAdjusts.Handler();
                UnitModifications.Demons.Abrikandilu.AbrikandiluAdjusts.Handler();
                UnitModifications.Demons.Babau.BabauAdjusts.Handler();
                UnitModifications.Demons.Brimorak.BrimorakAdjusts.Handler();
                UnitModifications.Demons.Cambion.CambionAdjusts.Handler();
                UnitModifications.Demons.Coloxus.ColoxusAdjusts.Handler();
                UnitModifications.Demons.DemondandStringy.DemodandStringyAdjust.Handler();
                UnitModifications.Demons.DemodandTarry.DemodandTarryAdjusts.Handler();
                UnitModifications.Demons.Gibrileth.GibrilethAdjusts.Handler();
                UnitModifications.Demons.Glabrezu.GlabrezuAdjusts.Handler();
                UnitModifications.Demons.Marileth.MarilethAdjusts.Handler();
                UnitModifications.Demons.Minotaur.MinotaurAdjusts.Handler();
                UnitModifications.Demons.Oolioddroo.OolioddrooAdjusts.Handler();
                UnitModifications.Dragons.DragonAdjusts.Handler();
                UnitModifications.EliteCasters.EliteCasterAdjusts.Handler();
                UnitModifications.Golems.GolemAdjusts.Handler();
                UnitModifications.Retrievers.RetrieverAdjusts.Handler();
                UnitModifications.VescavorAndDerakni.VescavorAndDerakniAdjusts.Handler();

                HEContext.Logger.LogHeader("Updates done");
            }


        }
    }
}
