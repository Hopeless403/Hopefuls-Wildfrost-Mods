// Decompiled with JetBrains decompiler
// Type: SpeechBubbleData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class SpeechBubbleData : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr_target;
  private static readonly System.IntPtr NativeFieldInfoPtr_targetName;
  private static readonly System.IntPtr NativeFieldInfoPtr_text;
  private static readonly System.IntPtr NativeFieldInfoPtr_delay;
  private static readonly System.IntPtr NativeFieldInfoPtr__duration_k__BackingField;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_duration_Public_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_duration_Private_set_Void_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Transform_String_String_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetDuration_Public_Void_Single_0;

  public unsafe float duration
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpeechBubbleData.NativeMethodInfoPtr_get_duration_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }
    [CallerCount(5), CachedScanResults(RefRangeStart = 74893, RefRangeEnd = 74898, XrefRangeStart = 74893, XrefRangeEnd = 74893, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SpeechBubbleData.NativeMethodInfoPtr_set_duration_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 74902, RefRangeEnd = 74903, XrefRangeStart = 74898, XrefRangeEnd = 74902, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SpeechBubbleData(Transform target, string targetName, string text, float delay = 0.0f)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpeechBubbleData>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(targetName);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(text);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &delay;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SpeechBubbleData.NativeMethodInfoPtr__ctor_Public_Void_Transform_String_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 74893, RefRangeEnd = 74898, XrefRangeStart = 74893, XrefRangeEnd = 74898, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetDuration(float duration)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &duration
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SpeechBubbleData.NativeMethodInfoPtr_SetDuration_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static SpeechBubbleData()
  {
    Il2CppClassPointerStore<SpeechBubbleData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (SpeechBubbleData));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpeechBubbleData>.NativeClassPtr);
    SpeechBubbleData.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpeechBubbleData>.NativeClassPtr, nameof (target));
    SpeechBubbleData.NativeFieldInfoPtr_targetName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpeechBubbleData>.NativeClassPtr, nameof (targetName));
    SpeechBubbleData.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpeechBubbleData>.NativeClassPtr, nameof (text));
    SpeechBubbleData.NativeFieldInfoPtr_delay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpeechBubbleData>.NativeClassPtr, nameof (delay));
    SpeechBubbleData.NativeFieldInfoPtr__duration_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpeechBubbleData>.NativeClassPtr, "<duration>k__BackingField");
    SpeechBubbleData.NativeMethodInfoPtr_get_duration_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeechBubbleData>.NativeClassPtr, 100669341);
    SpeechBubbleData.NativeMethodInfoPtr_set_duration_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeechBubbleData>.NativeClassPtr, 100669342);
    SpeechBubbleData.NativeMethodInfoPtr__ctor_Public_Void_Transform_String_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeechBubbleData>.NativeClassPtr, 100669343);
    SpeechBubbleData.NativeMethodInfoPtr_SetDuration_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeechBubbleData>.NativeClassPtr, 100669344);
  }

  public SpeechBubbleData(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Transform target
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpeechBubbleData.NativeFieldInfoPtr_target));
      return pointer == System.IntPtr.Zero ? (Transform) null : new Transform(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpeechBubbleData.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe string targetName
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpeechBubbleData.NativeFieldInfoPtr_targetName)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpeechBubbleData.NativeFieldInfoPtr_targetName), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string text
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpeechBubbleData.NativeFieldInfoPtr_text)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpeechBubbleData.NativeFieldInfoPtr_text), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe float delay
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpeechBubbleData.NativeFieldInfoPtr_delay));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpeechBubbleData.NativeFieldInfoPtr_delay)) = value;
    }
  }

  public unsafe float _duration_k__BackingField
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpeechBubbleData.NativeFieldInfoPtr__duration_k__BackingField));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpeechBubbleData.NativeFieldInfoPtr__duration_k__BackingField)) = value;
    }
  }
}
