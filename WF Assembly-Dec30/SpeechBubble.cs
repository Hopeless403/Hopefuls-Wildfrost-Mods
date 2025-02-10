// Decompiled with JetBrains decompiler
// Type: SpeechBubble
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;

#nullable disable
public class SpeechBubble : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_textElement;
  private static readonly IntPtr NativeMethodInfoPtr_SetSize_Public_Void_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetTextColour_Public_Void_Color_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetTextSpriteAsset_Public_Void_TMP_SpriteAsset_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetText_Public_Void_String_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95238, XrefRangeEnd = 95240, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetSize(float size)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &size
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SpeechBubble.NativeMethodInfoPtr_SetSize_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  public unsafe void SetTextColour(Color color)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &color
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SpeechBubble.NativeMethodInfoPtr_SetTextColour_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95240, XrefRangeEnd = 95242, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetTextSpriteAsset(TMP_SpriteAsset spriteAsset)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) spriteAsset)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SpeechBubble.NativeMethodInfoPtr_SetTextSpriteAsset_Public_Void_TMP_SpriteAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 83187, RefRangeEnd = 83188, XrefRangeStart = 83187, XrefRangeEnd = 83188, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetText(string text)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(text)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SpeechBubble.NativeMethodInfoPtr_SetText_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(212)]
  [CachedScanResults(RefRangeStart = 12749, RefRangeEnd = 12961, XrefRangeStart = 12749, XrefRangeEnd = 12961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SpeechBubble()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpeechBubble>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SpeechBubble.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static SpeechBubble()
  {
    Il2CppClassPointerStore<SpeechBubble>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (SpeechBubble));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpeechBubble>.NativeClassPtr);
    SpeechBubble.NativeFieldInfoPtr_textElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpeechBubble>.NativeClassPtr, nameof (textElement));
    SpeechBubble.NativeMethodInfoPtr_SetSize_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeechBubble>.NativeClassPtr, 100671579);
    SpeechBubble.NativeMethodInfoPtr_SetTextColour_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeechBubble>.NativeClassPtr, 100671580);
    SpeechBubble.NativeMethodInfoPtr_SetTextSpriteAsset_Public_Void_TMP_SpriteAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeechBubble>.NativeClassPtr, 100671581);
    SpeechBubble.NativeMethodInfoPtr_SetText_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeechBubble>.NativeClassPtr, 100671582);
    SpeechBubble.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeechBubble>.NativeClassPtr, 100671583);
  }

  public SpeechBubble(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe TMP_Text textElement
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpeechBubble.NativeFieldInfoPtr_textElement));
      return pointer == IntPtr.Zero ? (TMP_Text) null : new TMP_Text(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpeechBubble.NativeFieldInfoPtr_textElement), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
