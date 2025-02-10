// Decompiled with JetBrains decompiler
// Type: References
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class References : MonoBehaviourSingleton<References>
{
  private static readonly System.IntPtr NativeFieldInfoPtr_PlayerData;
  private static readonly System.IntPtr NativeFieldInfoPtr_Player;
  private static readonly System.IntPtr NativeFieldInfoPtr_Map;
  private static readonly System.IntPtr NativeFieldInfoPtr_Campaign;
  private static readonly System.IntPtr NativeFieldInfoPtr_Battle;
  private static readonly System.IntPtr NativeFieldInfoPtr_classes;
  private static readonly System.IntPtr NativeFieldInfoPtr_areas;
  private static readonly System.IntPtr NativeFieldInfoPtr_hardModeModifiers;
  private static readonly System.IntPtr NativeFieldInfoPtr__minibossCameraMover;
  private static readonly System.IntPtr NativeFieldInfoPtr_DefaultGameModeName;
  private static readonly System.IntPtr NativeFieldInfoPtr_TutorialGameModeName;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_LeaderData_Public_Static_get_CardData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Classes_Public_Static_get_Il2CppReferenceArray_1_ClassData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Areas_Public_Static_get_Il2CppReferenceArray_1_AreaData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_MinibossCameraMover_Public_Static_get_Transform_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetCurrentArea_Public_Static_AreaData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  public static unsafe CardData LeaderData
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 116176, RefRangeEnd = 116180, XrefRangeStart = 116155, XrefRangeEnd = 116176, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(References.NativeMethodInfoPtr_get_LeaderData_Public_Static_get_CardData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (CardData) null : new CardData(pointer);
    }
  }

  public static unsafe Il2CppReferenceArray<ClassData> Classes
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 116184, RefRangeEnd = 116186, XrefRangeStart = 116180, XrefRangeEnd = 116184, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(References.NativeMethodInfoPtr_get_Classes_Public_Static_get_Il2CppReferenceArray_1_ClassData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr nativeObject = num;
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<ClassData>) null : new Il2CppReferenceArray<ClassData>(nativeObject);
    }
  }

  public static unsafe Il2CppReferenceArray<AreaData> Areas
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 116190, RefRangeEnd = 116191, XrefRangeStart = 116186, XrefRangeEnd = 116190, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(References.NativeMethodInfoPtr_get_Areas_Public_Static_get_Il2CppReferenceArray_1_AreaData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr nativeObject = num;
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<AreaData>) null : new Il2CppReferenceArray<AreaData>(nativeObject);
    }
  }

  public static unsafe Transform MinibossCameraMover
  {
    [CallerCount(9), CachedScanResults(RefRangeStart = 116205, RefRangeEnd = 116214, XrefRangeStart = 116191, XrefRangeEnd = 116205, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(References.NativeMethodInfoPtr_get_MinibossCameraMover_Public_Static_get_Transform_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Transform) null : new Transform(pointer);
    }
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 116221, RefRangeEnd = 116227, XrefRangeStart = 116214, XrefRangeEnd = 116221, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe AreaData GetCurrentArea()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(References.NativeMethodInfoPtr_GetCurrentArea_Public_Static_AreaData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (AreaData) null : new AreaData(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116227, XrefRangeEnd = 116230, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe References()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<References>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(References.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static References()
  {
    Il2CppClassPointerStore<References>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (References));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<References>.NativeClassPtr);
    References.NativeFieldInfoPtr_PlayerData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<References>.NativeClassPtr, nameof (PlayerData));
    References.NativeFieldInfoPtr_Player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<References>.NativeClassPtr, nameof (Player));
    References.NativeFieldInfoPtr_Map = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<References>.NativeClassPtr, nameof (Map));
    References.NativeFieldInfoPtr_Campaign = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<References>.NativeClassPtr, nameof (Campaign));
    References.NativeFieldInfoPtr_Battle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<References>.NativeClassPtr, nameof (Battle));
    References.NativeFieldInfoPtr_classes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<References>.NativeClassPtr, nameof (classes));
    References.NativeFieldInfoPtr_areas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<References>.NativeClassPtr, nameof (areas));
    References.NativeFieldInfoPtr_hardModeModifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<References>.NativeClassPtr, nameof (hardModeModifiers));
    References.NativeFieldInfoPtr__minibossCameraMover = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<References>.NativeClassPtr, nameof (_minibossCameraMover));
    References.NativeFieldInfoPtr_DefaultGameModeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<References>.NativeClassPtr, nameof (DefaultGameModeName));
    References.NativeFieldInfoPtr_TutorialGameModeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<References>.NativeClassPtr, nameof (TutorialGameModeName));
    References.NativeMethodInfoPtr_get_LeaderData_Public_Static_get_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<References>.NativeClassPtr, 100674322);
    References.NativeMethodInfoPtr_get_Classes_Public_Static_get_Il2CppReferenceArray_1_ClassData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<References>.NativeClassPtr, 100674323);
    References.NativeMethodInfoPtr_get_Areas_Public_Static_get_Il2CppReferenceArray_1_AreaData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<References>.NativeClassPtr, 100674324);
    References.NativeMethodInfoPtr_get_MinibossCameraMover_Public_Static_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<References>.NativeClassPtr, 100674325);
    References.NativeMethodInfoPtr_GetCurrentArea_Public_Static_AreaData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<References>.NativeClassPtr, 100674326);
    References.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<References>.NativeClassPtr, 100674327);
  }

  public References(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe PlayerData PlayerData
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(References.NativeFieldInfoPtr_PlayerData, (void*) &num);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (PlayerData) null : new PlayerData(pointer);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(References.NativeFieldInfoPtr_PlayerData, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe Character Player
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(References.NativeFieldInfoPtr_Player, (void*) &num);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Character) null : new Character(pointer);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(References.NativeFieldInfoPtr_Player, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe MapNew Map
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(References.NativeFieldInfoPtr_Map, (void*) &num);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (MapNew) null : new MapNew(pointer);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(References.NativeFieldInfoPtr_Map, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe Campaign Campaign
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(References.NativeFieldInfoPtr_Campaign, (void*) &num);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Campaign) null : new Campaign(pointer);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(References.NativeFieldInfoPtr_Campaign, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe Battle Battle
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(References.NativeFieldInfoPtr_Battle, (void*) &num);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Battle) null : new Battle(pointer);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(References.NativeFieldInfoPtr_Battle, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<ClassData> classes
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(References.NativeFieldInfoPtr_classes));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<ClassData>) null : new Il2CppReferenceArray<ClassData>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(References.NativeFieldInfoPtr_classes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<AreaData> areas
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(References.NativeFieldInfoPtr_areas));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<AreaData>) null : new Il2CppReferenceArray<AreaData>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(References.NativeFieldInfoPtr_areas), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<HardModeModifierData> hardModeModifiers
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(References.NativeFieldInfoPtr_hardModeModifiers));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<HardModeModifierData>) null : new Il2CppReferenceArray<HardModeModifierData>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(References.NativeFieldInfoPtr_hardModeModifiers), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe Transform _minibossCameraMover
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(References.NativeFieldInfoPtr__minibossCameraMover, (void*) &num);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Transform) null : new Transform(pointer);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(References.NativeFieldInfoPtr__minibossCameraMover, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe string DefaultGameModeName
  {
    get
    {
      System.IntPtr il2CppString;
      IL2CPP.il2cpp_field_static_get_value(References.NativeFieldInfoPtr_DefaultGameModeName, (void*) &il2CppString);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(References.NativeFieldInfoPtr_DefaultGameModeName, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string TutorialGameModeName
  {
    get
    {
      System.IntPtr il2CppString;
      IL2CPP.il2cpp_field_static_get_value(References.NativeFieldInfoPtr_TutorialGameModeName, (void*) &il2CppString);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(References.NativeFieldInfoPtr_TutorialGameModeName, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  [ObfuscatedName("References/<>c")]
  [Serializable]
  public sealed class __c : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__get_LeaderData_b__2_0_Internal_Boolean_CardData_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<References.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(References.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe bool _get_LeaderData_b__2_0(CardData a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(References.__c.NativeMethodInfoPtr__get_LeaderData_b__2_0_Internal_Boolean_CardData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c()
    {
      Il2CppClassPointerStore<References.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<References>.NativeClassPtr, "<>c");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<References.__c>.NativeClassPtr);
      References.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<References.__c>.NativeClassPtr, "<>9");
      References.__c.NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<References.__c>.NativeClassPtr, "<>9__2_0");
      References.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<References.__c>.NativeClassPtr, 100674329);
      References.__c.NativeMethodInfoPtr__get_LeaderData_b__2_0_Internal_Boolean_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<References.__c>.NativeClassPtr, 100674330);
    }

    public __c(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe References.__c __9
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(References.__c.NativeFieldInfoPtr___9, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (References.__c) null : new References.__c(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(References.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<CardData, bool> __9__2_0
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(References.__c.NativeFieldInfoPtr___9__2_0, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<CardData, bool>) null : new Il2CppSystem.Func<CardData, bool>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(References.__c.NativeFieldInfoPtr___9__2_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
