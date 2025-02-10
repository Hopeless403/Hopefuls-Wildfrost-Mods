// Decompiled with JetBrains decompiler
// Type: CoroutineManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class CoroutineManager : MonoBehaviour
{
  private static readonly System.IntPtr NativeFieldInfoPtr_instance;
  private static readonly System.IntPtr NativeMethodInfoPtr_InstanceCheck_Private_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_State_IEnumerator_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Start_Public_Static_Void_IEnumerator_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 128031, RefRangeEnd = 128034, XrefRangeStart = 128003, XrefRangeEnd = 128031, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void InstanceCheck()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CoroutineManager.NativeMethodInfoPtr_InstanceCheck_Private_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128034, XrefRangeEnd = 128040, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe CoroutineManager.State Create(IEnumerator coroutine)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) coroutine)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CoroutineManager.NativeMethodInfoPtr_Create_Public_Static_State_IEnumerator_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (CoroutineManager.State) null : new CoroutineManager.State(pointer);
  }

  [CallerCount(7)]
  [CachedScanResults(RefRangeStart = 128045, RefRangeEnd = 128052, XrefRangeStart = 128040, XrefRangeEnd = 128045, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Start(IEnumerator coroutine)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) coroutine)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CoroutineManager.NativeMethodInfoPtr_Start_Public_Static_Void_IEnumerator_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(212)]
  [CachedScanResults(RefRangeStart = 12749, RefRangeEnd = 12961, XrefRangeStart = 12749, XrefRangeEnd = 12961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CoroutineManager()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CoroutineManager>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CoroutineManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static CoroutineManager()
  {
    Il2CppClassPointerStore<CoroutineManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (CoroutineManager));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CoroutineManager>.NativeClassPtr);
    CoroutineManager.NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoroutineManager>.NativeClassPtr, nameof (instance));
    CoroutineManager.NativeMethodInfoPtr_InstanceCheck_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoroutineManager>.NativeClassPtr, 100676526);
    CoroutineManager.NativeMethodInfoPtr_Create_Public_Static_State_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoroutineManager>.NativeClassPtr, 100676527);
    CoroutineManager.NativeMethodInfoPtr_Start_Public_Static_Void_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoroutineManager>.NativeClassPtr, 100676528);
    CoroutineManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoroutineManager>.NativeClassPtr, 100676529);
  }

  public CoroutineManager(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe CoroutineManager instance
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(CoroutineManager.NativeFieldInfoPtr_instance, (void*) &num);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (CoroutineManager) null : new CoroutineManager(pointer);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CoroutineManager.NativeFieldInfoPtr_instance, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public class State : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Finished;
    private static readonly System.IntPtr NativeFieldInfoPtr_coroutine;
    private static readonly System.IntPtr NativeFieldInfoPtr_running;
    private static readonly System.IntPtr NativeFieldInfoPtr_paused;
    private static readonly System.IntPtr NativeFieldInfoPtr_stopped;
    private static readonly System.IntPtr NativeMethodInfoPtr_add_Finished_Public_add_Void_FinishedHandler_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_remove_Finished_Public_rem_Void_FinishedHandler_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_IsRunning_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_IsPaused_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_IEnumerator_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Pause_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Unpause_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Start_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Stop_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CallWrapper_Private_IEnumerator_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127981, XrefRangeEnd = 127985, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    [SpecialName]
    public unsafe void add_Finished(CoroutineManager.State.FinishedHandler value)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CoroutineManager.State.NativeMethodInfoPtr_add_Finished_Public_add_Void_FinishedHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127985, XrefRangeEnd = 127989, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    [SpecialName]
    public unsafe void remove_Finished(CoroutineManager.State.FinishedHandler value)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CoroutineManager.State.NativeMethodInfoPtr_remove_Finished_Public_rem_Void_FinishedHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public unsafe bool IsRunning
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CoroutineManager.State.NativeMethodInfoPtr_get_IsRunning_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe bool IsPaused
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CoroutineManager.State.NativeMethodInfoPtr_get_IsPaused_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 77793, RefRangeEnd = 77796, XrefRangeStart = 77793, XrefRangeEnd = 77796, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe State(IEnumerator coroutine)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CoroutineManager.State>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) coroutine)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CoroutineManager.State.NativeMethodInfoPtr__ctor_Public_Void_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe void Pause()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CoroutineManager.State.NativeMethodInfoPtr_Pause_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe void Unpause()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CoroutineManager.State.NativeMethodInfoPtr_Unpause_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127989, XrefRangeEnd = 127998, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Start()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CoroutineManager.State.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe void Stop()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CoroutineManager.State.NativeMethodInfoPtr_Stop_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127998, XrefRangeEnd = 128003, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe IEnumerator CallWrapper()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CoroutineManager.State.NativeMethodInfoPtr_CallWrapper_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
    }

    static State()
    {
      Il2CppClassPointerStore<CoroutineManager.State>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CoroutineManager>.NativeClassPtr, nameof (State));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CoroutineManager.State>.NativeClassPtr);
      CoroutineManager.State.NativeFieldInfoPtr_Finished = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoroutineManager.State>.NativeClassPtr, nameof (Finished));
      CoroutineManager.State.NativeFieldInfoPtr_coroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoroutineManager.State>.NativeClassPtr, nameof (coroutine));
      CoroutineManager.State.NativeFieldInfoPtr_running = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoroutineManager.State>.NativeClassPtr, nameof (running));
      CoroutineManager.State.NativeFieldInfoPtr_paused = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoroutineManager.State>.NativeClassPtr, nameof (paused));
      CoroutineManager.State.NativeFieldInfoPtr_stopped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoroutineManager.State>.NativeClassPtr, nameof (stopped));
      CoroutineManager.State.NativeMethodInfoPtr_add_Finished_Public_add_Void_FinishedHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoroutineManager.State>.NativeClassPtr, 100676530);
      CoroutineManager.State.NativeMethodInfoPtr_remove_Finished_Public_rem_Void_FinishedHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoroutineManager.State>.NativeClassPtr, 100676531);
      CoroutineManager.State.NativeMethodInfoPtr_get_IsRunning_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoroutineManager.State>.NativeClassPtr, 100676532);
      CoroutineManager.State.NativeMethodInfoPtr_get_IsPaused_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoroutineManager.State>.NativeClassPtr, 100676533);
      CoroutineManager.State.NativeMethodInfoPtr__ctor_Public_Void_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoroutineManager.State>.NativeClassPtr, 100676534);
      CoroutineManager.State.NativeMethodInfoPtr_Pause_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoroutineManager.State>.NativeClassPtr, 100676535);
      CoroutineManager.State.NativeMethodInfoPtr_Unpause_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoroutineManager.State>.NativeClassPtr, 100676536);
      CoroutineManager.State.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoroutineManager.State>.NativeClassPtr, 100676537);
      CoroutineManager.State.NativeMethodInfoPtr_Stop_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoroutineManager.State>.NativeClassPtr, 100676538);
      CoroutineManager.State.NativeMethodInfoPtr_CallWrapper_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoroutineManager.State>.NativeClassPtr, 100676539);
    }

    public State(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe CoroutineManager.State.FinishedHandler Finished
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CoroutineManager.State.NativeFieldInfoPtr_Finished));
        return pointer == System.IntPtr.Zero ? (CoroutineManager.State.FinishedHandler) null : new CoroutineManager.State.FinishedHandler(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CoroutineManager.State.NativeFieldInfoPtr_Finished), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe IEnumerator coroutine
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CoroutineManager.State.NativeFieldInfoPtr_coroutine));
        return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CoroutineManager.State.NativeFieldInfoPtr_coroutine), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool running
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CoroutineManager.State.NativeFieldInfoPtr_running));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CoroutineManager.State.NativeFieldInfoPtr_running)) = value;
      }
    }

    public unsafe bool paused
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CoroutineManager.State.NativeFieldInfoPtr_paused));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CoroutineManager.State.NativeFieldInfoPtr_paused)) = value;
      }
    }

    public unsafe bool stopped
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CoroutineManager.State.NativeFieldInfoPtr_stopped));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CoroutineManager.State.NativeFieldInfoPtr_stopped)) = value;
      }
    }

    public sealed class FinishedHandler : Il2CppSystem.MulticastDelegate
    {
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Boolean_AsyncCallback_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

      [CallerCount(85)]
      [CachedScanResults(RefRangeStart = 127877, RefRangeEnd = 127962, XrefRangeStart = 127871, XrefRangeEnd = 127877, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe FinishedHandler(Il2CppSystem.Object @object, System.IntPtr method)
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CoroutineManager.State.FinishedHandler>.NativeClassPtr))
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CoroutineManager.State.FinishedHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public virtual unsafe void Invoke(bool manualStop)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &manualStop
        };
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CoroutineManager.State.FinishedHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127962, XrefRangeEnd = 127966, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
        bool manualStop,
        Il2CppSystem.AsyncCallback callback,
        Il2CppSystem.Object @object)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &manualStop;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CoroutineManager.State.FinishedHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Boolean_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        IL2CPP.il2cpp_runtime_invoke(CoroutineManager.State.FinishedHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static FinishedHandler()
      {
        Il2CppClassPointerStore<CoroutineManager.State.FinishedHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CoroutineManager.State>.NativeClassPtr, nameof (FinishedHandler));
        CoroutineManager.State.FinishedHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoroutineManager.State.FinishedHandler>.NativeClassPtr, 100676540);
        CoroutineManager.State.FinishedHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoroutineManager.State.FinishedHandler>.NativeClassPtr, 100676541);
        CoroutineManager.State.FinishedHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Boolean_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoroutineManager.State.FinishedHandler>.NativeClassPtr, 100676542);
        CoroutineManager.State.FinishedHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoroutineManager.State.FinishedHandler>.NativeClassPtr, 100676543);
      }

      public FinishedHandler(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static implicit operator CoroutineManager.State.FinishedHandler([In] System.Action<bool> obj0)
      {
        return DelegateSupport.ConvertDelegate<CoroutineManager.State.FinishedHandler>((System.Delegate) obj0);
      }

      public static CoroutineManager.State.FinishedHandler operator +(
        [In] CoroutineManager.State.FinishedHandler obj0,
        [In] CoroutineManager.State.FinishedHandler obj1)
      {
        return Il2CppSystem.Delegate.Combine((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1).Cast<CoroutineManager.State.FinishedHandler>();
      }

      public static CoroutineManager.State.FinishedHandler operator -(
        [In] CoroutineManager.State.FinishedHandler obj0,
        [In] CoroutineManager.State.FinishedHandler obj1)
      {
        Il2CppSystem.Delegate @delegate = Il2CppSystem.Delegate.Remove((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1);
        return (object) @delegate == null ? (CoroutineManager.State.FinishedHandler) @delegate : @delegate.Cast<CoroutineManager.State.FinishedHandler>();
      }
    }

    [ObfuscatedName("CoroutineManager/State/<CallWrapper>d__17")]
    public sealed class _CallWrapper_d__17 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
      private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr__e_5__2;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

      [CallerCount(53)]
      [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe _CallWrapper_d__17(int _param1)
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CoroutineManager.State._CallWrapper_d__17>.NativeClassPtr))
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &_param1
        };
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CoroutineManager.State._CallWrapper_d__17.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(12611)]
      [CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12665, XrefRangeStart = 54, XrefRangeEnd = 12665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void System_IDisposable_Dispose()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CoroutineManager.State._CallWrapper_d__17.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127966, XrefRangeEnd = 127975, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool MoveNext()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CoroutineManager.State._CallWrapper_d__17.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CoroutineManager.State._CallWrapper_d__17.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
        }
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127975, XrefRangeEnd = 127981, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void System_Collections_IEnumerator_Reset()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CoroutineManager.State._CallWrapper_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
      {
        [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CoroutineManager.State._CallWrapper_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
        }
      }

      static _CallWrapper_d__17()
      {
        Il2CppClassPointerStore<CoroutineManager.State._CallWrapper_d__17>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CoroutineManager.State>.NativeClassPtr, "<CallWrapper>d__17");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CoroutineManager.State._CallWrapper_d__17>.NativeClassPtr);
        CoroutineManager.State._CallWrapper_d__17.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoroutineManager.State._CallWrapper_d__17>.NativeClassPtr, "<>1__state");
        CoroutineManager.State._CallWrapper_d__17.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoroutineManager.State._CallWrapper_d__17>.NativeClassPtr, "<>2__current");
        CoroutineManager.State._CallWrapper_d__17.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoroutineManager.State._CallWrapper_d__17>.NativeClassPtr, "<>4__this");
        CoroutineManager.State._CallWrapper_d__17.NativeFieldInfoPtr__e_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoroutineManager.State._CallWrapper_d__17>.NativeClassPtr, "<e>5__2");
        CoroutineManager.State._CallWrapper_d__17.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoroutineManager.State._CallWrapper_d__17>.NativeClassPtr, 100676544);
        CoroutineManager.State._CallWrapper_d__17.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoroutineManager.State._CallWrapper_d__17>.NativeClassPtr, 100676545);
        CoroutineManager.State._CallWrapper_d__17.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoroutineManager.State._CallWrapper_d__17>.NativeClassPtr, 100676546);
        CoroutineManager.State._CallWrapper_d__17.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoroutineManager.State._CallWrapper_d__17>.NativeClassPtr, 100676547);
        CoroutineManager.State._CallWrapper_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoroutineManager.State._CallWrapper_d__17>.NativeClassPtr, 100676548);
        CoroutineManager.State._CallWrapper_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoroutineManager.State._CallWrapper_d__17>.NativeClassPtr, 100676549);
      }

      public _CallWrapper_d__17(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe int __1__state
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CoroutineManager.State._CallWrapper_d__17.NativeFieldInfoPtr___1__state));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CoroutineManager.State._CallWrapper_d__17.NativeFieldInfoPtr___1__state)) = value;
        }
      }

      public unsafe Il2CppSystem.Object __2__current
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CoroutineManager.State._CallWrapper_d__17.NativeFieldInfoPtr___2__current));
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CoroutineManager.State._CallWrapper_d__17.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe CoroutineManager.State __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CoroutineManager.State._CallWrapper_d__17.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (CoroutineManager.State) null : new CoroutineManager.State(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CoroutineManager.State._CallWrapper_d__17.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe IEnumerator _e_5__2
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CoroutineManager.State._CallWrapper_d__17.NativeFieldInfoPtr__e_5__2));
          return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CoroutineManager.State._CallWrapper_d__17.NativeFieldInfoPtr__e_5__2), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
