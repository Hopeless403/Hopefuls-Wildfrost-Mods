// Decompiled with JetBrains decompiler
// Type: AddSecretCardsSystem
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

#nullable disable
public class AddSecretCardsSystem : GameSystem
{
  private static readonly System.IntPtr NativeFieldInfoPtr_requiredModifiers;
  private static readonly System.IntPtr NativeFieldInfoPtr_cardsToAdd;
  private static readonly System.IntPtr NativeFieldInfoPtr_possibleNodeTypes;
  private static readonly System.IntPtr NativeFieldInfoPtr_tiers;
  private static readonly System.IntPtr NativeMethodInfoPtr_HasRequiredModifiers_Private_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Add_Private_Task_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OrderNodesBySingular_Private_Static_Int32_CampaignNode_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EntityEnterBackpack_Private_Void_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddCardToNode_Private_Static_Void_CampaignNode_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55051, XrefRangeEnd = 55053, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool HasRequiredModifiers()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AddSecretCardsSystem.NativeMethodInfoPtr_HasRequiredModifiers_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55053, XrefRangeEnd = 55073, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(AddSecretCardsSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55073, XrefRangeEnd = 55088, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(AddSecretCardsSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55088, XrefRangeEnd = 55098, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Task Add()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AddSecretCardsSystem.NativeMethodInfoPtr_Add_Private_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (Task) null : new Task(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55098, XrefRangeEnd = 55100, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int OrderNodesBySingular(CampaignNode a)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AddSecretCardsSystem.NativeMethodInfoPtr_OrderNodesBySingular_Private_Static_Int32_CampaignNode_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(int*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55100, XrefRangeEnd = 55117, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EntityEnterBackpack(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(AddSecretCardsSystem.NativeMethodInfoPtr_EntityEnterBackpack_Private_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 55195, RefRangeEnd = 55196, XrefRangeStart = 55117, XrefRangeEnd = 55195, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void AddCardToNode(CampaignNode node, string cardName)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) node);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(cardName);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(AddSecretCardsSystem.NativeMethodInfoPtr_AddCardToNode_Private_Static_Void_CampaignNode_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55196, XrefRangeEnd = 55203, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe AddSecretCardsSystem()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddSecretCardsSystem>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(AddSecretCardsSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static AddSecretCardsSystem()
  {
    Il2CppClassPointerStore<AddSecretCardsSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (AddSecretCardsSystem));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddSecretCardsSystem>.NativeClassPtr);
    AddSecretCardsSystem.NativeFieldInfoPtr_requiredModifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddSecretCardsSystem>.NativeClassPtr, nameof (requiredModifiers));
    AddSecretCardsSystem.NativeFieldInfoPtr_cardsToAdd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddSecretCardsSystem>.NativeClassPtr, nameof (cardsToAdd));
    AddSecretCardsSystem.NativeFieldInfoPtr_possibleNodeTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddSecretCardsSystem>.NativeClassPtr, nameof (possibleNodeTypes));
    AddSecretCardsSystem.NativeFieldInfoPtr_tiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddSecretCardsSystem>.NativeClassPtr, nameof (tiers));
    AddSecretCardsSystem.NativeMethodInfoPtr_HasRequiredModifiers_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddSecretCardsSystem>.NativeClassPtr, 100667820);
    AddSecretCardsSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddSecretCardsSystem>.NativeClassPtr, 100667821);
    AddSecretCardsSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddSecretCardsSystem>.NativeClassPtr, 100667822);
    AddSecretCardsSystem.NativeMethodInfoPtr_Add_Private_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddSecretCardsSystem>.NativeClassPtr, 100667823);
    AddSecretCardsSystem.NativeMethodInfoPtr_OrderNodesBySingular_Private_Static_Int32_CampaignNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddSecretCardsSystem>.NativeClassPtr, 100667824);
    AddSecretCardsSystem.NativeMethodInfoPtr_EntityEnterBackpack_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddSecretCardsSystem>.NativeClassPtr, 100667825);
    AddSecretCardsSystem.NativeMethodInfoPtr_AddCardToNode_Private_Static_Void_CampaignNode_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddSecretCardsSystem>.NativeClassPtr, 100667826);
    AddSecretCardsSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddSecretCardsSystem>.NativeClassPtr, 100667827);
  }

  public AddSecretCardsSystem(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Il2CppReferenceArray<GameModifierData> requiredModifiers
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AddSecretCardsSystem.NativeFieldInfoPtr_requiredModifiers));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<GameModifierData>) null : new Il2CppReferenceArray<GameModifierData>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AddSecretCardsSystem.NativeFieldInfoPtr_requiredModifiers), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppStringArray cardsToAdd
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AddSecretCardsSystem.NativeFieldInfoPtr_cardsToAdd));
      return pointer == System.IntPtr.Zero ? (Il2CppStringArray) null : new Il2CppStringArray(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AddSecretCardsSystem.NativeFieldInfoPtr_cardsToAdd), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppStringArray possibleNodeTypes
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AddSecretCardsSystem.NativeFieldInfoPtr_possibleNodeTypes));
      return pointer == System.IntPtr.Zero ? (Il2CppStringArray) null : new Il2CppStringArray(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AddSecretCardsSystem.NativeFieldInfoPtr_possibleNodeTypes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppStructArray<int> tiers
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AddSecretCardsSystem.NativeFieldInfoPtr_tiers));
      return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<int>) null : new Il2CppStructArray<int>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AddSecretCardsSystem.NativeFieldInfoPtr_tiers), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [ObfuscatedName("AddSecretCardsSystem/<>c__DisplayClass7_0")]
  public sealed class __c__DisplayClass7_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_node;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Add_b__0_Internal_Boolean_CampaignNode_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass7_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddSecretCardsSystem.__c__DisplayClass7_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AddSecretCardsSystem.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe bool _Add_b__0(CampaignNode a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AddSecretCardsSystem.__c__DisplayClass7_0.NativeMethodInfoPtr__Add_b__0_Internal_Boolean_CampaignNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c__DisplayClass7_0()
    {
      Il2CppClassPointerStore<AddSecretCardsSystem.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AddSecretCardsSystem>.NativeClassPtr, "<>c__DisplayClass7_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddSecretCardsSystem.__c__DisplayClass7_0>.NativeClassPtr);
      AddSecretCardsSystem.__c__DisplayClass7_0.NativeFieldInfoPtr_node = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddSecretCardsSystem.__c__DisplayClass7_0>.NativeClassPtr, nameof (node));
      AddSecretCardsSystem.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddSecretCardsSystem.__c__DisplayClass7_0>.NativeClassPtr, 100667828);
      AddSecretCardsSystem.__c__DisplayClass7_0.NativeMethodInfoPtr__Add_b__0_Internal_Boolean_CampaignNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddSecretCardsSystem.__c__DisplayClass7_0>.NativeClassPtr, 100667829);
    }

    public __c__DisplayClass7_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe CampaignNode node
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AddSecretCardsSystem.__c__DisplayClass7_0.NativeFieldInfoPtr_node));
        return pointer == System.IntPtr.Zero ? (CampaignNode) null : new CampaignNode(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AddSecretCardsSystem.__c__DisplayClass7_0.NativeFieldInfoPtr_node), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("AddSecretCardsSystem/<Add>d__7")]
  public sealed class _Add_d__7 : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54921, XrefRangeEnd = 54992, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AddSecretCardsSystem._Add_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
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
      IL2CPP.il2cpp_runtime_invoke(AddSecretCardsSystem._Add_d__7.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static _Add_d__7()
    {
      Il2CppClassPointerStore<AddSecretCardsSystem._Add_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AddSecretCardsSystem>.NativeClassPtr, "<Add>d__7");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddSecretCardsSystem._Add_d__7>.NativeClassPtr);
      AddSecretCardsSystem._Add_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddSecretCardsSystem._Add_d__7>.NativeClassPtr, "<>1__state");
      AddSecretCardsSystem._Add_d__7.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddSecretCardsSystem._Add_d__7>.NativeClassPtr, "<>t__builder");
      AddSecretCardsSystem._Add_d__7.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddSecretCardsSystem._Add_d__7>.NativeClassPtr, "<>4__this");
      AddSecretCardsSystem._Add_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddSecretCardsSystem._Add_d__7>.NativeClassPtr, 100667830);
      AddSecretCardsSystem._Add_d__7.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddSecretCardsSystem._Add_d__7>.NativeClassPtr, 100667831);
    }

    public _Add_d__7(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public _Add_d__7()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AddSecretCardsSystem._Add_d__7>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AddSecretCardsSystem._Add_d__7>.NativeClassPtr, data));
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AddSecretCardsSystem._Add_d__7.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AddSecretCardsSystem._Add_d__7.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public AsyncTaskMethodBuilder __t__builder
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AddSecretCardsSystem._Add_d__7.NativeFieldInfoPtr___t__builder);
        return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AddSecretCardsSystem._Add_d__7.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe AddSecretCardsSystem __4__this
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AddSecretCardsSystem._Add_d__7.NativeFieldInfoPtr___4__this));
        return pointer == System.IntPtr.Zero ? (AddSecretCardsSystem) null : new AddSecretCardsSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AddSecretCardsSystem._Add_d__7.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("AddSecretCardsSystem/<>c__DisplayClass9_0")]
  public sealed class __c__DisplayClass9_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_entity;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__EntityEnterBackpack_b__0_Internal_Boolean_String_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass9_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddSecretCardsSystem.__c__DisplayClass9_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AddSecretCardsSystem.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54992, XrefRangeEnd = 55051, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _EntityEnterBackpack_b__0(string a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AddSecretCardsSystem.__c__DisplayClass9_0.NativeMethodInfoPtr__EntityEnterBackpack_b__0_Internal_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c__DisplayClass9_0()
    {
      Il2CppClassPointerStore<AddSecretCardsSystem.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AddSecretCardsSystem>.NativeClassPtr, "<>c__DisplayClass9_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddSecretCardsSystem.__c__DisplayClass9_0>.NativeClassPtr);
      AddSecretCardsSystem.__c__DisplayClass9_0.NativeFieldInfoPtr_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddSecretCardsSystem.__c__DisplayClass9_0>.NativeClassPtr, nameof (entity));
      AddSecretCardsSystem.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddSecretCardsSystem.__c__DisplayClass9_0>.NativeClassPtr, 100667832);
      AddSecretCardsSystem.__c__DisplayClass9_0.NativeMethodInfoPtr__EntityEnterBackpack_b__0_Internal_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddSecretCardsSystem.__c__DisplayClass9_0>.NativeClassPtr, 100667833);
    }

    public __c__DisplayClass9_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Entity entity
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AddSecretCardsSystem.__c__DisplayClass9_0.NativeFieldInfoPtr_entity));
        return pointer == System.IntPtr.Zero ? (Entity) null : new Entity(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AddSecretCardsSystem.__c__DisplayClass9_0.NativeFieldInfoPtr_entity), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
