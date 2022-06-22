using System;
using System.Collections.Generic;
using System.Linq;
using Kingmaker;
using Kingmaker.Blueprints.JsonSystem;
using Kingmaker.EntitySystem.Entities;
using Kingmaker.Items.Slots;
using Kingmaker.RuleSystem;
using Kingmaker.RuleSystem.Rules;
using Kingmaker.UnitLogic;
using Kingmaker.UnitLogic.Commands;
using Kingmaker.UnitLogic.Mechanics.Actions;
using Kingmaker.Utility;
using Owlcat.Runtime.Core.Utils;
using static HarderEnemies.Main;

namespace HarderEnemies.Features.Logics {
    public class CustomContextActionMeleeAttack : ContextAction 
        {

        // Allows to target same target even if using selectnewtarget 
            public override string GetCaption() {
                return "Caster melee attack " + (this.SelectNewTarget ? "(change target)" : "");
            }

            public override void RunAction() {
                UnitEntityData maybeCaster = base.Context.MaybeCaster;
                if (maybeCaster == null) {
                    PFLog.Default.Error("Caster is missing", Array.Empty<object>());
                    return;
                }
                WeaponSlot threatHandMelee = maybeCaster.GetThreatHandMelee();
                if (threatHandMelee == null) {
                    PFLog.Default.Error("Caster can't make melee attack", Array.Empty<object>());
                    return;
                }
                UnitEntityData maybeCaster2 = base.Context.MaybeCaster;
                float meters = threatHandMelee.Weapon.AttackRange.Meters;
                bool selectNewTarget = this.SelectNewTarget;
                TargetWrapper target = base.Target;
                UnitEntityData unitEntityData = SelectTargetCustom(maybeCaster2, meters, selectNewTarget, (target != null) ? target.Unit : null);
                if (unitEntityData != null) {
                    if (this.FullAttack) {
                        RuleCalculateAttacksCount attacksCount = Rulebook.Trigger<RuleCalculateAttacksCount>(new RuleCalculateAttacksCount(maybeCaster));
                        int num = 0;
                        List<UnitAttack.AttackInfo> list = UnitAttack.EnumerateAttacks(attacksCount).ToTempList<UnitAttack.AttackInfo>();
                        List<WeaponSlot> list2 = (from h in maybeCaster.Body.AdditionalLimbs
                                                  where h.HasWeapon && h.HasItem
                                                  select h).ToTempList<WeaponSlot>();
                        int attacksCount2 = list.Count + list2.Count;
                        foreach (UnitAttack.AttackInfo attackInfo in list) {
                            this.RunAttackRule(maybeCaster, unitEntityData, attackInfo.Hand, attackInfo.AttackBonusPenalty, num, attacksCount2);
                            num++;
                        }
                        using (List<WeaponSlot>.Enumerator enumerator2 = list2.GetEnumerator()) {
                            while (enumerator2.MoveNext()) {
                                WeaponSlot hand = enumerator2.Current;
                                this.RunAttackRule(maybeCaster, unitEntityData, hand, 0, num, attacksCount2);
                                num++;
                            }
                            return;
                        }
                    }
                    this.RunAttackRule(maybeCaster, unitEntityData, threatHandMelee, 0, 0, 1);
                }
            }

            private void RunAttackRule(UnitEntityData caster, UnitEntityData target, WeaponSlot hand, int attackBonusPenalty = 0, int attackNumber = 0, int attacksCount = 1) {
                RuleAttackWithWeapon ruleAttackWithWeapon = new RuleAttackWithWeapon(caster, target, hand.Weapon, attackBonusPenalty) {
                    Reason = base.Context,
                    AutoHit = this.AutoHit,
                    AutoCriticalThreat = this.AutoCritThreat,
                    AutoCriticalConfirmation = this.AutoCritConfirmation,
                    ExtraAttack = this.ExtraAttack,
                    IsFullAttack = this.FullAttack,
                    AttackNumber = attackNumber,
                    AttacksCount = attacksCount
                };
                if (this.IgnoreStatBonus) {
                    ruleAttackWithWeapon.WeaponStats.OverrideDamageBonusStatMultiplier(0f);
                }
                base.Context.TriggerRule<RuleAttackWithWeapon>(ruleAttackWithWeapon);
            }
            public static UnitEntityData SelectTarget(UnitEntityData caster, float range, bool selectNewTarget, UnitEntityData target) {
                if (selectNewTarget) {
                    range += caster.View.Corpulence;
                    UnitEntityData unitEntityData = null;
                    foreach (UnitGroupMemory.UnitInfo unitInfo in caster.Memory.Enemies) {
                        UnitEntityData unit = unitInfo.Unit;
                        if (!(unit == null) && !(unit.View == null) && !(unit == target) && caster.DistanceTo(unit) <= range + unit.View.Corpulence && unit.Descriptor.State.IsConscious && (unitEntityData == null || unit.DistanceTo(target.Position) < unitEntityData.DistanceTo(target.Position))) {
                            unitEntityData = unit;
                        }
                    }
                    return unitEntityData;
                }
                if (target == null) {
                    PFLog.Default.Error("Target is invalid", Array.Empty<object>());
                    return null;
                }
                return target;
            }

            private static UnitEntityData SelectTargetCustom(UnitEntityData caster, float range, bool selectNewTarget, UnitEntityData target) {
                if (selectNewTarget) {
                    range += caster.View.Corpulence;
                    UnitEntityData unitEntityData = null;
                    foreach (UnitGroupMemory.UnitInfo unitInfo in caster.Memory.Enemies) {
                        UnitEntityData unit = unitInfo.Unit;
                        if (!(unit == null) && !(unit.View == null) && caster.DistanceTo(unit) <= range + unit.View.Corpulence && unit.Descriptor.State.IsConscious && (unitEntityData == null || unit.DistanceTo(target.Position) < unitEntityData.DistanceTo(target.Position))) {
                            unitEntityData = unit;
                        }
                    }
                    return unitEntityData;
                }
                if (target == null) {
                    PFLog.Default.Error("Target is invalid", Array.Empty<object>());
                    return null;
                }
                return target;
            }

        public bool SelectNewTarget;
            public bool AutoHit;
            public bool IgnoreStatBonus;
            public bool AutoCritThreat;
            public bool AutoCritConfirmation;
            public bool ExtraAttack = true;
            public bool FullAttack;
        }
    }
