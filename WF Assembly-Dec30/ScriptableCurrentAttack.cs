// Decompiled with JetBrains decompiler
// Type: ScriptableCurrentAttack
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;

#nullable disable
public class ScriptableCurrentAttack : ScriptableAmount
{
  private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Virtual_Int32_Entity_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109854, XrefRangeEnd = 109860, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe int Get(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ScriptableCurrentAttack.NativeMethodInfoPtr_Get_Public_Virtual_Int32_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(int*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(110)]
  [CachedScanResults(RefRangeStart = 104608, RefRangeEnd = 104718, XrefRangeStart = 104608, XrefRangeEnd = 104718, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ScriptableCurrentAttack()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScriptableCurrentAttack>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ScriptableCurrentAttack.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static ScriptableCurrentAttack()
  {
    Il2CppClassPointerStore<ScriptableCurrentAttack>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (ScriptableCurrentAttack));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptableCurrentAttack>.NativeClassPtr);
    ScriptableCurrentAttack.NativeMethodInfoPtr_Get_Public_Virtual_Int32_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableCurrentAttack>.NativeClassPtr, 100673442);
    ScriptableCurrentAttack.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableCurrentAttack>.NativeClassPtr, 100673443);
  }

  public ScriptableCurrentAttack(IntPtr pointer)
    : base(pointer)
  {
  }
}
