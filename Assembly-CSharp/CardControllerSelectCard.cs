// Decompiled with JetBrains decompiler
// Type: CardControllerSelectCard
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.Events;

public class CardControllerSelectCard : CardController
{
  [Header("Press Tween")]
  public float cardPressScaleFrom = 0.8f;
  public float cardPressScaleTo = 1f;
  public LeanTweenType cardPressEase = LeanTweenType.easeOutElastic;
  public float cardPressEaseDur = 1f;
  public float cardPressWobble = 1f;
  public UnityEventEntity pressEvent;
  public UnityEventEntity hoverEvent;
  public UnityEventEntity unHoverEvent;

  protected override bool AllowDynamicSelectRelease => false;

  private void OnEnable()
  {
    global::Events.OnEntityHover += new UnityAction<Entity>(this.CardHover);
    global::Events.OnEntityUnHover += new UnityAction<Entity>(this.CardUnHover);
  }

  private void OnDisable()
  {
    global::Events.OnEntityHover -= new UnityAction<Entity>(this.CardHover);
    global::Events.OnEntityUnHover -= new UnityAction<Entity>(this.CardUnHover);
  }

  protected override void Press()
  {
    if (!this.canPress || !(bool) (Object) this.pressEntity || this.pressEntity.inPlay)
      return;
    Debug.Log((object) ("Pressing [" + this.pressEntity.name + "]"));
    this.TweenHover(this.pressEntity);
    if ((double) this.cardPressEaseDur > 0.0)
      LeanTween.scale(this.pressEntity.offset.gameObject, Vector3.one * this.cardPressScaleTo, this.cardPressEaseDur).setFrom(Vector3.one * this.cardPressScaleFrom).setEase(this.cardPressEase);
    if ((double) this.cardPressWobble == 0.0)
      return;
    this.pressEntity.wobbler?.WobbleRandom(this.cardPressWobble);
  }

  protected override void Release()
  {
    if (!(bool) (Object) this.pressEntity || !((Object) this.hoverEntity == (Object) this.pressEntity) || this.pressEntity.inPlay)
      return;
    Debug.Log((object) string.Format("[{0}] PRESSING [{1}]! :D", (object) this, (object) this.pressEntity));
    Entity pressEntity = this.pressEntity;
    this.pressEntity = (Entity) null;
    this.pressEvent.Invoke(pressEntity);
  }

  private void CardHover(Entity entity) => this.hoverEvent.Invoke(entity);

  private void CardUnHover(Entity entity) => this.unHoverEvent.Invoke(entity);
}
