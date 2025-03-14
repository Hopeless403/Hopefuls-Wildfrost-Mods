﻿// Decompiled with JetBrains decompiler
// Type: AddCharmSlotModifierSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine.Events;

#nullable disable
public class AddCharmSlotModifierSystem : GameSystem
{
  private void OnEnable()
  {
    global::Events.OnEntityEnterBackpack += new UnityAction<Entity>(AddCharmSlotModifierSystem.EntityEnterBackpack);
  }

  private void OnDisable()
  {
    global::Events.OnEntityEnterBackpack -= new UnityAction<Entity>(AddCharmSlotModifierSystem.EntityEnterBackpack);
  }

  private static void EntityEnterBackpack(Entity entity)
  {
    AddCharmSlotModifierSystem.AddCharmSlot(entity.data);
  }

  private static void AddCharmSlot(CardData target)
  {
    object obj;
    if (target.customData != null && target.customData.TryGetValue("extraCharmSlots", out obj) && obj is int num)
      target.customData["extraCharmSlots"] = (object) (num + 1);
    else
      target.SetCustomData("extraCharmSlots", (object) 1);
  }
}
