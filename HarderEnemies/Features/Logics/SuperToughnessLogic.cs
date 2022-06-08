using Kingmaker.Blueprints;
using Kingmaker.Blueprints.Facts;
using Kingmaker.Enums;
using Kingmaker.PubSubSystem;
using Kingmaker.UnitLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarderEnemies.Features {
    [AllowedOn(typeof(BlueprintUnitFact), false)]
    public class SuperToughnessLogic : UnitFactComponentDelegate, ISubscriber, IGlobalSubscriber, IOwnerGainLevelHandler, IUnitSubscriber {
        public override void OnTurnOn() {
            this.Apply();
        }

        public override void OnTurnOff() {
            base.Owner.Stats.HitPoints.RemoveModifiersFrom(base.Runtime);
        }

        public void HandleUnitGainLevel() {
            this.Apply();
        }

        private void Apply() {
            base.Owner.Stats.HitPoints.RemoveModifiersFrom(base.Runtime);
            int num = (this.CheckMythicLevel ? base.Owner.Progression.MythicLevel : base.Owner.Progression.CharacterLevel) * 25;
            int value = this.CheckMythicLevel ? num : Math.Max(25, num);
            base.Owner.Stats.HitPoints.AddModifier(value, base.Runtime, ModifierDescriptor.UntypedStackable);
        }

        public bool CheckMythicLevel;
    }
}
