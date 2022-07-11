
using Kingmaker.Blueprints;
using Kingmaker.Blueprints.Classes;
using Kingmaker.UnitLogic.Abilities.Blueprints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TabletopTweaks.Core.Utilities;

namespace HarderEnemies.Blueprints {
    public class FeatureList {
        public static BlueprintFeature ElectricityImmunity = BlueprintTools.GetBlueprint<BlueprintFeature>("cd1e5ab641a833c49994aff99db98952");
        public static BlueprintFeature DR10 = BlueprintTools.GetBlueprint<BlueprintFeature>("e3b18255d373c494b83b4b95956fd847");
        public static BlueprintFeature DR15 = BlueprintTools.GetBlueprint<BlueprintFeature>("a1477ed71c2329d4088192cac8d4e3bd");
        public static BlueprintFeature DR30 = BlueprintTools.GetBlueprint<BlueprintFeature>("f8b2bfe671e44fc1bbca504953f46646");
        public static BlueprintFeature DR5 = BlueprintTools.GetBlueprint<BlueprintFeature>("f4b3dfedcc150d249be42c0d12302b20");

        public static BlueprintFeature Toughness = BlueprintTools.GetBlueprint<BlueprintFeature>("d09b20029e9abfe4480b356c92095623");
        public static BlueprintFeature Fortification25 = BlueprintTools.GetBlueprint<BlueprintFeature>("165b74db9493ded40ac05b3521aab427");
        public static BlueprintFeature Fortification50 = BlueprintTools.GetBlueprint<BlueprintFeature>("ca267173a3bb657489b5a6d6a06d09ac");
        public static BlueprintFeature Fortification75 = BlueprintTools.GetBlueprint<BlueprintFeature>("81701da21df5a3d4a8668a89ce6a1210");

        public static BlueprintFeature VescavorQueenGibberAbility = BlueprintTools.GetBlueprint<BlueprintFeature>("a938c2c4b81c8c342b46bab76989d727");
        public static BlueprintFeature TripBite = BlueprintTools.GetBlueprint<BlueprintFeature>("f957b4444b6fb404e84ae2a5765797bb");
        public static BlueprintFeature QuickenSpellFeature = BlueprintTools.GetBlueprint<BlueprintFeature>("ef7ece7bb5bb66a41b256976b27f424e");
        public static BlueprintFeature ImprovedPreciseShot = ResourcesLibrary.TryGetBlueprint<BlueprintFeature>("46f970a6b9b5d2346b10892673fe6e74");
        public static BlueprintFeature PreciseBomb = ResourcesLibrary.TryGetBlueprint<BlueprintFeature>("5c396342f614dd644a48c3af08d79701");
        public static BlueprintFeature PreciseShot = ResourcesLibrary.TryGetBlueprint<BlueprintFeature>("8f3d1e6b4be006f4d896081f2f889665");
        public static BlueprintFeature PointBlankShot = ResourcesLibrary.TryGetBlueprint<BlueprintFeature>("0da0c194d6e1d43419eb8d990b28e0ab");

