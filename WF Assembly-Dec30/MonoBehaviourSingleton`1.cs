// Decompiled with JetBrains decompiler
// Type: MonoBehaviourSingleton`1
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
public class MonoBehaviourSingleton<T> : MonoBehaviour where T : MonoBehaviour
{
  private static readonly System.IntPtr NativeFieldInfoPtr__instance_k__BackingField;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_instance_Public_Static_get_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_instance_Private_Static_set_Void_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  public static unsafe T instance
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53086, XrefRangeEnd = 53087, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(MonoBehaviourSingleton<T>.NativeMethodInfoPtr_get_instance_Public_Static_get_T_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.PointerToValueGeneric<T>(objectPointer, false, true);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53087, XrefRangeEnd = 53092, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
      System.IntPtr* numPtr2 = numPtr1;
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
      *numPtr2 = (System.IntPtr) ref local1;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MonoBehaviourSingleton<T>.NativeMethodInfoPtr_set_instance_Private_Static_set_Void_T_0, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 53108, RefRangeEnd = 53111, XrefRangeStart = 53092, XrefRangeEnd = 53108, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), MonoBehaviourSingleton<T>.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(212)]
  [CachedScanResults(RefRangeStart = 12749, RefRangeEnd = 12961, XrefRangeStart = 12749, XrefRangeEnd = 12961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe MonoBehaviourSingleton()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoBehaviourSingleton<T>>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(MonoBehaviourSingleton<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static MonoBehaviourSingleton()
  {
    // ISSUE: explicit non-virtual call
    // ISSUE: explicit non-virtual call
    Il2CppClassPointerStore<MonoBehaviourSingleton<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "MonoBehaviourSingleton`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))).TypeHandle).value);
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoBehaviourSingleton<T>>.NativeClassPtr);
    MonoBehaviourSingleton<T>.NativeFieldInfoPtr__instance_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoBehaviourSingleton<T>>.NativeClassPtr, "<instance>k__BackingField");
    MonoBehaviourSingleton<T>.NativeMethodInfoPtr_get_instance_Public_Static_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviourSingleton<T>>.NativeClassPtr, 100667571);
    MonoBehaviourSingleton<T>.NativeMethodInfoPtr_set_instance_Private_Static_set_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviourSingleton<T>>.NativeClassPtr, 100667572);
    MonoBehaviourSingleton<T>.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviourSingleton<T>>.NativeClassPtr, 100667573);
    MonoBehaviourSingleton<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBehaviourSingleton<T>>.NativeClassPtr, 100667574);
  }

  public MonoBehaviourSingleton(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe T _instance_k__BackingField
  {
    get
    {
      System.IntPtr objectPointer;
      IL2CPP.il2cpp_field_static_get_value(MonoBehaviourSingleton<T>.NativeFieldInfoPtr__instance_k__BackingField, (void*) &objectPointer);
      return IL2CPP.PointerToValueGeneric<T>(objectPointer, false, false);
    }
    [param: In] set
    {
      System.IntPtr instanceKBackingField = MonoBehaviourSingleton<T>.NativeFieldInfoPtr__instance_k__BackingField;
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
      IL2CPP.il2cpp_field_static_set_value(instanceKBackingField, (void*) ref local1);
    }
  }
}
