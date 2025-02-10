// Decompiled with JetBrains decompiler
// Type: Hover3dSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections.Generic;
using UnityEngine;

public class Hover3dSystem : GameSystem
{
  public Camera cam;
  [SerializeField]
  public LayerMask layerMask;
  [SerializeField]
  public List<Hoverable3d> hoverList;
  public List<Hoverable3d> newList;
  public readonly RaycastHit[] hits = new RaycastHit[5];

  public void OnEnable()
  {
    this.cam = Camera.main;
    this.hoverList = new List<Hoverable3d>();
    this.newList = new List<Hoverable3d>();
  }

  public void Update()
  {
    int num = Physics.RaycastNonAlloc(this.cam.ScreenPointToRay((Vector3) MonoBehaviourSingleton<Cursor3d>.instance.GetScreenPoint()), this.hits, 100f, (int) this.layerMask);
    for (int index = 0; index < num; ++index)
    {
      Hoverable3d component = this.hits[index].transform.GetComponent<Hoverable3d>();
      if (component != null)
      {
        this.newList.Add(component);
        if (!this.hoverList.Contains(component))
          component.Hover();
      }
    }
    foreach (Hoverable3d hover in this.hoverList)
    {
      if (!this.newList.Contains(hover))
        hover.UnHover();
    }
    this.hoverList.Clear();
    this.hoverList.AddRange((IEnumerable<Hoverable3d>) this.newList);
    this.newList.Clear();
  }
}
