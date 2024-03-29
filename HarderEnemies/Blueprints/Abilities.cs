﻿
using Kingmaker.Blueprints;
using Kingmaker.Blueprints.Classes;
using Kingmaker.UnitLogic.Abilities.Blueprints;
using Kingmaker.UnitLogic.ActivatableAbilities;
using Kingmaker.UnitLogic.Buffs.Blueprints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TabletopTweaks.Core.Utilities;

namespace HarderEnemies.Blueprints {
    public class Abilities {

        public static BlueprintAbility DispelGreater = BlueprintTools.GetBlueprint<BlueprintAbility>("f0f761b808dc4b149b08eaf44b99f633");
        public static BlueprintAbility Blasphemy = BlueprintTools.GetBlueprint<BlueprintAbility>("bd10c534a09f44f4ea632c8b8ae97145");
        public static BlueprintAbility UnholyBlight = BlueprintTools.GetBlueprint<BlueprintAbility>("a02cf51787df937489ef5d4cf5970335");
        public static BlueprintAbility SummonMonsterVII = BlueprintTools.GetBlueprint<BlueprintAbility>("ab167fd8203c1314bac6568932f1752f");
        public static BlueprintAbility SummonMonsterVIId3 = BlueprintTools.GetBlueprint<BlueprintAbility>("43f763d347eb2744caed9c656ba89531");
        public static BlueprintAbility HoldPersonMass = BlueprintTools.GetBlueprint<BlueprintAbility>("defbbeaef79eda64abc645036228a31b");
        public static BlueprintAbility HoldPerson = BlueprintTools.GetBlueprint<BlueprintAbility>("c7104f7526c4c524f91474614054547e");
        public static BlueprintAbility StinkingCloud = BlueprintTools.GetBlueprint<BlueprintAbility>("68a9e6d7256f1354289a39003a46d826");
        public static BlueprintAbility Fear = BlueprintTools.GetBlueprint<BlueprintAbility>("d2aeac47450c76347aebbc02e4f463e0");
        public static BlueprintAbility Stormbolts = BlueprintTools.GetBlueprint<BlueprintAbility>("7cfbefe0931257344b2cb7ddc4cdff6f");
        public static BlueprintAbility Grease = BlueprintTools.GetBlueprint<BlueprintAbility>("95851f6e85fe87d4190675db0419d112");
        public static BlueprintAbility CreatePit = BlueprintTools.GetBlueprint<BlueprintAbility>("29ccc62632178d344ad0be0865fd3113");
        public static BlueprintAbility AnimateDead = BlueprintTools.GetBlueprint<BlueprintAbility>("4b76d32feb089ad4499c3a1ce8e1ac27");
        public static BlueprintAbility RiftOfRuin = BlueprintTools.GetBlueprint<BlueprintAbility>("dd3dacafcf40a0145a5824c838e2698d");
        public static BlueprintAbility AcidPit = BlueprintTools.GetBlueprint<BlueprintAbility>("1407fb5054d087d47a4c40134c809f12");
        public static BlueprintAbility FlameStrike = BlueprintTools.GetBlueprint<BlueprintAbility>("f9910c76efc34af41b6e43d5d8752f0f");
        public static BlueprintAbility MirrorImage = BlueprintTools.GetBlueprint<BlueprintAbility>("3e4ab69ada402d145a5e0ad3ad4b8564");
        public static BlueprintAbility LegendaryProportions = BlueprintTools.GetBlueprint<BlueprintAbility>("da1b292d91ba37948893cdbe9ea89e28");
        public static BlueprintAbility ChaosHammer = BlueprintTools.GetBlueprint<BlueprintAbility>("c42ac3feb96d1e54e9bc77c84082f05f");
        public static BlueprintAbility BullRushAction = BlueprintTools.GetBlueprint<BlueprintAbility>("7ab6f70c996fe9b4597b8332f0a3af5f");
        public static BlueprintAbility Command = BlueprintTools.GetBlueprint<BlueprintAbility>("feb70aab86cc17f4bb64432c83737ac2");
        public static BlueprintAbility CommandFall = BlueprintTools.GetBlueprint<BlueprintAbility>("9e87cb2778afdc24e9ceb523aca512a8");
        public static BlueprintAbility Boneshaker = BlueprintTools.GetBlueprint<BlueprintAbility>("b7731c2b4fa1c9844a092329177be4c3");
        public static BlueprintAbility SoundBurst = BlueprintTools.GetBlueprint<BlueprintAbility>("c3893092a333b93499fd0a21845aa265");
        public static BlueprintAbility Blindess = BlueprintTools.GetBlueprint<BlueprintAbility>("46fd02ad56c35224c9c91c88cd457791");
        public static BlueprintAbility Prayer = BlueprintTools.GetBlueprint<BlueprintAbility>("faabd2cc67efa4646ac58c7bb3e40fcc");
        public static BlueprintAbility CauseFear = BlueprintTools.GetBlueprint<BlueprintAbility>("bd81a3931aa285a4f9844585b5d97e51");
        public static BlueprintAbility DivinePower = BlueprintTools.GetBlueprint<BlueprintAbility>("ef16771cb05d1344989519e87f25b3c5");
        public static BlueprintAbility CommandGreater = BlueprintTools.GetBlueprint<BlueprintAbility>("cb15cc8d7a5480648855a23b3ba3f93d");
        public static BlueprintAbility ColdIceStrike = BlueprintTools.GetBlueprint<BlueprintAbility>("5ef85d426783a5347b420546f91a677b");
        public static BlueprintAbility MagicMissile = BlueprintTools.GetBlueprint<BlueprintAbility>("4ac47ddb9fa1eaf43a1b6809980cfbd2");
        public static BlueprintAbility ColorSpray = BlueprintTools.GetBlueprint<BlueprintAbility>("91da41b9793a4624797921f221db653c");
        public static BlueprintAbility Scare = BlueprintTools.GetBlueprint<BlueprintAbility>("08cb5f4c3b2695e44971bf5c45205df0");
        public static BlueprintAbility HideousLaughter = BlueprintTools.GetBlueprint<BlueprintAbility>("fd4d9fd7f87575d47aafe2a64a6e2d8d");
        public static BlueprintAbility Fireball = BlueprintTools.GetBlueprint<BlueprintAbility>("2d81362af43aeac4387a3d4fced489c3");
        public static BlueprintAbility Haste = BlueprintTools.GetBlueprint<BlueprintAbility>("486eaff58293f6441a5c2759c4872f98");
        public static BlueprintAbility DeepSlumber = BlueprintTools.GetBlueprint<BlueprintAbility>("7658b74f626c56a49939d9c20580885e");
        public static BlueprintAbility IcyPrison = BlueprintTools.GetBlueprint<BlueprintAbility>("65e8d23aef5e7784dbeb27b1fca40931");
        public static BlueprintAbility PhantasmalWeb = BlueprintTools.GetBlueprint<BlueprintAbility>("12fb4a4c22549c74d949e2916a2f0b6a");
        public static BlueprintAbility SummonMonsterVBase = BlueprintTools.GetBlueprint<BlueprintAbility>("630c8b85d9f07a64f917d79cb5905741");
        public static BlueprintAbility SummonMonsterVd3 = BlueprintTools.GetBlueprint<BlueprintAbility>("715f208d545be2f4aa2d3693e6347a5a");
        public static BlueprintAbility HungryPit = BlueprintTools.GetBlueprint<BlueprintAbility>("f63f4d1806b78604a952b3958892ce1c");
        public static BlueprintAbility DragonsBreath = BlueprintTools.GetBlueprint<BlueprintAbility>("5e826bcdfde7f82468776b55315b2403");
        public static BlueprintAbility DragonsBreathGreen = BlueprintTools.GetBlueprint<BlueprintAbility>("48c4433acbcecae499d1d38a56f72f36");
        public static BlueprintAbility AcidArrow = BlueprintTools.GetBlueprint<BlueprintAbility>("9a46dfd390f943647ab4395fc997936d");
        public static BlueprintAbility OverrunAbility = BlueprintTools.GetBlueprint<BlueprintAbility>("1a3b471ecea51f7439a946b23577fd70");
        public static BlueprintAbility OverwhelmingGrief = BlueprintTools.GetBlueprint<BlueprintAbility>("dd2918e4a77c50044acba1ac93494c36");
        public static BlueprintAbility RainbowPattern = BlueprintTools.GetBlueprint<BlueprintAbility>("4b8265132f9c8174f87ce7fa6d0fe47b");
        public static BlueprintAbility PrismaticSpray = BlueprintTools.GetBlueprint<BlueprintAbility>("b22fd434bdb60fb4ba1068206402c4cf");
        public static BlueprintAbility AcidicSpray = BlueprintTools.GetBlueprint<BlueprintAbility>("c543eef6d725b184ea8669dd09b3894c");
        public static BlueprintAbility CausticEruption = BlueprintTools.GetBlueprint<BlueprintAbility>("8c29e953190cc67429dc9c701b16b7c2");
        public static BlueprintAbility AcidFog = BlueprintTools.GetBlueprint<BlueprintAbility>("dbf99b00cd35d0a4491c6cc9e771b487");



