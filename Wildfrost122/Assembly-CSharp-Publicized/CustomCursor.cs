// Decompiled with JetBrains decompiler
// Type: CustomCursor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
public class CustomCursor : MonoBehaviourSingleton<CustomCursor>
{
  public CursorMode cursorMode;
  public CustomCursor.Style[] styles;
  public string currentStyle = "default";
  public Dictionary<string, CustomCursor.Style> styleLookup;
  public static bool visible = true;

  public override void Awake()
  {
    base.Awake();
    CustomCursor.SetStyle(this.currentStyle);
  }

  public CustomCursor.Style Get(string styleName)
  {
    CustomCursor.Style style1 = (CustomCursor.Style) null;
    if (this.styleLookup == null)
    {
      this.styleLookup = new Dictionary<string, CustomCursor.Style>();
      foreach (CustomCursor.Style style2 in this.styles)
      {
        this.styleLookup[style2.name] = style2;
        if (style2.name == styleName)
          style1 = style2;
      }
    }
    else
      style1 = this.styleLookup[styleName];
    return style1;
  }

  public void Set(CustomCursor.Style style)
  {
    MonoBehaviourSingleton<CustomCursor>.instance.currentStyle = style.name;
    Cursor.SetCursor(style.sprite, style.hotSpot, MonoBehaviourSingleton<CustomCursor>.instance.cursorMode);
  }

  public static void SetStyle(string styleName)
  {
    CustomCursor.Style style = MonoBehaviourSingleton<CustomCursor>.instance.Get(styleName);
    if (style == null)
      return;
    MonoBehaviourSingleton<CustomCursor>.instance.Set(style);
  }

  public void OnApplicationFocus(bool focus)
  {
    if (focus)
      CustomCursor.UpdateState();
    else
      Cursor.SetCursor((Texture2D) null, Vector2.zero, CursorMode.Auto);
  }

  public static void UpdateState()
  {
    if (CustomCursor.visible && ((UnityEngine.Object) MonoBehaviourSingleton<Cursor3d>.instance == (UnityEngine.Object) null || MonoBehaviourSingleton<Cursor3d>.instance.usingMouse))
    {
      Cursor.visible = true;
      CustomCursor.SetStyle(MonoBehaviourSingleton<CustomCursor>.instance.currentStyle);
    }
    else
      Cursor.visible = false;
  }

  [Serializable]
  public class Style
  {
    public string name;
    public Texture2D sprite;
    public Vector2 hotSpot;
  }
}
