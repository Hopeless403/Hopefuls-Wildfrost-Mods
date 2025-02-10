// Decompiled with JetBrains decompiler
// Type: BuildingType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.Localization;

#nullable disable
[CreateAssetMenu(fileName = "Building", menuName = "Town/Building")]
public class BuildingType : DataFile
{
  public LocalizedString titleKey;
  public LocalizedString helpKey;
  public Prompt.Emote.Type helpEmoteType = Prompt.Emote.Type.Explain;
  [Header("Progression")]
  public UnlockData started;
  public UnlockData finished;
  public UnlockData[] unlocks;
  public string unlockedCheckedKey;
}
