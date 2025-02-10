// Decompiled with JetBrains decompiler
// Type: CharacterDisplay
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections;
using System.Runtime.InteropServices;

#nullable disable
public class CharacterDisplay : EntityDisplay
{
  private static readonly System.IntPtr NativeFieldInfoPtr_team;
  private static readonly System.IntPtr NativeFieldInfoPtr_goldDisplay;
  private static readonly System.IntPtr NativeFieldInfoPtr_deckDisplay;
  private static readonly System.IntPtr NativeFieldInfoPtr_handOverlay;
  private static readonly System.IntPtr NativeFieldInfoPtr_currentEffectBonus;
  private static readonly System.IntPtr NativeFieldInfoPtr_currentEffectFactor;
  private static readonly System.IntPtr NativeFieldInfoPtr__character;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_IsDeckpackOpen_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_character_Private_get_Character_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FindAndAssign_Public_Static_Void_Character_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Assign_Public_Void_Character_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UnAssign_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UpdateDisplay_Public_Virtual_IEnumerator_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ToggleInventory_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OpenInventory_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CloseInventory_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ForceUpdateDisplay_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  public unsafe bool IsDeckpackOpen
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 43621, RefRangeEnd = 43622, XrefRangeStart = 43620, XrefRangeEnd = 43621, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CharacterDisplay.NativeMethodInfoPtr_get_IsDeckpackOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  public unsafe Character character
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 43630, RefRangeEnd = 43632, XrefRangeStart = 43622, XrefRangeEnd = 43630, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CharacterDisplay.NativeMethodInfoPtr_get_character_Private_get_Character_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Character) null : new Character(pointer);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 43656, RefRangeEnd = 43657, XrefRangeStart = 43632, XrefRangeEnd = 43656, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void FindAndAssign(Character character)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) character)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CharacterDisplay.NativeMethodInfoPtr_FindAndAssign_Public_Static_Void_Character_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 43669, RefRangeEnd = 43671, XrefRangeStart = 43657, XrefRangeEnd = 43669, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Assign(Character character)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) character)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CharacterDisplay.NativeMethodInfoPtr_Assign_Public_Void_Character_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43671, XrefRangeEnd = 43672, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UnAssign()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CharacterDisplay.NativeMethodInfoPtr_UnAssign_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43672, XrefRangeEnd = 43677, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe IEnumerator UpdateDisplay(bool doPingIcons = true)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &doPingIcons
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CharacterDisplay.NativeMethodInfoPtr_UpdateDisplay_Public_Virtual_IEnumerator_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 43682, RefRangeEnd = 43684, XrefRangeStart = 43677, XrefRangeEnd = 43682, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ToggleInventory()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CharacterDisplay.NativeMethodInfoPtr_ToggleInventory_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 43686, RefRangeEnd = 43688, XrefRangeStart = 43684, XrefRangeEnd = 43686, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OpenInventory()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CharacterDisplay.NativeMethodInfoPtr_OpenInventory_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 43690, RefRangeEnd = 43692, XrefRangeStart = 43688, XrefRangeEnd = 43690, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CloseInventory()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CharacterDisplay.NativeMethodInfoPtr_CloseInventory_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43692, XrefRangeEnd = 43693, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ForceUpdateDisplay()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CharacterDisplay.NativeMethodInfoPtr_ForceUpdateDisplay_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43693, XrefRangeEnd = 43694, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CharacterDisplay()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterDisplay>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CharacterDisplay.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static CharacterDisplay()
  {
    Il2CppClassPointerStore<CharacterDisplay>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (CharacterDisplay));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterDisplay>.NativeClassPtr);
    CharacterDisplay.NativeFieldInfoPtr_team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterDisplay>.NativeClassPtr, nameof (team));
    CharacterDisplay.NativeFieldInfoPtr_goldDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterDisplay>.NativeClassPtr, nameof (goldDisplay));
    CharacterDisplay.NativeFieldInfoPtr_deckDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterDisplay>.NativeClassPtr, nameof (deckDisplay));
    CharacterDisplay.NativeFieldInfoPtr_handOverlay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterDisplay>.NativeClassPtr, nameof (handOverlay));
    CharacterDisplay.NativeFieldInfoPtr_currentEffectBonus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterDisplay>.NativeClassPtr, nameof (currentEffectBonus));
    CharacterDisplay.NativeFieldInfoPtr_currentEffectFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterDisplay>.NativeClassPtr, nameof (currentEffectFactor));
    CharacterDisplay.NativeFieldInfoPtr__character = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterDisplay>.NativeClassPtr, nameof (_character));
    CharacterDisplay.NativeMethodInfoPtr_get_IsDeckpackOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterDisplay>.NativeClassPtr, 100666542);
    CharacterDisplay.NativeMethodInfoPtr_get_character_Private_get_Character_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterDisplay>.NativeClassPtr, 100666543);
    CharacterDisplay.NativeMethodInfoPtr_FindAndAssign_Public_Static_Void_Character_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterDisplay>.NativeClassPtr, 100666544);
    CharacterDisplay.NativeMethodInfoPtr_Assign_Public_Void_Character_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterDisplay>.NativeClassPtr, 100666545);
    CharacterDisplay.NativeMethodInfoPtr_UnAssign_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterDisplay>.NativeClassPtr, 100666546);
    CharacterDisplay.NativeMethodInfoPtr_UpdateDisplay_Public_Virtual_IEnumerator_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterDisplay>.NativeClassPtr, 100666547);
    CharacterDisplay.NativeMethodInfoPtr_ToggleInventory_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterDisplay>.NativeClassPtr, 100666548);
    CharacterDisplay.NativeMethodInfoPtr_OpenInventory_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterDisplay>.NativeClassPtr, 100666549);
    CharacterDisplay.NativeMethodInfoPtr_CloseInventory_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterDisplay>.NativeClassPtr, 100666550);
    CharacterDisplay.NativeMethodInfoPtr_ForceUpdateDisplay_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterDisplay>.NativeClassPtr, 100666551);
    CharacterDisplay.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterDisplay>.NativeClassPtr, 100666552);
  }

  public CharacterDisplay(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe int team
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterDisplay.NativeFieldInfoPtr_team));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterDisplay.NativeFieldInfoPtr_team)) = value;
    }
  }

  public unsafe GoldDisplay goldDisplay
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterDisplay.NativeFieldInfoPtr_goldDisplay));
      return pointer == System.IntPtr.Zero ? (GoldDisplay) null : new GoldDisplay(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterDisplay.NativeFieldInfoPtr_goldDisplay), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe DeckDisplay deckDisplay
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterDisplay.NativeFieldInfoPtr_deckDisplay));
      return pointer == System.IntPtr.Zero ? (DeckDisplay) null : new DeckDisplay(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterDisplay.NativeFieldInfoPtr_deckDisplay), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe HandOverlay handOverlay
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterDisplay.NativeFieldInfoPtr_handOverlay));
      return pointer == System.IntPtr.Zero ? (HandOverlay) null : new HandOverlay(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterDisplay.NativeFieldInfoPtr_handOverlay), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int currentEffectBonus
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterDisplay.NativeFieldInfoPtr_currentEffectBonus));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterDisplay.NativeFieldInfoPtr_currentEffectBonus)) = value;
    }
  }

  public unsafe float currentEffectFactor
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterDisplay.NativeFieldInfoPtr_currentEffectFactor));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterDisplay.NativeFieldInfoPtr_currentEffectFactor)) = value;
    }
  }

  public unsafe Character _character
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterDisplay.NativeFieldInfoPtr__character));
      return pointer == System.IntPtr.Zero ? (Character) null : new Character(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterDisplay.NativeFieldInfoPtr__character), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [ObfuscatedName("CharacterDisplay/<UpdateDisplay>d__14")]
  public sealed class _UpdateDisplay_d__14 : Il2CppSystem.Object
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
    public unsafe _UpdateDisplay_d__14(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterDisplay._UpdateDisplay_d__14>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CharacterDisplay._UpdateDisplay_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(12611)]
    [CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12665, XrefRangeStart = 54, XrefRangeEnd = 12665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CharacterDisplay._UpdateDisplay_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43597, XrefRangeEnd = 43614, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CharacterDisplay._UpdateDisplay_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CharacterDisplay._UpdateDisplay_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43614, XrefRangeEnd = 43620, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CharacterDisplay._UpdateDisplay_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CharacterDisplay._UpdateDisplay_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    static _UpdateDisplay_d__14()
    {
      Il2CppClassPointerStore<CharacterDisplay._UpdateDisplay_d__14>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterDisplay>.NativeClassPtr, "<UpdateDisplay>d__14");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterDisplay._UpdateDisplay_d__14>.NativeClassPtr);
      CharacterDisplay._UpdateDisplay_d__14.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterDisplay._UpdateDisplay_d__14>.NativeClassPtr, "<>1__state");
      CharacterDisplay._UpdateDisplay_d__14.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterDisplay._UpdateDisplay_d__14>.NativeClassPtr, "<>2__current");
      CharacterDisplay._UpdateDisplay_d__14.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterDisplay._UpdateDisplay_d__14>.NativeClassPtr, "<>4__this");
      CharacterDisplay._UpdateDisplay_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterDisplay._UpdateDisplay_d__14>.NativeClassPtr, 100666553);
      CharacterDisplay._UpdateDisplay_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterDisplay._UpdateDisplay_d__14>.NativeClassPtr, 100666554);
      CharacterDisplay._UpdateDisplay_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterDisplay._UpdateDisplay_d__14>.NativeClassPtr, 100666555);
      CharacterDisplay._UpdateDisplay_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterDisplay._UpdateDisplay_d__14>.NativeClassPtr, 100666556);
      CharacterDisplay._UpdateDisplay_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterDisplay._UpdateDisplay_d__14>.NativeClassPtr, 100666557);
      CharacterDisplay._UpdateDisplay_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterDisplay._UpdateDisplay_d__14>.NativeClassPtr, 100666558);
    }

    public _UpdateDisplay_d__14(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterDisplay._UpdateDisplay_d__14.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterDisplay._UpdateDisplay_d__14.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterDisplay._UpdateDisplay_d__14.NativeFieldInfoPtr___2__current));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterDisplay._UpdateDisplay_d__14.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CharacterDisplay __4__this
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterDisplay._UpdateDisplay_d__14.NativeFieldInfoPtr___4__this));
        return pointer == System.IntPtr.Zero ? (CharacterDisplay) null : new CharacterDisplay(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterDisplay._UpdateDisplay_d__14.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
