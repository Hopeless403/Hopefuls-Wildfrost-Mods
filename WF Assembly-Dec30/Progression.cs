// Decompiled with JetBrains decompiler
// Type: Progression
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
public class Progression : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr_current;
  private static readonly System.IntPtr NativeFieldInfoPtr_previousRequired;
  private static readonly System.IntPtr NativeFieldInfoPtr_required;
  private static readonly System.IntPtr NativeFieldInfoPtr_randomness;
  private static readonly System.IntPtr NativeFieldInfoPtr_minProgressAdd;
  private static readonly System.IntPtr NativeFieldInfoPtr_maxProgressAdd;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Add_Public_Boolean_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RequirementMet_Public_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetNextRequirement_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ProgressToNextUnlock_Public_Single_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103389, XrefRangeEnd = 103390, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Progression()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Progression>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Progression.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 103391, RefRangeEnd = 103392, XrefRangeStart = 103390, XrefRangeEnd = 103391, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Progression(float startAmount, float startRequirement, float randomness)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Progression>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &startAmount;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &startRequirement;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &randomness;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Progression.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103392, XrefRangeEnd = 103393, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool Add(float amount)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &amount
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Progression.NativeMethodInfoPtr_Add_Public_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 103393, RefRangeEnd = 103394, XrefRangeStart = 103393, XrefRangeEnd = 103393, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool RequirementMet()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Progression.NativeMethodInfoPtr_RequirementMet_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 103394, RefRangeEnd = 103395, XrefRangeStart = 103394, XrefRangeEnd = 103394, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetNextRequirement()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Progression.NativeMethodInfoPtr_SetNextRequirement_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 103395, RefRangeEnd = 103397, XrefRangeStart = 103395, XrefRangeEnd = 103395, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe float ProgressToNextUnlock()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Progression.NativeMethodInfoPtr_ProgressToNextUnlock_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float*) IL2CPP.il2cpp_object_unbox(num);
  }

  static Progression()
  {
    Il2CppClassPointerStore<Progression>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (Progression));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Progression>.NativeClassPtr);
    Progression.NativeFieldInfoPtr_current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Progression>.NativeClassPtr, nameof (current));
    Progression.NativeFieldInfoPtr_previousRequired = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Progression>.NativeClassPtr, nameof (previousRequired));
    Progression.NativeFieldInfoPtr_required = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Progression>.NativeClassPtr, nameof (required));
    Progression.NativeFieldInfoPtr_randomness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Progression>.NativeClassPtr, nameof (randomness));
    Progression.NativeFieldInfoPtr_minProgressAdd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Progression>.NativeClassPtr, nameof (minProgressAdd));
    Progression.NativeFieldInfoPtr_maxProgressAdd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Progression>.NativeClassPtr, nameof (maxProgressAdd));
    Progression.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Progression>.NativeClassPtr, 100672612);
    Progression.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Progression>.NativeClassPtr, 100672613);
    Progression.NativeMethodInfoPtr_Add_Public_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Progression>.NativeClassPtr, 100672614);
    Progression.NativeMethodInfoPtr_RequirementMet_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Progression>.NativeClassPtr, 100672615);
    Progression.NativeMethodInfoPtr_SetNextRequirement_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Progression>.NativeClassPtr, 100672616);
    Progression.NativeMethodInfoPtr_ProgressToNextUnlock_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Progression>.NativeClassPtr, 100672617);
  }

  public Progression(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe float current
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Progression.NativeFieldInfoPtr_current));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Progression.NativeFieldInfoPtr_current)) = value;
    }
  }

  public unsafe float previousRequired
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Progression.NativeFieldInfoPtr_previousRequired));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Progression.NativeFieldInfoPtr_previousRequired)) = value;
    }
  }

  public unsafe float required
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Progression.NativeFieldInfoPtr_required));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Progression.NativeFieldInfoPtr_required)) = value;
    }
  }

  public unsafe float randomness
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Progression.NativeFieldInfoPtr_randomness));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Progression.NativeFieldInfoPtr_randomness)) = value;
    }
  }

  public unsafe float minProgressAdd
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Progression.NativeFieldInfoPtr_minProgressAdd));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Progression.NativeFieldInfoPtr_minProgressAdd)) = value;
    }
  }

  public unsafe float maxProgressAdd
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Progression.NativeFieldInfoPtr_maxProgressAdd));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Progression.NativeFieldInfoPtr_maxProgressAdd)) = value;
    }
  }
}
