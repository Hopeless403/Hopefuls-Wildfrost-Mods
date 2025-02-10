// Decompiled with JetBrains decompiler
// Type: ActionShove
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;

#nullable disable
public class ActionShove : PlayAction
{
  private static readonly IntPtr NativeFieldInfoPtr_shoveData;
  private static readonly IntPtr NativeFieldInfoPtr_updatePositions;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_Entity_List_1_CardSlot_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_IEnumerator_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26114, XrefRangeEnd = 26116, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ActionShove(Dictionary<Entity, List<CardSlot>> shoveData, bool updatePositions = false)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActionShove>.NativeClassPtr))
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) shoveData);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &updatePositions;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ActionShove.NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_Entity_List_1_CardSlot_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26116, XrefRangeEnd = 26120, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe IEnumerator Run()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ActionShove.NativeMethodInfoPtr_Run_Public_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    IntPtr pointer = num;
    return pointer == IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  static ActionShove()
  {
    Il2CppClassPointerStore<ActionShove>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (ActionShove));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActionShove>.NativeClassPtr);
    ActionShove.NativeFieldInfoPtr_shoveData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionShove>.NativeClassPtr, nameof (shoveData));
    ActionShove.NativeFieldInfoPtr_updatePositions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionShove>.NativeClassPtr, nameof (updatePositions));
    ActionShove.NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_Entity_List_1_CardSlot_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionShove>.NativeClassPtr, 100664581);
    ActionShove.NativeMethodInfoPtr_Run_Public_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionShove>.NativeClassPtr, 100664582);
  }

  public ActionShove(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Dictionary<Entity, List<CardSlot>> shoveData
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionShove.NativeFieldInfoPtr_shoveData));
      return pointer == IntPtr.Zero ? (Dictionary<Entity, List<CardSlot>>) null : new Dictionary<Entity, List<CardSlot>>(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ActionShove.NativeFieldInfoPtr_shoveData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool updatePositions
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionShove.NativeFieldInfoPtr_updatePositions));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActionShove.NativeFieldInfoPtr_updatePositions)) = value;
    }
  }
}