        public static BlueprintAbility Firestorm = BlueprintTools.GetBlueprint<BlueprintAbility>("e3d0dfe1c8527934294f241e0ae96a8d");
        public static BlueprintAbility OverwhelmingPresence = BlueprintTools.GetBlueprint<BlueprintAbility>("41cf93453b027b94886901dbfc680cb9");
        public static BlueprintAbility CommandGreaterFall = BlueprintTools.GetBlueprint<BlueprintAbility>("4cffe11248cb2134d98c9e39a827476a");
        public static BlueprintAbility PowerWordKill = BlueprintTools.GetBlueprint<BlueprintAbility>("2f8a67c483dfa0f439b293e094ca9e3c");
        public static BlueprintAbility PowerWordBlind = BlueprintTools.GetBlueprint<BlueprintAbility>("261e1788bfc5ac1419eec68b1d485dbc");
        public static BlueprintAbility WailOfBanshee = BlueprintTools.GetBlueprint<BlueprintAbility>("b24583190f36a8442b212e45226c54fc");
        public static BlueprintAbility MindBlank = BlueprintTools.GetBlueprint<BlueprintAbility>("df2a0ba6b6dcecf429cbb80a56fee5cf");

        public static BlueprintAbility SummonMonsterIXd3 = BlueprintTools.GetBlueprint<BlueprintAbility>("4988b2e622c6f2d4b897894e3be13f09");
        public static BlueprintAbility InvisibilityGreater = BlueprintTools.GetBlueprint<BlueprintAbility>("ecaa0def35b38f949bd1976a6c9539e0");
        public static BlueprintAbility HorridWilting = BlueprintTools.GetBlueprint<BlueprintAbility>("08323922485f7e246acb3d2276515526");
        public static BlueprintAbility ShoutGreater = BlueprintTools.GetBlueprint<BlueprintAbility>("fd0d3840c48cafb44bb29e8eb74df204");
        public static BlueprintAbility Disintegrate = BlueprintTools.GetBlueprint<BlueprintAbility>("4aa7942c3e62a164387a73184bca3fc1");
        public static BlueprintAbility HellfireRay = BlueprintTools.GetBlueprint<BlueprintAbility>("700cfcbd0cb2975419bcab7dbb8c6210");
        public static BlueprintAbility Sirocco = BlueprintTools.GetBlueprint<BlueprintAbility>("093ed1d67a539ad4c939d9d05cfe192c");

