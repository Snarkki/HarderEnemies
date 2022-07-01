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

namespace HarderEnemies.UnitModifications.Demons.Marileth {
   internal class UnitLists {

        public static BlueprintUnit AlushinyrraMarilithCommoner = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("870e4888f4fa4f94ca25035d60c41afe");
        public static BlueprintUnit AponaviciusVision = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("280e0464d529949448dcccbd0d3a7e34");
        public static BlueprintUnit Aponavicius_IvoryLabyrinth26 = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("ddb9b76a660d58a428085a6661c34733");
        public static BlueprintUnit Aponavicius_IvoryLabyrinth26_Scimitar = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("911f53ca85b7b444dac6ce1f893d3821");
        public static BlueprintUnit CR17_AreshkagalMarilith = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("713a7825363ebc5419d82609714e454c");
        public static BlueprintUnit CR17_MarilithStandard = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("4addf73a9a68c694f9919137f800be50");
        public static BlueprintUnit CR17_MarilithStandard_RE = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("6a6ff0070709f694b823deb9e329f58b");
        public static BlueprintUnit CR18_MarilithAdvanced = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("e350e84a381e17748aa663bd033f8ab1");
        public static BlueprintUnit CR18_MarilithAdvanced_RE = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("a8d84135c9abab146a617e80fb7d6029");
        public static BlueprintUnit CR19_MarilithAdvanced = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("75a989b2726a023429cb4ad067e2a80b");
        public static BlueprintUnit CR21_MarilithMythic4_Slayer = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("a4738fdde19441b45873ca290e7bf14b");
        public static BlueprintUnit CR21_MarilithMythic4_Slayer_RE = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("691fe8386ad009246b4d92cb9c63a8e8");
        public static BlueprintUnit CR23_MythicMarilithRogue = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("60707e25dd9a013418febbfa6dd56670");
        public static BlueprintUnit CR24_Areshkagal_MarilithBoss = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("bda15fb31ee8cba45b4d838344cb1e58");
        public static BlueprintUnit CR26_MythicMarilithSlayer = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("156621d3502bffa4a93820afecca82b7");
        public static BlueprintUnit DontLikeGuestsLeader = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("519f773f79ea48447ac028a37c388a12");
        public static BlueprintUnit Ember_Q3_MarilithAdvanced = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("c16c0bc7554b41c4ea1ca34d0d4f71ea");
        public static BlueprintUnit NoRespectLeader = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("cd85d333b8920ac448b400f2515dc8f5");
        public static BlueprintUnit RamisaSlaveTrader = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("6bc4c816006d50a4caa8f7d01b41da28");


        public static List<BlueprintUnit> DemonMarilithList = new List<BlueprintUnit>() {
            Aponavicius_IvoryLabyrinth26,
            Aponavicius_IvoryLabyrinth26_Scimitar,
            CR17_AreshkagalMarilith,
            CR17_MarilithStandard,
            CR17_MarilithStandard_RE,
            CR18_MarilithAdvanced,
            CR18_MarilithAdvanced_RE,
            CR19_MarilithAdvanced,
            CR21_MarilithMythic4_Slayer,
            CR21_MarilithMythic4_Slayer_RE,
            CR23_MythicMarilithRogue,
            CR26_MythicMarilithSlayer,
            DontLikeGuestsLeader,
            Ember_Q3_MarilithAdvanced,
            NoRespectLeader,
        };
    }
}
