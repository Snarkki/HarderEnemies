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
        public static BlueprintUnit NocticulaInDress = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("9182101ebd724cad9914015acf5f58c0");
        public static BlueprintUnit Nocticula = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("0cca8c841d634d84fbec2609c8db3465");
        public static BlueprintUnit Baphomet = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("f8007503fe211da4eb027e070eeb3f8c");
        public static BlueprintUnit MidnightFane_NocticulaPriestess = BlueprintTools.GetBlueprint<BlueprintUnit>("2d6fe3abc0ed7364ba48e604ae2471bd");
        public static BlueprintUnit EchoOfDeskari = BlueprintTools.GetBlueprint<BlueprintUnit>("a40904b640d757a498f7d10b3e066f84");
        public static BlueprintUnit EchoOfDeskari_ForFight = BlueprintTools.GetBlueprint<BlueprintUnit>("e0cb4338cb6e72146a8a35794a0034be");
        public static BlueprintUnit MidnightFane_ShadowDemonNocticula = BlueprintTools.GetBlueprint<BlueprintUnit>("786e50e95d025e8498281178fec9d182");
        public static BlueprintUnit CR30_AreshkagalBoss = BlueprintTools.GetBlueprint<BlueprintUnit>("7a1b0862dd2443b49adaba36b194e5de");

        public static List<BlueprintUnit> DemonLordList = new List<BlueprintUnit>() {
            MidnightFane_NocticulaPriestess,
            MidnightFane_ShadowDemonNocticula,
            CR30_AreshkagalBoss,
            DemonLordDeskari,
            Nocticula_AlushinyrraMythicDemon,
            AreeluDemonicForm,
            NocticulaInDress,
            Nocticula,
            Baphomet,
            EchoOfDeskari,
            EchoOfDeskari_ForFight
        };


        public static List<BlueprintUnit> NocticulaList = new List<BlueprintUnit>() {
            NocticulaInDress,
            Nocticula,
        };

        public static List<BlueprintUnit> DeskariList = new List<BlueprintUnit>() {
            DemonLordDeskari,
            EchoOfDeskari,
            EchoOfDeskari_ForFight
        };
    }
}
