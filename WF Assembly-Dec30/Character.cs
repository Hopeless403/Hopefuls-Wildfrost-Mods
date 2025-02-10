// Decompiled with JetBrains decompiler
// Type: Character
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class Character : MonoBehaviour
{
  private static readonly System.IntPtr NativeFieldInfoPtr_data;
  private static readonly System.IntPtr NativeFieldInfoPtr_title;
  private static readonly System.IntPtr NativeFieldInfoPtr_team;
  private static readonly System.IntPtr NativeFieldInfoPtr_entity;
  private static readonly System.IntPtr NativeFieldInfoPtr_drawContainer;
  private static readonly System.IntPtr NativeFieldInfoPtr_handContainer;
  private static readonly System.IntPtr NativeFieldInfoPtr_discardContainer;
  private static readonly System.IntPtr NativeFieldInfoPtr_reserveContainer;
  private static readonly System.IntPtr NativeFieldInfoPtr_freeAction;
  private static readonly System.IntPtr NativeFieldInfoPtr_endTurn;
  private static readonly System.IntPtr NativeFieldInfoPtr_autoTriggerUnits;
  private static readonly System.IntPtr NativeMethodInfoPtr_Assign_Public_Void_PlayerData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetCompanionCount_Public_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GainGold_Public_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SpendGold_Public_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Gain10Gold_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Gain100Gold_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Save_Public_Virtual_Final_New_CharacterSaveData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37195, XrefRangeEnd = 37196, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Assign(PlayerData data)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Character.NativeMethodInfoPtr_Assign_Public_Void_PlayerData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 37213, RefRangeEnd = 37217, XrefRangeStart = 37196, XrefRangeEnd = 37213, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe int GetCompanionCount()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Character.NativeMethodInfoPtr_GetCompanionCount_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(int*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 37224, RefRangeEnd = 37230, XrefRangeStart = 37217, XrefRangeEnd = 37224, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void GainGold(int amount)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &amount
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Character.NativeMethodInfoPtr_GainGold_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 37238, RefRangeEnd = 37242, XrefRangeStart = 37230, XrefRangeEnd = 37238, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SpendGold(int amount)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &amount
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Character.NativeMethodInfoPtr_SpendGold_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37242, XrefRangeEnd = 37243, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Gain10Gold()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Character.NativeMethodInfoPtr_Gain10Gold_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37243, XrefRangeEnd = 37244, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Gain100Gold()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Character.NativeMethodInfoPtr_Gain100Gold_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37244, XrefRangeEnd = 37248, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe CharacterSaveData Save()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Character.NativeMethodInfoPtr_Save_Public_Virtual_Final_New_CharacterSaveData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (CharacterSaveData) null : new CharacterSaveData(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37248, XrefRangeEnd = 37250, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe bool Equals(Il2CppSystem.Object other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Character.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37250, XrefRangeEnd = 37251, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Character()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Character>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Character.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static Character()
  {
    Il2CppClassPointerStore<Character>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (Character));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Character>.NativeClassPtr);
    Character.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Character>.NativeClassPtr, nameof (data));
    Character.NativeFieldInfoPtr_title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Character>.NativeClassPtr, nameof (title));
    Character.NativeFieldInfoPtr_team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Character>.NativeClassPtr, nameof (team));
    Character.NativeFieldInfoPtr_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Character>.NativeClassPtr, nameof (entity));
    Character.NativeFieldInfoPtr_drawContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Character>.NativeClassPtr, nameof (drawContainer));
    Character.NativeFieldInfoPtr_handContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Character>.NativeClassPtr, nameof (handContainer));
    Character.NativeFieldInfoPtr_discardContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Character>.NativeClassPtr, nameof (discardContainer));
    Character.NativeFieldInfoPtr_reserveContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Character>.NativeClassPtr, nameof (reserveContainer));
    Character.NativeFieldInfoPtr_freeAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Character>.NativeClassPtr, nameof (freeAction));
    Character.NativeFieldInfoPtr_endTurn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Character>.NativeClassPtr, nameof (endTurn));
    Character.NativeFieldInfoPtr_autoTriggerUnits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Character>.NativeClassPtr, nameof (autoTriggerUnits));
    Character.NativeMethodInfoPtr_Assign_Public_Void_PlayerData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Character>.NativeClassPtr, 100665793);
    Character.NativeMethodInfoPtr_GetCompanionCount_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Character>.NativeClassPtr, 100665794);
    Character.NativeMethodInfoPtr_GainGold_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Character>.NativeClassPtr, 100665795);
    Character.NativeMethodInfoPtr_SpendGold_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Character>.NativeClassPtr, 100665796);
    Character.NativeMethodInfoPtr_Gain10Gold_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Character>.NativeClassPtr, 100665797);
    Character.NativeMethodInfoPtr_Gain100Gold_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Character>.NativeClassPtr, 100665798);
    Character.NativeMethodInfoPtr_Save_Public_Virtual_Final_New_CharacterSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Character>.NativeClassPtr, 100665799);
    Character.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Character>.NativeClassPtr, 100665800);
    Character.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Character>.NativeClassPtr, 100665801);
  }

  public Character(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe PlayerData data
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Character.NativeFieldInfoPtr_data));
      return pointer == System.IntPtr.Zero ? (PlayerData) null : new PlayerData(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Character.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe string title
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Character.NativeFieldInfoPtr_title)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Character.NativeFieldInfoPtr_title), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe int team
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Character.NativeFieldInfoPtr_team));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Character.NativeFieldInfoPtr_team)) = value;
    }
  }

  public unsafe Entity entity
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Character.NativeFieldInfoPtr_entity));
      return pointer == System.IntPtr.Zero ? (Entity) null : new Entity(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Character.NativeFieldInfoPtr_entity), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CardContainer drawContainer
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Character.NativeFieldInfoPtr_drawContainer));
      return pointer == System.IntPtr.Zero ? (CardContainer) null : new CardContainer(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Character.NativeFieldInfoPtr_drawContainer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CardContainer handContainer
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Character.NativeFieldInfoPtr_handContainer));
      return pointer == System.IntPtr.Zero ? (CardContainer) null : new CardContainer(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Character.NativeFieldInfoPtr_handContainer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CardContainer discardContainer
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Character.NativeFieldInfoPtr_discardContainer));
      return pointer == System.IntPtr.Zero ? (CardContainer) null : new CardContainer(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Character.NativeFieldInfoPtr_discardContainer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CardContainer reserveContainer
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Character.NativeFieldInfoPtr_reserveContainer));
      return pointer == System.IntPtr.Zero ? (CardContainer) null : new CardContainer(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Character.NativeFieldInfoPtr_reserveContainer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool freeAction
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Character.NativeFieldInfoPtr_freeAction));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Character.NativeFieldInfoPtr_freeAction)) = value;
    }
  }

  public unsafe bool endTurn
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Character.NativeFieldInfoPtr_endTurn));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Character.NativeFieldInfoPtr_endTurn)) = value;
    }
  }

  public unsafe bool autoTriggerUnits
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Character.NativeFieldInfoPtr_autoTriggerUnits));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Character.NativeFieldInfoPtr_autoTriggerUnits)) = value;
    }
  }

  [ObfuscatedName("Character/<>c")]
  [Serializable]
  public sealed class __c : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__12_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__GetCompanionCount_b__12_0_Internal_Boolean_CardData_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Character.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Character.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37190, XrefRangeEnd = 37195, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _GetCompanionCount_b__12_0(CardData a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Character.__c.NativeMethodInfoPtr__GetCompanionCount_b__12_0_Internal_Boolean_CardData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c()
    {
      Il2CppClassPointerStore<Character.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Character>.NativeClassPtr, "<>c");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Character.__c>.NativeClassPtr);
      Character.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Character.__c>.NativeClassPtr, "<>9");
      Character.__c.NativeFieldInfoPtr___9__12_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Character.__c>.NativeClassPtr, "<>9__12_0");
      Character.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Character.__c>.NativeClassPtr, 100665803);
      Character.__c.NativeMethodInfoPtr__GetCompanionCount_b__12_0_Internal_Boolean_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Character.__c>.NativeClassPtr, 100665804);
    }

    public __c(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe Character.__c __9
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(Character.__c.NativeFieldInfoPtr___9, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Character.__c) null : new Character.__c(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Character.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Predicate<CardData> __9__12_0
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(Character.__c.NativeFieldInfoPtr___9__12_0, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Predicate<CardData>) null : new Il2CppSystem.Predicate<CardData>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Character.__c.NativeFieldInfoPtr___9__12_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
