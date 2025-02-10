// Decompiled with JetBrains decompiler
// Type: StatusEffectDoubleAllXWhenDestroyed
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Specific/Double All X When Destroyed", fileName = "Double All X When Destroyed")]
public class StatusEffectDoubleAllXWhenDestroyed : StatusEffectData
{
  [SerializeField]
  public StatusEffectData effectToDouble;

  public override void Init()
  {
    this.OnEntityDestroyed += new StatusEffectData.EffectEntityDeathEventHandler(this.DestroyCheck);
  }

  public override bool RunEntityDestroyedEvent(Entity entity, DeathType deathType)
  {
    return (Object) entity == (Object) this.target;
  }

  public IEnumerator DestroyCheck(Entity entity, DeathType deathType)
  {
    StatusEffectDoubleAllXWhenDestroyed allXwhenDestroyed = this;
    foreach (Entity allCard in Battle.GetAllCards())
    {
      if (allCard.enabled)
      {
        StatusEffectData status = allCard.FindStatus(allXwhenDestroyed.effectToDouble.type);
        if ((Object) status != (Object) null)
        {
          Hit hit = new Hit(allXwhenDestroyed.target, allCard, 0);
          hit.AddStatusEffect(allXwhenDestroyed.effectToDouble, status.count);
          yield return (object) hit.Process();
        }
      }
    }
  }
}
