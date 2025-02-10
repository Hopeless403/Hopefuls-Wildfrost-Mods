// Decompiled with JetBrains decompiler
// Type: PointCameraAtHoverCardSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.SceneManagement;

#nullable disable
public class PointCameraAtHoverCardSystem : GameSystem
{
  private static readonly System.IntPtr NativeFieldInfoPtr_cameraMover;
  private static readonly System.IntPtr NativeFieldInfoPtr_affectInPlay;
  private static readonly System.IntPtr NativeFieldInfoPtr_affectNotInPlay;
  private static readonly System.IntPtr NativeFieldInfoPtr_aimLerp;
  private static readonly System.IntPtr NativeFieldInfoPtr_aimResetLerp;
  private static readonly System.IntPtr NativeFieldInfoPtr_aimAmount;
  private static readonly System.IntPtr NativeFieldInfoPtr_pullLerp;
  private static readonly System.IntPtr NativeFieldInfoPtr_pullResetLerp;
  private static readonly System.IntPtr NativeFieldInfoPtr_pullAmount;
  private static readonly System.IntPtr NativeFieldInfoPtr_pullClamp;
  private static readonly System.IntPtr NativeFieldInfoPtr_current;
  private static readonly System.IntPtr NativeFieldInfoPtr_amount;
  private static readonly System.IntPtr NativeFieldInfoPtr_originalRotation;
  private static readonly System.IntPtr NativeFieldInfoPtr_toRotation;
  private static readonly System.IntPtr NativeFieldInfoPtr_originalPosition;
  private static readonly System.IntPtr NativeFieldInfoPtr_toPosition;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EntityHover_Private_Void_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EntityUnHover_Private_Void_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SceneChanged_Private_Void_Scene_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Check_Private_Boolean_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SettingChanged_Private_Void_String_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66613, XrefRangeEnd = 66654, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(PointCameraAtHoverCardSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66654, XrefRangeEnd = 66687, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(PointCameraAtHoverCardSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66687, XrefRangeEnd = 66722, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(PointCameraAtHoverCardSystem.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  public unsafe void EntityHover(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(PointCameraAtHoverCardSystem.NativeMethodInfoPtr_EntityHover_Private_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66722, XrefRangeEnd = 66727, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EntityUnHover(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(PointCameraAtHoverCardSystem.NativeMethodInfoPtr_EntityUnHover_Private_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66727, XrefRangeEnd = 66728, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SceneChanged(Scene scene)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &scene
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(PointCameraAtHoverCardSystem.NativeMethodInfoPtr_SceneChanged_Private_Void_Scene_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  public unsafe bool Check(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PointCameraAtHoverCardSystem.NativeMethodInfoPtr_Check_Private_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66728, XrefRangeEnd = 66734, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SettingChanged(string key, Il2CppSystem.Object value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(key);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(PointCameraAtHoverCardSystem.NativeMethodInfoPtr_SettingChanged_Private_Void_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66734, XrefRangeEnd = 66739, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe PointCameraAtHoverCardSystem()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PointCameraAtHoverCardSystem>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(PointCameraAtHoverCardSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static PointCameraAtHoverCardSystem()
  {
    Il2CppClassPointerStore<PointCameraAtHoverCardSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (PointCameraAtHoverCardSystem));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PointCameraAtHoverCardSystem>.NativeClassPtr);
    PointCameraAtHoverCardSystem.NativeFieldInfoPtr_cameraMover = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointCameraAtHoverCardSystem>.NativeClassPtr, nameof (cameraMover));
    PointCameraAtHoverCardSystem.NativeFieldInfoPtr_affectInPlay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointCameraAtHoverCardSystem>.NativeClassPtr, nameof (affectInPlay));
    PointCameraAtHoverCardSystem.NativeFieldInfoPtr_affectNotInPlay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointCameraAtHoverCardSystem>.NativeClassPtr, nameof (affectNotInPlay));
    PointCameraAtHoverCardSystem.NativeFieldInfoPtr_aimLerp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointCameraAtHoverCardSystem>.NativeClassPtr, nameof (aimLerp));
    PointCameraAtHoverCardSystem.NativeFieldInfoPtr_aimResetLerp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointCameraAtHoverCardSystem>.NativeClassPtr, nameof (aimResetLerp));
    PointCameraAtHoverCardSystem.NativeFieldInfoPtr_aimAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointCameraAtHoverCardSystem>.NativeClassPtr, nameof (aimAmount));
    PointCameraAtHoverCardSystem.NativeFieldInfoPtr_pullLerp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointCameraAtHoverCardSystem>.NativeClassPtr, nameof (pullLerp));
    PointCameraAtHoverCardSystem.NativeFieldInfoPtr_pullResetLerp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointCameraAtHoverCardSystem>.NativeClassPtr, nameof (pullResetLerp));
    PointCameraAtHoverCardSystem.NativeFieldInfoPtr_pullAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointCameraAtHoverCardSystem>.NativeClassPtr, nameof (pullAmount));
    PointCameraAtHoverCardSystem.NativeFieldInfoPtr_pullClamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointCameraAtHoverCardSystem>.NativeClassPtr, nameof (pullClamp));
    PointCameraAtHoverCardSystem.NativeFieldInfoPtr_current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointCameraAtHoverCardSystem>.NativeClassPtr, nameof (current));
    PointCameraAtHoverCardSystem.NativeFieldInfoPtr_amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointCameraAtHoverCardSystem>.NativeClassPtr, nameof (amount));
    PointCameraAtHoverCardSystem.NativeFieldInfoPtr_originalRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointCameraAtHoverCardSystem>.NativeClassPtr, nameof (originalRotation));
    PointCameraAtHoverCardSystem.NativeFieldInfoPtr_toRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointCameraAtHoverCardSystem>.NativeClassPtr, nameof (toRotation));
    PointCameraAtHoverCardSystem.NativeFieldInfoPtr_originalPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointCameraAtHoverCardSystem>.NativeClassPtr, nameof (originalPosition));
    PointCameraAtHoverCardSystem.NativeFieldInfoPtr_toPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointCameraAtHoverCardSystem>.NativeClassPtr, nameof (toPosition));
    PointCameraAtHoverCardSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointCameraAtHoverCardSystem>.NativeClassPtr, 100668785);
    PointCameraAtHoverCardSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointCameraAtHoverCardSystem>.NativeClassPtr, 100668786);
    PointCameraAtHoverCardSystem.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointCameraAtHoverCardSystem>.NativeClassPtr, 100668787);
    PointCameraAtHoverCardSystem.NativeMethodInfoPtr_EntityHover_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointCameraAtHoverCardSystem>.NativeClassPtr, 100668788);
    PointCameraAtHoverCardSystem.NativeMethodInfoPtr_EntityUnHover_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointCameraAtHoverCardSystem>.NativeClassPtr, 100668789);
    PointCameraAtHoverCardSystem.NativeMethodInfoPtr_SceneChanged_Private_Void_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointCameraAtHoverCardSystem>.NativeClassPtr, 100668790);
    PointCameraAtHoverCardSystem.NativeMethodInfoPtr_Check_Private_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointCameraAtHoverCardSystem>.NativeClassPtr, 100668791);
    PointCameraAtHoverCardSystem.NativeMethodInfoPtr_SettingChanged_Private_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointCameraAtHoverCardSystem>.NativeClassPtr, 100668792);
    PointCameraAtHoverCardSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointCameraAtHoverCardSystem>.NativeClassPtr, 100668793);
  }

  public PointCameraAtHoverCardSystem(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Transform cameraMover
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PointCameraAtHoverCardSystem.NativeFieldInfoPtr_cameraMover));
      return pointer == System.IntPtr.Zero ? (Transform) null : new Transform(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PointCameraAtHoverCardSystem.NativeFieldInfoPtr_cameraMover), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool affectInPlay
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PointCameraAtHoverCardSystem.NativeFieldInfoPtr_affectInPlay));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PointCameraAtHoverCardSystem.NativeFieldInfoPtr_affectInPlay)) = value;
    }
  }

  public unsafe bool affectNotInPlay
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PointCameraAtHoverCardSystem.NativeFieldInfoPtr_affectNotInPlay));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PointCameraAtHoverCardSystem.NativeFieldInfoPtr_affectNotInPlay)) = value;
    }
  }

  public unsafe float aimLerp
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PointCameraAtHoverCardSystem.NativeFieldInfoPtr_aimLerp));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PointCameraAtHoverCardSystem.NativeFieldInfoPtr_aimLerp)) = value;
    }
  }

  public unsafe float aimResetLerp
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PointCameraAtHoverCardSystem.NativeFieldInfoPtr_aimResetLerp));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PointCameraAtHoverCardSystem.NativeFieldInfoPtr_aimResetLerp)) = value;
    }
  }

  public unsafe float aimAmount
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PointCameraAtHoverCardSystem.NativeFieldInfoPtr_aimAmount));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PointCameraAtHoverCardSystem.NativeFieldInfoPtr_aimAmount)) = value;
    }
  }

  public unsafe float pullLerp
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PointCameraAtHoverCardSystem.NativeFieldInfoPtr_pullLerp));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PointCameraAtHoverCardSystem.NativeFieldInfoPtr_pullLerp)) = value;
    }
  }

  public unsafe float pullResetLerp
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PointCameraAtHoverCardSystem.NativeFieldInfoPtr_pullResetLerp));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PointCameraAtHoverCardSystem.NativeFieldInfoPtr_pullResetLerp)) = value;
    }
  }

  public unsafe float pullAmount
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PointCameraAtHoverCardSystem.NativeFieldInfoPtr_pullAmount));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PointCameraAtHoverCardSystem.NativeFieldInfoPtr_pullAmount)) = value;
    }
  }

  public unsafe float pullClamp
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PointCameraAtHoverCardSystem.NativeFieldInfoPtr_pullClamp));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PointCameraAtHoverCardSystem.NativeFieldInfoPtr_pullClamp)) = value;
    }
  }

  public unsafe Entity current
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PointCameraAtHoverCardSystem.NativeFieldInfoPtr_current));
      return pointer == System.IntPtr.Zero ? (Entity) null : new Entity(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PointCameraAtHoverCardSystem.NativeFieldInfoPtr_current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float amount
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PointCameraAtHoverCardSystem.NativeFieldInfoPtr_amount));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PointCameraAtHoverCardSystem.NativeFieldInfoPtr_amount)) = value;
    }
  }

  public unsafe Quaternion originalRotation
  {
    get
    {
      return *(Quaternion*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PointCameraAtHoverCardSystem.NativeFieldInfoPtr_originalRotation));
    }
    [param: In] set
    {
      *(Quaternion*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PointCameraAtHoverCardSystem.NativeFieldInfoPtr_originalRotation)) = value;
    }
  }

  public unsafe Quaternion toRotation
  {
    get
    {
      return *(Quaternion*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PointCameraAtHoverCardSystem.NativeFieldInfoPtr_toRotation));
    }
    [param: In] set
    {
      *(Quaternion*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PointCameraAtHoverCardSystem.NativeFieldInfoPtr_toRotation)) = value;
    }
  }

  public unsafe Vector3 originalPosition
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PointCameraAtHoverCardSystem.NativeFieldInfoPtr_originalPosition));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PointCameraAtHoverCardSystem.NativeFieldInfoPtr_originalPosition)) = value;
    }
  }

  public unsafe Vector3 toPosition
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PointCameraAtHoverCardSystem.NativeFieldInfoPtr_toPosition));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PointCameraAtHoverCardSystem.NativeFieldInfoPtr_toPosition)) = value;
    }
  }
}
