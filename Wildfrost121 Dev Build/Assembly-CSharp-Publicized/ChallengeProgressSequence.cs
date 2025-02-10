// Decompiled with JetBrains decompiler
// Type: ChallengeProgressSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

#nullable disable
public class ChallengeProgressSequence : MonoBehaviour
{
  [SerializeField]
  public ChallengeProgressDisplay progressPrefab;
  [SerializeField]
  public ChallengeProgressSequence.Profile[] profiles;
  [SerializeField]
  public Transform progressGroup;
  public readonly List<ChallengeProgressDisplay> panels = new List<ChallengeProgressDisplay>();
  [CompilerGenerated]
  public bool \u003Crunning\u003Ek__BackingField;

  public bool running
  {
    get => this.\u003Crunning\u003Ek__BackingField;
    set => this.\u003Crunning\u003Ek__BackingField = value;
  }

  public IEnumerator Start()
  {
    this.running = true;
    ChallengeProgressSystem objectOfType = UnityEngine.Object.FindObjectOfType<ChallengeProgressSystem>();
    if (objectOfType != null)
    {
      List<ChallengeProgress> progress1 = objectOfType.progress;
      if (progress1 != null)
      {
        foreach (ChallengeProgress progress2 in progress1.Where<ChallengeProgress>((Func<ChallengeProgress, bool>) (a => a.currentValue > a.originalValue)))
        {
          yield return (object) this.AddDisplay(progress2);
          yield return (object) new WaitForSeconds(0.5f);
        }
      }
    }
    this.running = false;
  }

  public IEnumerator AddDisplay(ChallengeProgress progress)
  {
    ChallengeProgressDisplay panel = UnityEngine.Object.Instantiate<ChallengeProgressDisplay>(this.progressPrefab, this.progressGroup);
    this.panels.Insert(0, panel);
    this.UpdatePanelPositions();
    ChallengeData challengeData = AddressableLoader.Get<ChallengeData>("ChallengeData", progress.challengeName);
    panel.Assign(challengeData);
    panel.SetFill((float) progress.originalValue, challengeData.goal);
    yield return (object) new WaitForSeconds(0.5f);
    int fillTo = Mathf.Min(challengeData.goal, progress.currentValue);
    float num = Mathf.Lerp(Mathf.Clamp((float) fillTo / (float) challengeData.goal, 0.0f, 1f) * 2f, 1f, 0.5f);
    Events.InvokeProgressStart((float) progress.originalValue / (float) challengeData.goal);
    panel.animator.SetBool("Increasing", true);
    LeanTween.value(panel.gameObject, (float) progress.originalValue, (float) fillTo, num).setEaseOutQuad().setOnUpdate((Action<float>) (a =>
    {
      panel.SetFill(a, challengeData.goal);
      panel.SetRemainingText(challengeData, a);
    }));
    yield return (object) new WaitForSeconds(num);
    panel.animator.SetBool("Increasing", false);
    Events.InvokeProgressStop();
    if (fillTo >= challengeData.goal)
    {
      Events.InvokeProgressDing();
      panel.animator.SetTrigger("Ping");
      panel.SetRewardText(challengeData);
      yield return (object) new WaitForSeconds(1.5f);
    }
  }

  public void UpdatePanelPositions()
  {
    float y = 0.0f;
    int a = 0;
    foreach (ChallengeProgressDisplay panel in this.panels)
    {
      ChallengeProgressSequence.Profile profile = this.profiles[Mathf.Min(a, this.profiles.Length - 1)];
      panel.SetColor(profile.color);
      if (a > 0)
      {
        LeanTween.cancel(panel.gameObject);
        LeanTween.moveLocal(panel.gameObject, new Vector3(0.0f, y, 0.0f), 0.2f).setEase(LeanTweenType.easeOutQuint);
        LeanTween.scale(panel.gameObject, Vector3.one * profile.scale, 0.2f).setEase(LeanTweenType.easeOutQuint);
        panel.icon.gameObject.SetActive(false);
        panel.back.gameObject.SetActive(false);
        panel.progressText.gameObject.SetActive(false);
      }
      y -= 1.3f * profile.scale;
      ++a;
    }
  }

  [Serializable]
  public struct Profile
  {
    public float scale;
    public Color color;
  }
}
