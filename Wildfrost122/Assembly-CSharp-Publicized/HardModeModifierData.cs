// Decompiled with JetBrains decompiler
// Type: HardModeModifierData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

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
