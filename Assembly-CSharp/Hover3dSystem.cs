// Decompiled with JetBrains decompiler
// Type: Hover3dSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections.Generic;
using UnityEngine;

public class Hover3dSystem : GameSystem
{
  private Camera cam;
  [SerializeField]
  private LayerMask layerMask;
  [SerializeField]
  private List<Hoverable3d> hoverList;
  private List<Hoverable3d> newList;
  private readonly RaycastHit[] hits = new RaycastHit[5];

  private void OnEnable()
  {
    this.cam = Camera.main;
    this.hoverList = new List<Hoverable3d>();
    this.newList = new List<Hoverable3d>();
  }

  private void Update()
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
