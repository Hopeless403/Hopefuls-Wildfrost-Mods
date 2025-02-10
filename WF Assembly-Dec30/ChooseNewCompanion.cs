// Decompiled with JetBrains decompiler
// Type: ChooseNewCompanion
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
public class ChooseNewCompanion : UISequence
{
  private static readonly System.IntPtr NativeFieldInfoPtr_sequence;
  private static readonly System.IntPtr NativeFieldInfoPtr_cardSelector;
  private static readonly System.IntPtr NativeFieldInfoPtr_cardController;
  private static readonly System.IntPtr NativeFieldInfoPtr_cardContainer;
  private static readonly System.IntPtr NativeFieldInfoPtr_rewardOptions;
  private static readonly System.IntPtr NativeFieldInfoPtr_topBanner;
  private static readonly System.IntPtr NativeFieldInfoPtr_bottomBanner;
  private static readonly System.IntPtr NativeFieldInfoPtr_background;
  private static readonly System.IntPtr NativeFieldInfoPtr_bannerTweenDur;
  private static readonly System.IntPtr NativeFieldInfoPtr_bannerTweenEase;
  private static readonly System.IntPtr NativeFieldInfoPtr_bannerTweenOutDur;
  private static readonly System.IntPtr NativeFieldInfoPtr_bannerTweenOutEase;
  private static readonly System.IntPtr NativeFieldInfoPtr_storedRewards;
  private static readonly System.IntPtr NativeMethodInfoPtr_Run_Public_Virtual_IEnumerator_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Populate_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38051, XrefRangeEnd = 38056, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe IEnumerator Run()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ChooseNewCompanion.NativeMethodInfoPtr_Run_Public_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38056, XrefRangeEnd = 38115, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Populate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ChooseNewCompanion.NativeMethodInfoPtr_Populate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38115, XrefRangeEnd = 38116, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ChooseNewCompanion()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChooseNewCompanion>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ChooseNewCompanion.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static ChooseNewCompanion()
  {
    Il2CppClassPointerStore<ChooseNewCompanion>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (ChooseNewCompanion));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChooseNewCompanion>.NativeClassPtr);
    ChooseNewCompanion.NativeFieldInfoPtr_sequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChooseNewCompanion>.NativeClassPtr, nameof (sequence));
    ChooseNewCompanion.NativeFieldInfoPtr_cardSelector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChooseNewCompanion>.NativeClassPtr, nameof (cardSelector));
    ChooseNewCompanion.NativeFieldInfoPtr_cardController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChooseNewCompanion>.NativeClassPtr, nameof (cardController));
    ChooseNewCompanion.NativeFieldInfoPtr_cardContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChooseNewCompanion>.NativeClassPtr, nameof (cardContainer));
    ChooseNewCompanion.NativeFieldInfoPtr_rewardOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChooseNewCompanion>.NativeClassPtr, nameof (rewardOptions));
    ChooseNewCompanion.NativeFieldInfoPtr_topBanner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChooseNewCompanion>.NativeClassPtr, nameof (topBanner));
    ChooseNewCompanion.NativeFieldInfoPtr_bottomBanner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChooseNewCompanion>.NativeClassPtr, nameof (bottomBanner));
    ChooseNewCompanion.NativeFieldInfoPtr_background = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChooseNewCompanion>.NativeClassPtr, nameof (background));
    ChooseNewCompanion.NativeFieldInfoPtr_bannerTweenDur = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChooseNewCompanion>.NativeClassPtr, nameof (bannerTweenDur));
    ChooseNewCompanion.NativeFieldInfoPtr_bannerTweenEase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChooseNewCompanion>.NativeClassPtr, nameof (bannerTweenEase));
    ChooseNewCompanion.NativeFieldInfoPtr_bannerTweenOutDur = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChooseNewCompanion>.NativeClassPtr, nameof (bannerTweenOutDur));
    ChooseNewCompanion.NativeFieldInfoPtr_bannerTweenOutEase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChooseNewCompanion>.NativeClassPtr, nameof (bannerTweenOutEase));
    ChooseNewCompanion.NativeFieldInfoPtr_storedRewards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChooseNewCompanion>.NativeClassPtr, nameof (storedRewards));
    ChooseNewCompanion.NativeMethodInfoPtr_Run_Public_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChooseNewCompanion>.NativeClassPtr, 100665852);
    ChooseNewCompanion.NativeMethodInfoPtr_Populate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChooseNewCompanion>.NativeClassPtr, 100665853);
    ChooseNewCompanion.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChooseNewCompanion>.NativeClassPtr, 100665854);
  }

  public ChooseNewCompanion(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe UISequence sequence
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChooseNewCompanion.NativeFieldInfoPtr_sequence));
      return pointer == System.IntPtr.Zero ? (UISequence) null : new UISequence(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChooseNewCompanion.NativeFieldInfoPtr_sequence), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CardSelector cardSelector
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChooseNewCompanion.NativeFieldInfoPtr_cardSelector));
      return pointer == System.IntPtr.Zero ? (CardSelector) null : new CardSelector(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChooseNewCompanion.NativeFieldInfoPtr_cardSelector), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CardController cardController
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChooseNewCompanion.NativeFieldInfoPtr_cardController));
      return pointer == System.IntPtr.Zero ? (CardController) null : new CardController(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChooseNewCompanion.NativeFieldInfoPtr_cardController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CardContainer cardContainer
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChooseNewCompanion.NativeFieldInfoPtr_cardContainer));
      return pointer == System.IntPtr.Zero ? (CardContainer) null : new CardContainer(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChooseNewCompanion.NativeFieldInfoPtr_cardContainer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int rewardOptions
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChooseNewCompanion.NativeFieldInfoPtr_rewardOptions));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChooseNewCompanion.NativeFieldInfoPtr_rewardOptions)) = value;
    }
  }

  public unsafe RectTransform topBanner
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChooseNewCompanion.NativeFieldInfoPtr_topBanner));
      return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChooseNewCompanion.NativeFieldInfoPtr_topBanner), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe RectTransform bottomBanner
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChooseNewCompanion.NativeFieldInfoPtr_bottomBanner));
      return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChooseNewCompanion.NativeFieldInfoPtr_bottomBanner), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe RectTransform background
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChooseNewCompanion.NativeFieldInfoPtr_background));
      return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChooseNewCompanion.NativeFieldInfoPtr_background), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector2 bannerTweenDur
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChooseNewCompanion.NativeFieldInfoPtr_bannerTweenDur));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChooseNewCompanion.NativeFieldInfoPtr_bannerTweenDur)) = value;
    }
  }

  public unsafe LeanTweenType bannerTweenEase
  {
    get
    {
      return *(LeanTweenType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChooseNewCompanion.NativeFieldInfoPtr_bannerTweenEase));
    }
    [param: In] set
    {
      *(LeanTweenType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChooseNewCompanion.NativeFieldInfoPtr_bannerTweenEase)) = value;
    }
  }

  public unsafe Vector2 bannerTweenOutDur
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChooseNewCompanion.NativeFieldInfoPtr_bannerTweenOutDur));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChooseNewCompanion.NativeFieldInfoPtr_bannerTweenOutDur)) = value;
    }
  }

  public unsafe LeanTweenType bannerTweenOutEase
  {
    get
    {
      return *(LeanTweenType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChooseNewCompanion.NativeFieldInfoPtr_bannerTweenOutEase));
    }
    [param: In] set
    {
      *(LeanTweenType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChooseNewCompanion.NativeFieldInfoPtr_bannerTweenOutEase)) = value;
    }
  }

  public unsafe Il2CppReferenceArray<CardData> storedRewards
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChooseNewCompanion.NativeFieldInfoPtr_storedRewards));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<CardData>) null : new Il2CppReferenceArray<CardData>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChooseNewCompanion.NativeFieldInfoPtr_storedRewards), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [ObfuscatedName("ChooseNewCompanion/<Run>d__13")]
  public sealed class _Run_d__13 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    [CallerCount(53)]
    [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _Run_d__13(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChooseNewCompanion._Run_d__13>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ChooseNewCompanion._Run_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(12611)]
    [CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12665, XrefRangeStart = 54, XrefRangeEnd = 12665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ChooseNewCompanion._Run_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38004, XrefRangeEnd = 38045, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ChooseNewCompanion._Run_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ChooseNewCompanion._Run_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38045, XrefRangeEnd = 38051, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ChooseNewCompanion._Run_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ChooseNewCompanion._Run_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    static _Run_d__13()
    {
      Il2CppClassPointerStore<ChooseNewCompanion._Run_d__13>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChooseNewCompanion>.NativeClassPtr, "<Run>d__13");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChooseNewCompanion._Run_d__13>.NativeClassPtr);
      ChooseNewCompanion._Run_d__13.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChooseNewCompanion._Run_d__13>.NativeClassPtr, "<>1__state");
      ChooseNewCompanion._Run_d__13.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChooseNewCompanion._Run_d__13>.NativeClassPtr, "<>2__current");
      ChooseNewCompanion._Run_d__13.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChooseNewCompanion._Run_d__13>.NativeClassPtr, "<>4__this");
      ChooseNewCompanion._Run_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChooseNewCompanion._Run_d__13>.NativeClassPtr, 100665855);
      ChooseNewCompanion._Run_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChooseNewCompanion._Run_d__13>.NativeClassPtr, 100665856);
      ChooseNewCompanion._Run_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChooseNewCompanion._Run_d__13>.NativeClassPtr, 100665857);
      ChooseNewCompanion._Run_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChooseNewCompanion._Run_d__13>.NativeClassPtr, 100665858);
      ChooseNewCompanion._Run_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChooseNewCompanion._Run_d__13>.NativeClassPtr, 100665859);
      ChooseNewCompanion._Run_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChooseNewCompanion._Run_d__13>.NativeClassPtr, 100665860);
    }

    public _Run_d__13(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChooseNewCompanion._Run_d__13.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChooseNewCompanion._Run_d__13.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChooseNewCompanion._Run_d__13.NativeFieldInfoPtr___2__current));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChooseNewCompanion._Run_d__13.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ChooseNewCompanion __4__this
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChooseNewCompanion._Run_d__13.NativeFieldInfoPtr___4__this));
        return pointer == System.IntPtr.Zero ? (ChooseNewCompanion) null : new ChooseNewCompanion(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChooseNewCompanion._Run_d__13.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
