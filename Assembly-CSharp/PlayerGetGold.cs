// Decompiled with JetBrains decompiler
// Type: PlayerGetGold
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

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
