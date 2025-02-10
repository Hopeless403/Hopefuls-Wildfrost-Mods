// Decompiled with JetBrains decompiler
// Type: UINavigationDefaultSystem
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
public static class UINavigationDefaultSystem : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeMethodInfoPtr_SetStartingItem_Public_Static_Void_Boolean_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetDefaultTarget_Public_Static_Void_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetPlayPosition_Private_Static_PlayPosition_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetDefaultTargets_Private_Static_IEnumerable_1_UINavigationItem_Entity_PlayPosition_0;

  [CallerCount(9)]
  [CachedScanResults(RefRangeStart = 18060, RefRangeEnd = 18069, XrefRangeStart = 17875, XrefRangeEnd = 18060, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetStartingItem(bool useClosest = true, bool ignoreHistory = false)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &useClosest;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &ignoreHistory;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(UINavigationDefaultSystem.NativeMethodInfoPtr_SetStartingItem_Public_Static_Void_Boolean_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 18141, RefRangeEnd = 18142, XrefRangeStart = 18069, XrefRangeEnd = 18141, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetDefaultTarget(Entity entity)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(UINavigationDefaultSystem.NativeMethodInfoPtr_SetDefaultTarget_Public_Static_Void_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18142, XrefRangeEnd = 18144, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe CardData.PlayPosition GetPlayPosition(Entity entity)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UINavigationDefaultSystem.NativeMethodInfoPtr_GetPlayPosition_Private_Static_PlayPosition_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(CardData.PlayPosition*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 18179, RefRangeEnd = 18180, XrefRangeStart = 18144, XrefRangeEnd = 18179, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe IEnumerable<UINavigationItem> GetDefaultTargets(
    Entity entity,
    CardData.PlayPosition playPosition)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &playPosition;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UINavigationDefaultSystem.NativeMethodInfoPtr_GetDefaultTargets_Private_Static_IEnumerable_1_UINavigationItem_Entity_PlayPosition_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerable<UINavigationItem>) null : new IEnumerable<UINavigationItem>(pointer);
  }

  static UINavigationDefaultSystem()
  {
    Il2CppClassPointerStore<UINavigationDefaultSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (UINavigationDefaultSystem));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UINavigationDefaultSystem>.NativeClassPtr);
    UINavigationDefaultSystem.NativeMethodInfoPtr_SetStartingItem_Public_Static_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINavigationDefaultSystem>.NativeClassPtr, 100663513);
    UINavigationDefaultSystem.NativeMethodInfoPtr_SetDefaultTarget_Public_Static_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINavigationDefaultSystem>.NativeClassPtr, 100663514);
    UINavigationDefaultSystem.NativeMethodInfoPtr_GetPlayPosition_Private_Static_PlayPosition_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINavigationDefaultSystem>.NativeClassPtr, 100663515);
    UINavigationDefaultSystem.NativeMethodInfoPtr_GetDefaultTargets_Private_Static_IEnumerable_1_UINavigationItem_Entity_PlayPosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINavigationDefaultSystem>.NativeClassPtr, 100663516);
  }

  public UINavigationDefaultSystem(System.IntPtr pointer)
    : base(pointer)
  {
  }

  [ObfuscatedName("UINavigationDefaultSystem/<>c")]
  [Serializable]
  public sealed class __c : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__0_0;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__0_1;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__0_2;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__0_3;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__0_4;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__0_5;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__0_6;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__0_7;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__0_8;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__1_0;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__1_1;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__3_0;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__3_1;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__3_2;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__3_3;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__3_4;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__3_5;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__3_6;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__SetStartingItem_b__0_0_Internal_Boolean_UINavigationItem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__SetStartingItem_b__0_1_Internal_Single_UINavigationItem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__SetStartingItem_b__0_2_Internal_Int32_UINavigationItem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__SetStartingItem_b__0_3_Internal_Single_UINavigationItem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__SetStartingItem_b__0_4_Internal_Int32_UINavigationItem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__SetStartingItem_b__0_5_Internal_Int32_UINavigationItem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__SetStartingItem_b__0_6_Internal_Single_UINavigationItem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__SetStartingItem_b__0_7_Internal_Int32_UINavigationItem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__SetStartingItem_b__0_8_Internal_Single_UINavigationItem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__SetDefaultTarget_b__1_0_Internal_Boolean_UINavigationItem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__SetDefaultTarget_b__1_1_Internal_Single_UINavigationItem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__GetDefaultTargets_b__3_0_Internal_UINavigationItem_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__GetDefaultTargets_b__3_1_Internal_UINavigationItem_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__GetDefaultTargets_b__3_2_Internal_UINavigationItem_CardContainer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__GetDefaultTargets_b__3_3_Internal_UINavigationItem_CardContainer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__GetDefaultTargets_b__3_4_Internal_UINavigationItem_CardContainer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__GetDefaultTargets_b__3_5_Internal_UINavigationItem_CardSlot_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__GetDefaultTargets_b__3_6_Internal_UINavigationItem_CardSlot_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UINavigationDefaultSystem.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UINavigationDefaultSystem.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17763, XrefRangeEnd = 17767, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _SetStartingItem_b__0_0(UINavigationItem item)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) item)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UINavigationDefaultSystem.__c.NativeMethodInfoPtr__SetStartingItem_b__0_0_Internal_Boolean_UINavigationItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17767, XrefRangeEnd = 17780, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float _SetStartingItem_b__0_1(UINavigationItem a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UINavigationDefaultSystem.__c.NativeMethodInfoPtr__SetStartingItem_b__0_1_Internal_Single_UINavigationItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe int _SetStartingItem_b__0_2(UINavigationItem a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UINavigationDefaultSystem.__c.NativeMethodInfoPtr__SetStartingItem_b__0_2_Internal_Int32_UINavigationItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17780, XrefRangeEnd = 17793, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float _SetStartingItem_b__0_3(UINavigationItem a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UINavigationDefaultSystem.__c.NativeMethodInfoPtr__SetStartingItem_b__0_3_Internal_Single_UINavigationItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17793, XrefRangeEnd = 17806, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int _SetStartingItem_b__0_4(UINavigationItem a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UINavigationDefaultSystem.__c.NativeMethodInfoPtr__SetStartingItem_b__0_4_Internal_Int32_UINavigationItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe int _SetStartingItem_b__0_5(UINavigationItem a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UINavigationDefaultSystem.__c.NativeMethodInfoPtr__SetStartingItem_b__0_5_Internal_Int32_UINavigationItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17806, XrefRangeEnd = 17817, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float _SetStartingItem_b__0_6(UINavigationItem a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UINavigationDefaultSystem.__c.NativeMethodInfoPtr__SetStartingItem_b__0_6_Internal_Single_UINavigationItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17817, XrefRangeEnd = 17830, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int _SetStartingItem_b__0_7(UINavigationItem a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UINavigationDefaultSystem.__c.NativeMethodInfoPtr__SetStartingItem_b__0_7_Internal_Int32_UINavigationItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17830, XrefRangeEnd = 17841, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float _SetStartingItem_b__0_8(UINavigationItem a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UINavigationDefaultSystem.__c.NativeMethodInfoPtr__SetStartingItem_b__0_8_Internal_Single_UINavigationItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17841, XrefRangeEnd = 17845, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _SetDefaultTarget_b__1_0(UINavigationItem item)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) item)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UINavigationDefaultSystem.__c.NativeMethodInfoPtr__SetDefaultTarget_b__1_0_Internal_Boolean_UINavigationItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17845, XrefRangeEnd = 17875, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float _SetDefaultTarget_b__1_1(UINavigationItem a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UINavigationDefaultSystem.__c.NativeMethodInfoPtr__SetDefaultTarget_b__1_1_Internal_Single_UINavigationItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe UINavigationItem _GetDefaultTargets_b__3_0(Entity a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UINavigationDefaultSystem.__c.NativeMethodInfoPtr__GetDefaultTargets_b__3_0_Internal_UINavigationItem_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (UINavigationItem) null : new UINavigationItem(pointer);
    }

    [CallerCount(0)]
    public unsafe UINavigationItem _GetDefaultTargets_b__3_1(Entity a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UINavigationDefaultSystem.__c.NativeMethodInfoPtr__GetDefaultTargets_b__3_1_Internal_UINavigationItem_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (UINavigationItem) null : new UINavigationItem(pointer);
    }

    [CallerCount(0)]
    public unsafe UINavigationItem _GetDefaultTargets_b__3_2(CardContainer a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UINavigationDefaultSystem.__c.NativeMethodInfoPtr__GetDefaultTargets_b__3_2_Internal_UINavigationItem_CardContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (UINavigationItem) null : new UINavigationItem(pointer);
    }

    [CallerCount(0)]
    public unsafe UINavigationItem _GetDefaultTargets_b__3_3(CardContainer a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UINavigationDefaultSystem.__c.NativeMethodInfoPtr__GetDefaultTargets_b__3_3_Internal_UINavigationItem_CardContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (UINavigationItem) null : new UINavigationItem(pointer);
    }

    [CallerCount(0)]
    public unsafe UINavigationItem _GetDefaultTargets_b__3_4(CardContainer a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UINavigationDefaultSystem.__c.NativeMethodInfoPtr__GetDefaultTargets_b__3_4_Internal_UINavigationItem_CardContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (UINavigationItem) null : new UINavigationItem(pointer);
    }

    [CallerCount(0)]
    public unsafe UINavigationItem _GetDefaultTargets_b__3_5(CardSlot a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UINavigationDefaultSystem.__c.NativeMethodInfoPtr__GetDefaultTargets_b__3_5_Internal_UINavigationItem_CardSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (UINavigationItem) null : new UINavigationItem(pointer);
    }

    [CallerCount(0)]
    public unsafe UINavigationItem _GetDefaultTargets_b__3_6(CardSlot a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UINavigationDefaultSystem.__c.NativeMethodInfoPtr__GetDefaultTargets_b__3_6_Internal_UINavigationItem_CardSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (UINavigationItem) null : new UINavigationItem(pointer);
    }

    static __c()
    {
      Il2CppClassPointerStore<UINavigationDefaultSystem.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UINavigationDefaultSystem>.NativeClassPtr, "<>c");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UINavigationDefaultSystem.__c>.NativeClassPtr);
      UINavigationDefaultSystem.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINavigationDefaultSystem.__c>.NativeClassPtr, "<>9");
      UINavigationDefaultSystem.__c.NativeFieldInfoPtr___9__0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINavigationDefaultSystem.__c>.NativeClassPtr, "<>9__0_0");
      UINavigationDefaultSystem.__c.NativeFieldInfoPtr___9__0_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINavigationDefaultSystem.__c>.NativeClassPtr, "<>9__0_1");
      UINavigationDefaultSystem.__c.NativeFieldInfoPtr___9__0_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINavigationDefaultSystem.__c>.NativeClassPtr, "<>9__0_2");
      UINavigationDefaultSystem.__c.NativeFieldInfoPtr___9__0_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINavigationDefaultSystem.__c>.NativeClassPtr, "<>9__0_3");
      UINavigationDefaultSystem.__c.NativeFieldInfoPtr___9__0_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINavigationDefaultSystem.__c>.NativeClassPtr, "<>9__0_4");
      UINavigationDefaultSystem.__c.NativeFieldInfoPtr___9__0_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINavigationDefaultSystem.__c>.NativeClassPtr, "<>9__0_5");
      UINavigationDefaultSystem.__c.NativeFieldInfoPtr___9__0_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINavigationDefaultSystem.__c>.NativeClassPtr, "<>9__0_6");
      UINavigationDefaultSystem.__c.NativeFieldInfoPtr___9__0_7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINavigationDefaultSystem.__c>.NativeClassPtr, "<>9__0_7");
      UINavigationDefaultSystem.__c.NativeFieldInfoPtr___9__0_8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINavigationDefaultSystem.__c>.NativeClassPtr, "<>9__0_8");
      UINavigationDefaultSystem.__c.NativeFieldInfoPtr___9__1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINavigationDefaultSystem.__c>.NativeClassPtr, "<>9__1_0");
      UINavigationDefaultSystem.__c.NativeFieldInfoPtr___9__1_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINavigationDefaultSystem.__c>.NativeClassPtr, "<>9__1_1");
      UINavigationDefaultSystem.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINavigationDefaultSystem.__c>.NativeClassPtr, "<>9__3_0");
      UINavigationDefaultSystem.__c.NativeFieldInfoPtr___9__3_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINavigationDefaultSystem.__c>.NativeClassPtr, "<>9__3_1");
      UINavigationDefaultSystem.__c.NativeFieldInfoPtr___9__3_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINavigationDefaultSystem.__c>.NativeClassPtr, "<>9__3_2");
      UINavigationDefaultSystem.__c.NativeFieldInfoPtr___9__3_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINavigationDefaultSystem.__c>.NativeClassPtr, "<>9__3_3");
      UINavigationDefaultSystem.__c.NativeFieldInfoPtr___9__3_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINavigationDefaultSystem.__c>.NativeClassPtr, "<>9__3_4");
      UINavigationDefaultSystem.__c.NativeFieldInfoPtr___9__3_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINavigationDefaultSystem.__c>.NativeClassPtr, "<>9__3_5");
      UINavigationDefaultSystem.__c.NativeFieldInfoPtr___9__3_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINavigationDefaultSystem.__c>.NativeClassPtr, "<>9__3_6");
      UINavigationDefaultSystem.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINavigationDefaultSystem.__c>.NativeClassPtr, 100663518);
      UINavigationDefaultSystem.__c.NativeMethodInfoPtr__SetStartingItem_b__0_0_Internal_Boolean_UINavigationItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINavigationDefaultSystem.__c>.NativeClassPtr, 100663519);
      UINavigationDefaultSystem.__c.NativeMethodInfoPtr__SetStartingItem_b__0_1_Internal_Single_UINavigationItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINavigationDefaultSystem.__c>.NativeClassPtr, 100663520);
      UINavigationDefaultSystem.__c.NativeMethodInfoPtr__SetStartingItem_b__0_2_Internal_Int32_UINavigationItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINavigationDefaultSystem.__c>.NativeClassPtr, 100663521);
      UINavigationDefaultSystem.__c.NativeMethodInfoPtr__SetStartingItem_b__0_3_Internal_Single_UINavigationItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINavigationDefaultSystem.__c>.NativeClassPtr, 100663522);
      UINavigationDefaultSystem.__c.NativeMethodInfoPtr__SetStartingItem_b__0_4_Internal_Int32_UINavigationItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINavigationDefaultSystem.__c>.NativeClassPtr, 100663523);
      UINavigationDefaultSystem.__c.NativeMethodInfoPtr__SetStartingItem_b__0_5_Internal_Int32_UINavigationItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINavigationDefaultSystem.__c>.NativeClassPtr, 100663524);
      UINavigationDefaultSystem.__c.NativeMethodInfoPtr__SetStartingItem_b__0_6_Internal_Single_UINavigationItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINavigationDefaultSystem.__c>.NativeClassPtr, 100663525);
      UINavigationDefaultSystem.__c.NativeMethodInfoPtr__SetStartingItem_b__0_7_Internal_Int32_UINavigationItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINavigationDefaultSystem.__c>.NativeClassPtr, 100663526);
      UINavigationDefaultSystem.__c.NativeMethodInfoPtr__SetStartingItem_b__0_8_Internal_Single_UINavigationItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINavigationDefaultSystem.__c>.NativeClassPtr, 100663527);
      UINavigationDefaultSystem.__c.NativeMethodInfoPtr__SetDefaultTarget_b__1_0_Internal_Boolean_UINavigationItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINavigationDefaultSystem.__c>.NativeClassPtr, 100663528);
      UINavigationDefaultSystem.__c.NativeMethodInfoPtr__SetDefaultTarget_b__1_1_Internal_Single_UINavigationItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINavigationDefaultSystem.__c>.NativeClassPtr, 100663529);
      UINavigationDefaultSystem.__c.NativeMethodInfoPtr__GetDefaultTargets_b__3_0_Internal_UINavigationItem_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINavigationDefaultSystem.__c>.NativeClassPtr, 100663530);
      UINavigationDefaultSystem.__c.NativeMethodInfoPtr__GetDefaultTargets_b__3_1_Internal_UINavigationItem_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINavigationDefaultSystem.__c>.NativeClassPtr, 100663531);
      UINavigationDefaultSystem.__c.NativeMethodInfoPtr__GetDefaultTargets_b__3_2_Internal_UINavigationItem_CardContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINavigationDefaultSystem.__c>.NativeClassPtr, 100663532);
      UINavigationDefaultSystem.__c.NativeMethodInfoPtr__GetDefaultTargets_b__3_3_Internal_UINavigationItem_CardContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINavigationDefaultSystem.__c>.NativeClassPtr, 100663533);
      UINavigationDefaultSystem.__c.NativeMethodInfoPtr__GetDefaultTargets_b__3_4_Internal_UINavigationItem_CardContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINavigationDefaultSystem.__c>.NativeClassPtr, 100663534);
      UINavigationDefaultSystem.__c.NativeMethodInfoPtr__GetDefaultTargets_b__3_5_Internal_UINavigationItem_CardSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINavigationDefaultSystem.__c>.NativeClassPtr, 100663535);
      UINavigationDefaultSystem.__c.NativeMethodInfoPtr__GetDefaultTargets_b__3_6_Internal_UINavigationItem_CardSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINavigationDefaultSystem.__c>.NativeClassPtr, 100663536);
    }

    public __c(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe UINavigationDefaultSystem.__c __9
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(UINavigationDefaultSystem.__c.NativeFieldInfoPtr___9, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (UINavigationDefaultSystem.__c) null : new UINavigationDefaultSystem.__c(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(UINavigationDefaultSystem.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<UINavigationItem, bool> __9__0_0
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(UINavigationDefaultSystem.__c.NativeFieldInfoPtr___9__0_0, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<UINavigationItem, bool>) null : new Il2CppSystem.Func<UINavigationItem, bool>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(UINavigationDefaultSystem.__c.NativeFieldInfoPtr___9__0_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<UINavigationItem, float> __9__0_1
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(UINavigationDefaultSystem.__c.NativeFieldInfoPtr___9__0_1, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<UINavigationItem, float>) null : new Il2CppSystem.Func<UINavigationItem, float>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(UINavigationDefaultSystem.__c.NativeFieldInfoPtr___9__0_1, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<UINavigationItem, int> __9__0_2
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(UINavigationDefaultSystem.__c.NativeFieldInfoPtr___9__0_2, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<UINavigationItem, int>) null : new Il2CppSystem.Func<UINavigationItem, int>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(UINavigationDefaultSystem.__c.NativeFieldInfoPtr___9__0_2, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<UINavigationItem, float> __9__0_3
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(UINavigationDefaultSystem.__c.NativeFieldInfoPtr___9__0_3, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<UINavigationItem, float>) null : new Il2CppSystem.Func<UINavigationItem, float>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(UINavigationDefaultSystem.__c.NativeFieldInfoPtr___9__0_3, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<UINavigationItem, int> __9__0_4
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(UINavigationDefaultSystem.__c.NativeFieldInfoPtr___9__0_4, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<UINavigationItem, int>) null : new Il2CppSystem.Func<UINavigationItem, int>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(UINavigationDefaultSystem.__c.NativeFieldInfoPtr___9__0_4, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<UINavigationItem, int> __9__0_5
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(UINavigationDefaultSystem.__c.NativeFieldInfoPtr___9__0_5, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<UINavigationItem, int>) null : new Il2CppSystem.Func<UINavigationItem, int>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(UINavigationDefaultSystem.__c.NativeFieldInfoPtr___9__0_5, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<UINavigationItem, float> __9__0_6
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(UINavigationDefaultSystem.__c.NativeFieldInfoPtr___9__0_6, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<UINavigationItem, float>) null : new Il2CppSystem.Func<UINavigationItem, float>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(UINavigationDefaultSystem.__c.NativeFieldInfoPtr___9__0_6, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<UINavigationItem, int> __9__0_7
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(UINavigationDefaultSystem.__c.NativeFieldInfoPtr___9__0_7, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<UINavigationItem, int>) null : new Il2CppSystem.Func<UINavigationItem, int>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(UINavigationDefaultSystem.__c.NativeFieldInfoPtr___9__0_7, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<UINavigationItem, float> __9__0_8
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(UINavigationDefaultSystem.__c.NativeFieldInfoPtr___9__0_8, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<UINavigationItem, float>) null : new Il2CppSystem.Func<UINavigationItem, float>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(UINavigationDefaultSystem.__c.NativeFieldInfoPtr___9__0_8, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<UINavigationItem, bool> __9__1_0
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(UINavigationDefaultSystem.__c.NativeFieldInfoPtr___9__1_0, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<UINavigationItem, bool>) null : new Il2CppSystem.Func<UINavigationItem, bool>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(UINavigationDefaultSystem.__c.NativeFieldInfoPtr___9__1_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<UINavigationItem, float> __9__1_1
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(UINavigationDefaultSystem.__c.NativeFieldInfoPtr___9__1_1, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<UINavigationItem, float>) null : new Il2CppSystem.Func<UINavigationItem, float>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(UINavigationDefaultSystem.__c.NativeFieldInfoPtr___9__1_1, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<Entity, UINavigationItem> __9__3_0
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(UINavigationDefaultSystem.__c.NativeFieldInfoPtr___9__3_0, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<Entity, UINavigationItem>) null : new Il2CppSystem.Func<Entity, UINavigationItem>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(UINavigationDefaultSystem.__c.NativeFieldInfoPtr___9__3_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<Entity, UINavigationItem> __9__3_1
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(UINavigationDefaultSystem.__c.NativeFieldInfoPtr___9__3_1, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<Entity, UINavigationItem>) null : new Il2CppSystem.Func<Entity, UINavigationItem>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(UINavigationDefaultSystem.__c.NativeFieldInfoPtr___9__3_1, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<CardContainer, UINavigationItem> __9__3_2
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(UINavigationDefaultSystem.__c.NativeFieldInfoPtr___9__3_2, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<CardContainer, UINavigationItem>) null : new Il2CppSystem.Func<CardContainer, UINavigationItem>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(UINavigationDefaultSystem.__c.NativeFieldInfoPtr___9__3_2, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<CardContainer, UINavigationItem> __9__3_3
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(UINavigationDefaultSystem.__c.NativeFieldInfoPtr___9__3_3, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<CardContainer, UINavigationItem>) null : new Il2CppSystem.Func<CardContainer, UINavigationItem>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(UINavigationDefaultSystem.__c.NativeFieldInfoPtr___9__3_3, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<CardContainer, UINavigationItem> __9__3_4
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(UINavigationDefaultSystem.__c.NativeFieldInfoPtr___9__3_4, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<CardContainer, UINavigationItem>) null : new Il2CppSystem.Func<CardContainer, UINavigationItem>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(UINavigationDefaultSystem.__c.NativeFieldInfoPtr___9__3_4, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<CardSlot, UINavigationItem> __9__3_5
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(UINavigationDefaultSystem.__c.NativeFieldInfoPtr___9__3_5, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<CardSlot, UINavigationItem>) null : new Il2CppSystem.Func<CardSlot, UINavigationItem>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(UINavigationDefaultSystem.__c.NativeFieldInfoPtr___9__3_5, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<CardSlot, UINavigationItem> __9__3_6
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(UINavigationDefaultSystem.__c.NativeFieldInfoPtr___9__3_6, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<CardSlot, UINavigationItem>) null : new Il2CppSystem.Func<CardSlot, UINavigationItem>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(UINavigationDefaultSystem.__c.NativeFieldInfoPtr___9__3_6, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
