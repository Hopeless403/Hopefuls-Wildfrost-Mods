// Decompiled with JetBrains decompiler
// Type: ObjectInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
[Serializable]
public class ObjectInfo : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr_objectName;
  private static readonly System.IntPtr NativeFieldInfoPtr_objectValue;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(1959)]
  [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ObjectInfo()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectInfo>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ObjectInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static ObjectInfo()
  {
    Il2CppClassPointerStore<ObjectInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (ObjectInfo));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectInfo>.NativeClassPtr);
    ObjectInfo.NativeFieldInfoPtr_objectName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectInfo>.NativeClassPtr, nameof (objectName));
    ObjectInfo.NativeFieldInfoPtr_objectValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectInfo>.NativeClassPtr, nameof (objectValue));
    ObjectInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectInfo>.NativeClassPtr, 100663334);
  }

  public ObjectInfo(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe string objectName
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ObjectInfo.NativeFieldInfoPtr_objectName)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ObjectInfo.NativeFieldInfoPtr_objectName), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe float objectValue
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ObjectInfo.NativeFieldInfoPtr_objectValue));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ObjectInfo.NativeFieldInfoPtr_objectValue)) = value;
    }
  }
}
