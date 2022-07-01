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

namespace HarderEnemies.UnitModifications.Retrievers {
    internal class UnitLists {

        public static BlueprintUnit CR11_RetrieverStandard = BlueprintTools.GetBlueprint<BlueprintUnit>("2f79139e8f8f3514d8f751975cca5a29");
        public static BlueprintUnit CR11_RetrieverStandard_RE = BlueprintTools.GetBlueprint<BlueprintUnit>("fde2aabdc2dd1e74ebf045cd34183b62");
        public static BlueprintUnit CR12_RetrieverAdvanced = BlueprintTools.GetBlueprint<BlueprintUnit>("d0f630b8893f35843b44f81e1d78e55c");
        public static BlueprintUnit CR12_RetrieverAdvanced_RE = BlueprintTools.GetBlueprint<BlueprintUnit>("81115449d26349d4ca1a0066b94efe46");
        public static BlueprintUnit CR13_RetrieverColdForged = BlueprintTools.GetBlueprint<BlueprintUnit>("427ae028e138789438a4688d579bed90");
        public static BlueprintUnit CR14_RetrieverElite = BlueprintTools.GetBlueprint<BlueprintUnit>("e40064497ffc3a749a6e5e6ac5f2666a");
        public static BlueprintUnit CR14_RetrieverElite_RE = BlueprintTools.GetBlueprint<BlueprintUnit>("76ff7605e93d426bb841a9f44dc527f5");
        public static BlueprintUnit CR20_TaintedRetriever = BlueprintTools.GetBlueprint<BlueprintUnit>("683e76fa7ae24d9899ab64c41d2878be");
        public static BlueprintUnit CR20_TaintedRetriever_RE = BlueprintTools.GetBlueprint<BlueprintUnit>("90c9f482ed41458da2c203ca604a6614");
        public static BlueprintUnit MidnightFane_RetrieverColdForged1 = BlueprintTools.GetBlueprint<BlueprintUnit>("5b6a2b0c6c8aa28438a4b65b3afb02c1");
        public static BlueprintUnit CR23_AreshkagalRetriever = BlueprintTools.GetBlueprint<BlueprintUnit>("1e4cafbd06b16cb4c9ba27538203a42d");
        public static BlueprintUnit CR25_Areshkagal_RetrieverBoss = BlueprintTools.GetBlueprint<BlueprintUnit>("9876513c09509954bb3330dc650fb9ae");
        public static BlueprintUnit CR26_Devastator = BlueprintTools.GetBlueprint<BlueprintUnit>("515c094f4e757794fa12ce0d6d7ee3d4");
        public static BlueprintUnit CR26_Devastator_RE = BlueprintTools.GetBlueprint<BlueprintUnit>("3f985fc7b4610d1428940a028dc6018f");
        public static BlueprintUnit CR29_Devastator = BlueprintTools.GetBlueprint<BlueprintUnit>("99c16c4360534129b45706841a7df3fe");
        public static BlueprintUnit CR29_Devastator_RE = BlueprintTools.GetBlueprint<BlueprintUnit>("94ebac8b10284a42a9fd6c72e2d6d720");
        public static BlueprintUnit LairDevastator = BlueprintTools.GetBlueprint<BlueprintUnit>("8b9a89943f3c1d144b8ce038587d8d79");

        public static List<BlueprintUnit> RetrieverList = new List<BlueprintUnit>() {
            CR11_RetrieverStandard,
            CR11_RetrieverStandard_RE,
            CR12_RetrieverAdvanced,
            CR12_RetrieverAdvanced_RE,
            CR13_RetrieverColdForged,
            CR14_RetrieverElite,
            CR14_RetrieverElite_RE,
            CR20_TaintedRetriever,
            CR20_TaintedRetriever_RE,
            MidnightFane_RetrieverColdForged1,
            CR23_AreshkagalRetriever,
            CR25_Areshkagal_RetrieverBoss,

        };
        public static List<BlueprintUnit> DevastatorList = new List<BlueprintUnit>() {
            CR26_Devastator,
            CR26_Devastator_RE,
            CR29_Devastator,
            CR29_Devastator_RE,
            LairDevastator
        };
    }
}
