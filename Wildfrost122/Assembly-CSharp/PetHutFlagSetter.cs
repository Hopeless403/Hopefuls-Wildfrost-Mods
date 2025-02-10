// Decompiled with JetBrains decompiler
// Type: PetHutFlagSetter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

#nullable disable
public class PetHutFlagSetter : MonoBehaviour
{
  [SerializeField]
  private SpriteRenderer flag;
  [SerializeField]
  private Sprite[] flagSprites;

  public void SetupFlag()
  {
    this.flag.sprite = this.flagSprites[Mathf.Clamp(SaveSystem.LoadProgressData<int>("selectedPet", 0), 0, this.flagSprites.Length - 1)];
  }
}
