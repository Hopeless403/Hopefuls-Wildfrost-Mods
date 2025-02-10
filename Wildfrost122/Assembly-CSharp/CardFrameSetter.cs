// Decompiled with JetBrains decompiler
// Type: CardFrameSetter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

#nullable disable
public class CardFrameSetter : MonoBehaviour
{
  [SerializeField]
  private AddressableTieredSpriteLoader[] spriteSetters;
  private bool loaded;

  public void Load(int frameLevel)
  {
    if (this.loaded)
      return;
    foreach (AddressableTieredSpriteLoader spriteSetter in this.spriteSetters)
      spriteSetter.Load(frameLevel);
    this.loaded = true;
  }
}
