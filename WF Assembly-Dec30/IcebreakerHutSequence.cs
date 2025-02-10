// Decompiled with JetBrains decompiler
// Type: IcebreakerHutSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using FMODUnity;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class IcebreakerHutSequence : BuildingSequence
{
  private static readonly System.IntPtr NativeFieldInfoPtr_metaprogressionKey;
  private static readonly System.IntPtr NativeFieldInfoPtr_nodes;
  private static readonly System.IntPtr NativeFieldInfoPtr_buttons;
  private static readonly System.IntPtr NativeFieldInfoPtr_challenges;
  private static readonly System.IntPtr NativeFieldInfoPtr_challengeDisplayCreator;
  private static readonly System.IntPtr NativeFieldInfoPtr_firstGreetKey;
  private static readonly System.IntPtr NativeFieldInfoPtr_mapInspectSequence;
  private static readonly System.IntPtr NativeFieldInfoPtr_denySfx;
  private static readonly System.IntPtr NativeFieldInfoPtr_unlocked;
  private static readonly System.IntPtr NativeMethodInfoPtr_Sequence_Protected_Virtual_IEnumerator_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Unlock_Private_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetUpMapNodes_Private_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetCurrentChallenge_Private_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryInspect_Public_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Deny_Private_Void_GameObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84215, XrefRangeEnd = 84220, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe IEnumerator Sequence()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IcebreakerHutSequence.NativeMethodInfoPtr_Sequence_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84220, XrefRangeEnd = 84248, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Unlock(string unlockDataName)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(unlockDataName)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IcebreakerHutSequence.NativeMethodInfoPtr_Unlock_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 84278, RefRangeEnd = 84279, XrefRangeStart = 84248, XrefRangeEnd = 84278, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetUpMapNodes(int unlocked)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &unlocked
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IcebreakerHutSequence.NativeMethodInfoPtr_SetUpMapNodes_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84279, XrefRangeEnd = 84281, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetCurrentChallenge(int unlocked)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &unlocked
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IcebreakerHutSequence.NativeMethodInfoPtr_SetCurrentChallenge_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84281, XrefRangeEnd = 84302, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void TryInspect(int mapNodeIndex)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &mapNodeIndex
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IcebreakerHutSequence.NativeMethodInfoPtr_TryInspect_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84302, XrefRangeEnd = 84317, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Deny(GameObject obj)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IcebreakerHutSequence.NativeMethodInfoPtr_Deny_Private_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84317, XrefRangeEnd = 84334, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IcebreakerHutSequence()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IcebreakerHutSequence>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IcebreakerHutSequence.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static IcebreakerHutSequence()
  {
    Il2CppClassPointerStore<IcebreakerHutSequence>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (IcebreakerHutSequence));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IcebreakerHutSequence>.NativeClassPtr);
    IcebreakerHutSequence.NativeFieldInfoPtr_metaprogressionKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IcebreakerHutSequence>.NativeClassPtr, nameof (metaprogressionKey));
    IcebreakerHutSequence.NativeFieldInfoPtr_nodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IcebreakerHutSequence>.NativeClassPtr, nameof (nodes));
    IcebreakerHutSequence.NativeFieldInfoPtr_buttons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IcebreakerHutSequence>.NativeClassPtr, nameof (buttons));
    IcebreakerHutSequence.NativeFieldInfoPtr_challenges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IcebreakerHutSequence>.NativeClassPtr, nameof (challenges));
    IcebreakerHutSequence.NativeFieldInfoPtr_challengeDisplayCreator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IcebreakerHutSequence>.NativeClassPtr, nameof (challengeDisplayCreator));
    IcebreakerHutSequence.NativeFieldInfoPtr_firstGreetKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IcebreakerHutSequence>.NativeClassPtr, nameof (firstGreetKey));
    IcebreakerHutSequence.NativeFieldInfoPtr_mapInspectSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IcebreakerHutSequence>.NativeClassPtr, nameof (mapInspectSequence));
    IcebreakerHutSequence.NativeFieldInfoPtr_denySfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IcebreakerHutSequence>.NativeClassPtr, nameof (denySfx));
    IcebreakerHutSequence.NativeFieldInfoPtr_unlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IcebreakerHutSequence>.NativeClassPtr, nameof (unlocked));
    IcebreakerHutSequence.NativeMethodInfoPtr_Sequence_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IcebreakerHutSequence>.NativeClassPtr, 100670301);
    IcebreakerHutSequence.NativeMethodInfoPtr_Unlock_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IcebreakerHutSequence>.NativeClassPtr, 100670302);
    IcebreakerHutSequence.NativeMethodInfoPtr_SetUpMapNodes_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IcebreakerHutSequence>.NativeClassPtr, 100670303);
    IcebreakerHutSequence.NativeMethodInfoPtr_SetCurrentChallenge_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IcebreakerHutSequence>.NativeClassPtr, 100670304);
    IcebreakerHutSequence.NativeMethodInfoPtr_TryInspect_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IcebreakerHutSequence>.NativeClassPtr, 100670305);
    IcebreakerHutSequence.NativeMethodInfoPtr_Deny_Private_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IcebreakerHutSequence>.NativeClassPtr, 100670306);
    IcebreakerHutSequence.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IcebreakerHutSequence>.NativeClassPtr, 100670307);
  }

  public IcebreakerHutSequence(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe string metaprogressionKey
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(IcebreakerHutSequence.NativeFieldInfoPtr_metaprogressionKey)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(IcebreakerHutSequence.NativeFieldInfoPtr_metaprogressionKey), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe Il2CppReferenceArray<ImageSprite> nodes
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(IcebreakerHutSequence.NativeFieldInfoPtr_nodes));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<ImageSprite>) null : new Il2CppReferenceArray<ImageSprite>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(IcebreakerHutSequence.NativeFieldInfoPtr_nodes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<ButtonAnimator> buttons
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(IcebreakerHutSequence.NativeFieldInfoPtr_buttons));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<ButtonAnimator>) null : new Il2CppReferenceArray<ButtonAnimator>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(IcebreakerHutSequence.NativeFieldInfoPtr_buttons), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<ChallengeData> challenges
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(IcebreakerHutSequence.NativeFieldInfoPtr_challenges));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<ChallengeData>) null : new Il2CppReferenceArray<ChallengeData>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(IcebreakerHutSequence.NativeFieldInfoPtr_challenges), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ChallengeDisplayCreator challengeDisplayCreator
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(IcebreakerHutSequence.NativeFieldInfoPtr_challengeDisplayCreator));
      return pointer == System.IntPtr.Zero ? (ChallengeDisplayCreator) null : new ChallengeDisplayCreator(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(IcebreakerHutSequence.NativeFieldInfoPtr_challengeDisplayCreator), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe string firstGreetKey
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(IcebreakerHutSequence.NativeFieldInfoPtr_firstGreetKey)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(IcebreakerHutSequence.NativeFieldInfoPtr_firstGreetKey), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe MapInspectSequence mapInspectSequence
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(IcebreakerHutSequence.NativeFieldInfoPtr_mapInspectSequence));
      return pointer == System.IntPtr.Zero ? (MapInspectSequence) null : new MapInspectSequence(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(IcebreakerHutSequence.NativeFieldInfoPtr_mapInspectSequence), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe EventReference denySfx
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(IcebreakerHutSequence.NativeFieldInfoPtr_denySfx));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(IcebreakerHutSequence.NativeFieldInfoPtr_denySfx)) = value;
    }
  }

  public unsafe List<bool> unlocked
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(IcebreakerHutSequence.NativeFieldInfoPtr_unlocked));
      return pointer == System.IntPtr.Zero ? (List<bool>) null : new List<bool>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(IcebreakerHutSequence.NativeFieldInfoPtr_unlocked), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [ObfuscatedName("IcebreakerHutSequence/<Sequence>d__9")]
  public sealed class _Sequence_d__9 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    [CallerCount(53)]
    [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _Sequence_d__9(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IcebreakerHutSequence._Sequence_d__9>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IcebreakerHutSequence._Sequence_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(12611)]
    [CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12665, XrefRangeStart = 54, XrefRangeEnd = 12665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IcebreakerHutSequence._Sequence_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84130, XrefRangeEnd = 84209, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IcebreakerHutSequence._Sequence_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IcebreakerHutSequence._Sequence_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84209, XrefRangeEnd = 84215, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IcebreakerHutSequence._Sequence_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IcebreakerHutSequence._Sequence_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    static _Sequence_d__9()
    {
      Il2CppClassPointerStore<IcebreakerHutSequence._Sequence_d__9>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IcebreakerHutSequence>.NativeClassPtr, "<Sequence>d__9");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IcebreakerHutSequence._Sequence_d__9>.NativeClassPtr);
      IcebreakerHutSequence._Sequence_d__9.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IcebreakerHutSequence._Sequence_d__9>.NativeClassPtr, "<>1__state");
      IcebreakerHutSequence._Sequence_d__9.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IcebreakerHutSequence._Sequence_d__9>.NativeClassPtr, "<>2__current");
      IcebreakerHutSequence._Sequence_d__9.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IcebreakerHutSequence._Sequence_d__9>.NativeClassPtr, "<>4__this");
      IcebreakerHutSequence._Sequence_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IcebreakerHutSequence._Sequence_d__9>.NativeClassPtr, 100670308);
      IcebreakerHutSequence._Sequence_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IcebreakerHutSequence._Sequence_d__9>.NativeClassPtr, 100670309);
      IcebreakerHutSequence._Sequence_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IcebreakerHutSequence._Sequence_d__9>.NativeClassPtr, 100670310);
      IcebreakerHutSequence._Sequence_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IcebreakerHutSequence._Sequence_d__9>.NativeClassPtr, 100670311);
      IcebreakerHutSequence._Sequence_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IcebreakerHutSequence._Sequence_d__9>.NativeClassPtr, 100670312);
      IcebreakerHutSequence._Sequence_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IcebreakerHutSequence._Sequence_d__9>.NativeClassPtr, 100670313);
    }

    public _Sequence_d__9(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(IcebreakerHutSequence._Sequence_d__9.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(IcebreakerHutSequence._Sequence_d__9.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(IcebreakerHutSequence._Sequence_d__9.NativeFieldInfoPtr___2__current));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(IcebreakerHutSequence._Sequence_d__9.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe IcebreakerHutSequence __4__this
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(IcebreakerHutSequence._Sequence_d__9.NativeFieldInfoPtr___4__this));
        return pointer == System.IntPtr.Zero ? (IcebreakerHutSequence) null : new IcebreakerHutSequence(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(IcebreakerHutSequence._Sequence_d__9.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
