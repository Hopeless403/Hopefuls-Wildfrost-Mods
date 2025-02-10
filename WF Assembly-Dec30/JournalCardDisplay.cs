// Decompiled with JetBrains decompiler
// Type: JournalCardDisplay
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections;
using System;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;

#nullable disable
public class JournalCardDisplay : MonoBehaviour
{
  private static readonly System.IntPtr NativeFieldInfoPtr_inspector;
  private static readonly System.IntPtr NativeFieldInfoPtr_normalPositionProfile;
  private static readonly System.IntPtr NativeFieldInfoPtr_bigPositionProfile;
  private static readonly System.IntPtr NativeFieldInfoPtr_nameText;
  private static readonly System.IntPtr NativeFieldInfoPtr_typeIcon;
  private static readonly System.IntPtr NativeFieldInfoPtr_typeText;
  private static readonly System.IntPtr NativeFieldInfoPtr__canvasGroup;
  private static readonly System.IntPtr NativeFieldInfoPtr_current;
  private static readonly System.IntPtr NativeFieldInfoPtr_from;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_canvasGroup_Private_get_CanvasGroup_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Display_Public_Void_CardData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UpdateCard_Private_IEnumerator_Card_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  public unsafe CanvasGroup canvasGroup
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 90695, RefRangeEnd = 90697, XrefRangeStart = 90690, XrefRangeEnd = 90695, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(JournalCardDisplay.NativeMethodInfoPtr_get_canvasGroup_Private_get_CanvasGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (CanvasGroup) null : new CanvasGroup(pointer);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90697, XrefRangeEnd = 90711, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(JournalCardDisplay.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 90738, RefRangeEnd = 90740, XrefRangeStart = 90711, XrefRangeEnd = 90738, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Display(CardData cardData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cardData)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(JournalCardDisplay.NativeMethodInfoPtr_Display_Public_Void_CardData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90740, XrefRangeEnd = 90746, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator UpdateCard(Card card)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) card)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(JournalCardDisplay.NativeMethodInfoPtr_UpdateCard_Private_IEnumerator_Card_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90746, XrefRangeEnd = 90747, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe JournalCardDisplay()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JournalCardDisplay>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(JournalCardDisplay.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static JournalCardDisplay()
  {
    Il2CppClassPointerStore<JournalCardDisplay>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (JournalCardDisplay));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JournalCardDisplay>.NativeClassPtr);
    JournalCardDisplay.NativeFieldInfoPtr_inspector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalCardDisplay>.NativeClassPtr, nameof (inspector));
    JournalCardDisplay.NativeFieldInfoPtr_normalPositionProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalCardDisplay>.NativeClassPtr, nameof (normalPositionProfile));
    JournalCardDisplay.NativeFieldInfoPtr_bigPositionProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalCardDisplay>.NativeClassPtr, nameof (bigPositionProfile));
    JournalCardDisplay.NativeFieldInfoPtr_nameText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalCardDisplay>.NativeClassPtr, nameof (nameText));
    JournalCardDisplay.NativeFieldInfoPtr_typeIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalCardDisplay>.NativeClassPtr, nameof (typeIcon));
    JournalCardDisplay.NativeFieldInfoPtr_typeText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalCardDisplay>.NativeClassPtr, nameof (typeText));
    JournalCardDisplay.NativeFieldInfoPtr__canvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalCardDisplay>.NativeClassPtr, nameof (_canvasGroup));
    JournalCardDisplay.NativeFieldInfoPtr_current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalCardDisplay>.NativeClassPtr, nameof (current));
    JournalCardDisplay.NativeFieldInfoPtr_from = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalCardDisplay>.NativeClassPtr, nameof (from));
    JournalCardDisplay.NativeMethodInfoPtr_get_canvasGroup_Private_get_CanvasGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalCardDisplay>.NativeClassPtr, 100671086);
    JournalCardDisplay.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalCardDisplay>.NativeClassPtr, 100671087);
    JournalCardDisplay.NativeMethodInfoPtr_Display_Public_Void_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalCardDisplay>.NativeClassPtr, 100671088);
    JournalCardDisplay.NativeMethodInfoPtr_UpdateCard_Private_IEnumerator_Card_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalCardDisplay>.NativeClassPtr, 100671089);
    JournalCardDisplay.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalCardDisplay>.NativeClassPtr, 100671090);
  }

  public JournalCardDisplay(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe CardInspector inspector
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalCardDisplay.NativeFieldInfoPtr_inspector));
      return pointer == System.IntPtr.Zero ? (CardInspector) null : new CardInspector(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JournalCardDisplay.NativeFieldInfoPtr_inspector), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public JournalCardDisplay.PositionProfile normalPositionProfile
  {
    get
    {
      System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalCardDisplay.NativeFieldInfoPtr_normalPositionProfile);
      return new JournalCardDisplay.PositionProfile(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<JournalCardDisplay.PositionProfile>.NativeClassPtr, data));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalCardDisplay.NativeFieldInfoPtr_normalPositionProfile), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<JournalCardDisplay.PositionProfile>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public JournalCardDisplay.PositionProfile bigPositionProfile
  {
    get
    {
      System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalCardDisplay.NativeFieldInfoPtr_bigPositionProfile);
      return new JournalCardDisplay.PositionProfile(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<JournalCardDisplay.PositionProfile>.NativeClassPtr, data));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalCardDisplay.NativeFieldInfoPtr_bigPositionProfile), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<JournalCardDisplay.PositionProfile>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public unsafe TMP_Text nameText
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalCardDisplay.NativeFieldInfoPtr_nameText));
      return pointer == System.IntPtr.Zero ? (TMP_Text) null : new TMP_Text(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JournalCardDisplay.NativeFieldInfoPtr_nameText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ImageSprite typeIcon
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalCardDisplay.NativeFieldInfoPtr_typeIcon));
      return pointer == System.IntPtr.Zero ? (ImageSprite) null : new ImageSprite(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JournalCardDisplay.NativeFieldInfoPtr_typeIcon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TMP_Text typeText
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalCardDisplay.NativeFieldInfoPtr_typeText));
      return pointer == System.IntPtr.Zero ? (TMP_Text) null : new TMP_Text(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JournalCardDisplay.NativeFieldInfoPtr_typeText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CanvasGroup _canvasGroup
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalCardDisplay.NativeFieldInfoPtr__canvasGroup));
      return pointer == System.IntPtr.Zero ? (CanvasGroup) null : new CanvasGroup(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JournalCardDisplay.NativeFieldInfoPtr__canvasGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Card current
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalCardDisplay.NativeFieldInfoPtr_current));
      return pointer == System.IntPtr.Zero ? (Card) null : new Card(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JournalCardDisplay.NativeFieldInfoPtr_current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector3 from
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalCardDisplay.NativeFieldInfoPtr_from));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalCardDisplay.NativeFieldInfoPtr_from)) = value;
    }
  }

  [Serializable]
  public sealed class PositionProfile : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_transforms;
    private static readonly System.IntPtr NativeFieldInfoPtr_anchoredPositions;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 90646, RefRangeEnd = 90647, XrefRangeStart = 90644, XrefRangeEnd = 90646, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Set()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(JournalCardDisplay.PositionProfile.NativeMethodInfoPtr_Set_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static PositionProfile()
    {
      Il2CppClassPointerStore<JournalCardDisplay.PositionProfile>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JournalCardDisplay>.NativeClassPtr, nameof (PositionProfile));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JournalCardDisplay.PositionProfile>.NativeClassPtr);
      JournalCardDisplay.PositionProfile.NativeFieldInfoPtr_transforms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalCardDisplay.PositionProfile>.NativeClassPtr, nameof (transforms));
      JournalCardDisplay.PositionProfile.NativeFieldInfoPtr_anchoredPositions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalCardDisplay.PositionProfile>.NativeClassPtr, nameof (anchoredPositions));
      JournalCardDisplay.PositionProfile.NativeMethodInfoPtr_Set_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalCardDisplay.PositionProfile>.NativeClassPtr, 100671091);
    }

    public PositionProfile(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public PositionProfile()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<JournalCardDisplay.PositionProfile>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<JournalCardDisplay.PositionProfile>.NativeClassPtr, data));
    }

    public unsafe Il2CppReferenceArray<RectTransform> transforms
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalCardDisplay.PositionProfile.NativeFieldInfoPtr_transforms));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<RectTransform>) null : new Il2CppReferenceArray<RectTransform>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JournalCardDisplay.PositionProfile.NativeFieldInfoPtr_transforms), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppStructArray<Vector3> anchoredPositions
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalCardDisplay.PositionProfile.NativeFieldInfoPtr_anchoredPositions));
        return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<Vector3>) null : new Il2CppStructArray<Vector3>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JournalCardDisplay.PositionProfile.NativeFieldInfoPtr_anchoredPositions), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("JournalCardDisplay/<UpdateCard>d__13")]
  public sealed class _UpdateCard_d__13 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr_card;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    [CallerCount(53)]
    [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _UpdateCard_d__13(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JournalCardDisplay._UpdateCard_d__13>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(JournalCardDisplay._UpdateCard_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(12611)]
    [CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12665, XrefRangeStart = 54, XrefRangeEnd = 12665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(JournalCardDisplay._UpdateCard_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90647, XrefRangeEnd = 90684, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(JournalCardDisplay._UpdateCard_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(JournalCardDisplay._UpdateCard_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90684, XrefRangeEnd = 90690, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(JournalCardDisplay._UpdateCard_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(JournalCardDisplay._UpdateCard_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    static _UpdateCard_d__13()
    {
      Il2CppClassPointerStore<JournalCardDisplay._UpdateCard_d__13>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JournalCardDisplay>.NativeClassPtr, "<UpdateCard>d__13");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JournalCardDisplay._UpdateCard_d__13>.NativeClassPtr);
      JournalCardDisplay._UpdateCard_d__13.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalCardDisplay._UpdateCard_d__13>.NativeClassPtr, "<>1__state");
      JournalCardDisplay._UpdateCard_d__13.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalCardDisplay._UpdateCard_d__13>.NativeClassPtr, "<>2__current");
      JournalCardDisplay._UpdateCard_d__13.NativeFieldInfoPtr_card = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalCardDisplay._UpdateCard_d__13>.NativeClassPtr, nameof (card));
      JournalCardDisplay._UpdateCard_d__13.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalCardDisplay._UpdateCard_d__13>.NativeClassPtr, "<>4__this");
      JournalCardDisplay._UpdateCard_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalCardDisplay._UpdateCard_d__13>.NativeClassPtr, 100671092);
      JournalCardDisplay._UpdateCard_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalCardDisplay._UpdateCard_d__13>.NativeClassPtr, 100671093);
      JournalCardDisplay._UpdateCard_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalCardDisplay._UpdateCard_d__13>.NativeClassPtr, 100671094);
      JournalCardDisplay._UpdateCard_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalCardDisplay._UpdateCard_d__13>.NativeClassPtr, 100671095);
      JournalCardDisplay._UpdateCard_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalCardDisplay._UpdateCard_d__13>.NativeClassPtr, 100671096);
      JournalCardDisplay._UpdateCard_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalCardDisplay._UpdateCard_d__13>.NativeClassPtr, 100671097);
    }

    public _UpdateCard_d__13(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalCardDisplay._UpdateCard_d__13.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalCardDisplay._UpdateCard_d__13.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalCardDisplay._UpdateCard_d__13.NativeFieldInfoPtr___2__current));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JournalCardDisplay._UpdateCard_d__13.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Card card
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalCardDisplay._UpdateCard_d__13.NativeFieldInfoPtr_card));
        return pointer == System.IntPtr.Zero ? (Card) null : new Card(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JournalCardDisplay._UpdateCard_d__13.NativeFieldInfoPtr_card), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe JournalCardDisplay __4__this
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalCardDisplay._UpdateCard_d__13.NativeFieldInfoPtr___4__this));
        return pointer == System.IntPtr.Zero ? (JournalCardDisplay) null : new JournalCardDisplay(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JournalCardDisplay._UpdateCard_d__13.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
