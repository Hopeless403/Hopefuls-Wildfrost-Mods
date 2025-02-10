// Decompiled with JetBrains decompiler
// Type: UINavigationItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using NaughtyAttributes;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class UINavigationItem : MonoBehaviour
{
  public UINavigationLayer navigationLayer;
  public Vector3 offset;
  public UINavigationItem.SelectionPriority selectionPriority;
  public GameObject clickHandler;
  public bool isHighlighted;
  public bool canLoop;
  public bool ignoreLayers;
  public bool isSelectable = true;
  public bool overrideInputs;
  [ShowIf("overrideInputs")]
  public UINavigationItem inputLeft;
  [ShowIf("overrideInputs")]
  public UINavigationItem inputRight;
  [ShowIf("overrideInputs")]
  public UINavigationItem inputUp;
  [ShowIf("overrideInputs")]
  public UINavigationItem inputDown;
  [HideIf("overrideInputs")]
  public bool overrideHorizontal;
  [ShowIf("overrideHorizontal")]
  [HideIf("overrideInputs")]
  public UnityEvent<float> OnHorizontalOverride;
  [HideIf("overrideInputs")]
  public bool overrideVertical;
  [ShowIf("overrideVertical")]
  [HideIf("overrideInputs")]
  public UnityEvent<float> OnVerticalOverride;
  public bool hasLayerBeenChecked;
  public Camera _cam;

  public Vector3 Position => this.transform.position + this.offset;

  public Camera cam => this._cam ?? (this._cam = Camera.main);

  public void OnEnable()
  {
    this.CheckForReferences(!this.hasLayerBeenChecked);
    MonoBehaviourSingleton<UINavigationSystem>.instance.RegisterSelectable(this);
  }

  public void OnDisable() => this.OnRemoved();

  public void OnDestroy() => this.OnRemoved();

  public void OnRemoved() => MonoBehaviourSingleton<UINavigationSystem>.instance.UnregisterSelectable(this);

  public virtual void Reset()
  {
    if (this.GetComponents<UINavigationItem>().Length > 1)
      Object.Destroy((Object) this);
    this.CheckForReferences(true);
  }

  public void OnTransformParentChanged()
  {
    this.navigationLayer = (UINavigationLayer) null;
    this.CheckForNavigationLayer(!this.hasLayerBeenChecked);
  }

  public void CheckForReferences(bool isFirstTime)
  {
    if ((Object) this.navigationLayer == (Object) null)
      this.CheckForNavigationLayer(isFirstTime);
    if (!((Object) this.clickHandler == (Object) null))
      return;
    this.CheckForSelectable();
  }

  public void CheckForNavigationLayer(bool isFirstTime)
  {
    if (isFirstTime)
      this.navigationLayer = (UINavigationLayer) null;
    this.CheckForNavigationLayer(this.transform, isFirstTime);
    this.hasLayerBeenChecked = true;
  }

  public void CheckForNavigationLayer(Transform checkTransform, bool isFirstTime)
  {
    if ((bool) (Object) checkTransform.GetComponent<UINavigationLayer>() && checkTransform.GetComponent<UINavigationLayer>().isOverrideLayer && (isFirstTime || checkTransform.GetComponent<UINavigationLayer>().allowLayerToBeAppliedAtRuntime))
      this.navigationLayer = checkTransform.GetComponent<UINavigationLayer>();
    if ((bool) (Object) this.navigationLayer || !(bool) (Object) checkTransform.transform.parent)
      return;
    this.CheckForNavigationLayer(checkTransform.transform.parent, isFirstTime);
  }

  public void CheckForSelectable()
  {
    this.CheckForSelectableDown(this.transform);
    if (!((Object) this.clickHandler == (Object) null))
      return;
    this.CheckForSelectableUp(this.transform.parent);
  }

  public void CheckForSelectableDown(Transform checkTransform)
  {
    this.clickHandler = checkTransform.GetComponent<IPointerDownHandler>() != null ? checkTransform.gameObject : (GameObject) null;
    if (!((Object) this.clickHandler == (Object) null))
      return;
    for (int index = 0; index < checkTransform.childCount; ++index)
    {
      this.CheckForSelectableDown(checkTransform.GetChild(index));
      if ((Object) this.clickHandler != (Object) null)
        break;
    }
  }

  public void CheckForSelectableUp(Transform checkTransform)
  {
    if (!((Object) checkTransform != (Object) null))
      return;
    this.clickHandler = checkTransform.GetComponent<IPointerDownHandler>() != null ? checkTransform.gameObject : (GameObject) null;
    if (!((Object) this.clickHandler == (Object) null) || !(bool) (Object) checkTransform.transform.parent)
      return;
    this.CheckForSelectableDown(checkTransform.transform.parent);
  }

  public bool CheckLayer()
  {
    UINavigationLayer activeNavigationLayer = UINavigationSystem.ActiveNavigationLayer;
    if (!this.ignoreLayers && !((Object) this.navigationLayer == (Object) activeNavigationLayer))
      return false;
    return (bool) (Object) activeNavigationLayer && activeNavigationLayer.allowOutsideVisibleSelection || this.cam.IsInCameraView(this.Position);
  }

  public enum SelectionPriority
  {
    Lowest = -2, // 0xFFFFFFFE
    Low = -1, // 0xFFFFFFFF
    Medium = 0,
    High = 1,
    Highest = 2,
    Mega = 10, // 0x0000000A
  }
}
