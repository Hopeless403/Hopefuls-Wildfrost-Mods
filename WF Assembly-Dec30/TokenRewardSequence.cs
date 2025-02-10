// Decompiled with JetBrains decompiler
// Type: TokenRewardSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
public class TokenRewardSequence : UISequence
{
  private static readonly System.IntPtr NativeFieldInfoPtr_canvasGroup;
  private static readonly System.IntPtr NativeFieldInfoPtr_titleTransform;
  private static readonly System.IntPtr NativeFieldInfoPtr_titleToPosition;
  private static readonly System.IntPtr NativeFieldInfoPtr_revealTween;
  private static readonly System.IntPtr NativeFieldInfoPtr_hideTween;
  private static readonly System.IntPtr NativeFieldInfoPtr_cardHolder;
  private static readonly System.IntPtr NativeFieldInfoPtr_skipButton;
  private static readonly System.IntPtr NativeFieldInfoPtr_goldGainFromSkip;
  private static readonly System.IntPtr NativeFieldInfoPtr_cardController;
  private static readonly System.IntPtr NativeFieldInfoPtr_tokenDragHandler;
  private static readonly System.IntPtr NativeFieldInfoPtr_tokenSlotGroup;
  private static readonly System.IntPtr NativeFieldInfoPtr_tokenSlotPrefab;
  private static readonly System.IntPtr NativeFieldInfoPtr_tokenData;
  private static readonly System.IntPtr NativeFieldInfoPtr_targets;
  private static readonly System.IntPtr NativeMethodInfoPtr_Run_Public_Virtual_IEnumerator_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TokenAssigned_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TokenAssignedRoutine_Private_IEnumerator_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Skip_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__Run_b__14_0_Private_Boolean_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99989, XrefRangeEnd = 99994, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe IEnumerator Run()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TokenRewardSequence.NativeMethodInfoPtr_Run_Public_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99994, XrefRangeEnd = 100001, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void TokenAssigned()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TokenRewardSequence.NativeMethodInfoPtr_TokenAssigned_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100001, XrefRangeEnd = 100006, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator TokenAssignedRoutine()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TokenRewardSequence.NativeMethodInfoPtr_TokenAssignedRoutine_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100006, XrefRangeEnd = 100011, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Skip()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TokenRewardSequence.NativeMethodInfoPtr_Skip_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100011, XrefRangeEnd = 100012, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe TokenRewardSequence()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TokenRewardSequence>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TokenRewardSequence.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 23871, RefRangeEnd = 23873, XrefRangeStart = 23871, XrefRangeEnd = 23873, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool _Run_b__14_0()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TokenRewardSequence.NativeMethodInfoPtr__Run_b__14_0_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  static TokenRewardSequence()
  {
    Il2CppClassPointerStore<TokenRewardSequence>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (TokenRewardSequence));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TokenRewardSequence>.NativeClassPtr);
    TokenRewardSequence.NativeFieldInfoPtr_canvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenRewardSequence>.NativeClassPtr, nameof (canvasGroup));
    TokenRewardSequence.NativeFieldInfoPtr_titleTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenRewardSequence>.NativeClassPtr, nameof (titleTransform));
    TokenRewardSequence.NativeFieldInfoPtr_titleToPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenRewardSequence>.NativeClassPtr, nameof (titleToPosition));
    TokenRewardSequence.NativeFieldInfoPtr_revealTween = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenRewardSequence>.NativeClassPtr, nameof (revealTween));
    TokenRewardSequence.NativeFieldInfoPtr_hideTween = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenRewardSequence>.NativeClassPtr, nameof (hideTween));
    TokenRewardSequence.NativeFieldInfoPtr_cardHolder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenRewardSequence>.NativeClassPtr, nameof (cardHolder));
    TokenRewardSequence.NativeFieldInfoPtr_skipButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenRewardSequence>.NativeClassPtr, nameof (skipButton));
    TokenRewardSequence.NativeFieldInfoPtr_goldGainFromSkip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenRewardSequence>.NativeClassPtr, nameof (goldGainFromSkip));
    TokenRewardSequence.NativeFieldInfoPtr_cardController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenRewardSequence>.NativeClassPtr, nameof (cardController));
    TokenRewardSequence.NativeFieldInfoPtr_tokenDragHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenRewardSequence>.NativeClassPtr, nameof (tokenDragHandler));
    TokenRewardSequence.NativeFieldInfoPtr_tokenSlotGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenRewardSequence>.NativeClassPtr, nameof (tokenSlotGroup));
    TokenRewardSequence.NativeFieldInfoPtr_tokenSlotPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenRewardSequence>.NativeClassPtr, nameof (tokenSlotPrefab));
    TokenRewardSequence.NativeFieldInfoPtr_tokenData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenRewardSequence>.NativeClassPtr, nameof (tokenData));
    TokenRewardSequence.NativeFieldInfoPtr_targets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenRewardSequence>.NativeClassPtr, nameof (targets));
    TokenRewardSequence.NativeMethodInfoPtr_Run_Public_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenRewardSequence>.NativeClassPtr, 100672238);
    TokenRewardSequence.NativeMethodInfoPtr_TokenAssigned_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenRewardSequence>.NativeClassPtr, 100672239);
    TokenRewardSequence.NativeMethodInfoPtr_TokenAssignedRoutine_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenRewardSequence>.NativeClassPtr, 100672240);
    TokenRewardSequence.NativeMethodInfoPtr_Skip_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenRewardSequence>.NativeClassPtr, 100672241);
    TokenRewardSequence.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenRewardSequence>.NativeClassPtr, 100672242);
    TokenRewardSequence.NativeMethodInfoPtr__Run_b__14_0_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenRewardSequence>.NativeClassPtr, 100672243);
  }

  public TokenRewardSequence(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe CanvasGroup canvasGroup
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TokenRewardSequence.NativeFieldInfoPtr_canvasGroup));
      return pointer == System.IntPtr.Zero ? (CanvasGroup) null : new CanvasGroup(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TokenRewardSequence.NativeFieldInfoPtr_canvasGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe RectTransform titleTransform
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TokenRewardSequence.NativeFieldInfoPtr_titleTransform));
      return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TokenRewardSequence.NativeFieldInfoPtr_titleTransform), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector3 titleToPosition
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TokenRewardSequence.NativeFieldInfoPtr_titleToPosition));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TokenRewardSequence.NativeFieldInfoPtr_titleToPosition)) = value;
    }
  }

  public unsafe TweenUI revealTween
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TokenRewardSequence.NativeFieldInfoPtr_revealTween));
      return pointer == System.IntPtr.Zero ? (TweenUI) null : new TweenUI(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TokenRewardSequence.NativeFieldInfoPtr_revealTween), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TweenUI hideTween
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TokenRewardSequence.NativeFieldInfoPtr_hideTween));
      return pointer == System.IntPtr.Zero ? (TweenUI) null : new TweenUI(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TokenRewardSequence.NativeFieldInfoPtr_hideTween), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CardContainer cardHolder
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TokenRewardSequence.NativeFieldInfoPtr_cardHolder));
      return pointer == System.IntPtr.Zero ? (CardContainer) null : new CardContainer(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TokenRewardSequence.NativeFieldInfoPtr_cardHolder), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Button skipButton
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TokenRewardSequence.NativeFieldInfoPtr_skipButton));
      return pointer == System.IntPtr.Zero ? (Button) null : new Button(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TokenRewardSequence.NativeFieldInfoPtr_skipButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int goldGainFromSkip
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TokenRewardSequence.NativeFieldInfoPtr_goldGainFromSkip));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TokenRewardSequence.NativeFieldInfoPtr_goldGainFromSkip)) = value;
    }
  }

  public unsafe CardController cardController
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TokenRewardSequence.NativeFieldInfoPtr_cardController));
      return pointer == System.IntPtr.Zero ? (CardController) null : new CardController(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TokenRewardSequence.NativeFieldInfoPtr_cardController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CardCharmDragHandler tokenDragHandler
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TokenRewardSequence.NativeFieldInfoPtr_tokenDragHandler));
      return pointer == System.IntPtr.Zero ? (CardCharmDragHandler) null : new CardCharmDragHandler(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TokenRewardSequence.NativeFieldInfoPtr_tokenDragHandler), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe RectTransform tokenSlotGroup
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TokenRewardSequence.NativeFieldInfoPtr_tokenSlotGroup));
      return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TokenRewardSequence.NativeFieldInfoPtr_tokenSlotGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CardCharmHolder tokenSlotPrefab
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TokenRewardSequence.NativeFieldInfoPtr_tokenSlotPrefab));
      return pointer == System.IntPtr.Zero ? (CardCharmHolder) null : new CardCharmHolder(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TokenRewardSequence.NativeFieldInfoPtr_tokenSlotPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<CardUpgradeData> tokenData
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TokenRewardSequence.NativeFieldInfoPtr_tokenData));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<CardUpgradeData>) null : new Il2CppReferenceArray<CardUpgradeData>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TokenRewardSequence.NativeFieldInfoPtr_tokenData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<TokenRewardSequence.Target> targets
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TokenRewardSequence.NativeFieldInfoPtr_targets));
      return pointer == System.IntPtr.Zero ? (List<TokenRewardSequence.Target>) null : new List<TokenRewardSequence.Target>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TokenRewardSequence.NativeFieldInfoPtr_targets), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public class Target : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_entity;
    private static readonly System.IntPtr NativeFieldInfoPtr_previousActualContainers;
    private static readonly System.IntPtr NativeFieldInfoPtr_previousController;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Entity_CardController_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveTo_Public_Void_Il2CppReferenceArray_1_CardContainer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Return_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 99698, RefRangeEnd = 99699, XrefRangeStart = 99681, XrefRangeEnd = 99698, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Target(Entity entity, CardController controller)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TokenRewardSequence.Target>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) controller);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TokenRewardSequence.Target.NativeMethodInfoPtr__ctor_Public_Void_Entity_CardController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 99701, RefRangeEnd = 99702, XrefRangeStart = 99699, XrefRangeEnd = 99701, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void MoveTo([Optional] Il2CppReferenceArray<CardContainer> containers)
    {
      if (containers == null)
        containers = new Il2CppReferenceArray<CardContainer>(0L);
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) containers)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TokenRewardSequence.Target.NativeMethodInfoPtr_MoveTo_Public_Void_Il2CppReferenceArray_1_CardContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99702, XrefRangeEnd = 99711, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Return()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TokenRewardSequence.Target.NativeMethodInfoPtr_Return_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99711, XrefRangeEnd = 99717, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe string ToString()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TokenRewardSequence.Target.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    public void MoveTo(params CardContainer[] containers)
    {
      this.MoveTo(new Il2CppReferenceArray<CardContainer>(containers));
    }

    static Target()
    {
      Il2CppClassPointerStore<TokenRewardSequence.Target>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TokenRewardSequence>.NativeClassPtr, nameof (Target));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TokenRewardSequence.Target>.NativeClassPtr);
      TokenRewardSequence.Target.NativeFieldInfoPtr_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenRewardSequence.Target>.NativeClassPtr, nameof (entity));
      TokenRewardSequence.Target.NativeFieldInfoPtr_previousActualContainers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenRewardSequence.Target>.NativeClassPtr, nameof (previousActualContainers));
      TokenRewardSequence.Target.NativeFieldInfoPtr_previousController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenRewardSequence.Target>.NativeClassPtr, nameof (previousController));
      TokenRewardSequence.Target.NativeMethodInfoPtr__ctor_Public_Void_Entity_CardController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenRewardSequence.Target>.NativeClassPtr, 100672244);
      TokenRewardSequence.Target.NativeMethodInfoPtr_MoveTo_Public_Void_Il2CppReferenceArray_1_CardContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenRewardSequence.Target>.NativeClassPtr, 100672245);
      TokenRewardSequence.Target.NativeMethodInfoPtr_Return_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenRewardSequence.Target>.NativeClassPtr, 100672246);
      TokenRewardSequence.Target.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenRewardSequence.Target>.NativeClassPtr, 100672247);
    }

    public Target(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Entity entity
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TokenRewardSequence.Target.NativeFieldInfoPtr_entity));
        return pointer == System.IntPtr.Zero ? (Entity) null : new Entity(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TokenRewardSequence.Target.NativeFieldInfoPtr_entity), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppReferenceArray<CardContainer> previousActualContainers
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TokenRewardSequence.Target.NativeFieldInfoPtr_previousActualContainers));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<CardContainer>) null : new Il2CppReferenceArray<CardContainer>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TokenRewardSequence.Target.NativeFieldInfoPtr_previousActualContainers), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CardController previousController
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TokenRewardSequence.Target.NativeFieldInfoPtr_previousController));
        return pointer == System.IntPtr.Zero ? (CardController) null : new CardController(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TokenRewardSequence.Target.NativeFieldInfoPtr_previousController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("TokenRewardSequence/<>c__DisplayClass14_0")]
  public sealed class __c__DisplayClass14_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_token;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Run_b__1_Internal_Void_UpgradeDisplay_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass14_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TokenRewardSequence.__c__DisplayClass14_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TokenRewardSequence.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99717, XrefRangeEnd = 99791, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Run_b__1(UpgradeDisplay a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TokenRewardSequence.__c__DisplayClass14_0.NativeMethodInfoPtr__Run_b__1_Internal_Void_UpgradeDisplay_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static __c__DisplayClass14_0()
    {
      Il2CppClassPointerStore<TokenRewardSequence.__c__DisplayClass14_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TokenRewardSequence>.NativeClassPtr, "<>c__DisplayClass14_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TokenRewardSequence.__c__DisplayClass14_0>.NativeClassPtr);
      TokenRewardSequence.__c__DisplayClass14_0.NativeFieldInfoPtr_token = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenRewardSequence.__c__DisplayClass14_0>.NativeClassPtr, nameof (token));
      TokenRewardSequence.__c__DisplayClass14_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenRewardSequence.__c__DisplayClass14_0>.NativeClassPtr, "<>4__this");
      TokenRewardSequence.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenRewardSequence.__c__DisplayClass14_0>.NativeClassPtr, 100672248);
      TokenRewardSequence.__c__DisplayClass14_0.NativeMethodInfoPtr__Run_b__1_Internal_Void_UpgradeDisplay_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenRewardSequence.__c__DisplayClass14_0>.NativeClassPtr, 100672249);
    }

    public __c__DisplayClass14_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe UpgradeDisplay token
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TokenRewardSequence.__c__DisplayClass14_0.NativeFieldInfoPtr_token));
        return pointer == System.IntPtr.Zero ? (UpgradeDisplay) null : new UpgradeDisplay(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TokenRewardSequence.__c__DisplayClass14_0.NativeFieldInfoPtr_token), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TokenRewardSequence __4__this
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TokenRewardSequence.__c__DisplayClass14_0.NativeFieldInfoPtr___4__this));
        return pointer == System.IntPtr.Zero ? (TokenRewardSequence) null : new TokenRewardSequence(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TokenRewardSequence.__c__DisplayClass14_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("TokenRewardSequence/<Run>d__14")]
  public sealed class _Run_d__14 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr___7__wrap1;
    private static readonly System.IntPtr NativeFieldInfoPtr__i_5__3;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    [CallerCount(53)]
    [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _Run_d__14(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TokenRewardSequence._Run_d__14>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TokenRewardSequence._Run_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 99798, RefRangeEnd = 99799, XrefRangeStart = 99791, XrefRangeEnd = 99798, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TokenRewardSequence._Run_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99799, XrefRangeEnd = 99972, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TokenRewardSequence._Run_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99972, XrefRangeEnd = 99975, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void __m__Finally1()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TokenRewardSequence._Run_d__14.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EGeneric\u002EIEnumerator\u003CSystem\u002EObject\u003E\u002ECurrent
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TokenRewardSequence._Run_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99975, XrefRangeEnd = 99981, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TokenRewardSequence._Run_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TokenRewardSequence._Run_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    static _Run_d__14()
    {
      Il2CppClassPointerStore<TokenRewardSequence._Run_d__14>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TokenRewardSequence>.NativeClassPtr, "<Run>d__14");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TokenRewardSequence._Run_d__14>.NativeClassPtr);
      TokenRewardSequence._Run_d__14.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenRewardSequence._Run_d__14>.NativeClassPtr, "<>1__state");
      TokenRewardSequence._Run_d__14.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenRewardSequence._Run_d__14>.NativeClassPtr, "<>2__current");
      TokenRewardSequence._Run_d__14.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenRewardSequence._Run_d__14>.NativeClassPtr, "<>4__this");
      TokenRewardSequence._Run_d__14.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenRewardSequence._Run_d__14>.NativeClassPtr, "<>7__wrap1");
      TokenRewardSequence._Run_d__14.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenRewardSequence._Run_d__14>.NativeClassPtr, "<i>5__3");
      TokenRewardSequence._Run_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenRewardSequence._Run_d__14>.NativeClassPtr, 100672250);
      TokenRewardSequence._Run_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenRewardSequence._Run_d__14>.NativeClassPtr, 100672251);
      TokenRewardSequence._Run_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenRewardSequence._Run_d__14>.NativeClassPtr, 100672252);
      TokenRewardSequence._Run_d__14.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenRewardSequence._Run_d__14>.NativeClassPtr, 100672253);
      TokenRewardSequence._Run_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenRewardSequence._Run_d__14>.NativeClassPtr, 100672254);
      TokenRewardSequence._Run_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenRewardSequence._Run_d__14>.NativeClassPtr, 100672255);
      TokenRewardSequence._Run_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenRewardSequence._Run_d__14>.NativeClassPtr, 100672256);
    }

    public _Run_d__14(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TokenRewardSequence._Run_d__14.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TokenRewardSequence._Run_d__14.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TokenRewardSequence._Run_d__14.NativeFieldInfoPtr___2__current));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TokenRewardSequence._Run_d__14.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TokenRewardSequence __4__this
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TokenRewardSequence._Run_d__14.NativeFieldInfoPtr___4__this));
        return pointer == System.IntPtr.Zero ? (TokenRewardSequence) null : new TokenRewardSequence(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TokenRewardSequence._Run_d__14.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public List<TokenRewardSequence.Target>.Enumerator __7__wrap1
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TokenRewardSequence._Run_d__14.NativeFieldInfoPtr___7__wrap1);
        return new List<TokenRewardSequence.Target>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<TokenRewardSequence.Target>.Enumerator>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TokenRewardSequence._Run_d__14.NativeFieldInfoPtr___7__wrap1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<TokenRewardSequence.Target>.Enumerator>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe int _i_5__3
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TokenRewardSequence._Run_d__14.NativeFieldInfoPtr__i_5__3));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TokenRewardSequence._Run_d__14.NativeFieldInfoPtr__i_5__3)) = value;
      }
    }
  }

  [ObfuscatedName("TokenRewardSequence/<TokenAssignedRoutine>d__16")]
  public sealed class _TokenAssignedRoutine_d__16 : Il2CppSystem.Object
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
    public unsafe _TokenAssignedRoutine_d__16(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TokenRewardSequence._TokenAssignedRoutine_d__16>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TokenRewardSequence._TokenAssignedRoutine_d__16.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(12611)]
    [CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12665, XrefRangeStart = 54, XrefRangeEnd = 12665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TokenRewardSequence._TokenAssignedRoutine_d__16.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99981, XrefRangeEnd = 99983, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TokenRewardSequence._TokenAssignedRoutine_d__16.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TokenRewardSequence._TokenAssignedRoutine_d__16.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99983, XrefRangeEnd = 99989, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TokenRewardSequence._TokenAssignedRoutine_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TokenRewardSequence._TokenAssignedRoutine_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    static _TokenAssignedRoutine_d__16()
    {
      Il2CppClassPointerStore<TokenRewardSequence._TokenAssignedRoutine_d__16>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TokenRewardSequence>.NativeClassPtr, "<TokenAssignedRoutine>d__16");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TokenRewardSequence._TokenAssignedRoutine_d__16>.NativeClassPtr);
      TokenRewardSequence._TokenAssignedRoutine_d__16.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenRewardSequence._TokenAssignedRoutine_d__16>.NativeClassPtr, "<>1__state");
      TokenRewardSequence._TokenAssignedRoutine_d__16.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenRewardSequence._TokenAssignedRoutine_d__16>.NativeClassPtr, "<>2__current");
      TokenRewardSequence._TokenAssignedRoutine_d__16.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenRewardSequence._TokenAssignedRoutine_d__16>.NativeClassPtr, "<>4__this");
      TokenRewardSequence._TokenAssignedRoutine_d__16.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenRewardSequence._TokenAssignedRoutine_d__16>.NativeClassPtr, 100672257);
      TokenRewardSequence._TokenAssignedRoutine_d__16.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenRewardSequence._TokenAssignedRoutine_d__16>.NativeClassPtr, 100672258);
      TokenRewardSequence._TokenAssignedRoutine_d__16.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenRewardSequence._TokenAssignedRoutine_d__16>.NativeClassPtr, 100672259);
      TokenRewardSequence._TokenAssignedRoutine_d__16.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenRewardSequence._TokenAssignedRoutine_d__16>.NativeClassPtr, 100672260);
      TokenRewardSequence._TokenAssignedRoutine_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenRewardSequence._TokenAssignedRoutine_d__16>.NativeClassPtr, 100672261);
      TokenRewardSequence._TokenAssignedRoutine_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenRewardSequence._TokenAssignedRoutine_d__16>.NativeClassPtr, 100672262);
    }

    public _TokenAssignedRoutine_d__16(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TokenRewardSequence._TokenAssignedRoutine_d__16.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TokenRewardSequence._TokenAssignedRoutine_d__16.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TokenRewardSequence._TokenAssignedRoutine_d__16.NativeFieldInfoPtr___2__current));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TokenRewardSequence._TokenAssignedRoutine_d__16.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TokenRewardSequence __4__this
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TokenRewardSequence._TokenAssignedRoutine_d__16.NativeFieldInfoPtr___4__this));
        return pointer == System.IntPtr.Zero ? (TokenRewardSequence) null : new TokenRewardSequence(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TokenRewardSequence._TokenAssignedRoutine_d__16.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
