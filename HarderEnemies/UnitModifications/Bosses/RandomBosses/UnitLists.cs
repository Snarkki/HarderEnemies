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

namespace HarderEnemies.UnitModifications.Bosses.RandomBosses {
    internal class UnitLists {

        public static BlueprintUnit AlushinyrraCasterMiniboss = BlueprintTools.GetBlueprint<BlueprintUnit>("28966687fe3ceec43857d87a08303854");
        public static BlueprintUnit AlushinyrraCasterMiniboss1 = BlueprintTools.GetBlueprint<BlueprintUnit>("4595304a7627fcf40895746e197fde15");
        public static BlueprintUnit AlushinyrraCasterMiniboss2 = BlueprintTools.GetBlueprint<BlueprintUnit>("9dfed67e29a1cdc45900bdde24d66a4e");
        public static BlueprintUnit AlushinyrraCasterMiniboss3 = BlueprintTools.GetBlueprint<BlueprintUnit>("91cd42858e372f845ae2c82554412101");
        public static BlueprintUnit AlushynirraDemodandMiniboss = BlueprintTools.GetBlueprint<BlueprintUnit>("e67d5e358a59f7c4b8803ed6c54c36c0");
        public static BlueprintUnit AreshkagalBoss_ShadowCopy = BlueprintTools.GetBlueprint<BlueprintUnit>("53292043b0a34835a9c0cf997a35de9c");
        public static BlueprintUnit AreshkagalBoss_ShadowCopy_ArenaFight = BlueprintTools.GetBlueprint<BlueprintUnit>("0147f4d2006c457da499947b3065a8f9");
        public static BlueprintUnit ArueshalaeRedoubt_DeathsnatcherMiniboss = BlueprintTools.GetBlueprint<BlueprintUnit>("f9fe6d8483667594bafbeb22a4279c8a");
        public static BlueprintUnit AshGiantLairMiniboss = BlueprintTools.GetBlueprint<BlueprintUnit>("b0a5e6f7f3436614685b294bbc97ee4b");
        public static BlueprintUnit BattleBliss_MephitFireBoss = BlueprintTools.GetBlueprint<BlueprintUnit>("e64b423f6572ab84d9293fd0228be387");
        public static BlueprintUnit BlightedTreantBoss = BlueprintTools.GetBlueprint<BlueprintUnit>("1f71b4ecb229d2d4aa654c5efee8e576");
        public static BlueprintUnit BodakLairMiniboss = BlueprintTools.GetBlueprint<BlueprintUnit>("e8bc9289d26cf804090184442cdf797d");
        public static BlueprintUnit CambionMinibossKineticist = BlueprintTools.GetBlueprint<BlueprintUnit>("6c06f8b57f2c4924e9d4323acc007d9e");
        public static BlueprintUnit ColyphyrSalamanderMiniboss = BlueprintTools.GetBlueprint<BlueprintUnit>("0b372fdd38a2bd24f8752daa6f2970bd");
        public static BlueprintUnit CR20_Areshkagal_SpellscribedMummyMiniBoss = BlueprintTools.GetBlueprint<BlueprintUnit>("99ceedc7f2ed80a41b4f2c46eac9fb78");
        public static BlueprintUnit CR24_Areshkagal_GolemMithralMiniBoss = BlueprintTools.GetBlueprint<BlueprintUnit>("42cdfa00fddc6f445a9ce4d20a621b42");
        public static BlueprintUnit CR24_Areshkagal_MarilithBoss = BlueprintTools.GetBlueprint<BlueprintUnit>("bda15fb31ee8cba45b4d838344cb1e58");
        public static BlueprintUnit CR29M_VrolikaiInquisitor_Miniboss = BlueprintTools.GetBlueprint<BlueprintUnit>("c35017033bd4491fb3fa880d49211c0b");
        public static BlueprintUnit CR30_AreshkagalBoss = BlueprintTools.GetBlueprint<BlueprintUnit>("7a1b0862dd2443b49adaba36b194e5de");
        public static BlueprintUnit CR30_VavakiaMythic_Boss = BlueprintTools.GetBlueprint<BlueprintUnit>("09a02fa57e1844a4b6df546954bd1a75");
        public static BlueprintUnit CR5_WaterElementalLarge_LabyrinthBoss = BlueprintTools.GetBlueprint<BlueprintUnit>("4518955732be42ecbe41221001163c2a");
        public static BlueprintUnit CR5_ZombieBossFighterLevel2 = BlueprintTools.GetBlueprint<BlueprintUnit>("87ed66055c5c44d8a7ef82411119253b");
        public static BlueprintUnit DemodandTarryLairMiniboss = BlueprintTools.GetBlueprint<BlueprintUnit>("05c24788a0aca3844892cbe95d162fac");
        public static BlueprintUnit DLC1_BlightedTreantBoss = BlueprintTools.GetBlueprint<BlueprintUnit>("3d52f3e795484e9fb76f53777e6eb05e");
        public static BlueprintUnit DLC1_InevitableKolyarutMiniboss = BlueprintTools.GetBlueprint<BlueprintUnit>("3b4b1b05783044f0b75f6f3afd9e6d7f");
        public static BlueprintUnit EcorcheLairBoss = BlueprintTools.GetBlueprint<BlueprintUnit>("0ac1ef59854f2c641bded5e36c1e79ac");
        public static BlueprintUnit Eustoyriax_Miniboss = BlueprintTools.GetBlueprint<BlueprintUnit>("2c91c5f6c86b7e949b102aa0cdc01298");
        public static BlueprintUnit FakeHellknightGlabrezuBoss = BlueprintTools.GetBlueprint<BlueprintUnit>("9056368789e3bca49a0ab6c36b5aa8df");
        public static BlueprintUnit GhostOracleBoss = BlueprintTools.GetBlueprint<BlueprintUnit>("5a18098c2513d6443b84c12fdbcf0e50");
        public static BlueprintUnit HellknightCamp_GreaterShadowDemonMiniboss1 = BlueprintTools.GetBlueprint<BlueprintUnit>("ecc06d7bbf12ef14790b22b9d7a3b192");
        public static BlueprintUnit HellknightCamp_GreaterShadowDemonMiniboss2 = BlueprintTools.GetBlueprint<BlueprintUnit>("52be8901d87296d4c920d2aea71f8776");
        public static BlueprintUnit IncubusBandLair_IncubusBoss = BlueprintTools.GetBlueprint<BlueprintUnit>("cc2441ffc5564d746b3e01fc38349d3a");
        public static BlueprintUnit IvoryLabyrinthMinibossDemodand20 = BlueprintTools.GetBlueprint<BlueprintUnit>("6416a982a6745814f86e5e48544e097c");
        public static BlueprintUnit Janeamine_SuccubusMiniboss = BlueprintTools.GetBlueprint<BlueprintUnit>("92f30c0a2f48fc14884539b10acbdc90");
        public static BlueprintUnit Lair_SuccubusBoss = BlueprintTools.GetBlueprint<BlueprintUnit>("26560e7831f208c41ae9d109636d4d69");
        public static BlueprintUnit LostChapel_GargoyleMiniboss = BlueprintTools.GetBlueprint<BlueprintUnit>("e779beab8b72a444f864c9ca1b01b855");
        public static BlueprintUnit Minagho_DrezenCitadel_Boss = BlueprintTools.GetBlueprint<BlueprintUnit>("b8d11ced33308874790188d910b71a2f");
        public static BlueprintUnit Miniboss_AxiomiteCaster_DLC1 = BlueprintTools.GetBlueprint<BlueprintUnit>("6a883cdabf8044bdb4c20ad4e3f0a0de");
        public static BlueprintUnit Miniboss_AxiomiteMelee_DLC1 = BlueprintTools.GetBlueprint<BlueprintUnit>("5a41cb8867414039ba463a2f4c9e3549");
        public static BlueprintUnit MinotaurGhost_Boss = BlueprintTools.GetBlueprint<BlueprintUnit>("1b5fc80bcedff624b805b950a2244165");
        public static BlueprintUnit MinotaurGhost_BossNoExp = BlueprintTools.GetBlueprint<BlueprintUnit>("c0dc27a43b555014286d89493e12bc14");
        public static BlueprintUnit MutasafenLair_CarnivorousCrystalMiniboss = BlueprintTools.GetBlueprint<BlueprintUnit>("ee855a2e29b8cf54eb254652a09162eb");
        public static BlueprintUnit MythicNightcrawlerBoss28 = BlueprintTools.GetBlueprint<BlueprintUnit>("ba8eb63fc432bda4ebfae95f820de6f2");
        public static BlueprintUnit Regill_HellknightsVsGargoyles_GargoyleMiniboss = BlueprintTools.GetBlueprint<BlueprintUnit>("25fab688af9122a4fa4767657299b5e4");
        public static BlueprintUnit SarcorianWedding_WightBoss = BlueprintTools.GetBlueprint<BlueprintUnit>("e6ace72105be4a73bd262be313c21ffb");
        public static BlueprintUnit SarkorianWedding_FallenBoss = BlueprintTools.GetBlueprint<BlueprintUnit>("d2e3f09a6b7a4e50b01f5e9921f2d7db");
        public static BlueprintUnit Sosiel_Q2_PurpleWormBoss = BlueprintTools.GetBlueprint<BlueprintUnit>("6f01354cb3a0c8f459c35668cf888643");
        public static BlueprintUnit SW_GlabrezuBoss = BlueprintTools.GetBlueprint<BlueprintUnit>("2433f902e6d443e2a6010de9e4227e9e");
        public static BlueprintUnit SW_GlabrezuBoss_phase2 = BlueprintTools.GetBlueprint<BlueprintUnit>("6249608286e547f98c548cf5747ac646");
        public static BlueprintUnit VeryOptionalGlabrezu_Miniboss = BlueprintTools.GetBlueprint<BlueprintUnit>("7a5501ce11c3a2f4d8a99e2c71476eee");
        public static BlueprintUnit Mutasafen = BlueprintTools.GetBlueprint<BlueprintUnit>("3e42b70cc8c924845967ea6592247eff");
        public static BlueprintUnit MutasafenAssistent = BlueprintTools.GetBlueprint<BlueprintUnit>("cdece5535c236994f8490d9d3d8417ed");
        public static BlueprintUnit MutasafenFourth_NoLoot = BlueprintTools.GetBlueprint<BlueprintUnit>("fce709b70edfe3c4b98cb6e842668577");
        public static BlueprintUnit MutasafenLair_MythicGlabrezu = BlueprintTools.GetBlueprint<BlueprintUnit>("78ac2a4a26b14157a384e4176965a953");
        public static BlueprintUnit MutasafenSecond = BlueprintTools.GetBlueprint<BlueprintUnit>("418a0a5e5884d344a844f9681003b93f");
        public static BlueprintUnit MutasafenThird = BlueprintTools.GetBlueprint<BlueprintUnit>("2035e7e9ad02ef74685acaae890137dd");
        public static BlueprintUnit Mutasafen_MidnightFaneInThePast = BlueprintTools.GetBlueprint<BlueprintUnit>("a17a7fbf4dc5ce846b4e325587a29a09");
        public static BlueprintUnit Xuneki = BlueprintTools.GetBlueprint<BlueprintUnit>("324272e2671c25446b7c3e49b78c29ec");
        public static BlueprintUnit Maugla = BlueprintTools.GetBlueprint<BlueprintUnit>("9b0bb09c56e8e5d4c86809a5ce35d9cb");
        public static BlueprintUnit MidnightFane_GlabrezuElite = BlueprintTools.GetBlueprint<BlueprintUnit>("75fa4aaa407c3d64fbd8cfd4c221f415");
        public static BlueprintUnit MidnightFane_GlabrezuRitualists = BlueprintTools.GetBlueprint<BlueprintUnit>("b8d0898ac46e4851b9613b80aea0ef04");
        public static BlueprintUnit XanthirPhase1 = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("082edd80ca45af84ab602fbe06e53f55");


        public static List<BlueprintUnit> MutafasenList = new List<BlueprintUnit>() {
                Mutasafen,
                MutasafenAssistent,
                MutasafenSecond,
                MutasafenThird,
                MutasafenFourth_NoLoot,
        };
    }
}
