// Decompiled with JetBrains decompiler
// Type: RenameMidBattleSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.Events;

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
