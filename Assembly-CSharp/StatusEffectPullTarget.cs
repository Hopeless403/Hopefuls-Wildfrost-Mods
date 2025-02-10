// Decompiled with JetBrains decompiler
// Type: StatusEffectPullTarget
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

[CreateAssetMenu(menuName = "Status Effects/Traits/Pull Target", fileName = "Pull Target")]
public class StatusEffectPullTarget : StatusEffectData
{
  private Hit storedHit;

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
      int index = container.IndexOf(target);
      int num = Mathf.Max(index - this.GetAmount(), 0);
      if (index != num)
      {
        container.RemoveAt(index);
        container.PushBackwards(num);
        container.Insert(num, target);
        foreach (Entity child in container)
          container.TweenChildPosition(child);
      }
    }
    return false;
  }
}
