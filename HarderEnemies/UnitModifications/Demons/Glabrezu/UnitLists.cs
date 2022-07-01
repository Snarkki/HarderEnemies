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

namespace HarderEnemies.UnitModifications.Demons.Glabrezu {
    internal class UnitLists {

        public static BlueprintUnit AlushinyrraGlabrezuCommoner = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("db1f55c83e6db6540bf94af7ce9eea61");
        public static BlueprintUnit Boulder = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("7ae258edc547f554284fb905cdff4786");
        public static BlueprintUnit CR13_GlabrezuStandard = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("d13545bd34bf2c3438f909417b9c5314");
        public static BlueprintUnit CR13_GlabrezuStandard_RE = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("323197d05aa21db4cb1c9460359cce76");
        public static BlueprintUnit CR13_GlabrezuStandard_RE_high = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("39412daa70d64ca386efe2c27ddb9ccf");
        public static BlueprintUnit CR14_GlabrezuAdvanced = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("d1822e208ff314846a5cd1443a9db45b");
        public static BlueprintUnit CR14_GlabrezuAdvanced_RE = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("7515c741cdc5abd4781ad7732594f65d");
        public static BlueprintUnit CR14_GlabrezuAdvanced_RE_high = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("d549c87e84a0412f92347737cc261878");
        public static BlueprintUnit CR14_Prebuff_GlabrezuStandard = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("70dbe81f5abca6b458931e697a6e0939");
        public static BlueprintUnit CR15_Prebuff_GlabrezuAdvanced = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("a78dbdbfa1703404baf6616e67ebc3ea");
        public static BlueprintUnit CR16_GlabrezuElite = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("4b7ba5cb98e3ace4798ffb6d836a5938");
        public static BlueprintUnit CR16_GlabrezuElite_RE = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("fe1a76195897ce24a8d40045e9c32b61");
        public static BlueprintUnit CR16_GlabrezuElite_RE_high = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("c21a1bed5eb748f796b81bf7c708763d");
        public static BlueprintUnit CR18M_MythicCrazyGlabrezu = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("04867a7006ab04140a4dd45d79d2ce1b");
        public static BlueprintUnit CR18M_MythicCrazyGlabrezu_RE = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("be2d4713d21f18847ad064d04a63f11e");
        public static BlueprintUnit CR19_GlabrezuDrezenOptional = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("cebf8dafc5feae5479c02be5b5d791eb");
        public static BlueprintUnit CR22M_MythicGlabrezu = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("947c90850e25a094fbdebdcb80ae6434");
        public static BlueprintUnit CR22M_MythicGlabrezu_RE = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("ba8ef01180fc2654380bee2766f9e505");
        public static BlueprintUnit DemonGladiator02 = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("80effc529d98a274c8a972a03878bf20");
        public static BlueprintUnit Drezen1_Tavern_Glabrezu = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("139ec0d2249679a4bb0fe30737d0b05f");
        public static BlueprintUnit FakeHellknightGlabrezuBoss = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("9056368789e3bca49a0ab6c36b5aa8df");
        public static BlueprintUnit MidnightFane_GlabrezuElite = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("75fa4aaa407c3d64fbd8cfd4c221f415");
        public static BlueprintUnit MidnightFane_GlabrezuRitualists = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("b8d0898ac46e4851b9613b80aea0ef04");
        public static BlueprintUnit MutasafenLair_MythicGlabrezu = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("78ac2a4a26b14157a384e4176965a953");
        public static BlueprintUnit SW_GlabrezuBoss = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("2433f902e6d443e2a6010de9e4227e9e");
        public static BlueprintUnit SW_GlabrezuBoss_phase2 = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("6249608286e547f98c548cf5747ac646");
        public static BlueprintUnit TTD_GlabrezuPatron = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("13b16f9b391cfff488539061d6925043");
        public static BlueprintUnit TutorialTestISpellResistance = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("03c31b70bd5ebfb478efb36460803f6e");
        public static BlueprintUnit VeryOptionalGlabrezu_Miniboss = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("7a5501ce11c3a2f4d8a99e2c71476eee");
        public static BlueprintUnit Voetiel = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("d75ee7e088ea2d64b8b602e2e59ad6a5");
        public static BlueprintUnit WintersunGlabrezu = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("9bf9e607b8851034083f519a0ea75366");
        public static BlueprintUnit Ygefeles = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("aedf061b223b6d54e8ffae6175515b29");


        public static List<BlueprintUnit> DemonGlabrezuList = new List<BlueprintUnit>() {
            CR13_GlabrezuStandard,
            CR13_GlabrezuStandard_RE,
            CR13_GlabrezuStandard_RE_high,
            CR14_GlabrezuAdvanced,
            CR14_GlabrezuAdvanced_RE,
            CR14_GlabrezuAdvanced_RE_high,
            CR14_Prebuff_GlabrezuStandard,
            CR15_Prebuff_GlabrezuAdvanced,
            CR16_GlabrezuElite,
            CR16_GlabrezuElite_RE,
            CR16_GlabrezuElite_RE_high,
            CR18M_MythicCrazyGlabrezu,
            CR18M_MythicCrazyGlabrezu_RE,
            CR19_GlabrezuDrezenOptional,
            CR22M_MythicGlabrezu,
            CR22M_MythicGlabrezu_RE,
            Drezen1_Tavern_Glabrezu,
            Voetiel,
            WintersunGlabrezu,
        };
    }
}
