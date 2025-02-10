// Decompiled with JetBrains decompiler
// Type: ScriptableCurrentStatus
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
public class ScriptableCurrentStatus : ScriptableAmount
{
  private static readonly IntPtr NativeFieldInfoPtr_statusType;
  private static readonly IntPtr NativeFieldInfoPtr_offset;
  private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Virtual_Int32_Entity_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109860, XrefRangeEnd = 109865, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe int Get(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ScriptableCurrentStatus.NativeMethodInfoPtr_Get_Public_Virtual_Int32_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(int*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109865, XrefRangeEnd = 109870, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ScriptableCurrentStatus()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScriptableCurrentStatus>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ScriptableCurrentStatus.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static ScriptableCurrentStatus()
  {
    Il2CppClassPointerStore<ScriptableCurrentStatus>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (ScriptableCurrentStatus));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptableCurrentStatus>.NativeClassPtr);
    ScriptableCurrentStatus.NativeFieldInfoPtr_statusType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCurrentStatus>.NativeClassPtr, nameof (statusType));
    ScriptableCurrentStatus.NativeFieldInfoPtr_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCurrentStatus>.NativeClassPtr, nameof (offset));
    ScriptableCurrentStatus.NativeMethodInfoPtr_Get_Public_Virtual_Int32_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableCurrentStatus>.NativeClassPtr, 100673444);
    ScriptableCurrentStatus.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableCurrentStatus>.NativeClassPtr, 100673445);
  }

  public ScriptableCurrentStatus(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe string statusType
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScriptableCurrentStatus.NativeFieldInfoPtr_statusType)));
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScriptableCurrentStatus.NativeFieldInfoPtr_statusType), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe int offset
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScriptableCurrentStatus.NativeFieldInfoPtr_offset));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScriptableCurrentStatus.NativeFieldInfoPtr_offset)) = value;
    }
  }
}
