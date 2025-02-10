// Decompiled with JetBrains decompiler
// Type: CardControllerSelectCard
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

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

  public override bool AllowDynamicSelectRelease => false;

  public new void OnEnable()
  {
    global::Events.OnEntityHover += new UnityAction<Entity>(this.CardHover);
    global::Events.OnEntityUnHover += new UnityAction<Entity>(this.CardUnHover);
  }

  public new void OnDisable()
  {
    global::Events.OnEntityHover -= new UnityAction<Entity>(this.CardHover);
    global::Events.OnEntityUnHover -= new UnityAction<Entity>(this.CardUnHover);
  }

  public override void Press()
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

  public override void Release()
  {
    if (!(bool) (Object) this.pressEntity || !((Object) this.hoverEntity == (Object) this.pressEntity) || this.pressEntity.inPlay)
      return;
    Debug.Log((object) string.Format("[{0}] PRESSING [{1}]! :D", (object) this, (object) this.pressEntity));
    Entity pressEntity = this.pressEntity;
    this.pressEntity = (Entity) null;
    this.pressEvent.Invoke(pressEntity);
  }

  public void CardHover(Entity entity) => this.hoverEvent.Invoke(entity);

  public void CardUnHover(Entity entity) => this.unHoverEvent.Invoke(entity);
}
