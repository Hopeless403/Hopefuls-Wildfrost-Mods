// Decompiled with JetBrains decompiler
// Type: BlessingSelect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Localization.Components;

#nullable disable
public class BlessingSelect : MonoBehaviour
{
  private static readonly System.IntPtr NativeFieldInfoPtr_inputAction;
  private static readonly System.IntPtr NativeFieldInfoPtr_bellImage;
  private static readonly System.IntPtr NativeFieldInfoPtr_dingerImage;
  private static readonly System.IntPtr NativeFieldInfoPtr_titleString;
  private static readonly System.IntPtr NativeFieldInfoPtr_descString;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetUp_Public_Void_BlessingData_GainBlessingSequence_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86748, XrefRangeEnd = 86766, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetUp(BlessingData blessingData, GainBlessingSequence gainBlessingSequence)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) blessingData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gainBlessingSequence);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BlessingSelect.NativeMethodInfoPtr_SetUp_Public_Void_BlessingData_GainBlessingSequence_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(212)]
  [CachedScanResults(RefRangeStart = 12749, RefRangeEnd = 12961, XrefRangeStart = 12749, XrefRangeEnd = 12961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe BlessingSelect()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlessingSelect>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BlessingSelect.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static BlessingSelect()
  {
    Il2CppClassPointerStore<BlessingSelect>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (BlessingSelect));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlessingSelect>.NativeClassPtr);
    BlessingSelect.NativeFieldInfoPtr_inputAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlessingSelect>.NativeClassPtr, nameof (inputAction));
    BlessingSelect.NativeFieldInfoPtr_bellImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlessingSelect>.NativeClassPtr, nameof (bellImage));
    BlessingSelect.NativeFieldInfoPtr_dingerImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlessingSelect>.NativeClassPtr, nameof (dingerImage));
    BlessingSelect.NativeFieldInfoPtr_titleString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlessingSelect>.NativeClassPtr, nameof (titleString));
    BlessingSelect.NativeFieldInfoPtr_descString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlessingSelect>.NativeClassPtr, nameof (descString));
    BlessingSelect.NativeMethodInfoPtr_SetUp_Public_Void_BlessingData_GainBlessingSequence_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlessingSelect>.NativeClassPtr, 100670613);
    BlessingSelect.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlessingSelect>.NativeClassPtr, 100670614);
  }

  public BlessingSelect(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe InputAction inputAction
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlessingSelect.NativeFieldInfoPtr_inputAction));
      return pointer == System.IntPtr.Zero ? (InputAction) null : new InputAction(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BlessingSelect.NativeFieldInfoPtr_inputAction), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ImageSprite bellImage
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlessingSelect.NativeFieldInfoPtr_bellImage));
      return pointer == System.IntPtr.Zero ? (ImageSprite) null : new ImageSprite(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BlessingSelect.NativeFieldInfoPtr_bellImage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ImageSprite dingerImage
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlessingSelect.NativeFieldInfoPtr_dingerImage));
      return pointer == System.IntPtr.Zero ? (ImageSprite) null : new ImageSprite(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BlessingSelect.NativeFieldInfoPtr_dingerImage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizeStringEvent titleString
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlessingSelect.NativeFieldInfoPtr_titleString));
      return pointer == System.IntPtr.Zero ? (LocalizeStringEvent) null : new LocalizeStringEvent(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BlessingSelect.NativeFieldInfoPtr_titleString), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizeStringEvent descString
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlessingSelect.NativeFieldInfoPtr_descString));
      return pointer == System.IntPtr.Zero ? (LocalizeStringEvent) null : new LocalizeStringEvent(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BlessingSelect.NativeFieldInfoPtr_descString), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [ObfuscatedName("BlessingSelect/<>c__DisplayClass5_0")]
  public sealed class __c__DisplayClass5_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_gainBlessingSequence;
    private static readonly System.IntPtr NativeFieldInfoPtr_blessingData;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__SetUp_b__0_Internal_Void_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass5_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlessingSelect.__c__DisplayClass5_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BlessingSelect.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86746, XrefRangeEnd = 86748, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _SetUp_b__0()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BlessingSelect.__c__DisplayClass5_0.NativeMethodInfoPtr__SetUp_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static __c__DisplayClass5_0()
    {
      Il2CppClassPointerStore<BlessingSelect.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BlessingSelect>.NativeClassPtr, "<>c__DisplayClass5_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlessingSelect.__c__DisplayClass5_0>.NativeClassPtr);
      BlessingSelect.__c__DisplayClass5_0.NativeFieldInfoPtr_gainBlessingSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlessingSelect.__c__DisplayClass5_0>.NativeClassPtr, nameof (gainBlessingSequence));
      BlessingSelect.__c__DisplayClass5_0.NativeFieldInfoPtr_blessingData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlessingSelect.__c__DisplayClass5_0>.NativeClassPtr, nameof (blessingData));
      BlessingSelect.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlessingSelect.__c__DisplayClass5_0>.NativeClassPtr, 100670615);
      BlessingSelect.__c__DisplayClass5_0.NativeMethodInfoPtr__SetUp_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlessingSelect.__c__DisplayClass5_0>.NativeClassPtr, 100670616);
    }

    public __c__DisplayClass5_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe GainBlessingSequence gainBlessingSequence
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlessingSelect.__c__DisplayClass5_0.NativeFieldInfoPtr_gainBlessingSequence));
        return pointer == System.IntPtr.Zero ? (GainBlessingSequence) null : new GainBlessingSequence(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BlessingSelect.__c__DisplayClass5_0.NativeFieldInfoPtr_gainBlessingSequence), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe BlessingData blessingData
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlessingSelect.__c__DisplayClass5_0.NativeFieldInfoPtr_blessingData));
        return pointer == System.IntPtr.Zero ? (BlessingData) null : new BlessingData(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BlessingSelect.__c__DisplayClass5_0.NativeFieldInfoPtr_blessingData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
