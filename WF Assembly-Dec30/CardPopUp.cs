// Decompiled with JetBrains decompiler
// Type: CardPopUp
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.UI;

#nullable disable
public class CardPopUp : MonoBehaviourRectSingleton<CardPopUp>
{
  private static readonly System.IntPtr NativeFieldInfoPtr_canvas;
  private static readonly System.IntPtr NativeFieldInfoPtr_bounds;
  private static readonly System.IntPtr NativeFieldInfoPtr_boundingBox;
  private static readonly System.IntPtr NativeFieldInfoPtr_layout;
  private static readonly System.IntPtr NativeFieldInfoPtr_sizeFitter;
  private static readonly System.IntPtr NativeFieldInfoPtr_gap;
  private static readonly System.IntPtr NativeFieldInfoPtr_posX;
  private static readonly System.IntPtr NativeFieldInfoPtr_posY;
  private static readonly System.IntPtr NativeFieldInfoPtr_keywordTooltipPrefab;
  private static readonly System.IntPtr NativeFieldInfoPtr_keywordTooltipInitialPool;
  private static readonly System.IntPtr NativeFieldInfoPtr_cardTooltipPrefab;
  private static readonly System.IntPtr NativeFieldInfoPtr_cardTooltipInitialPool;
  private static readonly System.IntPtr NativeFieldInfoPtr_activePanels;
  private static readonly System.IntPtr NativeFieldInfoPtr_follow;
  private static readonly System.IntPtr NativeFieldInfoPtr_pool;
  private static readonly System.IntPtr NativeFieldInfoPtr_ignoreTimeScale;
  private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetCanvasLayer_Public_Static_Void_String_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetIgnoreTimeScale_Public_Static_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Reset_Public_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AssignToCard_Public_Static_Void_Card_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AssignTo_Public_Static_Void_RectTransform_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddPanel_Public_Static_CardPopUpPanel_String_String_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddPanel_Public_Static_CardPopUpPanel_KeywordData_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddPanel_Public_Static_CardTooltip_CardData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RemovePanel_Public_Static_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetPanel_Private_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PoolPanel_Private_Void_Tooltip_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_StartFixLayouts_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FixLayouts_Private_IEnumerator_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ApplyLimits_Private_Vector3_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36354, XrefRangeEnd = 36381, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardPopUp.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36381, XrefRangeEnd = 36407, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardPopUp.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 36415, RefRangeEnd = 36416, XrefRangeStart = 36407, XrefRangeEnd = 36415, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetCanvasLayer(string layerName, int orderInLayer)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(layerName);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &orderInLayer;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardPopUp.NativeMethodInfoPtr_SetCanvasLayer_Public_Static_Void_String_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 36419, RefRangeEnd = 36420, XrefRangeStart = 36416, XrefRangeEnd = 36419, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetIgnoreTimeScale(bool ignore)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &ignore
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardPopUp.NativeMethodInfoPtr_SetIgnoreTimeScale_Public_Static_Void_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 36432, RefRangeEnd = 36433, XrefRangeStart = 36420, XrefRangeEnd = 36432, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Reset()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardPopUp.NativeMethodInfoPtr_Reset_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36433, XrefRangeEnd = 36446, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void AssignToCard(Card card)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) card)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardPopUp.NativeMethodInfoPtr_AssignToCard_Public_Static_Void_Card_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(9)]
  [CachedScanResults(RefRangeStart = 36454, RefRangeEnd = 36463, XrefRangeStart = 36446, XrefRangeEnd = 36454, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void AssignTo(RectTransform rect, float posX, float posY)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) rect);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &posX;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &posY;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardPopUp.NativeMethodInfoPtr_AssignTo_Public_Static_Void_RectTransform_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 36506, RefRangeEnd = 36512, XrefRangeStart = 36463, XrefRangeEnd = 36506, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe CardPopUpPanel AddPanel(string name, string title, string body)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(name);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(title);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(body);
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardPopUp.NativeMethodInfoPtr_AddPanel_Public_Static_CardPopUpPanel_String_String_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (CardPopUpPanel) null : new CardPopUpPanel(pointer);
  }

  [CallerCount(7)]
  [CachedScanResults(RefRangeStart = 36560, RefRangeEnd = 36567, XrefRangeStart = 36512, XrefRangeEnd = 36560, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe CardPopUpPanel AddPanel(KeywordData keyword, string forceBody = null)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) keyword);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(forceBody);
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardPopUp.NativeMethodInfoPtr_AddPanel_Public_Static_CardPopUpPanel_KeywordData_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (CardPopUpPanel) null : new CardPopUpPanel(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 36601, RefRangeEnd = 36602, XrefRangeStart = 36567, XrefRangeEnd = 36601, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe CardTooltip AddPanel(CardData cardData)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cardData)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardPopUp.NativeMethodInfoPtr_AddPanel_Public_Static_CardTooltip_CardData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (CardTooltip) null : new CardTooltip(pointer);
  }

  [CallerCount(14)]
  [CachedScanResults(RefRangeStart = 36663, RefRangeEnd = 36677, XrefRangeStart = 36602, XrefRangeEnd = 36663, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void RemovePanel(string name)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(name)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardPopUp.NativeMethodInfoPtr_RemovePanel_Public_Static_Void_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 36732, RefRangeEnd = 36735, XrefRangeStart = 36677, XrefRangeEnd = 36732, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe T GetPanel<T>() where T : Tooltip
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(CardPopUp.MethodInfoStoreGeneric_GetPanel_Private_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return IL2CPP.PointerToValueGeneric<T>(objectPointer, false, true);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36735, XrefRangeEnd = 36744, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void PoolPanel(Tooltip panel)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) panel)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardPopUp.NativeMethodInfoPtr_PoolPanel_Private_Void_Tooltip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(7)]
  [CachedScanResults(RefRangeStart = 36772, RefRangeEnd = 36779, XrefRangeStart = 36744, XrefRangeEnd = 36772, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Clear()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardPopUp.NativeMethodInfoPtr_Clear_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36779, XrefRangeEnd = 36790, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void StartFixLayouts()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardPopUp.NativeMethodInfoPtr_StartFixLayouts_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36790, XrefRangeEnd = 36795, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator FixLayouts()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardPopUp.NativeMethodInfoPtr_FixLayouts_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36795, XrefRangeEnd = 36805, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector3 ApplyLimits(Vector3 pos)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &pos
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardPopUp.NativeMethodInfoPtr_ApplyLimits_Private_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36805, XrefRangeEnd = 36823, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CardPopUp()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardPopUp>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardPopUp.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static CardPopUp()
  {
    Il2CppClassPointerStore<CardPopUp>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (CardPopUp));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardPopUp>.NativeClassPtr);
    CardPopUp.NativeFieldInfoPtr_canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardPopUp>.NativeClassPtr, nameof (canvas));
    CardPopUp.NativeFieldInfoPtr_bounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardPopUp>.NativeClassPtr, nameof (bounds));
    CardPopUp.NativeFieldInfoPtr_boundingBox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardPopUp>.NativeClassPtr, nameof (boundingBox));
    CardPopUp.NativeFieldInfoPtr_layout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardPopUp>.NativeClassPtr, nameof (layout));
    CardPopUp.NativeFieldInfoPtr_sizeFitter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardPopUp>.NativeClassPtr, nameof (sizeFitter));
    CardPopUp.NativeFieldInfoPtr_gap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardPopUp>.NativeClassPtr, nameof (gap));
    CardPopUp.NativeFieldInfoPtr_posX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardPopUp>.NativeClassPtr, nameof (posX));
    CardPopUp.NativeFieldInfoPtr_posY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardPopUp>.NativeClassPtr, nameof (posY));
    CardPopUp.NativeFieldInfoPtr_keywordTooltipPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardPopUp>.NativeClassPtr, nameof (keywordTooltipPrefab));
    CardPopUp.NativeFieldInfoPtr_keywordTooltipInitialPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardPopUp>.NativeClassPtr, nameof (keywordTooltipInitialPool));
    CardPopUp.NativeFieldInfoPtr_cardTooltipPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardPopUp>.NativeClassPtr, nameof (cardTooltipPrefab));
    CardPopUp.NativeFieldInfoPtr_cardTooltipInitialPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardPopUp>.NativeClassPtr, nameof (cardTooltipInitialPool));
    CardPopUp.NativeFieldInfoPtr_activePanels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardPopUp>.NativeClassPtr, nameof (activePanels));
    CardPopUp.NativeFieldInfoPtr_follow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardPopUp>.NativeClassPtr, nameof (follow));
    CardPopUp.NativeFieldInfoPtr_pool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardPopUp>.NativeClassPtr, nameof (pool));
    CardPopUp.NativeFieldInfoPtr_ignoreTimeScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardPopUp>.NativeClassPtr, nameof (ignoreTimeScale));
    CardPopUp.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardPopUp>.NativeClassPtr, 100665715);
    CardPopUp.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardPopUp>.NativeClassPtr, 100665716);
    CardPopUp.NativeMethodInfoPtr_SetCanvasLayer_Public_Static_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardPopUp>.NativeClassPtr, 100665717);
    CardPopUp.NativeMethodInfoPtr_SetIgnoreTimeScale_Public_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardPopUp>.NativeClassPtr, 100665718);
    CardPopUp.NativeMethodInfoPtr_Reset_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardPopUp>.NativeClassPtr, 100665719);
    CardPopUp.NativeMethodInfoPtr_AssignToCard_Public_Static_Void_Card_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardPopUp>.NativeClassPtr, 100665720);
    CardPopUp.NativeMethodInfoPtr_AssignTo_Public_Static_Void_RectTransform_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardPopUp>.NativeClassPtr, 100665721);
    CardPopUp.NativeMethodInfoPtr_AddPanel_Public_Static_CardPopUpPanel_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardPopUp>.NativeClassPtr, 100665722);
    CardPopUp.NativeMethodInfoPtr_AddPanel_Public_Static_CardPopUpPanel_KeywordData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardPopUp>.NativeClassPtr, 100665723);
    CardPopUp.NativeMethodInfoPtr_AddPanel_Public_Static_CardTooltip_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardPopUp>.NativeClassPtr, 100665724);
    CardPopUp.NativeMethodInfoPtr_RemovePanel_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardPopUp>.NativeClassPtr, 100665725);
    CardPopUp.NativeMethodInfoPtr_GetPanel_Private_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardPopUp>.NativeClassPtr, 100665726);
    CardPopUp.NativeMethodInfoPtr_PoolPanel_Private_Void_Tooltip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardPopUp>.NativeClassPtr, 100665727);
    CardPopUp.NativeMethodInfoPtr_Clear_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardPopUp>.NativeClassPtr, 100665728);
    CardPopUp.NativeMethodInfoPtr_StartFixLayouts_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardPopUp>.NativeClassPtr, 100665729);
    CardPopUp.NativeMethodInfoPtr_FixLayouts_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardPopUp>.NativeClassPtr, 100665730);
    CardPopUp.NativeMethodInfoPtr_ApplyLimits_Private_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardPopUp>.NativeClassPtr, 100665731);
    CardPopUp.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardPopUp>.NativeClassPtr, 100665732);
  }

  public CardPopUp(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Canvas canvas
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardPopUp.NativeFieldInfoPtr_canvas));
      return pointer == System.IntPtr.Zero ? (Canvas) null : new Canvas(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardPopUp.NativeFieldInfoPtr_canvas), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe RectTransform bounds
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardPopUp.NativeFieldInfoPtr_bounds));
      return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardPopUp.NativeFieldInfoPtr_bounds), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe RectTransform boundingBox
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardPopUp.NativeFieldInfoPtr_boundingBox));
      return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardPopUp.NativeFieldInfoPtr_boundingBox), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe RectTransform layout
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardPopUp.NativeFieldInfoPtr_layout));
      return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardPopUp.NativeFieldInfoPtr_layout), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ContentSizeFitter sizeFitter
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardPopUp.NativeFieldInfoPtr_sizeFitter));
      return pointer == System.IntPtr.Zero ? (ContentSizeFitter) null : new ContentSizeFitter(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardPopUp.NativeFieldInfoPtr_sizeFitter), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float gap
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardPopUp.NativeFieldInfoPtr_gap));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardPopUp.NativeFieldInfoPtr_gap)) = value;
    }
  }

  public unsafe float posX
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardPopUp.NativeFieldInfoPtr_posX));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardPopUp.NativeFieldInfoPtr_posX)) = value;
    }
  }

  public unsafe float posY
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardPopUp.NativeFieldInfoPtr_posY));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardPopUp.NativeFieldInfoPtr_posY)) = value;
    }
  }

  public unsafe AssetReferenceGameObject keywordTooltipPrefab
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardPopUp.NativeFieldInfoPtr_keywordTooltipPrefab));
      return pointer == System.IntPtr.Zero ? (AssetReferenceGameObject) null : new AssetReferenceGameObject(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardPopUp.NativeFieldInfoPtr_keywordTooltipPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int keywordTooltipInitialPool
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardPopUp.NativeFieldInfoPtr_keywordTooltipInitialPool));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardPopUp.NativeFieldInfoPtr_keywordTooltipInitialPool)) = value;
    }
  }

  public unsafe AssetReferenceGameObject cardTooltipPrefab
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardPopUp.NativeFieldInfoPtr_cardTooltipPrefab));
      return pointer == System.IntPtr.Zero ? (AssetReferenceGameObject) null : new AssetReferenceGameObject(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardPopUp.NativeFieldInfoPtr_cardTooltipPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int cardTooltipInitialPool
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardPopUp.NativeFieldInfoPtr_cardTooltipInitialPool));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardPopUp.NativeFieldInfoPtr_cardTooltipInitialPool)) = value;
    }
  }

  public unsafe Dictionary<string, Tooltip> activePanels
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardPopUp.NativeFieldInfoPtr_activePanels));
      return pointer == System.IntPtr.Zero ? (Dictionary<string, Tooltip>) null : new Dictionary<string, Tooltip>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardPopUp.NativeFieldInfoPtr_activePanels), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe RectTransform follow
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardPopUp.NativeFieldInfoPtr_follow));
      return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardPopUp.NativeFieldInfoPtr_follow), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<Tooltip> pool
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardPopUp.NativeFieldInfoPtr_pool));
      return pointer == System.IntPtr.Zero ? (List<Tooltip>) null : new List<Tooltip>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardPopUp.NativeFieldInfoPtr_pool), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool ignoreTimeScale
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardPopUp.NativeFieldInfoPtr_ignoreTimeScale));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardPopUp.NativeFieldInfoPtr_ignoreTimeScale)) = value;
    }
  }

  [ObfuscatedName("CardPopUp/<>c__27`1")]
  [Serializable]
  public sealed class __c__27<T> : Il2CppSystem.Object where T : Tooltip
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__27_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__GetPanel_b__27_0_Internal_Boolean_Tooltip_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__27()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardPopUp.__c__27<T>>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CardPopUp.__c__27<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36345, XrefRangeEnd = 36347, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _GetPanel_b__27_0(Tooltip a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardPopUp.__c__27<T>.NativeMethodInfoPtr__GetPanel_b__27_0_Internal_Boolean_Tooltip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c__27()
    {
      // ISSUE: explicit non-virtual call
      // ISSUE: explicit non-virtual call
      Il2CppClassPointerStore<CardPopUp.__c__27<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CardPopUp>.NativeClassPtr, "<>c__27`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))).TypeHandle).value);
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardPopUp.__c__27<T>>.NativeClassPtr);
      CardPopUp.__c__27<T>.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardPopUp.__c__27<T>>.NativeClassPtr, "<>9");
      CardPopUp.__c__27<T>.NativeFieldInfoPtr___9__27_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardPopUp.__c__27<T>>.NativeClassPtr, "<>9__27_0");
      CardPopUp.__c__27<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardPopUp.__c__27<T>>.NativeClassPtr, 100665734);
      CardPopUp.__c__27<T>.NativeMethodInfoPtr__GetPanel_b__27_0_Internal_Boolean_Tooltip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardPopUp.__c__27<T>>.NativeClassPtr, 100665735);
    }

    public __c__27(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe CardPopUp.__c__27<T> __9
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(CardPopUp.__c__27<T>.NativeFieldInfoPtr___9, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (CardPopUp.__c__27<T>) null : new CardPopUp.__c__27<T>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CardPopUp.__c__27<T>.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<Tooltip, bool> __9__27_0
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(CardPopUp.__c__27<T>.NativeFieldInfoPtr___9__27_0, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<Tooltip, bool>) null : new Il2CppSystem.Func<Tooltip, bool>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CardPopUp.__c__27<T>.NativeFieldInfoPtr___9__27_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("CardPopUp/<FixLayouts>d__31")]
  public sealed class _FixLayouts_d__31 : Il2CppSystem.Object
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
    public unsafe _FixLayouts_d__31(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardPopUp._FixLayouts_d__31>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CardPopUp._FixLayouts_d__31.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(12611)]
    [CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12665, XrefRangeStart = 54, XrefRangeEnd = 12665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CardPopUp._FixLayouts_d__31.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36347, XrefRangeEnd = 36348, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardPopUp._FixLayouts_d__31.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardPopUp._FixLayouts_d__31.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36348, XrefRangeEnd = 36354, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CardPopUp._FixLayouts_d__31.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CardPopUp._FixLayouts_d__31.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    static _FixLayouts_d__31()
    {
      Il2CppClassPointerStore<CardPopUp._FixLayouts_d__31>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CardPopUp>.NativeClassPtr, "<FixLayouts>d__31");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardPopUp._FixLayouts_d__31>.NativeClassPtr);
      CardPopUp._FixLayouts_d__31.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardPopUp._FixLayouts_d__31>.NativeClassPtr, "<>1__state");
      CardPopUp._FixLayouts_d__31.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardPopUp._FixLayouts_d__31>.NativeClassPtr, "<>2__current");
      CardPopUp._FixLayouts_d__31.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardPopUp._FixLayouts_d__31>.NativeClassPtr, "<>4__this");
      CardPopUp._FixLayouts_d__31.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardPopUp._FixLayouts_d__31>.NativeClassPtr, 100665736);
      CardPopUp._FixLayouts_d__31.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardPopUp._FixLayouts_d__31>.NativeClassPtr, 100665737);
      CardPopUp._FixLayouts_d__31.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardPopUp._FixLayouts_d__31>.NativeClassPtr, 100665738);
      CardPopUp._FixLayouts_d__31.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardPopUp._FixLayouts_d__31>.NativeClassPtr, 100665739);
      CardPopUp._FixLayouts_d__31.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardPopUp._FixLayouts_d__31>.NativeClassPtr, 100665740);
      CardPopUp._FixLayouts_d__31.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardPopUp._FixLayouts_d__31>.NativeClassPtr, 100665741);
    }

    public _FixLayouts_d__31(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardPopUp._FixLayouts_d__31.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardPopUp._FixLayouts_d__31.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardPopUp._FixLayouts_d__31.NativeFieldInfoPtr___2__current));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardPopUp._FixLayouts_d__31.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CardPopUp __4__this
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardPopUp._FixLayouts_d__31.NativeFieldInfoPtr___4__this));
        return pointer == System.IntPtr.Zero ? (CardPopUp) null : new CardPopUp(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardPopUp._FixLayouts_d__31.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  private sealed class MethodInfoStoreGeneric_GetPanel_Private_T_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(CardPopUp.NativeMethodInfoPtr_GetPanel_Private_T_0, Il2CppClassPointerStore<CardPopUp>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }
}
