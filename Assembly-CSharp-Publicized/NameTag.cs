// Decompiled with JetBrains decompiler
// Type: NameTag
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections.Generic;
using UnityEngine;

public class NameTag : MonoBehaviour
{
  [SerializeField]
  public NameTagStyle[] styles;
  public NameTagStyle currentStyle;
  public readonly Dictionary<string, NameTagStyle> styleDictionary = new Dictionary<string, NameTagStyle>();

  public void Awake()
  {
    foreach (NameTagStyle style in this.styles)
      this.styleDictionary[style.name] = style;
    foreach (NameTagStyle style in this.styles)
    {
      if (style.gameObject.activeSelf)
      {
        this.currentStyle = style;
        break;
      }
    }
  }

  public void SetStyle(string styleName)
  {
    NameTagStyle style = this.styleDictionary[styleName];
    if (!((Object) style != (Object) this.currentStyle))
      return;
    this.currentStyle.gameObject.SetActive(false);
    style.gameObject.SetActive(true);
    this.currentStyle = style;
  }
}
