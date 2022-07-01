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

namespace HarderEnemies.UnitModifications.Dragons {
    internal class UnitLists {

        public static BlueprintUnit CR10_BlueDragonJuvenile = BlueprintTools.GetBlueprint<BlueprintUnit>("e0002289ebae86343ad8568383d0b119");
        public static BlueprintUnit CR11_BlackDragonAdult = BlueprintTools.GetBlueprint<BlueprintUnit>("f59db197439759f4593e633a9e23b5f8");
        public static BlueprintUnit CR11_MatureAdultWhiteDragon = BlueprintTools.GetBlueprint<BlueprintUnit>("540863f9622b42e47b798cfe1b0059f2");
        public static BlueprintUnit CR16_BlackDragonAncient = BlueprintTools.GetBlueprint<BlueprintUnit>("6c44c85235c34a41b1dbfc0d6155e9b1");
        //public static BlueprintUnit DLC1_Terendelev = BlueprintTools.GetBlueprint<BlueprintUnit>("c4b7937db69944bcbf92298e40494b0f");
        //public static BlueprintUnit DLC1_WintersunWhiteDragon = BlueprintTools.GetBlueprint<BlueprintUnit>("10a6ec63990a4a2f87207ce207a229d8");
        //public static BlueprintUnit DLC1_WoundWormsLair_BlackDragon = BlueprintTools.GetBlueprint<BlueprintUnit>("1b7f42d9cfbd424fb31a8186520c29d0");
        public static BlueprintUnit RedDragon = BlueprintTools.GetBlueprint<BlueprintUnit>("9e8727d008bec6e47842ba13df87d939");
        public static BlueprintUnit RedDragon_Sanctum = BlueprintTools.GetBlueprint<BlueprintUnit>("b01da68dab56e004f952d7ad0e83cc46");
        public static BlueprintUnit Terendelev_Undead = BlueprintTools.GetBlueprint<BlueprintUnit>("59e7482d41d058a4bace7434c67a08be");
        public static BlueprintUnit WintersunWhiteDragon = BlueprintTools.GetBlueprint<BlueprintUnit>("68fc75dad58dc8a499d6c3fb11ed5915");
        public static BlueprintUnit WoundWormsLair_BlackDragon = BlueprintTools.GetBlueprint<BlueprintUnit>("c540d81c08822c14da75761493427e4c");

        public static List<BlueprintUnit> DragonList = new List<BlueprintUnit>() {
                CR16_BlackDragonAncient,
                RedDragon,
                RedDragon_Sanctum,
                WoundWormsLair_BlackDragon,
        };
        public static List<BlueprintUnit> LesserDragonsList = new List<BlueprintUnit>() {
                CR10_BlueDragonJuvenile,
                CR11_BlackDragonAdult,
                CR11_MatureAdultWhiteDragon,
                WintersunWhiteDragon,
        };
    }
}
