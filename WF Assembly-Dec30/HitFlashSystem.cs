// Decompiled with JetBrains decompiler
// Type: HitFlashSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
public class HitFlashSystem : GameSystem
{
  private static readonly System.IntPtr NativeFieldInfoPtr_instance;
  private static readonly System.IntPtr NativeFieldInfoPtr_flashDuration;
  private static readonly System.IntPtr NativeFieldInfoPtr_damageMaterial;
  private static readonly System.IntPtr NativeFieldInfoPtr_list;
  private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EntityHit_Private_Void_Hit_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RemoveFromTarget_Private_Void_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Remove_Public_Static_Void_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60869, XrefRangeEnd = 60873, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(HitFlashSystem.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60873, XrefRangeEnd = 60881, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(HitFlashSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60881, XrefRangeEnd = 60890, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(HitFlashSystem.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60890, XrefRangeEnd = 60914, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(HitFlashSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60914, XrefRangeEnd = 60952, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EntityHit(Hit hit)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) hit)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(HitFlashSystem.NativeMethodInfoPtr_EntityHit_Private_Void_Hit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60952, XrefRangeEnd = 60970, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RemoveFromTarget(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(HitFlashSystem.NativeMethodInfoPtr_RemoveFromTarget_Private_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 60995, RefRangeEnd = 60996, XrefRangeStart = 60970, XrefRangeEnd = 60995, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Remove(Entity entity)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(HitFlashSystem.NativeMethodInfoPtr_Remove_Public_Static_Void_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60996, XrefRangeEnd = 61005, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe HitFlashSystem()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HitFlashSystem>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(HitFlashSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static HitFlashSystem()
  {
    Il2CppClassPointerStore<HitFlashSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (HitFlashSystem));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HitFlashSystem>.NativeClassPtr);
    HitFlashSystem.NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HitFlashSystem>.NativeClassPtr, nameof (instance));
    HitFlashSystem.NativeFieldInfoPtr_flashDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HitFlashSystem>.NativeClassPtr, nameof (flashDuration));
    HitFlashSystem.NativeFieldInfoPtr_damageMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HitFlashSystem>.NativeClassPtr, nameof (damageMaterial));
    HitFlashSystem.NativeFieldInfoPtr_list = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HitFlashSystem>.NativeClassPtr, nameof (list));
    HitFlashSystem.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HitFlashSystem>.NativeClassPtr, 100668255);
    HitFlashSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HitFlashSystem>.NativeClassPtr, 100668256);
    HitFlashSystem.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HitFlashSystem>.NativeClassPtr, 100668257);
    HitFlashSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HitFlashSystem>.NativeClassPtr, 100668258);
    HitFlashSystem.NativeMethodInfoPtr_EntityHit_Private_Void_Hit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HitFlashSystem>.NativeClassPtr, 100668259);
    HitFlashSystem.NativeMethodInfoPtr_RemoveFromTarget_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HitFlashSystem>.NativeClassPtr, 100668260);
    HitFlashSystem.NativeMethodInfoPtr_Remove_Public_Static_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HitFlashSystem>.NativeClassPtr, 100668261);
    HitFlashSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HitFlashSystem>.NativeClassPtr, 100668262);
  }

  public HitFlashSystem(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe HitFlashSystem instance
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(HitFlashSystem.NativeFieldInfoPtr_instance, (void*) &num);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (HitFlashSystem) null : new HitFlashSystem(pointer);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(HitFlashSystem.NativeFieldInfoPtr_instance, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float flashDuration
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HitFlashSystem.NativeFieldInfoPtr_flashDuration));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HitFlashSystem.NativeFieldInfoPtr_flashDuration)) = value;
    }
  }

  public unsafe Material damageMaterial
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HitFlashSystem.NativeFieldInfoPtr_damageMaterial));
      return pointer == System.IntPtr.Zero ? (Material) null : new Material(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HitFlashSystem.NativeFieldInfoPtr_damageMaterial), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<HitFlashSystem.HitFlash> list
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HitFlashSystem.NativeFieldInfoPtr_list));
      return pointer == System.IntPtr.Zero ? (List<HitFlashSystem.HitFlash>) null : new List<HitFlashSystem.HitFlash>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HitFlashSystem.NativeFieldInfoPtr_list), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public class HitFlash : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__target_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr_material;
    private static readonly System.IntPtr NativeFieldInfoPtr_time;
    private static readonly System.IntPtr NativeFieldInfoPtr_imageDict;
    private static readonly System.IntPtr NativeFieldInfoPtr_textElements;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_target_Public_get_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_target_Private_set_Void_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ended_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Entity_Material_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Start_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Update_Public_Void_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_End_Public_Void_0;

    public unsafe Entity target
    {
      [CallerCount(10), CachedScanResults(RefRangeStart = 20094, RefRangeEnd = 20104, XrefRangeStart = 20094, XrefRangeEnd = 20104, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HitFlashSystem.HitFlash.NativeMethodInfoPtr_get_target_Public_get_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Entity) null : new Entity(pointer);
      }
      [CallerCount(21), CachedScanResults(RefRangeStart = 20073, RefRangeEnd = 20094, XrefRangeStart = 20073, XrefRangeEnd = 20094, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
        };
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HitFlashSystem.HitFlash.NativeMethodInfoPtr_set_target_Private_set_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe bool ended
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HitFlashSystem.HitFlash.NativeMethodInfoPtr_get_ended_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60702, XrefRangeEnd = 60721, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe HitFlash(Entity entity, Material material, float duration)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HitFlashSystem.HitFlash>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) material);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &duration;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HitFlashSystem.HitFlash.NativeMethodInfoPtr__ctor_Public_Void_Entity_Material_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 60749, RefRangeEnd = 60751, XrefRangeStart = 60721, XrefRangeEnd = 60749, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Start()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HitFlashSystem.HitFlash.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60751, XrefRangeEnd = 60752, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Update(float delta)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &delta
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HitFlashSystem.HitFlash.NativeMethodInfoPtr_Update_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 60790, RefRangeEnd = 60795, XrefRangeStart = 60752, XrefRangeEnd = 60790, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void End()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HitFlashSystem.HitFlash.NativeMethodInfoPtr_End_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static HitFlash()
    {
      Il2CppClassPointerStore<HitFlashSystem.HitFlash>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HitFlashSystem>.NativeClassPtr, nameof (HitFlash));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HitFlashSystem.HitFlash>.NativeClassPtr);
      HitFlashSystem.HitFlash.NativeFieldInfoPtr__target_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HitFlashSystem.HitFlash>.NativeClassPtr, "<target>k__BackingField");
      HitFlashSystem.HitFlash.NativeFieldInfoPtr_material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HitFlashSystem.HitFlash>.NativeClassPtr, nameof (material));
      HitFlashSystem.HitFlash.NativeFieldInfoPtr_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HitFlashSystem.HitFlash>.NativeClassPtr, nameof (time));
      HitFlashSystem.HitFlash.NativeFieldInfoPtr_imageDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HitFlashSystem.HitFlash>.NativeClassPtr, nameof (imageDict));
      HitFlashSystem.HitFlash.NativeFieldInfoPtr_textElements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HitFlashSystem.HitFlash>.NativeClassPtr, nameof (textElements));
      HitFlashSystem.HitFlash.NativeMethodInfoPtr_get_target_Public_get_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HitFlashSystem.HitFlash>.NativeClassPtr, 100668263);
      HitFlashSystem.HitFlash.NativeMethodInfoPtr_set_target_Private_set_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HitFlashSystem.HitFlash>.NativeClassPtr, 100668264);
      HitFlashSystem.HitFlash.NativeMethodInfoPtr_get_ended_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HitFlashSystem.HitFlash>.NativeClassPtr, 100668265);
      HitFlashSystem.HitFlash.NativeMethodInfoPtr__ctor_Public_Void_Entity_Material_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HitFlashSystem.HitFlash>.NativeClassPtr, 100668266);
      HitFlashSystem.HitFlash.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HitFlashSystem.HitFlash>.NativeClassPtr, 100668267);
      HitFlashSystem.HitFlash.NativeMethodInfoPtr_Update_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HitFlashSystem.HitFlash>.NativeClassPtr, 100668268);
      HitFlashSystem.HitFlash.NativeMethodInfoPtr_End_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HitFlashSystem.HitFlash>.NativeClassPtr, 100668269);
    }

    public HitFlash(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Entity _target_k__BackingField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HitFlashSystem.HitFlash.NativeFieldInfoPtr__target_k__BackingField));
        return pointer == System.IntPtr.Zero ? (Entity) null : new Entity(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HitFlashSystem.HitFlash.NativeFieldInfoPtr__target_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Material material
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HitFlashSystem.HitFlash.NativeFieldInfoPtr_material));
        return pointer == System.IntPtr.Zero ? (Material) null : new Material(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HitFlashSystem.HitFlash.NativeFieldInfoPtr_material), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float time
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HitFlashSystem.HitFlash.NativeFieldInfoPtr_time));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HitFlashSystem.HitFlash.NativeFieldInfoPtr_time)) = value;
      }
    }

    public unsafe Dictionary<Image, Material> imageDict
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HitFlashSystem.HitFlash.NativeFieldInfoPtr_imageDict));
        return pointer == System.IntPtr.Zero ? (Dictionary<Image, Material>) null : new Dictionary<Image, Material>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HitFlashSystem.HitFlash.NativeFieldInfoPtr_imageDict), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<TMP_Text> textElements
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HitFlashSystem.HitFlash.NativeFieldInfoPtr_textElements));
        return pointer == System.IntPtr.Zero ? (List<TMP_Text>) null : new List<TMP_Text>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HitFlashSystem.HitFlash.NativeFieldInfoPtr_textElements), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("HitFlashSystem/<>c__DisplayClass8_0")]
  public sealed class __c__DisplayClass8_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_hit;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__EntityHit_b__0_Internal_Boolean_HitFlash_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass8_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HitFlashSystem.__c__DisplayClass8_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HitFlashSystem.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60795, XrefRangeEnd = 60800, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _EntityHit_b__0(HitFlashSystem.HitFlash a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HitFlashSystem.__c__DisplayClass8_0.NativeMethodInfoPtr__EntityHit_b__0_Internal_Boolean_HitFlash_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c__DisplayClass8_0()
    {
      Il2CppClassPointerStore<HitFlashSystem.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HitFlashSystem>.NativeClassPtr, "<>c__DisplayClass8_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HitFlashSystem.__c__DisplayClass8_0>.NativeClassPtr);
      HitFlashSystem.__c__DisplayClass8_0.NativeFieldInfoPtr_hit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HitFlashSystem.__c__DisplayClass8_0>.NativeClassPtr, nameof (hit));
      HitFlashSystem.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HitFlashSystem.__c__DisplayClass8_0>.NativeClassPtr, 100668270);
      HitFlashSystem.__c__DisplayClass8_0.NativeMethodInfoPtr__EntityHit_b__0_Internal_Boolean_HitFlash_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HitFlashSystem.__c__DisplayClass8_0>.NativeClassPtr, 100668271);
    }

    public __c__DisplayClass8_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Hit hit
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HitFlashSystem.__c__DisplayClass8_0.NativeFieldInfoPtr_hit));
        return pointer == System.IntPtr.Zero ? (Hit) null : new Hit(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HitFlashSystem.__c__DisplayClass8_0.NativeFieldInfoPtr_hit), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("HitFlashSystem/<>c__DisplayClass9_0")]
  public sealed class __c__DisplayClass9_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_entity;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__RemoveFromTarget_b__0_Internal_Boolean_HitFlash_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass9_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HitFlashSystem.__c__DisplayClass9_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HitFlashSystem.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60800, XrefRangeEnd = 60869, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _RemoveFromTarget_b__0(HitFlashSystem.HitFlash a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HitFlashSystem.__c__DisplayClass9_0.NativeMethodInfoPtr__RemoveFromTarget_b__0_Internal_Boolean_HitFlash_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c__DisplayClass9_0()
    {
      Il2CppClassPointerStore<HitFlashSystem.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HitFlashSystem>.NativeClassPtr, "<>c__DisplayClass9_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HitFlashSystem.__c__DisplayClass9_0>.NativeClassPtr);
      HitFlashSystem.__c__DisplayClass9_0.NativeFieldInfoPtr_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HitFlashSystem.__c__DisplayClass9_0>.NativeClassPtr, nameof (entity));
      HitFlashSystem.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HitFlashSystem.__c__DisplayClass9_0>.NativeClassPtr, 100668272);
      HitFlashSystem.__c__DisplayClass9_0.NativeMethodInfoPtr__RemoveFromTarget_b__0_Internal_Boolean_HitFlash_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HitFlashSystem.__c__DisplayClass9_0>.NativeClassPtr, 100668273);
    }

    public __c__DisplayClass9_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Entity entity
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HitFlashSystem.__c__DisplayClass9_0.NativeFieldInfoPtr_entity));
        return pointer == System.IntPtr.Zero ? (Entity) null : new Entity(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HitFlashSystem.__c__DisplayClass9_0.NativeFieldInfoPtr_entity), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
