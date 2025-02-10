// Decompiled with JetBrains decompiler
// Type: PetHutFlagSetter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

#nullable disable
public class PetHutFlagSetter : MonoBehaviour
{
  [SerializeField]
  public SpriteRenderer flag;
  [SerializeField]
  public Sprite[] flagSprites;

  public void SetupFlag()
  {
    this.flag.sprite = this.flagSprites[Mathf.Clamp(SaveSystem.LoadProgressData<int>("selectedPet", 0), 0, this.flagSprites.Length - 1)];
  }
}
