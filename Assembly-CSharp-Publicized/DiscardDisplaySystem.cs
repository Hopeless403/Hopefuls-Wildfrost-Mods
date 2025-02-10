// Decompiled with JetBrains decompiler
// Type: DiscardDisplaySystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class DiscardDisplaySystem : GameSystem
{
  [SerializeField]
  public Transform display;
  [SerializeField]
  public TweenUI showTween;
  [SerializeField]
  public TweenUI hideTween;
  public Entity entityDrag;
  public CardContainer hoverDiscardContainer;
  public bool draggingCanDiscard;

  public void OnEnable()
  {
    global::Events.OnEntityDrag += new UnityAction<Entity>(this.EntityDrag);
    global::Events.OnEntityRelease += new UnityAction<Entity>(this.EntityRelease);
    global::Events.OnContainerHover += new UnityAction<CardContainer>(this.ContainerHover);
    global::Events.OnContainerUnHover += new UnityAction<CardContainer>(this.ContainerUnHover);
  }

  public void OnDisable()
  {
    global::Events.OnEntityDrag -= new UnityAction<Entity>(this.EntityDrag);
    global::Events.OnEntityRelease -= new UnityAction<Entity>(this.EntityRelease);
    global::Events.OnContainerHover -= new UnityAction<CardContainer>(this.ContainerHover);
    global::Events.OnContainerUnHover -= new UnityAction<CardContainer>(this.ContainerUnHover);
  }

  public void EntityDrag(Entity entity)
  {
    this.entityDrag = entity;
    this.draggingCanDiscard = entity.CanRecall();
  }

  public void EntityRelease(Entity entity)
  {
    if (!((Object) this.entityDrag == (Object) entity))
      return;
    this.entityDrag = (Entity) null;
    this.Hide();
  }

  public void ContainerHover(CardContainer container)
  {
    if (!((Object) this.entityDrag != (Object) null) || !this.draggingCanDiscard || !((Object) container != (Object) null) || !((Object) this.entityDrag.owner != (Object) null) || !((Object) container == (Object) this.entityDrag.owner.discardContainer))
      return;
    this.hoverDiscardContainer = container;
    this.display.position = container.transform.position;
    this.Show();
  }

  public void ContainerUnHover(CardContainer container)
  {
    if (!((Object) this.hoverDiscardContainer == (Object) container))
      return;
    this.hoverDiscardContainer = (CardContainer) null;
    this.Hide();
  }

  public void Show()
  {
    this.display.gameObject.SetActive(true);
    this.showTween?.Fire();
  }

  public void Hide() => this.StartCoroutine(this.HideRoutine());

  public IEnumerator HideRoutine()
  {
    if ((Object) this.hideTween != (Object) null)
    {
      this.hideTween.Fire();
      yield return (object) Sequences.Wait(this.hideTween.GetDuration());
    }
    this.display.gameObject.SetActive(false);
  }
}
