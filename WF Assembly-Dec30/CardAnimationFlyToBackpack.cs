// Decompiled with JetBrains decompiler
// Type: CardAnimationFlyToBackpack
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class CardAnimationFlyToBackpack : CardAnimation
{
  private static readonly System.IntPtr NativeFieldInfoPtr_xCurve;
  private static readonly System.IntPtr NativeFieldInfoPtr_yCurve;
  private static readonly System.IntPtr NativeFieldInfoPtr_zCurve;
  private static readonly System.IntPtr NativeFieldInfoPtr_spinCurve;
  private static readonly System.IntPtr NativeFieldInfoPtr_scaleCurve;
  private static readonly System.IntPtr NativeFieldInfoPtr_destroyOnEnd;
  private static readonly System.IntPtr NativeFieldInfoPtr_fixedDuration;
  private static readonly System.IntPtr NativeFieldInfoPtr_duration;
  private static readonly System.IntPtr NativeFieldInfoPtr_durationToDistance;
  private static readonly System.IntPtr NativeFieldInfoPtr_glowMain;
  private static readonly System.IntPtr NativeFieldInfoPtr_glowMainSize;
  private static readonly System.IntPtr NativeFieldInfoPtr_glowExtra;
  private static readonly System.IntPtr NativeFieldInfoPtr_glowExtraCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_glowExtraArea;
  private static readonly System.IntPtr NativeFieldInfoPtr_glowExtraSizeRange;
  private static readonly System.IntPtr NativeFieldInfoPtr_glowExtraDelay;
  private static readonly System.IntPtr NativeFieldInfoPtr_glowPrefab;
  private static readonly System.IntPtr NativeFieldInfoPtr_yUpCurve;
  private static readonly System.IntPtr NativeFieldInfoPtr_yUpAmount;
  private static readonly System.IntPtr NativeMethodInfoPtr_Routine_Public_Virtual_IEnumerator_Object_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107983, XrefRangeEnd = 107989, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe IEnumerator Routine(Il2CppSystem.Object data, float startDelay = 0.0f)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &startDelay;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CardAnimationFlyToBackpack.NativeMethodInfoPtr_Routine_Public_Virtual_IEnumerator_Object_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107989, XrefRangeEnd = 107991, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CardAnimationFlyToBackpack()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardAnimationFlyToBackpack>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardAnimationFlyToBackpack.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static CardAnimationFlyToBackpack()
  {
    Il2CppClassPointerStore<CardAnimationFlyToBackpack>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (CardAnimationFlyToBackpack));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardAnimationFlyToBackpack>.NativeClassPtr);
    CardAnimationFlyToBackpack.NativeFieldInfoPtr_xCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardAnimationFlyToBackpack>.NativeClassPtr, nameof (xCurve));
    CardAnimationFlyToBackpack.NativeFieldInfoPtr_yCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardAnimationFlyToBackpack>.NativeClassPtr, nameof (yCurve));
    CardAnimationFlyToBackpack.NativeFieldInfoPtr_zCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardAnimationFlyToBackpack>.NativeClassPtr, nameof (zCurve));
    CardAnimationFlyToBackpack.NativeFieldInfoPtr_spinCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardAnimationFlyToBackpack>.NativeClassPtr, nameof (spinCurve));
    CardAnimationFlyToBackpack.NativeFieldInfoPtr_scaleCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardAnimationFlyToBackpack>.NativeClassPtr, nameof (scaleCurve));
    CardAnimationFlyToBackpack.NativeFieldInfoPtr_destroyOnEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardAnimationFlyToBackpack>.NativeClassPtr, nameof (destroyOnEnd));
    CardAnimationFlyToBackpack.NativeFieldInfoPtr_fixedDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardAnimationFlyToBackpack>.NativeClassPtr, nameof (fixedDuration));
    CardAnimationFlyToBackpack.NativeFieldInfoPtr_duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardAnimationFlyToBackpack>.NativeClassPtr, nameof (duration));
    CardAnimationFlyToBackpack.NativeFieldInfoPtr_durationToDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardAnimationFlyToBackpack>.NativeClassPtr, nameof (durationToDistance));
    CardAnimationFlyToBackpack.NativeFieldInfoPtr_glowMain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardAnimationFlyToBackpack>.NativeClassPtr, nameof (glowMain));
    CardAnimationFlyToBackpack.NativeFieldInfoPtr_glowMainSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardAnimationFlyToBackpack>.NativeClassPtr, nameof (glowMainSize));
    CardAnimationFlyToBackpack.NativeFieldInfoPtr_glowExtra = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardAnimationFlyToBackpack>.NativeClassPtr, nameof (glowExtra));
    CardAnimationFlyToBackpack.NativeFieldInfoPtr_glowExtraCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardAnimationFlyToBackpack>.NativeClassPtr, nameof (glowExtraCount));
    CardAnimationFlyToBackpack.NativeFieldInfoPtr_glowExtraArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardAnimationFlyToBackpack>.NativeClassPtr, nameof (glowExtraArea));
    CardAnimationFlyToBackpack.NativeFieldInfoPtr_glowExtraSizeRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardAnimationFlyToBackpack>.NativeClassPtr, nameof (glowExtraSizeRange));
    CardAnimationFlyToBackpack.NativeFieldInfoPtr_glowExtraDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardAnimationFlyToBackpack>.NativeClassPtr, nameof (glowExtraDelay));
    CardAnimationFlyToBackpack.NativeFieldInfoPtr_glowPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardAnimationFlyToBackpack>.NativeClassPtr, nameof (glowPrefab));
    CardAnimationFlyToBackpack.NativeFieldInfoPtr_yUpCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardAnimationFlyToBackpack>.NativeClassPtr, nameof (yUpCurve));
    CardAnimationFlyToBackpack.NativeFieldInfoPtr_yUpAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardAnimationFlyToBackpack>.NativeClassPtr, nameof (yUpAmount));
    CardAnimationFlyToBackpack.NativeMethodInfoPtr_Routine_Public_Virtual_IEnumerator_Object_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardAnimationFlyToBackpack>.NativeClassPtr, 100673194);
    CardAnimationFlyToBackpack.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardAnimationFlyToBackpack>.NativeClassPtr, 100673195);
  }

  public CardAnimationFlyToBackpack(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe AnimationCurve xCurve
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationFlyToBackpack.NativeFieldInfoPtr_xCurve));
      return pointer == System.IntPtr.Zero ? (AnimationCurve) null : new AnimationCurve(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationFlyToBackpack.NativeFieldInfoPtr_xCurve), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe AnimationCurve yCurve
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationFlyToBackpack.NativeFieldInfoPtr_yCurve));
      return pointer == System.IntPtr.Zero ? (AnimationCurve) null : new AnimationCurve(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationFlyToBackpack.NativeFieldInfoPtr_yCurve), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe AnimationCurve zCurve
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationFlyToBackpack.NativeFieldInfoPtr_zCurve));
      return pointer == System.IntPtr.Zero ? (AnimationCurve) null : new AnimationCurve(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationFlyToBackpack.NativeFieldInfoPtr_zCurve), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe AnimationCurve spinCurve
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationFlyToBackpack.NativeFieldInfoPtr_spinCurve));
      return pointer == System.IntPtr.Zero ? (AnimationCurve) null : new AnimationCurve(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationFlyToBackpack.NativeFieldInfoPtr_spinCurve), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe AnimationCurve scaleCurve
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationFlyToBackpack.NativeFieldInfoPtr_scaleCurve));
      return pointer == System.IntPtr.Zero ? (AnimationCurve) null : new AnimationCurve(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationFlyToBackpack.NativeFieldInfoPtr_scaleCurve), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool destroyOnEnd
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationFlyToBackpack.NativeFieldInfoPtr_destroyOnEnd));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationFlyToBackpack.NativeFieldInfoPtr_destroyOnEnd)) = value;
    }
  }

  public unsafe bool fixedDuration
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationFlyToBackpack.NativeFieldInfoPtr_fixedDuration));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationFlyToBackpack.NativeFieldInfoPtr_fixedDuration)) = value;
    }
  }

  public unsafe float duration
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationFlyToBackpack.NativeFieldInfoPtr_duration));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationFlyToBackpack.NativeFieldInfoPtr_duration)) = value;
    }
  }

  public unsafe AnimationCurve durationToDistance
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationFlyToBackpack.NativeFieldInfoPtr_durationToDistance));
      return pointer == System.IntPtr.Zero ? (AnimationCurve) null : new AnimationCurve(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationFlyToBackpack.NativeFieldInfoPtr_durationToDistance), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe AnimationCurve glowMain
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationFlyToBackpack.NativeFieldInfoPtr_glowMain));
      return pointer == System.IntPtr.Zero ? (AnimationCurve) null : new AnimationCurve(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationFlyToBackpack.NativeFieldInfoPtr_glowMain), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector2 glowMainSize
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationFlyToBackpack.NativeFieldInfoPtr_glowMainSize));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationFlyToBackpack.NativeFieldInfoPtr_glowMainSize)) = value;
    }
  }

  public unsafe AnimationCurve glowExtra
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationFlyToBackpack.NativeFieldInfoPtr_glowExtra));
      return pointer == System.IntPtr.Zero ? (AnimationCurve) null : new AnimationCurve(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationFlyToBackpack.NativeFieldInfoPtr_glowExtra), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int glowExtraCount
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationFlyToBackpack.NativeFieldInfoPtr_glowExtraCount));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationFlyToBackpack.NativeFieldInfoPtr_glowExtraCount)) = value;
    }
  }

  public unsafe Rect glowExtraArea
  {
    get
    {
      return *(Rect*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationFlyToBackpack.NativeFieldInfoPtr_glowExtraArea));
    }
    [param: In] set
    {
      *(Rect*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationFlyToBackpack.NativeFieldInfoPtr_glowExtraArea)) = value;
    }
  }

  public unsafe Vector2 glowExtraSizeRange
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationFlyToBackpack.NativeFieldInfoPtr_glowExtraSizeRange));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationFlyToBackpack.NativeFieldInfoPtr_glowExtraSizeRange)) = value;
    }
  }

  public unsafe Vector2 glowExtraDelay
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationFlyToBackpack.NativeFieldInfoPtr_glowExtraDelay));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationFlyToBackpack.NativeFieldInfoPtr_glowExtraDelay)) = value;
    }
  }

  public unsafe Glow glowPrefab
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationFlyToBackpack.NativeFieldInfoPtr_glowPrefab));
      return pointer == System.IntPtr.Zero ? (Glow) null : new Glow(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationFlyToBackpack.NativeFieldInfoPtr_glowPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe AnimationCurve yUpCurve
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationFlyToBackpack.NativeFieldInfoPtr_yUpCurve));
      return pointer == System.IntPtr.Zero ? (AnimationCurve) null : new AnimationCurve(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationFlyToBackpack.NativeFieldInfoPtr_yUpCurve), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float yUpAmount
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationFlyToBackpack.NativeFieldInfoPtr_yUpAmount));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationFlyToBackpack.NativeFieldInfoPtr_yUpAmount)) = value;
    }
  }

  [ObfuscatedName("CardAnimationFlyToBackpack/<Routine>d__19")]
  public sealed class _Routine_d__19 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr_data;
    private static readonly System.IntPtr NativeFieldInfoPtr_startDelay;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr__entity_5__2;
    private static readonly System.IntPtr NativeFieldInfoPtr__target_5__3;
    private static readonly System.IntPtr NativeFieldInfoPtr__deckpack_5__4;
    private static readonly System.IntPtr NativeFieldInfoPtr__wobblers_5__5;
    private static readonly System.IntPtr NativeFieldInfoPtr__start_5__6;
    private static readonly System.IntPtr NativeFieldInfoPtr__offset_5__7;
    private static readonly System.IntPtr NativeFieldInfoPtr__t_5__8;
    private static readonly System.IntPtr NativeFieldInfoPtr__z_5__9;
    private static readonly System.IntPtr NativeFieldInfoPtr__scale_5__10;
    private static readonly System.IntPtr NativeFieldInfoPtr__dur_5__11;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    [CallerCount(53)]
    [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _Routine_d__19(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardAnimationFlyToBackpack._Routine_d__19>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CardAnimationFlyToBackpack._Routine_d__19.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(12611)]
    [CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12665, XrefRangeStart = 54, XrefRangeEnd = 12665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CardAnimationFlyToBackpack._Routine_d__19.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107928, XrefRangeEnd = 107977, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardAnimationFlyToBackpack._Routine_d__19.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardAnimationFlyToBackpack._Routine_d__19.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107977, XrefRangeEnd = 107983, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CardAnimationFlyToBackpack._Routine_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardAnimationFlyToBackpack._Routine_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    static _Routine_d__19()
    {
      Il2CppClassPointerStore<CardAnimationFlyToBackpack._Routine_d__19>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CardAnimationFlyToBackpack>.NativeClassPtr, "<Routine>d__19");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardAnimationFlyToBackpack._Routine_d__19>.NativeClassPtr);
      CardAnimationFlyToBackpack._Routine_d__19.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardAnimationFlyToBackpack._Routine_d__19>.NativeClassPtr, "<>1__state");
      CardAnimationFlyToBackpack._Routine_d__19.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardAnimationFlyToBackpack._Routine_d__19>.NativeClassPtr, "<>2__current");
      CardAnimationFlyToBackpack._Routine_d__19.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardAnimationFlyToBackpack._Routine_d__19>.NativeClassPtr, nameof (data));
      CardAnimationFlyToBackpack._Routine_d__19.NativeFieldInfoPtr_startDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardAnimationFlyToBackpack._Routine_d__19>.NativeClassPtr, nameof (startDelay));
      CardAnimationFlyToBackpack._Routine_d__19.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardAnimationFlyToBackpack._Routine_d__19>.NativeClassPtr, "<>4__this");
      CardAnimationFlyToBackpack._Routine_d__19.NativeFieldInfoPtr__entity_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardAnimationFlyToBackpack._Routine_d__19>.NativeClassPtr, "<entity>5__2");
      CardAnimationFlyToBackpack._Routine_d__19.NativeFieldInfoPtr__target_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardAnimationFlyToBackpack._Routine_d__19>.NativeClassPtr, "<target>5__3");
      CardAnimationFlyToBackpack._Routine_d__19.NativeFieldInfoPtr__deckpack_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardAnimationFlyToBackpack._Routine_d__19>.NativeClassPtr, "<deckpack>5__4");
      CardAnimationFlyToBackpack._Routine_d__19.NativeFieldInfoPtr__wobblers_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardAnimationFlyToBackpack._Routine_d__19>.NativeClassPtr, "<wobblers>5__5");
      CardAnimationFlyToBackpack._Routine_d__19.NativeFieldInfoPtr__start_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardAnimationFlyToBackpack._Routine_d__19>.NativeClassPtr, "<start>5__6");
      CardAnimationFlyToBackpack._Routine_d__19.NativeFieldInfoPtr__offset_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardAnimationFlyToBackpack._Routine_d__19>.NativeClassPtr, "<offset>5__7");
      CardAnimationFlyToBackpack._Routine_d__19.NativeFieldInfoPtr__t_5__8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardAnimationFlyToBackpack._Routine_d__19>.NativeClassPtr, "<t>5__8");
      CardAnimationFlyToBackpack._Routine_d__19.NativeFieldInfoPtr__z_5__9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardAnimationFlyToBackpack._Routine_d__19>.NativeClassPtr, "<z>5__9");
      CardAnimationFlyToBackpack._Routine_d__19.NativeFieldInfoPtr__scale_5__10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardAnimationFlyToBackpack._Routine_d__19>.NativeClassPtr, "<scale>5__10");
      CardAnimationFlyToBackpack._Routine_d__19.NativeFieldInfoPtr__dur_5__11 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardAnimationFlyToBackpack._Routine_d__19>.NativeClassPtr, "<dur>5__11");
      CardAnimationFlyToBackpack._Routine_d__19.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardAnimationFlyToBackpack._Routine_d__19>.NativeClassPtr, 100673196);
      CardAnimationFlyToBackpack._Routine_d__19.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardAnimationFlyToBackpack._Routine_d__19>.NativeClassPtr, 100673197);
      CardAnimationFlyToBackpack._Routine_d__19.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardAnimationFlyToBackpack._Routine_d__19>.NativeClassPtr, 100673198);
      CardAnimationFlyToBackpack._Routine_d__19.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardAnimationFlyToBackpack._Routine_d__19>.NativeClassPtr, 100673199);
      CardAnimationFlyToBackpack._Routine_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardAnimationFlyToBackpack._Routine_d__19>.NativeClassPtr, 100673200);
      CardAnimationFlyToBackpack._Routine_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardAnimationFlyToBackpack._Routine_d__19>.NativeClassPtr, 100673201);
    }

    public _Routine_d__19(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationFlyToBackpack._Routine_d__19.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationFlyToBackpack._Routine_d__19.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationFlyToBackpack._Routine_d__19.NativeFieldInfoPtr___2__current));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationFlyToBackpack._Routine_d__19.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppSystem.Object data
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationFlyToBackpack._Routine_d__19.NativeFieldInfoPtr_data));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationFlyToBackpack._Routine_d__19.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float startDelay
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationFlyToBackpack._Routine_d__19.NativeFieldInfoPtr_startDelay));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationFlyToBackpack._Routine_d__19.NativeFieldInfoPtr_startDelay)) = value;
      }
    }

    public unsafe CardAnimationFlyToBackpack __4__this
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationFlyToBackpack._Routine_d__19.NativeFieldInfoPtr___4__this));
        return pointer == System.IntPtr.Zero ? (CardAnimationFlyToBackpack) null : new CardAnimationFlyToBackpack(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationFlyToBackpack._Routine_d__19.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Entity _entity_5__2
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationFlyToBackpack._Routine_d__19.NativeFieldInfoPtr__entity_5__2));
        return pointer == System.IntPtr.Zero ? (Entity) null : new Entity(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationFlyToBackpack._Routine_d__19.NativeFieldInfoPtr__entity_5__2), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Transform _target_5__3
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationFlyToBackpack._Routine_d__19.NativeFieldInfoPtr__target_5__3));
        return pointer == System.IntPtr.Zero ? (Transform) null : new Transform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationFlyToBackpack._Routine_d__19.NativeFieldInfoPtr__target_5__3), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Deckpack _deckpack_5__4
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationFlyToBackpack._Routine_d__19.NativeFieldInfoPtr__deckpack_5__4));
        return pointer == System.IntPtr.Zero ? (Deckpack) null : new Deckpack(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationFlyToBackpack._Routine_d__19.NativeFieldInfoPtr__deckpack_5__4), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppReferenceArray<AngleWobbler> _wobblers_5__5
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationFlyToBackpack._Routine_d__19.NativeFieldInfoPtr__wobblers_5__5));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<AngleWobbler>) null : new Il2CppReferenceArray<AngleWobbler>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationFlyToBackpack._Routine_d__19.NativeFieldInfoPtr__wobblers_5__5), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Vector3 _start_5__6
    {
      get
      {
        return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationFlyToBackpack._Routine_d__19.NativeFieldInfoPtr__start_5__6));
      }
      [param: In] set
      {
        *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationFlyToBackpack._Routine_d__19.NativeFieldInfoPtr__start_5__6)) = value;
      }
    }

    public unsafe Vector3 _offset_5__7
    {
      get
      {
        return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationFlyToBackpack._Routine_d__19.NativeFieldInfoPtr__offset_5__7));
      }
      [param: In] set
      {
        *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationFlyToBackpack._Routine_d__19.NativeFieldInfoPtr__offset_5__7)) = value;
      }
    }

    public unsafe float _t_5__8
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationFlyToBackpack._Routine_d__19.NativeFieldInfoPtr__t_5__8));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationFlyToBackpack._Routine_d__19.NativeFieldInfoPtr__t_5__8)) = value;
      }
    }

    public unsafe float _z_5__9
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationFlyToBackpack._Routine_d__19.NativeFieldInfoPtr__z_5__9));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationFlyToBackpack._Routine_d__19.NativeFieldInfoPtr__z_5__9)) = value;
      }
    }

    public unsafe Vector3 _scale_5__10
    {
      get
      {
        return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationFlyToBackpack._Routine_d__19.NativeFieldInfoPtr__scale_5__10));
      }
      [param: In] set
      {
        *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationFlyToBackpack._Routine_d__19.NativeFieldInfoPtr__scale_5__10)) = value;
      }
    }

    public unsafe float _dur_5__11
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationFlyToBackpack._Routine_d__19.NativeFieldInfoPtr__dur_5__11));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationFlyToBackpack._Routine_d__19.NativeFieldInfoPtr__dur_5__11)) = value;
      }
    }
  }
}
