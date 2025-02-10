// Decompiled with JetBrains decompiler
// Type: RenameMidBattleSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;
using UnityEngine.Events;

public class RenameMidBattleSystem : MonoBehaviour
{
  public void OnEnable() => global::Events.OnRename += new UnityAction<Entity, string>(this.Rename);

  public void OnDisable() => global::Events.OnRename -= new UnityAction<Entity, string>(this.Rename);

  public void Rename(Entity entity, string newName)
  {
    foreach (Entity card in References.Battle.cards)
    {
      if (card.inPlay && (long) card.data.id == (long) entity.data.id && card.display is Card display)
        display.SetName(newName);
    }
  }
}
