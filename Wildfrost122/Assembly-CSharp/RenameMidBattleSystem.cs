// Decompiled with JetBrains decompiler
// Type: RenameMidBattleSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.Events;

#nullable disable
public class RenameMidBattleSystem : MonoBehaviour
{
  private void OnEnable() => global::Events.OnRename += new UnityAction<Entity, string>(this.Rename);

  private void OnDisable() => global::Events.OnRename -= new UnityAction<Entity, string>(this.Rename);

  private void Rename(Entity entity, string newName)
  {
    foreach (Entity card in References.Battle.cards)
    {
      if (card.inPlay && (long) card.data.id == (long) entity.data.id && card.display is Card display)
        display.SetName(newName);
    }
  }
}
