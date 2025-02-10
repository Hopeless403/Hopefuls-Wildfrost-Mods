// Decompiled with JetBrains decompiler
// Type: ES3Types.ES3UserType_SplatterDataArray
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ES3Types
{
  public class ES3UserType_SplatterDataArray : ES3ArrayType
  {
    private static readonly IntPtr NativeFieldInfoPtr_Instance;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141881, XrefRangeEnd = 141894, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ES3UserType_SplatterDataArray()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ES3UserType_SplatterDataArray>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ES3UserType_SplatterDataArray.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ES3UserType_SplatterDataArray()
    {
      Il2CppClassPointerStore<ES3UserType_SplatterDataArray>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ES3Types", nameof (ES3UserType_SplatterDataArray));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ES3UserType_SplatterDataArray>.NativeClassPtr);
      ES3UserType_SplatterDataArray.NativeFieldInfoPtr_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ES3UserType_SplatterDataArray>.NativeClassPtr, nameof (Instance));
      ES3UserType_SplatterDataArray.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3UserType_SplatterDataArray>.NativeClassPtr, 100678371);
    }

    public ES3UserType_SplatterDataArray(IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe ES3Type Instance
    {
      get
      {
        IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(ES3UserType_SplatterDataArray.NativeFieldInfoPtr_Instance, (void*) &num);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (ES3Type) null : new ES3Type(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ES3UserType_SplatterDataArray.NativeFieldInfoPtr_Instance, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
