// Decompiled with JetBrains decompiler
// Type: IPointerAfterExitHandler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using UnityEngine.EventSystems;

#nullable disable
public class IPointerAfterExitHandler : Il2CppObjectBase
{
  private static readonly IntPtr NativeMethodInfoPtr_OnPointerAfterExit_Public_Abstract_Virtual_New_Void_PointerEventData_0;

  [CallerCount(0)]
  public virtual unsafe void OnPointerAfterExit(PointerEventData eventData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventData)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IPointerAfterExitHandler.NativeMethodInfoPtr_OnPointerAfterExit_Public_Abstract_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static IPointerAfterExitHandler()
  {
    Il2CppClassPointerStore<IPointerAfterExitHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (IPointerAfterExitHandler));
    IPointerAfterExitHandler.NativeMethodInfoPtr_OnPointerAfterExit_Public_Abstract_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPointerAfterExitHandler>.NativeClassPtr, 100672607);
  }

  public IPointerAfterExitHandler(IntPtr pointer)
    : base(pointer)
  {
  }
}
