// Decompiled with JetBrains decompiler
// Type: LTRect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using UnityEngine;

#nullable disable
[Serializable]
public class LTRect
{
  public Rect _rect;
  public float alpha = 1f;
  public float rotation;
  public Vector2 pivot;
  public Vector2 margin;
  public Rect relativeRect = new Rect(0.0f, 0.0f, float.PositiveInfinity, float.PositiveInfinity);
  public bool rotateEnabled;
  [HideInInspector]
  public bool rotateFinished;
  public bool alphaEnabled;
  public string labelStr;
  public LTGUI.Element_Type type;
  public GUIStyle style;
  public bool useColor;
  public Color color = Color.white;
  public bool fontScaleToFit;
  public bool useSimpleScale;
  public bool sizeByHeight;
  public Texture texture;
  public int _id = -1;
  [HideInInspector]
  public int counter;
  public static bool colorTouched;

  public LTRect()
  {
    this.reset();
    this.rotateEnabled = this.alphaEnabled = true;
    this._rect = new Rect(0.0f, 0.0f, 1f, 1f);
  }

  public LTRect(Rect rect)
  {
    this._rect = rect;
    this.reset();
  }

  public LTRect(float x, float y, float width, float height)
  {
    this._rect = new Rect(x, y, width, height);
    this.alpha = 1f;
    this.rotation = 0.0f;
    this.rotateEnabled = this.alphaEnabled = false;
  }

  public LTRect(float x, float y, float width, float height, float alpha)
  {
    this._rect = new Rect(x, y, width, height);
    this.alpha = alpha;
    this.rotation = 0.0f;
    this.rotateEnabled = this.alphaEnabled = false;
  }

  public LTRect(float x, float y, float width, float height, float alpha, float rotation)
  {
    this._rect = new Rect(x, y, width, height);
    this.alpha = alpha;
    this.rotation = rotation;
    this.rotateEnabled = this.alphaEnabled = false;
    if ((double) rotation == 0.0)
      return;
    this.rotateEnabled = true;
    this.resetForRotation();
  }

  public bool hasInitiliazed => this._id != -1;

  public int id => this._id | this.counter << 16;

  public void setId(int id, int counter)
  {
    this._id = id;
    this.counter = counter;
  }

  public void reset()
  {
    this.alpha = 1f;
    this.rotation = 0.0f;
    this.rotateEnabled = this.alphaEnabled = false;
    this.margin = Vector2.zero;
    this.sizeByHeight = false;
    this.useColor = false;
  }

  public void resetForRotation()
  {
    Vector3 vector3;
    ref Vector3 local = ref vector3;
    Matrix4x4 matrix = GUI.matrix;
    double x = (double) matrix[0, 0];
    matrix = GUI.matrix;
    double y = (double) matrix[1, 1];
    matrix = GUI.matrix;
    double z = (double) matrix[2, 2];
    local = new Vector3((float) x, (float) y, (float) z);
    if (!(this.pivot == Vector2.zero))
      return;
    this.pivot = new Vector2((this._rect.x + this._rect.width * 0.5f) * vector3.x + GUI.matrix[0, 3], (this._rect.y + this._rect.height * 0.5f) * vector3.y + GUI.matrix[1, 3]);
  }

  public float x
  {
    get => this._rect.x;
    set => this._rect.x = value;
  }

  public float y
  {
    get => this._rect.y;
    set => this._rect.y = value;
  }

  public float width
  {
    get => this._rect.width;
    set => this._rect.width = value;
  }

  public float height
  {
    get => this._rect.height;
    set => this._rect.height = value;
  }

  public Rect rect
  {
    get
    {
      if (LTRect.colorTouched)
      {
        LTRect.colorTouched = false;
        GUI.color = new Color(GUI.color.r, GUI.color.g, GUI.color.b, 1f);
      }
      if (this.rotateEnabled)
      {
        if (this.rotateFinished)
        {
          this.rotateFinished = false;
          this.rotateEnabled = false;
          this.pivot = Vector2.zero;
        }
        else
          GUIUtility.RotateAroundPivot(this.rotation, this.pivot);
      }
      if (this.alphaEnabled)
      {
        GUI.color = new Color(GUI.color.r, GUI.color.g, GUI.color.b, this.alpha);
        LTRect.colorTouched = true;
      }
      if (this.fontScaleToFit)
        this.style.fontSize = !this.useSimpleScale ? (int) this._rect.height : (int) ((double) this._rect.height * (double) this.relativeRect.height);
      return this._rect;
    }
    set => this._rect = value;
  }

  public LTRect setStyle(GUIStyle style)
  {
    this.style = style;
    return this;
  }

  public LTRect setFontScaleToFit(bool fontScaleToFit)
  {
    this.fontScaleToFit = fontScaleToFit;
    return this;
  }

  public LTRect setColor(Color color)
  {
    this.color = color;
    this.useColor = true;
    return this;
  }

  public LTRect setAlpha(float alpha)
  {
    this.alpha = alpha;
    return this;
  }

  public LTRect setLabel(string str)
  {
    this.labelStr = str;
    return this;
  }

  public LTRect setUseSimpleScale(bool useSimpleScale, Rect relativeRect)
  {
    this.useSimpleScale = useSimpleScale;
    this.relativeRect = relativeRect;
    return this;
  }

  public LTRect setUseSimpleScale(bool useSimpleScale)
  {
    this.useSimpleScale = useSimpleScale;
    this.relativeRect = new Rect(0.0f, 0.0f, (float) Screen.width, (float) Screen.height);
    return this;
  }

  public LTRect setSizeByHeight(bool sizeByHeight)
  {
    this.sizeByHeight = sizeByHeight;
    return this;
  }

  public override string ToString()
  {
    return "x:" + this._rect.x.ToString() + " y:" + this._rect.y.ToString() + " width:" + this._rect.width.ToString() + " height:" + this._rect.height.ToString();
  }
}
