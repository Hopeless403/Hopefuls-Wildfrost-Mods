// Decompiled with JetBrains decompiler
// Type: StatusEffectIncreaseCountDown
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Specific/Increase Count Down", fileName = "Increase Count Down")]
public class StatusEffectIncreaseCountDown : StatusEffectData
{
  protected override void Init()
  {
    Events.OnEntityCountDown += new Events.UnityActionCheck<Entity, int>(this.EntityCountDown);
  }

  private void OnDestroy()
  {
    Events.OnEntityCountDown -= new Events.UnityActionCheck<Entity, int>(this.EntityCountDown);
  }

  private void EntityCountDown(Entity entity, ref int amount)
  {
    if (!((Object) entity == (Object) this.target))
      return;
    amount += this.GetAmount();
  }
}
