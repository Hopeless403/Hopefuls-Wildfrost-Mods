// Decompiled with JetBrains decompiler
// Type: BuildingPlot
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.UI;

#nullable disable
public class BuildingPlot : MonoBehaviour
{
  [SerializeField]
  private string sortingLayerName;
  [SerializeField]
  private int sortingOrder;

  private void Start()
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
