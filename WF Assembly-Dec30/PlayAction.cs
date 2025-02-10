// Decompiled with JetBrains decompiler
// Type: PlayAction
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections;
using System.Runtime.InteropServices;

#nullable disable
public class PlayAction : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr_pauseBefore;
  private static readonly System.IntPtr NativeFieldInfoPtr_pauseAfter;
  private static readonly System.IntPtr NativeFieldInfoPtr_priority;
  private static readonly System.IntPtr NativeFieldInfoPtr_fixedPosition;
  private static readonly System.IntPtr NativeFieldInfoPtr_parallel;
  private static readonly System.IntPtr NativeFieldInfoPtr_note;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_IsRoutine_Public_Virtual_New_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Process_Public_Virtual_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Run_Public_Virtual_New_IEnumerator_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_New_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

  public virtual unsafe bool IsRoutine
  {
    [CallerCount(14), CachedScanResults(RefRangeStart = 24612, RefRangeEnd = 24626, XrefRangeStart = 24612, XrefRangeEnd = 24626, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PlayAction.NativeMethodInfoPtr_get_IsRoutine_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  [CallerCount(12611)]
  [CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12665, XrefRangeStart = 54, XrefRangeEnd = 12665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Process()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PlayAction.NativeMethodInfoPtr_Process_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(44)]
  [CachedScanResults(RefRangeStart = 26224, RefRangeEnd = 26268, XrefRangeStart = 26224, XrefRangeEnd = 26224, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe IEnumerator Run()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PlayAction.NativeMethodInfoPtr_Run_Public_Virtual_New_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  public virtual unsafe string Name
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26268, XrefRangeEnd = 26280, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PlayAction.NativeMethodInfoPtr_get_Name_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }
  }

  [CallerCount(1959)]
  [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe PlayAction()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayAction>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(PlayAction.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static PlayAction()
  {
    Il2CppClassPointerStore<PlayAction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (PlayAction));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayAction>.NativeClassPtr);
    PlayAction.NativeFieldInfoPtr_pauseBefore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayAction>.NativeClassPtr, nameof (pauseBefore));
    PlayAction.NativeFieldInfoPtr_pauseAfter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayAction>.NativeClassPtr, nameof (pauseAfter));
    PlayAction.NativeFieldInfoPtr_priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayAction>.NativeClassPtr, nameof (priority));
    PlayAction.NativeFieldInfoPtr_fixedPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayAction>.NativeClassPtr, nameof (fixedPosition));
    PlayAction.NativeFieldInfoPtr_parallel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayAction>.NativeClassPtr, nameof (parallel));
    PlayAction.NativeFieldInfoPtr_note = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayAction>.NativeClassPtr, nameof (note));
    PlayAction.NativeMethodInfoPtr_get_IsRoutine_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayAction>.NativeClassPtr, 100664597);
    PlayAction.NativeMethodInfoPtr_Process_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayAction>.NativeClassPtr, 100664598);
    PlayAction.NativeMethodInfoPtr_Run_Public_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayAction>.NativeClassPtr, 100664599);
    PlayAction.NativeMethodInfoPtr_get_Name_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayAction>.NativeClassPtr, 100664600);
    PlayAction.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayAction>.NativeClassPtr, 100664601);
  }

  public PlayAction(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe float pauseBefore
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayAction.NativeFieldInfoPtr_pauseBefore));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayAction.NativeFieldInfoPtr_pauseBefore)) = value;
    }
  }

  public unsafe float pauseAfter
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayAction.NativeFieldInfoPtr_pauseAfter));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayAction.NativeFieldInfoPtr_pauseAfter)) = value;
    }
  }

  public unsafe int priority
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayAction.NativeFieldInfoPtr_priority));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayAction.NativeFieldInfoPtr_priority)) = value;
    }
  }

  public unsafe bool fixedPosition
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayAction.NativeFieldInfoPtr_fixedPosition));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayAction.NativeFieldInfoPtr_fixedPosition)) = value;
    }
  }

  public unsafe bool parallel
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayAction.NativeFieldInfoPtr_parallel));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayAction.NativeFieldInfoPtr_parallel)) = value;
    }
  }

  public unsafe string note
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayAction.NativeFieldInfoPtr_note)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayAction.NativeFieldInfoPtr_note), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }
}
