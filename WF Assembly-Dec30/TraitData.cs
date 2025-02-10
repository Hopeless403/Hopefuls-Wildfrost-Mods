// Decompiled with JetBrains decompiler
// Type: TraitData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System;
using System.Runtime.InteropServices;

#nullable disable
public class TraitData : DataFile
{
  private static readonly IntPtr NativeFieldInfoPtr_keyword;
  private static readonly IntPtr NativeFieldInfoPtr_effects;
  private static readonly IntPtr NativeFieldInfoPtr_overrides;
  private static readonly IntPtr NativeFieldInfoPtr_isReaction;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(110)]
  [CachedScanResults(RefRangeStart = 104608, RefRangeEnd = 104718, XrefRangeStart = 104608, XrefRangeEnd = 104718, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe TraitData()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TraitData>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TraitData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static TraitData()
  {
    Il2CppClassPointerStore<TraitData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (TraitData));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TraitData>.NativeClassPtr);
    TraitData.NativeFieldInfoPtr_keyword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraitData>.NativeClassPtr, nameof (keyword));
    TraitData.NativeFieldInfoPtr_effects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraitData>.NativeClassPtr, nameof (effects));
    TraitData.NativeFieldInfoPtr_overrides = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraitData>.NativeClassPtr, nameof (overrides));
    TraitData.NativeFieldInfoPtr_isReaction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraitData>.NativeClassPtr, nameof (isReaction));
    TraitData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraitData>.NativeClassPtr, 100673671);
  }

  public TraitData(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe KeywordData keyword
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TraitData.NativeFieldInfoPtr_keyword));
      return pointer == IntPtr.Zero ? (KeywordData) null : new KeywordData(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TraitData.NativeFieldInfoPtr_keyword), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<StatusEffectData> effects
  {
    get
    {
      IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TraitData.NativeFieldInfoPtr_effects));
      return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<StatusEffectData>) null : new Il2CppReferenceArray<StatusEffectData>(nativeObject);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TraitData.NativeFieldInfoPtr_effects), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<TraitData> overrides
  {
    get
    {
      IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TraitData.NativeFieldInfoPtr_overrides));
      return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<TraitData>) null : new Il2CppReferenceArray<TraitData>(nativeObject);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TraitData.NativeFieldInfoPtr_overrides), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool isReaction
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TraitData.NativeFieldInfoPtr_isReaction));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TraitData.NativeFieldInfoPtr_isReaction)) = value;
    }
  }
}
