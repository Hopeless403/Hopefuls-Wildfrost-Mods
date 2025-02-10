// Decompiled with JetBrains decompiler
// Type: SpeechBubbleSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class SpeechBubbleSystem : GameSystem
{
  private static readonly System.IntPtr NativeFieldInfoPtr_instance;
  private static readonly System.IntPtr NativeFieldInfoPtr_OnCreate;
  private static readonly System.IntPtr NativeFieldInfoPtr_bubblePrefab;
  private static readonly System.IntPtr NativeFieldInfoPtr_wordToDurationCurve;
  private static readonly System.IntPtr NativeFieldInfoPtr_durationFactor;
  private static readonly System.IntPtr NativeFieldInfoPtr_spawnPoints;
  private static readonly System.IntPtr NativeFieldInfoPtr_queue;
  private static readonly System.IntPtr NativeFieldInfoPtr_current;
  private static readonly System.IntPtr NativeMethodInfoPtr_add_OnCreate_Public_Static_add_Void_NotifyCreate_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_remove_OnCreate_Public_Static_rem_Void_NotifyCreate_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_Void_SpeechBubbleData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_QueueBubble_Private_Void_SpeechBubbleData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateBubble_Private_Void_SpeechBubbleData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateBubbleAfter_Private_IEnumerator_SpeechBubbleData_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetDuration_Public_Static_Single_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddSpawnPoint_Public_Void_SpeechBubbleSpawn_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RemoveSpawnPoint_Public_Void_SpeechBubbleSpawn_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74773, XrefRangeEnd = 74780, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  [SpecialName]
  public static unsafe void add_OnCreate(SpeechBubbleSystem.NotifyCreate value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SpeechBubbleSystem.NativeMethodInfoPtr_add_OnCreate_Public_Static_add_Void_NotifyCreate_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74780, XrefRangeEnd = 74787, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  [SpecialName]
  public static unsafe void remove_OnCreate(SpeechBubbleSystem.NotifyCreate value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SpeechBubbleSystem.NativeMethodInfoPtr_remove_OnCreate_Public_Static_rem_Void_NotifyCreate_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 74789, RefRangeEnd = 74790, XrefRangeStart = 74787, XrefRangeEnd = 74789, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Create(SpeechBubbleData data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SpeechBubbleSystem.NativeMethodInfoPtr_Create_Public_Static_Void_SpeechBubbleData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74790, XrefRangeEnd = 74821, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SpeechBubbleSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74821, XrefRangeEnd = 74837, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SpeechBubbleSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74837, XrefRangeEnd = 74850, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SpeechBubbleSystem.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74850, XrefRangeEnd = 74854, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void QueueBubble(SpeechBubbleData data)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SpeechBubbleSystem.NativeMethodInfoPtr_QueueBubble_Private_Void_SpeechBubbleData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 74867, RefRangeEnd = 74868, XrefRangeStart = 74854, XrefRangeEnd = 74867, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CreateBubble(SpeechBubbleData data)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SpeechBubbleSystem.NativeMethodInfoPtr_CreateBubble_Private_Void_SpeechBubbleData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74868, XrefRangeEnd = 74874, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator CreateBubbleAfter(SpeechBubbleData data, float delay)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &delay;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpeechBubbleSystem.NativeMethodInfoPtr_CreateBubbleAfter_Private_IEnumerator_SpeechBubbleData_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74874, XrefRangeEnd = 74882, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float GetDuration(string text)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(text)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpeechBubbleSystem.NativeMethodInfoPtr_GetDuration_Public_Static_Single_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 74886, RefRangeEnd = 74887, XrefRangeStart = 74882, XrefRangeEnd = 74886, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AddSpawnPoint(SpeechBubbleSpawn spawnPoint)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) spawnPoint)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SpeechBubbleSystem.NativeMethodInfoPtr_AddSpawnPoint_Public_Void_SpeechBubbleSpawn_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 74891, RefRangeEnd = 74892, XrefRangeStart = 74887, XrefRangeEnd = 74891, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RemoveSpawnPoint(SpeechBubbleSpawn spawnPoint)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) spawnPoint)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SpeechBubbleSystem.NativeMethodInfoPtr_RemoveSpawnPoint_Public_Void_SpeechBubbleSpawn_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74892, XrefRangeEnd = 74893, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SpeechBubbleSystem()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpeechBubbleSystem>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SpeechBubbleSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static SpeechBubbleSystem()
  {
    Il2CppClassPointerStore<SpeechBubbleSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (SpeechBubbleSystem));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpeechBubbleSystem>.NativeClassPtr);
    SpeechBubbleSystem.NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpeechBubbleSystem>.NativeClassPtr, nameof (instance));
    SpeechBubbleSystem.NativeFieldInfoPtr_OnCreate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpeechBubbleSystem>.NativeClassPtr, nameof (OnCreate));
    SpeechBubbleSystem.NativeFieldInfoPtr_bubblePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpeechBubbleSystem>.NativeClassPtr, nameof (bubblePrefab));
    SpeechBubbleSystem.NativeFieldInfoPtr_wordToDurationCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpeechBubbleSystem>.NativeClassPtr, nameof (wordToDurationCurve));
    SpeechBubbleSystem.NativeFieldInfoPtr_durationFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpeechBubbleSystem>.NativeClassPtr, nameof (durationFactor));
    SpeechBubbleSystem.NativeFieldInfoPtr_spawnPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpeechBubbleSystem>.NativeClassPtr, nameof (spawnPoints));
    SpeechBubbleSystem.NativeFieldInfoPtr_queue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpeechBubbleSystem>.NativeClassPtr, nameof (queue));
    SpeechBubbleSystem.NativeFieldInfoPtr_current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpeechBubbleSystem>.NativeClassPtr, nameof (current));
    SpeechBubbleSystem.NativeMethodInfoPtr_add_OnCreate_Public_Static_add_Void_NotifyCreate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeechBubbleSystem>.NativeClassPtr, 100669318);
    SpeechBubbleSystem.NativeMethodInfoPtr_remove_OnCreate_Public_Static_rem_Void_NotifyCreate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeechBubbleSystem>.NativeClassPtr, 100669319);
    SpeechBubbleSystem.NativeMethodInfoPtr_Create_Public_Static_Void_SpeechBubbleData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeechBubbleSystem>.NativeClassPtr, 100669320);
    SpeechBubbleSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeechBubbleSystem>.NativeClassPtr, 100669321);
    SpeechBubbleSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeechBubbleSystem>.NativeClassPtr, 100669322);
    SpeechBubbleSystem.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeechBubbleSystem>.NativeClassPtr, 100669323);
    SpeechBubbleSystem.NativeMethodInfoPtr_QueueBubble_Private_Void_SpeechBubbleData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeechBubbleSystem>.NativeClassPtr, 100669324);
    SpeechBubbleSystem.NativeMethodInfoPtr_CreateBubble_Private_Void_SpeechBubbleData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeechBubbleSystem>.NativeClassPtr, 100669325);
    SpeechBubbleSystem.NativeMethodInfoPtr_CreateBubbleAfter_Private_IEnumerator_SpeechBubbleData_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeechBubbleSystem>.NativeClassPtr, 100669326);
    SpeechBubbleSystem.NativeMethodInfoPtr_GetDuration_Public_Static_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeechBubbleSystem>.NativeClassPtr, 100669327);
    SpeechBubbleSystem.NativeMethodInfoPtr_AddSpawnPoint_Public_Void_SpeechBubbleSpawn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeechBubbleSystem>.NativeClassPtr, 100669328);
    SpeechBubbleSystem.NativeMethodInfoPtr_RemoveSpawnPoint_Public_Void_SpeechBubbleSpawn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeechBubbleSystem>.NativeClassPtr, 100669329);
    SpeechBubbleSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeechBubbleSystem>.NativeClassPtr, 100669330);
  }

  public SpeechBubbleSystem(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe SpeechBubbleSystem instance
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(SpeechBubbleSystem.NativeFieldInfoPtr_instance, (void*) &num);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (SpeechBubbleSystem) null : new SpeechBubbleSystem(pointer);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SpeechBubbleSystem.NativeFieldInfoPtr_instance, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe SpeechBubbleSystem.NotifyCreate OnCreate
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(SpeechBubbleSystem.NativeFieldInfoPtr_OnCreate, (void*) &num);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (SpeechBubbleSystem.NotifyCreate) null : new SpeechBubbleSystem.NotifyCreate(pointer);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SpeechBubbleSystem.NativeFieldInfoPtr_OnCreate, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe SpeechBub bubblePrefab
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpeechBubbleSystem.NativeFieldInfoPtr_bubblePrefab));
      return pointer == System.IntPtr.Zero ? (SpeechBub) null : new SpeechBub(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpeechBubbleSystem.NativeFieldInfoPtr_bubblePrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe AnimationCurve wordToDurationCurve
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpeechBubbleSystem.NativeFieldInfoPtr_wordToDurationCurve));
      return pointer == System.IntPtr.Zero ? (AnimationCurve) null : new AnimationCurve(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpeechBubbleSystem.NativeFieldInfoPtr_wordToDurationCurve), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float durationFactor
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpeechBubbleSystem.NativeFieldInfoPtr_durationFactor));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpeechBubbleSystem.NativeFieldInfoPtr_durationFactor)) = value;
    }
  }

  public unsafe List<SpeechBubbleSpawn> spawnPoints
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpeechBubbleSystem.NativeFieldInfoPtr_spawnPoints));
      return pointer == System.IntPtr.Zero ? (List<SpeechBubbleSpawn>) null : new List<SpeechBubbleSpawn>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpeechBubbleSystem.NativeFieldInfoPtr_spawnPoints), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<SpeechBubbleData> queue
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpeechBubbleSystem.NativeFieldInfoPtr_queue));
      return pointer == System.IntPtr.Zero ? (List<SpeechBubbleData>) null : new List<SpeechBubbleData>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpeechBubbleSystem.NativeFieldInfoPtr_queue), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe SpeechBub current
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpeechBubbleSystem.NativeFieldInfoPtr_current));
      return pointer == System.IntPtr.Zero ? (SpeechBub) null : new SpeechBub(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpeechBubbleSystem.NativeFieldInfoPtr_current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public sealed class NotifyCreate : Il2CppSystem.MulticastDelegate
  {
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_SpeechBubbleData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_SpeechBubbleData_AsyncCallback_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

    [CallerCount(200)]
    [CachedScanResults(RefRangeStart = 74558, RefRangeEnd = 74758, XrefRangeStart = 74546, XrefRangeEnd = 74558, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe NotifyCreate(Il2CppSystem.Object @object, System.IntPtr method)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpeechBubbleSystem.NotifyCreate>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SpeechBubbleSystem.NotifyCreate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public virtual unsafe void Invoke(SpeechBubbleData data)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SpeechBubbleSystem.NotifyCreate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_SpeechBubbleData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 74759, RefRangeEnd = 74762, XrefRangeStart = 74758, XrefRangeEnd = 74759, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
      SpeechBubbleData data,
      Il2CppSystem.AsyncCallback callback,
      Il2CppSystem.Object @object)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpeechBubbleSystem.NotifyCreate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_SpeechBubbleData_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 67136, RefRangeEnd = 67137, XrefRangeStart = 67136, XrefRangeEnd = 67137, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void EndInvoke(Il2CppSystem.IAsyncResult result)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) result)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SpeechBubbleSystem.NotifyCreate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static NotifyCreate()
    {
      Il2CppClassPointerStore<SpeechBubbleSystem.NotifyCreate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpeechBubbleSystem>.NativeClassPtr, nameof (NotifyCreate));
      SpeechBubbleSystem.NotifyCreate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeechBubbleSystem.NotifyCreate>.NativeClassPtr, 100669331);
      SpeechBubbleSystem.NotifyCreate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_SpeechBubbleData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeechBubbleSystem.NotifyCreate>.NativeClassPtr, 100669332);
      SpeechBubbleSystem.NotifyCreate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_SpeechBubbleData_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeechBubbleSystem.NotifyCreate>.NativeClassPtr, 100669333);
      SpeechBubbleSystem.NotifyCreate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeechBubbleSystem.NotifyCreate>.NativeClassPtr, 100669334);
    }

    public NotifyCreate(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static implicit operator SpeechBubbleSystem.NotifyCreate([In] System.Action<SpeechBubbleData> obj0)
    {
      return DelegateSupport.ConvertDelegate<SpeechBubbleSystem.NotifyCreate>((System.Delegate) obj0);
    }

    public static SpeechBubbleSystem.NotifyCreate operator +(
      [In] SpeechBubbleSystem.NotifyCreate obj0,
      [In] SpeechBubbleSystem.NotifyCreate obj1)
    {
      return Il2CppSystem.Delegate.Combine((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1).Cast<SpeechBubbleSystem.NotifyCreate>();
    }

    public static SpeechBubbleSystem.NotifyCreate operator -(
      [In] SpeechBubbleSystem.NotifyCreate obj0,
      [In] SpeechBubbleSystem.NotifyCreate obj1)
    {
      Il2CppSystem.Delegate @delegate = Il2CppSystem.Delegate.Remove((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1);
      return (object) @delegate == null ? (SpeechBubbleSystem.NotifyCreate) @delegate : @delegate.Cast<SpeechBubbleSystem.NotifyCreate>();
    }
  }

  [ObfuscatedName("SpeechBubbleSystem/<CreateBubbleAfter>d__17")]
  public sealed class _CreateBubbleAfter_d__17 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr_delay;
    private static readonly System.IntPtr NativeFieldInfoPtr_data;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    [CallerCount(53)]
    [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _CreateBubbleAfter_d__17(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpeechBubbleSystem._CreateBubbleAfter_d__17>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SpeechBubbleSystem._CreateBubbleAfter_d__17.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(12611)]
    [CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12665, XrefRangeStart = 54, XrefRangeEnd = 12665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SpeechBubbleSystem._CreateBubbleAfter_d__17.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74762, XrefRangeEnd = 74767, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpeechBubbleSystem._CreateBubbleAfter_d__17.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EGeneric\u002EIEnumerator\u003CSystem\u002EObject\u003E\u002ECurrent
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpeechBubbleSystem._CreateBubbleAfter_d__17.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74767, XrefRangeEnd = 74773, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SpeechBubbleSystem._CreateBubbleAfter_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpeechBubbleSystem._CreateBubbleAfter_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    static _CreateBubbleAfter_d__17()
    {
      Il2CppClassPointerStore<SpeechBubbleSystem._CreateBubbleAfter_d__17>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpeechBubbleSystem>.NativeClassPtr, "<CreateBubbleAfter>d__17");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpeechBubbleSystem._CreateBubbleAfter_d__17>.NativeClassPtr);
      SpeechBubbleSystem._CreateBubbleAfter_d__17.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpeechBubbleSystem._CreateBubbleAfter_d__17>.NativeClassPtr, "<>1__state");
      SpeechBubbleSystem._CreateBubbleAfter_d__17.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpeechBubbleSystem._CreateBubbleAfter_d__17>.NativeClassPtr, "<>2__current");
      SpeechBubbleSystem._CreateBubbleAfter_d__17.NativeFieldInfoPtr_delay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpeechBubbleSystem._CreateBubbleAfter_d__17>.NativeClassPtr, nameof (delay));
      SpeechBubbleSystem._CreateBubbleAfter_d__17.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpeechBubbleSystem._CreateBubbleAfter_d__17>.NativeClassPtr, nameof (data));
      SpeechBubbleSystem._CreateBubbleAfter_d__17.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpeechBubbleSystem._CreateBubbleAfter_d__17>.NativeClassPtr, "<>4__this");
      SpeechBubbleSystem._CreateBubbleAfter_d__17.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeechBubbleSystem._CreateBubbleAfter_d__17>.NativeClassPtr, 100669335);
      SpeechBubbleSystem._CreateBubbleAfter_d__17.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeechBubbleSystem._CreateBubbleAfter_d__17>.NativeClassPtr, 100669336);
      SpeechBubbleSystem._CreateBubbleAfter_d__17.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeechBubbleSystem._CreateBubbleAfter_d__17>.NativeClassPtr, 100669337);
      SpeechBubbleSystem._CreateBubbleAfter_d__17.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeechBubbleSystem._CreateBubbleAfter_d__17>.NativeClassPtr, 100669338);
      SpeechBubbleSystem._CreateBubbleAfter_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeechBubbleSystem._CreateBubbleAfter_d__17>.NativeClassPtr, 100669339);
      SpeechBubbleSystem._CreateBubbleAfter_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeechBubbleSystem._CreateBubbleAfter_d__17>.NativeClassPtr, 100669340);
    }

    public _CreateBubbleAfter_d__17(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpeechBubbleSystem._CreateBubbleAfter_d__17.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpeechBubbleSystem._CreateBubbleAfter_d__17.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpeechBubbleSystem._CreateBubbleAfter_d__17.NativeFieldInfoPtr___2__current));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpeechBubbleSystem._CreateBubbleAfter_d__17.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float delay
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpeechBubbleSystem._CreateBubbleAfter_d__17.NativeFieldInfoPtr_delay));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpeechBubbleSystem._CreateBubbleAfter_d__17.NativeFieldInfoPtr_delay)) = value;
      }
    }

    public unsafe SpeechBubbleData data
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpeechBubbleSystem._CreateBubbleAfter_d__17.NativeFieldInfoPtr_data));
        return pointer == System.IntPtr.Zero ? (SpeechBubbleData) null : new SpeechBubbleData(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpeechBubbleSystem._CreateBubbleAfter_d__17.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SpeechBubbleSystem __4__this
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpeechBubbleSystem._CreateBubbleAfter_d__17.NativeFieldInfoPtr___4__this));
        return pointer == System.IntPtr.Zero ? (SpeechBubbleSystem) null : new SpeechBubbleSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpeechBubbleSystem._CreateBubbleAfter_d__17.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
