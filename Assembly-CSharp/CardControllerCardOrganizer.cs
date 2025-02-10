// Decompiled with JetBrains decompiler
// Type: CardControllerCardOrganizer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

public class CardControllerCardOrganizer : CardController
{
  [Header("Plane to store positions in")]
  [SerializeField]
  private CardPlane cardPlane;
  [Header("Snap To Grid")]
  [SerializeField]
  private Vector2 snapOffset;
  [SerializeField]
  private Vector2 snapSize = new Vector2(3.8f, 5.5f);

  protected override void Press()
  {
    if (!(bool) (Object) this.pressEntity || !this.TryDrag(this.pressEntity))
      return;
    this.pressEntity.transform.SetAsLastSibling();
  }

  protected override void Release()
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

  protected override void DragUpdatePosition()
  {
    Vector3 vector3 = (this.GetDragPosition() - this.dragging.transform.parent.position).WithZ(this.dragZ);
    if (Input.GetButton("Snap"))
      vector3 = this.Snap(vector3);
    this.dragging.transform.localPosition = Delta.Lerp(this.dragging.transform.localPosition, vector3, this.dragLerp, Time.deltaTime);
  }

  private Vector3 Snap(Vector3 position)
  {
    position.x = Mathf.Round((position.x + this.snapOffset.x) / this.snapSize.x) * this.snapSize.x - this.snapOffset.x;
    position.y = Mathf.Round((position.y + this.snapOffset.y) / this.snapSize.y) * this.snapSize.y - this.snapOffset.y;
    return position;
  }
}
