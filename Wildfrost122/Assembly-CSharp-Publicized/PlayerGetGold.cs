// Decompiled with JetBrains decompiler
// Type: PlayerGetGold
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

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
