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

namespace HarderEnemies.UnitModifications.Demons.Babau {
    internal class UnitLists {

        public static BlueprintUnit AlushinyrraBabauCommoner = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("ad755ea7dbdab9d4f8b8e8c779c525a7");
        public static BlueprintUnit BabauAlarmer = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("b363ef52eecd6634cbd890bbfe229525");
        public static BlueprintUnit BabauFreeHand_flowers = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("48cb285106132e34bb8509539a77df9c");
        public static BlueprintUnit BabauWithShortspear = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("b4b7b5090a3bbfc47a84896ba61fa258");
        public static BlueprintUnit Babau_Coronation = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("462a0e15125e4ba7919cdb35e059a57a");
        public static BlueprintUnit CR11M_MythicCrazyBabau = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("63bc20023e04e2e4da8b95a54c00a775");
        public static BlueprintUnit CR11_BabauElite = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("c413bac240706ca4ab6fea015bbe1615");
        public static BlueprintUnit CR11_BabauEliteFreeHand = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("7379bd0628b90864b8236429051eadc4");
        public static BlueprintUnit CR11_BabauEliteFreeHand_RE = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("b8ff1047dc6a4caf85e8bc1a04c7302b");
        public static BlueprintUnit CR11_BabauEliteFreeHand_RE_high = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("27bad3650c584c6ea22bdb77d988c3e6");
        public static BlueprintUnit CR11_BabauElite_RE = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("f5b1c91d9d9b4c7483aa3eb1e93a46ee");
        public static BlueprintUnit CR15_BabauSpecial = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("de516b18abf742339988b11d00ba1363");
        public static BlueprintUnit CR15_BabauSpecial_RE = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("e6d1d03eafcb43e4bd7bdb414068cf56");
        public static BlueprintUnit CR16_BabauElite_DLC1 = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("e3f4366b69cd47dc8a9c23518b670b4a");
        public static BlueprintUnit CR22M_BabauAdvanced = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("ac2695a574b443546847a449e5db0685");
        public static BlueprintUnit CR6_BabauForTest = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("10e1dd6f4ba7f5f4f8db9718751d2f36");
        public static BlueprintUnit CR6_BabauFreeHand = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("f8311e813bd754645b36d62e20cabe78");
        public static BlueprintUnit CR6_BabauFreeHand_RE = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("f8560b93209995c47aed3a7d7eea3762");
        public static BlueprintUnit CR6_BabauFreeHand_RE_high = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("b5bf8ba33a8c44b29dda6215d03c773e");
        public static BlueprintUnit CR6_BabauStandard = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("b80f9014b742ea04ba27f897177bafc4");
        public static BlueprintUnit CR6_BabauStandard_DrezenInThePast = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("6fde408c22bbe2e418ed026f22cbe478");
        public static BlueprintUnit CR6_BabauStandard_RE = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("cb4262d95f9b51d4bac710b25e1d7204");
        public static BlueprintUnit CR9_BabauAdvanced = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("57d3148da79837649bdc48e17067ccbb");
        public static BlueprintUnit CR9_BabauAdvancedFreeHand = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("4aeab3413822b834c9d242aa2d9493a0");
        public static BlueprintUnit DemonicHungerBabau = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("339ebf6a2f6be8747a3e2bab4026c37a");
        public static BlueprintUnit DrezenBabauBBD = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("5de744fbbacb83349965ec2d0dfb34c2");
        public static BlueprintUnit DrezenBabauGateGuard = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("72d826140d6fc514b97809ff5480530d");
        public static BlueprintUnit EmberQ2_BabauFreeHand = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("542022987aede074ab07363b16a6e809");
        public static BlueprintUnit ReplacementInnkeeper = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("5e69b5259e513de488656e82333dd0f3");
        public static BlueprintUnit TTD_BabauPatron = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("f3807cfda13f6c640bd903fa9d0bac6a");


        public static List<BlueprintUnit> DemonBabauList = new List<BlueprintUnit>() {
            BabauAlarmer,
            BabauWithShortspear,
            CR11M_MythicCrazyBabau,
            CR11_BabauElite,
            CR11_BabauEliteFreeHand,
            CR11_BabauEliteFreeHand_RE,
            CR11_BabauEliteFreeHand_RE_high,
            CR11_BabauElite_RE,
            CR15_BabauSpecial,
            CR15_BabauSpecial_RE,
            CR16_BabauElite_DLC1,
            CR22M_BabauAdvanced,
            CR6_BabauForTest,
            CR6_BabauFreeHand,
            CR6_BabauFreeHand_RE,
            CR6_BabauFreeHand_RE_high,
            CR6_BabauStandard,
            CR6_BabauStandard_RE,
            CR9_BabauAdvanced,
            CR9_BabauAdvancedFreeHand,
            DrezenBabauGateGuard,
            EmberQ2_BabauFreeHand,
        };
    }
}
