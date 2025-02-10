// Decompiled with JetBrains decompiler
// Type: BuildingInteraction
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent(typeof (Building))]
public class BuildingInteraction : MonoBehaviour
{
  [SerializeField]
  public SpriteRenderer[] spritesToOutline;
  public Building _building;
  public Material _outlineMaterial;
  public readonly Dictionary<SpriteRenderer, Material> previous = new Dictionary<SpriteRenderer, Material>();
  public bool hover;

  public Building building => this._building ?? (this._building = this.GetComponent<Building>());

  public Material outlineMaterial => this._outlineMaterial ?? (this._outlineMaterial = AssetLoader.Lookup<Material>("Materials", "SpriteOutline"));

  public void Hover()
  {
    if (this.hover)
      return;
    Debug.Log((object) ("[" + this.name + " Hover]"));
    this.hover = true;
    this.previous.Clear();
    foreach (SpriteRenderer key in this.spritesToOutline)
    {
      this.previous[key] = key.sharedMaterial;
      key.sharedMaterial = this.outlineMaterial;
    }
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
    foreach (KeyValuePair<SpriteRenderer, Material> keyValuePair in this.previous.Where<KeyValuePair<SpriteRenderer, Material>>((Func<KeyValuePair<SpriteRenderer, Material>, bool>) (pair => (UnityEngine.Object) pair.Key != (UnityEngine.Object) null)))
      keyValuePair.Key.sharedMaterial = keyValuePair.Value;
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

  public void HoverTween()
  {
    LeanTween.cancel(this.gameObject);
    this.transform.localScale = new Vector3(0.99502486f, 0.99502486f, 1f);
    LeanTween.scale(this.gameObject, new Vector3(1.005f, 1.005f, 1f), 1.2f).setEaseOutElastic();
  }

  public void UnHoverTween()
  {
    LeanTween.cancel(this.gameObject);
    LeanTween.scale(this.gameObject, Vector3.one, 0.1f).setEaseOutQuart();
  }
}
