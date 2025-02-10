// Decompiled with JetBrains decompiler
// Type: MapPath
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class MapPath : MonoBehaviour
{
  private static readonly System.IntPtr NativeFieldInfoPtr_linePointPrefab;
  private static readonly System.IntPtr NativeFieldInfoPtr_lastPoint;
  private static readonly System.IntPtr NativeFieldInfoPtr_midPointOffset;
  private static readonly System.IntPtr NativeFieldInfoPtr_pathShort;
  private static readonly System.IntPtr NativeFieldInfoPtr_pathNodePull;
  private static readonly System.IntPtr NativeFieldInfoPtr_line;
  private static readonly System.IntPtr NativeFieldInfoPtr_curve;
  private static readonly System.IntPtr NativeFieldInfoPtr_revealEase;
  private static readonly System.IntPtr NativeFieldInfoPtr_revealSpeed;
  private static readonly System.IntPtr NativeFieldInfoPtr_nodes;
  private static readonly System.IntPtr NativeFieldInfoPtr__StartNode_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr_reachable;
  private static readonly System.IntPtr NativeFieldInfoPtr_alpha;
  private static readonly System.IntPtr NativeFieldInfoPtr_alphaTween;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_StartNode_Public_get_MapNode_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_StartNode_Private_set_Void_MapNode_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_EndNode_Public_get_MapNode_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_NodeCount_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ContainsNode_Public_Boolean_MapNode_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Add_Public_Void_MapNode_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_MapNode_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetNodes_Public_Il2CppReferenceArray_1_MapNode_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Setup_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PullTowards_Public_Void_Transform_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddPoint_Public_Transform_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Hide_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Reveal_Public_IEnumerator_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CheckReachable_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetUnreachable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FadeTo_Public_Void_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UpdatePathVisibility_Private_Void_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetColour_Private_Void_Color_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetAlpha_Private_Void_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__Reveal_b__29_0_Private_Void_Single_0;

  public unsafe MapNode StartNode
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MapPath.NativeMethodInfoPtr_get_StartNode_Public_get_MapNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (MapNode) null : new MapNode(pointer);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52439, XrefRangeEnd = 52440, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MapPath.NativeMethodInfoPtr_set_StartNode_Private_set_Void_MapNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }
  }

  public unsafe MapNode EndNode
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52440, XrefRangeEnd = 52444, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MapPath.NativeMethodInfoPtr_get_EndNode_Public_get_MapNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (MapNode) null : new MapNode(pointer);
    }
  }

  public unsafe int NodeCount
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52444, XrefRangeEnd = 52445, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MapPath.NativeMethodInfoPtr_get_NodeCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 52460, RefRangeEnd = 52462, XrefRangeStart = 52445, XrefRangeEnd = 52460, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool ContainsNode(MapNode node)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) node)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MapPath.NativeMethodInfoPtr_ContainsNode_Public_Boolean_MapNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 52483, RefRangeEnd = 52484, XrefRangeStart = 52462, XrefRangeEnd = 52483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Add(MapNode node)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) node)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(MapPath.NativeMethodInfoPtr_Add_Public_Void_MapNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52484, XrefRangeEnd = 52487, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe MapNode Get(int index)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &index
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MapPath.NativeMethodInfoPtr_Get_Public_MapNode_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (MapNode) null : new MapNode(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52487, XrefRangeEnd = 52513, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Il2CppReferenceArray<MapNode> GetNodes()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MapPath.NativeMethodInfoPtr_GetNodes_Public_Il2CppReferenceArray_1_MapNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr nativeObject = num;
    return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<MapNode>) null : new Il2CppReferenceArray<MapNode>(nativeObject);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 52566, RefRangeEnd = 52567, XrefRangeStart = 52513, XrefRangeEnd = 52566, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Setup()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(MapPath.NativeMethodInfoPtr_Setup_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 52571, RefRangeEnd = 52574, XrefRangeStart = 52567, XrefRangeEnd = 52571, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void PullTowards(Transform point, Vector3 towards, float amount)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) point);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &towards;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &amount;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(MapPath.NativeMethodInfoPtr_PullTowards_Public_Void_Transform_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 52584, RefRangeEnd = 52586, XrefRangeStart = 52574, XrefRangeEnd = 52584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Transform AddPoint(Vector3 localPosition)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &localPosition
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MapPath.NativeMethodInfoPtr_AddPoint_Public_Transform_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (Transform) null : new Transform(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52586, XrefRangeEnd = 52590, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Hide()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(MapPath.NativeMethodInfoPtr_Hide_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52590, XrefRangeEnd = 52595, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator Reveal()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MapPath.NativeMethodInfoPtr_Reveal_Public_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 52601, RefRangeEnd = 52602, XrefRangeStart = 52595, XrefRangeEnd = 52601, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CheckReachable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(MapPath.NativeMethodInfoPtr_CheckReachable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52602, XrefRangeEnd = 52603, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetUnreachable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(MapPath.NativeMethodInfoPtr_SetUnreachable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 52619, RefRangeEnd = 52623, XrefRangeStart = 52603, XrefRangeEnd = 52619, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void FadeTo(float alpha, float time = 0.3f)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &alpha;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(MapPath.NativeMethodInfoPtr_FadeTo_Public_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 52634, RefRangeEnd = 52636, XrefRangeStart = 52623, XrefRangeEnd = 52634, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UpdatePathVisibility(float value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &value
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(MapPath.NativeMethodInfoPtr_UpdatePathVisibility_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52636, XrefRangeEnd = 52643, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetColour(Color value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &value
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(MapPath.NativeMethodInfoPtr_SetColour_Private_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 52651, RefRangeEnd = 52653, XrefRangeStart = 52643, XrefRangeEnd = 52651, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetAlpha(float value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &value
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(MapPath.NativeMethodInfoPtr_SetAlpha_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52653, XrefRangeEnd = 52662, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe MapPath()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MapPath>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(MapPath.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52662, XrefRangeEnd = 52663, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _Reveal_b__29_0(float a)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &a
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(MapPath.NativeMethodInfoPtr__Reveal_b__29_0_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static MapPath()
  {
    Il2CppClassPointerStore<MapPath>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (MapPath));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapPath>.NativeClassPtr);
    MapPath.NativeFieldInfoPtr_linePointPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapPath>.NativeClassPtr, nameof (linePointPrefab));
    MapPath.NativeFieldInfoPtr_lastPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapPath>.NativeClassPtr, nameof (lastPoint));
    MapPath.NativeFieldInfoPtr_midPointOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapPath>.NativeClassPtr, nameof (midPointOffset));
    MapPath.NativeFieldInfoPtr_pathShort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapPath>.NativeClassPtr, nameof (pathShort));
    MapPath.NativeFieldInfoPtr_pathNodePull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapPath>.NativeClassPtr, nameof (pathNodePull));
    MapPath.NativeFieldInfoPtr_line = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapPath>.NativeClassPtr, nameof (line));
    MapPath.NativeFieldInfoPtr_curve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapPath>.NativeClassPtr, nameof (curve));
    MapPath.NativeFieldInfoPtr_revealEase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapPath>.NativeClassPtr, nameof (revealEase));
    MapPath.NativeFieldInfoPtr_revealSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapPath>.NativeClassPtr, nameof (revealSpeed));
    MapPath.NativeFieldInfoPtr_nodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapPath>.NativeClassPtr, nameof (nodes));
    MapPath.NativeFieldInfoPtr__StartNode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapPath>.NativeClassPtr, "<StartNode>k__BackingField");
    MapPath.NativeFieldInfoPtr_reachable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapPath>.NativeClassPtr, nameof (reachable));
    MapPath.NativeFieldInfoPtr_alpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapPath>.NativeClassPtr, nameof (alpha));
    MapPath.NativeFieldInfoPtr_alphaTween = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapPath>.NativeClassPtr, nameof (alphaTween));
    MapPath.NativeMethodInfoPtr_get_StartNode_Public_get_MapNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapPath>.NativeClassPtr, 100667529);
    MapPath.NativeMethodInfoPtr_set_StartNode_Private_set_Void_MapNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapPath>.NativeClassPtr, 100667530);
    MapPath.NativeMethodInfoPtr_get_EndNode_Public_get_MapNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapPath>.NativeClassPtr, 100667531);
    MapPath.NativeMethodInfoPtr_get_NodeCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapPath>.NativeClassPtr, 100667532);
    MapPath.NativeMethodInfoPtr_ContainsNode_Public_Boolean_MapNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapPath>.NativeClassPtr, 100667533);
    MapPath.NativeMethodInfoPtr_Add_Public_Void_MapNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapPath>.NativeClassPtr, 100667534);
    MapPath.NativeMethodInfoPtr_Get_Public_MapNode_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapPath>.NativeClassPtr, 100667535);
    MapPath.NativeMethodInfoPtr_GetNodes_Public_Il2CppReferenceArray_1_MapNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapPath>.NativeClassPtr, 100667536);
    MapPath.NativeMethodInfoPtr_Setup_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapPath>.NativeClassPtr, 100667537);
    MapPath.NativeMethodInfoPtr_PullTowards_Public_Void_Transform_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapPath>.NativeClassPtr, 100667538);
    MapPath.NativeMethodInfoPtr_AddPoint_Public_Transform_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapPath>.NativeClassPtr, 100667539);
    MapPath.NativeMethodInfoPtr_Hide_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapPath>.NativeClassPtr, 100667540);
    MapPath.NativeMethodInfoPtr_Reveal_Public_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapPath>.NativeClassPtr, 100667541);
    MapPath.NativeMethodInfoPtr_CheckReachable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapPath>.NativeClassPtr, 100667542);
    MapPath.NativeMethodInfoPtr_SetUnreachable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapPath>.NativeClassPtr, 100667543);
    MapPath.NativeMethodInfoPtr_FadeTo_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapPath>.NativeClassPtr, 100667544);
    MapPath.NativeMethodInfoPtr_UpdatePathVisibility_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapPath>.NativeClassPtr, 100667545);
    MapPath.NativeMethodInfoPtr_SetColour_Private_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapPath>.NativeClassPtr, 100667546);
    MapPath.NativeMethodInfoPtr_SetAlpha_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapPath>.NativeClassPtr, 100667547);
    MapPath.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapPath>.NativeClassPtr, 100667548);
    MapPath.NativeMethodInfoPtr__Reveal_b__29_0_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapPath>.NativeClassPtr, 100667549);
  }

  public MapPath(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Transform linePointPrefab
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapPath.NativeFieldInfoPtr_linePointPrefab));
      return pointer == System.IntPtr.Zero ? (Transform) null : new Transform(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapPath.NativeFieldInfoPtr_linePointPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Transform lastPoint
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapPath.NativeFieldInfoPtr_lastPoint));
      return pointer == System.IntPtr.Zero ? (Transform) null : new Transform(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapPath.NativeFieldInfoPtr_lastPoint), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector2 midPointOffset
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapPath.NativeFieldInfoPtr_midPointOffset));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapPath.NativeFieldInfoPtr_midPointOffset)) = value;
    }
  }

  public unsafe float pathShort
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapPath.NativeFieldInfoPtr_pathShort));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapPath.NativeFieldInfoPtr_pathShort)) = value;
    }
  }

  public unsafe Vector2 pathNodePull
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapPath.NativeFieldInfoPtr_pathNodePull));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapPath.NativeFieldInfoPtr_pathNodePull)) = value;
    }
  }

  public unsafe LineRenderer line
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapPath.NativeFieldInfoPtr_line));
      return pointer == System.IntPtr.Zero ? (LineRenderer) null : new LineRenderer(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapPath.NativeFieldInfoPtr_line), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CurvedLineRenderer curve
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapPath.NativeFieldInfoPtr_curve));
      return pointer == System.IntPtr.Zero ? (CurvedLineRenderer) null : new CurvedLineRenderer(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapPath.NativeFieldInfoPtr_curve), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LeanTweenType revealEase
  {
    get
    {
      return *(LeanTweenType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapPath.NativeFieldInfoPtr_revealEase));
    }
    [param: In] set
    {
      *(LeanTweenType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapPath.NativeFieldInfoPtr_revealEase)) = value;
    }
  }

  public unsafe float revealSpeed
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapPath.NativeFieldInfoPtr_revealSpeed));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapPath.NativeFieldInfoPtr_revealSpeed)) = value;
    }
  }

  public unsafe List<MapPath.Node> nodes
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapPath.NativeFieldInfoPtr_nodes));
      return pointer == System.IntPtr.Zero ? (List<MapPath.Node>) null : new List<MapPath.Node>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapPath.NativeFieldInfoPtr_nodes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe MapNode _StartNode_k__BackingField
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapPath.NativeFieldInfoPtr__StartNode_k__BackingField));
      return pointer == System.IntPtr.Zero ? (MapNode) null : new MapNode(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapPath.NativeFieldInfoPtr__StartNode_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool reachable
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapPath.NativeFieldInfoPtr_reachable));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapPath.NativeFieldInfoPtr_reachable)) = value;
    }
  }

  public unsafe float alpha
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapPath.NativeFieldInfoPtr_alpha));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapPath.NativeFieldInfoPtr_alpha)) = value;
    }
  }

  public unsafe LTDescr alphaTween
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapPath.NativeFieldInfoPtr_alphaTween));
      return pointer == System.IntPtr.Zero ? (LTDescr) null : new LTDescr(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapPath.NativeFieldInfoPtr_alphaTween), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public sealed class Node : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_mapNode;
    private static readonly System.IntPtr NativeFieldInfoPtr_point;

    static Node()
    {
      Il2CppClassPointerStore<MapPath.Node>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MapPath>.NativeClassPtr, nameof (Node));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapPath.Node>.NativeClassPtr);
      MapPath.Node.NativeFieldInfoPtr_mapNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapPath.Node>.NativeClassPtr, nameof (mapNode));
      MapPath.Node.NativeFieldInfoPtr_point = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapPath.Node>.NativeClassPtr, nameof (point));
    }

    public Node(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public Node()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MapPath.Node>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MapPath.Node>.NativeClassPtr, data));
    }

    public unsafe MapNode mapNode
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapPath.Node.NativeFieldInfoPtr_mapNode));
        return pointer == System.IntPtr.Zero ? (MapNode) null : new MapNode(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapPath.Node.NativeFieldInfoPtr_mapNode), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Transform point
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapPath.Node.NativeFieldInfoPtr_point));
        return pointer == System.IntPtr.Zero ? (Transform) null : new Transform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapPath.Node.NativeFieldInfoPtr_point), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("MapPath/<>c__DisplayClass18_0")]
  public sealed class __c__DisplayClass18_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_node;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ContainsNode_b__0_Internal_Boolean_Node_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass18_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MapPath.__c__DisplayClass18_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MapPath.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52379, XrefRangeEnd = 52383, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _ContainsNode_b__0(MapPath.Node a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) a))
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MapPath.__c__DisplayClass18_0.NativeMethodInfoPtr__ContainsNode_b__0_Internal_Boolean_Node_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c__DisplayClass18_0()
    {
      Il2CppClassPointerStore<MapPath.__c__DisplayClass18_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MapPath>.NativeClassPtr, "<>c__DisplayClass18_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapPath.__c__DisplayClass18_0>.NativeClassPtr);
      MapPath.__c__DisplayClass18_0.NativeFieldInfoPtr_node = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapPath.__c__DisplayClass18_0>.NativeClassPtr, nameof (node));
      MapPath.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapPath.__c__DisplayClass18_0>.NativeClassPtr, 100667550);
      MapPath.__c__DisplayClass18_0.NativeMethodInfoPtr__ContainsNode_b__0_Internal_Boolean_Node_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapPath.__c__DisplayClass18_0>.NativeClassPtr, 100667551);
    }

    public __c__DisplayClass18_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe MapNode node
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapPath.__c__DisplayClass18_0.NativeFieldInfoPtr_node));
        return pointer == System.IntPtr.Zero ? (MapNode) null : new MapNode(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapPath.__c__DisplayClass18_0.NativeFieldInfoPtr_node), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("MapPath/<Reveal>d__29")]
  public sealed class _Reveal_d__29 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr__delayPerNode_5__2;
    private static readonly System.IntPtr NativeFieldInfoPtr___7__wrap2;
    private static readonly System.IntPtr NativeFieldInfoPtr__node_5__4;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    [CallerCount(53)]
    [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _Reveal_d__29(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MapPath._Reveal_d__29>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MapPath._Reveal_d__29.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52383, XrefRangeEnd = 52390, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MapPath._Reveal_d__29.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52390, XrefRangeEnd = 52430, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MapPath._Reveal_d__29.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52430, XrefRangeEnd = 52433, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void __m__Finally1()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MapPath._Reveal_d__29.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EGeneric\u002EIEnumerator\u003CSystem\u002EObject\u003E\u002ECurrent
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MapPath._Reveal_d__29.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52433, XrefRangeEnd = 52439, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MapPath._Reveal_d__29.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MapPath._Reveal_d__29.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    static _Reveal_d__29()
    {
      Il2CppClassPointerStore<MapPath._Reveal_d__29>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MapPath>.NativeClassPtr, "<Reveal>d__29");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapPath._Reveal_d__29>.NativeClassPtr);
      MapPath._Reveal_d__29.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapPath._Reveal_d__29>.NativeClassPtr, "<>1__state");
      MapPath._Reveal_d__29.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapPath._Reveal_d__29>.NativeClassPtr, "<>2__current");
      MapPath._Reveal_d__29.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapPath._Reveal_d__29>.NativeClassPtr, "<>4__this");
      MapPath._Reveal_d__29.NativeFieldInfoPtr__delayPerNode_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapPath._Reveal_d__29>.NativeClassPtr, "<delayPerNode>5__2");
      MapPath._Reveal_d__29.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapPath._Reveal_d__29>.NativeClassPtr, "<>7__wrap2");
      MapPath._Reveal_d__29.NativeFieldInfoPtr__node_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapPath._Reveal_d__29>.NativeClassPtr, "<node>5__4");
      MapPath._Reveal_d__29.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapPath._Reveal_d__29>.NativeClassPtr, 100667552);
      MapPath._Reveal_d__29.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapPath._Reveal_d__29>.NativeClassPtr, 100667553);
      MapPath._Reveal_d__29.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapPath._Reveal_d__29>.NativeClassPtr, 100667554);
      MapPath._Reveal_d__29.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapPath._Reveal_d__29>.NativeClassPtr, 100667555);
      MapPath._Reveal_d__29.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapPath._Reveal_d__29>.NativeClassPtr, 100667556);
      MapPath._Reveal_d__29.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapPath._Reveal_d__29>.NativeClassPtr, 100667557);
      MapPath._Reveal_d__29.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapPath._Reveal_d__29>.NativeClassPtr, 100667558);
    }

    public _Reveal_d__29(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapPath._Reveal_d__29.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapPath._Reveal_d__29.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapPath._Reveal_d__29.NativeFieldInfoPtr___2__current));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapPath._Reveal_d__29.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe MapPath __4__this
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapPath._Reveal_d__29.NativeFieldInfoPtr___4__this));
        return pointer == System.IntPtr.Zero ? (MapPath) null : new MapPath(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MapPath._Reveal_d__29.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float _delayPerNode_5__2
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapPath._Reveal_d__29.NativeFieldInfoPtr__delayPerNode_5__2));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapPath._Reveal_d__29.NativeFieldInfoPtr__delayPerNode_5__2)) = value;
      }
    }

    public List<MapPath.Node>.Enumerator __7__wrap2
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapPath._Reveal_d__29.NativeFieldInfoPtr___7__wrap2);
        return new List<MapPath.Node>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<MapPath.Node>.Enumerator>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapPath._Reveal_d__29.NativeFieldInfoPtr___7__wrap2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<MapPath.Node>.Enumerator>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public MapPath.Node _node_5__4
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapPath._Reveal_d__29.NativeFieldInfoPtr__node_5__4);
        return new MapPath.Node(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MapPath.Node>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MapPath._Reveal_d__29.NativeFieldInfoPtr__node_5__4), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MapPath.Node>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }
}
