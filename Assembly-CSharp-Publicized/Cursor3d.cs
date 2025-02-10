// Decompiled with JetBrains decompiler
// Type: Cursor3d
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Runtime.CompilerServices;
using UnityEngine;

public class Cursor3d : MonoBehaviourSingleton<Cursor3d>
{
  public Camera _cam;
  public LayerMask layerMask;
  public bool usingMouse = true;
  public bool usingTouch;
  public GameObject mouseObj;
  public bool showVirtualPointerState = true;
  [CompilerGenerated]
  public static Vector3 \u003CPosition\u003Ek__BackingField;
  [CompilerGenerated]
  public static Vector3 \u003CPositionWithZ\u003Ek__BackingField;
  public static readonly Vector3 offset = new Vector3(0.0f, 0.0f, -1f);
  public readonly RaycastHit[] hits = new RaycastHit[1];

  public Camera cam => this._cam ?? (this._cam = Camera.main);

  public static Vector3 Position
  {
    get => Cursor3d.\u003CPosition\u003Ek__BackingField;
    set => Cursor3d.\u003CPosition\u003Ek__BackingField = value;
  }

  public static Vector3 PositionWithZ
  {
    get => Cursor3d.\u003CPositionWithZ\u003Ek__BackingField;
    set => Cursor3d.\u003CPositionWithZ\u003Ek__BackingField = value;
  }

  public void OnEnable() => CustomCursor.UpdateState();

  public void Update()
  {
    if (!this.usingMouse || Physics.RaycastNonAlloc(this.cam.ScreenPointToRay(InputSystem.MousePosition + Cursor3d.offset), this.hits, 1000f, (int) this.layerMask) <= 0)
      return;
    this.SetPosition(this.hits[0].point);
  }

  public Vector2 GetScreenPoint() => (Vector2) this.cam.WorldToScreenPoint(this.transform.position);

  public void SetPosition(Vector3 position)
  {
    this.transform.position = position;
    Cursor3d.PositionWithZ = position;
    Cursor3d.Position = Cursor3d.PositionWithZ.WithZ(0.0f);
  }
}
