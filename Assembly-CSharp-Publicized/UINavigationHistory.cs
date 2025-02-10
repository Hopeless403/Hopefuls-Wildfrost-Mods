// Decompiled with JetBrains decompiler
// Type: UINavigationHistory
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections.Generic;
using System.Linq;

public static class UINavigationHistory
{
  public static readonly List<UINavigationHistory.Layer> layers = new List<UINavigationHistory.Layer>();
  public static readonly List<UINavigationItem> items = new List<UINavigationItem>(10);
  public const int capacity = 10;

  public static void AddItem(UINavigationItem item)
  {
    UINavigationHistory.items.Add(item);
    if (UINavigationHistory.items.Count <= 10)
      return;
    UINavigationHistory.items.RemoveAt(0);
  }

  public static int GetItemIndex(UINavigationItem item) => !UINavigationHistory.items.Contains(item) ? 0 : UINavigationHistory.items.IndexOf(item);

  public static void AddLayer(UINavigationLayer navLayer) => UINavigationHistory.layers.Add(new UINavigationHistory.Layer(navLayer));

  public static void Clear()
  {
    UINavigationHistory.layers.Clear();
    UINavigationHistory.items.Clear();
  }

  public static void GoBackALayer()
  {
    if (MonoBehaviourSingleton<Cursor3d>.instance.usingMouse)
      return;
    if (UINavigationHistory.layers.Count > 0)
    {
      UINavigationHistory.Layer layer = UINavigationHistory.layers.FirstOrDefault<UINavigationHistory.Layer>((Func<UINavigationHistory.Layer, bool>) (a => (UnityEngine.Object) a.navigationLayer == (UnityEngine.Object) UINavigationSystem.ActiveNavigationLayer));
      if (layer != null && layer.navigationItemHistory.Count > 0)
      {
        MonoBehaviourSingleton<UINavigationSystem>.instance.SetCurrentNavigationItem(layer.navigationItemHistory.Last<UINavigationItem>());
        return;
      }
    }
    UINavigationDefaultSystem.SetStartingItem(false);
  }

  [Serializable]
  public class Layer
  {
    public UINavigationLayer navigationLayer;
    public readonly List<UINavigationItem> navigationItemHistory = new List<UINavigationItem>();

    public Layer(UINavigationLayer navigationLayer) => this.navigationLayer = navigationLayer;
  }
}
