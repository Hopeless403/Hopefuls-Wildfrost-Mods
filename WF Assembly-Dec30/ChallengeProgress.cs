// Decompiled with JetBrains decompiler
// Type: ChallengeProgress
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
[Serializable]
public class ChallengeProgress : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr_challengeName;
  private static readonly System.IntPtr NativeFieldInfoPtr_currentValue;
  private static readonly System.IntPtr NativeFieldInfoPtr_originalValue;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0;

  [CallerCount(1959)]
  [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ChallengeProgress()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChallengeProgress>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ChallengeProgress.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 102812, RefRangeEnd = 102813, XrefRangeStart = 102810, XrefRangeEnd = 102812, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ChallengeProgress(string challengeName, int value)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChallengeProgress>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(challengeName);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ChallengeProgress.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static ChallengeProgress()
  {
    Il2CppClassPointerStore<ChallengeProgress>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (ChallengeProgress));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChallengeProgress>.NativeClassPtr);
    ChallengeProgress.NativeFieldInfoPtr_challengeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeProgress>.NativeClassPtr, nameof (challengeName));
    ChallengeProgress.NativeFieldInfoPtr_currentValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeProgress>.NativeClassPtr, nameof (currentValue));
    ChallengeProgress.NativeFieldInfoPtr_originalValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeProgress>.NativeClassPtr, nameof (originalValue));
    ChallengeProgress.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeProgress>.NativeClassPtr, 100672541);
    ChallengeProgress.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeProgress>.NativeClassPtr, 100672542);
  }

  public ChallengeProgress(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe string challengeName
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChallengeProgress.NativeFieldInfoPtr_challengeName)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChallengeProgress.NativeFieldInfoPtr_challengeName), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe int currentValue
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChallengeProgress.NativeFieldInfoPtr_currentValue));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChallengeProgress.NativeFieldInfoPtr_currentValue)) = value;
    }
  }

  public unsafe int originalValue
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChallengeProgress.NativeFieldInfoPtr_originalValue));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChallengeProgress.NativeFieldInfoPtr_originalValue)) = value;
    }
  }
}
