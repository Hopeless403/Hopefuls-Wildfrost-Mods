// Decompiled with JetBrains decompiler
// Type: CardHover
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using NaughtyAttributes;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

#nullable disable
public class CardHover : 
  MonoBehaviour,
  IPointerEnterHandler,
  IEventSystemHandler,
  IPointerExitHandler,
  IPointerAfterExitHandler
{
  [SerializeField]
  private bool IsMaster = true;
  [HideIf("IsMaster")]
  public CardHover master;
  [SerializeField]
  [ShowIf("IsMaster")]
  private GraphicRaycaster graphicRaycaster;
  [SerializeField]
  [ShowIf("IsMaster")]
  internal Entity entity;
  [SerializeField]
  [ShowIf("IsMaster")]
  private bool disableWhileDragging = true;
  [SerializeField]
  [ShowIf("IsMaster")]
  private Flipper flipper;
  public UnityEvent onHover;
  public UnityEvent onUnHover;
  [Header("Pop up \"Keyword\" description(s) while mouse over")]
  [SerializeField]
  private CardPopUpTarget pop;
  [Header("Mouse Over This Element?")]
  [SerializeField]
  [ReadOnly]
  private bool mouseOver;
  [SerializeField]
  [ReadOnly]
  private int childMouseOverCount;
  private bool preMouseOver;
  [Header("Entity assigned as \"Hovering\"? (set by CardControllers)")]
  [ReadOnly]
  public bool hovering;
  [ShowIf("IsMaster")]
  public CardController controller;
  private bool hoverable = true;
  private bool dragging;
  private bool hasPop;

  private bool IsHovering => !this.IsMaster ? this.master.hovering : this.hovering;

  public bool IsHoverable => !this.IsMaster ? this.master.hoverable : this.hoverable;

  private bool IsMouseOver => this.mouseOver || this.childMouseOverCount > 0;

  private bool CanHover
  {
    get
    {
      return this.enabled && (bool) (Object) this.controller && this.controller.enabled && !this.flipper.flipped && this.IsHoverable;
    }
  }

  public bool WasHovering { get; private set; }

  private void Awake() => this.hasPop = (bool) (Object) this.pop;

  private void OnEnable()
  {
    this.hoverable = true;
    this.hovering = false;
    this.mouseOver = false;
    if (this.IsMaster)
      this.graphicRaycaster.enabled = true;
    global::Events.OnUpdateInputSystem += new UnityAction<bool>(this.UpdateInputSystem);
    global::Events.OnCardControllerEnabled += new UnityAction<CardController>(this.CardControllerEnabled);
  }

  private void OnDisable()
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

  private void Update()
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

  private void LateUpdate()
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

  private void UpdateInputSystem(bool forceTouch)
  {
    if (!this.IsMaster || !this.IsMouseOver)
      return;
    this.preMouseOver = false;
  }

  private void CardControllerEnabled(CardController controller)
  {
    if (!this.mouseOver || !((Object) controller == (Object) this.controller))
      return;
    controller.Hover(this.IsMaster ? this.entity : this.master.entity);
  }

  private void CheckHover()
  {
    if (!this.IsMouseOver || this.preMouseOver)
      return;
    this.Hover();
    this.preMouseOver = true;
  }

  private void CheckUnHover()
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

  protected void Hover()
  {
    if (!this.CanHover)
      return;
    this.controller.Hover(this.entity);
    this.onHover?.Invoke();
  }

  protected void UnHover()
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
