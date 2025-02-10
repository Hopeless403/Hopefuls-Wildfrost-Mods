// Decompiled with JetBrains decompiler
// Type: ClassSaveData
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
public class ClassSaveData : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr_name;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Final_New_ClassData_0;

  [CallerCount(1959)]
  [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ClassSaveData()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClassSaveData>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ClassSaveData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(127)]
  [CachedScanResults(RefRangeStart = 30519, RefRangeEnd = 30646, XrefRangeStart = 30519, XrefRangeEnd = 30646, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ClassSaveData(string name)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClassSaveData>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(name)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ClassSaveData.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103887, XrefRangeEnd = 103895, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe ClassData Load()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ClassSaveData.NativeMethodInfoPtr_Load_Public_Virtual_Final_New_ClassData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (ClassData) null : new ClassData(pointer);
  }

  static ClassSaveData()
  {
    Il2CppClassPointerStore<ClassSaveData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (ClassSaveData));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClassSaveData>.NativeClassPtr);
    ClassSaveData.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClassSaveData>.NativeClassPtr, nameof (name));
    ClassSaveData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClassSaveData>.NativeClassPtr, 100672669);
    ClassSaveData.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClassSaveData>.NativeClassPtr, 100672670);
    ClassSaveData.NativeMethodInfoPtr_Load_Public_Virtual_Final_New_ClassData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClassSaveData>.NativeClassPtr, 100672671);
  }

  public ClassSaveData(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe string name
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClassSaveData.NativeFieldInfoPtr_name)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClassSaveData.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }
}
