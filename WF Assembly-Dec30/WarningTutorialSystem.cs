// Decompiled with JetBrains decompiler
// Type: WarningTutorialSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine.Localization;

#nullable disable
public class WarningTutorialSystem : GameSystem
{
  private static readonly System.IntPtr NativeFieldInfoPtr_promptStringRef;
  private static readonly System.IntPtr NativeFieldInfoPtr_promptShown;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CheckAction_Private_Void_byref_PlayAction_byref_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetDamageDetails_Private_Static_Void_Entity_byref_Int32_byref_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ActionPerform_Private_Void_PlayAction_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ShowPrompt_Private_Void_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_HidePrompt_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80864, XrefRangeEnd = 80879, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(WarningTutorialSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80879, XrefRangeEnd = 80894, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(WarningTutorialSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80894, XrefRangeEnd = 80946, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CheckAction(ref PlayAction action, ref bool allow)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    System.IntPtr* numPtr2 = numPtr1;
    System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) action);
    System.IntPtr* numPtr3 = &ptr;
    *numPtr2 = (System.IntPtr) numPtr3;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref allow;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(WarningTutorialSystem.NativeMethodInfoPtr_CheckAction_Private_Void_byref_PlayAction_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    ref PlayAction local = ref action;
    System.IntPtr pointer = ptr;
    PlayAction playAction = pointer == System.IntPtr.Zero ? (PlayAction) null : new PlayAction(pointer);
    local = playAction;
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 80964, RefRangeEnd = 80965, XrefRangeStart = 80946, XrefRangeEnd = 80964, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void GetDamageDetails(Entity entity, out int damage, out bool instantKill)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref damage;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref instantKill;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(WarningTutorialSystem.NativeMethodInfoPtr_GetDamageDetails_Private_Static_Void_Entity_byref_Int32_byref_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80965, XrefRangeEnd = 80966, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ActionPerform(PlayAction action)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) action)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(WarningTutorialSystem.NativeMethodInfoPtr_ActionPerform_Private_Void_PlayAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 80982, RefRangeEnd = 80983, XrefRangeStart = 80966, XrefRangeEnd = 80982, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ShowPrompt(Entity attackingCard)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) attackingCard)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(WarningTutorialSystem.NativeMethodInfoPtr_ShowPrompt_Private_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80983, XrefRangeEnd = 80984, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void HidePrompt()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(WarningTutorialSystem.NativeMethodInfoPtr_HidePrompt_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 21168, RefRangeEnd = 21171, XrefRangeStart = 21168, XrefRangeEnd = 21171, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe WarningTutorialSystem()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WarningTutorialSystem>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(WarningTutorialSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static WarningTutorialSystem()
  {
    Il2CppClassPointerStore<WarningTutorialSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (WarningTutorialSystem));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WarningTutorialSystem>.NativeClassPtr);
    WarningTutorialSystem.NativeFieldInfoPtr_promptStringRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarningTutorialSystem>.NativeClassPtr, nameof (promptStringRef));
    WarningTutorialSystem.NativeFieldInfoPtr_promptShown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarningTutorialSystem>.NativeClassPtr, nameof (promptShown));
    WarningTutorialSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarningTutorialSystem>.NativeClassPtr, 100669919);
    WarningTutorialSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarningTutorialSystem>.NativeClassPtr, 100669920);
    WarningTutorialSystem.NativeMethodInfoPtr_CheckAction_Private_Void_byref_PlayAction_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarningTutorialSystem>.NativeClassPtr, 100669921);
    WarningTutorialSystem.NativeMethodInfoPtr_GetDamageDetails_Private_Static_Void_Entity_byref_Int32_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarningTutorialSystem>.NativeClassPtr, 100669922);
    WarningTutorialSystem.NativeMethodInfoPtr_ActionPerform_Private_Void_PlayAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarningTutorialSystem>.NativeClassPtr, 100669923);
    WarningTutorialSystem.NativeMethodInfoPtr_ShowPrompt_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarningTutorialSystem>.NativeClassPtr, 100669924);
    WarningTutorialSystem.NativeMethodInfoPtr_HidePrompt_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarningTutorialSystem>.NativeClassPtr, 100669925);
    WarningTutorialSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarningTutorialSystem>.NativeClassPtr, 100669926);
  }

  public WarningTutorialSystem(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe LocalizedString promptStringRef
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WarningTutorialSystem.NativeFieldInfoPtr_promptStringRef));
      return pointer == System.IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WarningTutorialSystem.NativeFieldInfoPtr_promptStringRef), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool promptShown
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WarningTutorialSystem.NativeFieldInfoPtr_promptShown));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WarningTutorialSystem.NativeFieldInfoPtr_promptShown)) = value;
    }
  }

  [ObfuscatedName("WarningTutorialSystem/<>c")]
  [Serializable]
  public sealed class __c : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__4_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__CheckAction_b__4_0_Internal_Boolean_Entity_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WarningTutorialSystem.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(WarningTutorialSystem.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80643, XrefRangeEnd = 80645, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _CheckAction_b__4_0(Entity a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(WarningTutorialSystem.__c.NativeMethodInfoPtr__CheckAction_b__4_0_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c()
    {
      Il2CppClassPointerStore<WarningTutorialSystem.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WarningTutorialSystem>.NativeClassPtr, "<>c");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WarningTutorialSystem.__c>.NativeClassPtr);
      WarningTutorialSystem.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarningTutorialSystem.__c>.NativeClassPtr, "<>9");
      WarningTutorialSystem.__c.NativeFieldInfoPtr___9__4_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarningTutorialSystem.__c>.NativeClassPtr, "<>9__4_0");
      WarningTutorialSystem.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarningTutorialSystem.__c>.NativeClassPtr, 100669928);
      WarningTutorialSystem.__c.NativeMethodInfoPtr__CheckAction_b__4_0_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarningTutorialSystem.__c>.NativeClassPtr, 100669929);
    }

    public __c(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe WarningTutorialSystem.__c __9
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(WarningTutorialSystem.__c.NativeFieldInfoPtr___9, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (WarningTutorialSystem.__c) null : new WarningTutorialSystem.__c(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(WarningTutorialSystem.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<Entity, bool> __9__4_0
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(WarningTutorialSystem.__c.NativeFieldInfoPtr___9__4_0, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<Entity, bool>) null : new Il2CppSystem.Func<Entity, bool>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(WarningTutorialSystem.__c.NativeFieldInfoPtr___9__4_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("WarningTutorialSystem/<>c__DisplayClass7_0")]
  public sealed class __c__DisplayClass7_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr_attackingCard;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ShowPrompt_b__0_Internal_String_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass7_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WarningTutorialSystem.__c__DisplayClass7_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(WarningTutorialSystem.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80645, XrefRangeEnd = 80864, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string _ShowPrompt_b__0()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(WarningTutorialSystem.__c__DisplayClass7_0.NativeMethodInfoPtr__ShowPrompt_b__0_Internal_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    static __c__DisplayClass7_0()
    {
      Il2CppClassPointerStore<WarningTutorialSystem.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WarningTutorialSystem>.NativeClassPtr, "<>c__DisplayClass7_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WarningTutorialSystem.__c__DisplayClass7_0>.NativeClassPtr);
      WarningTutorialSystem.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarningTutorialSystem.__c__DisplayClass7_0>.NativeClassPtr, "<>4__this");
      WarningTutorialSystem.__c__DisplayClass7_0.NativeFieldInfoPtr_attackingCard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarningTutorialSystem.__c__DisplayClass7_0>.NativeClassPtr, nameof (attackingCard));
      WarningTutorialSystem.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarningTutorialSystem.__c__DisplayClass7_0>.NativeClassPtr, 100669930);
      WarningTutorialSystem.__c__DisplayClass7_0.NativeMethodInfoPtr__ShowPrompt_b__0_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarningTutorialSystem.__c__DisplayClass7_0>.NativeClassPtr, 100669931);
    }

    public __c__DisplayClass7_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe WarningTutorialSystem __4__this
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WarningTutorialSystem.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this));
        return pointer == System.IntPtr.Zero ? (WarningTutorialSystem) null : new WarningTutorialSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WarningTutorialSystem.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Entity attackingCard
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WarningTutorialSystem.__c__DisplayClass7_0.NativeFieldInfoPtr_attackingCard));
        return pointer == System.IntPtr.Zero ? (Entity) null : new Entity(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WarningTutorialSystem.__c__DisplayClass7_0.NativeFieldInfoPtr_attackingCard), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