        public static BlueprintFeature GreaterBullRush = ResourcesLibrary.TryGetBlueprint<BlueprintFeature>("72ba6ad46d94ecd41bad8e64739ea392");
        public static BlueprintFeature ImprovedBullRush = ResourcesLibrary.TryGetBlueprint<BlueprintFeature>("b3614622866fe7046b787a548bbd7f59");
        public static BlueprintFeature HalfFiendTemplate = ResourcesLibrary.TryGetBlueprint<BlueprintFeature>("f79b555fa1d81d44499a128076f91273");
        public static BlueprintFeature GreatCleaveFeature = ResourcesLibrary.TryGetBlueprint<BlueprintFeature>("cc9c862ef2e03af4f89be5088851ea35");
        public static BlueprintFeature CleaveFeature = ResourcesLibrary.TryGetBlueprint<BlueprintFeature>("d809b6c4ff2aaff4fa70d712a70f7d7b");
        public static BlueprintFeature CleavingFinish = ResourcesLibrary.TryGetBlueprint<BlueprintFeature>("59bd93899149fa44687ff4121389b3a9");
        public static BlueprintFeature ImprovedCleavingFinish = ResourcesLibrary.TryGetBlueprint<BlueprintFeature>("ffa1b373190af4f4db7a5501904a1983");
        public static BlueprintFeature DazzlingDisplayFeature = ResourcesLibrary.TryGetBlueprint<BlueprintFeature>("bcbd674ec70ff6f4894bb5f07b6f4095");
        public static BlueprintFeature SkillFocusDiplomacy = ResourcesLibrary.TryGetBlueprint<BlueprintFeature>("1621be43793c5bb43be55493e9c45924");
        public static BlueprintFeature DreadfulCarnage = ResourcesLibrary.TryGetBlueprint<BlueprintFeature>("fc37b70e3d064a147a3a99db4a86ee12");
        public static BlueprintFeature TrippingBite = BlueprintTools.GetBlueprint<BlueprintFeature>("f957b4444b6fb404e84ae2a5765797bb");
        public static BlueprintFeature CornugonSmash = ResourcesLibrary.TryGetBlueprint<BlueprintFeature>("ceea53555d83f2547ae5fc47e0399e14");
        public static BlueprintFeature IntimidatingProwess = ResourcesLibrary.TryGetBlueprint<BlueprintFeature>("d76497bfc48516e45a0831628f767a0f");
        public static BlueprintFeature Outflank = ResourcesLibrary.TryGetBlueprint<BlueprintFeature>("422dab7309e1ad343935f33a4d6e9f11");
        public static BlueprintFeature DispellingStrike = ResourcesLibrary.TryGetBlueprint<BlueprintFeature>("1b92146b8a9830d4bb97ab694335fa7c");
        public static BlueprintFeature VitalStrikeFeature = ResourcesLibrary.TryGetBlueprint<BlueprintFeature>("14a1fc1356df9f146900e1e42142fc9d");
        public static BlueprintFeature VitalStrikeFeatureGreater = ResourcesLibrary.TryGetBlueprint<BlueprintFeature>("e2d1fa11f6b095e4fb2fd1dcf5e36eb3");
        public static BlueprintFeature VitalStrikeFeatureImproved = ResourcesLibrary.TryGetBlueprint<BlueprintFeature>("52913092cd018da47845f36e6fbe240f");
        public static BlueprintFeature VitalStrikeMythicFeat = ResourcesLibrary.TryGetBlueprint<BlueprintFeature>("e07bcb271ecefec44be314e1c807c798");
        public static BlueprintFeature Persuasive = ResourcesLibrary.TryGetBlueprint<BlueprintFeature>("86d93a5891d299d4983bdc6ef3987afd");
        public static BlueprintFeature ShatterDefenses = ResourcesLibrary.TryGetBlueprint<BlueprintFeature>("61a17ccbbb3d79445b0926347ec07577");
        public static BlueprintFeature ThugFrightening = ResourcesLibrary.TryGetBlueprint<BlueprintFeature>("5476fa6ac147a584aa886f1c232b8a87");
        public static BlueprintFeature ArcaneArmorTraining = ResourcesLibrary.TryGetBlueprint<BlueprintFeature>("1a0298abacb6e0f45b7e28553e99e76c");
        public static BlueprintFeature ArcaneArmorMastery = ResourcesLibrary.TryGetBlueprint<BlueprintFeature>("453f5181a5ed3a445abfa3bcd3f4ac0c");

        // MYTHIC FEATURES
        public static BlueprintFeature AlwaysAChange = BlueprintTools.GetBlueprint<BlueprintFeature>("d57301613ad6a5140b2fdac40fa368e3");
        public static BlueprintFeature ThunderingBlows = BlueprintTools.GetBlueprint<BlueprintFeature>("8081c981b95ad9f49a421e7345c8c6f6");
        public static BlueprintFeature DestructiveShockwave = BlueprintTools.GetBlueprint<BlueprintFeature>("263a65c1e92dd964192ba7d41a76b4e3");
        public static BlueprintFeature AscendentElementFire = BlueprintTools.GetBlueprint<BlueprintFeature>("dc9bc78e5ef2ed6459343350fbe883bc");
        public static BlueprintFeature AscendentElementNegative = BlueprintTools.GetBlueprint<BlueprintFeature>("d9819d09c703c53438e142a2e2c8a113");
        public static BlueprintFeature AscendentElementAcid = BlueprintTools.GetBlueprint<BlueprintFeature>("d808baf783a063e4d84a1aaadbdd1cb7");
        public static BlueprintFeature AscendentElementElectricity = BlueprintTools.GetBlueprint<BlueprintFeature>("7bf39f8d76f8c9441896222128f1673a");
        public static BlueprintFeature AscendentElementCold = BlueprintTools.GetBlueprint<BlueprintFeature>("25f9791fbb5de694a8a3b936d2f30390");
        public static BlueprintFeature BullRushMythicFeat = BlueprintTools.GetBlueprint<BlueprintFeature>("50f13705c167bfa43ad4e1a7da95c491");



        public static BlueprintFeature CR22_AxiomiteCaster_Feature_Prebuff = ResourcesLibrary.TryGetBlueprint<BlueprintFeature>("c6e69c237da84ff1ae85603912187809");
        public static BlueprintFeature CR22_AxiomiteCaster_Feature_CombatPrebuff = ResourcesLibrary.TryGetBlueprint<BlueprintFeature>("c412fe0f34ec444e9f9ca1da3d18bd9b");



    }
}
