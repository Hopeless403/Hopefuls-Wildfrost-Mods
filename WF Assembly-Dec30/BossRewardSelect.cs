// Decompiled with JetBrains decompiler
// Type: BossRewardSelect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class BossRewardSelect : MonoBehaviourRect
{
  private static readonly System.IntPtr NativeFieldInfoPtr_inputAction;
  private static readonly System.IntPtr NativeFieldInfoPtr_popUpKeyword;
  private static readonly System.IntPtr NativeFieldInfoPtr_title;
  private static readonly System.IntPtr NativeFieldInfoPtr_body;
  private static readonly System.IntPtr NativeFieldInfoPtr_popUpName;
  private static readonly System.IntPtr NativeFieldInfoPtr_poppedUp;
  private static readonly System.IntPtr NativeFieldInfoPtr_popUpOffset;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetUp_Public_Virtual_New_Void_Data_GainBlessingSequence2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Pop_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UnPop_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Destroy_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 86852, RefRangeEnd = 86855, XrefRangeStart = 86832, XrefRangeEnd = 86852, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void SetUp(
    BossRewardData.Data rewardData,
    GainBlessingSequence2 gainBlessingSequence)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) rewardData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gainBlessingSequence);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BossRewardSelect.NativeMethodInfoPtr_SetUp_Public_Virtual_New_Void_Data_GainBlessingSequence2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86855, XrefRangeEnd = 86866, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Pop()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BossRewardSelect.NativeMethodInfoPtr_Pop_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86866, XrefRangeEnd = 86873, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UnPop()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BossRewardSelect.NativeMethodInfoPtr_UnPop_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86873, XrefRangeEnd = 86886, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Destroy()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BossRewardSelect.NativeMethodInfoPtr_Destroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 21168, RefRangeEnd = 21171, XrefRangeStart = 21168, XrefRangeEnd = 21171, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe BossRewardSelect()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BossRewardSelect>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BossRewardSelect.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static BossRewardSelect()
  {
    Il2CppClassPointerStore<BossRewardSelect>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (BossRewardSelect));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BossRewardSelect>.NativeClassPtr);
    BossRewardSelect.NativeFieldInfoPtr_inputAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BossRewardSelect>.NativeClassPtr, nameof (inputAction));
    BossRewardSelect.NativeFieldInfoPtr_popUpKeyword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BossRewardSelect>.NativeClassPtr, nameof (popUpKeyword));
    BossRewardSelect.NativeFieldInfoPtr_title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BossRewardSelect>.NativeClassPtr, nameof (title));
    BossRewardSelect.NativeFieldInfoPtr_body = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BossRewardSelect>.NativeClassPtr, nameof (body));
    BossRewardSelect.NativeFieldInfoPtr_popUpName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BossRewardSelect>.NativeClassPtr, nameof (popUpName));
    BossRewardSelect.NativeFieldInfoPtr_poppedUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BossRewardSelect>.NativeClassPtr, nameof (poppedUp));
    BossRewardSelect.NativeFieldInfoPtr_popUpOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BossRewardSelect>.NativeClassPtr, nameof (popUpOffset));
    BossRewardSelect.NativeMethodInfoPtr_SetUp_Public_Virtual_New_Void_Data_GainBlessingSequence2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BossRewardSelect>.NativeClassPtr, 100670617);
    BossRewardSelect.NativeMethodInfoPtr_Pop_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BossRewardSelect>.NativeClassPtr, 100670618);
    BossRewardSelect.NativeMethodInfoPtr_UnPop_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BossRewardSelect>.NativeClassPtr, 100670619);
    BossRewardSelect.NativeMethodInfoPtr_Destroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BossRewardSelect>.NativeClassPtr, 100670620);
    BossRewardSelect.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BossRewardSelect>.NativeClassPtr, 100670621);
  }

  public BossRewardSelect(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe InputAction inputAction
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BossRewardSelect.NativeFieldInfoPtr_inputAction));
      return pointer == System.IntPtr.Zero ? (InputAction) null : new InputAction(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BossRewardSelect.NativeFieldInfoPtr_inputAction), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe KeywordData popUpKeyword
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BossRewardSelect.NativeFieldInfoPtr_popUpKeyword));
      return pointer == System.IntPtr.Zero ? (KeywordData) null : new KeywordData(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BossRewardSelect.NativeFieldInfoPtr_popUpKeyword), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe string title
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BossRewardSelect.NativeFieldInfoPtr_title)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BossRewardSelect.NativeFieldInfoPtr_title), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string body
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BossRewardSelect.NativeFieldInfoPtr_body)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BossRewardSelect.NativeFieldInfoPtr_body), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string popUpName
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BossRewardSelect.NativeFieldInfoPtr_popUpName)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BossRewardSelect.NativeFieldInfoPtr_popUpName), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe bool poppedUp
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BossRewardSelect.NativeFieldInfoPtr_poppedUp));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BossRewardSelect.NativeFieldInfoPtr_poppedUp)) = value;
    }
  }

  public static unsafe Vector2 popUpOffset
  {
    get
    {
      Vector2 popUpOffset;
      IL2CPP.il2cpp_field_static_get_value(BossRewardSelect.NativeFieldInfoPtr_popUpOffset, (void*) &popUpOffset);
      return popUpOffset;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(BossRewardSelect.NativeFieldInfoPtr_popUpOffset, (void*) &value);
    }
  }

  [ObfuscatedName("BossRewardSelect/<>c__DisplayClass7_0")]
  public sealed class __c__DisplayClass7_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_gainBlessingSequence;
    private static readonly System.IntPtr NativeFieldInfoPtr_rewardData;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__SetUp_b__0_Internal_Void_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass7_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BossRewardSelect.__c__DisplayClass7_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BossRewardSelect.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86766, XrefRangeEnd = 86832, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _SetUp_b__0()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BossRewardSelect.__c__DisplayClass7_0.NativeMethodInfoPtr__SetUp_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static __c__DisplayClass7_0()
    {
      Il2CppClassPointerStore<BossRewardSelect.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BossRewardSelect>.NativeClassPtr, "<>c__DisplayClass7_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BossRewardSelect.__c__DisplayClass7_0>.NativeClassPtr);
      BossRewardSelect.__c__DisplayClass7_0.NativeFieldInfoPtr_gainBlessingSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BossRewardSelect.__c__DisplayClass7_0>.NativeClassPtr, nameof (gainBlessingSequence));
      BossRewardSelect.__c__DisplayClass7_0.NativeFieldInfoPtr_rewardData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BossRewardSelect.__c__DisplayClass7_0>.NativeClassPtr, nameof (rewardData));
      BossRewardSelect.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BossRewardSelect.__c__DisplayClass7_0>.NativeClassPtr, 100670623);
      BossRewardSelect.__c__DisplayClass7_0.NativeMethodInfoPtr__SetUp_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BossRewardSelect.__c__DisplayClass7_0>.NativeClassPtr, 100670624);
    }

    public __c__DisplayClass7_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe GainBlessingSequence2 gainBlessingSequence
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BossRewardSelect.__c__DisplayClass7_0.NativeFieldInfoPtr_gainBlessingSequence));
        return pointer == System.IntPtr.Zero ? (GainBlessingSequence2) null : new GainBlessingSequence2(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BossRewardSelect.__c__DisplayClass7_0.NativeFieldInfoPtr_gainBlessingSequence), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe BossRewardData.Data rewardData
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BossRewardSelect.__c__DisplayClass7_0.NativeFieldInfoPtr_rewardData));
        return pointer == System.IntPtr.Zero ? (BossRewardData.Data) null : new BossRewardData.Data(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BossRewardSelect.__c__DisplayClass7_0.NativeFieldInfoPtr_rewardData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
