// Decompiled with JetBrains decompiler
// Type: CardPocket
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections.Generic;
using UnityEngine;

#nullable disable
public class CardPocket : CardContainer
{
  [SerializeField]
  private Transform slideInPosition;
  [SerializeField]
  private AnimationCurve slideCurve;
  [SerializeField]
  private float slideDuration = 0.5f;
  [SerializeField]
  private float slideDelay = 0.5f;
  [SerializeField]
  private Vector3 randomAngleAmount = new Vector3(0.0f, 0.0f, 1f);
  [SerializeField]
  private CardPocketInteraction interaction;
  [SerializeField]
  private CardContainer[] skipAnimationFromContainers;
  private readonly Dictionary<Entity, CardPocket.PositionHandler> positions = new Dictionary<Entity, CardPocket.PositionHandler>();

  public override void AssignController(CardController controller)
  {
    base.AssignController(controller);
    this.GetComponentInChildren<ToggleBasedOnCardController>(true)?.AssignCardController(controller);
  }

  private void Update()
  {
    foreach (KeyValuePair<Entity, CardPocket.PositionHandler> position in this.positions)
    {
      if (!position.Value.IsFinished)
        position.Value.Update(Time.deltaTime);
    }
  }

  public override void SetSize(int size, float cardScale)
  {
    base.SetSize(size, cardScale);
    this.holder.sizeDelta = GameManager.CARD_SIZE * cardScale;
  }

  public override Vector3 GetChildPosition(Entity child) => this.positions[child].GetPosition();

  public override Vector3 GetChildRotation(Entity child)
  {
    return Vector3.Scale(child.random3, this.randomAngleAmount);
  }

  public Vector3 GetFinalChildPosition(Entity child)
  {
    int num1 = this.IndexOf(child);
    float num2 = 0.0f;
    float num3 = 0.0f;
    double x = 0.0 + (double) this.gap.x * (double) num1;
    float num4 = num2 + this.gap.y * (float) num1;
    float num5 = num3 + this.gap.z * (float) num1;
    double y = (double) num4;
    double z = (double) num5;
    return new Vector3((float) x, (float) y, (float) z);
  }

  public override void Hover()
  {
    base.Hover();
    if (!(bool) (Object) this.interaction)
      return;
    this.interaction.Hover();
  }

  public override void UnHover()
  {
    base.UnHover();
    if (!(bool) (Object) this.interaction)
      return;
    this.interaction.UnHover();
  }

  protected override void CardAdded(Entity entity)
  {
    base.CardAdded(entity);
    entity.enabled = false;
    if ((bool) (Object) entity.uINavigationItem)
    {
      entity.uINavigationItem.isSelectable = false;
      entity.uINavigationItem.enabled = false;
    }
    if ((bool) (Object) entity.flipper)
      entity.flipper.FlipDown();
    CardPocket.PositionHandler positionHandler = new CardPocket.PositionHandler(this, entity, this.slideInPosition.localPosition, this.GetFinalChildPosition(entity), this.slideCurve, this.slideDuration, this.slideDelay);
    this.positions.Add(entity, positionHandler);
    if (entity.preContainers == null || entity.preContainers.Length == 0)
    {
      positionHandler.Skip();
    }
    else
    {
      foreach (CardContainer preContainer in entity.preContainers)
      {
        if (this.skipAnimationFromContainers.Contains<CardContainer>(preContainer))
        {
          positionHandler.Skip();
          break;
        }
      }
    }
  }

  protected override void CardRemoved(Entity entity)
  {
    base.CardRemoved(entity);
    if ((bool) (Object) entity.uINavigationItem)
    {
      entity.uINavigationItem.isSelectable = true;
      entity.uINavigationItem.enabled = true;
    }
    this.positions.Remove(entity);
  }

  public class PositionHandler
  {
    private readonly CardPocket pocket;
    private readonly Entity entity;
    private readonly Vector3 startPosition;
    private readonly Vector3 positionChange;
    private readonly AnimationCurve curve;
    private readonly float duration;
    private float delay;
    private float t;

    public bool IsFinished => (double) this.t >= (double) this.duration;

    public PositionHandler(
      CardPocket pocket,
      Entity entity,
      Vector3 fromPosition,
      Vector3 toPosition,
      AnimationCurve slideCurve,
      float slideDuration,
      float slideDelay)
    {
      this.pocket = pocket;
      this.entity = entity;
      this.startPosition = fromPosition;
      this.positionChange = toPosition - fromPosition;
      this.curve = slideCurve;
      this.duration = slideDuration;
      this.delay = slideDelay;
      this.t = 0.0f;
    }

    public Vector3 GetPosition()
    {
      return this.startPosition + this.positionChange * this.curve.Evaluate(this.t / this.duration);
    }

    public void Skip()
    {
      this.t = this.duration;
      this.Update(0.0f);
    }

    public void Update(float delta)
    {
      if ((double) this.delay > 0.0)
      {
        this.delay -= delta;
        if ((double) this.delay > 0.0)
          return;
        Events.InvokeEntityEnterPocket(this.entity, this.pocket);
      }
      else
      {
        this.t += delta;
        this.entity.transform.localPosition = this.GetPosition();
      }
    }
  }
}
