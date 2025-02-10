// Decompiled with JetBrains decompiler
// Type: HardModeModifierData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using NaughtyAttributes;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Modifiers/Hard Mode Modifier", fileName = "Hard Mode Modifier")]
public class HardModeModifierData : ScriptableObject
{
  public GameModifierData modifierData;
  public int stormPoints;
  public bool unlockedByDefault;
  [HideIf("unlockedByDefault")]
  public HardModeModifierData[] unlockRequires;
  [HideIf("unlockedByDefault")]
  public int unlockRequiresPoints;
}
