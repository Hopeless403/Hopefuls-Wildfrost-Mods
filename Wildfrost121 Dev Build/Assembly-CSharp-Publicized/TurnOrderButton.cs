// Decompiled with JetBrains decompiler
// Type: TurnOrderButton
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

#nullable disable
public class TurnOrderButton : MonoBehaviour
{
  [SerializeField]
  public ButtonAnimator button;
  [SerializeField]
  public Image image;
  [SerializeField]
  public Sprite openSprite;
  [SerializeField]
  public Sprite closedSprite;
  [SerializeField]
  public ParticleSystem particleSystem;

  public void Awake()
  {
    global::Events.OnSceneChanged += new UnityAction<Scene>(this.SceneChanged);
    this.SetActive(false);
  }

  public void OnDestroy() => global::Events.OnSceneChanged -= new UnityAction<Scene>(this.SceneChanged);

  public void OnEnable()
  {
    global::Events.OnCardControllerEnabled += new UnityAction<CardController>(this.CardControllerEnabled);
    global::Events.OnCardControllerDisabled += new UnityAction<CardController>(this.CardControllerDisabled);
  }

  public void OnDisable()
  {
    global::Events.OnCardControllerEnabled -= new UnityAction<CardController>(this.CardControllerEnabled);
    global::Events.OnCardControllerDisabled -= new UnityAction<CardController>(this.CardControllerDisabled);
  }

  public void CardControllerEnabled(CardController controller)
  {
    if (!(bool) (Object) References.Battle || !((Object) controller == (Object) References.Battle.playerCardController))
      return;
    this.button.interactable = true;
  }

  public void CardControllerDisabled(CardController controller)
  {
    if (!(bool) (Object) References.Battle || !((Object) controller == (Object) References.Battle.playerCardController))
      return;
    this.button.interactable = false;
  }

  public void SceneChanged(Scene scene) => this.SetActive(scene.name == "Battle");

  public void SetActive(bool value)
  {
    this.gameObject.SetActive(value);
    this.button.interactable = value;
    this.CloseEye();
    this.button.interactable = false;
  }

  public void Select()
  {
    if (!ActionQueue.Empty || (bool) (Object) References.Battle && (bool) (Object) References.Battle.playerCardController.dragging)
      return;
    Object.FindObjectOfType<TurnOrderDisplay>()?.Toggle();
  }

  public void OpenEye()
  {
    this.image.sprite = this.openSprite;
    this.particleSystem.Play();
  }

  public void CloseEye()
  {
    this.image.sprite = this.closedSprite;
    this.particleSystem.Stop();
  }
}
