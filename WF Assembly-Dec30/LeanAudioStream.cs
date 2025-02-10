// Decompiled with JetBrains decompiler
// Type: LeanAudioStream
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
public class LeanAudioStream : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr_position;
  private static readonly System.IntPtr NativeFieldInfoPtr_audioClip;
  private static readonly System.IntPtr NativeFieldInfoPtr_audioArr;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnAudioRead_Public_Void_Il2CppStructArray_1_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnAudioSetPosition_Public_Void_Int32_0;

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 78819, RefRangeEnd = 78820, XrefRangeStart = 78819, XrefRangeEnd = 78820, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LeanAudioStream(Il2CppStructArray<float> audioArr)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LeanAudioStream>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) audioArr)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LeanAudioStream.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128448, XrefRangeEnd = 128449, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnAudioRead(Il2CppStructArray<float> data)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LeanAudioStream.NativeMethodInfoPtr_OnAudioRead_Public_Void_Il2CppStructArray_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 128449, RefRangeEnd = 128454, XrefRangeStart = 128449, XrefRangeEnd = 128449, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnAudioSetPosition(int newPosition)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &newPosition
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(LeanAudioStream.NativeMethodInfoPtr_OnAudioSetPosition_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static LeanAudioStream()
  {
    Il2CppClassPointerStore<LeanAudioStream>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (LeanAudioStream));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LeanAudioStream>.NativeClassPtr);
    LeanAudioStream.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanAudioStream>.NativeClassPtr, nameof (position));
    LeanAudioStream.NativeFieldInfoPtr_audioClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanAudioStream>.NativeClassPtr, nameof (audioClip));
    LeanAudioStream.NativeFieldInfoPtr_audioArr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeanAudioStream>.NativeClassPtr, nameof (audioArr));
    LeanAudioStream.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanAudioStream>.NativeClassPtr, 100676578);
    LeanAudioStream.NativeMethodInfoPtr_OnAudioRead_Public_Void_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanAudioStream>.NativeClassPtr, 100676579);
    LeanAudioStream.NativeMethodInfoPtr_OnAudioSetPosition_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeanAudioStream>.NativeClassPtr, 100676580);
  }

  public LeanAudioStream(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe int position
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeanAudioStream.NativeFieldInfoPtr_position));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeanAudioStream.NativeFieldInfoPtr_position)) = value;
    }
  }

  public unsafe AudioClip audioClip
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeanAudioStream.NativeFieldInfoPtr_audioClip));
      return pointer == System.IntPtr.Zero ? (AudioClip) null : new AudioClip(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LeanAudioStream.NativeFieldInfoPtr_audioClip), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppStructArray<float> audioArr
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LeanAudioStream.NativeFieldInfoPtr_audioArr));
      return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<float>) null : new Il2CppStructArray<float>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LeanAudioStream.NativeFieldInfoPtr_audioArr), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
