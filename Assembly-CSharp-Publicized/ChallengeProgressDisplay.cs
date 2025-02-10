// Decompiled with JetBrains decompiler
// Type: ChallengeProgressDisplay
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ChallengeProgressDisplay : MonoBehaviour
{
  public TMP_Text text;
  public TMP_Text progressText;
  public ImageSprite icon;
  public ImageSprite back;
  public Image fill;
  public UnityEngine.Animator animator;

  public void Assign(ChallengeData challengeData)
  {
    this.text.text = string.Format(challengeData.text, (object) challengeData.goal);
    this.icon.SetSprite(challengeData.icon);
  }

  public void SetRewardText(ChallengeData challengeData) => this.text.text = challengeData.rewardText;

  public void SetFill(float current, int target)
  {
    this.fill.fillAmount = current / (float) target;
    this.progressText.text = string.Format("{0}/{1}", (object) Mathf.RoundToInt(current), (object) target);
  }

  public void SetRemainingText(ChallengeData challengeData, float current)
  {
    int num = Mathf.RoundToInt(current);
    this.text.text = string.Format(challengeData.text, (object) (challengeData.goal - num));
  }

  public void SetColor(Color color)
  {
    this.text.color = color;
    this.progressText.color = color;
    this.fill.color = color;
  }
}
