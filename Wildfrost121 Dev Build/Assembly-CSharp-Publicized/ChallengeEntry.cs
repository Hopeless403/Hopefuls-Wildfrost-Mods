// Decompiled with JetBrains decompiler
// Type: ChallengeEntry
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using TMPro;
using UnityEngine;
using UnityEngine.Localization.Components;
using UnityEngine.UI;

#nullable disable
public class ChallengeEntry : MonoBehaviour
{
  [SerializeField]
  public LocalizeStringEvent text;
  [SerializeField]
  public TMP_Text progressText;
  [SerializeField]
  public LocalizeStringEvent rewardText;
  [SerializeField]
  public Image background;
  [SerializeField]
  public Image rewardIcon;
  public ChallengeData challenge;

  public void Assign(ChallengeData challenge, bool completed)
  {
    this.challenge = challenge;
    this.text.StringReference = challenge.textKey;
    if (completed && (bool) (Object) this.rewardText)
      this.rewardText.StringReference = challenge.rewardKey;
    if (!(bool) (Object) this.rewardIcon)
      return;
    this.rewardIcon.sprite = challenge.icon;
  }

  public void SetProgress(int progress)
  {
    this.progressText.text = string.Format("{0}/{1}", (object) progress, (object) this.challenge.goal);
  }

  public void SetText(string str)
  {
    TMP_Text component = this.text.GetComponent<TMP_Text>();
    if (component == null)
      return;
    component.text = str.Format((object) this.challenge.listener.target);
  }
}
