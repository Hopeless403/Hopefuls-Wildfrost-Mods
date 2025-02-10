// Decompiled with JetBrains decompiler
// Type: PetHutFlagSetter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

public class PetHutFlagSetter : MonoBehaviour
{
  [SerializeField]
  private SpriteRenderer flag;
  [SerializeField]
  private Sprite[] flagSprites;

  public void SetupFlag() => this.flag.sprite = this.flagSprites[Mathf.Clamp(SaveSystem.LoadProgressData<int>("selectedPet", 0), 0, this.flagSprites.Length - 1)];
}
