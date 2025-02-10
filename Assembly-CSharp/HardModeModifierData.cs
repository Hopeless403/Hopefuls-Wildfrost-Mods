// Decompiled with JetBrains decompiler
// Type: HardModeModifierData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

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