        public static BlueprintAbility TelekineticStrikePull = BlueprintTools.GetBlueprint<BlueprintAbility>("a9d1eff37681a294eb1ddaa50741b0b0");
        public static BlueprintAbility TelekineticStrike = BlueprintTools.GetBlueprint<BlueprintAbility>("1a33199538c31a14db23318fdb6e10cb");
        public static BlueprintAbility TripAction = BlueprintTools.GetBlueprint<BlueprintAbility>("6fd05c4ecfebd6f4d873325de442fc17");
        public static BlueprintAbility VescavorGuardSpitAcidAbility = BlueprintTools.GetBlueprint<BlueprintAbility>("77fdc27130bfef64abc0128c6c2de45b");
        public static BlueprintAbility DimensionDoorHell = BlueprintTools.GetBlueprint<BlueprintAbility>("637e9c2a9d121584fb8b3f3ec799eb1e");
        public static BlueprintAbility DerakniDroneAbility = BlueprintTools.GetBlueprint<BlueprintAbility>("30e1b50180b115840a94c611599de01e");
        public static BlueprintAbility DroningWingsAbility = BlueprintTools.GetBlueprint<BlueprintAbility>("7050231f1705f604c859f991fec4b523");
        public static BlueprintAbility Slow = BlueprintTools.GetBlueprint<BlueprintAbility>("f492622e473d34747806bdb39356eb89");
        public static BlueprintAbility ChainLightning = BlueprintTools.GetBlueprint<BlueprintAbility>("645558d63604747428d55f0dd3a4cb58");
        public static BlueprintAbility PhantasmalPutrefaction = BlueprintTools.GetBlueprint<BlueprintAbility>("1f2e6019ece86d64baa5effa15e81ecc");
        public static BlueprintAbility Heal = BlueprintTools.GetBlueprint<BlueprintAbility>("ff8f1534f66559c478448723e16b6624");
        public static BlueprintAbility Harm = BlueprintTools.GetBlueprint<BlueprintAbility>("137af566f68fd9b428e2e12da43c1482");
        public static BlueprintAbility RighteousMagic = BlueprintTools.GetBlueprint<BlueprintAbility>("90810e5cf53bf854293cbd5ea1066252");
        public static BlueprintAbility CureModerateWoundsMass = BlueprintTools.GetBlueprint<BlueprintAbility>("571221cc141bc21449ae96b3944652aa");
        public static BlueprintAbility ScorchingRay = BlueprintTools.GetBlueprint<BlueprintAbility>("cdb106d53c65bbc4086183d54c3b97c7");
        public static BlueprintAbility BurningArc = BlueprintTools.GetBlueprint<BlueprintAbility>("eaac3d36e0336cb479209a6f65e25e7c");
        public static BlueprintAbility VitalStrikeAbilityGreater = BlueprintTools.GetBlueprint<BlueprintAbility>("11f971b6453f74d4594c538e3c88d499");
        public static BlueprintAbility SenseVitals = BlueprintTools.GetBlueprint<BlueprintAbility>("82962a820ebc0e7408b8582fdc3f4c0c");
        public static BlueprintAbility Nurah_InspirecourageAbility = BlueprintTools.GetBlueprint<BlueprintAbility>("2e5cbdbab116779418fa94021b2547fc");



