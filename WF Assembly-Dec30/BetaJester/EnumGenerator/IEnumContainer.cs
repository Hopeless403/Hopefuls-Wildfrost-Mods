// Decompiled with JetBrains decompiler
// Type: BetaJester.EnumGenerator.IEnumContainer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System;

#nullable disable
namespace BetaJester.EnumGenerator
{
  public class IEnumContainer : Il2CppObjectBase
  {
    private static readonly IntPtr NativeMethodInfoPtr_GetEnums_Public_Abstract_Virtual_New_Il2CppReferenceArray_1_EnumInfo_0;

    [CallerCount(0)]
    public virtual unsafe Il2CppReferenceArray<EnumInfo> GetEnums()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IEnumContainer.NativeMethodInfoPtr_GetEnums_Public_Abstract_Virtual_New_Il2CppReferenceArray_1_EnumInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr nativeObject = num;
      return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<EnumInfo>) null : new Il2CppReferenceArray<EnumInfo>(nativeObject);
    }

    static IEnumContainer()
    {
      Il2CppClassPointerStore<IEnumContainer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "BetaJester.EnumGenerator", nameof (IEnumContainer));
      IEnumContainer.NativeMethodInfoPtr_GetEnums_Public_Abstract_Virtual_New_Il2CppReferenceArray_1_EnumInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEnumContainer>.NativeClassPtr, 100678465);
    }

    public IEnumContainer(IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
