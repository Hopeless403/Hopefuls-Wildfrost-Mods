// Decompiled with JetBrains decompiler
// Type: RewardData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

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
