// Decompiled with JetBrains decompiler
// Type: CinemaBarSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
public class CinemaBarSystem : GameSystem
{
  public static CinemaBarSystem _instance;
  [SerializeField]
  public Canvas canvas;
  [SerializeField]
  public CinemaBarSystem.Section top;
  [SerializeField]
  public CinemaBarSystem.Section bottom;
  public static CinemaBarSystem.Section Top;
  public static CinemaBarSystem.Section Bottom;
  public const float from = -1.5f;
  public const float to = 0.4f;
  public const float inDur = 0.5f;
  public const LeanTweenType inEase = LeanTweenType.easeOutBack;
  public const float outDur = 0.2f;
  public const LeanTweenType outEase = LeanTweenType.easeInQuad;

  public static CinemaBarSystem instance
  {
    get
    {
      return CinemaBarSystem._instance ?? (CinemaBarSystem._instance = UnityEngine.Object.FindObjectOfType<CinemaBarSystem>(true));
    }
  }

  public void Awake()
  {
    CinemaBarSystem.Top = this.top;
    CinemaBarSystem.Bottom = this.bottom;
  }

  public void OnEnable()
  {
    global::Events.OnCampaignFinal += new UnityAction(CinemaBarSystem.CampaignFinal);
  }

  public void OnDisable()
  {
    global::Events.OnCampaignFinal -= new UnityAction(CinemaBarSystem.CampaignFinal);
  }

  public static void CampaignFinal()
  {
    CinemaBarSystem.Clear();
    CinemaBarSystem.OutInstant();
  }

  public static void Clear()
  {
    CinemaBarSystem.instance.StopAllCoroutines();
    CinemaBarSystem.Top.Clear();
    CinemaBarSystem.Bottom.Clear();
  }

  public static void SetScript(string text, bool typewriterAnimation)
  {
    string str = "";
    if (text.Contains("|"))
    {
      int length = text.IndexOf('|');
      str = text.Substring(0, length);
      text = text.Substring(length + 1);
    }
    CinemaBarSystem.Top.script.text = str;
    CinemaBarSystem.Bottom.script.text = text;
    CinemaBarSystem.instance.StopAllCoroutines();
    if (!typewriterAnimation)
      return;
    CinemaBarSystem.instance.StartCoroutine(CinemaBarSystem.Typewrite());
  }

  public static IEnumerator Typewrite()
  {
    if (!CinemaBarSystem.Top.script.text.IsNullOrWhitespace())
    {
      CinemaBarSystem.Bottom.script.maxVisibleCharacters = 0;
      yield return (object) CinemaBarSystem.Top.typewriter.Write();
      yield return (object) new WaitForSeconds(1f);
    }
    yield return (object) CinemaBarSystem.Bottom.typewriter.Write();
  }

  public static bool IsActive() => CinemaBarSystem.instance.gameObject.activeSelf;

  public static void In()
  {
    GameObject gameObject = CinemaBarSystem.instance.gameObject;
    gameObject.SetActive(true);
    CinemaBarSystem.Clear();
    LeanTween.cancel(gameObject);
    CinemaBarSystem.SetPosition(-1.5f);
    LeanTween.value(gameObject, -1.5f, 0.4f, 0.5f).setEase(LeanTweenType.easeOutBack).setOnUpdate(new Action<float>(CinemaBarSystem.SetPosition));
  }

  public static void InInstant()
  {
    GameObject gameObject = CinemaBarSystem.instance.gameObject;
    gameObject.SetActive(true);
    CinemaBarSystem.Clear();
    LeanTween.cancel(gameObject);
    CinemaBarSystem.SetPosition(0.4f);
  }

  public static void Out()
  {
    if ((UnityEngine.Object) CinemaBarSystem.instance == (UnityEngine.Object) null || (UnityEngine.Object) CinemaBarSystem.instance.gameObject == (UnityEngine.Object) null || !CinemaBarSystem.instance.gameObject.activeSelf)
      return;
    LeanTween.cancel(CinemaBarSystem.instance.gameObject);
    CinemaBarSystem.SetPosition(0.4f);
    LeanTween.value(CinemaBarSystem.instance.gameObject, 0.4f, -1.5f, 0.2f).setEase(LeanTweenType.easeInQuad).setOnUpdate(new Action<float>(CinemaBarSystem.SetPosition)).setOnComplete((System.Action) (() =>
    {
      CinemaBarSystem.ResetSortingLayer();
      CinemaBarSystem.instance.gameObject.SetActive(false);
    }));
  }

