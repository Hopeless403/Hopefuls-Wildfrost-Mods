// Decompiled with JetBrains decompiler
// Type: StatusEffectDoubleAllXWhenDestroyed
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;

[CreateAssetMenu(menuName = "Status Effects/Specific/Double All X When Destroyed", fileName = "Double All X When Destroyed")]
public class StatusEffectDoubleAllXWhenDestroyed : StatusEffectData
{
  [SerializeField]
  private StatusEffectData effectToDouble;

  protected override void Init() => this.OnEntityDestroyed += new StatusEffectData.EffectEntityDeathEventHandler(this.DestroyCheck);

  public override bool RunEntityDestroyedEvent(Entity entity, DeathType deathType) => (Object) entity == (Object) this.target;

  private IEnumerator DestroyCheck(Entity entity, DeathType deathType)
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
