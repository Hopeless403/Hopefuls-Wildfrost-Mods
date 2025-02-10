// Decompiled with JetBrains decompiler
// Type: NavigationStateAssignUpgrade
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
public class NavigationStateAssignUpgrade : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr_disabled;
  private static readonly System.IntPtr NativeFieldInfoPtr_eligibleCards;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_List_1_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Begin_Public_Virtual_Final_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_End_Public_Virtual_Final_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Disable_Private_Void_UINavigationItem_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15672, XrefRangeEnd = 15682, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe NavigationStateAssignUpgrade(List<Entity> eligibleCards)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NavigationStateAssignUpgrade>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eligibleCards)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(NavigationStateAssignUpgrade.NativeMethodInfoPtr__ctor_Public_Void_List_1_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15682, XrefRangeEnd = 15772, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Begin()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(NavigationStateAssignUpgrade.NativeMethodInfoPtr_Begin_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15772, XrefRangeEnd = 15810, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void End()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(NavigationStateAssignUpgrade.NativeMethodInfoPtr_End_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15810, XrefRangeEnd = 15818, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Disable(UINavigationItem item)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) item)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(NavigationStateAssignUpgrade.NativeMethodInfoPtr_Disable_Private_Void_UINavigationItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static NavigationStateAssignUpgrade()
  {
    Il2CppClassPointerStore<NavigationStateAssignUpgrade>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (NavigationStateAssignUpgrade));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NavigationStateAssignUpgrade>.NativeClassPtr);
    NavigationStateAssignUpgrade.NativeFieldInfoPtr_disabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationStateAssignUpgrade>.NativeClassPtr, nameof (disabled));
    NavigationStateAssignUpgrade.NativeFieldInfoPtr_eligibleCards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationStateAssignUpgrade>.NativeClassPtr, nameof (eligibleCards));
    NavigationStateAssignUpgrade.NativeMethodInfoPtr__ctor_Public_Void_List_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationStateAssignUpgrade>.NativeClassPtr, 100663364);
    NavigationStateAssignUpgrade.NativeMethodInfoPtr_Begin_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationStateAssignUpgrade>.NativeClassPtr, 100663365);
    NavigationStateAssignUpgrade.NativeMethodInfoPtr_End_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationStateAssignUpgrade>.NativeClassPtr, 100663366);
    NavigationStateAssignUpgrade.NativeMethodInfoPtr_Disable_Private_Void_UINavigationItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationStateAssignUpgrade>.NativeClassPtr, 100663367);
  }

  public NavigationStateAssignUpgrade(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe List<UINavigationItem> disabled
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NavigationStateAssignUpgrade.NativeFieldInfoPtr_disabled));
      return pointer == System.IntPtr.Zero ? (List<UINavigationItem>) null : new List<UINavigationItem>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NavigationStateAssignUpgrade.NativeFieldInfoPtr_disabled), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<Entity> eligibleCards
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NavigationStateAssignUpgrade.NativeFieldInfoPtr_eligibleCards));
      return pointer == System.IntPtr.Zero ? (List<Entity>) null : new List<Entity>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NavigationStateAssignUpgrade.NativeFieldInfoPtr_eligibleCards), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [ObfuscatedName("NavigationStateAssignUpgrade/<>c")]
  [Serializable]
  public sealed class __c : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__3_0;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__4_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Begin_b__3_0_Internal_UINavigationItem_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__End_b__4_0_Internal_Boolean_UINavigationItem_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NavigationStateAssignUpgrade.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NavigationStateAssignUpgrade.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe UINavigationItem _Begin_b__3_0(Entity a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NavigationStateAssignUpgrade.__c.NativeMethodInfoPtr__Begin_b__3_0_Internal_UINavigationItem_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (UINavigationItem) null : new UINavigationItem(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15668, XrefRangeEnd = 15672, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _End_b__4_0(UINavigationItem a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NavigationStateAssignUpgrade.__c.NativeMethodInfoPtr__End_b__4_0_Internal_Boolean_UINavigationItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c()
    {
      Il2CppClassPointerStore<NavigationStateAssignUpgrade.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NavigationStateAssignUpgrade>.NativeClassPtr, "<>c");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NavigationStateAssignUpgrade.__c>.NativeClassPtr);
      NavigationStateAssignUpgrade.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationStateAssignUpgrade.__c>.NativeClassPtr, "<>9");
      NavigationStateAssignUpgrade.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationStateAssignUpgrade.__c>.NativeClassPtr, "<>9__3_0");
      NavigationStateAssignUpgrade.__c.NativeFieldInfoPtr___9__4_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationStateAssignUpgrade.__c>.NativeClassPtr, "<>9__4_0");
      NavigationStateAssignUpgrade.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationStateAssignUpgrade.__c>.NativeClassPtr, 100663369);
      NavigationStateAssignUpgrade.__c.NativeMethodInfoPtr__Begin_b__3_0_Internal_UINavigationItem_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationStateAssignUpgrade.__c>.NativeClassPtr, 100663370);
      NavigationStateAssignUpgrade.__c.NativeMethodInfoPtr__End_b__4_0_Internal_Boolean_UINavigationItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationStateAssignUpgrade.__c>.NativeClassPtr, 100663371);
    }

    public __c(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe NavigationStateAssignUpgrade.__c __9
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(NavigationStateAssignUpgrade.__c.NativeFieldInfoPtr___9, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (NavigationStateAssignUpgrade.__c) null : new NavigationStateAssignUpgrade.__c(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(NavigationStateAssignUpgrade.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<Entity, UINavigationItem> __9__3_0
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(NavigationStateAssignUpgrade.__c.NativeFieldInfoPtr___9__3_0, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<Entity, UINavigationItem>) null : new Il2CppSystem.Func<Entity, UINavigationItem>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(NavigationStateAssignUpgrade.__c.NativeFieldInfoPtr___9__3_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<UINavigationItem, bool> __9__4_0
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(NavigationStateAssignUpgrade.__c.NativeFieldInfoPtr___9__4_0, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<UINavigationItem, bool>) null : new Il2CppSystem.Func<UINavigationItem, bool>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(NavigationStateAssignUpgrade.__c.NativeFieldInfoPtr___9__4_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
