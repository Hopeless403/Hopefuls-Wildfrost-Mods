// Decompiled with JetBrains decompiler
// Type: ChallengeListenerHighest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;

#nullable disable
public class ChallengeListenerHighest : ChallengeListener
{
  private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Void_String_Int32_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109004, XrefRangeEnd = 109005, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Set(string challengeName, int oldValue, int newValue)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[3];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(challengeName);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &oldValue;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &newValue;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ChallengeListenerHighest.NativeMethodInfoPtr_Set_Public_Virtual_Void_String_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(110)]
  [CachedScanResults(RefRangeStart = 104608, RefRangeEnd = 104718, XrefRangeStart = 104608, XrefRangeEnd = 104718, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ChallengeListenerHighest()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChallengeListenerHighest>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ChallengeListenerHighest.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static ChallengeListenerHighest()
  {
    Il2CppClassPointerStore<ChallengeListenerHighest>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (ChallengeListenerHighest));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChallengeListenerHighest>.NativeClassPtr);
    ChallengeListenerHighest.NativeMethodInfoPtr_Set_Public_Virtual_Void_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeListenerHighest>.NativeClassPtr, 100673334);
    ChallengeListenerHighest.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeListenerHighest>.NativeClassPtr, 100673335);
  }

  public ChallengeListenerHighest(IntPtr pointer)
    : base(pointer)
  {
  }
}
