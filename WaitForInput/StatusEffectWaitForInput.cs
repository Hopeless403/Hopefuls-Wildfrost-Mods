using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace WaitForInput
{
    public class StatusEffectWaitForInput : StatusEffectData
    {
        public object state;
        public override bool RunApplyStatusEvent(StatusEffectApply apply)
        {
            if ((Object)apply?.effectData != (Object)null && apply.effectData.type == this.effectToAffect.type && apply.count > 0 && this.CheckTeamOfTarget(apply.target) && this.CheckTeamOfApplier(apply.applier))
            {
                if (this.setToSpecificValue)
                {
                    apply.count = this.specificValue;
                }
                else
                {
                    apply.count += this.add * this.GetAmount();
                    apply.count = Mathf.CeilToInt((float)apply.count * this.multiplyBy);
                }
            }
            return false;
        }
    }
}
