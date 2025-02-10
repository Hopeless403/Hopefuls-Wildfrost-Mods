// Decompiled with JetBrains decompiler
// Type: RewardData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

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
