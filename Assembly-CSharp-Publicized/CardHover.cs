// Decompiled with JetBrains decompiler
// Type: CardHover
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using NaughtyAttributes;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CardHover : 
  MonoBehaviour,
  IPointerEnterHandler,
  IEventSystemHandler,
  IPointerExitHandler,
  IPointerAfterExitHandler
{
  [SerializeField]
  public bool IsMaster = true;
  [HideIf("IsMaster")]
  public CardHover master;
  [SerializeField]
  [ShowIf("IsMaster")]
  public GraphicRaycaster graphicRaycaster;
  [SerializeField]
  [ShowIf("IsMaster")]
  public Entity entity;
  [SerializeField]
  [ShowIf("IsMaster")]
  public bool disableWhileDragging = true;
  [SerializeField]
  [ShowIf("IsMaster")]
  public Flipper flipper;
  public UnityEvent onHover;
  public UnityEvent onUnHover;
  [Header("Pop up \"Keyword\" description(s) while mouse over")]
  [SerializeField]
  public CardPopUpTarget pop;
  [Header("Mouse Over This Element?")]
  [SerializeField]
  [ReadOnly]
  public bool mouseOver;
  [SerializeField]
  [ReadOnly]
  public int childMouseOverCount;
  public bool preMouseOver;
  [Header("Entity assigned as \"Hovering\"? (set by CardControllers)")]
  [ReadOnly]
  public bool hovering;
  [ShowIf("IsMaster")]
  public CardController controller;
  public bool hoverable = true;
  public bool dragging;
  public bool hasPop;
  [CompilerGenerated]
  public bool \u003CWasHovering\u003Ek__BackingField;

  public bool IsHovering => !this.IsMaster ? this.master.hovering : this.hovering;

  public bool IsHoverable => !this.IsMaster ? this.master.hoverable : this.hoverable;

  public bool IsMouseOver => this.mouseOver || this.childMouseOverCount > 0;

  public bool CanHover => this.enabled && (bool) (Object) this.controller && this.controller.enabled && !this.flipper.flipped && this.IsHoverable;

  public bool WasHovering
  {
    get => this.\u003CWasHovering\u003Ek__BackingField;
    set => this.\u003CWasHovering\u003Ek__BackingField = value;
  }

  public void Awake() => this.hasPop = (bool) (Object) this.pop;

  public void OnEnable()
  {
    this.hoverable = true;
    this.hovering = false;
    this.mouseOver = false;
    if (this.IsMaster)
      this.graphicRaycaster.enabled = true;
    global::Events.OnUpdateInputSystem += new UnityAction<bool>(this.UpdateInputSystem);
    global::Events.OnCardControllerEnabled += new UnityAction<CardController>(this.CardControllerEnabled);
  }

  public void OnDisable()
  {
    if (this.mouseOver && !this.IsMaster)
    {
      this.mouseOver = false;
      this.master.childMouseOverCount = Mathf.Max(0, this.master.childMouseOverCount - 1);
    }
    if (this.hasPop && (bool) (Object) this.pop && this.pop.popped)
      this.pop.UnPop();
    global::Events.OnUpdateInputSystem -= new UnityAction<bool>(this.UpdateInputSystem);
    global::Events.OnCardControllerEnabled -= new UnityAction<CardController>(this.CardControllerEnabled);
  }

  public void Update()
  {
    if (!this.hasPop || this.mouseOver && this.IsHovering)
      return;
    if ((bool) (Object) this.pop)
    {
      if (!this.pop.popped)
        return;
      this.pop.UnPop();
    }
    else
      this.hasPop = false;
  }

  public void LateUpdate()
  {
    this.WasHovering = this.IsHovering;
    if (this.IsMaster)
    {
      bool isMouseOver = this.IsMouseOver;
      if (isMouseOver && !this.preMouseOver)
        this.Hover();
      else if (!isMouseOver && this.preMouseOver)
        this.UnHover();
      this.preMouseOver = isMouseOver;
    }
    if (this.mouseOver && this.IsHovering && this.hasPop)
    {
      if ((bool) (Object) this.pop)
      {
        if (!this.pop.popped)
          this.pop.Pop();
      }
      else
        this.hasPop = false;
    }
    if (!this.IsMaster || !this.disableWhileDragging || this.entity.dragging == this.dragging)
      return;
    this.dragging = this.entity.dragging;
    if (this.dragging)
      this.Disable();
    else
      this.Enable();
  }

  public void UpdateInputSystem(bool forceTouch)
  {
    if (!this.IsMaster || !this.IsMouseOver)
      return;
    this.preMouseOver = false;
  }

  public void CardControllerEnabled(CardController controller)
  {
    if (!this.mouseOver || !((Object) controller == (Object) this.controller))
      return;
    controller.Hover(this.IsMaster ? this.entity : this.master.entity);
  }

  public void CheckHover()
  {
    if (!this.IsMouseOver || this.preMouseOver)
      return;
    this.Hover();
    this.preMouseOver = true;
  }

  public void CheckUnHover()
  {
    if (this.IsMouseOver || !this.preMouseOver)
      return;
    this.UnHover();
    this.preMouseOver = false;
  }

  public void Enable()
  {
    this.graphicRaycaster.enabled = true;
    global::Events.InvokeUpdateInputSystem(false);
  }

  public void Disable()
  {
    this.graphicRaycaster.enabled = false;
    this.ForceUnHover();
    global::Events.InvokeUpdateInputSystem(false);
  }

  public void SetHoverable(bool value)
  {
    this.hoverable = value;
    if (this.hoverable)
      return;
    this.ForceUnHover();
  }

  public void Hover()
  {
    if (!this.CanHover)
      return;
    this.controller.Hover(this.entity);
    this.onHover?.Invoke();
  }

  public void UnHover()
  {
    if (!this.enabled || !(bool) (Object) this.controller || !this.controller.enabled || !((Object) this.controller.hoverEntity == (Object) this.entity))
      return;
    this.controller.UnHover(this.entity);
    this.onUnHover?.Invoke();
  }

  public void ForceUnHover()
  {
    this.mouseOver = false;
    this.preMouseOver = false;
    this.UnHover();
  }

  public void OnPointerEnter(PointerEventData eventData)
  {
    if (this.mouseOver || !this.hoverable || !MonoBehaviourSingleton<Cursor3d>.instance.usingMouse && (bool) (Object) UINavigationSystem.ActiveNavigationLayer && !UINavigationSystem.ActiveNavigationLayer.forceHover)
      return;
    this.mouseOver = true;
    if (this.IsMaster)
    {
      this.CheckHover();
    }
    else
    {
      ++this.master.childMouseOverCount;
      this.master.CheckHover();
    }
  }

  public void OnPointerExit(PointerEventData eventData)
  {
    if (!this.mouseOver)
      return;
    this.mouseOver = false;
    if (this.IsMaster)
      return;
    this.master.childMouseOverCount = Mathf.Max(0, this.master.childMouseOverCount - 1);
  }

  public void OnPointerAfterExit(PointerEventData eventData)
  {
    if (this.IsMaster)
      this.CheckUnHover();
    else
      this.master.CheckUnHover();
  }
}
