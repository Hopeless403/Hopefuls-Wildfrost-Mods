// Decompiled with JetBrains decompiler
// Type: StatusEffectScrap
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;

[CreateAssetMenu(menuName = "Status Effects/Scrap", fileName = "Scrap")]
public class StatusEffectScrap : StatusEffectData
{
  protected override void Init() => this.OnHit += new StatusEffectData.EffectHitEventHandler(this.Check);

  public override bool RunHitEvent(Hit hit) => (Object) hit.target == (Object) this.target && hit.damage > 0 && !hit.nullified;

  private IEnumerator Check(Hit hit)
  {
    StatusEffectScrap statusEffectScrap = this;
    hit.damageBlocked = hit.damage;
    hit.damage = 0;
    --statusEffectScrap.count;
    if (statusEffectScrap.count <= 0)
      yield return (object) statusEffectScrap.Remove();
    statusEffectScrap.target.PromptUpdate();
  }
}
