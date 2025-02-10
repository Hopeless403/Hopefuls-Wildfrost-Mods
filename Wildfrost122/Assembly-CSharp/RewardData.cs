// Decompiled with JetBrains decompiler
// Type: RewardData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "RewardData", menuName = "Reward Data")]
public class RewardData : ScriptableObject
{
  public string title;
  public string description;
  public Sprite icon;
  public GameObject buttonPrefab;
  public UISequence selectionScreenPrefab;
  public string acquireScript;
  public string[] acquireScriptArgs;
  public Sprite setCampaignNodeIcon;
}
