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

namespace HarderEnemies.UnitModifications.Demons.Cambion {
    internal class UnitLists {

        public static BlueprintUnit ArenaWizard_Curse = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("c0fe3438b11d09841a8717ab55eebe15");
        public static BlueprintUnit CambionFlameShaman = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("fee9736c2d534066a03f17a7793e7bec");
        public static BlueprintUnit CambionMinibossKineticist = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("6c06f8b57f2c4924e9d4323acc007d9e");
        public static BlueprintUnit CambionSlaverLeader = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("7c50cad36582b244084704b48f994fa2");
        public static BlueprintUnit CambionWithClub = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("d8a1ab3537961c841b795bcb288a385b");
        public static BlueprintUnit CR14_CambionBard_Ranged = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("41115867802ace94cb8767132cb6ea90");
        public static BlueprintUnit CR15_CambionAlchemist_Ranged = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("1d4ad8176fda60c4d80a6ee6a41a73c1");
        public static BlueprintUnit CR15_CambionAlchemist_Ranged_RE = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("a5567be7bb729ab41a500d81b6f6d9ca");
        public static BlueprintUnit CR15_CambionCleric_Caster = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("4932555b9d789964eb41183412c8b339");
        public static BlueprintUnit CR15_CambionCleric_Caster_RE = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("26b9060ca9b3f2342a3897bff8657b16");
        public static BlueprintUnit CR15_Cybrog_Cambion_Ranged = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("4392e6d57466ea24787150c8de01e50b");
        public static BlueprintUnit CR17_CambionToughRanged = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("c06ad11810339d740823838f3ffe0751");
        public static BlueprintUnit CR17_CambionToughRanged_RE = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("f1d43452e01e484e9b16b4b585c8f954");
        public static BlueprintUnit CR18_CambionToughCaster = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("84c02e613e97f994084249a7cac34188");
        public static BlueprintUnit CR18_CambionToughCaster_RE = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("e9d464311de84eda98ac570a5d3b3641");
        public static BlueprintUnit CR19_CambionBard_Melee = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("d97912a0735b3d44abffaee610225076");
        public static BlueprintUnit CR2_CambionStandard_Melee = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("371a43c485691124abf63ac86c67c3f5");
        public static BlueprintUnit CR2_CambionStandard_Ranged = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("9125fbea5b02f4744a169091dec729b2");
        public static BlueprintUnit CR3_CambionAlchemist_Ranged = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("19ca035a66477954f97f91eaef89d0b0");
        public static BlueprintUnit CR3_CambionBard_Ranged = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("ee0eb8e208dcec14d8d213fff7060ee6");
        public static BlueprintUnit CR3_CambionCleric_Caster = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("7210024421ec733479e05841856aa341");
        public static BlueprintUnit CR3_CambionFighter_Melee = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("f257cf352c9a6244d9f344779704ebcd");
        public static BlueprintUnit CR3_CambionRanger_Ranged = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("db6a1ce772c51064ea5f35ec83e44f2f");
        public static BlueprintUnit CR3_CambionRogue_Melee = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("8868374092c5e3d4c9c30711f99f5951");
        public static BlueprintUnit CR3_CambionWizard_Caster = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("b410ed79d33b1e342972ed8539f4c5c7");
        public static BlueprintUnit DaeranQ1_CambionWizard = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("b533e0ba3bc985340a713e65a64b31c4");
        public static BlueprintUnit DaeranQ1_CambionWizard_normal = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("ecf225e208fa6264488d4f0f49a09bbc");
        public static BlueprintUnit DrugVictimLeader = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("914e078ed70d47646aebe55061601798");
        public static BlueprintUnit FleshmarketGuard_Cambion17 = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("117211542b3603349a3926714e5b7acb");
        public static BlueprintUnit Fleshmarket_CambionGuardCaptain_WithLoot = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("28da512049ec4b138d04ef9d94d58764");
        public static BlueprintUnit GateGuard_HigherToMedium = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("fe4e653a606568f448c9e15a52579ab5");
        public static BlueprintUnit GateGuard_MediumToLower = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("558dc07952333e345b96ee1b65f01978");
        public static BlueprintUnit KrebusSlaveTraderHumanForm = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("67013765d49b47748ba0f4abfdaab1e0");
        public static BlueprintUnit Lair_CambionAlchemist = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("30b52c870e9c2884c9d5f2f433ebaecf");
        public static BlueprintUnit Mutasafen = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("3e42b70cc8c924845967ea6592247eff");
        public static BlueprintUnit MutasafenAssistent = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("cdece5535c236994f8490d9d3d8417ed");
        public static BlueprintUnit MutasafenFourth_NoLoot = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("fce709b70edfe3c4b98cb6e842668577");
        public static BlueprintUnit MutasafenSecond = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("418a0a5e5884d344a844f9681003b93f");
        public static BlueprintUnit MutasafenThird = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("2035e7e9ad02ef74685acaae890137dd");
        public static BlueprintUnit Mutasafen_MidnightFaneInThePast = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("a17a7fbf4dc5ce846b4e325587a29a09");
        public static BlueprintUnit Nexus_CambionWithLoot_ForAssault = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("f3a44470aebf4a0a8f8894d13e60e80d");
        public static BlueprintUnit Nexus_CambionWithLoot_ForAssault_2 = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("fb5de51f70aa48baae028cbd24c264a7");
        public static BlueprintUnit NonameSlaveTrader = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("4b22429c9ca86864e94368380e4e4885");
        public static BlueprintUnit RvaniySlaveTrader = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("76b021bd47a2edc42b001ad6ef5c54bc");
        public static BlueprintUnit SailorRangedTough = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("0390cb1501e64c15bef19f83a6bbdc95");
        public static BlueprintUnit ToughMinaghoCambion = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("a974bc51eaf3ae04287c174c5404d2b4");
        public static BlueprintUnit Vellexia_CambionToughMelee_WithLoot = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("40e5f14437d74763a3c51ef7988c6bc5");


