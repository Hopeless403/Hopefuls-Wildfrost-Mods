// Decompiled with JetBrains decompiler
// Type: HardModeModifierData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
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
