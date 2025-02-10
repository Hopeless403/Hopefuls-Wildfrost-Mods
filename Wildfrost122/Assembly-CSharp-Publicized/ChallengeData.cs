// Decompiled with JetBrains decompiler
// Type: ChallengeData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;
using UnityEngine.Localization;

#nullable disable
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
