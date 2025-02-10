// Decompiled with JetBrains decompiler
// Type: ScriptableGold
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
public class ScriptableGold : ScriptableAmount
{
  private static readonly IntPtr NativeFieldInfoPtr_factor;
  private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Virtual_Int32_Entity_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109872, XrefRangeEnd = 109880, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe int Get(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ScriptableGold.NativeMethodInfoPtr_Get_Public_Virtual_Int32_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(int*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(110)]
  [CachedScanResults(RefRangeStart = 104608, RefRangeEnd = 104718, XrefRangeStart = 104608, XrefRangeEnd = 104718, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ScriptableGold()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScriptableGold>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ScriptableGold.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static ScriptableGold()
  {
    Il2CppClassPointerStore<ScriptableGold>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (ScriptableGold));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptableGold>.NativeClassPtr);
    ScriptableGold.NativeFieldInfoPtr_factor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableGold>.NativeClassPtr, nameof (factor));
    ScriptableGold.NativeMethodInfoPtr_Get_Public_Virtual_Int32_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableGold>.NativeClassPtr, 100673448);
    ScriptableGold.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableGold>.NativeClassPtr, 100673449);
  }

  public ScriptableGold(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe float factor
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScriptableGold.NativeFieldInfoPtr_factor));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScriptableGold.NativeFieldInfoPtr_factor)) = value;
    }
  }
}
