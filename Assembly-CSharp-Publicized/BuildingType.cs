// Decompiled with JetBrains decompiler
// Type: BuildingType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;
using UnityEngine.Localization;

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
