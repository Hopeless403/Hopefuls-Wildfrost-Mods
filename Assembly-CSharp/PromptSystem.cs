// Decompiled with JetBrains decompiler
// Type: PromptSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using FMODUnity;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class PromptSystem : GameSystem
{
  private static PromptSystem instance;
  [SerializeField]
  private Prompt prompt;
  [SerializeField]
  private EventReference popUpSfx;
  [SerializeField]
  private EventReference denySfx;

  public static Prompt Prompt => PromptSystem.instance.prompt;

  public static void SetSortingLayer(string layerName, int sortingOrder)
  {
    Canvas component = PromptSystem.instance.GetComponent<Canvas>();
    if (!(bool) (Object) component)
      return;
    component.sortingLayerName = layerName;
    component.sortingOrder = sortingOrder;
  }

  private void OnEnable()
  {
    global::Events.OnSceneChanged += new UnityAction<Scene>(this.SceneChanged);
    PromptSystem.instance = this;
  }

  private void OnDisable() => global::Events.OnSceneChanged -= new UnityAction<Scene>(this.SceneChanged);

  private void SceneChanged(Scene scene)
  {
    if (!(bool) (Object) this.prompt || !this.prompt.gameObject.activeSelf)
      return;
    this.prompt.gameObject.SetActive(false);
  }

  public static void Create(
    Prompt.Anchor anchor,
    Vector2 anchoredPosition,
    float maxWidth,
    Prompt.Emote.Type emoteType = Prompt.Emote.Type.Basic,
    Prompt.Emote.Position emotePosition = Prompt.Emote.Position.Above)
  {
    if (!(bool) (Object) PromptSystem.instance)
      return;
    PromptSystem.instance.DoCreate(anchor, anchoredPosition, maxWidth, emoteType, emotePosition);
  }

  public static void Create(
    Prompt.Anchor anchor,
    float x,
    float y,
    float maxWidth,
    Prompt.Emote.Type emoteType = Prompt.Emote.Type.Basic,
    Prompt.Emote.Position emotePosition = Prompt.Emote.Position.Above)
  {
    PromptSystem.Create(anchor, new Vector2(x, y), maxWidth, emoteType, emotePosition);
  }

  public static void SetTextAction(Prompt.GetTextCallback action)
  {
    PromptSystem.Prompt.SetTextAction = action;
    PromptSystem.Prompt.RunSetTextAction();
  }

  private void DoCreate(
    Prompt.Anchor anchor,
    Vector2 anchoredPosition,
    float maxWidth,
    Prompt.Emote.Type emoteType = Prompt.Emote.Type.Basic,
    Prompt.Emote.Position emotePosition = Prompt.Emote.Position.Above)
  {
    this.prompt.Enable();
    this.prompt.SetPosition(anchoredPosition, anchor);
    this.prompt.SetMaxWidth(maxWidth);
    this.prompt.SetEmote(emoteType, emotePosition);
    this.prompt.Ping();
    SfxSystem.OneShot(this.popUpSfx);
    SfxSystem.OneShot("event:/sfx/map/location_showup");
  }

  public static void Hide() => Object.FindObjectOfType<PromptSystem>()?.DoHide();

  private void DoHide()
  {
    if (!(bool) (Object) this.prompt || !this.prompt.active)
      return;
    this.prompt.Hide();
  }

  public static void Shake()
  {
    if (!(bool) (Object) PromptSystem.instance)
      return;
    GameObject gameObject = PromptSystem.instance.gameObject;
    LeanTween.cancel(gameObject);
    gameObject.transform.localPosition = new Vector3(0.25f, 0.0f, -3f);
    LeanTween.moveLocal(gameObject, new Vector3(0.0f, 0.0f, -3f), 1f).setEase(LeanTweenType.easeOutElastic);
    SfxSystem.OneShot(PromptSystem.instance.denySfx);
  }
}