        // MYTHIC ABILITIES
        public static BlueprintAbility EdictofImpenetrableFortress = BlueprintTools.GetBlueprint<BlueprintAbility>("d7741c08ccf699e4a8a8f8ab2ed345f8");
        public static BlueprintAbility FreezingNothingness = BlueprintTools.GetBlueprint<BlueprintAbility>("89bc94bd06dcf5847bb9e4d6ba1b9767");
        public static BlueprintAbility MicroscopicProportions = BlueprintTools.GetBlueprint<BlueprintAbility>("d6042abe75df262498b6021eb8cc07a5");
        public static BlueprintAbility RainofHalberds = BlueprintTools.GetBlueprint<BlueprintAbility>("a759d339d98572a42a0c6e1dcc33453d");
        public static BlueprintAbility BoneShield = BlueprintTools.GetBlueprint<BlueprintAbility>("0093fc0098c984c43ac239d1211d1311");
        public static BlueprintAbility Revolt = BlueprintTools.GetBlueprint<BlueprintAbility>("319c5a450b01f834599389853753d0f0");
        public static BlueprintAbility SuddenSquall = BlueprintTools.GetBlueprint<BlueprintAbility>("4e22d7cfda74b3644b31de8e7c044e21");
        public static BlueprintAbility EdictOfInvulnerability = BlueprintTools.GetBlueprint<BlueprintAbility>("6d21deddd7712fd409c94d248b75643d");
        public static BlueprintAbility DemonTeleport = BlueprintTools.GetBlueprint<BlueprintAbility>("b3e8e307811b2a24387c2c9226fb4c10");









    }
}

// Grease, magearmor, true strike, create pit, hideous laughter, scare, web, haste, spiked pit, slow, soothing mud, acid pit, fear, spike stones, Cacophonous Call
// Cacophonous Call mass, Castigate, Castigate mass, hungry pit, waves of fatigue, wracking ray, Banshee Blast, Disintegrate, dispel magic greater, Eyebite, Litany of Madness,
// Sirocco, Tar Pool, Blasphemy, creeping doom, destruction, Finger of Death, Insanity, Ki Shout, Power Word Blind, Waves of Ecstasy, Waves of Exhaustion, Word of Chaos, Euphoric Tranquility
// Power Word Stun, Prediction of Failure, Rift of Ruin
// Shout, Greater, Unholy Aura, Stormbolts, 	Clashing Rocks, Overwhelming Presence, Wail of the Banshee


// buffeja: mage armor, barkskin, shield of faith, displacement, blink , greater inv, false life, stoneskin, stoneskin communal, heal&harm, true seeing communal, 	Frightful Aspect, Seamantle
// Foresight Heal, Mass, Heroic Invocation

// hienompia juttuja: remove fear, 