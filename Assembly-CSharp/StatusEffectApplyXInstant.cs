// Decompiled with JetBrains decompiler
// Type: StatusEffectApplyXInstant
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;

[CreateAssetMenu(menuName = "Status Effects/Specific/Instant Apply X", fileName = "Instant Apply X")]
public class StatusEffectApplyXInstant : StatusEffectApplyX
{
  public override bool Instant => true;

  protected override int GetAmount(Entity entity, bool equalAmount = false, int equalTo = 0)
  {
    if ((bool) (Object) this.scriptableAmount)
      return this.scriptableAmount.Get(entity);
    return !equalAmount ? this.GetAmount() : equalTo;
  }

  protected override int GetAmount() => this.count;

  protected override bool TargetSilenced() => false;

  protected override void Init() => this.OnBegin += new StatusEffectData.EffectEventHandler(this.Process);

  private IEnumerator Process()
  {
    StatusEffectApplyXInstant effectApplyXinstant = this;
    yield return (object) effectApplyXinstant.Run(effectApplyXinstant.GetTargets());
    yield return (object) effectApplyXinstant.Remove();
  }
}
