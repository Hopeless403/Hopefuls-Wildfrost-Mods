// Decompiled with JetBrains decompiler
// Type: BackButtonGamePadController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

#nullable disable
public class BackButtonGamePadController : MonoBehaviour
{
  private static readonly System.IntPtr NativeFieldInfoPtr_isGoingBack;
  private static readonly System.IntPtr NativeFieldInfoPtr_backButton;
  private static readonly System.IntPtr NativeFieldInfoPtr_eventTrigger;
  private static readonly System.IntPtr NativeFieldInfoPtr_uINavigationLayer;
  private static readonly System.IntPtr NativeFieldInfoPtr_navigationItem;
  private static readonly System.IntPtr NativeFieldInfoPtr_OnBackButtonOverride;
  private static readonly System.IntPtr NativeFieldInfoPtr_backClearTime;
  private static readonly System.IntPtr NativeFieldInfoPtr_GoingBackClear;
  private static readonly System.IntPtr NativeFieldInfoPtr_navItemEnabled;
  private static readonly System.IntPtr NativeFieldInfoPtr_press;
  private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Press_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Release_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RunGoBackClear_Private_IEnumerator_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Start_Internal_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CheckForNavigationLayer_Private_Void_Transform_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CheckNavigationItem_Private_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12689, XrefRangeEnd = 12696, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BackButtonGamePadController.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12696, XrefRangeEnd = 12701, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Press()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BackButtonGamePadController.NativeMethodInfoPtr_Press_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12701, XrefRangeEnd = 12711, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Release()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BackButtonGamePadController.NativeMethodInfoPtr_Release_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12711, XrefRangeEnd = 12717, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Invoke()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BackButtonGamePadController.NativeMethodInfoPtr_Invoke_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12717, XrefRangeEnd = 12722, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator RunGoBackClear()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BackButtonGamePadController.NativeMethodInfoPtr_RunGoBackClear_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12722, XrefRangeEnd = 12724, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BackButtonGamePadController.NativeMethodInfoPtr_Start_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 12740, RefRangeEnd = 12741, XrefRangeStart = 12724, XrefRangeEnd = 12740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CheckForNavigationLayer(Transform checkTransform)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) checkTransform)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BackButtonGamePadController.NativeMethodInfoPtr_CheckForNavigationLayer_Private_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 12747, RefRangeEnd = 12748, XrefRangeStart = 12741, XrefRangeEnd = 12747, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool CheckNavigationItem()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BackButtonGamePadController.NativeMethodInfoPtr_CheckNavigationItem_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(212)]
  [CachedScanResults(RefRangeStart = 12749, RefRangeEnd = 12961, XrefRangeStart = 12748, XrefRangeEnd = 12749, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe BackButtonGamePadController()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BackButtonGamePadController>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BackButtonGamePadController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static BackButtonGamePadController()
  {
    Il2CppClassPointerStore<BackButtonGamePadController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (BackButtonGamePadController));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BackButtonGamePadController>.NativeClassPtr);
    BackButtonGamePadController.NativeFieldInfoPtr_isGoingBack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackButtonGamePadController>.NativeClassPtr, nameof (isGoingBack));
    BackButtonGamePadController.NativeFieldInfoPtr_backButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackButtonGamePadController>.NativeClassPtr, nameof (backButton));
    BackButtonGamePadController.NativeFieldInfoPtr_eventTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackButtonGamePadController>.NativeClassPtr, nameof (eventTrigger));
    BackButtonGamePadController.NativeFieldInfoPtr_uINavigationLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackButtonGamePadController>.NativeClassPtr, nameof (uINavigationLayer));
    BackButtonGamePadController.NativeFieldInfoPtr_navigationItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackButtonGamePadController>.NativeClassPtr, nameof (navigationItem));
    BackButtonGamePadController.NativeFieldInfoPtr_OnBackButtonOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackButtonGamePadController>.NativeClassPtr, nameof (OnBackButtonOverride));
    BackButtonGamePadController.NativeFieldInfoPtr_backClearTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackButtonGamePadController>.NativeClassPtr, nameof (backClearTime));
    BackButtonGamePadController.NativeFieldInfoPtr_GoingBackClear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackButtonGamePadController>.NativeClassPtr, nameof (GoingBackClear));
    BackButtonGamePadController.NativeFieldInfoPtr_navItemEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackButtonGamePadController>.NativeClassPtr, nameof (navItemEnabled));
    BackButtonGamePadController.NativeFieldInfoPtr_press = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackButtonGamePadController>.NativeClassPtr, nameof (press));
    BackButtonGamePadController.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackButtonGamePadController>.NativeClassPtr, 100663297);
    BackButtonGamePadController.NativeMethodInfoPtr_Press_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackButtonGamePadController>.NativeClassPtr, 100663298);
    BackButtonGamePadController.NativeMethodInfoPtr_Release_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackButtonGamePadController>.NativeClassPtr, 100663299);
    BackButtonGamePadController.NativeMethodInfoPtr_Invoke_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackButtonGamePadController>.NativeClassPtr, 100663300);
    BackButtonGamePadController.NativeMethodInfoPtr_RunGoBackClear_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackButtonGamePadController>.NativeClassPtr, 100663301);
    BackButtonGamePadController.NativeMethodInfoPtr_Start_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackButtonGamePadController>.NativeClassPtr, 100663302);
    BackButtonGamePadController.NativeMethodInfoPtr_CheckForNavigationLayer_Private_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackButtonGamePadController>.NativeClassPtr, 100663303);
    BackButtonGamePadController.NativeMethodInfoPtr_CheckNavigationItem_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackButtonGamePadController>.NativeClassPtr, 100663304);
    BackButtonGamePadController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackButtonGamePadController>.NativeClassPtr, 100663305);
  }

  public BackButtonGamePadController(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe bool isGoingBack
  {
    get
    {
      bool isGoingBack;
      IL2CPP.il2cpp_field_static_get_value(BackButtonGamePadController.NativeFieldInfoPtr_isGoingBack, (void*) &isGoingBack);
      return isGoingBack;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(BackButtonGamePadController.NativeFieldInfoPtr_isGoingBack, (void*) &value);
    }
  }

  public unsafe Button backButton
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BackButtonGamePadController.NativeFieldInfoPtr_backButton));
      return pointer == System.IntPtr.Zero ? (Button) null : new Button(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BackButtonGamePadController.NativeFieldInfoPtr_backButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe EventTrigger eventTrigger
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BackButtonGamePadController.NativeFieldInfoPtr_eventTrigger));
      return pointer == System.IntPtr.Zero ? (EventTrigger) null : new EventTrigger(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BackButtonGamePadController.NativeFieldInfoPtr_eventTrigger), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UINavigationLayer uINavigationLayer
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BackButtonGamePadController.NativeFieldInfoPtr_uINavigationLayer));
      return pointer == System.IntPtr.Zero ? (UINavigationLayer) null : new UINavigationLayer(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BackButtonGamePadController.NativeFieldInfoPtr_uINavigationLayer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UINavigationItem navigationItem
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BackButtonGamePadController.NativeFieldInfoPtr_navigationItem));
      return pointer == System.IntPtr.Zero ? (UINavigationItem) null : new UINavigationItem(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BackButtonGamePadController.NativeFieldInfoPtr_navigationItem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UnityEvent OnBackButtonOverride
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BackButtonGamePadController.NativeFieldInfoPtr_OnBackButtonOverride));
      return pointer == System.IntPtr.Zero ? (UnityEvent) null : new UnityEvent(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BackButtonGamePadController.NativeFieldInfoPtr_OnBackButtonOverride), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe float backClearTime
  {
    get
    {
      float backClearTime;
      IL2CPP.il2cpp_field_static_get_value(BackButtonGamePadController.NativeFieldInfoPtr_backClearTime, (void*) &backClearTime);
      return backClearTime;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(BackButtonGamePadController.NativeFieldInfoPtr_backClearTime, (void*) &value);
    }
  }

  public unsafe Coroutine GoingBackClear
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BackButtonGamePadController.NativeFieldInfoPtr_GoingBackClear));
      return pointer == System.IntPtr.Zero ? (Coroutine) null : new Coroutine(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BackButtonGamePadController.NativeFieldInfoPtr_GoingBackClear), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool navItemEnabled
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BackButtonGamePadController.NativeFieldInfoPtr_navItemEnabled));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BackButtonGamePadController.NativeFieldInfoPtr_navItemEnabled)) = value;
    }
  }

  public unsafe bool press
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BackButtonGamePadController.NativeFieldInfoPtr_press));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BackButtonGamePadController.NativeFieldInfoPtr_press)) = value;
    }
  }

  [ObfuscatedName("BackButtonGamePadController/<RunGoBackClear>d__14")]
  public sealed class _RunGoBackClear_d__14 : Il2CppSystem.Object
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
    [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 0, XrefRangeEnd = 1, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _RunGoBackClear_d__14(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BackButtonGamePadController._RunGoBackClear_d__14>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BackButtonGamePadController._RunGoBackClear_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(12611)]
    [CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12665, XrefRangeStart = 54, XrefRangeEnd = 54, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BackButtonGamePadController._RunGoBackClear_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12665, XrefRangeEnd = 12671, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BackButtonGamePadController._RunGoBackClear_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EGeneric\u002EIEnumerator\u003CSystem\u002EObject\u003E\u002ECurrent
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12671, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BackButtonGamePadController._RunGoBackClear_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12683, XrefRangeEnd = 12689, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BackButtonGamePadController._RunGoBackClear_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BackButtonGamePadController._RunGoBackClear_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    static _RunGoBackClear_d__14()
    {
      Il2CppClassPointerStore<BackButtonGamePadController._RunGoBackClear_d__14>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BackButtonGamePadController>.NativeClassPtr, "<RunGoBackClear>d__14");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BackButtonGamePadController._RunGoBackClear_d__14>.NativeClassPtr);
      BackButtonGamePadController._RunGoBackClear_d__14.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackButtonGamePadController._RunGoBackClear_d__14>.NativeClassPtr, "<>1__state");
      BackButtonGamePadController._RunGoBackClear_d__14.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackButtonGamePadController._RunGoBackClear_d__14>.NativeClassPtr, "<>2__current");
      BackButtonGamePadController._RunGoBackClear_d__14.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackButtonGamePadController._RunGoBackClear_d__14>.NativeClassPtr, "<>4__this");
      BackButtonGamePadController._RunGoBackClear_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackButtonGamePadController._RunGoBackClear_d__14>.NativeClassPtr, 100663306);
      BackButtonGamePadController._RunGoBackClear_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackButtonGamePadController._RunGoBackClear_d__14>.NativeClassPtr, 100663307);
      BackButtonGamePadController._RunGoBackClear_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackButtonGamePadController._RunGoBackClear_d__14>.NativeClassPtr, 100663308);
      BackButtonGamePadController._RunGoBackClear_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackButtonGamePadController._RunGoBackClear_d__14>.NativeClassPtr, 100663309);
      BackButtonGamePadController._RunGoBackClear_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackButtonGamePadController._RunGoBackClear_d__14>.NativeClassPtr, 100663310);
      BackButtonGamePadController._RunGoBackClear_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackButtonGamePadController._RunGoBackClear_d__14>.NativeClassPtr, 100663311);
    }

    public _RunGoBackClear_d__14(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BackButtonGamePadController._RunGoBackClear_d__14.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BackButtonGamePadController._RunGoBackClear_d__14.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BackButtonGamePadController._RunGoBackClear_d__14.NativeFieldInfoPtr___2__current));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BackButtonGamePadController._RunGoBackClear_d__14.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe BackButtonGamePadController __4__this
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BackButtonGamePadController._RunGoBackClear_d__14.NativeFieldInfoPtr___4__this));
        return pointer == System.IntPtr.Zero ? (BackButtonGamePadController) null : new BackButtonGamePadController(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BackButtonGamePadController._RunGoBackClear_d__14.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
