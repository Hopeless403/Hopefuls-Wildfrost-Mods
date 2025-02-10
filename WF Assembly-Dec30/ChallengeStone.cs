// Decompiled with JetBrains decompiler
// Type: ChallengeStone
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Localization.Components;

#nullable disable
public class ChallengeStone : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_challenge;
  private static readonly IntPtr NativeFieldInfoPtr_door;
  private static readonly IntPtr NativeFieldInfoPtr_charmHolder;
  private static readonly IntPtr NativeFieldInfoPtr_navItem;
  private static readonly IntPtr NativeFieldInfoPtr_title;
  private static readonly IntPtr NativeFieldInfoPtr_text;
  private static readonly IntPtr NativeFieldInfoPtr_popUpOffset;
  private static readonly IntPtr NativeFieldInfoPtr_raycastPadding;
  private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_CardUpgradeData_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37171, XrefRangeEnd = 37173, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ChallengeStone.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 37189, RefRangeEnd = 37190, XrefRangeStart = 37173, XrefRangeEnd = 37189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Open(CardUpgradeData upgradeData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) upgradeData)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ChallengeStone.NativeMethodInfoPtr_Open_Public_Void_CardUpgradeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(212)]
  [CachedScanResults(RefRangeStart = 12749, RefRangeEnd = 12961, XrefRangeStart = 12749, XrefRangeEnd = 12961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ChallengeStone()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChallengeStone>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ChallengeStone.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static ChallengeStone()
  {
    Il2CppClassPointerStore<ChallengeStone>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (ChallengeStone));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChallengeStone>.NativeClassPtr);
    ChallengeStone.NativeFieldInfoPtr_challenge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeStone>.NativeClassPtr, nameof (challenge));
    ChallengeStone.NativeFieldInfoPtr_door = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeStone>.NativeClassPtr, nameof (door));
    ChallengeStone.NativeFieldInfoPtr_charmHolder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeStone>.NativeClassPtr, nameof (charmHolder));
    ChallengeStone.NativeFieldInfoPtr_navItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeStone>.NativeClassPtr, nameof (navItem));
    ChallengeStone.NativeFieldInfoPtr_title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeStone>.NativeClassPtr, nameof (title));
    ChallengeStone.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeStone>.NativeClassPtr, nameof (text));
    ChallengeStone.NativeFieldInfoPtr_popUpOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeStone>.NativeClassPtr, nameof (popUpOffset));
    ChallengeStone.NativeFieldInfoPtr_raycastPadding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeStone>.NativeClassPtr, nameof (raycastPadding));
    ChallengeStone.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeStone>.NativeClassPtr, 100665789);
    ChallengeStone.NativeMethodInfoPtr_Open_Public_Void_CardUpgradeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeStone>.NativeClassPtr, 100665790);
    ChallengeStone.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeStone>.NativeClassPtr, 100665791);
  }

  public ChallengeStone(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe ChallengeData challenge
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChallengeStone.NativeFieldInfoPtr_challenge));
      return pointer == IntPtr.Zero ? (ChallengeData) null : new ChallengeData(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChallengeStone.NativeFieldInfoPtr_challenge), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject door
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChallengeStone.NativeFieldInfoPtr_door));
      return pointer == IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChallengeStone.NativeFieldInfoPtr_door), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CardCharmHolder charmHolder
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChallengeStone.NativeFieldInfoPtr_charmHolder));
      return pointer == IntPtr.Zero ? (CardCharmHolder) null : new CardCharmHolder(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChallengeStone.NativeFieldInfoPtr_charmHolder), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UINavigationItem navItem
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChallengeStone.NativeFieldInfoPtr_navItem));
      return pointer == IntPtr.Zero ? (UINavigationItem) null : new UINavigationItem(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChallengeStone.NativeFieldInfoPtr_navItem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizeStringEvent title
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChallengeStone.NativeFieldInfoPtr_title));
      return pointer == IntPtr.Zero ? (LocalizeStringEvent) null : new LocalizeStringEvent(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChallengeStone.NativeFieldInfoPtr_title), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizeStringEvent text
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChallengeStone.NativeFieldInfoPtr_text));
      return pointer == IntPtr.Zero ? (LocalizeStringEvent) null : new LocalizeStringEvent(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChallengeStone.NativeFieldInfoPtr_text), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe Vector2 popUpOffset
  {
    get
    {
      Vector2 popUpOffset;
      IL2CPP.il2cpp_field_static_get_value(ChallengeStone.NativeFieldInfoPtr_popUpOffset, (void*) &popUpOffset);
      return popUpOffset;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ChallengeStone.NativeFieldInfoPtr_popUpOffset, (void*) &value);
    }
  }

  public static unsafe Vector4 raycastPadding
  {
    get
    {
      Vector4 raycastPadding;
      IL2CPP.il2cpp_field_static_get_value(ChallengeStone.NativeFieldInfoPtr_raycastPadding, (void*) &raycastPadding);
      return raycastPadding;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ChallengeStone.NativeFieldInfoPtr_raycastPadding, (void*) &value);
    }
  }
}
