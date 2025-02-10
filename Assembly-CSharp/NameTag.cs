// Decompiled with JetBrains decompiler
// Type: NameTag
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections.Generic;
using UnityEngine;

public class NameTag : MonoBehaviour
{
  [SerializeField]
  private NameTagStyle[] styles;
  public NameTagStyle currentStyle;
  private readonly Dictionary<string, NameTagStyle> styleDictionary = new Dictionary<string, NameTagStyle>();

  private void Awake()
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
