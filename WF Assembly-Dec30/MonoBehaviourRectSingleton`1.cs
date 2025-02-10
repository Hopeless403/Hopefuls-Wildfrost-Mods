// Decompiled with JetBrains decompiler
// Type: MonoBehaviourRectSingleton`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class MonoBehaviourRectSingleton<T> : MonoBehaviour where T : MonoBehaviour
{
  private static readonly System.IntPtr NativeFieldInfoPtr__instance;
  private static readonly System.IntPtr NativeFieldInfoPtr__rectTransform;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_instance_Public_Static_get_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_rectTransform_Public_get_RectTransform_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  public static unsafe T instance
  {
    [CallerCount(32), CachedScanResults(RefRangeStart = 53041, RefRangeEnd = 53073, XrefRangeStart = 53025, XrefRangeEnd = 53041, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(MonoBehaviourRectSingleton<T>.NativeMethodInfoPtr_get_instance_Public_Static_get_T_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.PointerToValueGeneric<T>(objectPointer, false, true);
    }
  }

  public unsafe RectTransform rectTransform
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 53083, RefRangeEnd = 53086, XrefRangeStart = 53073, XrefRangeEnd = 53083, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MonoBehaviourRectSingleton<T>.NativeMethodInfoPtr_get_rectTransform_Public_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
    }
  }

  [CallerCount(212)]
  [CachedScanResults(RefRangeStart = 12749, RefRangeEnd = 12961, XrefRangeStart = 12749, XrefRangeEnd = 12961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe MonoBehaviourRectSingleton()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoBehaviourRectSingleton<T>>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(MonoBehaviourRectSingleton<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static MonoBehaviourRectSingleton()
  {
    // ISSUE: explicit non-virtual call
    // ISSUE: explicit non-virtual call
    Il2CppClassPointerStore<MonoBehaviourRectSingleton<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "MonoBehaviourRectSingleton`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))).TypeHandle).value);
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoBehaviourRectSingleton<T>>.NativeClassPtr);
    MonoBehaviourRectSingleton<T>.NativeFieldInfoPtr__instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoBehaviourRectSingleton<T>>.NativeClassPtr, nameof (_instance));
    MonoBehaviourRectSingleton<T>.NativeFieldInfoPtr__rectTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoBehaviourRectSingleton<T>>.NativeClassPtr, nameof (_rectTransform));
    MonoBehaviourRectSingleton<T>.NativeMethodInfoPtr_get_instance_Public_Static_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviourRectSingleton<T>>.NativeClassPtr, 100667568);
    MonoBehaviourRectSingleton<T>.NativeMethodInfoPtr_get_rectTransform_Public_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviourRectSingleton<T>>.NativeClassPtr, 100667569);
    MonoBehaviourRectSingleton<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviourRectSingleton<T>>.NativeClassPtr, 100667570);
  }

  public MonoBehaviourRectSingleton(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe T _instance
  {
    get
    {
      System.IntPtr objectPointer;
      IL2CPP.il2cpp_field_static_get_value(MonoBehaviourRectSingleton<T>.NativeFieldInfoPtr__instance, (void*) &objectPointer);
      return IL2CPP.PointerToValueGeneric<T>(objectPointer, false, false);
    }
    [param: In] set
    {
      System.IntPtr fieldInfoPtrInstance = MonoBehaviourRectSingleton<T>.NativeFieldInfoPtr__instance;
      T& local1;
      if (!typeof (T).IsValueType)
      {
        __Boxed<T> local2 = (object) value;
        if (!(local2 is string))
        {
          System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
          local1 = ptr == System.IntPtr.Zero ? (T&) ptr : (!IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ptr)) ? (T&) ptr : (T&) IL2CPP.il2cpp_object_unbox(ptr));
        }
        else
          local1 = (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string);
      }
      else
        local1 = ref value;
      IL2CPP.il2cpp_field_static_set_value(fieldInfoPtrInstance, (void*) ref local1);
    }
  }

  public unsafe RectTransform _rectTransform
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MonoBehaviourRectSingleton<T>.NativeFieldInfoPtr__rectTransform));
      return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MonoBehaviourRectSingleton<T>.NativeFieldInfoPtr__rectTransform), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
