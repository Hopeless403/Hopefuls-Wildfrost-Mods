// Decompiled with JetBrains decompiler
// Type: SecretFinalBossSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System;
using System.Runtime.InteropServices;

#nullable disable
public class SecretFinalBossSystem : GameSystem
{
  private static readonly IntPtr NativeFieldInfoPtr_requireInDeck;
  private static readonly IntPtr NativeFieldInfoPtr_targetNodeName;
  private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_BattleEnd_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_CheckContinuePastFinalBoss_Private_Void_CampaignNode_0;
  private static readonly IntPtr NativeMethodInfoPtr_PlayerHasRequiredCards_Private_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70737, XrefRangeEnd = 70745, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SecretFinalBossSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70745, XrefRangeEnd = 70753, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SecretFinalBossSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70753, XrefRangeEnd = 70769, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void BattleEnd()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SecretFinalBossSystem.NativeMethodInfoPtr_BattleEnd_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70769, XrefRangeEnd = 70782, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CheckContinuePastFinalBoss(CampaignNode node)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) node)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SecretFinalBossSystem.NativeMethodInfoPtr_CheckContinuePastFinalBoss_Private_Void_CampaignNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 70812, RefRangeEnd = 70814, XrefRangeStart = 70782, XrefRangeEnd = 70812, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool PlayerHasRequiredCards()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(SecretFinalBossSystem.NativeMethodInfoPtr_PlayerHasRequiredCards_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70814, XrefRangeEnd = 70832, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SecretFinalBossSystem()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SecretFinalBossSystem>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SecretFinalBossSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static SecretFinalBossSystem()
  {
    Il2CppClassPointerStore<SecretFinalBossSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (SecretFinalBossSystem));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SecretFinalBossSystem>.NativeClassPtr);
    SecretFinalBossSystem.NativeFieldInfoPtr_requireInDeck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SecretFinalBossSystem>.NativeClassPtr, nameof (requireInDeck));
    SecretFinalBossSystem.NativeFieldInfoPtr_targetNodeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SecretFinalBossSystem>.NativeClassPtr, nameof (targetNodeName));
    SecretFinalBossSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecretFinalBossSystem>.NativeClassPtr, 100669079);
    SecretFinalBossSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecretFinalBossSystem>.NativeClassPtr, 100669080);
    SecretFinalBossSystem.NativeMethodInfoPtr_BattleEnd_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecretFinalBossSystem>.NativeClassPtr, 100669081);
    SecretFinalBossSystem.NativeMethodInfoPtr_CheckContinuePastFinalBoss_Private_Void_CampaignNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecretFinalBossSystem>.NativeClassPtr, 100669082);
    SecretFinalBossSystem.NativeMethodInfoPtr_PlayerHasRequiredCards_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecretFinalBossSystem>.NativeClassPtr, 100669083);
    SecretFinalBossSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecretFinalBossSystem>.NativeClassPtr, 100669084);
  }

  public SecretFinalBossSystem(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Il2CppStringArray requireInDeck
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SecretFinalBossSystem.NativeFieldInfoPtr_requireInDeck));
      return pointer == IntPtr.Zero ? (Il2CppStringArray) null : new Il2CppStringArray(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SecretFinalBossSystem.NativeFieldInfoPtr_requireInDeck), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe string targetNodeName
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SecretFinalBossSystem.NativeFieldInfoPtr_targetNodeName)));
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SecretFinalBossSystem.NativeFieldInfoPtr_targetNodeName), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }
}
