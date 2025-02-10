// Decompiled with JetBrains decompiler
// Type: PlayCrownCardsFirstSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
public class PlayCrownCardsFirstSystem : GameSystem
{
  private static readonly IntPtr NativeFieldInfoPtr_crownPhase;
  private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_BattleStart_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_CheckAction_Private_Void_byref_PlayAction_byref_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_BattleTurnEnd_Private_Void_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66547, XrefRangeEnd = 66569, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(PlayCrownCardsFirstSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66569, XrefRangeEnd = 66591, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(PlayCrownCardsFirstSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(14)]
  [CachedScanResults(RefRangeStart = 66591, RefRangeEnd = 66605, XrefRangeStart = 66591, XrefRangeEnd = 66591, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void BattleStart()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(PlayCrownCardsFirstSystem.NativeMethodInfoPtr_BattleStart_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66605, XrefRangeEnd = 66612, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CheckAction(ref PlayAction action, ref bool allow)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr1 = stackalloc IntPtr[2];
    IntPtr* numPtr2 = numPtr1;
    IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) action);
    IntPtr* numPtr3 = &ptr;
    *numPtr2 = (IntPtr) numPtr3;
    *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref allow;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(PlayCrownCardsFirstSystem.NativeMethodInfoPtr_CheckAction_Private_Void_byref_PlayAction_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    ref PlayAction local = ref action;
    IntPtr pointer = ptr;
    PlayAction playAction = pointer == IntPtr.Zero ? (PlayAction) null : new PlayAction(pointer);
    local = playAction;
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66612, XrefRangeEnd = 66613, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void BattleTurnEnd(int turnNumber)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &turnNumber
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(PlayCrownCardsFirstSystem.NativeMethodInfoPtr_BattleTurnEnd_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 21168, RefRangeEnd = 21171, XrefRangeStart = 21168, XrefRangeEnd = 21171, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe PlayCrownCardsFirstSystem()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayCrownCardsFirstSystem>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(PlayCrownCardsFirstSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static PlayCrownCardsFirstSystem()
  {
    Il2CppClassPointerStore<PlayCrownCardsFirstSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (PlayCrownCardsFirstSystem));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayCrownCardsFirstSystem>.NativeClassPtr);
    PlayCrownCardsFirstSystem.NativeFieldInfoPtr_crownPhase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayCrownCardsFirstSystem>.NativeClassPtr, nameof (crownPhase));
    PlayCrownCardsFirstSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayCrownCardsFirstSystem>.NativeClassPtr, 100668779);
    PlayCrownCardsFirstSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayCrownCardsFirstSystem>.NativeClassPtr, 100668780);
    PlayCrownCardsFirstSystem.NativeMethodInfoPtr_BattleStart_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayCrownCardsFirstSystem>.NativeClassPtr, 100668781);
    PlayCrownCardsFirstSystem.NativeMethodInfoPtr_CheckAction_Private_Void_byref_PlayAction_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayCrownCardsFirstSystem>.NativeClassPtr, 100668782);
    PlayCrownCardsFirstSystem.NativeMethodInfoPtr_BattleTurnEnd_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayCrownCardsFirstSystem>.NativeClassPtr, 100668783);
    PlayCrownCardsFirstSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayCrownCardsFirstSystem>.NativeClassPtr, 100668784);
  }

  public PlayCrownCardsFirstSystem(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe bool crownPhase
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayCrownCardsFirstSystem.NativeFieldInfoPtr_crownPhase));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayCrownCardsFirstSystem.NativeFieldInfoPtr_crownPhase)) = value;
    }
  }
}
