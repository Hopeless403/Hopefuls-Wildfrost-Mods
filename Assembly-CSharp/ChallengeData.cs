// Decompiled with JetBrains decompiler
// Type: ChallengeData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.Localization;

[CreateAssetMenu(menuName = "Town/Challenge", fileName = "Challenge")]
public class ChallengeData : DataFile
{
  public bool hidden;
  public LocalizedString titleKey;
  public LocalizedString textKey;
  public LocalizedString rewardKey;
  public int goal;
  public ChallengeListener listener;
  public Sprite icon;
  public ChallengeData[] requires;
  public UnlockData reward;

  public string text => this.textKey.GetLocalizedString();

  public string rewardText => this.rewardKey.GetLocalizedString();
}
