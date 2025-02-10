// Decompiled with JetBrains decompiler
// Type: CardControllerCardOrganizer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

public class CardControllerCardOrganizer : CardController
{
  [Header("Plane to store positions in")]
  [SerializeField]
  public CardPlane cardPlane;
  [Header("Snap To Grid")]
  [SerializeField]
  public Vector2 snapOffset;
  [SerializeField]
  public Vector2 snapSize = new Vector2(3.8f, 5.5f);

  public override void Press()
  {
    if (!(bool) (Object) this.pressEntity || !this.TryDrag(this.pressEntity))
      return;
    this.pressEntity.transform.SetAsLastSibling();
  }

  public override void Release()
  {
    if (!((Object) this.dragging != (Object) null))
      return;
    Vector3 position = (this.GetDragPosition() - this.dragging.transform.parent.position).WithZ(0.0f);
    if (Input.GetButton("Snap"))
      position = this.Snap(position);
    this.dragging.transform.localPosition = position;
    this.cardPlane?.StorePosition(this.dragging);
    this.dragging.gameObject.layer = this.draggingLayerPre;
    this.dragging.dragging = false;
    this.TweenUnHover(this.dragging);
    this.DragEnd();
  }

  public override void DragUpdatePosition()
  {
    Vector3 vector3 = (this.GetDragPosition() - this.dragging.transform.parent.position).WithZ(this.dragZ);
    if (Input.GetButton("Snap"))
      vector3 = this.Snap(vector3);
    this.dragging.transform.localPosition = Delta.Lerp(this.dragging.transform.localPosition, vector3, this.dragLerp, Time.deltaTime);
  }

  public Vector3 Snap(Vector3 position)
  {
    position.x = Mathf.Round((position.x + this.snapOffset.x) / this.snapSize.x) * this.snapSize.x - this.snapOffset.x;
    position.y = Mathf.Round((position.y + this.snapOffset.y) / this.snapSize.y) * this.snapSize.y - this.snapOffset.y;
    return position;
  }
}