  public static void OutInstant()
  {
    if (!(bool) (UnityEngine.Object) CinemaBarSystem.instance || !(bool) (UnityEngine.Object) CinemaBarSystem.instance.gameObject || !CinemaBarSystem.instance.gameObject.activeSelf)
      return;
    LeanTween.cancel(CinemaBarSystem.instance.gameObject);
    CinemaBarSystem.SetPosition(-1.5f);
    CinemaBarSystem.ResetSortingLayer();
    CinemaBarSystem.instance.gameObject.SetActive(false);
  }

  public static void SetSortingLayer(string name, int orderInLayer = 0)
  {
    CinemaBarSystem.instance.canvas.sortingLayerName = name;
    CinemaBarSystem.instance.canvas.sortingOrder = orderInLayer;
  }

  public static void ResetSortingLayer() => CinemaBarSystem.SetSortingLayer("CinemaBars");

  public static void SetPosition(float value)
  {
    CinemaBarSystem.Top.transform.anchoredPosition = CinemaBarSystem.Top.transform.anchoredPosition.WithY(-value);
    CinemaBarSystem.Bottom.transform.anchoredPosition = CinemaBarSystem.Bottom.transform.anchoredPosition.WithY(value);
  }

  public class State
  {
    public readonly bool wasActive;
    public readonly string topScript;
    public readonly string topPrompt;
    public readonly string topPromptAction;
    public readonly string bottomScript;
    public readonly string bottomPrompt;
    public readonly string bottomPromptAction;
    public readonly string sortingLayerName;
    public readonly int sortingOrderInLayer;

    public State()
    {
      this.wasActive = CinemaBarSystem.IsActive();
      this.topScript = CinemaBarSystem.Top.script.text;
      this.topPrompt = CinemaBarSystem.Top.prompt.text;
      this.topPromptAction = CinemaBarSystem.Top.buttonImage.actionName;
      this.bottomScript = CinemaBarSystem.Bottom.script.text;
      this.bottomPrompt = CinemaBarSystem.Bottom.prompt.text;
      this.bottomPromptAction = CinemaBarSystem.Bottom.buttonImage.actionName;
      this.sortingLayerName = CinemaBarSystem.instance.canvas.sortingLayerName;
      this.sortingOrderInLayer = CinemaBarSystem.instance.canvas.sortingOrder;
    }

    public void Restore()
    {
      bool flag = CinemaBarSystem.IsActive();
      if (flag && !this.wasActive)
        CinemaBarSystem.Out();
      else if (!flag && this.wasActive)
        CinemaBarSystem.In();
      CinemaBarSystem.Top.SetScript(this.topScript);
      CinemaBarSystem.Top.SetPrompt(this.topPrompt, this.topPromptAction);
      CinemaBarSystem.Bottom.SetScript(this.bottomScript);
      CinemaBarSystem.Bottom.SetPrompt(this.bottomPrompt, this.bottomPromptAction);
      CinemaBarSystem.SetSortingLayer(this.sortingLayerName, this.sortingOrderInLayer);
    }
  }

  [Serializable]
  public class Section
  {
    public RectTransform transform;
    public TMP_Text prompt;
    public ControllerButtonImage buttonImage;
    public TMP_Text script;
    public TextTypewrite typewriter;

    public void SetPrompt(string text, string actionName)
    {
      this.prompt.text = text;
      this.buttonImage.Set(actionName);
    }

    public void RemovePrompt() => this.SetPrompt("", "");

    public void SetScript(string text) => this.script.text = text;

    public void RemoveScript() => this.SetScript("");

    public void Clear()
    {
      this.SetPrompt("", "");
      this.SetScript("");
    }
  }
}
