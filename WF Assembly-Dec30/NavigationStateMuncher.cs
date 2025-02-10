// Decompiled with JetBrains decompiler
// Type: NavigationStateMuncher
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
public class NavigationStateMuncher : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr_disabled;
  private static readonly System.IntPtr NativeFieldInfoPtr_muncher;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_EventRoutineMuncher_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Begin_Public_Virtual_Final_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_End_Public_Virtual_Final_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Disable_Private_Void_UINavigationItem_0;

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 16160, RefRangeEnd = 16161, XrefRangeStart = 16150, XrefRangeEnd = 16160, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe NavigationStateMuncher(EventRoutineMuncher muncher)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NavigationStateMuncher>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) muncher)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(NavigationStateMuncher.NativeMethodInfoPtr__ctor_Public_Void_EventRoutineMuncher_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16161, XrefRangeEnd = 16188, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Begin()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(NavigationStateMuncher.NativeMethodInfoPtr_Begin_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16188, XrefRangeEnd = 16226, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void End()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(NavigationStateMuncher.NativeMethodInfoPtr_End_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 16234, RefRangeEnd = 16235, XrefRangeStart = 16226, XrefRangeEnd = 16234, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Disable(UINavigationItem item)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) item)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(NavigationStateMuncher.NativeMethodInfoPtr_Disable_Private_Void_UINavigationItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static NavigationStateMuncher()
  {
    Il2CppClassPointerStore<NavigationStateMuncher>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (NavigationStateMuncher));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NavigationStateMuncher>.NativeClassPtr);
    NavigationStateMuncher.NativeFieldInfoPtr_disabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationStateMuncher>.NativeClassPtr, nameof (disabled));
    NavigationStateMuncher.NativeFieldInfoPtr_muncher = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationStateMuncher>.NativeClassPtr, nameof (muncher));
    NavigationStateMuncher.NativeMethodInfoPtr__ctor_Public_Void_EventRoutineMuncher_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationStateMuncher>.NativeClassPtr, 100663390);
    NavigationStateMuncher.NativeMethodInfoPtr_Begin_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationStateMuncher>.NativeClassPtr, 100663391);
    NavigationStateMuncher.NativeMethodInfoPtr_End_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationStateMuncher>.NativeClassPtr, 100663392);
    NavigationStateMuncher.NativeMethodInfoPtr_Disable_Private_Void_UINavigationItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationStateMuncher>.NativeClassPtr, 100663393);
  }

  public NavigationStateMuncher(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe List<UINavigationItem> disabled
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NavigationStateMuncher.NativeFieldInfoPtr_disabled));
      return pointer == System.IntPtr.Zero ? (List<UINavigationItem>) null : new List<UINavigationItem>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NavigationStateMuncher.NativeFieldInfoPtr_disabled), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe EventRoutineMuncher muncher
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NavigationStateMuncher.NativeFieldInfoPtr_muncher));
      return pointer == System.IntPtr.Zero ? (EventRoutineMuncher) null : new EventRoutineMuncher(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NavigationStateMuncher.NativeFieldInfoPtr_muncher), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [ObfuscatedName("NavigationStateMuncher/<>c")]
  [Serializable]
  public sealed class __c : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__4_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__End_b__4_0_Internal_Boolean_UINavigationItem_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NavigationStateMuncher.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NavigationStateMuncher.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16146, XrefRangeEnd = 16150, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _End_b__4_0(UINavigationItem a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NavigationStateMuncher.__c.NativeMethodInfoPtr__End_b__4_0_Internal_Boolean_UINavigationItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c()
    {
      Il2CppClassPointerStore<NavigationStateMuncher.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NavigationStateMuncher>.NativeClassPtr, "<>c");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NavigationStateMuncher.__c>.NativeClassPtr);
      NavigationStateMuncher.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationStateMuncher.__c>.NativeClassPtr, "<>9");
      NavigationStateMuncher.__c.NativeFieldInfoPtr___9__4_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationStateMuncher.__c>.NativeClassPtr, "<>9__4_0");
      NavigationStateMuncher.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationStateMuncher.__c>.NativeClassPtr, 100663395);
      NavigationStateMuncher.__c.NativeMethodInfoPtr__End_b__4_0_Internal_Boolean_UINavigationItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationStateMuncher.__c>.NativeClassPtr, 100663396);
    }

    public __c(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe NavigationStateMuncher.__c __9
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(NavigationStateMuncher.__c.NativeFieldInfoPtr___9, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (NavigationStateMuncher.__c) null : new NavigationStateMuncher.__c(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(NavigationStateMuncher.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<UINavigationItem, bool> __9__4_0
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(NavigationStateMuncher.__c.NativeFieldInfoPtr___9__4_0, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<UINavigationItem, bool>) null : new Il2CppSystem.Func<UINavigationItem, bool>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(NavigationStateMuncher.__c.NativeFieldInfoPtr___9__4_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
