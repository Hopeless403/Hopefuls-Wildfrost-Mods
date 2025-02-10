// Decompiled with JetBrains decompiler
// Type: BuildingPlot
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;
using UnityEngine.UI;

#nullable disable
public class BuildingPlot : MonoBehaviour
{
  [SerializeField]
  public string sortingLayerName;
  [SerializeField]
  public int sortingOrder;

  public void Start()
  {
    Building componentInChildren = this.GetComponentInChildren<Building>(true);
    if ((Object) componentInChildren != (Object) null)
    {
      foreach (SpriteRenderer componentsInChild in componentInChildren.GetComponentsInChildren<SpriteRenderer>(true))
      {
        componentsInChild.sortingLayerName = this.sortingLayerName;
        componentsInChild.sortingOrder += this.sortingOrder;
      }
    }
    Image component = this.GetComponent<Image>();
    if (component == null)
      return;
    component.enabled = false;
  }
}
