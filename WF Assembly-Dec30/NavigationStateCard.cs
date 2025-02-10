// Decompiled with JetBrains decompiler
// Type: NavigationStateCard
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
public class NavigationStateCard : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr_disabled;
  private static readonly System.IntPtr NativeFieldInfoPtr_entity;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Begin_Public_Virtual_Final_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_End_Public_Virtual_Final_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Disable_Private_Void_UINavigationItem_0;

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 15945, RefRangeEnd = 15946, XrefRangeStart = 15935, XrefRangeEnd = 15945, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe NavigationStateCard(Entity entity)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NavigationStateCard>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(NavigationStateCard.NativeMethodInfoPtr__ctor_Public_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15946, XrefRangeEnd = 16098, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Begin()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(NavigationStateCard.NativeMethodInfoPtr_Begin_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16098, XrefRangeEnd = 16136, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void End()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(NavigationStateCard.NativeMethodInfoPtr_End_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 16144, RefRangeEnd = 16146, XrefRangeStart = 16136, XrefRangeEnd = 16144, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Disable(UINavigationItem item)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) item)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(NavigationStateCard.NativeMethodInfoPtr_Disable_Private_Void_UINavigationItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static NavigationStateCard()
  {
    Il2CppClassPointerStore<NavigationStateCard>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (NavigationStateCard));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NavigationStateCard>.NativeClassPtr);
    NavigationStateCard.NativeFieldInfoPtr_disabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationStateCard>.NativeClassPtr, nameof (disabled));
    NavigationStateCard.NativeFieldInfoPtr_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationStateCard>.NativeClassPtr, nameof (entity));
    NavigationStateCard.NativeMethodInfoPtr__ctor_Public_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationStateCard>.NativeClassPtr, 100663379);
    NavigationStateCard.NativeMethodInfoPtr_Begin_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationStateCard>.NativeClassPtr, 100663380);
    NavigationStateCard.NativeMethodInfoPtr_End_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationStateCard>.NativeClassPtr, 100663381);
    NavigationStateCard.NativeMethodInfoPtr_Disable_Private_Void_UINavigationItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationStateCard>.NativeClassPtr, 100663382);
  }

  public NavigationStateCard(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe List<UINavigationItem> disabled
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NavigationStateCard.NativeFieldInfoPtr_disabled));
      return pointer == System.IntPtr.Zero ? (List<UINavigationItem>) null : new List<UINavigationItem>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NavigationStateCard.NativeFieldInfoPtr_disabled), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Entity entity
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NavigationStateCard.NativeFieldInfoPtr_entity));
      return pointer == System.IntPtr.Zero ? (Entity) null : new Entity(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NavigationStateCard.NativeFieldInfoPtr_entity), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [ObfuscatedName("NavigationStateCard/<>c")]
  [Serializable]
  public sealed class __c : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__3_0;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__4_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Begin_b__3_0_Internal_Boolean_CardContainer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__End_b__4_0_Internal_Boolean_UINavigationItem_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NavigationStateCard.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NavigationStateCard.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15927, XrefRangeEnd = 15931, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _Begin_b__3_0(CardContainer c)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) c)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NavigationStateCard.__c.NativeMethodInfoPtr__Begin_b__3_0_Internal_Boolean_CardContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15931, XrefRangeEnd = 15935, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _End_b__4_0(UINavigationItem a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NavigationStateCard.__c.NativeMethodInfoPtr__End_b__4_0_Internal_Boolean_UINavigationItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c()
    {
      Il2CppClassPointerStore<NavigationStateCard.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NavigationStateCard>.NativeClassPtr, "<>c");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NavigationStateCard.__c>.NativeClassPtr);
      NavigationStateCard.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationStateCard.__c>.NativeClassPtr, "<>9");
      NavigationStateCard.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationStateCard.__c>.NativeClassPtr, "<>9__3_0");
      NavigationStateCard.__c.NativeFieldInfoPtr___9__4_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationStateCard.__c>.NativeClassPtr, "<>9__4_0");
      NavigationStateCard.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationStateCard.__c>.NativeClassPtr, 100663384);
      NavigationStateCard.__c.NativeMethodInfoPtr__Begin_b__3_0_Internal_Boolean_CardContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationStateCard.__c>.NativeClassPtr, 100663385);
      NavigationStateCard.__c.NativeMethodInfoPtr__End_b__4_0_Internal_Boolean_UINavigationItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationStateCard.__c>.NativeClassPtr, 100663386);
    }

    public __c(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe NavigationStateCard.__c __9
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(NavigationStateCard.__c.NativeFieldInfoPtr___9, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (NavigationStateCard.__c) null : new NavigationStateCard.__c(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(NavigationStateCard.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<CardContainer, bool> __9__3_0
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(NavigationStateCard.__c.NativeFieldInfoPtr___9__3_0, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<CardContainer, bool>) null : new Il2CppSystem.Func<CardContainer, bool>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(NavigationStateCard.__c.NativeFieldInfoPtr___9__3_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<UINavigationItem, bool> __9__4_0
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(NavigationStateCard.__c.NativeFieldInfoPtr___9__4_0, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<UINavigationItem, bool>) null : new Il2CppSystem.Func<UINavigationItem, bool>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(NavigationStateCard.__c.NativeFieldInfoPtr___9__4_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
