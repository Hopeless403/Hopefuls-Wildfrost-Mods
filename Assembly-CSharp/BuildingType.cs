// Decompiled with JetBrains decompiler
// Type: BuildingType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

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
