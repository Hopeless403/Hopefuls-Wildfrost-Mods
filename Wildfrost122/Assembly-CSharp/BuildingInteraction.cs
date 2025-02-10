// Decompiled with JetBrains decompiler
// Type: BuildingInteraction
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.EventSystems;

#nullable disable
[RequireComponent(typeof (Building))]
public class BuildingInteraction : MonoBehaviour
{
  [SerializeField]
  private GameObject[] outlines;
  private Building _building;
  private bool hover;

  private Building building => this._building ?? (this._building = this.GetComponent<Building>());

  public void Hover()
  {
    if (this.hover)
      return;
    Debug.Log((object) ("[" + this.name + " Hover]"));
    this.hover = true;
    foreach (GameObject outline in this.outlines)
      outline.SetActive(true);
    this.HoverTween();
    this.building.SetIcon("Select");
    Events.InvokeButtonHover(ButtonType.Building);
  }

  public void UnHover()
  {
    if (!this.hover)
      return;
    this.hover = false;
    Debug.Log((object) ("[" + this.name + " UnHover]"));
    foreach (GameObject outline in this.outlines)
      outline.SetActive(false);
    this.UnHoverTween();
    this.building.SetSuitableIcon();
  }

  public void Select(BaseEventData eventData)
  {
    if (eventData is PointerEventData pointerEventData && pointerEventData.button != PointerEventData.InputButton.Left)
      return;
    Town.SelectBuilding(this.building);
    Events.InvokeButtonPress(ButtonType.Building);
  }

  private void HoverTween()
  {
    LeanTween.cancel(this.gameObject);
    this.transform.localScale = new Vector3(0.99502486f, 0.99502486f, 1f);
    LeanTween.scale(this.gameObject, new Vector3(1.005f, 1.005f, 1f), 1.2f).setEaseOutElastic();
  }

  private void UnHoverTween()
  {
    LeanTween.cancel(this.gameObject);
    LeanTween.scale(this.gameObject, Vector3.one, 0.1f).setEaseOutQuart();
  }
}
