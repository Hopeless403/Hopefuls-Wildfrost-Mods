// Decompiled with JetBrains decompiler
// Type: CrownHolder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
public class CrownHolder : UpgradeHolder
{
  private static readonly IntPtr NativeFieldInfoPtr_gap;
  private static readonly IntPtr NativeFieldInfoPtr_angleRange;
  private static readonly IntPtr NativeFieldInfoPtr_xRange;
  private static readonly IntPtr NativeFieldInfoPtr_xMax;
  private static readonly IntPtr NativeFieldInfoPtr_seed;
  private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetPositions_Public_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44100, XrefRangeEnd = 44101, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CrownHolder.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44101, XrefRangeEnd = 44133, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void SetPositions()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CrownHolder.NativeMethodInfoPtr_SetPositions_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44133, XrefRangeEnd = 44134, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CrownHolder()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CrownHolder>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CrownHolder.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static CrownHolder()
  {
    Il2CppClassPointerStore<CrownHolder>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (CrownHolder));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CrownHolder>.NativeClassPtr);
    CrownHolder.NativeFieldInfoPtr_gap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrownHolder>.NativeClassPtr, nameof (gap));
    CrownHolder.NativeFieldInfoPtr_angleRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrownHolder>.NativeClassPtr, nameof (angleRange));
    CrownHolder.NativeFieldInfoPtr_xRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrownHolder>.NativeClassPtr, nameof (xRange));
    CrownHolder.NativeFieldInfoPtr_xMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrownHolder>.NativeClassPtr, nameof (xMax));
    CrownHolder.NativeFieldInfoPtr_seed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrownHolder>.NativeClassPtr, nameof (seed));
    CrownHolder.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrownHolder>.NativeClassPtr, 100666601);
    CrownHolder.NativeMethodInfoPtr_SetPositions_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrownHolder>.NativeClassPtr, 100666602);
    CrownHolder.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrownHolder>.NativeClassPtr, 100666603);
  }

  public CrownHolder(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe float gap
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CrownHolder.NativeFieldInfoPtr_gap));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CrownHolder.NativeFieldInfoPtr_gap)) = value;
    }
  }

  public unsafe float angleRange
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CrownHolder.NativeFieldInfoPtr_angleRange));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CrownHolder.NativeFieldInfoPtr_angleRange)) = value;
    }
  }

  public unsafe float xRange
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CrownHolder.NativeFieldInfoPtr_xRange));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CrownHolder.NativeFieldInfoPtr_xRange)) = value;
    }
  }

  public unsafe float xMax
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CrownHolder.NativeFieldInfoPtr_xMax));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CrownHolder.NativeFieldInfoPtr_xMax)) = value;
    }
  }

  public unsafe int seed
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CrownHolder.NativeFieldInfoPtr_seed));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CrownHolder.NativeFieldInfoPtr_seed)) = value;
    }
  }
}
