// Decompiled with JetBrains decompiler
// Type: ImageDropShadow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
[RequireComponent(typeof (Image))]
public class ImageDropShadow : MonoBehaviourRect
{
  [SerializeField]
  public Vector2 offset = new Vector2(0.1f, -0.1f);
  [SerializeField]
  public Material shadowMaterial;
  [SerializeField]
  public Color shadowColor;
  public Image caster;
  public Image shadow;
  public RectTransform casterTransform;
  public RectTransform shadowTransform;

  public IEnumerator Start()
  {
    // ISSUE: reference to a compiler-generated field
    int num = this.\u003C\u003E1__state;
    ImageDropShadow imageDropShadow = this;
    if (num != 0)
    {
      if (num != 1)
        return false;
      // ISSUE: reference to a compiler-generated field
      this.\u003C\u003E1__state = -1;
      imageDropShadow.shadowTransform.localScale = Vector3.one;
      imageDropShadow.shadowTransform.localEulerAngles = Vector3.zero;
      imageDropShadow.shadow = imageDropShadow.shadowTransform.gameObject.AddComponent<Image>();
      imageDropShadow.shadow.raycastTarget = false;
      imageDropShadow.shadow.material = imageDropShadow.shadowMaterial;
      imageDropShadow.shadow.sprite = imageDropShadow.caster.sprite;
      imageDropShadow.shadow.color = imageDropShadow.shadowColor;
      return false;
    }
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E1__state = -1;
    imageDropShadow.caster = imageDropShadow.GetComponent<Image>();
    imageDropShadow.casterTransform = imageDropShadow.rectTransform;
    imageDropShadow.shadowTransform = new GameObject(nameof (ImageDropShadow), new System.Type[1]
    {
      typeof (RectTransform)
    }).GetComponent<RectTransform>();
    imageDropShadow.shadowTransform.SetParent(imageDropShadow.casterTransform.parent);
    imageDropShadow.shadowTransform.SetSiblingIndex(imageDropShadow.casterTransform.GetSiblingIndex());
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E2__current = (object) null;
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E1__state = 1;
    return true;
  }

  public void LateUpdate()
  {
    this.shadowTransform.sizeDelta = this.casterTransform.sizeDelta;
    this.shadowTransform.anchoredPosition = this.casterTransform.anchoredPosition + this.offset;
    this.shadowTransform.rotation = this.casterTransform.rotation;
  }
}
