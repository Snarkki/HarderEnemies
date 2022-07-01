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

namespace HarderEnemies.UnitModifications.Cultists.Casters {
    internal class UnitLists {

  

        public static BlueprintUnit CR17_Cultist_Areshkagal_DamageFullCaster = BlueprintTools.GetBlueprint<BlueprintUnit>("be546212e4bc5164eabbcebb0ef8322e");
        
        public static BlueprintUnit CR2_Cultist_Wizard_BurningArc = BlueprintTools.GetBlueprint<BlueprintUnit>("6a663e03d7ca2a34ab132e5b93d841e9");
        public static BlueprintUnit CR3_Cultist_Wizard_DamageFullCaster = BlueprintTools.GetBlueprint<BlueprintUnit>("46d14b326c3a8f549941ec2573ce0cd0");
        public static BlueprintUnit CR3_Cultist_Wizard_DamageFullCaster_RE = BlueprintTools.GetBlueprint<BlueprintUnit>("2e2899d840529fa439233425d22b914d");
        public static BlueprintUnit CR4_Cultist_Wizard_DamageFullCaster = BlueprintTools.GetBlueprint<BlueprintUnit>("8a62f80242580d34caaafef9720223d4");
        public static BlueprintUnit CR4_Cultist_Wizard_DamageFullCaster_RE = BlueprintTools.GetBlueprint<BlueprintUnit>("ebb1aee495e961b4ebb4a9634c41abea");
        public static BlueprintUnit CR4_Cultist_Wizard_Summoner = BlueprintTools.GetBlueprint<BlueprintUnit>("a09f35ce8c5ae89419332c2c8a900097");
        public static BlueprintUnit CR4_Cultist_Wizard_Summoner_RE = BlueprintTools.GetBlueprint<BlueprintUnit>("46d6dd3493d4ef24995cb6251ddc764a");

        public static BlueprintUnit CR6_Cultist_Wizard_DamageFullCaster = BlueprintTools.GetBlueprint<BlueprintUnit>("acdf3463223474e4fa020409dec73e27");
        public static BlueprintUnit CR6_Cultist_Wizard_DamageFullCaster_RE = BlueprintTools.GetBlueprint<BlueprintUnit>("dda9df33a904a5649b8f6c415e0d8c10");
        public static BlueprintUnit CR6_Cultist_Wizard_Summoner = BlueprintTools.GetBlueprint<BlueprintUnit>("1a5d2d5098517ae459e16e107d8883b5");
        public static BlueprintUnit CR6_Cultist_Wizard_Summoner_RE = BlueprintTools.GetBlueprint<BlueprintUnit>("4e9742fc60a61074baaa2419971b1e74");
 
        public static BlueprintUnit CR8_Cultist_Wizard_DamageFullCaster = BlueprintTools.GetBlueprint<BlueprintUnit>("9e8a547e3e7c4014686e47ccd3d6233c");
        public static BlueprintUnit CR8_Cultist_Wizard_DamageFullCaster_RE = BlueprintTools.GetBlueprint<BlueprintUnit>("83d6afcfaaced4f45acfc45b9d13459b");
        public static BlueprintUnit Cultist_Wizard_DamageFullCaster_Deskari = BlueprintTools.GetBlueprint<BlueprintUnit>("d7b9114bfd97ba146b7e8ff787aa1950");
        public static BlueprintUnit CR8_Cultist_Wizard_Summoner = BlueprintTools.GetBlueprint<BlueprintUnit>("f44a6c38751971c42a4f4e5b75692016");
        public static BlueprintUnit CR8_Cultist_Wizard_Summoner_RE = BlueprintTools.GetBlueprint<BlueprintUnit>("743f12be576ba7348a90ca510b4d2a1b");
  
        
 


        public static List<BlueprintUnit> CR4CultistDamageCasterList = new List<BlueprintUnit>() {
                    CR4_Cultist_Wizard_DamageFullCaster,
                    CR4_Cultist_Wizard_DamageFullCaster_RE,
            };

        public static List<BlueprintUnit> CR4CultistSummonCasterList = new List<BlueprintUnit>() {
                    CR4_Cultist_Wizard_Summoner,
                    CR4_Cultist_Wizard_Summoner_RE,
            };

        public static List<BlueprintUnit> CR6CultistDamageCasterList = new List<BlueprintUnit>() {
                    CR6_Cultist_Wizard_DamageFullCaster,
                    CR6_Cultist_Wizard_DamageFullCaster_RE,
            };
        public static List<BlueprintUnit> CR6CultistSummonCasterList = new List<BlueprintUnit>() {
                    CR6_Cultist_Wizard_Summoner,
                    CR6_Cultist_Wizard_Summoner_RE,
            };
        public static List<BlueprintUnit> CR8CultistDamageCasterList = new List<BlueprintUnit>() {
                    CR8_Cultist_Wizard_DamageFullCaster,
                    CR8_Cultist_Wizard_DamageFullCaster_RE,
                    Cultist_Wizard_DamageFullCaster_Deskari
            };
        public static List<BlueprintUnit> CR8CultistSummonCasterList = new List<BlueprintUnit>() {
                    CR8_Cultist_Wizard_Summoner,
                    CR8_Cultist_Wizard_Summoner_RE,
            };

    }
}
