// Decompiled with JetBrains decompiler
// Type: CardManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Pool;
using UnityEngine.ResourceManagement.AsyncOperations;

#nullable disable
public class CardManager : MonoBehaviourSingleton<CardManager>
{
  private static readonly System.IntPtr NativeFieldInfoPtr_cardIcons;
  private static readonly System.IntPtr NativeFieldInfoPtr_startPos;
  private static readonly System.IntPtr NativeFieldInfoPtr_cardPools;
  private static readonly System.IntPtr NativeFieldInfoPtr_init;
  private static readonly System.IntPtr NativeFieldInfoPtr_cardIconLoadHandle;
  private static readonly System.IntPtr NativeFieldInfoPtr_SCALE;
  private static readonly System.IntPtr NativeFieldInfoPtr_HOVER_SCALE;
  private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_IEnumerator_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LoadCardIcons_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Static_Card_CardData_CardController_Character_Boolean_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ReturnToPool_Public_Static_Boolean_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ReturnToPool_Public_Static_Boolean_Card_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ReturnToPool_Public_Static_Boolean_Entity_Card_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_NewStatusIcon_Public_Static_StatusIcon_String_Transform_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ReturnToPoolNextFrame_Public_Static_Void_Card_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ReturnToPoolNextFrameRoutine_Private_Static_IEnumerator_Card_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36030, XrefRangeEnd = 36035, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardManager.NativeMethodInfoPtr_Start_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 36107, RefRangeEnd = 36108, XrefRangeStart = 36035, XrefRangeEnd = 36107, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void LoadCardIcons()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardManager.NativeMethodInfoPtr_LoadCardIcons_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(39)]
  [CachedScanResults(RefRangeStart = 36134, RefRangeEnd = 36173, XrefRangeStart = 36108, XrefRangeEnd = 36134, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Card Get(
    CardData data,
    CardController controller,
    Character owner,
    bool inPlay,
    bool isPlayerCard)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) controller);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) owner);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &inPlay;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &isPlayerCard;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardManager.NativeMethodInfoPtr_Get_Public_Static_Card_CardData_CardController_Character_Boolean_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (Card) null : new Card(pointer);
  }

  [CallerCount(25)]
  [CachedScanResults(RefRangeStart = 36184, RefRangeEnd = 36209, XrefRangeStart = 36173, XrefRangeEnd = 36184, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool ReturnToPool(Entity entity)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardManager.NativeMethodInfoPtr_ReturnToPool_Public_Static_Boolean_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 36214, RefRangeEnd = 36216, XrefRangeStart = 36209, XrefRangeEnd = 36214, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool ReturnToPool(Card card)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) card)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardManager.NativeMethodInfoPtr_ReturnToPool_Public_Static_Boolean_Card_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(8)]
  [CachedScanResults(RefRangeStart = 36242, RefRangeEnd = 36250, XrefRangeStart = 36216, XrefRangeEnd = 36242, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool ReturnToPool(Entity entity, Card card)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) card);
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardManager.NativeMethodInfoPtr_ReturnToPool_Public_Static_Boolean_Entity_Card_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 36272, RefRangeEnd = 36274, XrefRangeStart = 36250, XrefRangeEnd = 36272, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe StatusIcon NewStatusIcon(string type, Transform iconParent)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(type);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) iconParent);
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardManager.NativeMethodInfoPtr_NewStatusIcon_Public_Static_StatusIcon_String_Transform_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (StatusIcon) null : new StatusIcon(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 36288, RefRangeEnd = 36289, XrefRangeStart = 36274, XrefRangeEnd = 36288, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void ReturnToPoolNextFrame(Card card)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) card)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardManager.NativeMethodInfoPtr_ReturnToPoolNextFrame_Public_Static_Void_Card_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36289, XrefRangeEnd = 36294, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe IEnumerator ReturnToPoolNextFrameRoutine(Card card)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) card)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardManager.NativeMethodInfoPtr_ReturnToPoolNextFrameRoutine_Private_Static_IEnumerator_Card_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36294, XrefRangeEnd = 36297, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CardManager()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardManager>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static CardManager()
  {
    Il2CppClassPointerStore<CardManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (CardManager));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardManager>.NativeClassPtr);
    CardManager.NativeFieldInfoPtr_cardIcons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardManager>.NativeClassPtr, nameof (cardIcons));
    CardManager.NativeFieldInfoPtr_startPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardManager>.NativeClassPtr, nameof (startPos));
    CardManager.NativeFieldInfoPtr_cardPools = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardManager>.NativeClassPtr, nameof (cardPools));
    CardManager.NativeFieldInfoPtr_init = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardManager>.NativeClassPtr, nameof (init));
    CardManager.NativeFieldInfoPtr_cardIconLoadHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardManager>.NativeClassPtr, nameof (cardIconLoadHandle));
    CardManager.NativeFieldInfoPtr_SCALE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardManager>.NativeClassPtr, nameof (SCALE));
    CardManager.NativeFieldInfoPtr_HOVER_SCALE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardManager>.NativeClassPtr, nameof (HOVER_SCALE));
    CardManager.NativeMethodInfoPtr_Start_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardManager>.NativeClassPtr, 100665679);
    CardManager.NativeMethodInfoPtr_LoadCardIcons_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardManager>.NativeClassPtr, 100665680);
    CardManager.NativeMethodInfoPtr_Get_Public_Static_Card_CardData_CardController_Character_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardManager>.NativeClassPtr, 100665681);
    CardManager.NativeMethodInfoPtr_ReturnToPool_Public_Static_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardManager>.NativeClassPtr, 100665682);
    CardManager.NativeMethodInfoPtr_ReturnToPool_Public_Static_Boolean_Card_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardManager>.NativeClassPtr, 100665683);
    CardManager.NativeMethodInfoPtr_ReturnToPool_Public_Static_Boolean_Entity_Card_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardManager>.NativeClassPtr, 100665684);
    CardManager.NativeMethodInfoPtr_NewStatusIcon_Public_Static_StatusIcon_String_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardManager>.NativeClassPtr, 100665685);
    CardManager.NativeMethodInfoPtr_ReturnToPoolNextFrame_Public_Static_Void_Card_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardManager>.NativeClassPtr, 100665686);
    CardManager.NativeMethodInfoPtr_ReturnToPoolNextFrameRoutine_Private_Static_IEnumerator_Card_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardManager>.NativeClassPtr, 100665687);
    CardManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardManager>.NativeClassPtr, 100665688);
  }

  public CardManager(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe Dictionary<string, GameObject> cardIcons
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(CardManager.NativeFieldInfoPtr_cardIcons, (void*) &num);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Dictionary<string, GameObject>) null : new Dictionary<string, GameObject>(pointer);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CardManager.NativeFieldInfoPtr_cardIcons, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe Vector3 startPos
  {
    get
    {
      Vector3 startPos;
      IL2CPP.il2cpp_field_static_get_value(CardManager.NativeFieldInfoPtr_startPos, (void*) &startPos);
      return startPos;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CardManager.NativeFieldInfoPtr_startPos, (void*) &value);
    }
  }

  public static unsafe Dictionary<string, ObjectPool<Card>> cardPools
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(CardManager.NativeFieldInfoPtr_cardPools, (void*) &num);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Dictionary<string, ObjectPool<Card>>) null : new Dictionary<string, ObjectPool<Card>>(pointer);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CardManager.NativeFieldInfoPtr_cardPools, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe bool init
  {
    get
    {
      bool init;
      IL2CPP.il2cpp_field_static_get_value(CardManager.NativeFieldInfoPtr_init, (void*) &init);
      return init;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CardManager.NativeFieldInfoPtr_init, (void*) &value);
    }
  }

  public AsyncOperationHandle<IList<GameObject>> cardIconLoadHandle
  {
    get
    {
      System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardManager.NativeFieldInfoPtr_cardIconLoadHandle);
      return new AsyncOperationHandle<IList<GameObject>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncOperationHandle<IList<GameObject>>>.NativeClassPtr, data));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardManager.NativeFieldInfoPtr_cardIconLoadHandle), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncOperationHandle<IList<GameObject>>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public static unsafe float SCALE
  {
    get
    {
      float scale;
      IL2CPP.il2cpp_field_static_get_value(CardManager.NativeFieldInfoPtr_SCALE, (void*) &scale);
      return scale;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CardManager.NativeFieldInfoPtr_SCALE, (void*) &value);
    }
  }

  public static unsafe float HOVER_SCALE
  {
    get
    {
      float hoverScale;
      IL2CPP.il2cpp_field_static_get_value(CardManager.NativeFieldInfoPtr_HOVER_SCALE, (void*) &hoverScale);
      return hoverScale;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CardManager.NativeFieldInfoPtr_HOVER_SCALE, (void*) &value);
    }
  }

  [ObfuscatedName("CardManager/<>c__DisplayClass7_0")]
  public sealed class __c__DisplayClass7_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_t;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__2;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__2_Internal_Void_Card_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass7_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardManager.__c__DisplayClass7_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CardManager.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35805, XrefRangeEnd = 35812, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Start_b__2(Card card)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) card)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CardManager.__c__DisplayClass7_0.NativeMethodInfoPtr__Start_b__2_Internal_Void_Card_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static __c__DisplayClass7_0()
    {
      Il2CppClassPointerStore<CardManager.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CardManager>.NativeClassPtr, "<>c__DisplayClass7_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardManager.__c__DisplayClass7_0>.NativeClassPtr);
      CardManager.__c__DisplayClass7_0.NativeFieldInfoPtr_t = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardManager.__c__DisplayClass7_0>.NativeClassPtr, nameof (t));
      CardManager.__c__DisplayClass7_0.NativeFieldInfoPtr___9__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardManager.__c__DisplayClass7_0>.NativeClassPtr, "<>9__2");
      CardManager.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardManager.__c__DisplayClass7_0>.NativeClassPtr, 100665690);
      CardManager.__c__DisplayClass7_0.NativeMethodInfoPtr__Start_b__2_Internal_Void_Card_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardManager.__c__DisplayClass7_0>.NativeClassPtr, 100665691);
    }

    public __c__DisplayClass7_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Transform t
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardManager.__c__DisplayClass7_0.NativeFieldInfoPtr_t));
        return pointer == System.IntPtr.Zero ? (Transform) null : new Transform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardManager.__c__DisplayClass7_0.NativeFieldInfoPtr_t), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppSystem.Action<Card> __9__2
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardManager.__c__DisplayClass7_0.NativeFieldInfoPtr___9__2));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<Card>) null : new Il2CppSystem.Action<Card>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardManager.__c__DisplayClass7_0.NativeFieldInfoPtr___9__2), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("CardManager/<>c__DisplayClass7_1")]
  public sealed class __c__DisplayClass7_1 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_prefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass7_0_0;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__0_Internal_Card_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass7_1()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardManager.__c__DisplayClass7_1>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CardManager.__c__DisplayClass7_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35812, XrefRangeEnd = 35861, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Card _Start_b__0()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardManager.__c__DisplayClass7_1.NativeMethodInfoPtr__Start_b__0_Internal_Card_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Card) null : new Card(pointer);
    }

    static __c__DisplayClass7_1()
    {
      Il2CppClassPointerStore<CardManager.__c__DisplayClass7_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CardManager>.NativeClassPtr, "<>c__DisplayClass7_1");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardManager.__c__DisplayClass7_1>.NativeClassPtr);
      CardManager.__c__DisplayClass7_1.NativeFieldInfoPtr_prefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardManager.__c__DisplayClass7_1>.NativeClassPtr, nameof (prefab));
      CardManager.__c__DisplayClass7_1.NativeFieldInfoPtr_field_Public___c__DisplayClass7_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardManager.__c__DisplayClass7_1>.NativeClassPtr, "CS$<>8__locals1");
      CardManager.__c__DisplayClass7_1.NativeFieldInfoPtr___9__0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardManager.__c__DisplayClass7_1>.NativeClassPtr, "<>9__0");
      CardManager.__c__DisplayClass7_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardManager.__c__DisplayClass7_1>.NativeClassPtr, 100665692);
      CardManager.__c__DisplayClass7_1.NativeMethodInfoPtr__Start_b__0_Internal_Card_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardManager.__c__DisplayClass7_1>.NativeClassPtr, 100665693);
    }

    public __c__DisplayClass7_1(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe GameObject prefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardManager.__c__DisplayClass7_1.NativeFieldInfoPtr_prefab));
        return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardManager.__c__DisplayClass7_1.NativeFieldInfoPtr_prefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CardManager.__c__DisplayClass7_0 field_Public___c__DisplayClass7_0_0
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardManager.__c__DisplayClass7_1.NativeFieldInfoPtr_field_Public___c__DisplayClass7_0_0));
        return pointer == System.IntPtr.Zero ? (CardManager.__c__DisplayClass7_0) null : new CardManager.__c__DisplayClass7_0(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardManager.__c__DisplayClass7_1.NativeFieldInfoPtr_field_Public___c__DisplayClass7_0_0), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppSystem.Func<Card> __9__0
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardManager.__c__DisplayClass7_1.NativeFieldInfoPtr___9__0));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<Card>) null : new Il2CppSystem.Func<Card>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardManager.__c__DisplayClass7_1.NativeFieldInfoPtr___9__0), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("CardManager/<>c")]
  [Serializable]
  public sealed class __c : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__7_1;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__7_3;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__7_1_Internal_Void_Card_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__7_3_Internal_Void_Card_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardManager.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CardManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35861, XrefRangeEnd = 35879, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Start_b__7_1(Card card)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) card)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CardManager.__c.NativeMethodInfoPtr__Start_b__7_1_Internal_Void_Card_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35879, XrefRangeEnd = 35885, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Start_b__7_3(Card card)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) card)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CardManager.__c.NativeMethodInfoPtr__Start_b__7_3_Internal_Void_Card_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static __c()
    {
      Il2CppClassPointerStore<CardManager.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CardManager>.NativeClassPtr, "<>c");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardManager.__c>.NativeClassPtr);
      CardManager.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardManager.__c>.NativeClassPtr, "<>9");
      CardManager.__c.NativeFieldInfoPtr___9__7_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardManager.__c>.NativeClassPtr, "<>9__7_1");
      CardManager.__c.NativeFieldInfoPtr___9__7_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardManager.__c>.NativeClassPtr, "<>9__7_3");
      CardManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardManager.__c>.NativeClassPtr, 100665695);
      CardManager.__c.NativeMethodInfoPtr__Start_b__7_1_Internal_Void_Card_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardManager.__c>.NativeClassPtr, 100665696);
      CardManager.__c.NativeMethodInfoPtr__Start_b__7_3_Internal_Void_Card_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardManager.__c>.NativeClassPtr, 100665697);
    }

    public __c(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe CardManager.__c __9
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(CardManager.__c.NativeFieldInfoPtr___9, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (CardManager.__c) null : new CardManager.__c(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CardManager.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Action<Card> __9__7_1
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(CardManager.__c.NativeFieldInfoPtr___9__7_1, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<Card>) null : new Il2CppSystem.Action<Card>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CardManager.__c.NativeFieldInfoPtr___9__7_1, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Action<Card> __9__7_3
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(CardManager.__c.NativeFieldInfoPtr___9__7_3, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<Card>) null : new Il2CppSystem.Action<Card>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CardManager.__c.NativeFieldInfoPtr___9__7_3, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("CardManager/<Start>d__7")]
  public sealed class _Start_d__7 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr___8__1;
    private static readonly System.IntPtr NativeFieldInfoPtr___8__2;
    private static readonly System.IntPtr NativeFieldInfoPtr___7__wrap1;
    private static readonly System.IntPtr NativeFieldInfoPtr__cardType_5__3;
    private static readonly System.IntPtr NativeFieldInfoPtr__handle_5__4;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    [CallerCount(53)]
    [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _Start_d__7(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardManager._Start_d__7>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CardManager._Start_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35885, XrefRangeEnd = 35892, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CardManager._Start_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35892, XrefRangeEnd = 36013, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardManager._Start_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36013, XrefRangeEnd = 36016, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void __m__Finally1()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CardManager._Start_d__7.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EGeneric\u002EIEnumerator\u003CSystem\u002EObject\u003E\u002ECurrent
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardManager._Start_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36016, XrefRangeEnd = 36022, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CardManager._Start_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardManager._Start_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    static _Start_d__7()
    {
      Il2CppClassPointerStore<CardManager._Start_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CardManager>.NativeClassPtr, "<Start>d__7");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardManager._Start_d__7>.NativeClassPtr);
      CardManager._Start_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardManager._Start_d__7>.NativeClassPtr, "<>1__state");
      CardManager._Start_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardManager._Start_d__7>.NativeClassPtr, "<>2__current");
      CardManager._Start_d__7.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardManager._Start_d__7>.NativeClassPtr, "<>4__this");
      CardManager._Start_d__7.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardManager._Start_d__7>.NativeClassPtr, "<>8__1");
      CardManager._Start_d__7.NativeFieldInfoPtr___8__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardManager._Start_d__7>.NativeClassPtr, "<>8__2");
      CardManager._Start_d__7.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardManager._Start_d__7>.NativeClassPtr, "<>7__wrap1");
      CardManager._Start_d__7.NativeFieldInfoPtr__cardType_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardManager._Start_d__7>.NativeClassPtr, "<cardType>5__3");
      CardManager._Start_d__7.NativeFieldInfoPtr__handle_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardManager._Start_d__7>.NativeClassPtr, "<handle>5__4");
      CardManager._Start_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardManager._Start_d__7>.NativeClassPtr, 100665698);
      CardManager._Start_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardManager._Start_d__7>.NativeClassPtr, 100665699);
      CardManager._Start_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardManager._Start_d__7>.NativeClassPtr, 100665700);
      CardManager._Start_d__7.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardManager._Start_d__7>.NativeClassPtr, 100665701);
      CardManager._Start_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardManager._Start_d__7>.NativeClassPtr, 100665702);
      CardManager._Start_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardManager._Start_d__7>.NativeClassPtr, 100665703);
      CardManager._Start_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardManager._Start_d__7>.NativeClassPtr, 100665704);
    }

    public _Start_d__7(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardManager._Start_d__7.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardManager._Start_d__7.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardManager._Start_d__7.NativeFieldInfoPtr___2__current));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardManager._Start_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CardManager __4__this
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardManager._Start_d__7.NativeFieldInfoPtr___4__this));
        return pointer == System.IntPtr.Zero ? (CardManager) null : new CardManager(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardManager._Start_d__7.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CardManager.__c__DisplayClass7_0 __8__1
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardManager._Start_d__7.NativeFieldInfoPtr___8__1));
        return pointer == System.IntPtr.Zero ? (CardManager.__c__DisplayClass7_0) null : new CardManager.__c__DisplayClass7_0(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardManager._Start_d__7.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CardManager.__c__DisplayClass7_1 __8__2
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardManager._Start_d__7.NativeFieldInfoPtr___8__2));
        return pointer == System.IntPtr.Zero ? (CardManager.__c__DisplayClass7_1) null : new CardManager.__c__DisplayClass7_1(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardManager._Start_d__7.NativeFieldInfoPtr___8__2), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public List<CardType>.Enumerator __7__wrap1
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardManager._Start_d__7.NativeFieldInfoPtr___7__wrap1);
        return new List<CardType>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<CardType>.Enumerator>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardManager._Start_d__7.NativeFieldInfoPtr___7__wrap1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<CardType>.Enumerator>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe CardType _cardType_5__3
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardManager._Start_d__7.NativeFieldInfoPtr__cardType_5__3));
        return pointer == System.IntPtr.Zero ? (CardType) null : new CardType(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardManager._Start_d__7.NativeFieldInfoPtr__cardType_5__3), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public AsyncOperationHandle<GameObject> _handle_5__4
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardManager._Start_d__7.NativeFieldInfoPtr__handle_5__4);
        return new AsyncOperationHandle<GameObject>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncOperationHandle<GameObject>>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardManager._Start_d__7.NativeFieldInfoPtr__handle_5__4), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncOperationHandle<GameObject>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }

  [ObfuscatedName("CardManager/<ReturnToPoolNextFrameRoutine>d__15")]
  public sealed class _ReturnToPoolNextFrameRoutine_d__15 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr_card;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    [CallerCount(53)]
    [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _ReturnToPoolNextFrameRoutine_d__15(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardManager._ReturnToPoolNextFrameRoutine_d__15>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CardManager._ReturnToPoolNextFrameRoutine_d__15.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(12611)]
    [CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12665, XrefRangeStart = 54, XrefRangeEnd = 12665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CardManager._ReturnToPoolNextFrameRoutine_d__15.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36022, XrefRangeEnd = 36024, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardManager._ReturnToPoolNextFrameRoutine_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EGeneric\u002EIEnumerator\u003CSystem\u002EObject\u003E\u002ECurrent
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardManager._ReturnToPoolNextFrameRoutine_d__15.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36024, XrefRangeEnd = 36030, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CardManager._ReturnToPoolNextFrameRoutine_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardManager._ReturnToPoolNextFrameRoutine_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    static _ReturnToPoolNextFrameRoutine_d__15()
    {
      Il2CppClassPointerStore<CardManager._ReturnToPoolNextFrameRoutine_d__15>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CardManager>.NativeClassPtr, "<ReturnToPoolNextFrameRoutine>d__15");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardManager._ReturnToPoolNextFrameRoutine_d__15>.NativeClassPtr);
      CardManager._ReturnToPoolNextFrameRoutine_d__15.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardManager._ReturnToPoolNextFrameRoutine_d__15>.NativeClassPtr, "<>1__state");
      CardManager._ReturnToPoolNextFrameRoutine_d__15.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardManager._ReturnToPoolNextFrameRoutine_d__15>.NativeClassPtr, "<>2__current");
      CardManager._ReturnToPoolNextFrameRoutine_d__15.NativeFieldInfoPtr_card = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardManager._ReturnToPoolNextFrameRoutine_d__15>.NativeClassPtr, nameof (card));
      CardManager._ReturnToPoolNextFrameRoutine_d__15.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardManager._ReturnToPoolNextFrameRoutine_d__15>.NativeClassPtr, 100665705);
      CardManager._ReturnToPoolNextFrameRoutine_d__15.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardManager._ReturnToPoolNextFrameRoutine_d__15>.NativeClassPtr, 100665706);
      CardManager._ReturnToPoolNextFrameRoutine_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardManager._ReturnToPoolNextFrameRoutine_d__15>.NativeClassPtr, 100665707);
      CardManager._ReturnToPoolNextFrameRoutine_d__15.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardManager._ReturnToPoolNextFrameRoutine_d__15>.NativeClassPtr, 100665708);
      CardManager._ReturnToPoolNextFrameRoutine_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardManager._ReturnToPoolNextFrameRoutine_d__15>.NativeClassPtr, 100665709);
      CardManager._ReturnToPoolNextFrameRoutine_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardManager._ReturnToPoolNextFrameRoutine_d__15>.NativeClassPtr, 100665710);
    }

    public _ReturnToPoolNextFrameRoutine_d__15(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardManager._ReturnToPoolNextFrameRoutine_d__15.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardManager._ReturnToPoolNextFrameRoutine_d__15.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardManager._ReturnToPoolNextFrameRoutine_d__15.NativeFieldInfoPtr___2__current));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardManager._ReturnToPoolNextFrameRoutine_d__15.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Card card
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardManager._ReturnToPoolNextFrameRoutine_d__15.NativeFieldInfoPtr_card));
        return pointer == System.IntPtr.Zero ? (Card) null : new Card(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardManager._ReturnToPoolNextFrameRoutine_d__15.NativeFieldInfoPtr_card), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
