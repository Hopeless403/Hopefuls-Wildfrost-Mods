// Decompiled with JetBrains decompiler
// Type: ES3Types.ES3UserType_SplatterData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Reflection;
using System.Runtime.InteropServices;

#nullable disable
namespace ES3Types
{
  public class ES3UserType_SplatterData : ES3ObjectType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Instance;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_WriteObject_Protected_Virtual_Void_Object_ES3Writer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ReadObject_Protected_Virtual_Void_ES3Reader_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ReadObject_Protected_Virtual_Object_ES3Reader_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141768, XrefRangeEnd = 141779, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ES3UserType_SplatterData()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ES3UserType_SplatterData>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ES3UserType_SplatterData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141779, XrefRangeEnd = 141798, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void WriteObject(Il2CppSystem.Object obj, ES3Writer writer)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) writer);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ES3UserType_SplatterData.NativeMethodInfoPtr_WriteObject_Protected_Virtual_Void_Object_ES3Writer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141798, XrefRangeEnd = 141876, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void ReadObject<T>(ES3Reader reader, Il2CppSystem.Object obj)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) reader);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ES3UserType_SplatterData.MethodInfoStoreGeneric_ReadObject_Protected_Virtual_Void_ES3Reader_Object_0<T>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141876, XrefRangeEnd = 141881, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe Il2CppSystem.Object ReadObject<T>(ES3Reader reader)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) reader)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ES3UserType_SplatterData.MethodInfoStoreGeneric_ReadObject_Protected_Virtual_Object_ES3Reader_0<T>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
    }

    static ES3UserType_SplatterData()
    {
      Il2CppClassPointerStore<ES3UserType_SplatterData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ES3Types", nameof (ES3UserType_SplatterData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ES3UserType_SplatterData>.NativeClassPtr);
      ES3UserType_SplatterData.NativeFieldInfoPtr_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ES3UserType_SplatterData>.NativeClassPtr, nameof (Instance));
      ES3UserType_SplatterData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3UserType_SplatterData>.NativeClassPtr, 100678367);
      ES3UserType_SplatterData.NativeMethodInfoPtr_WriteObject_Protected_Virtual_Void_Object_ES3Writer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3UserType_SplatterData>.NativeClassPtr, 100678368);
      ES3UserType_SplatterData.NativeMethodInfoPtr_ReadObject_Protected_Virtual_Void_ES3Reader_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3UserType_SplatterData>.NativeClassPtr, 100678369);
      ES3UserType_SplatterData.NativeMethodInfoPtr_ReadObject_Protected_Virtual_Object_ES3Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3UserType_SplatterData>.NativeClassPtr, 100678370);
    }

    public ES3UserType_SplatterData(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe ES3Type Instance
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(ES3UserType_SplatterData.NativeFieldInfoPtr_Instance, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (ES3Type) null : new ES3Type(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ES3UserType_SplatterData.NativeFieldInfoPtr_Instance, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    private sealed class MethodInfoStoreGeneric_ReadObject_Protected_Virtual_Void_ES3Reader_Object_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ES3UserType_SplatterData.NativeMethodInfoPtr_ReadObject_Protected_Virtual_Void_ES3Reader_Object_0, Il2CppClassPointerStore<ES3UserType_SplatterData>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_ReadObject_Protected_Virtual_Object_ES3Reader_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ES3UserType_SplatterData.NativeMethodInfoPtr_ReadObject_Protected_Virtual_Object_ES3Reader_0, Il2CppClassPointerStore<ES3UserType_SplatterData>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }
  }
}
