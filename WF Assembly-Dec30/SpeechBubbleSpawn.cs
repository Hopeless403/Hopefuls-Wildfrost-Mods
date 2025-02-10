// Decompiled with JetBrains decompiler
// Type: SpeechBubbleSpawn
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;

#nullable disable
public class SpeechBubbleSpawn : MonoBehaviourRect
{
  private static readonly IntPtr NativeFieldInfoPtr_spacing;
  private static readonly IntPtr NativeFieldInfoPtr_bubbles;
  private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Create_Public_SpeechBub_SpeechBub_SpeechBubbleData_0;
  private static readonly IntPtr NativeMethodInfoPtr_UpdateSize_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_UpdatePositions_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54039, XrefRangeEnd = 54046, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SpeechBubbleSpawn.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54046, XrefRangeEnd = 54053, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SpeechBubbleSpawn.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54053, XrefRangeEnd = 54067, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SpeechBubbleSpawn.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54067, XrefRangeEnd = 54104, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SpeechBub Create(SpeechBub prefab, SpeechBubbleData data)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) prefab);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data);
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpeechBubbleSpawn.NativeMethodInfoPtr_Create_Public_SpeechBub_SpeechBub_SpeechBubbleData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    IntPtr pointer = num;
    return pointer == IntPtr.Zero ? (SpeechBub) null : new SpeechBub(pointer);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 54121, RefRangeEnd = 54123, XrefRangeStart = 54104, XrefRangeEnd = 54121, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UpdateSize()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SpeechBubbleSpawn.NativeMethodInfoPtr_UpdateSize_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 54142, RefRangeEnd = 54144, XrefRangeStart = 54123, XrefRangeEnd = 54142, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UpdatePositions()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SpeechBubbleSpawn.NativeMethodInfoPtr_UpdatePositions_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54144, XrefRangeEnd = 54153, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SpeechBubbleSpawn()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpeechBubbleSpawn>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SpeechBubbleSpawn.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static SpeechBubbleSpawn()
  {
    Il2CppClassPointerStore<SpeechBubbleSpawn>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (SpeechBubbleSpawn));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpeechBubbleSpawn>.NativeClassPtr);
    SpeechBubbleSpawn.NativeFieldInfoPtr_spacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpeechBubbleSpawn>.NativeClassPtr, nameof (spacing));
    SpeechBubbleSpawn.NativeFieldInfoPtr_bubbles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpeechBubbleSpawn>.NativeClassPtr, nameof (bubbles));
    SpeechBubbleSpawn.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeechBubbleSpawn>.NativeClassPtr, 100667730);
    SpeechBubbleSpawn.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeechBubbleSpawn>.NativeClassPtr, 100667731);
    SpeechBubbleSpawn.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeechBubbleSpawn>.NativeClassPtr, 100667732);
    SpeechBubbleSpawn.NativeMethodInfoPtr_Create_Public_SpeechBub_SpeechBub_SpeechBubbleData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeechBubbleSpawn>.NativeClassPtr, 100667733);
    SpeechBubbleSpawn.NativeMethodInfoPtr_UpdateSize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeechBubbleSpawn>.NativeClassPtr, 100667734);
    SpeechBubbleSpawn.NativeMethodInfoPtr_UpdatePositions_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeechBubbleSpawn>.NativeClassPtr, 100667735);
    SpeechBubbleSpawn.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeechBubbleSpawn>.NativeClassPtr, 100667736);
  }

  public SpeechBubbleSpawn(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe float spacing
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpeechBubbleSpawn.NativeFieldInfoPtr_spacing));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpeechBubbleSpawn.NativeFieldInfoPtr_spacing)) = value;
    }
  }

  public unsafe List<SpeechBub> bubbles
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpeechBubbleSpawn.NativeFieldInfoPtr_bubbles));
      return pointer == IntPtr.Zero ? (List<SpeechBub>) null : new List<SpeechBub>(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpeechBubbleSpawn.NativeFieldInfoPtr_bubbles), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
