// Decompiled with JetBrains decompiler
// Type: PlayerGetGold
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

#nullable disable
public class PlayerGetGold : MonoBehaviour
{
  public void GetGold(int amount)
  {
    Character player = References.Player;
    if (!((Object) player != (Object) null))
      return;
    player.data.inventory.gold += amount;
    player.entity.PromptUpdate();
  }
}
