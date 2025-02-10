// Decompiled with JetBrains decompiler
// Type: UnlockModifierSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

#nullable disable
public class UnlockModifierSequence : MonoBehaviour
{
  [SerializeField]
  public ModifierIcon icon;

  public void Run(GameModifierData modifierData)
  {
    this.icon.Set(modifierData, Vector2.zero);
    this.gameObject.SetActive(true);
  }
}
