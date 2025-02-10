// Decompiled with JetBrains decompiler
// Type: GameUpdateDisplayer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Localization;
using UnityEngine.Localization.Components;
using UnityEngine.SceneManagement;

#nullable disable
public class GameUpdateDisplayer : MonoBehaviour
{
  [SerializeField]
  public GameObject display;
  [SerializeField]
  public SmoothScrollRect scrollRect;
  [SerializeField]
  public LocalizeStringEvent titleEvent;
  [SerializeField]
  public LocalizeStringEvent bodyEvent;
  [SerializeField]
  public GameUpdateDisplayer.Update[] updates;
  [Header("Beta Version")]
  [SerializeField]
  public GameUpdateDisplayer.Update beta;

  public void OnEnable()
  {
    this.display.SetActive(false);
    global::Events.OnSceneChanged += new UnityAction<Scene>(this.SceneChanged);
  }

  public void OnDisable() => global::Events.OnSceneChanged -= new UnityAction<Scene>(this.SceneChanged);

  public void SceneChanged(Scene scene)
  {
    if (!(scene.name == "MainMenu"))
      return;
    this.Check();
  }

  public void Check()
  {
    VersionCompatibility.GetVersions();
    foreach (GameUpdateDisplayer.Update update in ((IEnumerable<GameUpdateDisplayer.Update>) this.updates).Reverse<GameUpdateDisplayer.Update>())
    {
      int result1;
      if (VersionCompatibility.currentVersion == update.buildNumber && int.TryParse(VersionCompatibility.currentVersion, out result1))
      {
        int result2;
        if (int.TryParse(VersionCompatibility.previousVersion, out result2) && result2 > 0 && result2 < result1)
        {
          this.StartCoroutine(this.ShowRoutine(update));
          return;
        }
        this.Hide();
        return;
      }
    }
    this.Hide();
  }

  public IEnumerator ShowRoutine(GameUpdateDisplayer.Update update)
  {
    this.display.SetActive(true);
    this.titleEvent.StringReference = update.titleRef;
    this.bodyEvent.StringReference = update.bodyRef;
    if (this.scrollRect.transform is RectTransform transform)
      transform.sizeDelta = transform.sizeDelta.WithY(update.panelHeight);
    yield return (object) new WaitForSeconds(0.35f);
    this.scrollRect.ScrollToTop();
  }

  public void Hide()
  {
    this.display.SetActive(false);
    this.gameObject.SetActive(false);
  }

  [Serializable]
  public struct Update
  {
    public string buildNumber;
    public LocalizedString titleRef;
    public LocalizedString bodyRef;
    public float panelHeight;
  }
}
