// Decompiled with JetBrains decompiler
// Type: GameUpdateDisplayer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Localization;
using UnityEngine.Localization.Components;
using UnityEngine.SceneManagement;

public class GameUpdateDisplayer : MonoBehaviour
{
  [SerializeField]
  private GameObject display;
  [SerializeField]
  private SmoothScrollRect scrollRect;
  [SerializeField]
  private LocalizeStringEvent titleEvent;
  [SerializeField]
  private LocalizeStringEvent bodyEvent;
  [SerializeField]
  private GameUpdateDisplayer.Update[] updates;
  [Header("Beta Version")]
  [SerializeField]
  private GameUpdateDisplayer.Update beta;

  private void OnEnable()
  {
    this.display.SetActive(false);
    global::Events.OnSceneChanged += new UnityAction<Scene>(this.SceneChanged);
  }

  private void OnDisable() => global::Events.OnSceneChanged -= new UnityAction<Scene>(this.SceneChanged);

  private void SceneChanged(Scene scene)
  {
    if (!(scene.name == "MainMenu"))
      return;
    this.Check();
  }

  private void Check()
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

  private IEnumerator ShowRoutine(GameUpdateDisplayer.Update update)
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
  private struct Update
  {
    public string buildNumber;
    public LocalizedString titleRef;
    public LocalizedString bodyRef;
    public float panelHeight;
  }
}
