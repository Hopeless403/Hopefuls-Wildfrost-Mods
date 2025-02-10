// Decompiled with JetBrains decompiler
// Type: ChallengeEntry
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using TMPro;
using UnityEngine;
using UnityEngine.Localization.Components;
using UnityEngine.UI;

#nullable disable
public class ChallengeEntry : MonoBehaviour
{
  [SerializeField]
  private LocalizeStringEvent text;
  [SerializeField]
  private TMP_Text progressText;
  [SerializeField]
  private LocalizeStringEvent rewardText;
  [SerializeField]
  private Image background;
  [SerializeField]
  private Image rewardIcon;
  private ChallengeData challenge;

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