        public static List<BlueprintUnit> DemonCambionList = new List<BlueprintUnit>() {
            CambionFlameShaman,
            CambionSlaverLeader,
            CambionWithClub,
            CR14_CambionBard_Ranged,
            CR15_CambionAlchemist_Ranged,
            CR15_CambionAlchemist_Ranged_RE,
            CR15_CambionCleric_Caster,
            CR15_CambionCleric_Caster_RE,
            CR15_Cybrog_Cambion_Ranged,
            CR17_CambionToughRanged,
            CR17_CambionToughRanged_RE,
            CR19_CambionBard_Melee,
            CR2_CambionStandard_Melee,
            CR2_CambionStandard_Ranged,
            CR3_CambionAlchemist_Ranged,
            CR3_CambionBard_Ranged,
            CR3_CambionCleric_Caster,
            CR3_CambionFighter_Melee,
            CR3_CambionRanger_Ranged,
            CR3_CambionRogue_Melee,
            Lair_CambionAlchemist,
            CR3_CambionWizard_Caster,
            DaeranQ1_CambionWizard,
            DaeranQ1_CambionWizard_normal,
            CR18_CambionToughCaster,
            CR18_CambionToughCaster_RE,
            Nexus_CambionWithLoot_ForAssault,
            Nexus_CambionWithLoot_ForAssault_2,
            ToughMinaghoCambion,
            Vellexia_CambionToughMelee_WithLoot,
        };

        public static List<BlueprintUnit> DemonRangedCambionList = new List<BlueprintUnit>() {
            CR15_Cybrog_Cambion_Ranged,
            CR17_CambionToughRanged,
            CR17_CambionToughRanged_RE,
            CR3_CambionRanger_Ranged,
        };
    }
}
