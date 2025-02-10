// Decompiled with JetBrains decompiler
// Type: LeaderboardsEntry
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LeaderboardsEntry : MonoBehaviour
{
  [SerializeField]
  private Color playerBgColor;
  [SerializeField]
  private Graphic background;
  [SerializeField]
  private TMP_Text nameText;
  [SerializeField]
  private TMP_Text rankText;
  [SerializeField]
  private TMP_Text scoreText;
  [SerializeField]
  private TMP_Text timeText;

  public void Set(bool isPlayer, string name, int rank, object score, string timeString)
  {
    if (isPlayer)
      this.background.color = this.playerBgColor;
    this.nameText.text = name;
    this.rankText.text = string.Format("#{0}", (object) rank);
    this.scoreText.text = score.ToString();
    this.timeText.text = timeString;
  }
}
