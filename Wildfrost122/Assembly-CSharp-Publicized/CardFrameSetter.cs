// Decompiled with JetBrains decompiler
// Type: CardFrameSetter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

#nullable disable
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
