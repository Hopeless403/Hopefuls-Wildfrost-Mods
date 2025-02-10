// Decompiled with JetBrains decompiler
// Type: ModifierUnlockSystem
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
public class ModifierUnlockSystem : GameSystem
{
  private static readonly System.IntPtr NativeFieldInfoPtr_requirements;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 21168, RefRangeEnd = 21171, XrefRangeStart = 21168, XrefRangeEnd = 21171, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ModifierUnlockSystem()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ModifierUnlockSystem>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ModifierUnlockSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static ModifierUnlockSystem()
  {
    Il2CppClassPointerStore<ModifierUnlockSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (ModifierUnlockSystem));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ModifierUnlockSystem>.NativeClassPtr);
    ModifierUnlockSystem.NativeFieldInfoPtr_requirements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifierUnlockSystem>.NativeClassPtr, nameof (requirements));
    ModifierUnlockSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifierUnlockSystem>.NativeClassPtr, 100668747);
  }

  public ModifierUnlockSystem(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Il2CppReferenceArray<ModifierUnlockSystem.Requirement> requirements
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifierUnlockSystem.NativeFieldInfoPtr_requirements));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<ModifierUnlockSystem.Requirement>) null : new Il2CppReferenceArray<ModifierUnlockSystem.Requirement>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ModifierUnlockSystem.NativeFieldInfoPtr_requirements), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [Serializable]
  public sealed class Requirement : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_requiresModifiers;

    static Requirement()
    {
      Il2CppClassPointerStore<ModifierUnlockSystem.Requirement>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ModifierUnlockSystem>.NativeClassPtr, nameof (Requirement));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ModifierUnlockSystem.Requirement>.NativeClassPtr);
      ModifierUnlockSystem.Requirement.NativeFieldInfoPtr_requiresModifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifierUnlockSystem.Requirement>.NativeClassPtr, nameof (requiresModifiers));
    }

    public Requirement(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public Requirement()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ModifierUnlockSystem.Requirement>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ModifierUnlockSystem.Requirement>.NativeClassPtr, data));
    }

    public unsafe Il2CppStringArray requiresModifiers
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifierUnlockSystem.Requirement.NativeFieldInfoPtr_requiresModifiers));
        return pointer == System.IntPtr.Zero ? (Il2CppStringArray) null : new Il2CppStringArray(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ModifierUnlockSystem.Requirement.NativeFieldInfoPtr_requiresModifiers), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
