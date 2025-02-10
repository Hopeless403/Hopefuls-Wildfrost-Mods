// Decompiled with JetBrains decompiler
// Type: BuildingIconSetterDaily
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
public class BuildingIconSetterDaily : BuildingIconSetter
{
  private static readonly IntPtr NativeFieldInfoPtr_gameModeName;
  private static readonly IntPtr NativeFieldInfoPtr__gameMode;
  private static readonly IntPtr NativeMethodInfoPtr_get_gameMode_Private_get_GameMode_0;
  private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Virtual_String_Building_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  public unsafe GameMode gameMode
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85190, XrefRangeEnd = 85199, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(BuildingIconSetterDaily.NativeMethodInfoPtr_get_gameMode_Private_get_GameMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (GameMode) null : new GameMode(pointer);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85199, XrefRangeEnd = 85214, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe string Get(Building building)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) building)
    };
    IntPtr exc;
    IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BuildingIconSetterDaily.NativeMethodInfoPtr_Get_Public_Virtual_String_Building_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return IL2CPP.Il2CppStringToManaged(il2CppString);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85214, XrefRangeEnd = 85219, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe BuildingIconSetterDaily()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildingIconSetterDaily>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BuildingIconSetterDaily.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static BuildingIconSetterDaily()
  {
    Il2CppClassPointerStore<BuildingIconSetterDaily>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (BuildingIconSetterDaily));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildingIconSetterDaily>.NativeClassPtr);
    BuildingIconSetterDaily.NativeFieldInfoPtr_gameModeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingIconSetterDaily>.NativeClassPtr, nameof (gameModeName));
    BuildingIconSetterDaily.NativeFieldInfoPtr__gameMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildingIconSetterDaily>.NativeClassPtr, nameof (_gameMode));
    BuildingIconSetterDaily.NativeMethodInfoPtr_get_gameMode_Private_get_GameMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildingIconSetterDaily>.NativeClassPtr, 100670415);
    BuildingIconSetterDaily.NativeMethodInfoPtr_Get_Public_Virtual_String_Building_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildingIconSetterDaily>.NativeClassPtr, 100670416);
    BuildingIconSetterDaily.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildingIconSetterDaily>.NativeClassPtr, 100670417);
  }

  public BuildingIconSetterDaily(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe string gameModeName
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildingIconSetterDaily.NativeFieldInfoPtr_gameModeName)));
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuildingIconSetterDaily.NativeFieldInfoPtr_gameModeName), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe GameMode _gameMode
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuildingIconSetterDaily.NativeFieldInfoPtr__gameMode));
      return pointer == IntPtr.Zero ? (GameMode) null : new GameMode(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuildingIconSetterDaily.NativeFieldInfoPtr__gameMode), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
