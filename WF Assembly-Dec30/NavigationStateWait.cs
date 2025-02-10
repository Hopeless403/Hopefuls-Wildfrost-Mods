// Decompiled with JetBrains decompiler
// Type: NavigationStateWait
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
public class NavigationStateWait : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr_disableInput;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Begin_Public_Virtual_Final_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_End_Public_Virtual_Final_New_Void_0;

  [CallerCount(7)]
  [CachedScanResults(RefRangeStart = 16236, RefRangeEnd = 16243, XrefRangeStart = 16235, XrefRangeEnd = 16236, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe NavigationStateWait(bool disableInput = false)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NavigationStateWait>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &disableInput
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(NavigationStateWait.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16243, XrefRangeEnd = 16248, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Begin()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(NavigationStateWait.NativeMethodInfoPtr_Begin_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16248, XrefRangeEnd = 16253, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void End()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(NavigationStateWait.NativeMethodInfoPtr_End_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static NavigationStateWait()
  {
    Il2CppClassPointerStore<NavigationStateWait>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (NavigationStateWait));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NavigationStateWait>.NativeClassPtr);
    NavigationStateWait.NativeFieldInfoPtr_disableInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationStateWait>.NativeClassPtr, nameof (disableInput));
    NavigationStateWait.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationStateWait>.NativeClassPtr, 100663397);
    NavigationStateWait.NativeMethodInfoPtr_Begin_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationStateWait>.NativeClassPtr, 100663398);
    NavigationStateWait.NativeMethodInfoPtr_End_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationStateWait>.NativeClassPtr, 100663399);
  }

  public NavigationStateWait(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe bool disableInput
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NavigationStateWait.NativeFieldInfoPtr_disableInput));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NavigationStateWait.NativeFieldInfoPtr_disableInput)) = value;
    }
  }
}
