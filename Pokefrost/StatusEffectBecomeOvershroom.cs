// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectBecomeOvershroom
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System.Collections;
using UnityEngine;

#nullable disable
namespace Pokefrost
{
  public class StatusEffectBecomeOvershroom : StatusEffectData
  {
    public override bool HasApplyStatusRoutine => true;

    public override IEnumerator ApplyStatusRoutine(StatusEffectApply apply)
    {
      Debug.Log((object) "[Test] ApplyStatusRoutine");
      int num;
      if (apply != null && (Object) apply.applier?.owner == (Object) this.target.owner)
      {
        StatusEffectData effectData = apply.effectData;
        if ((effectData != null ? (effectData.offensive ? 1 : 0) : 0) != 0)
        {
          num = apply?.effectData.name == "Overload" ? 1 : (apply?.effectData.name == "Shroom" ? 1 : 0);
          goto label_4;
        }
      }
      num = 0;
label_4:
      if (num != 0)
      {
        Debug.Log((object) "[Test] found overload");
        apply.effectData = AddressableLoader.Get<StatusEffectData>("StatusEffectData", "Overshroom");
      }
      return (IEnumerator) null;
    }
  }
}
