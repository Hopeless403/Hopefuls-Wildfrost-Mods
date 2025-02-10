// Decompiled with JetBrains decompiler
// Type: DeathSfxSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using FMODUnity;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;

#nullable disable
public class DeathSfxSystem : GameSystem
{
  private static readonly System.IntPtr NativeFieldInfoPtr_globalChance;
  private static readonly System.IntPtr NativeFieldInfoPtr_globalChanceAdd;
  private static readonly System.IntPtr NativeFieldInfoPtr_profiles;
  private static readonly System.IntPtr NativeFieldInfoPtr_currentGlobalChance;
  private static readonly System.IntPtr NativeFieldInfoPtr_profileLookup;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EntityKilled_Private_Void_Entity_DeathType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CheckChance_Private_Boolean_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71457, XrefRangeEnd = 71479, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DeathSfxSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71479, XrefRangeEnd = 71487, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DeathSfxSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71487, XrefRangeEnd = 71495, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EntityKilled(Entity entity, DeathType deathType)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &deathType;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DeathSfxSystem.NativeMethodInfoPtr_EntityKilled_Private_Void_Entity_DeathType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71495, XrefRangeEnd = 71496, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool CheckChance(float chance)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &chance
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DeathSfxSystem.NativeMethodInfoPtr_CheckChance_Private_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71496, XrefRangeEnd = 71505, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe DeathSfxSystem()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeathSfxSystem>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DeathSfxSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static DeathSfxSystem()
  {
    Il2CppClassPointerStore<DeathSfxSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (DeathSfxSystem));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeathSfxSystem>.NativeClassPtr);
    DeathSfxSystem.NativeFieldInfoPtr_globalChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeathSfxSystem>.NativeClassPtr, nameof (globalChance));
    DeathSfxSystem.NativeFieldInfoPtr_globalChanceAdd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeathSfxSystem>.NativeClassPtr, nameof (globalChanceAdd));
    DeathSfxSystem.NativeFieldInfoPtr_profiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeathSfxSystem>.NativeClassPtr, nameof (profiles));
    DeathSfxSystem.NativeFieldInfoPtr_currentGlobalChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeathSfxSystem>.NativeClassPtr, nameof (currentGlobalChance));
    DeathSfxSystem.NativeFieldInfoPtr_profileLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeathSfxSystem>.NativeClassPtr, nameof (profileLookup));
    DeathSfxSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeathSfxSystem>.NativeClassPtr, 100669157);
    DeathSfxSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeathSfxSystem>.NativeClassPtr, 100669158);
    DeathSfxSystem.NativeMethodInfoPtr_EntityKilled_Private_Void_Entity_DeathType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeathSfxSystem>.NativeClassPtr, 100669159);
    DeathSfxSystem.NativeMethodInfoPtr_CheckChance_Private_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeathSfxSystem>.NativeClassPtr, 100669160);
    DeathSfxSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeathSfxSystem>.NativeClassPtr, 100669161);
  }

  public DeathSfxSystem(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe float globalChance
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeathSfxSystem.NativeFieldInfoPtr_globalChance));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeathSfxSystem.NativeFieldInfoPtr_globalChance)) = value;
    }
  }

  public unsafe float globalChanceAdd
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeathSfxSystem.NativeFieldInfoPtr_globalChanceAdd));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeathSfxSystem.NativeFieldInfoPtr_globalChanceAdd)) = value;
    }
  }

  public unsafe Il2CppReferenceArray<DeathSfxSystem.Profile> profiles
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeathSfxSystem.NativeFieldInfoPtr_profiles));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<DeathSfxSystem.Profile>) null : new Il2CppReferenceArray<DeathSfxSystem.Profile>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DeathSfxSystem.NativeFieldInfoPtr_profiles), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float currentGlobalChance
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeathSfxSystem.NativeFieldInfoPtr_currentGlobalChance));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeathSfxSystem.NativeFieldInfoPtr_currentGlobalChance)) = value;
    }
  }

  public unsafe Dictionary<string, Il2CppSystem.Tuple<DeathSfxSystem.Profile, float>> profileLookup
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeathSfxSystem.NativeFieldInfoPtr_profileLookup));
      return pointer == System.IntPtr.Zero ? (Dictionary<string, Il2CppSystem.Tuple<DeathSfxSystem.Profile, float>>) null : new Dictionary<string, Il2CppSystem.Tuple<DeathSfxSystem.Profile, float>>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DeathSfxSystem.NativeFieldInfoPtr_profileLookup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [Serializable]
  public class Profile : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_eventReference;
    private static readonly System.IntPtr NativeFieldInfoPtr_cards;
    private static readonly System.IntPtr NativeFieldInfoPtr_chance;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Profile()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeathSfxSystem.Profile>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DeathSfxSystem.Profile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Profile()
    {
      Il2CppClassPointerStore<DeathSfxSystem.Profile>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeathSfxSystem>.NativeClassPtr, nameof (Profile));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeathSfxSystem.Profile>.NativeClassPtr);
      DeathSfxSystem.Profile.NativeFieldInfoPtr_eventReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeathSfxSystem.Profile>.NativeClassPtr, nameof (eventReference));
      DeathSfxSystem.Profile.NativeFieldInfoPtr_cards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeathSfxSystem.Profile>.NativeClassPtr, nameof (cards));
      DeathSfxSystem.Profile.NativeFieldInfoPtr_chance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeathSfxSystem.Profile>.NativeClassPtr, nameof (chance));
      DeathSfxSystem.Profile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeathSfxSystem.Profile>.NativeClassPtr, 100669162);
    }

    public Profile(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe EventReference eventReference
    {
      get
      {
        return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeathSfxSystem.Profile.NativeFieldInfoPtr_eventReference));
      }
      [param: In] set
      {
        *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeathSfxSystem.Profile.NativeFieldInfoPtr_eventReference)) = value;
      }
    }

    public unsafe Il2CppReferenceArray<DeathSfxSystem.CardRef> cards
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeathSfxSystem.Profile.NativeFieldInfoPtr_cards));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<DeathSfxSystem.CardRef>) null : new Il2CppReferenceArray<DeathSfxSystem.CardRef>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DeathSfxSystem.Profile.NativeFieldInfoPtr_cards), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float chance
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeathSfxSystem.Profile.NativeFieldInfoPtr_chance));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeathSfxSystem.Profile.NativeFieldInfoPtr_chance)) = value;
      }
    }
  }

  [Serializable]
  public class CardRef : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_card;
    private static readonly System.IntPtr NativeFieldInfoPtr_pitchShift;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CardRef()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeathSfxSystem.CardRef>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DeathSfxSystem.CardRef.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CardRef()
    {
      Il2CppClassPointerStore<DeathSfxSystem.CardRef>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeathSfxSystem>.NativeClassPtr, nameof (CardRef));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeathSfxSystem.CardRef>.NativeClassPtr);
      DeathSfxSystem.CardRef.NativeFieldInfoPtr_card = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeathSfxSystem.CardRef>.NativeClassPtr, nameof (card));
      DeathSfxSystem.CardRef.NativeFieldInfoPtr_pitchShift = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeathSfxSystem.CardRef>.NativeClassPtr, nameof (pitchShift));
      DeathSfxSystem.CardRef.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeathSfxSystem.CardRef>.NativeClassPtr, 100669163);
    }

    public CardRef(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe CardData card
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeathSfxSystem.CardRef.NativeFieldInfoPtr_card));
        return pointer == System.IntPtr.Zero ? (CardData) null : new CardData(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DeathSfxSystem.CardRef.NativeFieldInfoPtr_card), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float pitchShift
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeathSfxSystem.CardRef.NativeFieldInfoPtr_pitchShift));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeathSfxSystem.CardRef.NativeFieldInfoPtr_pitchShift)) = value;
      }
    }
  }
}
