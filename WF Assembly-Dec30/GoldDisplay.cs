// Decompiled with JetBrains decompiler
// Type: GoldDisplay
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
public class GoldDisplay : MonoBehaviour
{
  private static readonly System.IntPtr NativeFieldInfoPtr_icon;
  private static readonly System.IntPtr NativeFieldInfoPtr_doPing;
  private static readonly System.IntPtr NativeFieldInfoPtr_pingEase;
  private static readonly System.IntPtr NativeFieldInfoPtr_pingCurve;
  private static readonly System.IntPtr NativeFieldInfoPtr_pingDur;
  private static readonly System.IntPtr NativeFieldInfoPtr_textAsset;
  private static readonly System.IntPtr NativeFieldInfoPtr_format;
  private static readonly System.IntPtr NativeFieldInfoPtr_formatAdd;
  private static readonly System.IntPtr NativeFieldInfoPtr_formatSub;
  private static readonly System.IntPtr NativeFieldInfoPtr_formatChangeUp;
  private static readonly System.IntPtr NativeFieldInfoPtr_formatChangeDown;
  private static readonly System.IntPtr NativeFieldInfoPtr_addDelay;
  private static readonly System.IntPtr NativeFieldInfoPtr_totalAddTime;
  private static readonly System.IntPtr NativeFieldInfoPtr_addBetweenTimeMax;
  private static readonly System.IntPtr NativeFieldInfoPtr_goldPre;
  private static readonly System.IntPtr NativeFieldInfoPtr_current;
  private static readonly System.IntPtr NativeFieldInfoPtr__add_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr_change;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_PingIsAnimationCurve_Private_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_add_Public_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_add_Private_set_Void_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ShowChange_Public_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_HideChange_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Ping_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UpdateText_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ResolveAfter_Public_Void_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ResolveAdd_Private_IEnumerator_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  public unsafe bool PingIsAnimationCurve
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GoldDisplay.NativeMethodInfoPtr_get_PingIsAnimationCurve_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  public unsafe float add
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GoldDisplay.NativeMethodInfoPtr_get_add_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GoldDisplay.NativeMethodInfoPtr_set_add_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 50677, RefRangeEnd = 50678, XrefRangeStart = 50656, XrefRangeEnd = 50677, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(int amount)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &amount
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(GoldDisplay.NativeMethodInfoPtr_Set_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 50679, RefRangeEnd = 50682, XrefRangeStart = 50678, XrefRangeEnd = 50679, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ShowChange(int change)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &change
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(GoldDisplay.NativeMethodInfoPtr_ShowChange_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 50683, RefRangeEnd = 50687, XrefRangeStart = 50682, XrefRangeEnd = 50683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void HideChange()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(GoldDisplay.NativeMethodInfoPtr_HideChange_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50687, XrefRangeEnd = 50702, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Ping()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(GoldDisplay.NativeMethodInfoPtr_Ping_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 50734, RefRangeEnd = 50737, XrefRangeStart = 50702, XrefRangeEnd = 50734, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UpdateText()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(GoldDisplay.NativeMethodInfoPtr_UpdateText_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50737, XrefRangeEnd = 50745, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ResolveAfter(float delay)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &delay
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(GoldDisplay.NativeMethodInfoPtr_ResolveAfter_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50745, XrefRangeEnd = 50750, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator ResolveAdd(float delay)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &delay
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GoldDisplay.NativeMethodInfoPtr_ResolveAdd_Private_IEnumerator_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50750, XrefRangeEnd = 50771, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe GoldDisplay()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GoldDisplay>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(GoldDisplay.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static GoldDisplay()
  {
    Il2CppClassPointerStore<GoldDisplay>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (GoldDisplay));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GoldDisplay>.NativeClassPtr);
    GoldDisplay.NativeFieldInfoPtr_icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoldDisplay>.NativeClassPtr, nameof (icon));
    GoldDisplay.NativeFieldInfoPtr_doPing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoldDisplay>.NativeClassPtr, nameof (doPing));
    GoldDisplay.NativeFieldInfoPtr_pingEase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoldDisplay>.NativeClassPtr, nameof (pingEase));
    GoldDisplay.NativeFieldInfoPtr_pingCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoldDisplay>.NativeClassPtr, nameof (pingCurve));
    GoldDisplay.NativeFieldInfoPtr_pingDur = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoldDisplay>.NativeClassPtr, nameof (pingDur));
    GoldDisplay.NativeFieldInfoPtr_textAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoldDisplay>.NativeClassPtr, nameof (textAsset));
    GoldDisplay.NativeFieldInfoPtr_format = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoldDisplay>.NativeClassPtr, nameof (format));
    GoldDisplay.NativeFieldInfoPtr_formatAdd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoldDisplay>.NativeClassPtr, nameof (formatAdd));
    GoldDisplay.NativeFieldInfoPtr_formatSub = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoldDisplay>.NativeClassPtr, nameof (formatSub));
    GoldDisplay.NativeFieldInfoPtr_formatChangeUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoldDisplay>.NativeClassPtr, nameof (formatChangeUp));
    GoldDisplay.NativeFieldInfoPtr_formatChangeDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoldDisplay>.NativeClassPtr, nameof (formatChangeDown));
    GoldDisplay.NativeFieldInfoPtr_addDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoldDisplay>.NativeClassPtr, nameof (addDelay));
    GoldDisplay.NativeFieldInfoPtr_totalAddTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoldDisplay>.NativeClassPtr, nameof (totalAddTime));
    GoldDisplay.NativeFieldInfoPtr_addBetweenTimeMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoldDisplay>.NativeClassPtr, nameof (addBetweenTimeMax));
    GoldDisplay.NativeFieldInfoPtr_goldPre = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoldDisplay>.NativeClassPtr, nameof (goldPre));
    GoldDisplay.NativeFieldInfoPtr_current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoldDisplay>.NativeClassPtr, nameof (current));
    GoldDisplay.NativeFieldInfoPtr__add_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoldDisplay>.NativeClassPtr, "<add>k__BackingField");
    GoldDisplay.NativeFieldInfoPtr_change = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoldDisplay>.NativeClassPtr, nameof (change));
    GoldDisplay.NativeMethodInfoPtr_get_PingIsAnimationCurve_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoldDisplay>.NativeClassPtr, 100667333);
    GoldDisplay.NativeMethodInfoPtr_get_add_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoldDisplay>.NativeClassPtr, 100667334);
    GoldDisplay.NativeMethodInfoPtr_set_add_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoldDisplay>.NativeClassPtr, 100667335);
    GoldDisplay.NativeMethodInfoPtr_Set_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoldDisplay>.NativeClassPtr, 100667336);
    GoldDisplay.NativeMethodInfoPtr_ShowChange_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoldDisplay>.NativeClassPtr, 100667337);
    GoldDisplay.NativeMethodInfoPtr_HideChange_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoldDisplay>.NativeClassPtr, 100667338);
    GoldDisplay.NativeMethodInfoPtr_Ping_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoldDisplay>.NativeClassPtr, 100667339);
    GoldDisplay.NativeMethodInfoPtr_UpdateText_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoldDisplay>.NativeClassPtr, 100667340);
    GoldDisplay.NativeMethodInfoPtr_ResolveAfter_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoldDisplay>.NativeClassPtr, 100667341);
    GoldDisplay.NativeMethodInfoPtr_ResolveAdd_Private_IEnumerator_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoldDisplay>.NativeClassPtr, 100667342);
    GoldDisplay.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoldDisplay>.NativeClassPtr, 100667343);
  }

  public GoldDisplay(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Image icon
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GoldDisplay.NativeFieldInfoPtr_icon));
      return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GoldDisplay.NativeFieldInfoPtr_icon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool doPing
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GoldDisplay.NativeFieldInfoPtr_doPing));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GoldDisplay.NativeFieldInfoPtr_doPing)) = value;
    }
  }

  public unsafe LeanTweenType pingEase
  {
    get
    {
      return *(LeanTweenType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GoldDisplay.NativeFieldInfoPtr_pingEase));
    }
    [param: In] set
    {
      *(LeanTweenType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GoldDisplay.NativeFieldInfoPtr_pingEase)) = value;
    }
  }

  public unsafe AnimationCurve pingCurve
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GoldDisplay.NativeFieldInfoPtr_pingCurve));
      return pointer == System.IntPtr.Zero ? (AnimationCurve) null : new AnimationCurve(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GoldDisplay.NativeFieldInfoPtr_pingCurve), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float pingDur
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GoldDisplay.NativeFieldInfoPtr_pingDur));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GoldDisplay.NativeFieldInfoPtr_pingDur)) = value;
    }
  }

  public unsafe TMP_Text textAsset
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GoldDisplay.NativeFieldInfoPtr_textAsset));
      return pointer == System.IntPtr.Zero ? (TMP_Text) null : new TMP_Text(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GoldDisplay.NativeFieldInfoPtr_textAsset), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe string format
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GoldDisplay.NativeFieldInfoPtr_format)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GoldDisplay.NativeFieldInfoPtr_format), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string formatAdd
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GoldDisplay.NativeFieldInfoPtr_formatAdd)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GoldDisplay.NativeFieldInfoPtr_formatAdd), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string formatSub
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GoldDisplay.NativeFieldInfoPtr_formatSub)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GoldDisplay.NativeFieldInfoPtr_formatSub), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string formatChangeUp
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GoldDisplay.NativeFieldInfoPtr_formatChangeUp)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GoldDisplay.NativeFieldInfoPtr_formatChangeUp), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string formatChangeDown
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GoldDisplay.NativeFieldInfoPtr_formatChangeDown)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GoldDisplay.NativeFieldInfoPtr_formatChangeDown), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe float addDelay
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GoldDisplay.NativeFieldInfoPtr_addDelay));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GoldDisplay.NativeFieldInfoPtr_addDelay)) = value;
    }
  }

  public unsafe float totalAddTime
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GoldDisplay.NativeFieldInfoPtr_totalAddTime));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GoldDisplay.NativeFieldInfoPtr_totalAddTime)) = value;
    }
  }

  public unsafe float addBetweenTimeMax
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GoldDisplay.NativeFieldInfoPtr_addBetweenTimeMax));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GoldDisplay.NativeFieldInfoPtr_addBetweenTimeMax)) = value;
    }
  }

  public unsafe int goldPre
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GoldDisplay.NativeFieldInfoPtr_goldPre));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GoldDisplay.NativeFieldInfoPtr_goldPre)) = value;
    }
  }

  public unsafe float current
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GoldDisplay.NativeFieldInfoPtr_current));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GoldDisplay.NativeFieldInfoPtr_current)) = value;
    }
  }

  public unsafe float _add_k__BackingField
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GoldDisplay.NativeFieldInfoPtr__add_k__BackingField));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GoldDisplay.NativeFieldInfoPtr__add_k__BackingField)) = value;
    }
  }

  public unsafe float change
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GoldDisplay.NativeFieldInfoPtr_change));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GoldDisplay.NativeFieldInfoPtr_change)) = value;
    }
  }

  [ObfuscatedName("GoldDisplay/<ResolveAdd>d__29")]
  public sealed class _ResolveAdd_d__29 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr_delay;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr__timeBetween_5__2;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    [CallerCount(53)]
    [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _ResolveAdd_d__29(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GoldDisplay._ResolveAdd_d__29>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GoldDisplay._ResolveAdd_d__29.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(12611)]
    [CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12665, XrefRangeStart = 54, XrefRangeEnd = 12665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GoldDisplay._ResolveAdd_d__29.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GoldDisplay._ResolveAdd_d__29.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GoldDisplay._ResolveAdd_d__29.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50650, XrefRangeEnd = 50656, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GoldDisplay._ResolveAdd_d__29.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GoldDisplay._ResolveAdd_d__29.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    static _ResolveAdd_d__29()
    {
      Il2CppClassPointerStore<GoldDisplay._ResolveAdd_d__29>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GoldDisplay>.NativeClassPtr, "<ResolveAdd>d__29");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GoldDisplay._ResolveAdd_d__29>.NativeClassPtr);
      GoldDisplay._ResolveAdd_d__29.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoldDisplay._ResolveAdd_d__29>.NativeClassPtr, "<>1__state");
      GoldDisplay._ResolveAdd_d__29.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoldDisplay._ResolveAdd_d__29>.NativeClassPtr, "<>2__current");
      GoldDisplay._ResolveAdd_d__29.NativeFieldInfoPtr_delay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoldDisplay._ResolveAdd_d__29>.NativeClassPtr, nameof (delay));
      GoldDisplay._ResolveAdd_d__29.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoldDisplay._ResolveAdd_d__29>.NativeClassPtr, "<>4__this");
      GoldDisplay._ResolveAdd_d__29.NativeFieldInfoPtr__timeBetween_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoldDisplay._ResolveAdd_d__29>.NativeClassPtr, "<timeBetween>5__2");
      GoldDisplay._ResolveAdd_d__29.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoldDisplay._ResolveAdd_d__29>.NativeClassPtr, 100667344);
      GoldDisplay._ResolveAdd_d__29.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoldDisplay._ResolveAdd_d__29>.NativeClassPtr, 100667345);
      GoldDisplay._ResolveAdd_d__29.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoldDisplay._ResolveAdd_d__29>.NativeClassPtr, 100667346);
      GoldDisplay._ResolveAdd_d__29.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoldDisplay._ResolveAdd_d__29>.NativeClassPtr, 100667347);
      GoldDisplay._ResolveAdd_d__29.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoldDisplay._ResolveAdd_d__29>.NativeClassPtr, 100667348);
      GoldDisplay._ResolveAdd_d__29.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoldDisplay._ResolveAdd_d__29>.NativeClassPtr, 100667349);
    }

    public _ResolveAdd_d__29(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GoldDisplay._ResolveAdd_d__29.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GoldDisplay._ResolveAdd_d__29.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GoldDisplay._ResolveAdd_d__29.NativeFieldInfoPtr___2__current));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GoldDisplay._ResolveAdd_d__29.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float delay
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GoldDisplay._ResolveAdd_d__29.NativeFieldInfoPtr_delay));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GoldDisplay._ResolveAdd_d__29.NativeFieldInfoPtr_delay)) = value;
      }
    }

    public unsafe GoldDisplay __4__this
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GoldDisplay._ResolveAdd_d__29.NativeFieldInfoPtr___4__this));
        return pointer == System.IntPtr.Zero ? (GoldDisplay) null : new GoldDisplay(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GoldDisplay._ResolveAdd_d__29.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float _timeBetween_5__2
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GoldDisplay._ResolveAdd_d__29.NativeFieldInfoPtr__timeBetween_5__2));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GoldDisplay._ResolveAdd_d__29.NativeFieldInfoPtr__timeBetween_5__2)) = value;
      }
    }
  }
}
