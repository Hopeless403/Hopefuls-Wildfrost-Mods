// Decompiled with JetBrains decompiler
// Type: ObjectTrackerUIScript
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class ObjectTrackerUIScript : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_parentCanvas;
  private static readonly IntPtr NativeFieldInfoPtr_objToTrack;
  private static readonly IntPtr NativeFieldInfoPtr_localOffset;
  private static readonly IntPtr NativeFieldInfoPtr_targetPos;
  private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_New_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16253, XrefRangeEnd = 16265, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ObjectTrackerUIScript.NativeMethodInfoPtr_Update_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(212)]
  [CachedScanResults(RefRangeStart = 12749, RefRangeEnd = 12961, XrefRangeStart = 12749, XrefRangeEnd = 12961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ObjectTrackerUIScript()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectTrackerUIScript>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ObjectTrackerUIScript.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static ObjectTrackerUIScript()
  {
    Il2CppClassPointerStore<ObjectTrackerUIScript>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (ObjectTrackerUIScript));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectTrackerUIScript>.NativeClassPtr);
    ObjectTrackerUIScript.NativeFieldInfoPtr_parentCanvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectTrackerUIScript>.NativeClassPtr, nameof (parentCanvas));
    ObjectTrackerUIScript.NativeFieldInfoPtr_objToTrack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectTrackerUIScript>.NativeClassPtr, nameof (objToTrack));
    ObjectTrackerUIScript.NativeFieldInfoPtr_localOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectTrackerUIScript>.NativeClassPtr, nameof (localOffset));
    ObjectTrackerUIScript.NativeFieldInfoPtr_targetPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectTrackerUIScript>.NativeClassPtr, nameof (targetPos));
    ObjectTrackerUIScript.NativeMethodInfoPtr_Update_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectTrackerUIScript>.NativeClassPtr, 100663400);
    ObjectTrackerUIScript.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectTrackerUIScript>.NativeClassPtr, 100663401);
  }

  public ObjectTrackerUIScript(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe RectTransform parentCanvas
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ObjectTrackerUIScript.NativeFieldInfoPtr_parentCanvas));
      return pointer == IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ObjectTrackerUIScript.NativeFieldInfoPtr_parentCanvas), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject objToTrack
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ObjectTrackerUIScript.NativeFieldInfoPtr_objToTrack));
      return pointer == IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ObjectTrackerUIScript.NativeFieldInfoPtr_objToTrack), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector3 localOffset
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ObjectTrackerUIScript.NativeFieldInfoPtr_localOffset));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ObjectTrackerUIScript.NativeFieldInfoPtr_localOffset)) = value;
    }
  }

  public unsafe Vector3 targetPos
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ObjectTrackerUIScript.NativeFieldInfoPtr_targetPos));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ObjectTrackerUIScript.NativeFieldInfoPtr_targetPos)) = value;
    }
  }
}
