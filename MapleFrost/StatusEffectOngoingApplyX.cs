using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildfrostHopeMod.MapleFrost
{
    public class StatusEffectOngoingApplyX : StatusEffectOngoing
    {
        public override IEnumerator Add(int add)
        {
            return base.Add(add);
        }
        public override IEnumerator Remove(int remove)
        {
            return base.Remove(remove);
        }
    }
}
