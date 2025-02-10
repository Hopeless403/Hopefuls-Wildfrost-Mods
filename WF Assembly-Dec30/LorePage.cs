// Decompiled with JetBrains decompiler
// Type: LorePage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
public class LorePage : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_manager;
  private static readonly IntPtr NativeFieldInfoPtr_pageData;
  private static readonly IntPtr NativeFieldInfoPtr_lockedDisplay;
  private static readonly IntPtr NativeFieldInfoPtr_unlockedDisplay;
  private static readonly IntPtr NativeFieldInfoPtr_newDisplay;
  private static readonly IntPtr NativeFieldInfoPtr_button;
  private static readonly IntPtr NativeFieldInfoPtr_canvas;
  private static readonly IntPtr NativeFieldInfoPtr_isUnlocked;
  private static readonly IntPtr NativeFieldInfoPtr_isNew;
  private static readonly IntPtr NativeFieldInfoPtr_denyTween;
  private static readonly IntPtr NativeFieldInfoPtr_newTween;
  private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetUnlocked_Public_Void_JournalPageData_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetNew_Public_Void_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_Select_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91551, XrefRangeEnd = 91554, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LorePage.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 91559, RefRangeEnd = 91560, XrefRangeStart = 91554, XrefRangeEnd = 91559, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetUnlocked(JournalPageData pageData, bool value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) pageData);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LorePage.NativeMethodInfoPtr_SetUnlocked_Public_Void_JournalPageData_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 91562, RefRangeEnd = 91563, XrefRangeStart = 91560, XrefRangeEnd = 91562, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetNew(bool value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &value
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LorePage.NativeMethodInfoPtr_SetNew_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91563, XrefRangeEnd = 91572, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Select()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LorePage.NativeMethodInfoPtr_Select_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(212)]
  [CachedScanResults(RefRangeStart = 12749, RefRangeEnd = 12961, XrefRangeStart = 12749, XrefRangeEnd = 12961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LorePage()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LorePage>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LorePage.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static LorePage()
  {
    Il2CppClassPointerStore<LorePage>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (LorePage));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LorePage>.NativeClassPtr);
    LorePage.NativeFieldInfoPtr_manager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LorePage>.NativeClassPtr, nameof (manager));
    LorePage.NativeFieldInfoPtr_pageData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LorePage>.NativeClassPtr, nameof (pageData));
    LorePage.NativeFieldInfoPtr_lockedDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LorePage>.NativeClassPtr, nameof (lockedDisplay));
    LorePage.NativeFieldInfoPtr_unlockedDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LorePage>.NativeClassPtr, nameof (unlockedDisplay));
    LorePage.NativeFieldInfoPtr_newDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LorePage>.NativeClassPtr, nameof (newDisplay));
    LorePage.NativeFieldInfoPtr_button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LorePage>.NativeClassPtr, nameof (button));
    LorePage.NativeFieldInfoPtr_canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LorePage>.NativeClassPtr, nameof (canvas));
    LorePage.NativeFieldInfoPtr_isUnlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LorePage>.NativeClassPtr, nameof (isUnlocked));
    LorePage.NativeFieldInfoPtr_isNew = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LorePage>.NativeClassPtr, nameof (isNew));
    LorePage.NativeFieldInfoPtr_denyTween = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LorePage>.NativeClassPtr, nameof (denyTween));
    LorePage.NativeFieldInfoPtr_newTween = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LorePage>.NativeClassPtr, nameof (newTween));
    LorePage.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LorePage>.NativeClassPtr, 100671178);
    LorePage.NativeMethodInfoPtr_SetUnlocked_Public_Void_JournalPageData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LorePage>.NativeClassPtr, 100671179);
    LorePage.NativeMethodInfoPtr_SetNew_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LorePage>.NativeClassPtr, 100671180);
    LorePage.NativeMethodInfoPtr_Select_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LorePage>.NativeClassPtr, 100671181);
    LorePage.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LorePage>.NativeClassPtr, 100671182);
  }

  public LorePage(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe LorePageManager manager
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LorePage.NativeFieldInfoPtr_manager));
      return pointer == IntPtr.Zero ? (LorePageManager) null : new LorePageManager(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LorePage.NativeFieldInfoPtr_manager), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe JournalPageData pageData
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LorePage.NativeFieldInfoPtr_pageData));
      return pointer == IntPtr.Zero ? (JournalPageData) null : new JournalPageData(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LorePage.NativeFieldInfoPtr_pageData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject lockedDisplay
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LorePage.NativeFieldInfoPtr_lockedDisplay));
      return pointer == IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LorePage.NativeFieldInfoPtr_lockedDisplay), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject unlockedDisplay
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LorePage.NativeFieldInfoPtr_unlockedDisplay));
      return pointer == IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LorePage.NativeFieldInfoPtr_unlockedDisplay), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject newDisplay
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LorePage.NativeFieldInfoPtr_newDisplay));
      return pointer == IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LorePage.NativeFieldInfoPtr_newDisplay), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Button button
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LorePage.NativeFieldInfoPtr_button));
      return pointer == IntPtr.Zero ? (Button) null : new Button(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LorePage.NativeFieldInfoPtr_button), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Canvas canvas
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LorePage.NativeFieldInfoPtr_canvas));
      return pointer == IntPtr.Zero ? (Canvas) null : new Canvas(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LorePage.NativeFieldInfoPtr_canvas), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool isUnlocked
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LorePage.NativeFieldInfoPtr_isUnlocked));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LorePage.NativeFieldInfoPtr_isUnlocked)) = value;
    }
  }

  public unsafe bool isNew
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LorePage.NativeFieldInfoPtr_isNew));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LorePage.NativeFieldInfoPtr_isNew)) = value;
    }
  }

  public unsafe TweenUI denyTween
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LorePage.NativeFieldInfoPtr_denyTween));
      return pointer == IntPtr.Zero ? (TweenUI) null : new TweenUI(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LorePage.NativeFieldInfoPtr_denyTween), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TweenUI newTween
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LorePage.NativeFieldInfoPtr_newTween));
      return pointer == IntPtr.Zero ? (TweenUI) null : new TweenUI(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LorePage.NativeFieldInfoPtr_newTween), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
