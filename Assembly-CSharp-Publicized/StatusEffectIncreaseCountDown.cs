// Decompiled with JetBrains decompiler
// Type: StatusEffectIncreaseCountDown
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

[CreateAssetMenu(menuName = "Status Effects/Specific/Increase Count Down", fileName = "Increase Count Down")]
public class StatusEffectIncreaseCountDown : StatusEffectData
{
  public override void Init() => Events.OnEntityCountDown += new Events.UnityActionCheck<Entity, int>(this.EntityCountDown);

  public void OnDestroy() => Events.OnEntityCountDown -= new Events.UnityActionCheck<Entity, int>(this.EntityCountDown);

  public void EntityCountDown(Entity entity, ref int amount)
  {
    if (!((Object) entity == (Object) this.target))
      return;
    amount += this.GetAmount();
  }
}
