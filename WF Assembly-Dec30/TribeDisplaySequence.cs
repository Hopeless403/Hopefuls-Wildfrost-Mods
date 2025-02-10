// Decompiled with JetBrains decompiler
// Type: TribeDisplaySequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class TribeDisplaySequence : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_tribeNames;
  private static readonly IntPtr NativeFieldInfoPtr_displays;
  private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Void_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Void_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 100152, RefRangeEnd = 100153, XrefRangeStart = 100149, XrefRangeEnd = 100152, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Run(string className)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(className)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TribeDisplaySequence.NativeMethodInfoPtr_Run_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 100160, RefRangeEnd = 100161, XrefRangeStart = 100153, XrefRangeEnd = 100160, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Run(int classIndex)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &classIndex
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TribeDisplaySequence.NativeMethodInfoPtr_Run_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(212)]
  [CachedScanResults(RefRangeStart = 12749, RefRangeEnd = 12961, XrefRangeStart = 12749, XrefRangeEnd = 12961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe TribeDisplaySequence()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TribeDisplaySequence>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TribeDisplaySequence.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static TribeDisplaySequence()
  {
    Il2CppClassPointerStore<TribeDisplaySequence>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (TribeDisplaySequence));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TribeDisplaySequence>.NativeClassPtr);
    TribeDisplaySequence.NativeFieldInfoPtr_tribeNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TribeDisplaySequence>.NativeClassPtr, nameof (tribeNames));
    TribeDisplaySequence.NativeFieldInfoPtr_displays = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TribeDisplaySequence>.NativeClassPtr, nameof (displays));
    TribeDisplaySequence.NativeMethodInfoPtr_Run_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TribeDisplaySequence>.NativeClassPtr, 100672275);
    TribeDisplaySequence.NativeMethodInfoPtr_Run_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TribeDisplaySequence>.NativeClassPtr, 100672276);
    TribeDisplaySequence.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TribeDisplaySequence>.NativeClassPtr, 100672277);
  }

  public TribeDisplaySequence(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Il2CppStringArray tribeNames
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TribeDisplaySequence.NativeFieldInfoPtr_tribeNames));
      return pointer == IntPtr.Zero ? (Il2CppStringArray) null : new Il2CppStringArray(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TribeDisplaySequence.NativeFieldInfoPtr_tribeNames), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<GameObject> displays
  {
    get
    {
      IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TribeDisplaySequence.NativeFieldInfoPtr_displays));
      return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<GameObject>) null : new Il2CppReferenceArray<GameObject>(nativeObject);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TribeDisplaySequence.NativeFieldInfoPtr_displays), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
