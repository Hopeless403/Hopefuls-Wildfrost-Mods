// Decompiled with JetBrains decompiler
// Type: CardControllerDragger
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

#nullable disable
public class CardControllerDragger : CardController
{
  [Header("Dragging")]
  public bool canDrag = true;
  public UnityEventEntity onDrag;
  public UnityEventEntity onRelease;
  public UnityEventEntity onCancel;

  protected override void Press()
  {
    if (!this.canDrag || !(bool) (Object) this.pressEntity || !((Object) this.pressEntity.owner == (Object) this.owner) || !this.TryDrag(this.pressEntity))
      return;
    this.onDrag?.Invoke(this.pressEntity);
  }

  public override void DragCancel()
  {
    if (!(bool) (Object) this.dragging)
      return;
    this.onCancel?.Invoke(this.dragging);
    this.DragEnd();
  }

  protected override void Release()
  {
    if (!(bool) (Object) this.dragging)
      return;
    this.onRelease?.Invoke(this.dragging);
    this.DragEnd();
  }

  protected override void DragEnd()
  {
    this.dragging.TweenToContainer();
    this.TweenUnHover(this.dragging);
    base.DragEnd();
  }
}
