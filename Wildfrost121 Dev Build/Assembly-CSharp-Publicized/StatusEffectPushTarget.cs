// Decompiled with JetBrains decompiler
// Type: StatusEffectPushTarget
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Traits/Push Target", fileName = "Push Target")]
public class StatusEffectPushTarget : StatusEffectData
{
  public Hit storedHit;

  public override bool RunPreAttackEvent(Hit hit)
  {
    if ((Object) hit.attacker == (Object) this.target && this.target.alive && this.target.enabled && (Object) hit.target != (Object) null && hit.target.containers != null)
    {
      hit.FlagAsOffensive();
      this.storedHit = hit;
    }
    return false;
  }

  public override bool RunHitEvent(Hit hit)
  {
    if (hit == this.storedHit)
    {
      Entity target = hit.target;
      CardContainer container = target.containers[0];
      int index1 = container.IndexOf(target);
      int index2 = Mathf.Min(index1 + this.GetAmount(), container.max - 1);
      if (index1 != index2)
      {
        container.RemoveAt(index1);
        container.Insert(index2, target);
        foreach (Entity child in container)
          container.TweenChildPosition(child);
      }
    }
    return false;
  }
}
