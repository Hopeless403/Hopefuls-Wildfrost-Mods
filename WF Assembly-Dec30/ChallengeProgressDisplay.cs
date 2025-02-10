// Decompiled with JetBrains decompiler
// Type: ChallengeProgressDisplay
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
public class ChallengeProgressDisplay : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_text;
  private static readonly IntPtr NativeFieldInfoPtr_progressText;
  private static readonly IntPtr NativeFieldInfoPtr_icon;
  private static readonly IntPtr NativeFieldInfoPtr_back;
  private static readonly IntPtr NativeFieldInfoPtr_fill;
  private static readonly IntPtr NativeFieldInfoPtr_animator;
  private static readonly IntPtr NativeMethodInfoPtr_Assign_Public_Void_ChallengeData_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetRewardText_Public_Void_ChallengeData_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetFill_Public_Void_Single_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetRemainingText_Public_Void_ChallengeData_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetColor_Public_Void_Color_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 87648, RefRangeEnd = 87649, XrefRangeStart = 87642, XrefRangeEnd = 87648, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Assign(ChallengeData challengeData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) challengeData)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ChallengeProgressDisplay.NativeMethodInfoPtr_Assign_Public_Void_ChallengeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87649, XrefRangeEnd = 87651, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetRewardText(ChallengeData challengeData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) challengeData)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ChallengeProgressDisplay.NativeMethodInfoPtr_SetRewardText_Public_Void_ChallengeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 87661, RefRangeEnd = 87663, XrefRangeStart = 87651, XrefRangeEnd = 87661, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetFill(float current, int target)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &current;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &target;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ChallengeProgressDisplay.NativeMethodInfoPtr_SetFill_Public_Void_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87663, XrefRangeEnd = 87669, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetRemainingText(ChallengeData challengeData, float current)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) challengeData);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &current;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ChallengeProgressDisplay.NativeMethodInfoPtr_SetRemainingText_Public_Void_ChallengeData_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  public unsafe void SetColor(Color color)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &color
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ChallengeProgressDisplay.NativeMethodInfoPtr_SetColor_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(212)]
  [CachedScanResults(RefRangeStart = 12749, RefRangeEnd = 12961, XrefRangeStart = 12749, XrefRangeEnd = 12961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ChallengeProgressDisplay()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChallengeProgressDisplay>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ChallengeProgressDisplay.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static ChallengeProgressDisplay()
  {
    Il2CppClassPointerStore<ChallengeProgressDisplay>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (ChallengeProgressDisplay));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChallengeProgressDisplay>.NativeClassPtr);
    ChallengeProgressDisplay.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeProgressDisplay>.NativeClassPtr, nameof (text));
    ChallengeProgressDisplay.NativeFieldInfoPtr_progressText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeProgressDisplay>.NativeClassPtr, nameof (progressText));
    ChallengeProgressDisplay.NativeFieldInfoPtr_icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeProgressDisplay>.NativeClassPtr, nameof (icon));
    ChallengeProgressDisplay.NativeFieldInfoPtr_back = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeProgressDisplay>.NativeClassPtr, nameof (back));
    ChallengeProgressDisplay.NativeFieldInfoPtr_fill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeProgressDisplay>.NativeClassPtr, nameof (fill));
    ChallengeProgressDisplay.NativeFieldInfoPtr_animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChallengeProgressDisplay>.NativeClassPtr, nameof (animator));
    ChallengeProgressDisplay.NativeMethodInfoPtr_Assign_Public_Void_ChallengeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeProgressDisplay>.NativeClassPtr, 100670708);
    ChallengeProgressDisplay.NativeMethodInfoPtr_SetRewardText_Public_Void_ChallengeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeProgressDisplay>.NativeClassPtr, 100670709);
    ChallengeProgressDisplay.NativeMethodInfoPtr_SetFill_Public_Void_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeProgressDisplay>.NativeClassPtr, 100670710);
    ChallengeProgressDisplay.NativeMethodInfoPtr_SetRemainingText_Public_Void_ChallengeData_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeProgressDisplay>.NativeClassPtr, 100670711);
    ChallengeProgressDisplay.NativeMethodInfoPtr_SetColor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeProgressDisplay>.NativeClassPtr, 100670712);
    ChallengeProgressDisplay.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChallengeProgressDisplay>.NativeClassPtr, 100670713);
  }

  public ChallengeProgressDisplay(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe TMP_Text text
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChallengeProgressDisplay.NativeFieldInfoPtr_text));
      return pointer == IntPtr.Zero ? (TMP_Text) null : new TMP_Text(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChallengeProgressDisplay.NativeFieldInfoPtr_text), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TMP_Text progressText
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChallengeProgressDisplay.NativeFieldInfoPtr_progressText));
      return pointer == IntPtr.Zero ? (TMP_Text) null : new TMP_Text(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChallengeProgressDisplay.NativeFieldInfoPtr_progressText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ImageSprite icon
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChallengeProgressDisplay.NativeFieldInfoPtr_icon));
      return pointer == IntPtr.Zero ? (ImageSprite) null : new ImageSprite(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChallengeProgressDisplay.NativeFieldInfoPtr_icon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ImageSprite back
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChallengeProgressDisplay.NativeFieldInfoPtr_back));
      return pointer == IntPtr.Zero ? (ImageSprite) null : new ImageSprite(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChallengeProgressDisplay.NativeFieldInfoPtr_back), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Image fill
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChallengeProgressDisplay.NativeFieldInfoPtr_fill));
      return pointer == IntPtr.Zero ? (Image) null : new Image(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChallengeProgressDisplay.NativeFieldInfoPtr_fill), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UnityEngine.Animator animator
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChallengeProgressDisplay.NativeFieldInfoPtr_animator));
      return pointer == IntPtr.Zero ? (UnityEngine.Animator) null : new UnityEngine.Animator(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChallengeProgressDisplay.NativeFieldInfoPtr_animator), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
