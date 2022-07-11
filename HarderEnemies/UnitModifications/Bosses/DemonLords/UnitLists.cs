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

namespace HarderEnemies.UnitModifications.Bosses.DemonLords {
    internal class UnitLists {

        public static BlueprintUnit DemonLordDeskari = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("5a75db49bf7aeaf4c9f0264cac3eed5c");
        public static BlueprintUnit Nocticula_AlushinyrraMythicDemon = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("ce682067f7f81084fbd00d3e57f877af");
        public static BlueprintUnit AreeluDemonicForm = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("6eac4b763b6504546a580d4f01c63bfa");
        public static BlueprintUnit Areelu = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("92f29ae2c49edb74f8943d30ea788dd0");
        public static BlueprintUnit NocticulaInDress = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("9182101ebd724cad9914015acf5f58c0");
        public static BlueprintUnit Nocticula = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("0cca8c841d634d84fbec2609c8db3465");
        public static BlueprintUnit Baphomet = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("f8007503fe211da4eb027e070eeb3f8c");
        public static BlueprintUnit CR30_AreshkagalBoss = BlueprintTools.GetBlueprint<BlueprintUnit>("7a1b0862dd2443b49adaba36b194e5de");

        public static List<BlueprintUnit> DemonLordList = new List<BlueprintUnit>() {
            CR30_AreshkagalBoss,
            DemonLordDeskari,
            Nocticula_AlushinyrraMythicDemon,
            AreeluDemonicForm,
            NocticulaInDress,
            Nocticula,
            Baphomet,
        };


        public static List<BlueprintUnit> NocticulaList = new List<BlueprintUnit>() {
            Nocticula_AlushinyrraMythicDemon,
            NocticulaInDress,
            Nocticula,
        };

        public static List<BlueprintUnit> AreeluList = new List<BlueprintUnit>() {
            AreeluDemonicForm,
            Areelu,
        };

    }
}
