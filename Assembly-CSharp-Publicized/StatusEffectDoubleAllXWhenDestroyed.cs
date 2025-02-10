// Decompiled with JetBrains decompiler
// Type: StatusEffectDoubleAllXWhenDestroyed
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using UnityEngine;

[CreateAssetMenu(menuName = "Status Effects/Specific/Double All X When Destroyed", fileName = "Double All X When Destroyed")]
public class StatusEffectDoubleAllXWhenDestroyed : StatusEffectData
{
  [SerializeField]
  public StatusEffectData effectToDouble;

  public override void Init() => this.OnEntityDestroyed += new StatusEffectData.EffectEntityDeathEventHandler(this.DestroyCheck);

  public override bool RunEntityDestroyedEvent(Entity entity, DeathType deathType) => (Object) entity == (Object) this.target;

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
