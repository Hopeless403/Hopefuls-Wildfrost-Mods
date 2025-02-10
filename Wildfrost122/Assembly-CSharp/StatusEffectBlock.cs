// Decompiled with JetBrains decompiler
// Type: StatusEffectBlock
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Block", fileName = "Block")]
public class StatusEffectBlock : StatusEffectData
{
  protected override void Init()
  {
    this.OnHit += new StatusEffectData.EffectHitEventHandler(this.Check);
  }

  public override bool RunHitEvent(Hit hit)
  {
    return (Object) hit.target == (Object) this.target && hit.Offensive && hit.canBeNullified && hit.damage > 0;
  }

  private IEnumerator Check(Hit hit)
  {
    StatusEffectBlock statusEffectBlock = this;
    SfxSystem.OneShot("event:/sfx/status_icon/block_decrease");
    hit.damageBlocked = hit.damage;
    hit.damage = 0;
    --statusEffectBlock.count;
    if (statusEffectBlock.count <= 0)
      yield return (object) statusEffectBlock.Remove();
    statusEffectBlock.target.PromptUpdate();
  }
}
