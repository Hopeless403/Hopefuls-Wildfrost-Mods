// Decompiled with JetBrains decompiler
// Type: CollectionModifier
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class CollectionModifier : ScriptableObject
{
  private static readonly System.IntPtr NativeFieldInfoPtr_list;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(110)]
  [CachedScanResults(RefRangeStart = 104608, RefRangeEnd = 104718, XrefRangeStart = 104608, XrefRangeEnd = 104718, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CollectionModifier()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CollectionModifier>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CollectionModifier.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static CollectionModifier()
  {
    Il2CppClassPointerStore<CollectionModifier>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (CollectionModifier));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CollectionModifier>.NativeClassPtr);
    CollectionModifier.NativeFieldInfoPtr_list = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollectionModifier>.NativeClassPtr, nameof (list));
    CollectionModifier.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionModifier>.NativeClassPtr, 100673353);
  }

  public CollectionModifier(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Il2CppStructArray<CollectionModifier.Modify> list
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CollectionModifier.NativeFieldInfoPtr_list));
      return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<CollectionModifier.Modify>) null : new Il2CppStructArray<CollectionModifier.Modify>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CollectionModifier.NativeFieldInfoPtr_list), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [Serializable]
  [StructLayout(LayoutKind.Explicit)]
  public struct Modify
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_index;
    private static readonly System.IntPtr NativeFieldInfoPtr_addWeight;
    [FieldOffset(0)]
    public int index;
    [FieldOffset(4)]
    public float addWeight;

    static Modify()
    {
      Il2CppClassPointerStore<CollectionModifier.Modify>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CollectionModifier>.NativeClassPtr, nameof (Modify));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CollectionModifier.Modify>.NativeClassPtr);
      CollectionModifier.Modify.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollectionModifier.Modify>.NativeClassPtr, nameof (index));
      CollectionModifier.Modify.NativeFieldInfoPtr_addWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollectionModifier.Modify>.NativeClassPtr, nameof (addWeight));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CollectionModifier.Modify>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
