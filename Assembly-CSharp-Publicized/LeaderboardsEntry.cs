// Decompiled with JetBrains decompiler
// Type: LeaderboardsEntry
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LeaderboardsEntry : MonoBehaviour
{
  [SerializeField]
  public Color playerBgColor;
  [SerializeField]
  public Graphic background;
  [SerializeField]
  public TMP_Text nameText;
  [SerializeField]
  public TMP_Text rankText;
  [SerializeField]
  public TMP_Text scoreText;
  [SerializeField]
  public TMP_Text timeText;

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
