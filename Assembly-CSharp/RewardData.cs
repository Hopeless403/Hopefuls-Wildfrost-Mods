// Decompiled with JetBrains decompiler
// Type: RewardData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

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
