// Decompiled with JetBrains decompiler
// Type: LTEvent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
public class LTEvent : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr_id;
  private static readonly System.IntPtr NativeFieldInfoPtr_data;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Object_0;

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 132553, RefRangeEnd = 132554, XrefRangeStart = 132544, XrefRangeEnd = 132553, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LTEvent(int id, Il2CppSystem.Object data)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LTEvent>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &id;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LTEvent.NativeMethodInfoPtr__ctor_Public_Void_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static LTEvent()
  {
    Il2CppClassPointerStore<LTEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (LTEvent));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LTEvent>.NativeClassPtr);
    LTEvent.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTEvent>.NativeClassPtr, nameof (id));
    LTEvent.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LTEvent>.NativeClassPtr, nameof (data));
    LTEvent.NativeMethodInfoPtr__ctor_Public_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LTEvent>.NativeClassPtr, 100676927);
  }

  public LTEvent(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe int id
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTEvent.NativeFieldInfoPtr_id));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTEvent.NativeFieldInfoPtr_id)) = value;
    }
  }

  public unsafe Il2CppSystem.Object data
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LTEvent.NativeFieldInfoPtr_data));
      return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LTEvent.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
