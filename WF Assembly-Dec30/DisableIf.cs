// Decompiled with JetBrains decompiler
// Type: DisableIf
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class DisableIf : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_not;
  private static readonly IntPtr NativeFieldInfoPtr_RELEASE;
  private static readonly IntPtr NativeFieldInfoPtr_DEMO;
  private static readonly IntPtr NativeFieldInfoPtr_CHALLENGES;
  private static readonly IntPtr NativeFieldInfoPtr_BATTLE_LOG;
  private static readonly IntPtr NativeFieldInfoPtr_ANALYTICS;
  private static readonly IntPtr NativeFieldInfoPtr_JOURNAL_PAGES;
  private static readonly IntPtr NativeFieldInfoPtr_HARD_MODE;
  private static readonly IntPtr NativeFieldInfoPtr_CANNOT_EXIT;
  private static readonly IntPtr NativeFieldInfoPtr_BETA;
  private static readonly IntPtr NativeFieldInfoPtr_NEW_FROST_BELLS;
  private static readonly IntPtr NativeFieldInfoPtr_destroy;
  private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Disable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42770, XrefRangeEnd = 42774, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DisableIf.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42774, XrefRangeEnd = 42779, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Disable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DisableIf.NativeMethodInfoPtr_Disable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(212)]
  [CachedScanResults(RefRangeStart = 12749, RefRangeEnd = 12961, XrefRangeStart = 12749, XrefRangeEnd = 12961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe DisableIf()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DisableIf>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DisableIf.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static DisableIf()
  {
    Il2CppClassPointerStore<DisableIf>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (DisableIf));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DisableIf>.NativeClassPtr);
    DisableIf.NativeFieldInfoPtr_not = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableIf>.NativeClassPtr, nameof (not));
    DisableIf.NativeFieldInfoPtr_RELEASE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableIf>.NativeClassPtr, nameof (RELEASE));
    DisableIf.NativeFieldInfoPtr_DEMO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableIf>.NativeClassPtr, nameof (DEMO));
    DisableIf.NativeFieldInfoPtr_CHALLENGES = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableIf>.NativeClassPtr, nameof (CHALLENGES));
    DisableIf.NativeFieldInfoPtr_BATTLE_LOG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableIf>.NativeClassPtr, nameof (BATTLE_LOG));
    DisableIf.NativeFieldInfoPtr_ANALYTICS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableIf>.NativeClassPtr, nameof (ANALYTICS));
    DisableIf.NativeFieldInfoPtr_JOURNAL_PAGES = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableIf>.NativeClassPtr, nameof (JOURNAL_PAGES));
    DisableIf.NativeFieldInfoPtr_HARD_MODE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableIf>.NativeClassPtr, nameof (HARD_MODE));
    DisableIf.NativeFieldInfoPtr_CANNOT_EXIT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableIf>.NativeClassPtr, nameof (CANNOT_EXIT));
    DisableIf.NativeFieldInfoPtr_BETA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableIf>.NativeClassPtr, nameof (BETA));
    DisableIf.NativeFieldInfoPtr_NEW_FROST_BELLS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableIf>.NativeClassPtr, nameof (NEW_FROST_BELLS));
    DisableIf.NativeFieldInfoPtr_destroy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableIf>.NativeClassPtr, nameof (destroy));
    DisableIf.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisableIf>.NativeClassPtr, 100666474);
    DisableIf.NativeMethodInfoPtr_Disable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisableIf>.NativeClassPtr, 100666475);
    DisableIf.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisableIf>.NativeClassPtr, 100666476);
  }

  public DisableIf(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe bool not
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DisableIf.NativeFieldInfoPtr_not));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DisableIf.NativeFieldInfoPtr_not)) = value;
    }
  }

  public unsafe bool RELEASE
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DisableIf.NativeFieldInfoPtr_RELEASE));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DisableIf.NativeFieldInfoPtr_RELEASE)) = value;
    }
  }

  public unsafe bool DEMO
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DisableIf.NativeFieldInfoPtr_DEMO));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DisableIf.NativeFieldInfoPtr_DEMO)) = value;
    }
  }

  public unsafe bool CHALLENGES
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DisableIf.NativeFieldInfoPtr_CHALLENGES));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DisableIf.NativeFieldInfoPtr_CHALLENGES)) = value;
    }
  }

  public unsafe bool BATTLE_LOG
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DisableIf.NativeFieldInfoPtr_BATTLE_LOG));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DisableIf.NativeFieldInfoPtr_BATTLE_LOG)) = value;
    }
  }

  public unsafe bool ANALYTICS
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DisableIf.NativeFieldInfoPtr_ANALYTICS));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DisableIf.NativeFieldInfoPtr_ANALYTICS)) = value;
    }
  }

  public unsafe bool JOURNAL_PAGES
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DisableIf.NativeFieldInfoPtr_JOURNAL_PAGES));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DisableIf.NativeFieldInfoPtr_JOURNAL_PAGES)) = value;
    }
  }

  public unsafe bool HARD_MODE
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DisableIf.NativeFieldInfoPtr_HARD_MODE));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DisableIf.NativeFieldInfoPtr_HARD_MODE)) = value;
    }
  }

  public unsafe bool CANNOT_EXIT
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DisableIf.NativeFieldInfoPtr_CANNOT_EXIT));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DisableIf.NativeFieldInfoPtr_CANNOT_EXIT)) = value;
    }
  }

  public unsafe bool BETA
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DisableIf.NativeFieldInfoPtr_BETA));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DisableIf.NativeFieldInfoPtr_BETA)) = value;
    }
  }

  public unsafe bool NEW_FROST_BELLS
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DisableIf.NativeFieldInfoPtr_NEW_FROST_BELLS));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DisableIf.NativeFieldInfoPtr_NEW_FROST_BELLS)) = value;
    }
  }

  public unsafe bool destroy
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DisableIf.NativeFieldInfoPtr_destroy));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DisableIf.NativeFieldInfoPtr_destroy)) = value;
    }
  }
}
