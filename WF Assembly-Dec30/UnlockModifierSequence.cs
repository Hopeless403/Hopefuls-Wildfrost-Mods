// Decompiled with JetBrains decompiler
// Type: UnlockModifierSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class UnlockModifierSequence : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_icon;
  private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Void_GameModifierData_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100198, XrefRangeEnd = 100203, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Run(GameModifierData modifierData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) modifierData)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(UnlockModifierSequence.NativeMethodInfoPtr_Run_Public_Void_GameModifierData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(212)]
  [CachedScanResults(RefRangeStart = 12749, RefRangeEnd = 12961, XrefRangeStart = 12749, XrefRangeEnd = 12961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UnlockModifierSequence()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnlockModifierSequence>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(UnlockModifierSequence.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static UnlockModifierSequence()
  {
    Il2CppClassPointerStore<UnlockModifierSequence>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (UnlockModifierSequence));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnlockModifierSequence>.NativeClassPtr);
    UnlockModifierSequence.NativeFieldInfoPtr_icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnlockModifierSequence>.NativeClassPtr, nameof (icon));
    UnlockModifierSequence.NativeMethodInfoPtr_Run_Public_Void_GameModifierData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnlockModifierSequence>.NativeClassPtr, 100672284);
    UnlockModifierSequence.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnlockModifierSequence>.NativeClassPtr, 100672285);
  }

  public UnlockModifierSequence(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe ModifierIcon icon
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnlockModifierSequence.NativeFieldInfoPtr_icon));
      return pointer == IntPtr.Zero ? (ModifierIcon) null : new ModifierIcon(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnlockModifierSequence.NativeFieldInfoPtr_icon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
