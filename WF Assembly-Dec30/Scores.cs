// Decompiled with JetBrains decompiler
// Type: Scores
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading.Tasks;
using Steamworks.Data;
using System.Runtime.InteropServices;

#nullable disable
public static class Scores : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeMethodInfoPtr_GetLeaderboardName_Private_Static_String_Type_DateTime_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Submit_Public_Static_Task_1_Nullable_1_LeaderboardUpdate_Type_DateTime_Int32_Il2CppStructArray_1_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetLeaderboard_Public_Static_Task_1_Nullable_1_Leaderboard_Type_DateTime_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetLeaderboard_Private_Static_Task_1_Nullable_1_Leaderboard_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetGlobal_Public_Static_Task_1_Il2CppReferenceArray_1_LeaderboardEntry_Leaderboard_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetFriends_Public_Static_Task_1_Il2CppReferenceArray_1_LeaderboardEntry_Leaderboard_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetAround_Public_Static_Task_1_Il2CppReferenceArray_1_LeaderboardEntry_Leaderboard_Int32_0;

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 116806, RefRangeEnd = 116808, XrefRangeStart = 116803, XrefRangeEnd = 116806, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string GetLeaderboardName(Scores.Type boardType, Il2CppSystem.DateTime date)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &boardType;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &date;
    System.IntPtr exc;
    System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(Scores.NativeMethodInfoPtr_GetLeaderboardName_Private_Static_String_Type_DateTime_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return IL2CPP.Il2CppStringToManaged(il2CppString);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116808, XrefRangeEnd = 116822, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Task<Il2CppSystem.Nullable<LeaderboardUpdate>> Submit(
    Scores.Type type,
    Il2CppSystem.DateTime date,
    int score,
    [Optional] Il2CppStructArray<int> details)
  {
    if (details == null)
      details = new Il2CppStructArray<int>(0L);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &type;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &date;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &score;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) details);
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Scores.NativeMethodInfoPtr_Submit_Public_Static_Task_1_Nullable_1_LeaderboardUpdate_Type_DateTime_Int32_Il2CppStructArray_1_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (Task<Il2CppSystem.Nullable<LeaderboardUpdate>>) null : new Task<Il2CppSystem.Nullable<LeaderboardUpdate>>(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 116835, RefRangeEnd = 116836, XrefRangeStart = 116822, XrefRangeEnd = 116835, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Task<Il2CppSystem.Nullable<Leaderboard>> GetLeaderboard(
    Scores.Type type,
    Il2CppSystem.DateTime date)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &type;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &date;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Scores.NativeMethodInfoPtr_GetLeaderboard_Public_Static_Task_1_Nullable_1_Leaderboard_Type_DateTime_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (Task<Il2CppSystem.Nullable<Leaderboard>>) null : new Task<Il2CppSystem.Nullable<Leaderboard>>(pointer);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 116850, RefRangeEnd = 116852, XrefRangeStart = 116836, XrefRangeEnd = 116850, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Task<Il2CppSystem.Nullable<Leaderboard>> GetLeaderboard(
    string leaderboardName)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(leaderboardName)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Scores.NativeMethodInfoPtr_GetLeaderboard_Private_Static_Task_1_Nullable_1_Leaderboard_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (Task<Il2CppSystem.Nullable<Leaderboard>>) null : new Task<Il2CppSystem.Nullable<Leaderboard>>(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 116865, RefRangeEnd = 116866, XrefRangeStart = 116852, XrefRangeEnd = 116865, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Task<Il2CppReferenceArray<LeaderboardEntry>> GetGlobal(
    Leaderboard board,
    int entries,
    int offset)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &board;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entries;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &offset;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Scores.NativeMethodInfoPtr_GetGlobal_Public_Static_Task_1_Il2CppReferenceArray_1_LeaderboardEntry_Leaderboard_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (Task<Il2CppReferenceArray<LeaderboardEntry>>) null : new Task<Il2CppReferenceArray<LeaderboardEntry>>(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116866, XrefRangeEnd = 116879, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Task<Il2CppReferenceArray<LeaderboardEntry>> GetFriends(
    Leaderboard board,
    int entries)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &board;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entries;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Scores.NativeMethodInfoPtr_GetFriends_Public_Static_Task_1_Il2CppReferenceArray_1_LeaderboardEntry_Leaderboard_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (Task<Il2CppReferenceArray<LeaderboardEntry>>) null : new Task<Il2CppReferenceArray<LeaderboardEntry>>(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 116892, RefRangeEnd = 116893, XrefRangeStart = 116879, XrefRangeEnd = 116892, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Task<Il2CppReferenceArray<LeaderboardEntry>> GetAround(
    Leaderboard board,
    int entries)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &board;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entries;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Scores.NativeMethodInfoPtr_GetAround_Public_Static_Task_1_Il2CppReferenceArray_1_LeaderboardEntry_Leaderboard_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (Task<Il2CppReferenceArray<LeaderboardEntry>>) null : new Task<Il2CppReferenceArray<LeaderboardEntry>>(pointer);
  }

  public static Task<Il2CppSystem.Nullable<LeaderboardUpdate>> Submit(
    Scores.Type type,
    Il2CppSystem.DateTime date,
    int score,
    params int[] details)
  {
    return Scores.Submit(type, date, score, new Il2CppStructArray<int>(details));
  }

  static Scores()
  {
    Il2CppClassPointerStore<Scores>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (Scores));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Scores>.NativeClassPtr);
    Scores.NativeMethodInfoPtr_GetLeaderboardName_Private_Static_String_Type_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scores>.NativeClassPtr, 100674394);
    Scores.NativeMethodInfoPtr_Submit_Public_Static_Task_1_Nullable_1_LeaderboardUpdate_Type_DateTime_Int32_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scores>.NativeClassPtr, 100674395);
    Scores.NativeMethodInfoPtr_GetLeaderboard_Public_Static_Task_1_Nullable_1_Leaderboard_Type_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scores>.NativeClassPtr, 100674396);
    Scores.NativeMethodInfoPtr_GetLeaderboard_Private_Static_Task_1_Nullable_1_Leaderboard_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scores>.NativeClassPtr, 100674397);
    Scores.NativeMethodInfoPtr_GetGlobal_Public_Static_Task_1_Il2CppReferenceArray_1_LeaderboardEntry_Leaderboard_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scores>.NativeClassPtr, 100674398);
    Scores.NativeMethodInfoPtr_GetFriends_Public_Static_Task_1_Il2CppReferenceArray_1_LeaderboardEntry_Leaderboard_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scores>.NativeClassPtr, 100674399);
    Scores.NativeMethodInfoPtr_GetAround_Public_Static_Task_1_Il2CppReferenceArray_1_LeaderboardEntry_Leaderboard_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scores>.NativeClassPtr, 100674400);
  }

  public Scores(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public enum Type
  {
    TopScores,
    Daily,
  }

  [ObfuscatedName("Scores/<Submit>d__2")]
  public sealed class _Submit_d__2 : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;
    private static readonly System.IntPtr NativeFieldInfoPtr_type;
    private static readonly System.IntPtr NativeFieldInfoPtr_date;
    private static readonly System.IntPtr NativeFieldInfoPtr_score;
    private static readonly System.IntPtr NativeFieldInfoPtr_details;
    private static readonly System.IntPtr NativeFieldInfoPtr___u__1;
    private static readonly System.IntPtr NativeFieldInfoPtr___u__2;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116631, XrefRangeEnd = 116674, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Scores._Submit_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116674, XrefRangeEnd = 116677, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stateMachine)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Scores._Submit_d__2.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static _Submit_d__2()
    {
      Il2CppClassPointerStore<Scores._Submit_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Scores>.NativeClassPtr, "<Submit>d__2");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Scores._Submit_d__2>.NativeClassPtr);
      Scores._Submit_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scores._Submit_d__2>.NativeClassPtr, "<>1__state");
      Scores._Submit_d__2.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scores._Submit_d__2>.NativeClassPtr, "<>t__builder");
      Scores._Submit_d__2.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scores._Submit_d__2>.NativeClassPtr, nameof (type));
      Scores._Submit_d__2.NativeFieldInfoPtr_date = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scores._Submit_d__2>.NativeClassPtr, nameof (date));
      Scores._Submit_d__2.NativeFieldInfoPtr_score = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scores._Submit_d__2>.NativeClassPtr, nameof (score));
      Scores._Submit_d__2.NativeFieldInfoPtr_details = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scores._Submit_d__2>.NativeClassPtr, nameof (details));
      Scores._Submit_d__2.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scores._Submit_d__2>.NativeClassPtr, "<>u__1");
      Scores._Submit_d__2.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scores._Submit_d__2>.NativeClassPtr, "<>u__2");
      Scores._Submit_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scores._Submit_d__2>.NativeClassPtr, 100674401);
      Scores._Submit_d__2.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scores._Submit_d__2>.NativeClassPtr, 100674402);
    }

    public _Submit_d__2(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public _Submit_d__2()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Scores._Submit_d__2>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Scores._Submit_d__2>.NativeClassPtr, data));
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Scores._Submit_d__2.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Scores._Submit_d__2.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public AsyncTaskMethodBuilder<Il2CppSystem.Nullable<LeaderboardUpdate>> __t__builder
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Scores._Submit_d__2.NativeFieldInfoPtr___t__builder);
        return new AsyncTaskMethodBuilder<Il2CppSystem.Nullable<LeaderboardUpdate>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Il2CppSystem.Nullable<LeaderboardUpdate>>>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Scores._Submit_d__2.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Il2CppSystem.Nullable<LeaderboardUpdate>>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe Scores.Type type
    {
      get
      {
        return *(Scores.Type*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Scores._Submit_d__2.NativeFieldInfoPtr_type));
      }
      [param: In] set
      {
        *(Scores.Type*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Scores._Submit_d__2.NativeFieldInfoPtr_type)) = value;
      }
    }

    public unsafe Il2CppSystem.DateTime date
    {
      get
      {
        return *(Il2CppSystem.DateTime*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Scores._Submit_d__2.NativeFieldInfoPtr_date));
      }
      [param: In] set
      {
        *(Il2CppSystem.DateTime*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Scores._Submit_d__2.NativeFieldInfoPtr_date)) = value;
      }
    }

    public unsafe int score
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Scores._Submit_d__2.NativeFieldInfoPtr_score));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Scores._Submit_d__2.NativeFieldInfoPtr_score)) = value;
      }
    }

    public unsafe Il2CppStructArray<int> details
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Scores._Submit_d__2.NativeFieldInfoPtr_details));
        return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<int>) null : new Il2CppStructArray<int>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Scores._Submit_d__2.NativeFieldInfoPtr_details), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public TaskAwaiter<Il2CppSystem.Nullable<Leaderboard>> __u__1
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Scores._Submit_d__2.NativeFieldInfoPtr___u__1);
        return new TaskAwaiter<Il2CppSystem.Nullable<Leaderboard>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter<Il2CppSystem.Nullable<Leaderboard>>>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Scores._Submit_d__2.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter<Il2CppSystem.Nullable<Leaderboard>>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public TaskAwaiter<Il2CppSystem.Nullable<LeaderboardUpdate>> __u__2
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Scores._Submit_d__2.NativeFieldInfoPtr___u__2);
        return new TaskAwaiter<Il2CppSystem.Nullable<LeaderboardUpdate>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter<Il2CppSystem.Nullable<LeaderboardUpdate>>>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Scores._Submit_d__2.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter<Il2CppSystem.Nullable<LeaderboardUpdate>>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }

  [ObfuscatedName("Scores/<GetLeaderboard>d__3")]
  public sealed class _GetLeaderboard_d__3 : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;
    private static readonly System.IntPtr NativeFieldInfoPtr_type;
    private static readonly System.IntPtr NativeFieldInfoPtr_date;
    private static readonly System.IntPtr NativeFieldInfoPtr___u__1;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116677, XrefRangeEnd = 116700, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Scores._GetLeaderboard_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116700, XrefRangeEnd = 116703, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stateMachine)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Scores._GetLeaderboard_d__3.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static _GetLeaderboard_d__3()
    {
      Il2CppClassPointerStore<Scores._GetLeaderboard_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Scores>.NativeClassPtr, "<GetLeaderboard>d__3");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Scores._GetLeaderboard_d__3>.NativeClassPtr);
      Scores._GetLeaderboard_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scores._GetLeaderboard_d__3>.NativeClassPtr, "<>1__state");
      Scores._GetLeaderboard_d__3.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scores._GetLeaderboard_d__3>.NativeClassPtr, "<>t__builder");
      Scores._GetLeaderboard_d__3.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scores._GetLeaderboard_d__3>.NativeClassPtr, nameof (type));
      Scores._GetLeaderboard_d__3.NativeFieldInfoPtr_date = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scores._GetLeaderboard_d__3>.NativeClassPtr, nameof (date));
      Scores._GetLeaderboard_d__3.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scores._GetLeaderboard_d__3>.NativeClassPtr, "<>u__1");
      Scores._GetLeaderboard_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scores._GetLeaderboard_d__3>.NativeClassPtr, 100674403);
      Scores._GetLeaderboard_d__3.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scores._GetLeaderboard_d__3>.NativeClassPtr, 100674404);
    }

    public _GetLeaderboard_d__3(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public _GetLeaderboard_d__3()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Scores._GetLeaderboard_d__3>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Scores._GetLeaderboard_d__3>.NativeClassPtr, data));
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Scores._GetLeaderboard_d__3.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Scores._GetLeaderboard_d__3.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public AsyncTaskMethodBuilder<Il2CppSystem.Nullable<Leaderboard>> __t__builder
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Scores._GetLeaderboard_d__3.NativeFieldInfoPtr___t__builder);
        return new AsyncTaskMethodBuilder<Il2CppSystem.Nullable<Leaderboard>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Il2CppSystem.Nullable<Leaderboard>>>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Scores._GetLeaderboard_d__3.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Il2CppSystem.Nullable<Leaderboard>>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe Scores.Type type
    {
      get
      {
        return *(Scores.Type*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Scores._GetLeaderboard_d__3.NativeFieldInfoPtr_type));
      }
      [param: In] set
      {
        *(Scores.Type*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Scores._GetLeaderboard_d__3.NativeFieldInfoPtr_type)) = value;
      }
    }

    public unsafe Il2CppSystem.DateTime date
    {
      get
      {
        return *(Il2CppSystem.DateTime*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Scores._GetLeaderboard_d__3.NativeFieldInfoPtr_date));
      }
      [param: In] set
      {
        *(Il2CppSystem.DateTime*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Scores._GetLeaderboard_d__3.NativeFieldInfoPtr_date)) = value;
      }
    }

    public TaskAwaiter<Il2CppSystem.Nullable<Leaderboard>> __u__1
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Scores._GetLeaderboard_d__3.NativeFieldInfoPtr___u__1);
        return new TaskAwaiter<Il2CppSystem.Nullable<Leaderboard>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter<Il2CppSystem.Nullable<Leaderboard>>>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Scores._GetLeaderboard_d__3.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter<Il2CppSystem.Nullable<Leaderboard>>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }

  [ObfuscatedName("Scores/<GetLeaderboard>d__4")]
  public sealed class _GetLeaderboard_d__4 : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;
    private static readonly System.IntPtr NativeFieldInfoPtr_leaderboardName;
    private static readonly System.IntPtr NativeFieldInfoPtr___u__1;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116703, XrefRangeEnd = 116725, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Scores._GetLeaderboard_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116725, XrefRangeEnd = 116728, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stateMachine)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Scores._GetLeaderboard_d__4.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static _GetLeaderboard_d__4()
    {
      Il2CppClassPointerStore<Scores._GetLeaderboard_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Scores>.NativeClassPtr, "<GetLeaderboard>d__4");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Scores._GetLeaderboard_d__4>.NativeClassPtr);
      Scores._GetLeaderboard_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scores._GetLeaderboard_d__4>.NativeClassPtr, "<>1__state");
      Scores._GetLeaderboard_d__4.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scores._GetLeaderboard_d__4>.NativeClassPtr, "<>t__builder");
      Scores._GetLeaderboard_d__4.NativeFieldInfoPtr_leaderboardName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scores._GetLeaderboard_d__4>.NativeClassPtr, nameof (leaderboardName));
      Scores._GetLeaderboard_d__4.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scores._GetLeaderboard_d__4>.NativeClassPtr, "<>u__1");
      Scores._GetLeaderboard_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scores._GetLeaderboard_d__4>.NativeClassPtr, 100674405);
      Scores._GetLeaderboard_d__4.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scores._GetLeaderboard_d__4>.NativeClassPtr, 100674406);
    }

    public _GetLeaderboard_d__4(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public _GetLeaderboard_d__4()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Scores._GetLeaderboard_d__4>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Scores._GetLeaderboard_d__4>.NativeClassPtr, data));
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Scores._GetLeaderboard_d__4.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Scores._GetLeaderboard_d__4.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public AsyncTaskMethodBuilder<Il2CppSystem.Nullable<Leaderboard>> __t__builder
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Scores._GetLeaderboard_d__4.NativeFieldInfoPtr___t__builder);
        return new AsyncTaskMethodBuilder<Il2CppSystem.Nullable<Leaderboard>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Il2CppSystem.Nullable<Leaderboard>>>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Scores._GetLeaderboard_d__4.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Il2CppSystem.Nullable<Leaderboard>>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe string leaderboardName
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Scores._GetLeaderboard_d__4.NativeFieldInfoPtr_leaderboardName)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Scores._GetLeaderboard_d__4.NativeFieldInfoPtr_leaderboardName), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public TaskAwaiter<Il2CppSystem.Nullable<Leaderboard>> __u__1
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Scores._GetLeaderboard_d__4.NativeFieldInfoPtr___u__1);
        return new TaskAwaiter<Il2CppSystem.Nullable<Leaderboard>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter<Il2CppSystem.Nullable<Leaderboard>>>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Scores._GetLeaderboard_d__4.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter<Il2CppSystem.Nullable<Leaderboard>>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }

  [ObfuscatedName("Scores/<GetGlobal>d__5")]
  public sealed class _GetGlobal_d__5 : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;
    private static readonly System.IntPtr NativeFieldInfoPtr_board;
    private static readonly System.IntPtr NativeFieldInfoPtr_entries;
    private static readonly System.IntPtr NativeFieldInfoPtr_offset;
    private static readonly System.IntPtr NativeFieldInfoPtr___u__1;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116728, XrefRangeEnd = 116750, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Scores._GetGlobal_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116750, XrefRangeEnd = 116753, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stateMachine)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Scores._GetGlobal_d__5.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static _GetGlobal_d__5()
    {
      Il2CppClassPointerStore<Scores._GetGlobal_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Scores>.NativeClassPtr, "<GetGlobal>d__5");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Scores._GetGlobal_d__5>.NativeClassPtr);
      Scores._GetGlobal_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scores._GetGlobal_d__5>.NativeClassPtr, "<>1__state");
      Scores._GetGlobal_d__5.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scores._GetGlobal_d__5>.NativeClassPtr, "<>t__builder");
      Scores._GetGlobal_d__5.NativeFieldInfoPtr_board = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scores._GetGlobal_d__5>.NativeClassPtr, nameof (board));
      Scores._GetGlobal_d__5.NativeFieldInfoPtr_entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scores._GetGlobal_d__5>.NativeClassPtr, nameof (entries));
      Scores._GetGlobal_d__5.NativeFieldInfoPtr_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scores._GetGlobal_d__5>.NativeClassPtr, nameof (offset));
      Scores._GetGlobal_d__5.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scores._GetGlobal_d__5>.NativeClassPtr, "<>u__1");
      Scores._GetGlobal_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scores._GetGlobal_d__5>.NativeClassPtr, 100674407);
      Scores._GetGlobal_d__5.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scores._GetGlobal_d__5>.NativeClassPtr, 100674408);
    }

    public _GetGlobal_d__5(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public _GetGlobal_d__5()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Scores._GetGlobal_d__5>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Scores._GetGlobal_d__5>.NativeClassPtr, data));
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Scores._GetGlobal_d__5.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Scores._GetGlobal_d__5.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public AsyncTaskMethodBuilder<Il2CppReferenceArray<LeaderboardEntry>> __t__builder
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Scores._GetGlobal_d__5.NativeFieldInfoPtr___t__builder);
        return new AsyncTaskMethodBuilder<Il2CppReferenceArray<LeaderboardEntry>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Il2CppReferenceArray<LeaderboardEntry>>>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Scores._GetGlobal_d__5.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Il2CppReferenceArray<LeaderboardEntry>>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe Leaderboard board
    {
      get
      {
        return *(Leaderboard*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Scores._GetGlobal_d__5.NativeFieldInfoPtr_board));
      }
      [param: In] set
      {
        *(Leaderboard*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Scores._GetGlobal_d__5.NativeFieldInfoPtr_board)) = value;
      }
    }

    public unsafe int entries
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Scores._GetGlobal_d__5.NativeFieldInfoPtr_entries));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Scores._GetGlobal_d__5.NativeFieldInfoPtr_entries)) = value;
      }
    }

    public unsafe int offset
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Scores._GetGlobal_d__5.NativeFieldInfoPtr_offset));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Scores._GetGlobal_d__5.NativeFieldInfoPtr_offset)) = value;
      }
    }

    public TaskAwaiter<Il2CppReferenceArray<LeaderboardEntry>> __u__1
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Scores._GetGlobal_d__5.NativeFieldInfoPtr___u__1);
        return new TaskAwaiter<Il2CppReferenceArray<LeaderboardEntry>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter<Il2CppReferenceArray<LeaderboardEntry>>>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Scores._GetGlobal_d__5.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter<Il2CppReferenceArray<LeaderboardEntry>>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }

  [ObfuscatedName("Scores/<GetFriends>d__6")]
  public sealed class _GetFriends_d__6 : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;
    private static readonly System.IntPtr NativeFieldInfoPtr_board;
    private static readonly System.IntPtr NativeFieldInfoPtr___u__1;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116753, XrefRangeEnd = 116775, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Scores._GetFriends_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116775, XrefRangeEnd = 116778, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stateMachine)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Scores._GetFriends_d__6.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static _GetFriends_d__6()
    {
      Il2CppClassPointerStore<Scores._GetFriends_d__6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Scores>.NativeClassPtr, "<GetFriends>d__6");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Scores._GetFriends_d__6>.NativeClassPtr);
      Scores._GetFriends_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scores._GetFriends_d__6>.NativeClassPtr, "<>1__state");
      Scores._GetFriends_d__6.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scores._GetFriends_d__6>.NativeClassPtr, "<>t__builder");
      Scores._GetFriends_d__6.NativeFieldInfoPtr_board = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scores._GetFriends_d__6>.NativeClassPtr, nameof (board));
      Scores._GetFriends_d__6.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scores._GetFriends_d__6>.NativeClassPtr, "<>u__1");
      Scores._GetFriends_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scores._GetFriends_d__6>.NativeClassPtr, 100674409);
      Scores._GetFriends_d__6.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scores._GetFriends_d__6>.NativeClassPtr, 100674410);
    }

    public _GetFriends_d__6(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public _GetFriends_d__6()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Scores._GetFriends_d__6>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Scores._GetFriends_d__6>.NativeClassPtr, data));
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Scores._GetFriends_d__6.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Scores._GetFriends_d__6.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public AsyncTaskMethodBuilder<Il2CppReferenceArray<LeaderboardEntry>> __t__builder
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Scores._GetFriends_d__6.NativeFieldInfoPtr___t__builder);
        return new AsyncTaskMethodBuilder<Il2CppReferenceArray<LeaderboardEntry>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Il2CppReferenceArray<LeaderboardEntry>>>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Scores._GetFriends_d__6.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Il2CppReferenceArray<LeaderboardEntry>>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe Leaderboard board
    {
      get
      {
        return *(Leaderboard*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Scores._GetFriends_d__6.NativeFieldInfoPtr_board));
      }
      [param: In] set
      {
        *(Leaderboard*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Scores._GetFriends_d__6.NativeFieldInfoPtr_board)) = value;
      }
    }

    public TaskAwaiter<Il2CppReferenceArray<LeaderboardEntry>> __u__1
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Scores._GetFriends_d__6.NativeFieldInfoPtr___u__1);
        return new TaskAwaiter<Il2CppReferenceArray<LeaderboardEntry>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter<Il2CppReferenceArray<LeaderboardEntry>>>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Scores._GetFriends_d__6.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter<Il2CppReferenceArray<LeaderboardEntry>>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }

  [ObfuscatedName("Scores/<GetAround>d__7")]
  public sealed class _GetAround_d__7 : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;
    private static readonly System.IntPtr NativeFieldInfoPtr_entries;
    private static readonly System.IntPtr NativeFieldInfoPtr_board;
    private static readonly System.IntPtr NativeFieldInfoPtr___u__1;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116778, XrefRangeEnd = 116800, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Scores._GetAround_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116800, XrefRangeEnd = 116803, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stateMachine)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Scores._GetAround_d__7.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static _GetAround_d__7()
    {
      Il2CppClassPointerStore<Scores._GetAround_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Scores>.NativeClassPtr, "<GetAround>d__7");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Scores._GetAround_d__7>.NativeClassPtr);
      Scores._GetAround_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scores._GetAround_d__7>.NativeClassPtr, "<>1__state");
      Scores._GetAround_d__7.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scores._GetAround_d__7>.NativeClassPtr, "<>t__builder");
      Scores._GetAround_d__7.NativeFieldInfoPtr_entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scores._GetAround_d__7>.NativeClassPtr, nameof (entries));
      Scores._GetAround_d__7.NativeFieldInfoPtr_board = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scores._GetAround_d__7>.NativeClassPtr, nameof (board));
      Scores._GetAround_d__7.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scores._GetAround_d__7>.NativeClassPtr, "<>u__1");
      Scores._GetAround_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scores._GetAround_d__7>.NativeClassPtr, 100674411);
      Scores._GetAround_d__7.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scores._GetAround_d__7>.NativeClassPtr, 100674412);
    }

    public _GetAround_d__7(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public _GetAround_d__7()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Scores._GetAround_d__7>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Scores._GetAround_d__7>.NativeClassPtr, data));
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Scores._GetAround_d__7.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Scores._GetAround_d__7.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public AsyncTaskMethodBuilder<Il2CppReferenceArray<LeaderboardEntry>> __t__builder
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Scores._GetAround_d__7.NativeFieldInfoPtr___t__builder);
        return new AsyncTaskMethodBuilder<Il2CppReferenceArray<LeaderboardEntry>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Il2CppReferenceArray<LeaderboardEntry>>>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Scores._GetAround_d__7.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Il2CppReferenceArray<LeaderboardEntry>>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe int entries
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Scores._GetAround_d__7.NativeFieldInfoPtr_entries));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Scores._GetAround_d__7.NativeFieldInfoPtr_entries)) = value;
      }
    }

    public unsafe Leaderboard board
    {
      get
      {
        return *(Leaderboard*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Scores._GetAround_d__7.NativeFieldInfoPtr_board));
      }
      [param: In] set
      {
        *(Leaderboard*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Scores._GetAround_d__7.NativeFieldInfoPtr_board)) = value;
      }
    }

    public TaskAwaiter<Il2CppReferenceArray<LeaderboardEntry>> __u__1
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Scores._GetAround_d__7.NativeFieldInfoPtr___u__1);
        return new TaskAwaiter<Il2CppReferenceArray<LeaderboardEntry>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter<Il2CppReferenceArray<LeaderboardEntry>>>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Scores._GetAround_d__7.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter<Il2CppReferenceArray<LeaderboardEntry>>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }
}
