// Decompiled with JetBrains decompiler
// Type: CharacterAvatarMoveToCard
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
public class CharacterAvatarMoveToCard : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_inCardPosition;
  private static readonly IntPtr NativeFieldInfoPtr_inCardRotation;
  private static readonly IntPtr NativeFieldInfoPtr_inCardScale;
  private static readonly IntPtr NativeMethodInfoPtr_MoveToCard_Public_Void_Card_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28172, XrefRangeEnd = 28181, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void MoveToCard(Card card)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) card)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CharacterAvatarMoveToCard.NativeMethodInfoPtr_MoveToCard_Public_Void_Card_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(212)]
  [CachedScanResults(RefRangeStart = 12749, RefRangeEnd = 12961, XrefRangeStart = 12749, XrefRangeEnd = 12961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CharacterAvatarMoveToCard()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterAvatarMoveToCard>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CharacterAvatarMoveToCard.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static CharacterAvatarMoveToCard()
  {
    Il2CppClassPointerStore<CharacterAvatarMoveToCard>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (CharacterAvatarMoveToCard));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterAvatarMoveToCard>.NativeClassPtr);
    CharacterAvatarMoveToCard.NativeFieldInfoPtr_inCardPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAvatarMoveToCard>.NativeClassPtr, nameof (inCardPosition));
    CharacterAvatarMoveToCard.NativeFieldInfoPtr_inCardRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAvatarMoveToCard>.NativeClassPtr, nameof (inCardRotation));
    CharacterAvatarMoveToCard.NativeFieldInfoPtr_inCardScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAvatarMoveToCard>.NativeClassPtr, nameof (inCardScale));
    CharacterAvatarMoveToCard.NativeMethodInfoPtr_MoveToCard_Public_Void_Card_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAvatarMoveToCard>.NativeClassPtr, 100664846);
    CharacterAvatarMoveToCard.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAvatarMoveToCard>.NativeClassPtr, 100664847);
  }

  public CharacterAvatarMoveToCard(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Vector3 inCardPosition
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAvatarMoveToCard.NativeFieldInfoPtr_inCardPosition));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAvatarMoveToCard.NativeFieldInfoPtr_inCardPosition)) = value;
    }
  }

  public unsafe Vector3 inCardRotation
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAvatarMoveToCard.NativeFieldInfoPtr_inCardRotation));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAvatarMoveToCard.NativeFieldInfoPtr_inCardRotation)) = value;
    }
  }

  public unsafe Vector3 inCardScale
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAvatarMoveToCard.NativeFieldInfoPtr_inCardScale));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAvatarMoveToCard.NativeFieldInfoPtr_inCardScale)) = value;
    }
  }
}
