// Decompiled with JetBrains decompiler
// Type: UnlockModifierSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

#nullable disable
public class UnlockModifierSequence : MonoBehaviour
{
  [SerializeField]
  private ModifierIcon icon;

  public void Run(GameModifierData modifierData)
  {
    this.icon.Set(modifierData, Vector2.zero);
    this.gameObject.SetActive(true);
  }
}
