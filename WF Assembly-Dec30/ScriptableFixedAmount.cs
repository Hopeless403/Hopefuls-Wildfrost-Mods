// Decompiled with JetBrains decompiler
// Type: ScriptableFixedAmount
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
public class ScriptableFixedAmount : ScriptableAmount
{
  private static readonly IntPtr NativeFieldInfoPtr_amount;
  private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Virtual_Int32_Entity_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 109870, RefRangeEnd = 109871, XrefRangeStart = 109870, XrefRangeEnd = 109870, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe int Get(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ScriptableFixedAmount.NativeMethodInfoPtr_Get_Public_Virtual_Int32_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(int*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109871, XrefRangeEnd = 109872, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ScriptableFixedAmount()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScriptableFixedAmount>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ScriptableFixedAmount.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static ScriptableFixedAmount()
  {
    Il2CppClassPointerStore<ScriptableFixedAmount>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (ScriptableFixedAmount));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptableFixedAmount>.NativeClassPtr);
    ScriptableFixedAmount.NativeFieldInfoPtr_amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableFixedAmount>.NativeClassPtr, nameof (amount));
    ScriptableFixedAmount.NativeMethodInfoPtr_Get_Public_Virtual_Int32_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableFixedAmount>.NativeClassPtr, 100673446);
    ScriptableFixedAmount.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableFixedAmount>.NativeClassPtr, 100673447);
  }

  public ScriptableFixedAmount(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe int amount
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScriptableFixedAmount.NativeFieldInfoPtr_amount));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScriptableFixedAmount.NativeFieldInfoPtr_amount)) = value;
    }
  }
}
