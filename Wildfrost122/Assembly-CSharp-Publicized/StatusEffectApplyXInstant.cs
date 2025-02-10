// Decompiled with JetBrains decompiler
// Type: StatusEffectApplyXInstant
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Specific/Instant Apply X", fileName = "Instant Apply X")]
public class StatusEffectApplyXInstant : StatusEffectApplyX
{
  public override bool Instant => true;

  public override int GetAmount(Entity entity, bool equalAmount = false, int equalTo = 0)
  {
    if ((bool) (Object) this.scriptableAmount)
      return this.scriptableAmount.Get(entity);
    return !equalAmount ? this.GetAmount() : equalTo;
  }

  public override int GetAmount() => this.count;

  public override bool TargetSilenced() => false;

  public override void Init()
  {
    this.OnBegin += new StatusEffectData.EffectEventHandler(this.Process);
  }

  public IEnumerator Process()
  {
    StatusEffectApplyXInstant effectApplyXinstant = this;
    yield return (object) effectApplyXinstant.Run(effectApplyXinstant.GetTargets());
    yield return (object) effectApplyXinstant.Remove();
  }
}
