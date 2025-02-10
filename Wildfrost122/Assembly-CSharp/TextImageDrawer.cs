// Decompiled with JetBrains decompiler
// Type: TextImageDrawer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
public class TextImageDrawer : TMP_Text
{
  [SerializeField]
  private TextImageData data;
  private Image[] images;
  private Transform _transform;

  private new Transform transform
  {
    get => this._transform ?? (this._transform = this.GetComponent<Transform>());
  }

  public override string text
  {
    get => this.m_text;
    set
    {
      if (!(this.m_text != value))
        return;
      this.m_text = value;
      this.DrawText();
    }
  }

  public override Color color
  {
    get => this.m_fontColor;
    set
    {
      this.m_fontColor = value;
      this.SetColour();
    }
  }

  protected override void Awake()
  {
    base.Awake();
    this.DrawText();
  }

  private void DrawText()
  {
    this.Clear();
    this.images = new Image[this.m_text.Length];
    for (int index = 0; index < this.m_text.Length; ++index)
    {
      char ch = this.m_text[index];
      Sprite result;
      if (this.data.TryGetSprite(ch, out result))
      {
        GameObject gameObject = new GameObject(ch.ToString());
        Image image = gameObject.AddComponent<Image>();
        image.sprite = result;
        image.color = this.m_fontColor;
        image.material = this.material;
        image.raycastTarget = this.raycastTarget;
        image.maskable = this.maskable;
        image.preserveAspect = true;
        this.images[index] = image;
        Transform transform = gameObject.transform;
        if (transform != null)
        {
          transform.SetParent(this.transform);
          transform.localScale = Vector3.one;
          transform.SetLocalPositionAndRotation(Vector3.zero, Quaternion.identity);
        }
      }
    }
  }

  private void SetColour()
  {
    foreach (Graphic image in this.images)
      image.color = this.m_fontColor;
  }

  private void Clear()
  {
    Image[] images = this.images;
    if (images == null || images.Length <= 0)
      return;
    foreach (Image image in this.images)
    {
      if ((bool) (Object) image && (bool) (Object) image.gameObject)
        Object.Destroy((Object) image.gameObject);
    }
  }
}
