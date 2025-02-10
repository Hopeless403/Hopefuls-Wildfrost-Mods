// Decompiled with JetBrains decompiler
// Type: AvatarPoser
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
public class AvatarPoser : MonoBehaviour
{
  private static readonly System.IntPtr NativeFieldInfoPtr_faceImage;
  private static readonly System.IntPtr NativeFieldInfoPtr_bodyImage;
  private static readonly System.IntPtr NativeFieldInfoPtr_pingStrength;
  private static readonly System.IntPtr NativeFieldInfoPtr_poseTime;
  private static readonly System.IntPtr NativeFieldInfoPtr_poses;
  private static readonly System.IntPtr NativeFieldInfoPtr_poseLookup;
  private static readonly System.IntPtr NativeFieldInfoPtr_baseFaceSprite;
  private static readonly System.IntPtr NativeFieldInfoPtr_baseBodySprite;
  private static readonly System.IntPtr NativeFieldInfoPtr_scale;
  private static readonly System.IntPtr NativeFieldInfoPtr_reset;
  private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Ping_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27750, XrefRangeEnd = 27768, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(AvatarPoser.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27768, XrefRangeEnd = 27779, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(AvatarPoser.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27779, XrefRangeEnd = 27795, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(string poseName)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(poseName)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(AvatarPoser.NativeMethodInfoPtr_Set_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 27805, RefRangeEnd = 27807, XrefRangeStart = 27795, XrefRangeEnd = 27805, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Ping()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(AvatarPoser.NativeMethodInfoPtr_Ping_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27807, XrefRangeEnd = 27816, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe AvatarPoser()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarPoser>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(AvatarPoser.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static AvatarPoser()
  {
    Il2CppClassPointerStore<AvatarPoser>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (AvatarPoser));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarPoser>.NativeClassPtr);
    AvatarPoser.NativeFieldInfoPtr_faceImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarPoser>.NativeClassPtr, nameof (faceImage));
    AvatarPoser.NativeFieldInfoPtr_bodyImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarPoser>.NativeClassPtr, nameof (bodyImage));
    AvatarPoser.NativeFieldInfoPtr_pingStrength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarPoser>.NativeClassPtr, nameof (pingStrength));
    AvatarPoser.NativeFieldInfoPtr_poseTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarPoser>.NativeClassPtr, nameof (poseTime));
    AvatarPoser.NativeFieldInfoPtr_poses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarPoser>.NativeClassPtr, nameof (poses));
    AvatarPoser.NativeFieldInfoPtr_poseLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarPoser>.NativeClassPtr, nameof (poseLookup));
    AvatarPoser.NativeFieldInfoPtr_baseFaceSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarPoser>.NativeClassPtr, nameof (baseFaceSprite));
    AvatarPoser.NativeFieldInfoPtr_baseBodySprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarPoser>.NativeClassPtr, nameof (baseBodySprite));
    AvatarPoser.NativeFieldInfoPtr_scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarPoser>.NativeClassPtr, nameof (scale));
    AvatarPoser.NativeFieldInfoPtr_reset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarPoser>.NativeClassPtr, nameof (reset));
    AvatarPoser.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarPoser>.NativeClassPtr, 100664815);
    AvatarPoser.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarPoser>.NativeClassPtr, 100664816);
    AvatarPoser.NativeMethodInfoPtr_Set_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarPoser>.NativeClassPtr, 100664817);
    AvatarPoser.NativeMethodInfoPtr_Ping_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarPoser>.NativeClassPtr, 100664818);
    AvatarPoser.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarPoser>.NativeClassPtr, 100664819);
  }

  public AvatarPoser(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Image faceImage
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AvatarPoser.NativeFieldInfoPtr_faceImage));
      return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AvatarPoser.NativeFieldInfoPtr_faceImage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Image bodyImage
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AvatarPoser.NativeFieldInfoPtr_bodyImage));
      return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AvatarPoser.NativeFieldInfoPtr_bodyImage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float pingStrength
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AvatarPoser.NativeFieldInfoPtr_pingStrength));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AvatarPoser.NativeFieldInfoPtr_pingStrength)) = value;
    }
  }

  public unsafe Vector2 poseTime
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AvatarPoser.NativeFieldInfoPtr_poseTime));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AvatarPoser.NativeFieldInfoPtr_poseTime)) = value;
    }
  }

  public unsafe Il2CppReferenceArray<AvatarPoser.Pose> poses
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AvatarPoser.NativeFieldInfoPtr_poses));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<AvatarPoser.Pose>) null : new Il2CppReferenceArray<AvatarPoser.Pose>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AvatarPoser.NativeFieldInfoPtr_poses), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Dictionary<string, AvatarPoser.Pose> poseLookup
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AvatarPoser.NativeFieldInfoPtr_poseLookup));
      return pointer == System.IntPtr.Zero ? (Dictionary<string, AvatarPoser.Pose>) null : new Dictionary<string, AvatarPoser.Pose>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AvatarPoser.NativeFieldInfoPtr_poseLookup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Sprite baseFaceSprite
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AvatarPoser.NativeFieldInfoPtr_baseFaceSprite));
      return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AvatarPoser.NativeFieldInfoPtr_baseFaceSprite), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Sprite baseBodySprite
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AvatarPoser.NativeFieldInfoPtr_baseBodySprite));
      return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AvatarPoser.NativeFieldInfoPtr_baseBodySprite), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector3 scale
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AvatarPoser.NativeFieldInfoPtr_scale));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AvatarPoser.NativeFieldInfoPtr_scale)) = value;
    }
  }

  public unsafe float reset
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AvatarPoser.NativeFieldInfoPtr_reset));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AvatarPoser.NativeFieldInfoPtr_reset)) = value;
    }
  }

  [Serializable]
  public sealed class Pose : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_name;
    private static readonly System.IntPtr NativeFieldInfoPtr_setFace;
    private static readonly System.IntPtr NativeFieldInfoPtr_face;
    private static readonly System.IntPtr NativeFieldInfoPtr_setBody;
    private static readonly System.IntPtr NativeFieldInfoPtr_body;

    static Pose()
    {
      Il2CppClassPointerStore<AvatarPoser.Pose>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AvatarPoser>.NativeClassPtr, nameof (Pose));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarPoser.Pose>.NativeClassPtr);
      AvatarPoser.Pose.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarPoser.Pose>.NativeClassPtr, nameof (name));
      AvatarPoser.Pose.NativeFieldInfoPtr_setFace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarPoser.Pose>.NativeClassPtr, nameof (setFace));
      AvatarPoser.Pose.NativeFieldInfoPtr_face = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarPoser.Pose>.NativeClassPtr, nameof (face));
      AvatarPoser.Pose.NativeFieldInfoPtr_setBody = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarPoser.Pose>.NativeClassPtr, nameof (setBody));
      AvatarPoser.Pose.NativeFieldInfoPtr_body = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarPoser.Pose>.NativeClassPtr, nameof (body));
    }

    public Pose(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public Pose()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AvatarPoser.Pose>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AvatarPoser.Pose>.NativeClassPtr, data));
    }

    public unsafe string name
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AvatarPoser.Pose.NativeFieldInfoPtr_name)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AvatarPoser.Pose.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe bool setFace
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AvatarPoser.Pose.NativeFieldInfoPtr_setFace));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AvatarPoser.Pose.NativeFieldInfoPtr_setFace)) = value;
      }
    }

    public unsafe Il2CppReferenceArray<Sprite> face
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AvatarPoser.Pose.NativeFieldInfoPtr_face));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<Sprite>) null : new Il2CppReferenceArray<Sprite>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AvatarPoser.Pose.NativeFieldInfoPtr_face), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool setBody
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AvatarPoser.Pose.NativeFieldInfoPtr_setBody));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AvatarPoser.Pose.NativeFieldInfoPtr_setBody)) = value;
      }
    }

    public unsafe Il2CppReferenceArray<Sprite> body
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AvatarPoser.Pose.NativeFieldInfoPtr_body));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<Sprite>) null : new Il2CppReferenceArray<Sprite>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AvatarPoser.Pose.NativeFieldInfoPtr_body), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
