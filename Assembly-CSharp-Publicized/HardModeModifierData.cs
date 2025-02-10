// Decompiled with JetBrains decompiler
// Type: HardModeModifierData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using NaughtyAttributes;
using UnityEngine;

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
