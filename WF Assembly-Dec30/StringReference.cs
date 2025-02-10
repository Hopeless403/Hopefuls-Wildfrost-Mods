// Decompiled with JetBrains decompiler
// Type: StringReference
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine.Localization;

#nullable disable
public class StringReference : MonoBehaviourSingleton<StringReference>
{
  private static readonly IntPtr NativeFieldInfoPtr_injured;
  private static readonly IntPtr NativeFieldInfoPtr_tutorialCharm1;
  private static readonly IntPtr NativeFieldInfoPtr_tutorialCharm2;
  private static readonly IntPtr NativeFieldInfoPtr_tutorialCrown;
  private static readonly IntPtr NativeFieldInfoPtr_tutorialInjury;
  private static readonly IntPtr NativeFieldInfoPtr_tutorialInjuryMultiple;
  private static readonly IntPtr NativeFieldInfoPtr_tutorialCompanion1;
  private static readonly IntPtr NativeFieldInfoPtr_tutorialCompanion1Gamepad;
  private static readonly IntPtr NativeFieldInfoPtr_tutorialCompanion1Touch;
  private static readonly IntPtr NativeFieldInfoPtr_tutorialCompanion2;
  private static readonly IntPtr NativeFieldInfoPtr_tutorialItem;
  private static readonly IntPtr NativeFieldInfoPtr_tutorialBattle1_1;
  private static readonly IntPtr NativeFieldInfoPtr_tutorialBattle1_2;
  private static readonly IntPtr NativeFieldInfoPtr_tutorialBattle1_3;
  private static readonly IntPtr NativeFieldInfoPtr_tutorialBattle1_4;
  private static readonly IntPtr NativeFieldInfoPtr_tutorialBattle1_41;
  private static readonly IntPtr NativeFieldInfoPtr_tutorialBattle1_5;
  private static readonly IntPtr NativeFieldInfoPtr_tutorialBattle1_6;
  private static readonly IntPtr NativeFieldInfoPtr_tutorialBattle1_7;
  private static readonly IntPtr NativeFieldInfoPtr_tutorialBattle1_8;
  private static readonly IntPtr NativeFieldInfoPtr_tutorialBattle2_1;
  private static readonly IntPtr NativeFieldInfoPtr_tutorialBattle2_1Gamepad;
  private static readonly IntPtr NativeFieldInfoPtr_tutorialBattle2_2;
  private static readonly IntPtr NativeFieldInfoPtr_tutorialBattle2_3;
  private static readonly IntPtr NativeFieldInfoPtr_tutorialBattle2_4;
  private static readonly IntPtr NativeFieldInfoPtr_tutorialBattle2_41a;
  private static readonly IntPtr NativeFieldInfoPtr_tutorialBattle2_41b;
  private static readonly IntPtr NativeFieldInfoPtr_tutorialBattle2_5;
  private static readonly IntPtr NativeFieldInfoPtr_tutorialBattle2_6;
  private static readonly IntPtr NativeFieldInfoPtr_tutorialBattle3_1;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54566, XrefRangeEnd = 54569, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe StringReference()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StringReference>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StringReference.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static StringReference()
  {
    Il2CppClassPointerStore<StringReference>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (StringReference));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StringReference>.NativeClassPtr);
    StringReference.NativeFieldInfoPtr_injured = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringReference>.NativeClassPtr, nameof (injured));
    StringReference.NativeFieldInfoPtr_tutorialCharm1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringReference>.NativeClassPtr, nameof (tutorialCharm1));
    StringReference.NativeFieldInfoPtr_tutorialCharm2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringReference>.NativeClassPtr, nameof (tutorialCharm2));
    StringReference.NativeFieldInfoPtr_tutorialCrown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringReference>.NativeClassPtr, nameof (tutorialCrown));
    StringReference.NativeFieldInfoPtr_tutorialInjury = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringReference>.NativeClassPtr, nameof (tutorialInjury));
    StringReference.NativeFieldInfoPtr_tutorialInjuryMultiple = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringReference>.NativeClassPtr, nameof (tutorialInjuryMultiple));
    StringReference.NativeFieldInfoPtr_tutorialCompanion1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringReference>.NativeClassPtr, nameof (tutorialCompanion1));
    StringReference.NativeFieldInfoPtr_tutorialCompanion1Gamepad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringReference>.NativeClassPtr, nameof (tutorialCompanion1Gamepad));
    StringReference.NativeFieldInfoPtr_tutorialCompanion1Touch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringReference>.NativeClassPtr, nameof (tutorialCompanion1Touch));
    StringReference.NativeFieldInfoPtr_tutorialCompanion2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringReference>.NativeClassPtr, nameof (tutorialCompanion2));
    StringReference.NativeFieldInfoPtr_tutorialItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringReference>.NativeClassPtr, nameof (tutorialItem));
    StringReference.NativeFieldInfoPtr_tutorialBattle1_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringReference>.NativeClassPtr, nameof (tutorialBattle1_1));
    StringReference.NativeFieldInfoPtr_tutorialBattle1_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringReference>.NativeClassPtr, nameof (tutorialBattle1_2));
    StringReference.NativeFieldInfoPtr_tutorialBattle1_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringReference>.NativeClassPtr, nameof (tutorialBattle1_3));
    StringReference.NativeFieldInfoPtr_tutorialBattle1_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringReference>.NativeClassPtr, nameof (tutorialBattle1_4));
    StringReference.NativeFieldInfoPtr_tutorialBattle1_41 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringReference>.NativeClassPtr, nameof (tutorialBattle1_41));
    StringReference.NativeFieldInfoPtr_tutorialBattle1_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringReference>.NativeClassPtr, nameof (tutorialBattle1_5));
    StringReference.NativeFieldInfoPtr_tutorialBattle1_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringReference>.NativeClassPtr, nameof (tutorialBattle1_6));
    StringReference.NativeFieldInfoPtr_tutorialBattle1_7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringReference>.NativeClassPtr, nameof (tutorialBattle1_7));
    StringReference.NativeFieldInfoPtr_tutorialBattle1_8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringReference>.NativeClassPtr, nameof (tutorialBattle1_8));
    StringReference.NativeFieldInfoPtr_tutorialBattle2_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringReference>.NativeClassPtr, nameof (tutorialBattle2_1));
    StringReference.NativeFieldInfoPtr_tutorialBattle2_1Gamepad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringReference>.NativeClassPtr, nameof (tutorialBattle2_1Gamepad));
    StringReference.NativeFieldInfoPtr_tutorialBattle2_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringReference>.NativeClassPtr, nameof (tutorialBattle2_2));
    StringReference.NativeFieldInfoPtr_tutorialBattle2_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringReference>.NativeClassPtr, nameof (tutorialBattle2_3));
    StringReference.NativeFieldInfoPtr_tutorialBattle2_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringReference>.NativeClassPtr, nameof (tutorialBattle2_4));
    StringReference.NativeFieldInfoPtr_tutorialBattle2_41a = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringReference>.NativeClassPtr, nameof (tutorialBattle2_41a));
    StringReference.NativeFieldInfoPtr_tutorialBattle2_41b = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringReference>.NativeClassPtr, nameof (tutorialBattle2_41b));
    StringReference.NativeFieldInfoPtr_tutorialBattle2_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringReference>.NativeClassPtr, nameof (tutorialBattle2_5));
    StringReference.NativeFieldInfoPtr_tutorialBattle2_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringReference>.NativeClassPtr, nameof (tutorialBattle2_6));
    StringReference.NativeFieldInfoPtr_tutorialBattle3_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringReference>.NativeClassPtr, nameof (tutorialBattle3_1));
    StringReference.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringReference>.NativeClassPtr, 100667792);
  }

  public StringReference(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe LocalizedString injured
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StringReference.NativeFieldInfoPtr_injured));
      return pointer == IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StringReference.NativeFieldInfoPtr_injured), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedString tutorialCharm1
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StringReference.NativeFieldInfoPtr_tutorialCharm1));
      return pointer == IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StringReference.NativeFieldInfoPtr_tutorialCharm1), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedString tutorialCharm2
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StringReference.NativeFieldInfoPtr_tutorialCharm2));
      return pointer == IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StringReference.NativeFieldInfoPtr_tutorialCharm2), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedString tutorialCrown
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StringReference.NativeFieldInfoPtr_tutorialCrown));
      return pointer == IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StringReference.NativeFieldInfoPtr_tutorialCrown), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedString tutorialInjury
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StringReference.NativeFieldInfoPtr_tutorialInjury));
      return pointer == IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StringReference.NativeFieldInfoPtr_tutorialInjury), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedString tutorialInjuryMultiple
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StringReference.NativeFieldInfoPtr_tutorialInjuryMultiple));
      return pointer == IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StringReference.NativeFieldInfoPtr_tutorialInjuryMultiple), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedString tutorialCompanion1
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StringReference.NativeFieldInfoPtr_tutorialCompanion1));
      return pointer == IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StringReference.NativeFieldInfoPtr_tutorialCompanion1), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedString tutorialCompanion1Gamepad
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StringReference.NativeFieldInfoPtr_tutorialCompanion1Gamepad));
      return pointer == IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StringReference.NativeFieldInfoPtr_tutorialCompanion1Gamepad), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedString tutorialCompanion1Touch
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StringReference.NativeFieldInfoPtr_tutorialCompanion1Touch));
      return pointer == IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StringReference.NativeFieldInfoPtr_tutorialCompanion1Touch), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedString tutorialCompanion2
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StringReference.NativeFieldInfoPtr_tutorialCompanion2));
      return pointer == IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StringReference.NativeFieldInfoPtr_tutorialCompanion2), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedString tutorialItem
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StringReference.NativeFieldInfoPtr_tutorialItem));
      return pointer == IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StringReference.NativeFieldInfoPtr_tutorialItem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedString tutorialBattle1_1
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StringReference.NativeFieldInfoPtr_tutorialBattle1_1));
      return pointer == IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StringReference.NativeFieldInfoPtr_tutorialBattle1_1), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedString tutorialBattle1_2
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StringReference.NativeFieldInfoPtr_tutorialBattle1_2));
      return pointer == IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StringReference.NativeFieldInfoPtr_tutorialBattle1_2), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedString tutorialBattle1_3
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StringReference.NativeFieldInfoPtr_tutorialBattle1_3));
      return pointer == IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StringReference.NativeFieldInfoPtr_tutorialBattle1_3), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedString tutorialBattle1_4
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StringReference.NativeFieldInfoPtr_tutorialBattle1_4));
      return pointer == IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StringReference.NativeFieldInfoPtr_tutorialBattle1_4), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedString tutorialBattle1_41
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StringReference.NativeFieldInfoPtr_tutorialBattle1_41));
      return pointer == IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StringReference.NativeFieldInfoPtr_tutorialBattle1_41), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedString tutorialBattle1_5
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StringReference.NativeFieldInfoPtr_tutorialBattle1_5));
      return pointer == IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StringReference.NativeFieldInfoPtr_tutorialBattle1_5), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedString tutorialBattle1_6
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StringReference.NativeFieldInfoPtr_tutorialBattle1_6));
      return pointer == IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StringReference.NativeFieldInfoPtr_tutorialBattle1_6), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedString tutorialBattle1_7
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StringReference.NativeFieldInfoPtr_tutorialBattle1_7));
      return pointer == IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StringReference.NativeFieldInfoPtr_tutorialBattle1_7), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedString tutorialBattle1_8
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StringReference.NativeFieldInfoPtr_tutorialBattle1_8));
      return pointer == IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StringReference.NativeFieldInfoPtr_tutorialBattle1_8), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedString tutorialBattle2_1
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StringReference.NativeFieldInfoPtr_tutorialBattle2_1));
      return pointer == IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StringReference.NativeFieldInfoPtr_tutorialBattle2_1), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedString tutorialBattle2_1Gamepad
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StringReference.NativeFieldInfoPtr_tutorialBattle2_1Gamepad));
      return pointer == IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StringReference.NativeFieldInfoPtr_tutorialBattle2_1Gamepad), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedString tutorialBattle2_2
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StringReference.NativeFieldInfoPtr_tutorialBattle2_2));
      return pointer == IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StringReference.NativeFieldInfoPtr_tutorialBattle2_2), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedString tutorialBattle2_3
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StringReference.NativeFieldInfoPtr_tutorialBattle2_3));
      return pointer == IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StringReference.NativeFieldInfoPtr_tutorialBattle2_3), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedString tutorialBattle2_4
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StringReference.NativeFieldInfoPtr_tutorialBattle2_4));
      return pointer == IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StringReference.NativeFieldInfoPtr_tutorialBattle2_4), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedString tutorialBattle2_41a
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StringReference.NativeFieldInfoPtr_tutorialBattle2_41a));
      return pointer == IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StringReference.NativeFieldInfoPtr_tutorialBattle2_41a), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedString tutorialBattle2_41b
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StringReference.NativeFieldInfoPtr_tutorialBattle2_41b));
      return pointer == IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StringReference.NativeFieldInfoPtr_tutorialBattle2_41b), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedString tutorialBattle2_5
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StringReference.NativeFieldInfoPtr_tutorialBattle2_5));
      return pointer == IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StringReference.NativeFieldInfoPtr_tutorialBattle2_5), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedString tutorialBattle2_6
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StringReference.NativeFieldInfoPtr_tutorialBattle2_6));
      return pointer == IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StringReference.NativeFieldInfoPtr_tutorialBattle2_6), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedString tutorialBattle3_1
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StringReference.NativeFieldInfoPtr_tutorialBattle3_1));
      return pointer == IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StringReference.NativeFieldInfoPtr_tutorialBattle3_1), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
