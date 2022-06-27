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

namespace HarderEnemies.UnitModifications.Cultists.MeleeCasters {
    internal class UnitLists {

        public static BlueprintUnit CR3_Cultist_Baphomet_MeleeCaster = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("b4c6114b68136a84ebead5c7707ed041");
        public static BlueprintUnit CR3_Cultist_Baphomet_MeleeCaster_RE = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("e64796d2b86317f47979fa2eea73926f");
        public static BlueprintUnit TemplarOfIvoryLabyrinth_CR3_Cultist_Baphomet_MeleeCaster = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("ad96fb0603854074bd5389c93350f94c");
        public static BlueprintUnit TemplarOfIvoryLabyrinth_CR4_Cultist_Baphomet_MeleeCaster = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("93ef438371d54b2a9702b06e56617ecc");
        public static BlueprintUnit CR4_Cultist_Baphomet_MeleeCaster = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("fa09c09aeff05b34ba4252911a507888");
        public static BlueprintUnit CR4_Cultist_Baphomet_MeleeCaster_RE = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("b399059a966de1349bb95ecc26c2706f");
        public static BlueprintUnit CR6_Cultist_Baphomet_MeleeCaster = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("5ffa288cb0d19284b81c0b768702d66f");
        public static BlueprintUnit CR6_Cultist_Baphomet_MeleeCaster_RE = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("1016a77e6bcc1bf40a220073a9f494ee");
        public static BlueprintUnit CR8_Cultist_Baphomet_MeleeCaster = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("9f37f9a07eee9c247b8aecd7961c4d82");
        public static BlueprintUnit CR8_Cultist_Baphomet_MeleeCaster_RE = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("9e09fe7622d2e784e9daa8cfcd92d7f1");
        public static BlueprintUnit CR8_Cultist_Kabriri_MeleeCaster = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("dffb1d17f24e3fc4587b5db823fd3628");
        public static BlueprintUnit TemplarOfIvoryLabyrinth_CR11_Cultist_Baphomet_MeleeCaster = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("6dbab5bb74b84f18892d1450a0f29357");
        public static BlueprintUnit TemplarOfIvoryLabyrinth_CR6_Cultist_Baphomet_MeleeCaster = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("2e92674265924a9297f01842e3e7b1e3");
        public static BlueprintUnit TemplarOfIvoryLabyrinth_CR8_Cultist_Baphomet_MeleeCaster = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("00d2c22cffbe405097820a607aa18695");
        public static BlueprintUnit CR10_Cultist_Kabriri_MeleeCaster = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("b8bd4df5069db37409233cada5f638fe");
        public static BlueprintUnit CR11_Cultist_Baphomet_MeleeCaster = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("cf2db6e10760abf419a756cb26c8da95");
        public static BlueprintUnit CR19_Cultist_Areshkagal_MeleeCaster = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("11259d0fa389c174492220445347be57");

        public static List<BlueprintUnit> LowLevelClericList = new List<BlueprintUnit>() {
               CR3_Cultist_Baphomet_MeleeCaster,
               CR3_Cultist_Baphomet_MeleeCaster_RE,
               TemplarOfIvoryLabyrinth_CR3_Cultist_Baphomet_MeleeCaster,
               CR4_Cultist_Baphomet_MeleeCaster,
               CR4_Cultist_Baphomet_MeleeCaster_RE,
               TemplarOfIvoryLabyrinth_CR4_Cultist_Baphomet_MeleeCaster,
            };

        public static List<BlueprintUnit> CR6ClericList = new List<BlueprintUnit>() {
               CR6_Cultist_Baphomet_MeleeCaster,
               CR6_Cultist_Baphomet_MeleeCaster_RE,
               TemplarOfIvoryLabyrinth_CR6_Cultist_Baphomet_MeleeCaster,
            };
        public static List<BlueprintUnit> CR8ClericList = new List<BlueprintUnit>() {
               CR8_Cultist_Baphomet_MeleeCaster,
               CR8_Cultist_Baphomet_MeleeCaster_RE,
               CR8_Cultist_Kabriri_MeleeCaster,
               TemplarOfIvoryLabyrinth_CR8_Cultist_Baphomet_MeleeCaster
            };
        public static List<BlueprintUnit> HighLevelClericList = new List<BlueprintUnit>() {
               TemplarOfIvoryLabyrinth_CR11_Cultist_Baphomet_MeleeCaster,
               CR10_Cultist_Kabriri_MeleeCaster,
               CR11_Cultist_Baphomet_MeleeCaster,
               //CR19_Cultist_Areshkagal_MeleeCaster separate
            };
    }
}
