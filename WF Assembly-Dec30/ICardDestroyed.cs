// Decompiled with JetBrains decompiler
// Type: ICardDestroyed
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;

#nullable disable
public class ICardDestroyed : Il2CppObjectBase
{
  private static readonly IntPtr NativeMethodInfoPtr_Final_Public_Abstract_Virtual_New_Void_0;

  [CallerCount(0)]
  public virtual unsafe void Final()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ICardDestroyed.NativeMethodInfoPtr_Final_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static ICardDestroyed()
  {
    Il2CppClassPointerStore<ICardDestroyed>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (ICardDestroyed));
    ICardDestroyed.NativeMethodInfoPtr_Final_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICardDestroyed>.NativeClassPtr, 100672606);
  }

  public ICardDestroyed(IntPtr pointer)
    : base(pointer)
  {
  }
}
