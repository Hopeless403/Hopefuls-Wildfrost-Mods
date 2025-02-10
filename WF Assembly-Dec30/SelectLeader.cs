// Decompiled with JetBrains decompiler
// Type: SelectLeader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class SelectLeader : MonoBehaviour
{
  private static readonly System.IntPtr NativeFieldInfoPtr_options;
  private static readonly System.IntPtr NativeFieldInfoPtr_differentTribes;
  private static readonly System.IntPtr NativeFieldInfoPtr_cardController;
  private static readonly System.IntPtr NativeFieldInfoPtr_leaderCardContainer;
  private static readonly System.IntPtr NativeFieldInfoPtr_selectionSequence;
  private static readonly System.IntPtr NativeFieldInfoPtr_titleSetter;
  private static readonly System.IntPtr NativeFieldInfoPtr_flagGroup;
  private static readonly System.IntPtr NativeFieldInfoPtr_flagBase;
  private static readonly System.IntPtr NativeFieldInfoPtr_flagOffset;
  private static readonly System.IntPtr NativeFieldInfoPtr_tribeDisplay;
  private static readonly System.IntPtr NativeFieldInfoPtr_flags;
  private static readonly System.IntPtr NativeFieldInfoPtr__current_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr_characters;
  private static readonly System.IntPtr NativeFieldInfoPtr_leaderPools;
  private static readonly System.IntPtr NativeFieldInfoPtr__generating_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__running_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr_seed;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_current_Public_get_Character_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_current_Private_set_Void_Character_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_generating_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_generating_Private_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_running_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_running_Private_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Run_Public_Void_List_1_ClassData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Hide_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Return_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetSeed_Public_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GenerateLeaders_Public_IEnumerator_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateLeader_Private_Card_ClassData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetLeaderPositions_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FlipUpLeaders_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FlipUpLeadersInstant_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FlipUpRoutine_Private_IEnumerator_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Reroll_Public_Virtual_Final_New_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Select_Public_Void_Entity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Select_Public_Void_Character_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Cancel_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  public unsafe SelectLeader.Character current
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SelectLeader.NativeMethodInfoPtr_get_current_Public_get_Character_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (SelectLeader.Character) null : new SelectLeader.Character(pointer);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SelectLeader.NativeMethodInfoPtr_set_current_Private_set_Void_Character_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }
  }

  public unsafe bool generating
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 88162, RefRangeEnd = 88163, XrefRangeStart = 88162, XrefRangeEnd = 88162, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SelectLeader.NativeMethodInfoPtr_get_generating_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SelectLeader.NativeMethodInfoPtr_set_generating_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }
  }

  public unsafe bool running
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SelectLeader.NativeMethodInfoPtr_get_running_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SelectLeader.NativeMethodInfoPtr_set_running_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 88200, RefRangeEnd = 88201, XrefRangeStart = 88163, XrefRangeEnd = 88200, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Run(List<ClassData> tribes)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) tribes)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SelectLeader.NativeMethodInfoPtr_Run_Public_Void_List_1_ClassData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88201, XrefRangeEnd = 88203, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Hide()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SelectLeader.NativeMethodInfoPtr_Hide_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88203, XrefRangeEnd = 88216, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Return()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SelectLeader.NativeMethodInfoPtr_Return_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88216, XrefRangeEnd = 88221, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetSeed(int seed)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &seed
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SelectLeader.NativeMethodInfoPtr_SetSeed_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 88226, RefRangeEnd = 88227, XrefRangeStart = 88221, XrefRangeEnd = 88226, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator GenerateLeaders(bool useSeed)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &useSeed
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SelectLeader.NativeMethodInfoPtr_GenerateLeaders_Public_IEnumerator_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 88263, RefRangeEnd = 88264, XrefRangeStart = 88227, XrefRangeEnd = 88263, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Card CreateLeader(ClassData classData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) classData)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SelectLeader.NativeMethodInfoPtr_CreateLeader_Private_Card_ClassData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (Card) null : new Card(pointer);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 88304, RefRangeEnd = 88307, XrefRangeStart = 88264, XrefRangeEnd = 88304, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Clear()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SelectLeader.NativeMethodInfoPtr_Clear_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 88350, RefRangeEnd = 88351, XrefRangeStart = 88307, XrefRangeEnd = 88350, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetLeaderPositions()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SelectLeader.NativeMethodInfoPtr_SetLeaderPositions_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88351, XrefRangeEnd = 88358, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void FlipUpLeaders()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SelectLeader.NativeMethodInfoPtr_FlipUpLeaders_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88358, XrefRangeEnd = 88373, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void FlipUpLeadersInstant()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SelectLeader.NativeMethodInfoPtr_FlipUpLeadersInstant_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88373, XrefRangeEnd = 88378, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator FlipUpRoutine()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SelectLeader.NativeMethodInfoPtr_FlipUpRoutine_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88378, XrefRangeEnd = 88390, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool Reroll()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SelectLeader.NativeMethodInfoPtr_Reroll_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88390, XrefRangeEnd = 88409, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Select(Entity entity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SelectLeader.NativeMethodInfoPtr_Select_Public_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Select(SelectLeader.Character character)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) character)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SelectLeader.NativeMethodInfoPtr_Select_Public_Void_Character_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88409, XrefRangeEnd = 88411, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Cancel()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SelectLeader.NativeMethodInfoPtr_Cancel_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88411, XrefRangeEnd = 88420, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SelectLeader()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectLeader>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SelectLeader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static SelectLeader()
  {
    Il2CppClassPointerStore<SelectLeader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (SelectLeader));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectLeader>.NativeClassPtr);
    SelectLeader.NativeFieldInfoPtr_options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectLeader>.NativeClassPtr, nameof (options));
    SelectLeader.NativeFieldInfoPtr_differentTribes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectLeader>.NativeClassPtr, nameof (differentTribes));
    SelectLeader.NativeFieldInfoPtr_cardController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectLeader>.NativeClassPtr, nameof (cardController));
    SelectLeader.NativeFieldInfoPtr_leaderCardContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectLeader>.NativeClassPtr, nameof (leaderCardContainer));
    SelectLeader.NativeFieldInfoPtr_selectionSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectLeader>.NativeClassPtr, nameof (selectionSequence));
    SelectLeader.NativeFieldInfoPtr_titleSetter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectLeader>.NativeClassPtr, nameof (titleSetter));
    SelectLeader.NativeFieldInfoPtr_flagGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectLeader>.NativeClassPtr, nameof (flagGroup));
    SelectLeader.NativeFieldInfoPtr_flagBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectLeader>.NativeClassPtr, nameof (flagBase));
    SelectLeader.NativeFieldInfoPtr_flagOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectLeader>.NativeClassPtr, nameof (flagOffset));
    SelectLeader.NativeFieldInfoPtr_tribeDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectLeader>.NativeClassPtr, nameof (tribeDisplay));
    SelectLeader.NativeFieldInfoPtr_flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectLeader>.NativeClassPtr, nameof (flags));
    SelectLeader.NativeFieldInfoPtr__current_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectLeader>.NativeClassPtr, "<current>k__BackingField");
    SelectLeader.NativeFieldInfoPtr_characters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectLeader>.NativeClassPtr, nameof (characters));
    SelectLeader.NativeFieldInfoPtr_leaderPools = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectLeader>.NativeClassPtr, nameof (leaderPools));
    SelectLeader.NativeFieldInfoPtr__generating_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectLeader>.NativeClassPtr, "<generating>k__BackingField");
    SelectLeader.NativeFieldInfoPtr__running_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectLeader>.NativeClassPtr, "<running>k__BackingField");
    SelectLeader.NativeFieldInfoPtr_seed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectLeader>.NativeClassPtr, nameof (seed));
    SelectLeader.NativeMethodInfoPtr_get_current_Public_get_Character_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectLeader>.NativeClassPtr, 100670738);
    SelectLeader.NativeMethodInfoPtr_set_current_Private_set_Void_Character_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectLeader>.NativeClassPtr, 100670739);
    SelectLeader.NativeMethodInfoPtr_get_generating_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectLeader>.NativeClassPtr, 100670740);
    SelectLeader.NativeMethodInfoPtr_set_generating_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectLeader>.NativeClassPtr, 100670741);
    SelectLeader.NativeMethodInfoPtr_get_running_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectLeader>.NativeClassPtr, 100670742);
    SelectLeader.NativeMethodInfoPtr_set_running_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectLeader>.NativeClassPtr, 100670743);
    SelectLeader.NativeMethodInfoPtr_Run_Public_Void_List_1_ClassData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectLeader>.NativeClassPtr, 100670744);
    SelectLeader.NativeMethodInfoPtr_Hide_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectLeader>.NativeClassPtr, 100670745);
    SelectLeader.NativeMethodInfoPtr_Return_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectLeader>.NativeClassPtr, 100670746);
    SelectLeader.NativeMethodInfoPtr_SetSeed_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectLeader>.NativeClassPtr, 100670747);
    SelectLeader.NativeMethodInfoPtr_GenerateLeaders_Public_IEnumerator_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectLeader>.NativeClassPtr, 100670748);
    SelectLeader.NativeMethodInfoPtr_CreateLeader_Private_Card_ClassData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectLeader>.NativeClassPtr, 100670749);
    SelectLeader.NativeMethodInfoPtr_Clear_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectLeader>.NativeClassPtr, 100670750);
    SelectLeader.NativeMethodInfoPtr_SetLeaderPositions_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectLeader>.NativeClassPtr, 100670751);
    SelectLeader.NativeMethodInfoPtr_FlipUpLeaders_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectLeader>.NativeClassPtr, 100670752);
    SelectLeader.NativeMethodInfoPtr_FlipUpLeadersInstant_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectLeader>.NativeClassPtr, 100670753);
    SelectLeader.NativeMethodInfoPtr_FlipUpRoutine_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectLeader>.NativeClassPtr, 100670754);
    SelectLeader.NativeMethodInfoPtr_Reroll_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectLeader>.NativeClassPtr, 100670755);
    SelectLeader.NativeMethodInfoPtr_Select_Public_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectLeader>.NativeClassPtr, 100670756);
    SelectLeader.NativeMethodInfoPtr_Select_Public_Void_Character_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectLeader>.NativeClassPtr, 100670757);
    SelectLeader.NativeMethodInfoPtr_Cancel_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectLeader>.NativeClassPtr, 100670758);
    SelectLeader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectLeader>.NativeClassPtr, 100670759);
  }

  public SelectLeader(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe int options
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SelectLeader.NativeFieldInfoPtr_options));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SelectLeader.NativeFieldInfoPtr_options)) = value;
    }
  }

  public unsafe int differentTribes
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SelectLeader.NativeFieldInfoPtr_differentTribes));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SelectLeader.NativeFieldInfoPtr_differentTribes)) = value;
    }
  }

  public unsafe CardController cardController
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SelectLeader.NativeFieldInfoPtr_cardController));
      return pointer == System.IntPtr.Zero ? (CardController) null : new CardController(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SelectLeader.NativeFieldInfoPtr_cardController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CardContainer leaderCardContainer
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SelectLeader.NativeFieldInfoPtr_leaderCardContainer));
      return pointer == System.IntPtr.Zero ? (CardContainer) null : new CardContainer(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SelectLeader.NativeFieldInfoPtr_leaderCardContainer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe InspectNewUnitSequence selectionSequence
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SelectLeader.NativeFieldInfoPtr_selectionSequence));
      return pointer == System.IntPtr.Zero ? (InspectNewUnitSequence) null : new InspectNewUnitSequence(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SelectLeader.NativeFieldInfoPtr_selectionSequence), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TitleSetter titleSetter
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SelectLeader.NativeFieldInfoPtr_titleSetter));
      return pointer == System.IntPtr.Zero ? (TitleSetter) null : new TitleSetter(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SelectLeader.NativeFieldInfoPtr_titleSetter), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Transform flagGroup
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SelectLeader.NativeFieldInfoPtr_flagGroup));
      return pointer == System.IntPtr.Zero ? (Transform) null : new Transform(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SelectLeader.NativeFieldInfoPtr_flagGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TribeFlagDisplay flagBase
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SelectLeader.NativeFieldInfoPtr_flagBase));
      return pointer == System.IntPtr.Zero ? (TribeFlagDisplay) null : new TribeFlagDisplay(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SelectLeader.NativeFieldInfoPtr_flagBase), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector3 flagOffset
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SelectLeader.NativeFieldInfoPtr_flagOffset));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SelectLeader.NativeFieldInfoPtr_flagOffset)) = value;
    }
  }

  public unsafe TribeDisplaySequence tribeDisplay
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SelectLeader.NativeFieldInfoPtr_tribeDisplay));
      return pointer == System.IntPtr.Zero ? (TribeDisplaySequence) null : new TribeDisplaySequence(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SelectLeader.NativeFieldInfoPtr_tribeDisplay), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<GameObject> flags
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SelectLeader.NativeFieldInfoPtr_flags));
      return pointer == System.IntPtr.Zero ? (List<GameObject>) null : new List<GameObject>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SelectLeader.NativeFieldInfoPtr_flags), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe SelectLeader.Character _current_k__BackingField
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SelectLeader.NativeFieldInfoPtr__current_k__BackingField));
      return pointer == System.IntPtr.Zero ? (SelectLeader.Character) null : new SelectLeader.Character(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SelectLeader.NativeFieldInfoPtr__current_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<SelectLeader.Character> characters
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SelectLeader.NativeFieldInfoPtr_characters));
      return pointer == System.IntPtr.Zero ? (List<SelectLeader.Character>) null : new List<SelectLeader.Character>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SelectLeader.NativeFieldInfoPtr_characters), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Dictionary<ClassData, SelectLeader.LeaderPool> leaderPools
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SelectLeader.NativeFieldInfoPtr_leaderPools));
      return pointer == System.IntPtr.Zero ? (Dictionary<ClassData, SelectLeader.LeaderPool>) null : new Dictionary<ClassData, SelectLeader.LeaderPool>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SelectLeader.NativeFieldInfoPtr_leaderPools), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool _generating_k__BackingField
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SelectLeader.NativeFieldInfoPtr__generating_k__BackingField));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SelectLeader.NativeFieldInfoPtr__generating_k__BackingField)) = value;
    }
  }

  public unsafe bool _running_k__BackingField
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SelectLeader.NativeFieldInfoPtr__running_k__BackingField));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SelectLeader.NativeFieldInfoPtr__running_k__BackingField)) = value;
    }
  }

  public unsafe int seed
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SelectLeader.NativeFieldInfoPtr_seed));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SelectLeader.NativeFieldInfoPtr_seed)) = value;
    }
  }

  public class Character : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_data;
    private static readonly System.IntPtr NativeFieldInfoPtr_entity;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_PlayerData_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddLeaderToInventory_Public_Void_0;

    [CallerCount(108)]
    [CachedScanResults(RefRangeStart = 87838, RefRangeEnd = 87946, XrefRangeStart = 87835, XrefRangeEnd = 87838, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Character(PlayerData data, Entity entity)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectLeader.Character>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SelectLeader.Character.NativeMethodInfoPtr__ctor_Public_Void_PlayerData_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87946, XrefRangeEnd = 87961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Clear()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SelectLeader.Character.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87961, XrefRangeEnd = 87964, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddLeaderToInventory()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SelectLeader.Character.NativeMethodInfoPtr_AddLeaderToInventory_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Character()
    {
      Il2CppClassPointerStore<SelectLeader.Character>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SelectLeader>.NativeClassPtr, nameof (Character));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectLeader.Character>.NativeClassPtr);
      SelectLeader.Character.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectLeader.Character>.NativeClassPtr, nameof (data));
      SelectLeader.Character.NativeFieldInfoPtr_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectLeader.Character>.NativeClassPtr, nameof (entity));
      SelectLeader.Character.NativeMethodInfoPtr__ctor_Public_Void_PlayerData_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectLeader.Character>.NativeClassPtr, 100670760);
      SelectLeader.Character.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectLeader.Character>.NativeClassPtr, 100670761);
      SelectLeader.Character.NativeMethodInfoPtr_AddLeaderToInventory_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectLeader.Character>.NativeClassPtr, 100670762);
    }

    public Character(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe PlayerData data
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SelectLeader.Character.NativeFieldInfoPtr_data));
        return pointer == System.IntPtr.Zero ? (PlayerData) null : new PlayerData(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SelectLeader.Character.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Entity entity
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SelectLeader.Character.NativeFieldInfoPtr_entity));
        return pointer == System.IntPtr.Zero ? (Entity) null : new Entity(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SelectLeader.Character.NativeFieldInfoPtr_entity), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  public class LeaderPool : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_classData;
    private static readonly System.IntPtr NativeFieldInfoPtr_pool;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ClassData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Pull_Public_CardData_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87964, XrefRangeEnd = 87974, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe LeaderPool(ClassData classData)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectLeader.LeaderPool>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) classData)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SelectLeader.LeaderPool.NativeMethodInfoPtr__ctor_Public_Void_ClassData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87974, XrefRangeEnd = 87987, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CardData Pull()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SelectLeader.LeaderPool.NativeMethodInfoPtr_Pull_Public_CardData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (CardData) null : new CardData(pointer);
    }

    static LeaderPool()
    {
      Il2CppClassPointerStore<SelectLeader.LeaderPool>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SelectLeader>.NativeClassPtr, nameof (LeaderPool));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectLeader.LeaderPool>.NativeClassPtr);
      SelectLeader.LeaderPool.NativeFieldInfoPtr_classData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectLeader.LeaderPool>.NativeClassPtr, nameof (classData));
      SelectLeader.LeaderPool.NativeFieldInfoPtr_pool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectLeader.LeaderPool>.NativeClassPtr, nameof (pool));
      SelectLeader.LeaderPool.NativeMethodInfoPtr__ctor_Public_Void_ClassData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectLeader.LeaderPool>.NativeClassPtr, 100670763);
      SelectLeader.LeaderPool.NativeMethodInfoPtr_Pull_Public_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectLeader.LeaderPool>.NativeClassPtr, 100670764);
    }

    public LeaderPool(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe ClassData classData
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SelectLeader.LeaderPool.NativeFieldInfoPtr_classData));
        return pointer == System.IntPtr.Zero ? (ClassData) null : new ClassData(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SelectLeader.LeaderPool.NativeFieldInfoPtr_classData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<CardData> pool
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SelectLeader.LeaderPool.NativeFieldInfoPtr_pool));
        return pointer == System.IntPtr.Zero ? (List<CardData>) null : new List<CardData>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SelectLeader.LeaderPool.NativeFieldInfoPtr_pool), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("SelectLeader/<>c__DisplayClass30_0")]
  public sealed class __c__DisplayClass30_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_c;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__GenerateLeaders_b__0_Internal_Void_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass30_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectLeader.__c__DisplayClass30_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SelectLeader.__c__DisplayClass30_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87987, XrefRangeEnd = 87990, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _GenerateLeaders_b__0()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SelectLeader.__c__DisplayClass30_0.NativeMethodInfoPtr__GenerateLeaders_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static __c__DisplayClass30_0()
    {
      Il2CppClassPointerStore<SelectLeader.__c__DisplayClass30_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SelectLeader>.NativeClassPtr, "<>c__DisplayClass30_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectLeader.__c__DisplayClass30_0>.NativeClassPtr);
      SelectLeader.__c__DisplayClass30_0.NativeFieldInfoPtr_c = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectLeader.__c__DisplayClass30_0>.NativeClassPtr, nameof (c));
      SelectLeader.__c__DisplayClass30_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectLeader.__c__DisplayClass30_0>.NativeClassPtr, "<>4__this");
      SelectLeader.__c__DisplayClass30_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectLeader.__c__DisplayClass30_0>.NativeClassPtr, 100670765);
      SelectLeader.__c__DisplayClass30_0.NativeMethodInfoPtr__GenerateLeaders_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectLeader.__c__DisplayClass30_0>.NativeClassPtr, 100670766);
    }

    public __c__DisplayClass30_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe SelectLeader.Character c
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SelectLeader.__c__DisplayClass30_0.NativeFieldInfoPtr_c));
        return pointer == System.IntPtr.Zero ? (SelectLeader.Character) null : new SelectLeader.Character(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SelectLeader.__c__DisplayClass30_0.NativeFieldInfoPtr_c), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SelectLeader __4__this
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SelectLeader.__c__DisplayClass30_0.NativeFieldInfoPtr___4__this));
        return pointer == System.IntPtr.Zero ? (SelectLeader) null : new SelectLeader(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SelectLeader.__c__DisplayClass30_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("SelectLeader/<GenerateLeaders>d__30")]
  public sealed class _GenerateLeaders_d__30 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr_useSeed;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr__availableTribes_5__2;
    private static readonly System.IntPtr NativeFieldInfoPtr___7__wrap2;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    [CallerCount(53)]
    [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _GenerateLeaders_d__30(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectLeader._GenerateLeaders_d__30>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SelectLeader._GenerateLeaders_d__30.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 87997, RefRangeEnd = 87998, XrefRangeStart = 87990, XrefRangeEnd = 87997, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SelectLeader._GenerateLeaders_d__30.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87998, XrefRangeEnd = 88112, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SelectLeader._GenerateLeaders_d__30.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88112, XrefRangeEnd = 88115, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void __m__Finally1()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SelectLeader._GenerateLeaders_d__30.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EGeneric\u002EIEnumerator\u003CSystem\u002EObject\u003E\u002ECurrent
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SelectLeader._GenerateLeaders_d__30.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88115, XrefRangeEnd = 88121, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SelectLeader._GenerateLeaders_d__30.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SelectLeader._GenerateLeaders_d__30.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    static _GenerateLeaders_d__30()
    {
      Il2CppClassPointerStore<SelectLeader._GenerateLeaders_d__30>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SelectLeader>.NativeClassPtr, "<GenerateLeaders>d__30");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectLeader._GenerateLeaders_d__30>.NativeClassPtr);
      SelectLeader._GenerateLeaders_d__30.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectLeader._GenerateLeaders_d__30>.NativeClassPtr, "<>1__state");
      SelectLeader._GenerateLeaders_d__30.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectLeader._GenerateLeaders_d__30>.NativeClassPtr, "<>2__current");
      SelectLeader._GenerateLeaders_d__30.NativeFieldInfoPtr_useSeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectLeader._GenerateLeaders_d__30>.NativeClassPtr, nameof (useSeed));
      SelectLeader._GenerateLeaders_d__30.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectLeader._GenerateLeaders_d__30>.NativeClassPtr, "<>4__this");
      SelectLeader._GenerateLeaders_d__30.NativeFieldInfoPtr__availableTribes_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectLeader._GenerateLeaders_d__30>.NativeClassPtr, "<availableTribes>5__2");
      SelectLeader._GenerateLeaders_d__30.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectLeader._GenerateLeaders_d__30>.NativeClassPtr, "<>7__wrap2");
      SelectLeader._GenerateLeaders_d__30.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectLeader._GenerateLeaders_d__30>.NativeClassPtr, 100670767);
      SelectLeader._GenerateLeaders_d__30.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectLeader._GenerateLeaders_d__30>.NativeClassPtr, 100670768);
      SelectLeader._GenerateLeaders_d__30.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectLeader._GenerateLeaders_d__30>.NativeClassPtr, 100670769);
      SelectLeader._GenerateLeaders_d__30.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectLeader._GenerateLeaders_d__30>.NativeClassPtr, 100670770);
      SelectLeader._GenerateLeaders_d__30.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectLeader._GenerateLeaders_d__30>.NativeClassPtr, 100670771);
      SelectLeader._GenerateLeaders_d__30.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectLeader._GenerateLeaders_d__30>.NativeClassPtr, 100670772);
      SelectLeader._GenerateLeaders_d__30.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectLeader._GenerateLeaders_d__30>.NativeClassPtr, 100670773);
    }

    public _GenerateLeaders_d__30(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SelectLeader._GenerateLeaders_d__30.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SelectLeader._GenerateLeaders_d__30.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SelectLeader._GenerateLeaders_d__30.NativeFieldInfoPtr___2__current));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SelectLeader._GenerateLeaders_d__30.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool useSeed
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SelectLeader._GenerateLeaders_d__30.NativeFieldInfoPtr_useSeed));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SelectLeader._GenerateLeaders_d__30.NativeFieldInfoPtr_useSeed)) = value;
      }
    }

    public unsafe SelectLeader __4__this
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SelectLeader._GenerateLeaders_d__30.NativeFieldInfoPtr___4__this));
        return pointer == System.IntPtr.Zero ? (SelectLeader) null : new SelectLeader(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SelectLeader._GenerateLeaders_d__30.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<ClassData> _availableTribes_5__2
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SelectLeader._GenerateLeaders_d__30.NativeFieldInfoPtr__availableTribes_5__2));
        return pointer == System.IntPtr.Zero ? (List<ClassData>) null : new List<ClassData>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SelectLeader._GenerateLeaders_d__30.NativeFieldInfoPtr__availableTribes_5__2), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public List<Card>.Enumerator __7__wrap2
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SelectLeader._GenerateLeaders_d__30.NativeFieldInfoPtr___7__wrap2);
        return new List<Card>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<Card>.Enumerator>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SelectLeader._GenerateLeaders_d__30.NativeFieldInfoPtr___7__wrap2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<Card>.Enumerator>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }

  [ObfuscatedName("SelectLeader/<FlipUpRoutine>d__36")]
  public sealed class _FlipUpRoutine_d__36 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr___7__wrap1;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    [CallerCount(53)]
    [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _FlipUpRoutine_d__36(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectLeader._FlipUpRoutine_d__36>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SelectLeader._FlipUpRoutine_d__36.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 88128, RefRangeEnd = 88129, XrefRangeStart = 88121, XrefRangeEnd = 88128, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SelectLeader._FlipUpRoutine_d__36.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88129, XrefRangeEnd = 88148, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SelectLeader._FlipUpRoutine_d__36.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88148, XrefRangeEnd = 88151, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void __m__Finally1()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SelectLeader._FlipUpRoutine_d__36.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EGeneric\u002EIEnumerator\u003CSystem\u002EObject\u003E\u002ECurrent
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SelectLeader._FlipUpRoutine_d__36.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88151, XrefRangeEnd = 88157, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SelectLeader._FlipUpRoutine_d__36.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SelectLeader._FlipUpRoutine_d__36.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    static _FlipUpRoutine_d__36()
    {
      Il2CppClassPointerStore<SelectLeader._FlipUpRoutine_d__36>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SelectLeader>.NativeClassPtr, "<FlipUpRoutine>d__36");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectLeader._FlipUpRoutine_d__36>.NativeClassPtr);
      SelectLeader._FlipUpRoutine_d__36.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectLeader._FlipUpRoutine_d__36>.NativeClassPtr, "<>1__state");
      SelectLeader._FlipUpRoutine_d__36.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectLeader._FlipUpRoutine_d__36>.NativeClassPtr, "<>2__current");
      SelectLeader._FlipUpRoutine_d__36.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectLeader._FlipUpRoutine_d__36>.NativeClassPtr, "<>4__this");
      SelectLeader._FlipUpRoutine_d__36.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectLeader._FlipUpRoutine_d__36>.NativeClassPtr, "<>7__wrap1");
      SelectLeader._FlipUpRoutine_d__36.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectLeader._FlipUpRoutine_d__36>.NativeClassPtr, 100670774);
      SelectLeader._FlipUpRoutine_d__36.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectLeader._FlipUpRoutine_d__36>.NativeClassPtr, 100670775);
      SelectLeader._FlipUpRoutine_d__36.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectLeader._FlipUpRoutine_d__36>.NativeClassPtr, 100670776);
      SelectLeader._FlipUpRoutine_d__36.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectLeader._FlipUpRoutine_d__36>.NativeClassPtr, 100670777);
      SelectLeader._FlipUpRoutine_d__36.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectLeader._FlipUpRoutine_d__36>.NativeClassPtr, 100670778);
      SelectLeader._FlipUpRoutine_d__36.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectLeader._FlipUpRoutine_d__36>.NativeClassPtr, 100670779);
      SelectLeader._FlipUpRoutine_d__36.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectLeader._FlipUpRoutine_d__36>.NativeClassPtr, 100670780);
    }

    public _FlipUpRoutine_d__36(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SelectLeader._FlipUpRoutine_d__36.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SelectLeader._FlipUpRoutine_d__36.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SelectLeader._FlipUpRoutine_d__36.NativeFieldInfoPtr___2__current));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SelectLeader._FlipUpRoutine_d__36.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SelectLeader __4__this
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SelectLeader._FlipUpRoutine_d__36.NativeFieldInfoPtr___4__this));
        return pointer == System.IntPtr.Zero ? (SelectLeader) null : new SelectLeader(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SelectLeader._FlipUpRoutine_d__36.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe IEnumerator<Entity> __7__wrap1
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SelectLeader._FlipUpRoutine_d__36.NativeFieldInfoPtr___7__wrap1));
        return pointer == System.IntPtr.Zero ? (IEnumerator<Entity>) null : new IEnumerator<Entity>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SelectLeader._FlipUpRoutine_d__36.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("SelectLeader/<>c__DisplayClass38_0")]
  public sealed class __c__DisplayClass38_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_entity;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Select_b__0_Internal_Boolean_Character_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass38_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectLeader.__c__DisplayClass38_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SelectLeader.__c__DisplayClass38_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88157, XrefRangeEnd = 88162, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _Select_b__0(SelectLeader.Character a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SelectLeader.__c__DisplayClass38_0.NativeMethodInfoPtr__Select_b__0_Internal_Boolean_Character_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c__DisplayClass38_0()
    {
      Il2CppClassPointerStore<SelectLeader.__c__DisplayClass38_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SelectLeader>.NativeClassPtr, "<>c__DisplayClass38_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectLeader.__c__DisplayClass38_0>.NativeClassPtr);
      SelectLeader.__c__DisplayClass38_0.NativeFieldInfoPtr_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectLeader.__c__DisplayClass38_0>.NativeClassPtr, nameof (entity));
      SelectLeader.__c__DisplayClass38_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectLeader.__c__DisplayClass38_0>.NativeClassPtr, 100670781);
      SelectLeader.__c__DisplayClass38_0.NativeMethodInfoPtr__Select_b__0_Internal_Boolean_Character_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectLeader.__c__DisplayClass38_0>.NativeClassPtr, 100670782);
    }

    public __c__DisplayClass38_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Entity entity
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SelectLeader.__c__DisplayClass38_0.NativeFieldInfoPtr_entity));
        return pointer == System.IntPtr.Zero ? (Entity) null : new Entity(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SelectLeader.__c__DisplayClass38_0.NativeFieldInfoPtr_entity), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
