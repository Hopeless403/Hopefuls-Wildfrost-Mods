// Decompiled with JetBrains decompiler
// Type: AvatarEyePositions
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
public class AvatarEyePositions : MonoBehaviour
{
  private static readonly System.IntPtr NativeFieldInfoPtr_eyes;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(212)]
  [CachedScanResults(RefRangeStart = 12749, RefRangeEnd = 12961, XrefRangeStart = 12749, XrefRangeEnd = 12961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe AvatarEyePositions()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarEyePositions>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(AvatarEyePositions.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static AvatarEyePositions()
  {
    Il2CppClassPointerStore<AvatarEyePositions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (AvatarEyePositions));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarEyePositions>.NativeClassPtr);
    AvatarEyePositions.NativeFieldInfoPtr_eyes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEyePositions>.NativeClassPtr, nameof (eyes));
    AvatarEyePositions.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEyePositions>.NativeClassPtr, 100664804);
  }

  public AvatarEyePositions(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Il2CppReferenceArray<AvatarEyePositions.Eye> eyes
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AvatarEyePositions.NativeFieldInfoPtr_eyes));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<AvatarEyePositions.Eye>) null : new Il2CppReferenceArray<AvatarEyePositions.Eye>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AvatarEyePositions.NativeFieldInfoPtr_eyes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [Serializable]
  public class Eye : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_pos;
    private static readonly System.IntPtr NativeFieldInfoPtr_scale;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27696, XrefRangeEnd = 27697, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Eye()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarEyePositions.Eye>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AvatarEyePositions.Eye.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Eye()
    {
      Il2CppClassPointerStore<AvatarEyePositions.Eye>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AvatarEyePositions>.NativeClassPtr, nameof (Eye));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarEyePositions.Eye>.NativeClassPtr);
      AvatarEyePositions.Eye.NativeFieldInfoPtr_pos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEyePositions.Eye>.NativeClassPtr, nameof (pos));
      AvatarEyePositions.Eye.NativeFieldInfoPtr_scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEyePositions.Eye>.NativeClassPtr, nameof (scale));
      AvatarEyePositions.Eye.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEyePositions.Eye>.NativeClassPtr, 100664805);
    }

    public Eye(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Vector3 pos
    {
      get
      {
        return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AvatarEyePositions.Eye.NativeFieldInfoPtr_pos));
      }
      [param: In] set
      {
        *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AvatarEyePositions.Eye.NativeFieldInfoPtr_pos)) = value;
      }
    }

    public unsafe Vector3 scale
    {
      get
      {
        return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AvatarEyePositions.Eye.NativeFieldInfoPtr_scale));
      }
      [param: In] set
      {
        *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AvatarEyePositions.Eye.NativeFieldInfoPtr_scale)) = value;
      }
    }
  }
}
