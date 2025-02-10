// Decompiled with JetBrains decompiler
// Type: TurnOrderButton
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TurnOrderButton : MonoBehaviour
{
  [SerializeField]
  private ButtonAnimator button;
  [SerializeField]
  private Image image;
  [SerializeField]
  private Sprite openSprite;
  [SerializeField]
  private Sprite closedSprite;
  [SerializeField]
  private ParticleSystem particleSystem;

  private void Awake()
  {
    global::Events.OnSceneChanged += new UnityAction<Scene>(this.SceneChanged);
    this.SetActive(false);
  }

  private void OnDestroy() => global::Events.OnSceneChanged -= new UnityAction<Scene>(this.SceneChanged);

  private void OnEnable()
  {
    global::Events.OnCardControllerEnabled += new UnityAction<CardController>(this.CardControllerEnabled);
    global::Events.OnCardControllerDisabled += new UnityAction<CardController>(this.CardControllerDisabled);
  }

  private void OnDisable()
  {
    global::Events.OnCardControllerEnabled -= new UnityAction<CardController>(this.CardControllerEnabled);
    global::Events.OnCardControllerDisabled -= new UnityAction<CardController>(this.CardControllerDisabled);
  }

  private void CardControllerEnabled(CardController controller)
  {
    if (!(bool) (Object) References.Battle || !((Object) controller == (Object) References.Battle.playerCardController))
      return;
    this.button.interactable = true;
  }

  private void CardControllerDisabled(CardController controller)
  {
    if (!(bool) (Object) References.Battle || !((Object) controller == (Object) References.Battle.playerCardController))
      return;
    this.button.interactable = false;
  }

  private void SceneChanged(Scene scene) => this.SetActive(scene.name == "Battle");

  private void SetActive(bool value)
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
