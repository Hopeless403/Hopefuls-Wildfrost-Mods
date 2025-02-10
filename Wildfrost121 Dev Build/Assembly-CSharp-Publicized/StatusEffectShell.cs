// Decompiled with JetBrains decompiler
// Type: StatusEffectShell
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Shell", fileName = "Shell")]
public class StatusEffectShell : StatusEffectData
{
  public override void Init()
  {
    this.OnHit += new StatusEffectData.EffectHitEventHandler(this.Check);
  }

  public override bool RunHitEvent(Hit hit)
  {
    return (Object) hit.target == (Object) this.target && hit.damage > 0;
  }

  public IEnumerator Check(Hit hit)
  {
    StatusEffectShell statusEffectShell = this;
    while (hit.damage > 0 && statusEffectShell.count > 0)
    {
      --statusEffectShell.count;
      --hit.damage;
      ++hit.damageBlocked;
    }
    if (statusEffectShell.count <= 0)
      yield return (object) statusEffectShell.Remove();
    statusEffectShell.target.PromptUpdate();
  }
}
