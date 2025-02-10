// Decompiled with JetBrains decompiler
// Type: AddCharmSlotModifierSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine.Events;

#nullable disable
public class AddCharmSlotModifierSystem : GameSystem
{
  public void OnEnable()
  {
    global::Events.OnEntityEnterBackpack += new UnityAction<Entity>(AddCharmSlotModifierSystem.EntityEnterBackpack);
  }

  public void OnDisable()
  {
    global::Events.OnEntityEnterBackpack -= new UnityAction<Entity>(AddCharmSlotModifierSystem.EntityEnterBackpack);
  }

  public static void EntityEnterBackpack(Entity entity)
  {
    AddCharmSlotModifierSystem.AddCharmSlot(entity.data);
  }

  public static void AddCharmSlot(CardData target)
  {
    object obj;
    if (target.customData != null && target.customData.TryGetValue("extraCharmSlots", out obj) && obj is int num)
      target.customData["extraCharmSlots"] = (object) (num + 1);
    else
      target.SetCustomData("extraCharmSlots", (object) 1);
  }
}
