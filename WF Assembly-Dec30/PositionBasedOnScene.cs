// Decompiled with JetBrains decompiler
// Type: PositionBasedOnScene
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
using UnityEngine.SceneManagement;

#nullable disable
public class PositionBasedOnScene : MonoBehaviour
{
  private static readonly System.IntPtr NativeFieldInfoPtr_positions;
  private static readonly System.IntPtr NativeFieldInfoPtr_hasRectTransform;
  private static readonly System.IntPtr NativeFieldInfoPtr_rt;
  private static readonly System.IntPtr NativeFieldInfoPtr_t;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ActiveSceneChanged_Private_Void_Scene_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetPosition_Private_Void_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53287, XrefRangeEnd = 53300, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(PositionBasedOnScene.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53300, XrefRangeEnd = 53308, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(PositionBasedOnScene.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53308, XrefRangeEnd = 53322, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ActiveSceneChanged(Scene to)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &to
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(PositionBasedOnScene.NativeMethodInfoPtr_ActiveSceneChanged_Private_Void_Scene_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53322, XrefRangeEnd = 53323, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetPosition(Vector3 pos)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &pos
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(PositionBasedOnScene.NativeMethodInfoPtr_SetPosition_Private_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(212)]
  [CachedScanResults(RefRangeStart = 12749, RefRangeEnd = 12961, XrefRangeStart = 12749, XrefRangeEnd = 12961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe PositionBasedOnScene()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PositionBasedOnScene>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(PositionBasedOnScene.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static PositionBasedOnScene()
  {
    Il2CppClassPointerStore<PositionBasedOnScene>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (PositionBasedOnScene));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PositionBasedOnScene>.NativeClassPtr);
    PositionBasedOnScene.NativeFieldInfoPtr_positions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PositionBasedOnScene>.NativeClassPtr, nameof (positions));
    PositionBasedOnScene.NativeFieldInfoPtr_hasRectTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PositionBasedOnScene>.NativeClassPtr, nameof (hasRectTransform));
    PositionBasedOnScene.NativeFieldInfoPtr_rt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PositionBasedOnScene>.NativeClassPtr, nameof (rt));
    PositionBasedOnScene.NativeFieldInfoPtr_t = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PositionBasedOnScene>.NativeClassPtr, nameof (t));
    PositionBasedOnScene.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PositionBasedOnScene>.NativeClassPtr, 100667600);
    PositionBasedOnScene.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PositionBasedOnScene>.NativeClassPtr, 100667601);
    PositionBasedOnScene.NativeMethodInfoPtr_ActiveSceneChanged_Private_Void_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PositionBasedOnScene>.NativeClassPtr, 100667602);
    PositionBasedOnScene.NativeMethodInfoPtr_SetPosition_Private_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PositionBasedOnScene>.NativeClassPtr, 100667603);
    PositionBasedOnScene.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PositionBasedOnScene>.NativeClassPtr, 100667604);
  }

  public PositionBasedOnScene(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Il2CppReferenceArray<PositionBasedOnScene.ScenePosition> positions
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PositionBasedOnScene.NativeFieldInfoPtr_positions));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<PositionBasedOnScene.ScenePosition>) null : new Il2CppReferenceArray<PositionBasedOnScene.ScenePosition>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PositionBasedOnScene.NativeFieldInfoPtr_positions), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool hasRectTransform
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PositionBasedOnScene.NativeFieldInfoPtr_hasRectTransform));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PositionBasedOnScene.NativeFieldInfoPtr_hasRectTransform)) = value;
    }
  }

  public unsafe RectTransform rt
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PositionBasedOnScene.NativeFieldInfoPtr_rt));
      return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PositionBasedOnScene.NativeFieldInfoPtr_rt), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Transform t
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PositionBasedOnScene.NativeFieldInfoPtr_t));
      return pointer == System.IntPtr.Zero ? (Transform) null : new Transform(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PositionBasedOnScene.NativeFieldInfoPtr_t), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [Serializable]
  public class ScenePosition : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_sceneName;
    private static readonly System.IntPtr NativeFieldInfoPtr_position;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ScenePosition()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PositionBasedOnScene.ScenePosition>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PositionBasedOnScene.ScenePosition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ScenePosition()
    {
      Il2CppClassPointerStore<PositionBasedOnScene.ScenePosition>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PositionBasedOnScene>.NativeClassPtr, nameof (ScenePosition));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PositionBasedOnScene.ScenePosition>.NativeClassPtr);
      PositionBasedOnScene.ScenePosition.NativeFieldInfoPtr_sceneName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PositionBasedOnScene.ScenePosition>.NativeClassPtr, nameof (sceneName));
      PositionBasedOnScene.ScenePosition.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PositionBasedOnScene.ScenePosition>.NativeClassPtr, nameof (position));
      PositionBasedOnScene.ScenePosition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PositionBasedOnScene.ScenePosition>.NativeClassPtr, 100667605);
    }

    public ScenePosition(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe string sceneName
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PositionBasedOnScene.ScenePosition.NativeFieldInfoPtr_sceneName)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PositionBasedOnScene.ScenePosition.NativeFieldInfoPtr_sceneName), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe Vector3 position
    {
      get
      {
        return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PositionBasedOnScene.ScenePosition.NativeFieldInfoPtr_position));
      }
      [param: In] set
      {
        *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PositionBasedOnScene.ScenePosition.NativeFieldInfoPtr_position)) = value;
      }
    }
  }

  [ObfuscatedName("PositionBasedOnScene/<>c__DisplayClass6_0")]
  public sealed class __c__DisplayClass6_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_to;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ActiveSceneChanged_b__0_Internal_Boolean_ScenePosition_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass6_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PositionBasedOnScene.__c__DisplayClass6_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PositionBasedOnScene.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53284, XrefRangeEnd = 53287, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _ActiveSceneChanged_b__0(PositionBasedOnScene.ScenePosition a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PositionBasedOnScene.__c__DisplayClass6_0.NativeMethodInfoPtr__ActiveSceneChanged_b__0_Internal_Boolean_ScenePosition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c__DisplayClass6_0()
    {
      Il2CppClassPointerStore<PositionBasedOnScene.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PositionBasedOnScene>.NativeClassPtr, "<>c__DisplayClass6_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PositionBasedOnScene.__c__DisplayClass6_0>.NativeClassPtr);
      PositionBasedOnScene.__c__DisplayClass6_0.NativeFieldInfoPtr_to = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PositionBasedOnScene.__c__DisplayClass6_0>.NativeClassPtr, nameof (to));
      PositionBasedOnScene.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PositionBasedOnScene.__c__DisplayClass6_0>.NativeClassPtr, 100667606);
      PositionBasedOnScene.__c__DisplayClass6_0.NativeMethodInfoPtr__ActiveSceneChanged_b__0_Internal_Boolean_ScenePosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PositionBasedOnScene.__c__DisplayClass6_0>.NativeClassPtr, 100667607);
    }

    public __c__DisplayClass6_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Scene to
    {
      get
      {
        return *(Scene*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PositionBasedOnScene.__c__DisplayClass6_0.NativeFieldInfoPtr_to));
      }
      [param: In] set
      {
        *(Scene*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PositionBasedOnScene.__c__DisplayClass6_0.NativeFieldInfoPtr_to)) = value;
      }
    }
  }
}
