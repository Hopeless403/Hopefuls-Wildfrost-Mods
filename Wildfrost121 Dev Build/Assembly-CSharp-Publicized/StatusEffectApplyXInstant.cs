// Decompiled with JetBrains decompiler
// Type: StatusEffectApplyXInstant
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
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
