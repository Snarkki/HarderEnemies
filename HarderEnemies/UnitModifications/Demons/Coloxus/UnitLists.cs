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

namespace HarderEnemies.UnitModifications.Demons.Coloxus {
    internal class UnitLists {

        public static BlueprintUnit AlushinyrraColoxusCommoner = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("2590ec8b588c37f429b2ca25b9c31b76");
        public static BlueprintUnit CR12_ColoxusStandard = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("d5a01b84a52ed0e4f88dc06828360e2d");
        public static BlueprintUnit CR12_ColoxusStandard_RE_high = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("c59356fe81704e7188a4b8e246b9b2e3");
        public static BlueprintUnit CR13_ColoxusAdvanced = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("c67e65df175521040afcfc3621c4f2d5");
        public static BlueprintUnit CR13_ColoxusAdvanced_RE_high = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("54684bb9198b47fc90b49d3346bc27d4");
        public static BlueprintUnit CR15_ColoxusEmissary = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("ebfc4f9af4ec9b84da9682cb46cd1d45");
        public static BlueprintUnit CR15_ColoxusEmissary_RE_high = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("15a980d24ab94aa2b78a49fc9946a3f6");
        public static BlueprintUnit CR17_ColoxusToughCaster_1 = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("b06d25ead6ec62c4ab9c0821c7c32dd5");
        public static BlueprintUnit CR21_ColoxusCaster = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("5e0ec427990647f6bfe5345669315ed8");
        public static BlueprintUnit CR21_ColoxusCaster_RE_high = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("47c032c3ca2b42d5bedf3c36a4158dfe");
        public static BlueprintUnit FakeNosorez = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("67fe6232c9fcda14687438d082085eca");
        public static BlueprintUnit GateGuard_MediumToHigher = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("e38f403833a0c0c4c8ddcf624b333baf");
        public static BlueprintUnit TTD_ColoxusPatron = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("997595680918dfc44bbbfc89a12eb230");

        public static List<BlueprintUnit> DemonColoxusList = new List<BlueprintUnit>() {
            CR12_ColoxusStandard,
            CR12_ColoxusStandard_RE_high,
            CR13_ColoxusAdvanced,
            CR13_ColoxusAdvanced_RE_high,
            CR15_ColoxusEmissary,
            CR15_ColoxusEmissary_RE_high,
            CR17_ColoxusToughCaster_1,
            CR21_ColoxusCaster,
            CR21_ColoxusCaster_RE_high,
         };


        public static List<BlueprintUnit> StandardColoxusList = new List<BlueprintUnit>() {
            CR12_ColoxusStandard,
            CR12_ColoxusStandard_RE_high,
            CR13_ColoxusAdvanced,
            CR13_ColoxusAdvanced_RE_high,
         };

        public static List<BlueprintUnit> DiscordColoxusList = new List<BlueprintUnit>() {
            CR15_ColoxusEmissary,
            CR15_ColoxusEmissary_RE_high,
         };

        public static List<BlueprintUnit> CasterColoxusList = new List<BlueprintUnit>() {
            CR17_ColoxusToughCaster_1,
            CR21_ColoxusCaster,
            CR21_ColoxusCaster_RE_high,
         };

    }
}
