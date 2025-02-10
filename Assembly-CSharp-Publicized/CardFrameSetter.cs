// Decompiled with JetBrains decompiler
// Type: CardFrameSetter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

public class CardFrameSetter : MonoBehaviour
{
  [SerializeField]
  public AddressableTieredSpriteLoader[] spriteSetters;
  public bool loaded;

  public void Load(int frameLevel)
  {
    if (this.loaded)
      return;
    foreach (AddressableTieredSpriteLoader spriteSetter in this.spriteSetters)
      spriteSetter.Load(frameLevel);
    this.loaded = true;
  }
}
