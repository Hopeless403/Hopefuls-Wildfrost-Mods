// Decompiled with JetBrains decompiler
// Type: CardAnimationMinibossIntro
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class CardAnimationMinibossIntro : CardAnimation
{
  private static readonly System.IntPtr NativeFieldInfoPtr_rumbleAmount;
  private static readonly System.IntPtr NativeFieldInfoPtr_wobbleAmount;
  private static readonly System.IntPtr NativeFieldInfoPtr_scaleTween;
  private static readonly System.IntPtr NativeFieldInfoPtr_scaleTo;
  private static readonly System.IntPtr NativeFieldInfoPtr_rotateTween;
  private static readonly System.IntPtr NativeFieldInfoPtr_rotateAmount;
  private static readonly System.IntPtr NativeMethodInfoPtr_Routine_Public_Virtual_IEnumerator_Object_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108016, XrefRangeEnd = 108022, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe IEnumerator Routine(Il2CppSystem.Object data, float startDelay = 0.0f)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &startDelay;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CardAnimationMinibossIntro.NativeMethodInfoPtr_Routine_Public_Virtual_IEnumerator_Object_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108022, XrefRangeEnd = 108023, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CardAnimationMinibossIntro()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardAnimationMinibossIntro>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardAnimationMinibossIntro.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static CardAnimationMinibossIntro()
  {
    Il2CppClassPointerStore<CardAnimationMinibossIntro>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (CardAnimationMinibossIntro));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardAnimationMinibossIntro>.NativeClassPtr);
    CardAnimationMinibossIntro.NativeFieldInfoPtr_rumbleAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardAnimationMinibossIntro>.NativeClassPtr, nameof (rumbleAmount));
    CardAnimationMinibossIntro.NativeFieldInfoPtr_wobbleAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardAnimationMinibossIntro>.NativeClassPtr, nameof (wobbleAmount));
    CardAnimationMinibossIntro.NativeFieldInfoPtr_scaleTween = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardAnimationMinibossIntro>.NativeClassPtr, nameof (scaleTween));
    CardAnimationMinibossIntro.NativeFieldInfoPtr_scaleTo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardAnimationMinibossIntro>.NativeClassPtr, nameof (scaleTo));
    CardAnimationMinibossIntro.NativeFieldInfoPtr_rotateTween = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardAnimationMinibossIntro>.NativeClassPtr, nameof (rotateTween));
    CardAnimationMinibossIntro.NativeFieldInfoPtr_rotateAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardAnimationMinibossIntro>.NativeClassPtr, nameof (rotateAmount));
    CardAnimationMinibossIntro.NativeMethodInfoPtr_Routine_Public_Virtual_IEnumerator_Object_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardAnimationMinibossIntro>.NativeClassPtr, 100673202);
    CardAnimationMinibossIntro.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardAnimationMinibossIntro>.NativeClassPtr, 100673203);
  }

  public CardAnimationMinibossIntro(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe float rumbleAmount
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationMinibossIntro.NativeFieldInfoPtr_rumbleAmount));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationMinibossIntro.NativeFieldInfoPtr_rumbleAmount)) = value;
    }
  }

  public unsafe float wobbleAmount
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationMinibossIntro.NativeFieldInfoPtr_wobbleAmount));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationMinibossIntro.NativeFieldInfoPtr_wobbleAmount)) = value;
    }
  }

  public CurveProfile scaleTween
  {
    get
    {
      System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationMinibossIntro.NativeFieldInfoPtr_scaleTween);
      return new CurveProfile(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CurveProfile>.NativeClassPtr, data));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationMinibossIntro.NativeFieldInfoPtr_scaleTween), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CurveProfile>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public unsafe Vector3 scaleTo
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationMinibossIntro.NativeFieldInfoPtr_scaleTo));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationMinibossIntro.NativeFieldInfoPtr_scaleTo)) = value;
    }
  }

  public CurveProfile rotateTween
  {
    get
    {
      System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationMinibossIntro.NativeFieldInfoPtr_rotateTween);
      return new CurveProfile(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CurveProfile>.NativeClassPtr, data));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationMinibossIntro.NativeFieldInfoPtr_rotateTween), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CurveProfile>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public unsafe Vector3 rotateAmount
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationMinibossIntro.NativeFieldInfoPtr_rotateAmount));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationMinibossIntro.NativeFieldInfoPtr_rotateAmount)) = value;
    }
  }

  [ObfuscatedName("CardAnimationMinibossIntro/<Routine>d__6")]
  public sealed class _Routine_d__6 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr_data;
    private static readonly System.IntPtr NativeFieldInfoPtr_startDelay;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr__target_5__2;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    [CallerCount(53)]
    [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _Routine_d__6(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardAnimationMinibossIntro._Routine_d__6>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CardAnimationMinibossIntro._Routine_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(12611)]
    [CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12665, XrefRangeStart = 54, XrefRangeEnd = 12665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CardAnimationMinibossIntro._Routine_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107991, XrefRangeEnd = 108010, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardAnimationMinibossIntro._Routine_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardAnimationMinibossIntro._Routine_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108010, XrefRangeEnd = 108016, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CardAnimationMinibossIntro._Routine_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardAnimationMinibossIntro._Routine_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    static _Routine_d__6()
    {
      Il2CppClassPointerStore<CardAnimationMinibossIntro._Routine_d__6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CardAnimationMinibossIntro>.NativeClassPtr, "<Routine>d__6");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardAnimationMinibossIntro._Routine_d__6>.NativeClassPtr);
      CardAnimationMinibossIntro._Routine_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardAnimationMinibossIntro._Routine_d__6>.NativeClassPtr, "<>1__state");
      CardAnimationMinibossIntro._Routine_d__6.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardAnimationMinibossIntro._Routine_d__6>.NativeClassPtr, "<>2__current");
      CardAnimationMinibossIntro._Routine_d__6.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardAnimationMinibossIntro._Routine_d__6>.NativeClassPtr, nameof (data));
      CardAnimationMinibossIntro._Routine_d__6.NativeFieldInfoPtr_startDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardAnimationMinibossIntro._Routine_d__6>.NativeClassPtr, nameof (startDelay));
      CardAnimationMinibossIntro._Routine_d__6.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardAnimationMinibossIntro._Routine_d__6>.NativeClassPtr, "<>4__this");
      CardAnimationMinibossIntro._Routine_d__6.NativeFieldInfoPtr__target_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardAnimationMinibossIntro._Routine_d__6>.NativeClassPtr, "<target>5__2");
      CardAnimationMinibossIntro._Routine_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardAnimationMinibossIntro._Routine_d__6>.NativeClassPtr, 100673204);
      CardAnimationMinibossIntro._Routine_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardAnimationMinibossIntro._Routine_d__6>.NativeClassPtr, 100673205);
      CardAnimationMinibossIntro._Routine_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardAnimationMinibossIntro._Routine_d__6>.NativeClassPtr, 100673206);
      CardAnimationMinibossIntro._Routine_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardAnimationMinibossIntro._Routine_d__6>.NativeClassPtr, 100673207);
      CardAnimationMinibossIntro._Routine_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardAnimationMinibossIntro._Routine_d__6>.NativeClassPtr, 100673208);
      CardAnimationMinibossIntro._Routine_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardAnimationMinibossIntro._Routine_d__6>.NativeClassPtr, 100673209);
    }

    public _Routine_d__6(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationMinibossIntro._Routine_d__6.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationMinibossIntro._Routine_d__6.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationMinibossIntro._Routine_d__6.NativeFieldInfoPtr___2__current));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationMinibossIntro._Routine_d__6.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppSystem.Object data
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationMinibossIntro._Routine_d__6.NativeFieldInfoPtr_data));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationMinibossIntro._Routine_d__6.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float startDelay
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationMinibossIntro._Routine_d__6.NativeFieldInfoPtr_startDelay));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationMinibossIntro._Routine_d__6.NativeFieldInfoPtr_startDelay)) = value;
      }
    }

    public unsafe CardAnimationMinibossIntro __4__this
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationMinibossIntro._Routine_d__6.NativeFieldInfoPtr___4__this));
        return pointer == System.IntPtr.Zero ? (CardAnimationMinibossIntro) null : new CardAnimationMinibossIntro(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationMinibossIntro._Routine_d__6.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Entity _target_5__2
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationMinibossIntro._Routine_d__6.NativeFieldInfoPtr__target_5__2));
        return pointer == System.IntPtr.Zero ? (Entity) null : new Entity(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardAnimationMinibossIntro._Routine_d__6.NativeFieldInfoPtr__target_5__2), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
