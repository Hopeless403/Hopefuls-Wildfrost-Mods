// Decompiled with JetBrains decompiler
// Type: EventRoutine
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;

#nullable disable
public class EventRoutine : SceneRoutine
{
  private static readonly System.IntPtr NativeFieldInfoPtr__player;
  private static readonly System.IntPtr NativeFieldInfoPtr_node;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_player_Protected_get_Character_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_data_Protected_get_Dictionary_2_String_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Populate_Public_Virtual_New_IEnumerator_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CheckAddUpgrades_Protected_Void_Int32_CardData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  public unsafe Character player
  {
    [CallerCount(16), CachedScanResults(RefRangeStart = 46106, RefRangeEnd = 46122, XrefRangeStart = 46103, XrefRangeEnd = 46106, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EventRoutine.NativeMethodInfoPtr_get_player_Protected_get_Character_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Character) null : new Character(pointer);
    }
  }

  public unsafe Dictionary<string, Il2CppSystem.Object> data
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 46122, RefRangeEnd = 46124, XrefRangeStart = 46122, XrefRangeEnd = 46122, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EventRoutine.NativeMethodInfoPtr_get_data_Protected_get_Dictionary_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Dictionary<string, Il2CppSystem.Object>) null : new Dictionary<string, Il2CppSystem.Object>(pointer);
    }
  }

  [CallerCount(44)]
  [CachedScanResults(RefRangeStart = 26224, RefRangeEnd = 26268, XrefRangeStart = 26224, XrefRangeEnd = 26268, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe IEnumerator Populate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), EventRoutine.NativeMethodInfoPtr_Populate_Public_Virtual_New_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 46151, RefRangeEnd = 46154, XrefRangeStart = 46124, XrefRangeEnd = 46151, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CheckAddUpgrades(int cardIndex, CardData cardDataClone)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &cardIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cardDataClone);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(EventRoutine.NativeMethodInfoPtr_CheckAddUpgrades_Protected_Void_Int32_CardData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 21168, RefRangeEnd = 21171, XrefRangeStart = 21168, XrefRangeEnd = 21171, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe EventRoutine()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventRoutine>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(EventRoutine.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static EventRoutine()
  {
    Il2CppClassPointerStore<EventRoutine>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (EventRoutine));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventRoutine>.NativeClassPtr);
    EventRoutine.NativeFieldInfoPtr__player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventRoutine>.NativeClassPtr, nameof (_player));
    EventRoutine.NativeFieldInfoPtr_node = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventRoutine>.NativeClassPtr, nameof (node));
    EventRoutine.NativeMethodInfoPtr_get_player_Protected_get_Character_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventRoutine>.NativeClassPtr, 100666755);
    EventRoutine.NativeMethodInfoPtr_get_data_Protected_get_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventRoutine>.NativeClassPtr, 100666756);
    EventRoutine.NativeMethodInfoPtr_Populate_Public_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventRoutine>.NativeClassPtr, 100666757);
    EventRoutine.NativeMethodInfoPtr_CheckAddUpgrades_Protected_Void_Int32_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventRoutine>.NativeClassPtr, 100666758);
    EventRoutine.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventRoutine>.NativeClassPtr, 100666759);
  }

  public EventRoutine(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Character _player
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EventRoutine.NativeFieldInfoPtr__player));
      return pointer == System.IntPtr.Zero ? (Character) null : new Character(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EventRoutine.NativeFieldInfoPtr__player), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CampaignNode node
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EventRoutine.NativeFieldInfoPtr_node));
      return pointer == System.IntPtr.Zero ? (CampaignNode) null : new CampaignNode(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EventRoutine.NativeFieldInfoPtr_node), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
