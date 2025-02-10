// Decompiled with JetBrains decompiler
// Type: PlayerGetGold
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
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
