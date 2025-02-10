// Decompiled with JetBrains decompiler
// Type: NavigationStateBattle
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
public class NavigationStateBattle : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr_disabled;
  private static readonly System.IntPtr NativeMethodInfoPtr_Begin_Public_Virtual_Final_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_End_Public_Virtual_Final_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Disable_Private_Void_UINavigationItem_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15822, XrefRangeEnd = 15869, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Begin()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(NavigationStateBattle.NativeMethodInfoPtr_Begin_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15869, XrefRangeEnd = 15907, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void End()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(NavigationStateBattle.NativeMethodInfoPtr_End_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 15915, RefRangeEnd = 15917, XrefRangeStart = 15907, XrefRangeEnd = 15915, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Disable(UINavigationItem item)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) item)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(NavigationStateBattle.NativeMethodInfoPtr_Disable_Private_Void_UINavigationItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 15926, RefRangeEnd = 15927, XrefRangeStart = 15917, XrefRangeEnd = 15926, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe NavigationStateBattle()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NavigationStateBattle>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(NavigationStateBattle.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static NavigationStateBattle()
  {
    Il2CppClassPointerStore<NavigationStateBattle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (NavigationStateBattle));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NavigationStateBattle>.NativeClassPtr);
    NavigationStateBattle.NativeFieldInfoPtr_disabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationStateBattle>.NativeClassPtr, nameof (disabled));
    NavigationStateBattle.NativeMethodInfoPtr_Begin_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationStateBattle>.NativeClassPtr, 100663372);
    NavigationStateBattle.NativeMethodInfoPtr_End_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationStateBattle>.NativeClassPtr, 100663373);
    NavigationStateBattle.NativeMethodInfoPtr_Disable_Private_Void_UINavigationItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationStateBattle>.NativeClassPtr, 100663374);
    NavigationStateBattle.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationStateBattle>.NativeClassPtr, 100663375);
  }

  public NavigationStateBattle(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe List<UINavigationItem> disabled
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NavigationStateBattle.NativeFieldInfoPtr_disabled));
      return pointer == System.IntPtr.Zero ? (List<UINavigationItem>) null : new List<UINavigationItem>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NavigationStateBattle.NativeFieldInfoPtr_disabled), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [ObfuscatedName("NavigationStateBattle/<>c")]
  [Serializable]
  public sealed class __c : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__End_b__2_0_Internal_Boolean_UINavigationItem_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NavigationStateBattle.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NavigationStateBattle.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15818, XrefRangeEnd = 15822, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _End_b__2_0(UINavigationItem a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NavigationStateBattle.__c.NativeMethodInfoPtr__End_b__2_0_Internal_Boolean_UINavigationItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c()
    {
      Il2CppClassPointerStore<NavigationStateBattle.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NavigationStateBattle>.NativeClassPtr, "<>c");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NavigationStateBattle.__c>.NativeClassPtr);
      NavigationStateBattle.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationStateBattle.__c>.NativeClassPtr, "<>9");
      NavigationStateBattle.__c.NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationStateBattle.__c>.NativeClassPtr, "<>9__2_0");
      NavigationStateBattle.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationStateBattle.__c>.NativeClassPtr, 100663377);
      NavigationStateBattle.__c.NativeMethodInfoPtr__End_b__2_0_Internal_Boolean_UINavigationItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationStateBattle.__c>.NativeClassPtr, 100663378);
    }

    public __c(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe NavigationStateBattle.__c __9
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(NavigationStateBattle.__c.NativeFieldInfoPtr___9, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (NavigationStateBattle.__c) null : new NavigationStateBattle.__c(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(NavigationStateBattle.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<UINavigationItem, bool> __9__2_0
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(NavigationStateBattle.__c.NativeFieldInfoPtr___9__2_0, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<UINavigationItem, bool>) null : new Il2CppSystem.Func<UINavigationItem, bool>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(NavigationStateBattle.__c.NativeFieldInfoPtr___9__2_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
