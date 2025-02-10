// Decompiled with JetBrains decompiler
// Type: CardControllerDragger
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

#nullable disable
public class CardControllerDragger : CardController
{
  [Header("Dragging")]
  public bool canDrag = true;
  public UnityEventEntity onDrag;
  public UnityEventEntity onRelease;
  public UnityEventEntity onCancel;

  public override void Press()
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

  public override void Release()
  {
    if (!(bool) (Object) this.dragging)
      return;
    this.onRelease?.Invoke(this.dragging);
    this.DragEnd();
  }

  public override void DragEnd()
  {
    this.dragging.TweenToContainer();
    this.TweenUnHover(this.dragging);
    base.DragEnd();
  }
}
