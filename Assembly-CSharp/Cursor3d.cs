// Decompiled with JetBrains decompiler
// Type: Cursor3d
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

public class Cursor3d : MonoBehaviourSingleton<Cursor3d>
{
  private Camera _cam;
  public LayerMask layerMask;
  public bool usingMouse = true;
  public bool usingTouch;
  public GameObject mouseObj;
  internal bool showVirtualPointerState = true;
  private static readonly Vector3 offset = new Vector3(0.0f, 0.0f, -1f);
  private readonly RaycastHit[] hits = new RaycastHit[1];

  private Camera cam => this._cam ?? (this._cam = Camera.main);

  public static Vector3 Position { get; private set; }

  public static Vector3 PositionWithZ { get; private set; }

  private void OnEnable() => CustomCursor.UpdateState();

  private void Update()
  {
    if (!this.usingMouse || Physics.RaycastNonAlloc(this.cam.ScreenPointToRay(InputSystem.MousePosition + Cursor3d.offset), this.hits, 1000f, (int) this.layerMask) <= 0)
      return;
    this.SetPosition(this.hits[0].point);
  }

  public Vector2 GetScreenPoint() => (Vector2) this.cam.WorldToScreenPoint(this.transform.position);

  internal void SetPosition(Vector3 position)
  {
    this.transform.position = position;
    Cursor3d.PositionWithZ = position;
    Cursor3d.Position = Cursor3d.PositionWithZ.WithZ(0.0f);
  }
}
