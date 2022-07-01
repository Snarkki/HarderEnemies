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

namespace HarderEnemies.UnitModifications.Demons.DemodandTarry {
    internal class UnitLists {

        public static BlueprintUnit AlushinyrraDemodandCommonerTarry = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("c7f84a4550b4355499e6af3ec1b985cf");
        public static BlueprintUnit AlushynirraDemodandKineticist = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("17c83213a13646e9892d63d5004fd87f");
        public static BlueprintUnit AlushynirraDemodandMiniboss = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("e67d5e358a59f7c4b8803ed6c54c36c0");
        public static BlueprintUnit AngryDemodandLeader = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("12d74de992a8845458ba8a16ace425a7");
        public static BlueprintUnit CR13_DemodandTarryStandard = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("3789d14f264253f4195aa88fd5ecf16e");
        public static BlueprintUnit CR13_DemodandTarryStandard_RE = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("89067e73046746f6b6811ea33e80099e");
        public static BlueprintUnit CR14_DemodandTarryAdvanced = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("fef5ca46f853a5f4eb022a75033ab899");
        public static BlueprintUnit CR14_DemodandTarryAdvanced_RE = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("de5f05998fe94717a442bb4e41833351");
        public static BlueprintUnit CR17_DemodandTarryAdvanced_Alushnirra = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("6cd6d98b2205c2f44befdf99c7cd38cd");
        public static BlueprintUnit CR18_IvoryLabyrinthDemodandKineticist = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("6d4ee360322a3bc439c0dad1b9679bbf");
        public static BlueprintUnit DemodandTarryLairMiniboss = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("05c24788a0aca3844892cbe95d162fac");
        public static BlueprintUnit IvoryLabyrinthDemodand18 = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("1aa9d5b5a777f5c4eb56cdf9a911d299");
        public static BlueprintUnit IvoryLabyrinthDemodand19 = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("b9968b8e008c849469f2a42ffedc3a74");
        public static BlueprintUnit IvoryLabyrinthDemodandKineticist18 = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("9985ef20ad8c9024e8a97176938776cd");
        public static BlueprintUnit IvoryLabyrinthLongspearDemodand = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("097c68b95055434419d2ab4e6ad6633e");
        public static BlueprintUnit IvoryLabyrinthMinibossDemodand20 = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("6416a982a6745814f86e5e48544e097c");
        public static BlueprintUnit IvoryLabyrinthRangedDemodand18 = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("94d17b0461693444b8f3ba863b479915");
        public static BlueprintUnit TTD_DemodandPatron = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("7678a579f19fb4c4eb431efb5b243ce6");


        public static List<BlueprintUnit> DemodandTarryList = new List<BlueprintUnit>() {
            AlushinyrraDemodandCommonerTarry,
            AlushynirraDemodandKineticist,
            AlushynirraDemodandMiniboss,
            AngryDemodandLeader,
            CR13_DemodandTarryStandard,
            CR13_DemodandTarryStandard_RE,
            CR14_DemodandTarryAdvanced,
            CR14_DemodandTarryAdvanced_RE,
            CR17_DemodandTarryAdvanced_Alushnirra,
            CR18_IvoryLabyrinthDemodandKineticist,
            DemodandTarryLairMiniboss,
            IvoryLabyrinthDemodand18,
            IvoryLabyrinthDemodand19,
            IvoryLabyrinthDemodandKineticist18,
            IvoryLabyrinthLongspearDemodand,
            IvoryLabyrinthMinibossDemodand20,
            IvoryLabyrinthRangedDemodand18,
            TTD_DemodandPatron,
        };
    }
}
