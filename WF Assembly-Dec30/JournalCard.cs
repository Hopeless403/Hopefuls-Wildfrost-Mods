// Decompiled with JetBrains decompiler
// Type: JournalCard
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
public class JournalCard : MonoBehaviour
{
  private static readonly System.IntPtr NativeFieldInfoPtr_nameText;
  private static readonly System.IntPtr NativeFieldInfoPtr_background;
  private static readonly System.IntPtr NativeFieldInfoPtr_image;
  private static readonly System.IntPtr NativeFieldInfoPtr_button;
  private static readonly System.IntPtr NativeFieldInfoPtr_discoveredMaterial;
  private static readonly System.IntPtr NativeFieldInfoPtr_frame;
  private static readonly System.IntPtr NativeFieldInfoPtr_frames;
  private static readonly System.IntPtr NativeFieldInfoPtr_cardData;
  private static readonly System.IntPtr NativeFieldInfoPtr_discovered;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetCardArt_Public_Void_CardData_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CheckDiscovered_Public_Void_List_1_String_JournalCardManager_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetDiscovered_Public_Void_String_JournalCardManager_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90604, XrefRangeEnd = 90620, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetCardArt(CardData cardData, float scale)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cardData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &scale;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(JournalCard.NativeMethodInfoPtr_SetCardArt_Public_Void_CardData_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90620, XrefRangeEnd = 90626, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CheckDiscovered(List<string> discoveredCards, JournalCardManager manager)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) discoveredCards);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) manager);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(JournalCard.NativeMethodInfoPtr_CheckDiscovered_Public_Void_List_1_String_JournalCardManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 90641, RefRangeEnd = 90644, XrefRangeStart = 90626, XrefRangeEnd = 90641, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetDiscovered(string title, JournalCardManager manager)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(title);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) manager);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(JournalCard.NativeMethodInfoPtr_SetDiscovered_Public_Void_String_JournalCardManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(212)]
  [CachedScanResults(RefRangeStart = 12749, RefRangeEnd = 12961, XrefRangeStart = 12749, XrefRangeEnd = 12961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe JournalCard()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JournalCard>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(JournalCard.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static JournalCard()
  {
    Il2CppClassPointerStore<JournalCard>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (JournalCard));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JournalCard>.NativeClassPtr);
    JournalCard.NativeFieldInfoPtr_nameText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalCard>.NativeClassPtr, nameof (nameText));
    JournalCard.NativeFieldInfoPtr_background = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalCard>.NativeClassPtr, nameof (background));
    JournalCard.NativeFieldInfoPtr_image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalCard>.NativeClassPtr, nameof (image));
    JournalCard.NativeFieldInfoPtr_button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalCard>.NativeClassPtr, nameof (button));
    JournalCard.NativeFieldInfoPtr_discoveredMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalCard>.NativeClassPtr, nameof (discoveredMaterial));
    JournalCard.NativeFieldInfoPtr_frame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalCard>.NativeClassPtr, nameof (frame));
    JournalCard.NativeFieldInfoPtr_frames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalCard>.NativeClassPtr, nameof (frames));
    JournalCard.NativeFieldInfoPtr_cardData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalCard>.NativeClassPtr, nameof (cardData));
    JournalCard.NativeFieldInfoPtr_discovered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalCard>.NativeClassPtr, nameof (discovered));
    JournalCard.NativeMethodInfoPtr_SetCardArt_Public_Void_CardData_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalCard>.NativeClassPtr, 100671080);
    JournalCard.NativeMethodInfoPtr_CheckDiscovered_Public_Void_List_1_String_JournalCardManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalCard>.NativeClassPtr, 100671081);
    JournalCard.NativeMethodInfoPtr_SetDiscovered_Public_Void_String_JournalCardManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalCard>.NativeClassPtr, 100671082);
    JournalCard.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalCard>.NativeClassPtr, 100671083);
  }

  public JournalCard(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe TMP_Text nameText
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalCard.NativeFieldInfoPtr_nameText));
      return pointer == System.IntPtr.Zero ? (TMP_Text) null : new TMP_Text(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JournalCard.NativeFieldInfoPtr_nameText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Image background
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalCard.NativeFieldInfoPtr_background));
      return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JournalCard.NativeFieldInfoPtr_background), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Image image
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalCard.NativeFieldInfoPtr_image));
      return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JournalCard.NativeFieldInfoPtr_image), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Button button
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalCard.NativeFieldInfoPtr_button));
      return pointer == System.IntPtr.Zero ? (Button) null : new Button(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JournalCard.NativeFieldInfoPtr_button), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Material discoveredMaterial
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalCard.NativeFieldInfoPtr_discoveredMaterial));
      return pointer == System.IntPtr.Zero ? (Material) null : new Material(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JournalCard.NativeFieldInfoPtr_discoveredMaterial), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Image frame
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalCard.NativeFieldInfoPtr_frame));
      return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JournalCard.NativeFieldInfoPtr_frame), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<Sprite> frames
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalCard.NativeFieldInfoPtr_frames));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<Sprite>) null : new Il2CppReferenceArray<Sprite>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JournalCard.NativeFieldInfoPtr_frames), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CardData cardData
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalCard.NativeFieldInfoPtr_cardData));
      return pointer == System.IntPtr.Zero ? (CardData) null : new CardData(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JournalCard.NativeFieldInfoPtr_cardData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool discovered
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalCard.NativeFieldInfoPtr_discovered));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalCard.NativeFieldInfoPtr_discovered)) = value;
    }
  }

  [ObfuscatedName("JournalCard/<>c__DisplayClass11_0")]
  public sealed class __c__DisplayClass11_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_manager;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__SetDiscovered_b__0_Internal_Void_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass11_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JournalCard.__c__DisplayClass11_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(JournalCard.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90599, XrefRangeEnd = 90604, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _SetDiscovered_b__0()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(JournalCard.__c__DisplayClass11_0.NativeMethodInfoPtr__SetDiscovered_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static __c__DisplayClass11_0()
    {
      Il2CppClassPointerStore<JournalCard.__c__DisplayClass11_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JournalCard>.NativeClassPtr, "<>c__DisplayClass11_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JournalCard.__c__DisplayClass11_0>.NativeClassPtr);
      JournalCard.__c__DisplayClass11_0.NativeFieldInfoPtr_manager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalCard.__c__DisplayClass11_0>.NativeClassPtr, nameof (manager));
      JournalCard.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalCard.__c__DisplayClass11_0>.NativeClassPtr, "<>4__this");
      JournalCard.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalCard.__c__DisplayClass11_0>.NativeClassPtr, 100671084);
      JournalCard.__c__DisplayClass11_0.NativeMethodInfoPtr__SetDiscovered_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalCard.__c__DisplayClass11_0>.NativeClassPtr, 100671085);
    }

    public __c__DisplayClass11_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe JournalCardManager manager
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalCard.__c__DisplayClass11_0.NativeFieldInfoPtr_manager));
        return pointer == System.IntPtr.Zero ? (JournalCardManager) null : new JournalCardManager(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JournalCard.__c__DisplayClass11_0.NativeFieldInfoPtr_manager), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe JournalCard __4__this
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalCard.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this));
        return pointer == System.IntPtr.Zero ? (JournalCard) null : new JournalCard(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JournalCard.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
