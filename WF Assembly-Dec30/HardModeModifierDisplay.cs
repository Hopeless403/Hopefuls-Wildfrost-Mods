// Decompiled with JetBrains decompiler
// Type: HardModeModifierDisplay
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class HardModeModifierDisplay : ModifierDisplay
{
  private static readonly System.IntPtr NativeFieldInfoPtr_background;
  private static readonly System.IntPtr NativeFieldInfoPtr_modifiers;
  private static readonly System.IntPtr NativeFieldInfoPtr_active;
  private static readonly System.IntPtr NativeMethodInfoPtr_Populate_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Toggle_Public_Void_GameModifierData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 92982, RefRangeEnd = 92983, XrefRangeStart = 92931, XrefRangeEnd = 92982, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Populate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(HardModeModifierDisplay.NativeMethodInfoPtr_Populate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92983, XrefRangeEnd = 93010, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Toggle(GameModifierData modifier)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) modifier)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(HardModeModifierDisplay.NativeMethodInfoPtr_Toggle_Public_Void_GameModifierData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93010, XrefRangeEnd = 93011, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe HardModeModifierDisplay()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HardModeModifierDisplay>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(HardModeModifierDisplay.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static HardModeModifierDisplay()
  {
    Il2CppClassPointerStore<HardModeModifierDisplay>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (HardModeModifierDisplay));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HardModeModifierDisplay>.NativeClassPtr);
    HardModeModifierDisplay.NativeFieldInfoPtr_background = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HardModeModifierDisplay>.NativeClassPtr, nameof (background));
    HardModeModifierDisplay.NativeFieldInfoPtr_modifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HardModeModifierDisplay>.NativeClassPtr, nameof (modifiers));
    HardModeModifierDisplay.NativeFieldInfoPtr_active = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HardModeModifierDisplay>.NativeClassPtr, nameof (active));
    HardModeModifierDisplay.NativeMethodInfoPtr_Populate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardModeModifierDisplay>.NativeClassPtr, 100671322);
    HardModeModifierDisplay.NativeMethodInfoPtr_Toggle_Public_Void_GameModifierData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardModeModifierDisplay>.NativeClassPtr, 100671323);
    HardModeModifierDisplay.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardModeModifierDisplay>.NativeClassPtr, 100671324);
  }

  public HardModeModifierDisplay(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe GameObject background
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HardModeModifierDisplay.NativeFieldInfoPtr_background));
      return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HardModeModifierDisplay.NativeFieldInfoPtr_background), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<GameModifierData> modifiers
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HardModeModifierDisplay.NativeFieldInfoPtr_modifiers));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<GameModifierData>) null : new Il2CppReferenceArray<GameModifierData>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HardModeModifierDisplay.NativeFieldInfoPtr_modifiers), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<string> active
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HardModeModifierDisplay.NativeFieldInfoPtr_active));
      return pointer == System.IntPtr.Zero ? (List<string>) null : new List<string>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HardModeModifierDisplay.NativeFieldInfoPtr_active), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [ObfuscatedName("HardModeModifierDisplay/<>c__DisplayClass3_0")]
  public sealed class __c__DisplayClass3_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_modifier;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Populate_b__0_Internal_Void_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass3_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HardModeModifierDisplay.__c__DisplayClass3_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HardModeModifierDisplay.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92904, XrefRangeEnd = 92931, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Populate_b__0()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HardModeModifierDisplay.__c__DisplayClass3_0.NativeMethodInfoPtr__Populate_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static __c__DisplayClass3_0()
    {
      Il2CppClassPointerStore<HardModeModifierDisplay.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HardModeModifierDisplay>.NativeClassPtr, "<>c__DisplayClass3_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HardModeModifierDisplay.__c__DisplayClass3_0>.NativeClassPtr);
      HardModeModifierDisplay.__c__DisplayClass3_0.NativeFieldInfoPtr_modifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HardModeModifierDisplay.__c__DisplayClass3_0>.NativeClassPtr, nameof (modifier));
      HardModeModifierDisplay.__c__DisplayClass3_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HardModeModifierDisplay.__c__DisplayClass3_0>.NativeClassPtr, "<>4__this");
      HardModeModifierDisplay.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardModeModifierDisplay.__c__DisplayClass3_0>.NativeClassPtr, 100671325);
      HardModeModifierDisplay.__c__DisplayClass3_0.NativeMethodInfoPtr__Populate_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardModeModifierDisplay.__c__DisplayClass3_0>.NativeClassPtr, 100671326);
    }

    public __c__DisplayClass3_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe GameModifierData modifier
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HardModeModifierDisplay.__c__DisplayClass3_0.NativeFieldInfoPtr_modifier));
        return pointer == System.IntPtr.Zero ? (GameModifierData) null : new GameModifierData(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HardModeModifierDisplay.__c__DisplayClass3_0.NativeFieldInfoPtr_modifier), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe HardModeModifierDisplay __4__this
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HardModeModifierDisplay.__c__DisplayClass3_0.NativeFieldInfoPtr___4__this));
        return pointer == System.IntPtr.Zero ? (HardModeModifierDisplay) null : new HardModeModifierDisplay(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HardModeModifierDisplay.__c__DisplayClass3_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
