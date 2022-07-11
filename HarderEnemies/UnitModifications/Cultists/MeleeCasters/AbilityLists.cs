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

namespace HarderEnemies.UnitModifications.Cultists.MeleeCasters {
    internal class AbilityLists {

        /// <summary>
        /// 
        /// </summary>

 
        public static BlueprintAbilityReference[] LowLevelCultistClericMemorizedSpells = new BlueprintAbilityReference[] {
                Abilities.Command.ToReference<BlueprintAbilityReference>(),
                Abilities.Command.ToReference<BlueprintAbilityReference>(),
                Abilities.CauseFear.ToReference<BlueprintAbilityReference>(),
                Abilities.CauseFear.ToReference<BlueprintAbilityReference>(),
                Abilities.HoldPerson.ToReference<BlueprintAbilityReference>(),
                Abilities.SoundBurst.ToReference<BlueprintAbilityReference>(),
                Abilities.Boneshaker.ToReference<BlueprintAbilityReference>(),
            };

        /// <summary>
        /// 
        /// </summary>

        public static BlueprintAbilityReference[] CR6ClericMemorizedSpells = {
                Abilities.Command.ToReference<BlueprintAbilityReference>(),
                Abilities.Command.ToReference<BlueprintAbilityReference>(),
                Abilities.CauseFear.ToReference<BlueprintAbilityReference>(),
                Abilities.CauseFear.ToReference<BlueprintAbilityReference>(),
                Abilities.HoldPerson.ToReference<BlueprintAbilityReference>(),
                Abilities.SoundBurst.ToReference<BlueprintAbilityReference>(),
                Abilities.Boneshaker.ToReference<BlueprintAbilityReference>(),
                Abilities.Prayer.ToReference<BlueprintAbilityReference>(),
                Abilities.Blindess.ToReference<BlueprintAbilityReference>(),
            };
        /// <summary>
        /// 
        /// </summary>

        public static BlueprintAbilityReference[] CR8ClericMemorizedSpells = {
                Abilities.Command.ToReference<BlueprintAbilityReference>(),
                Abilities.Command.ToReference<BlueprintAbilityReference>(),
                Abilities.CauseFear.ToReference<BlueprintAbilityReference>(),
                Abilities.CauseFear.ToReference<BlueprintAbilityReference>(),
                Abilities.HoldPerson.ToReference<BlueprintAbilityReference>(),
                Abilities.SoundBurst.ToReference<BlueprintAbilityReference>(),
                Abilities.Boneshaker.ToReference<BlueprintAbilityReference>(),
                Abilities.Prayer.ToReference<BlueprintAbilityReference>(),
                Abilities.Blindess.ToReference<BlueprintAbilityReference>(),
                Abilities.DivinePower.ToReference<BlueprintAbilityReference>(),
            };
        /// <summary>
        /// 
        /// </summary>

        public static BlueprintAbilityReference[] HighLevelClericMemorizedSpells = {
                Abilities.Prayer.ToReference<BlueprintAbilityReference>(),
                Abilities.Blindess.ToReference<BlueprintAbilityReference>(),
                Abilities.DivinePower.ToReference<BlueprintAbilityReference>(),
                Abilities.FlameStrike.ToReference<BlueprintAbilityReference>(),
                Abilities.FlameStrike.ToReference<BlueprintAbilityReference>(),
                Abilities.CommandGreater.ToReference<BlueprintAbilityReference>(),
                Abilities.ColdIceStrike.ToReference<BlueprintAbilityReference>(),
            };
    }
}
