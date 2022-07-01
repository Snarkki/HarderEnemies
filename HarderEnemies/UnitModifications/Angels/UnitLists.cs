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

namespace HarderEnemies.UnitModifications.Angels {
    internal class UnitLists {

        public static BlueprintUnit AngelTargona = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("81297c673b63b60448ef88a10db6bc78");
        public static BlueprintUnit DLC1_AngelTargona = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("00b678a6b73f45e6817bd554c88878f3");
        public static BlueprintUnit MidnightFane_MonadicDeva = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("5c5a98f8f91b9cb4dad9180988ea09d1");
        public static BlueprintUnit PuluraFall_Eliandra = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("e349079a648cb15448a27f9049344bf1");
        public static BlueprintUnit Yaniel = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("d914111e83e44194db99ab91d8c04632");
        public static BlueprintUnit Yaniel_DrezenCitadelLevel2 = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("6774bfa8c17aa6f4f88129b1451d6a4c");
        public static BlueprintUnit Herald = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("fff912fcbfbbc364e84ae5ea9384db89");

        public static BlueprintUnit IrabethTirabade = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("d1e567736abf23943b9f041ba7a0bc23");
        public static BlueprintUnit IrabethTirabadeDrezen = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("b14f909c20a130d47b907ad1a8cf4984");
        public static BlueprintUnit IrabethTirabadeGG = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("e778129f817a5fa4286e64b061df84a5");
        public static BlueprintUnit IrabethTirabade_DH = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("48cc2d6daf65f014781f6ea76c2565bc");
        public static BlueprintUnit IrabethTirabade_DrezenCapital = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("280d4712dceb37f4a88e98f1f4c6e64f");
        public static BlueprintUnit IrabethTirabade_GibberingSwarm = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("910ba83603ad7d04ab3d46bca33d8a2a");
        public static BlueprintUnit IrabethTirabade_Iz = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("9adfeebc39054544fa0f924022e43c1c");
        public static BlueprintUnit IrabethTirabade_LostChapel = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("758596d3dbc112d40aa1a2fc64991076");

        public static BlueprintUnit QueenGalfrey = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("97d1c33c784100140b9fa317aef5a499");
        public static BlueprintUnit QueenGalfreyDisguised = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("a8b7f6fd39ff2974f8b5fbf944a7f735");
        public static BlueprintUnit QueenGalfreyDrezen = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("dd4cc594a29e25542bc6da2e69b9aee9");
        public static BlueprintUnit QueenGalfrey_DH = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("ac2060f96475ca54e8238cb1d8fc20a3");
        public static BlueprintUnit QueenGalfrey_DrezenCapital = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("8c5dcc93d68d0ed44afd43902201da40");
        public static BlueprintUnit QueenGalfrey_LostChapel = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("93f70f6a27e49c049b5e3f3fdc52ff15");


        public static BlueprintUnit AlushinyrraHerald = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("ba4d057e32bd2984f969bc781da523ba");



        public static List<BlueprintUnit> AngelsList = new List<BlueprintUnit>() {
            MidnightFane_MonadicDeva,
            //AlushinyrraHerald,
            //AngelTargona,
            //PuluraFall_Eliandra,
            Herald,
        };

        public static List<BlueprintUnit> IrabethList = new List<BlueprintUnit>() {
            IrabethTirabade,
            IrabethTirabadeDrezen,
            IrabethTirabadeGG,
            IrabethTirabade_DH,
            IrabethTirabade_DrezenCapital,
            IrabethTirabade_Iz,
            IrabethTirabade_LostChapel,
        };
        public static List<BlueprintUnit> GalfreyList = new List<BlueprintUnit>() {
            QueenGalfrey,
            QueenGalfreyDisguised,
            QueenGalfreyDrezen,
            QueenGalfrey_DH,
            QueenGalfrey_DrezenCapital,
            QueenGalfrey_LostChapel,
        };
    }
}
