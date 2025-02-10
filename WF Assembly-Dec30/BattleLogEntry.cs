// Decompiled with JetBrains decompiler
// Type: BattleLogEntry
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading.Tasks;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;

#nullable disable
public class BattleLogEntry : MonoBehaviour
{
  private static readonly System.IntPtr NativeFieldInfoPtr_textElement;
  private static readonly System.IntPtr NativeFieldInfoPtr_colorFriendly;
  private static readonly System.IntPtr NativeFieldInfoPtr_colorEnemy;
  private static readonly System.IntPtr NativeFieldInfoPtr_colorNumber;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetUp_Public_Task_BattleLog_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddInserts_Private_Static_String_String_Il2CppReferenceArray_1_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetEntityName_Private_Static_String_BattleEntity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FormatLogText_Private_Static_String_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86658, XrefRangeEnd = 86669, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Task SetUp(BattleLog log)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) log))
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BattleLogEntry.NativeMethodInfoPtr_SetUp_Public_Task_BattleLog_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (Task) null : new Task(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 86710, RefRangeEnd = 86711, XrefRangeStart = 86669, XrefRangeEnd = 86710, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string AddInserts(string text, Il2CppReferenceArray<Il2CppSystem.Object> inserts)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(text);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) inserts);
    System.IntPtr exc;
    System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(BattleLogEntry.NativeMethodInfoPtr_AddInserts_Private_Static_String_String_Il2CppReferenceArray_1_Object_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return IL2CPP.Il2CppStringToManaged(il2CppString);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86711, XrefRangeEnd = 86713, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string GetEntityName(BattleEntity entity)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) entity))
    };
    System.IntPtr exc;
    System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(BattleLogEntry.NativeMethodInfoPtr_GetEntityName_Private_Static_String_BattleEntity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return IL2CPP.Il2CppStringToManaged(il2CppString);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 86724, RefRangeEnd = 86726, XrefRangeStart = 86713, XrefRangeEnd = 86724, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string FormatLogText(string text)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(text)
    };
    System.IntPtr exc;
    System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(BattleLogEntry.NativeMethodInfoPtr_FormatLogText_Private_Static_String_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return IL2CPP.Il2CppStringToManaged(il2CppString);
  }

  [CallerCount(212)]
  [CachedScanResults(RefRangeStart = 12749, RefRangeEnd = 12961, XrefRangeStart = 12749, XrefRangeEnd = 12961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe BattleLogEntry()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BattleLogEntry>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BattleLogEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static BattleLogEntry()
  {
    Il2CppClassPointerStore<BattleLogEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (BattleLogEntry));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BattleLogEntry>.NativeClassPtr);
    BattleLogEntry.NativeFieldInfoPtr_textElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleLogEntry>.NativeClassPtr, nameof (textElement));
    BattleLogEntry.NativeFieldInfoPtr_colorFriendly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleLogEntry>.NativeClassPtr, nameof (colorFriendly));
    BattleLogEntry.NativeFieldInfoPtr_colorEnemy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleLogEntry>.NativeClassPtr, nameof (colorEnemy));
    BattleLogEntry.NativeFieldInfoPtr_colorNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleLogEntry>.NativeClassPtr, nameof (colorNumber));
    BattleLogEntry.NativeMethodInfoPtr_SetUp_Public_Task_BattleLog_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleLogEntry>.NativeClassPtr, 100670598);
    BattleLogEntry.NativeMethodInfoPtr_AddInserts_Private_Static_String_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleLogEntry>.NativeClassPtr, 100670599);
    BattleLogEntry.NativeMethodInfoPtr_GetEntityName_Private_Static_String_BattleEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleLogEntry>.NativeClassPtr, 100670600);
    BattleLogEntry.NativeMethodInfoPtr_FormatLogText_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleLogEntry>.NativeClassPtr, 100670601);
    BattleLogEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleLogEntry>.NativeClassPtr, 100670602);
  }

  public BattleLogEntry(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe TMP_Text textElement
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogEntry.NativeFieldInfoPtr_textElement));
      return pointer == System.IntPtr.Zero ? (TMP_Text) null : new TMP_Text(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleLogEntry.NativeFieldInfoPtr_textElement), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe string colorFriendly
  {
    get
    {
      System.IntPtr il2CppString;
      IL2CPP.il2cpp_field_static_get_value(BattleLogEntry.NativeFieldInfoPtr_colorFriendly, (void*) &il2CppString);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(BattleLogEntry.NativeFieldInfoPtr_colorFriendly, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string colorEnemy
  {
    get
    {
      System.IntPtr il2CppString;
      IL2CPP.il2cpp_field_static_get_value(BattleLogEntry.NativeFieldInfoPtr_colorEnemy, (void*) &il2CppString);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(BattleLogEntry.NativeFieldInfoPtr_colorEnemy, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string colorNumber
  {
    get
    {
      System.IntPtr il2CppString;
      IL2CPP.il2cpp_field_static_get_value(BattleLogEntry.NativeFieldInfoPtr_colorNumber, (void*) &il2CppString);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(BattleLogEntry.NativeFieldInfoPtr_colorNumber, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  [ObfuscatedName("BattleLogEntry/<SetUp>d__4")]
  public sealed class _SetUp_d__4 : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;
    private static readonly System.IntPtr NativeFieldInfoPtr_log;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr___u__1;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86640, XrefRangeEnd = 86658, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BattleLogEntry._SetUp_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stateMachine)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BattleLogEntry._SetUp_d__4.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static _SetUp_d__4()
    {
      Il2CppClassPointerStore<BattleLogEntry._SetUp_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BattleLogEntry>.NativeClassPtr, "<SetUp>d__4");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BattleLogEntry._SetUp_d__4>.NativeClassPtr);
      BattleLogEntry._SetUp_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleLogEntry._SetUp_d__4>.NativeClassPtr, "<>1__state");
      BattleLogEntry._SetUp_d__4.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleLogEntry._SetUp_d__4>.NativeClassPtr, "<>t__builder");
      BattleLogEntry._SetUp_d__4.NativeFieldInfoPtr_log = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleLogEntry._SetUp_d__4>.NativeClassPtr, nameof (log));
      BattleLogEntry._SetUp_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleLogEntry._SetUp_d__4>.NativeClassPtr, "<>4__this");
      BattleLogEntry._SetUp_d__4.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleLogEntry._SetUp_d__4>.NativeClassPtr, "<>u__1");
      BattleLogEntry._SetUp_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleLogEntry._SetUp_d__4>.NativeClassPtr, 100670603);
      BattleLogEntry._SetUp_d__4.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleLogEntry._SetUp_d__4>.NativeClassPtr, 100670604);
    }

    public _SetUp_d__4(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public _SetUp_d__4()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BattleLogEntry._SetUp_d__4>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BattleLogEntry._SetUp_d__4>.NativeClassPtr, data));
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogEntry._SetUp_d__4.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogEntry._SetUp_d__4.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public AsyncTaskMethodBuilder __t__builder
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogEntry._SetUp_d__4.NativeFieldInfoPtr___t__builder);
        return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogEntry._SetUp_d__4.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public BattleLog log
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogEntry._SetUp_d__4.NativeFieldInfoPtr_log);
        return new BattleLog(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BattleLog>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogEntry._SetUp_d__4.NativeFieldInfoPtr_log), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BattleLog>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe BattleLogEntry __4__this
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogEntry._SetUp_d__4.NativeFieldInfoPtr___4__this));
        return pointer == System.IntPtr.Zero ? (BattleLogEntry) null : new BattleLogEntry(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleLogEntry._SetUp_d__4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public TaskAwaiter<string> __u__1
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogEntry._SetUp_d__4.NativeFieldInfoPtr___u__1);
        return new TaskAwaiter<string>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter<string>>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleLogEntry._SetUp_d__4.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter<string>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }
}
