// Decompiled with JetBrains decompiler
// Type: BuildingPlot
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.UI;

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
