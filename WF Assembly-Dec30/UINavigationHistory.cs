// Decompiled with JetBrains decompiler
// Type: UINavigationHistory
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;

#nullable disable
public static class UINavigationHistory : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr_layers;
  private static readonly System.IntPtr NativeFieldInfoPtr_items;
  private static readonly System.IntPtr NativeFieldInfoPtr_capacity;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddItem_Public_Static_Void_UINavigationItem_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetItemIndex_Public_Static_Int32_UINavigationItem_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddLayer_Public_Static_Void_UINavigationLayer_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GoBackALayer_Public_Static_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18197, XrefRangeEnd = 18211, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void AddItem(UINavigationItem item)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) item)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(UINavigationHistory.NativeMethodInfoPtr_AddItem_Public_Static_Void_UINavigationItem_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18211, XrefRangeEnd = 18224, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int GetItemIndex(UINavigationItem item)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) item)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UINavigationHistory.NativeMethodInfoPtr_GetItemIndex_Public_Static_Int32_UINavigationItem_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(int*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18224, XrefRangeEnd = 18244, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void AddLayer(UINavigationLayer navLayer)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) navLayer)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(UINavigationHistory.NativeMethodInfoPtr_AddLayer_Public_Static_Void_UINavigationLayer_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18244, XrefRangeEnd = 18253, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Clear()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(UINavigationHistory.NativeMethodInfoPtr_Clear_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 18290, RefRangeEnd = 18291, XrefRangeStart = 18253, XrefRangeEnd = 18290, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void GoBackALayer()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(UINavigationHistory.NativeMethodInfoPtr_GoBackALayer_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static UINavigationHistory()
  {
    Il2CppClassPointerStore<UINavigationHistory>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (UINavigationHistory));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UINavigationHistory>.NativeClassPtr);
    UINavigationHistory.NativeFieldInfoPtr_layers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINavigationHistory>.NativeClassPtr, nameof (layers));
    UINavigationHistory.NativeFieldInfoPtr_items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINavigationHistory>.NativeClassPtr, nameof (items));
    UINavigationHistory.NativeFieldInfoPtr_capacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINavigationHistory>.NativeClassPtr, nameof (capacity));
    UINavigationHistory.NativeMethodInfoPtr_AddItem_Public_Static_Void_UINavigationItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINavigationHistory>.NativeClassPtr, 100663537);
    UINavigationHistory.NativeMethodInfoPtr_GetItemIndex_Public_Static_Int32_UINavigationItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINavigationHistory>.NativeClassPtr, 100663538);
    UINavigationHistory.NativeMethodInfoPtr_AddLayer_Public_Static_Void_UINavigationLayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINavigationHistory>.NativeClassPtr, 100663539);
    UINavigationHistory.NativeMethodInfoPtr_Clear_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINavigationHistory>.NativeClassPtr, 100663540);
    UINavigationHistory.NativeMethodInfoPtr_GoBackALayer_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINavigationHistory>.NativeClassPtr, 100663541);
  }

  public UINavigationHistory(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe List<UINavigationHistory.Layer> layers
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(UINavigationHistory.NativeFieldInfoPtr_layers, (void*) &num);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (List<UINavigationHistory.Layer>) null : new List<UINavigationHistory.Layer>(pointer);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(UINavigationHistory.NativeFieldInfoPtr_layers, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe List<UINavigationItem> items
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(UINavigationHistory.NativeFieldInfoPtr_items, (void*) &num);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (List<UINavigationItem>) null : new List<UINavigationItem>(pointer);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(UINavigationHistory.NativeFieldInfoPtr_items, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe int capacity
  {
    get
    {
      int capacity;
      IL2CPP.il2cpp_field_static_get_value(UINavigationHistory.NativeFieldInfoPtr_capacity, (void*) &capacity);
      return capacity;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(UINavigationHistory.NativeFieldInfoPtr_capacity, (void*) &value);
    }
  }

  [Serializable]
  public class Layer : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_navigationLayer;
    private static readonly System.IntPtr NativeFieldInfoPtr_navigationItemHistory;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_UINavigationLayer_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18180, XrefRangeEnd = 18190, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Layer(UINavigationLayer navigationLayer)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UINavigationHistory.Layer>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) navigationLayer)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UINavigationHistory.Layer.NativeMethodInfoPtr__ctor_Public_Void_UINavigationLayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Layer()
    {
      Il2CppClassPointerStore<UINavigationHistory.Layer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UINavigationHistory>.NativeClassPtr, nameof (Layer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UINavigationHistory.Layer>.NativeClassPtr);
      UINavigationHistory.Layer.NativeFieldInfoPtr_navigationLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINavigationHistory.Layer>.NativeClassPtr, nameof (navigationLayer));
      UINavigationHistory.Layer.NativeFieldInfoPtr_navigationItemHistory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINavigationHistory.Layer>.NativeClassPtr, nameof (navigationItemHistory));
      UINavigationHistory.Layer.NativeMethodInfoPtr__ctor_Public_Void_UINavigationLayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINavigationHistory.Layer>.NativeClassPtr, 100663543);
    }

    public Layer(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe UINavigationLayer navigationLayer
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UINavigationHistory.Layer.NativeFieldInfoPtr_navigationLayer));
        return pointer == System.IntPtr.Zero ? (UINavigationLayer) null : new UINavigationLayer(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UINavigationHistory.Layer.NativeFieldInfoPtr_navigationLayer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<UINavigationItem> navigationItemHistory
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UINavigationHistory.Layer.NativeFieldInfoPtr_navigationItemHistory));
        return pointer == System.IntPtr.Zero ? (List<UINavigationItem>) null : new List<UINavigationItem>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UINavigationHistory.Layer.NativeFieldInfoPtr_navigationItemHistory), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("UINavigationHistory/<>c")]
  [Serializable]
  public sealed class __c : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__7_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__GoBackALayer_b__7_0_Internal_Boolean_Layer_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UINavigationHistory.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UINavigationHistory.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18190, XrefRangeEnd = 18197, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _GoBackALayer_b__7_0(UINavigationHistory.Layer a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UINavigationHistory.__c.NativeMethodInfoPtr__GoBackALayer_b__7_0_Internal_Boolean_Layer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c()
    {
      Il2CppClassPointerStore<UINavigationHistory.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UINavigationHistory>.NativeClassPtr, "<>c");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UINavigationHistory.__c>.NativeClassPtr);
      UINavigationHistory.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINavigationHistory.__c>.NativeClassPtr, "<>9");
      UINavigationHistory.__c.NativeFieldInfoPtr___9__7_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINavigationHistory.__c>.NativeClassPtr, "<>9__7_0");
      UINavigationHistory.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINavigationHistory.__c>.NativeClassPtr, 100663545);
      UINavigationHistory.__c.NativeMethodInfoPtr__GoBackALayer_b__7_0_Internal_Boolean_Layer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINavigationHistory.__c>.NativeClassPtr, 100663546);
    }

    public __c(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe UINavigationHistory.__c __9
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(UINavigationHistory.__c.NativeFieldInfoPtr___9, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (UINavigationHistory.__c) null : new UINavigationHistory.__c(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(UINavigationHistory.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<UINavigationHistory.Layer, bool> __9__7_0
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(UINavigationHistory.__c.NativeFieldInfoPtr___9__7_0, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<UINavigationHistory.Layer, bool>) null : new Il2CppSystem.Func<UINavigationHistory.Layer, bool>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(UINavigationHistory.__c.NativeFieldInfoPtr___9__7_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
