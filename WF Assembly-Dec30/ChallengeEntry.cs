// Decompiled with JetBrains decompiler
// Type: ChallengeEntry
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.Localization.Components;
using UnityEngine.UI;

#nullable disable
public class ChallengeEntry : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_text;
  private static readonly IntPtr NativeFieldInfoPtr_progressText;
  private static readonly IntPtr NativeFieldInfoPtr_rewardText;
  private static readonly IntPtr NativeFieldInfoPtr_background;
  private static readonly IntPtr NativeFieldInfoPtr_rewardIcon;
  private static readonly IntPtr NativeFieldInfoPtr_challenge;
  private static readonly IntPtr NativeMethodInfoPtr_Assign_Public_Void_ChallengeData_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetProgress_Public_Void_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetText_Public_Void_String_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 87222, RefRangeEnd = 87224, XrefRangeStart = 87211, XrefRangeEnd = 87222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Assign(ChallengeData challenge, bool completed)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) challenge);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &completed;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ChallengeEntry.NativeMethodInfoPtr_Assign_Public_Void_ChallengeData_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 87232, RefRangeEnd = 87233, XrefRangeStart = 87224, XrefRangeEnd = 87232, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetProgress(int progress)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &progress
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ChallengeEntry.NativeMethodInfoPtr_SetProgress_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87233, XrefRangeEnd = 87245, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetText(string str)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(str)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ChallengeEntry.NativeMethodInfoPtr_SetText_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(212)]
  [CachedScanResults(RefRangeStart = 12749, RefRangeEnd = 12961, XrefRangeStart = 12749, XrefRangeEnd = 12961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ChallengeEntry()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChallengeEntry>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ChallengeEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static ChallengeEntry()
  {
    Il2CppClassPointerStore<ChallengeEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (ChallengeEntry));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChallengeEntry>.NativeClassPtr);
    ChallengeEntry.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeEntry>.NativeClassPtr, nameof (text));
    ChallengeEntry.NativeFieldInfoPtr_progressText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeEntry>.NativeClassPtr, nameof (progressText));
    ChallengeEntry.NativeFieldInfoPtr_rewardText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeEntry>.NativeClassPtr, nameof (rewardText));
    ChallengeEntry.NativeFieldInfoPtr_background = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeEntry>.NativeClassPtr, nameof (background));
    ChallengeEntry.NativeFieldInfoPtr_rewardIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeEntry>.NativeClassPtr, nameof (rewardIcon));
    ChallengeEntry.NativeFieldInfoPtr_challenge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeEntry>.NativeClassPtr, nameof (challenge));
    ChallengeEntry.NativeMethodInfoPtr_Assign_Public_Void_ChallengeData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeEntry>.NativeClassPtr, 100670674);
    ChallengeEntry.NativeMethodInfoPtr_SetProgress_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeEntry>.NativeClassPtr, 100670675);
    ChallengeEntry.NativeMethodInfoPtr_SetText_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeEntry>.NativeClassPtr, 100670676);
    ChallengeEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeEntry>.NativeClassPtr, 100670677);
  }

  public ChallengeEntry(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe LocalizeStringEvent text
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChallengeEntry.NativeFieldInfoPtr_text));
      return pointer == IntPtr.Zero ? (LocalizeStringEvent) null : new LocalizeStringEvent(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChallengeEntry.NativeFieldInfoPtr_text), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TMP_Text progressText
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChallengeEntry.NativeFieldInfoPtr_progressText));
      return pointer == IntPtr.Zero ? (TMP_Text) null : new TMP_Text(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChallengeEntry.NativeFieldInfoPtr_progressText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizeStringEvent rewardText
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChallengeEntry.NativeFieldInfoPtr_rewardText));
      return pointer == IntPtr.Zero ? (LocalizeStringEvent) null : new LocalizeStringEvent(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChallengeEntry.NativeFieldInfoPtr_rewardText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Image background
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChallengeEntry.NativeFieldInfoPtr_background));
      return pointer == IntPtr.Zero ? (Image) null : new Image(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChallengeEntry.NativeFieldInfoPtr_background), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Image rewardIcon
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChallengeEntry.NativeFieldInfoPtr_rewardIcon));
      return pointer == IntPtr.Zero ? (Image) null : new Image(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChallengeEntry.NativeFieldInfoPtr_rewardIcon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ChallengeData challenge
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChallengeEntry.NativeFieldInfoPtr_challenge));
      return pointer == IntPtr.Zero ? (ChallengeData) null : new ChallengeData(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChallengeEntry.NativeFieldInfoPtr_challenge), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
