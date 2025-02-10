// Decompiled with JetBrains decompiler
// Type: StatusEffectIncreaseCountDown
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

[CreateAssetMenu(menuName = "Status Effects/Specific/Increase Count Down", fileName = "Increase Count Down")]
public class StatusEffectIncreaseCountDown : StatusEffectData
{
  protected override void Init() => Events.OnEntityCountDown += new Events.UnityActionCheck<Entity, int>(this.EntityCountDown);

  private void OnDestroy() => Events.OnEntityCountDown -= new Events.UnityActionCheck<Entity, int>(this.EntityCountDown);

  private void EntityCountDown(Entity entity, ref int amount)
  {
    if (!((Object) entity == (Object) this.target))
      return;
    amount += this.GetAmount();
  }
}
