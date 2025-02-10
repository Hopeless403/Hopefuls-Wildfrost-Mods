// Decompiled with JetBrains decompiler
// Type: CampaignGenerator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading.Tasks;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class CampaignGenerator : ScriptableObject
{
  private static readonly System.IntPtr NativeFieldInfoPtr_seed;
  private static readonly System.IntPtr NativeFieldInfoPtr_nodeSizeRange;
  private static readonly System.IntPtr NativeFieldInfoPtr_nodeCreationRand;
  private static readonly System.IntPtr NativeFieldInfoPtr_nodeSpacing;
  private static readonly System.IntPtr NativeFieldInfoPtr_battleDistanceRange;
  private static readonly System.IntPtr NativeFieldInfoPtr_mapDirection;
  private static readonly System.IntPtr NativeFieldInfoPtr_presets;
  private static readonly System.IntPtr NativeFieldInfoPtr_instant;
  private static readonly System.IntPtr NativeFieldInfoPtr_restart;
  private static readonly System.IntPtr NativeFieldInfoPtr_restartOnError;
  private static readonly System.IntPtr NativeMethodInfoPtr_Generate_Public_Virtual_New_IEnumerator_Campaign_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryGenerate_Private_Task_1_Boolean_Campaign_Int32_List_1_Node_IReadOnlyDictionary_2_String_CampaignNodeType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetSeed_Protected_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ChoosePreset_Protected_TextAsset_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetPresetLines_Protected_Static_Il2CppStringArray_TextAsset_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetCampaignLength_Protected_Static_Int32_Il2CppStringArray_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateNode_Protected_Node_Single_Single_CampaignNodeType_Int32_Int32_Int32_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ShuffleNodes_Protected_Static_Void_List_1_Node_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ShuffleNodes_Public_Static_Void_List_1_CampaignNode_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LineIntersectsCircle_Protected_Static_Boolean_Line_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105937, XrefRangeEnd = 105943, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe IEnumerator Generate(Campaign campaign)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) campaign)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CampaignGenerator.NativeMethodInfoPtr_Generate_Public_Virtual_New_IEnumerator_Campaign_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IEnumerator) null : new IEnumerator(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105943, XrefRangeEnd = 105960, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Task<bool> TryGenerate(
    Campaign campaign,
    int attempt,
    List<CampaignGenerator.Node> nodes,
    IReadOnlyDictionary<string, CampaignNodeType> nodeDict)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) campaign);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &attempt;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) nodes);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) nodeDict);
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CampaignGenerator.NativeMethodInfoPtr_TryGenerate_Private_Task_1_Boolean_Campaign_Int32_List_1_Node_IReadOnlyDictionary_2_String_CampaignNodeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (Task<bool>) null : new Task<bool>(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105960, XrefRangeEnd = 105963, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetSeed()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CampaignGenerator.NativeMethodInfoPtr_SetSeed_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105963, XrefRangeEnd = 105974, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe TextAsset ChoosePreset()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CampaignGenerator.NativeMethodInfoPtr_ChoosePreset_Protected_TextAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (TextAsset) null : new TextAsset(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 105986, RefRangeEnd = 105987, XrefRangeStart = 105974, XrefRangeEnd = 105986, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Il2CppStringArray GetPresetLines(TextAsset preset)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) preset)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CampaignGenerator.NativeMethodInfoPtr_GetPresetLines_Protected_Static_Il2CppStringArray_TextAsset_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (Il2CppStringArray) null : new Il2CppStringArray(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105987, XrefRangeEnd = 105988, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int GetCampaignLength(Il2CppStringArray lines)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) lines)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CampaignGenerator.NativeMethodInfoPtr_GetCampaignLength_Protected_Static_Int32_Il2CppStringArray_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(int*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 106005, RefRangeEnd = 106008, XrefRangeStart = 105988, XrefRangeEnd = 106005, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CampaignGenerator.Node CreateNode(
    float x,
    float y,
    CampaignNodeType type,
    int tier,
    int positionIndex,
    int areaIndex,
    float r = 1f)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[7];
    numPtr[0] = (System.IntPtr) &x;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &y;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) type);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &tier;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &positionIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &areaIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &r;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CampaignGenerator.NativeMethodInfoPtr_CreateNode_Protected_Node_Single_Single_CampaignNodeType_Int32_Int32_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (CampaignGenerator.Node) null : new CampaignGenerator.Node(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 106051, RefRangeEnd = 106052, XrefRangeStart = 106008, XrefRangeEnd = 106051, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void ShuffleNodes(List<CampaignGenerator.Node> nodes)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) nodes)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CampaignGenerator.NativeMethodInfoPtr_ShuffleNodes_Protected_Static_Void_List_1_Node_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 106109, RefRangeEnd = 106110, XrefRangeStart = 106052, XrefRangeEnd = 106109, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void ShuffleNodes(List<CampaignNode> nodes)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) nodes)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CampaignGenerator.NativeMethodInfoPtr_ShuffleNodes_Public_Static_Void_List_1_CampaignNode_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 106110, RefRangeEnd = 106111, XrefRangeStart = 106110, XrefRangeEnd = 106110, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool LineIntersectsCircle(
    CampaignGenerator.Line line,
    float cx,
    float cy,
    float r)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) line);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &cx;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &cy;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &r;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CampaignGenerator.NativeMethodInfoPtr_LineIntersectsCircle_Protected_Static_Boolean_Line_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106111, XrefRangeEnd = 106112, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CampaignGenerator()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CampaignGenerator>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CampaignGenerator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static CampaignGenerator()
  {
    Il2CppClassPointerStore<CampaignGenerator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (CampaignGenerator));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CampaignGenerator>.NativeClassPtr);
    CampaignGenerator.NativeFieldInfoPtr_seed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignGenerator>.NativeClassPtr, nameof (seed));
    CampaignGenerator.NativeFieldInfoPtr_nodeSizeRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignGenerator>.NativeClassPtr, nameof (nodeSizeRange));
    CampaignGenerator.NativeFieldInfoPtr_nodeCreationRand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignGenerator>.NativeClassPtr, nameof (nodeCreationRand));
    CampaignGenerator.NativeFieldInfoPtr_nodeSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignGenerator>.NativeClassPtr, nameof (nodeSpacing));
    CampaignGenerator.NativeFieldInfoPtr_battleDistanceRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignGenerator>.NativeClassPtr, nameof (battleDistanceRange));
    CampaignGenerator.NativeFieldInfoPtr_mapDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignGenerator>.NativeClassPtr, nameof (mapDirection));
    CampaignGenerator.NativeFieldInfoPtr_presets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignGenerator>.NativeClassPtr, nameof (presets));
    CampaignGenerator.NativeFieldInfoPtr_instant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignGenerator>.NativeClassPtr, nameof (instant));
    CampaignGenerator.NativeFieldInfoPtr_restart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignGenerator>.NativeClassPtr, nameof (restart));
    CampaignGenerator.NativeFieldInfoPtr_restartOnError = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignGenerator>.NativeClassPtr, nameof (restartOnError));
    CampaignGenerator.NativeMethodInfoPtr_Generate_Public_Virtual_New_IEnumerator_Campaign_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignGenerator>.NativeClassPtr, 100672831);
    CampaignGenerator.NativeMethodInfoPtr_TryGenerate_Private_Task_1_Boolean_Campaign_Int32_List_1_Node_IReadOnlyDictionary_2_String_CampaignNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignGenerator>.NativeClassPtr, 100672832);
    CampaignGenerator.NativeMethodInfoPtr_SetSeed_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignGenerator>.NativeClassPtr, 100672833);
    CampaignGenerator.NativeMethodInfoPtr_ChoosePreset_Protected_TextAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignGenerator>.NativeClassPtr, 100672834);
    CampaignGenerator.NativeMethodInfoPtr_GetPresetLines_Protected_Static_Il2CppStringArray_TextAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignGenerator>.NativeClassPtr, 100672835);
    CampaignGenerator.NativeMethodInfoPtr_GetCampaignLength_Protected_Static_Int32_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignGenerator>.NativeClassPtr, 100672836);
    CampaignGenerator.NativeMethodInfoPtr_CreateNode_Protected_Node_Single_Single_CampaignNodeType_Int32_Int32_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignGenerator>.NativeClassPtr, 100672837);
    CampaignGenerator.NativeMethodInfoPtr_ShuffleNodes_Protected_Static_Void_List_1_Node_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignGenerator>.NativeClassPtr, 100672838);
    CampaignGenerator.NativeMethodInfoPtr_ShuffleNodes_Public_Static_Void_List_1_CampaignNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignGenerator>.NativeClassPtr, 100672839);
    CampaignGenerator.NativeMethodInfoPtr_LineIntersectsCircle_Protected_Static_Boolean_Line_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignGenerator>.NativeClassPtr, 100672840);
    CampaignGenerator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignGenerator>.NativeClassPtr, 100672841);
  }

  public CampaignGenerator(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe string seed
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignGenerator.NativeFieldInfoPtr_seed)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CampaignGenerator.NativeFieldInfoPtr_seed), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe Vector2 nodeSizeRange
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignGenerator.NativeFieldInfoPtr_nodeSizeRange));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignGenerator.NativeFieldInfoPtr_nodeSizeRange)) = value;
    }
  }

  public unsafe float nodeCreationRand
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignGenerator.NativeFieldInfoPtr_nodeCreationRand));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignGenerator.NativeFieldInfoPtr_nodeCreationRand)) = value;
    }
  }

  public unsafe Vector2 nodeSpacing
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignGenerator.NativeFieldInfoPtr_nodeSpacing));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignGenerator.NativeFieldInfoPtr_nodeSpacing)) = value;
    }
  }

  public unsafe Vector2 battleDistanceRange
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignGenerator.NativeFieldInfoPtr_battleDistanceRange));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignGenerator.NativeFieldInfoPtr_battleDistanceRange)) = value;
    }
  }

  public unsafe Vector2 mapDirection
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignGenerator.NativeFieldInfoPtr_mapDirection));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignGenerator.NativeFieldInfoPtr_mapDirection)) = value;
    }
  }

  public unsafe Il2CppReferenceArray<TextAsset> presets
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignGenerator.NativeFieldInfoPtr_presets));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<TextAsset>) null : new Il2CppReferenceArray<TextAsset>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CampaignGenerator.NativeFieldInfoPtr_presets), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool instant
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignGenerator.NativeFieldInfoPtr_instant));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignGenerator.NativeFieldInfoPtr_instant)) = value;
    }
  }

  public unsafe bool restart
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignGenerator.NativeFieldInfoPtr_restart));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignGenerator.NativeFieldInfoPtr_restart)) = value;
    }
  }

  public unsafe bool restartOnError
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignGenerator.NativeFieldInfoPtr_restartOnError));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignGenerator.NativeFieldInfoPtr_restartOnError)) = value;
    }
  }

  public class Line : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_x1;
    private static readonly System.IntPtr NativeFieldInfoPtr_y1;
    private static readonly System.IntPtr NativeFieldInfoPtr_x2;
    private static readonly System.IntPtr NativeFieldInfoPtr_y2;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 105543, RefRangeEnd = 105544, XrefRangeStart = 105542, XrefRangeEnd = 105543, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Line(float x1, float y1, float x2, float y2)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CampaignGenerator.Line>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &x1;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &y1;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &x2;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &y2;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CampaignGenerator.Line.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Line()
    {
      Il2CppClassPointerStore<CampaignGenerator.Line>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CampaignGenerator>.NativeClassPtr, nameof (Line));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CampaignGenerator.Line>.NativeClassPtr);
      CampaignGenerator.Line.NativeFieldInfoPtr_x1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignGenerator.Line>.NativeClassPtr, nameof (x1));
      CampaignGenerator.Line.NativeFieldInfoPtr_y1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignGenerator.Line>.NativeClassPtr, nameof (y1));
      CampaignGenerator.Line.NativeFieldInfoPtr_x2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignGenerator.Line>.NativeClassPtr, nameof (x2));
      CampaignGenerator.Line.NativeFieldInfoPtr_y2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignGenerator.Line>.NativeClassPtr, nameof (y2));
      CampaignGenerator.Line.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignGenerator.Line>.NativeClassPtr, 100672842);
    }

    public Line(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float x1
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignGenerator.Line.NativeFieldInfoPtr_x1));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignGenerator.Line.NativeFieldInfoPtr_x1)) = value;
      }
    }

    public unsafe float y1
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignGenerator.Line.NativeFieldInfoPtr_y1));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignGenerator.Line.NativeFieldInfoPtr_y1)) = value;
      }
    }

    public unsafe float x2
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignGenerator.Line.NativeFieldInfoPtr_x2));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignGenerator.Line.NativeFieldInfoPtr_x2)) = value;
      }
    }

    public unsafe float y2
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignGenerator.Line.NativeFieldInfoPtr_y2));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignGenerator.Line.NativeFieldInfoPtr_y2)) = value;
      }
    }
  }

  public class Node : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_x;
    private static readonly System.IntPtr NativeFieldInfoPtr_y;
    private static readonly System.IntPtr NativeFieldInfoPtr_r;
    private static readonly System.IntPtr NativeFieldInfoPtr_tier;
    private static readonly System.IntPtr NativeFieldInfoPtr_positionIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_type;
    private static readonly System.IntPtr NativeFieldInfoPtr_color;
    private static readonly System.IntPtr NativeFieldInfoPtr_campaignNode;
    private static readonly System.IntPtr NativeFieldInfoPtr_areaIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_connections;
    private static readonly System.IntPtr NativeFieldInfoPtr_connectionCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_interactable;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Int32_Int32_Int32_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Connect_Public_Void_Node_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 105559, RefRangeEnd = 105560, XrefRangeStart = 105549, XrefRangeEnd = 105559, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Node(
      float x,
      float y,
      float r,
      int tier,
      int positionIndex,
      int areaIndex,
      string type)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CampaignGenerator.Node>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[7];
      numPtr[0] = (System.IntPtr) &x;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &y;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &r;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &tier;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &positionIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &areaIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(type);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CampaignGenerator.Node.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Int32_Int32_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 105568, RefRangeEnd = 105569, XrefRangeStart = 105560, XrefRangeEnd = 105568, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Connect(CampaignGenerator.Node other)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CampaignGenerator.Node.NativeMethodInfoPtr_Connect_Public_Void_Node_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105569, XrefRangeEnd = 105577, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe string ToString()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CampaignGenerator.Node.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    static Node()
    {
      Il2CppClassPointerStore<CampaignGenerator.Node>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CampaignGenerator>.NativeClassPtr, nameof (Node));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CampaignGenerator.Node>.NativeClassPtr);
      CampaignGenerator.Node.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignGenerator.Node>.NativeClassPtr, nameof (x));
      CampaignGenerator.Node.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignGenerator.Node>.NativeClassPtr, nameof (y));
      CampaignGenerator.Node.NativeFieldInfoPtr_r = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignGenerator.Node>.NativeClassPtr, nameof (r));
      CampaignGenerator.Node.NativeFieldInfoPtr_tier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignGenerator.Node>.NativeClassPtr, nameof (tier));
      CampaignGenerator.Node.NativeFieldInfoPtr_positionIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignGenerator.Node>.NativeClassPtr, nameof (positionIndex));
      CampaignGenerator.Node.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignGenerator.Node>.NativeClassPtr, nameof (type));
      CampaignGenerator.Node.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignGenerator.Node>.NativeClassPtr, nameof (color));
      CampaignGenerator.Node.NativeFieldInfoPtr_campaignNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignGenerator.Node>.NativeClassPtr, nameof (campaignNode));
      CampaignGenerator.Node.NativeFieldInfoPtr_areaIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignGenerator.Node>.NativeClassPtr, nameof (areaIndex));
      CampaignGenerator.Node.NativeFieldInfoPtr_connections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignGenerator.Node>.NativeClassPtr, nameof (connections));
      CampaignGenerator.Node.NativeFieldInfoPtr_connectionCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignGenerator.Node>.NativeClassPtr, nameof (connectionCount));
      CampaignGenerator.Node.NativeFieldInfoPtr_interactable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignGenerator.Node>.NativeClassPtr, nameof (interactable));
      CampaignGenerator.Node.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Int32_Int32_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignGenerator.Node>.NativeClassPtr, 100672843);
      CampaignGenerator.Node.NativeMethodInfoPtr_Connect_Public_Void_Node_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignGenerator.Node>.NativeClassPtr, 100672844);
      CampaignGenerator.Node.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignGenerator.Node>.NativeClassPtr, 100672845);
    }

    public Node(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float x
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignGenerator.Node.NativeFieldInfoPtr_x));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignGenerator.Node.NativeFieldInfoPtr_x)) = value;
      }
    }

    public unsafe float y
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignGenerator.Node.NativeFieldInfoPtr_y));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignGenerator.Node.NativeFieldInfoPtr_y)) = value;
      }
    }

    public unsafe float r
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignGenerator.Node.NativeFieldInfoPtr_r));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignGenerator.Node.NativeFieldInfoPtr_r)) = value;
      }
    }

    public unsafe int tier
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignGenerator.Node.NativeFieldInfoPtr_tier));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignGenerator.Node.NativeFieldInfoPtr_tier)) = value;
      }
    }

    public unsafe int positionIndex
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignGenerator.Node.NativeFieldInfoPtr_positionIndex));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignGenerator.Node.NativeFieldInfoPtr_positionIndex)) = value;
      }
    }

    public unsafe string type
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignGenerator.Node.NativeFieldInfoPtr_type)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CampaignGenerator.Node.NativeFieldInfoPtr_type), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe Color color
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignGenerator.Node.NativeFieldInfoPtr_color));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignGenerator.Node.NativeFieldInfoPtr_color)) = value;
      }
    }

    public unsafe CampaignNode campaignNode
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignGenerator.Node.NativeFieldInfoPtr_campaignNode));
        return pointer == System.IntPtr.Zero ? (CampaignNode) null : new CampaignNode(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CampaignGenerator.Node.NativeFieldInfoPtr_campaignNode), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int areaIndex
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignGenerator.Node.NativeFieldInfoPtr_areaIndex));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignGenerator.Node.NativeFieldInfoPtr_areaIndex)) = value;
      }
    }

    public unsafe List<CampaignGenerator.Node.Connection> connections
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignGenerator.Node.NativeFieldInfoPtr_connections));
        return pointer == System.IntPtr.Zero ? (List<CampaignGenerator.Node.Connection>) null : new List<CampaignGenerator.Node.Connection>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CampaignGenerator.Node.NativeFieldInfoPtr_connections), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int connectionCount
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignGenerator.Node.NativeFieldInfoPtr_connectionCount));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignGenerator.Node.NativeFieldInfoPtr_connectionCount)) = value;
      }
    }

    public unsafe bool interactable
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignGenerator.Node.NativeFieldInfoPtr_interactable));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignGenerator.Node.NativeFieldInfoPtr_interactable)) = value;
      }
    }

    public class Connection : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_node;
      private static readonly System.IntPtr NativeFieldInfoPtr_color;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Node_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105544, XrefRangeEnd = 105546, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Connection(CampaignGenerator.Node node)
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CampaignGenerator.Node.Connection>.NativeClassPtr))
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) node)
        };
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CampaignGenerator.Node.Connection.NativeMethodInfoPtr__ctor_Public_Void_Node_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105546, XrefRangeEnd = 105549, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe string ToString()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CampaignGenerator.Node.Connection.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }

      static Connection()
      {
        Il2CppClassPointerStore<CampaignGenerator.Node.Connection>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CampaignGenerator.Node>.NativeClassPtr, nameof (Connection));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CampaignGenerator.Node.Connection>.NativeClassPtr);
        CampaignGenerator.Node.Connection.NativeFieldInfoPtr_node = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignGenerator.Node.Connection>.NativeClassPtr, nameof (node));
        CampaignGenerator.Node.Connection.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignGenerator.Node.Connection>.NativeClassPtr, nameof (color));
        CampaignGenerator.Node.Connection.NativeMethodInfoPtr__ctor_Public_Void_Node_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignGenerator.Node.Connection>.NativeClassPtr, 100672846);
        CampaignGenerator.Node.Connection.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignGenerator.Node.Connection>.NativeClassPtr, 100672847);
      }

      public Connection(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe CampaignGenerator.Node node
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignGenerator.Node.Connection.NativeFieldInfoPtr_node));
          return pointer == System.IntPtr.Zero ? (CampaignGenerator.Node) null : new CampaignGenerator.Node(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CampaignGenerator.Node.Connection.NativeFieldInfoPtr_node), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Color color
      {
        get
        {
          return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignGenerator.Node.Connection.NativeFieldInfoPtr_color));
        }
        [param: In] set
        {
          *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignGenerator.Node.Connection.NativeFieldInfoPtr_color)) = value;
        }
      }
    }
  }

  [ObfuscatedName("CampaignGenerator/<>c__DisplayClass10_0")]
  public sealed class __c__DisplayClass10_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_task;
    private static readonly System.IntPtr NativeFieldInfoPtr_error;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Generate_b__0_Internal_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Generate_b__1_Internal_Boolean_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass10_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CampaignGenerator.__c__DisplayClass10_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CampaignGenerator.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _Generate_b__0()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CampaignGenerator.__c__DisplayClass10_0.NativeMethodInfoPtr__Generate_b__0_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public unsafe bool _Generate_b__1()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CampaignGenerator.__c__DisplayClass10_0.NativeMethodInfoPtr__Generate_b__1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c__DisplayClass10_0()
    {
      Il2CppClassPointerStore<CampaignGenerator.__c__DisplayClass10_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CampaignGenerator>.NativeClassPtr, "<>c__DisplayClass10_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CampaignGenerator.__c__DisplayClass10_0>.NativeClassPtr);
      CampaignGenerator.__c__DisplayClass10_0.NativeFieldInfoPtr_task = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignGenerator.__c__DisplayClass10_0>.NativeClassPtr, nameof (task));
      CampaignGenerator.__c__DisplayClass10_0.NativeFieldInfoPtr_error = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignGenerator.__c__DisplayClass10_0>.NativeClassPtr, nameof (error));
      CampaignGenerator.__c__DisplayClass10_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignGenerator.__c__DisplayClass10_0>.NativeClassPtr, "<>4__this");
      CampaignGenerator.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignGenerator.__c__DisplayClass10_0>.NativeClassPtr, 100672848);
      CampaignGenerator.__c__DisplayClass10_0.NativeMethodInfoPtr__Generate_b__0_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignGenerator.__c__DisplayClass10_0>.NativeClassPtr, 100672849);
      CampaignGenerator.__c__DisplayClass10_0.NativeMethodInfoPtr__Generate_b__1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignGenerator.__c__DisplayClass10_0>.NativeClassPtr, 100672850);
    }

    public __c__DisplayClass10_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Task<bool> task
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignGenerator.__c__DisplayClass10_0.NativeFieldInfoPtr_task));
        return pointer == System.IntPtr.Zero ? (Task<bool>) null : new Task<bool>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CampaignGenerator.__c__DisplayClass10_0.NativeFieldInfoPtr_task), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool error
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignGenerator.__c__DisplayClass10_0.NativeFieldInfoPtr_error));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignGenerator.__c__DisplayClass10_0.NativeFieldInfoPtr_error)) = value;
      }
    }

    public unsafe CampaignGenerator __4__this
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignGenerator.__c__DisplayClass10_0.NativeFieldInfoPtr___4__this));
        return pointer == System.IntPtr.Zero ? (CampaignGenerator) null : new CampaignGenerator(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CampaignGenerator.__c__DisplayClass10_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("CampaignGenerator/<>c")]
  [Serializable]
  public sealed class __c : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__10_2;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Generate_b__10_2_Internal_Boolean_Node_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CampaignGenerator.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CampaignGenerator.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe bool _Generate_b__10_2(CampaignGenerator.Node a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CampaignGenerator.__c.NativeMethodInfoPtr__Generate_b__10_2_Internal_Boolean_Node_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c()
    {
      Il2CppClassPointerStore<CampaignGenerator.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CampaignGenerator>.NativeClassPtr, "<>c");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CampaignGenerator.__c>.NativeClassPtr);
      CampaignGenerator.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignGenerator.__c>.NativeClassPtr, "<>9");
      CampaignGenerator.__c.NativeFieldInfoPtr___9__10_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignGenerator.__c>.NativeClassPtr, "<>9__10_2");
      CampaignGenerator.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignGenerator.__c>.NativeClassPtr, 100672852);
      CampaignGenerator.__c.NativeMethodInfoPtr__Generate_b__10_2_Internal_Boolean_Node_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignGenerator.__c>.NativeClassPtr, 100672853);
    }

    public __c(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe CampaignGenerator.__c __9
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(CampaignGenerator.__c.NativeFieldInfoPtr___9, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (CampaignGenerator.__c) null : new CampaignGenerator.__c(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CampaignGenerator.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<CampaignGenerator.Node, bool> __9__10_2
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(CampaignGenerator.__c.NativeFieldInfoPtr___9__10_2, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<CampaignGenerator.Node, bool>) null : new Il2CppSystem.Func<CampaignGenerator.Node, bool>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CampaignGenerator.__c.NativeFieldInfoPtr___9__10_2, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("CampaignGenerator/<Generate>d__10")]
  public sealed class _Generate_d__10 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr_campaign;
    private static readonly System.IntPtr NativeFieldInfoPtr___8__1;
    private static readonly System.IntPtr NativeFieldInfoPtr__nodeDict_5__2;
    private static readonly System.IntPtr NativeFieldInfoPtr__nodes_5__3;
    private static readonly System.IntPtr NativeFieldInfoPtr__attempt_5__4;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    [CallerCount(53)]
    [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _Generate_d__10(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CampaignGenerator._Generate_d__10>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CampaignGenerator._Generate_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(12611)]
    [CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12665, XrefRangeStart = 54, XrefRangeEnd = 12665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CampaignGenerator._Generate_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105577, XrefRangeEnd = 105743, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CampaignGenerator._Generate_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CampaignGenerator._Generate_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105743, XrefRangeEnd = 105749, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CampaignGenerator._Generate_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12671, XrefRangeEnd = 12683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CampaignGenerator._Generate_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    static _Generate_d__10()
    {
      Il2CppClassPointerStore<CampaignGenerator._Generate_d__10>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CampaignGenerator>.NativeClassPtr, "<Generate>d__10");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CampaignGenerator._Generate_d__10>.NativeClassPtr);
      CampaignGenerator._Generate_d__10.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignGenerator._Generate_d__10>.NativeClassPtr, "<>1__state");
      CampaignGenerator._Generate_d__10.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignGenerator._Generate_d__10>.NativeClassPtr, "<>2__current");
      CampaignGenerator._Generate_d__10.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignGenerator._Generate_d__10>.NativeClassPtr, "<>4__this");
      CampaignGenerator._Generate_d__10.NativeFieldInfoPtr_campaign = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignGenerator._Generate_d__10>.NativeClassPtr, nameof (campaign));
      CampaignGenerator._Generate_d__10.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignGenerator._Generate_d__10>.NativeClassPtr, "<>8__1");
      CampaignGenerator._Generate_d__10.NativeFieldInfoPtr__nodeDict_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignGenerator._Generate_d__10>.NativeClassPtr, "<nodeDict>5__2");
      CampaignGenerator._Generate_d__10.NativeFieldInfoPtr__nodes_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignGenerator._Generate_d__10>.NativeClassPtr, "<nodes>5__3");
      CampaignGenerator._Generate_d__10.NativeFieldInfoPtr__attempt_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignGenerator._Generate_d__10>.NativeClassPtr, "<attempt>5__4");
      CampaignGenerator._Generate_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignGenerator._Generate_d__10>.NativeClassPtr, 100672854);
      CampaignGenerator._Generate_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignGenerator._Generate_d__10>.NativeClassPtr, 100672855);
      CampaignGenerator._Generate_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignGenerator._Generate_d__10>.NativeClassPtr, 100672856);
      CampaignGenerator._Generate_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignGenerator._Generate_d__10>.NativeClassPtr, 100672857);
      CampaignGenerator._Generate_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignGenerator._Generate_d__10>.NativeClassPtr, 100672858);
      CampaignGenerator._Generate_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignGenerator._Generate_d__10>.NativeClassPtr, 100672859);
    }

    public _Generate_d__10(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignGenerator._Generate_d__10.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignGenerator._Generate_d__10.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignGenerator._Generate_d__10.NativeFieldInfoPtr___2__current));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CampaignGenerator._Generate_d__10.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CampaignGenerator __4__this
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignGenerator._Generate_d__10.NativeFieldInfoPtr___4__this));
        return pointer == System.IntPtr.Zero ? (CampaignGenerator) null : new CampaignGenerator(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CampaignGenerator._Generate_d__10.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Campaign campaign
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignGenerator._Generate_d__10.NativeFieldInfoPtr_campaign));
        return pointer == System.IntPtr.Zero ? (Campaign) null : new Campaign(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CampaignGenerator._Generate_d__10.NativeFieldInfoPtr_campaign), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CampaignGenerator.__c__DisplayClass10_0 __8__1
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignGenerator._Generate_d__10.NativeFieldInfoPtr___8__1));
        return pointer == System.IntPtr.Zero ? (CampaignGenerator.__c__DisplayClass10_0) null : new CampaignGenerator.__c__DisplayClass10_0(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CampaignGenerator._Generate_d__10.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Dictionary<string, CampaignNodeType> _nodeDict_5__2
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignGenerator._Generate_d__10.NativeFieldInfoPtr__nodeDict_5__2));
        return pointer == System.IntPtr.Zero ? (Dictionary<string, CampaignNodeType>) null : new Dictionary<string, CampaignNodeType>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CampaignGenerator._Generate_d__10.NativeFieldInfoPtr__nodeDict_5__2), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<CampaignGenerator.Node> _nodes_5__3
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignGenerator._Generate_d__10.NativeFieldInfoPtr__nodes_5__3));
        return pointer == System.IntPtr.Zero ? (List<CampaignGenerator.Node>) null : new List<CampaignGenerator.Node>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CampaignGenerator._Generate_d__10.NativeFieldInfoPtr__nodes_5__3), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int _attempt_5__4
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignGenerator._Generate_d__10.NativeFieldInfoPtr__attempt_5__4));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignGenerator._Generate_d__10.NativeFieldInfoPtr__attempt_5__4)) = value;
      }
    }
  }

  [ObfuscatedName("CampaignGenerator/<>c__DisplayClass11_0")]
  public sealed class __c__DisplayClass11_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_nodes;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__TryGenerate_b__0_Internal_Void_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass11_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CampaignGenerator.__c__DisplayClass11_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CampaignGenerator.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105749, XrefRangeEnd = 105750, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _TryGenerate_b__0()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CampaignGenerator.__c__DisplayClass11_0.NativeMethodInfoPtr__TryGenerate_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static __c__DisplayClass11_0()
    {
      Il2CppClassPointerStore<CampaignGenerator.__c__DisplayClass11_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CampaignGenerator>.NativeClassPtr, "<>c__DisplayClass11_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CampaignGenerator.__c__DisplayClass11_0>.NativeClassPtr);
      CampaignGenerator.__c__DisplayClass11_0.NativeFieldInfoPtr_nodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignGenerator.__c__DisplayClass11_0>.NativeClassPtr, nameof (nodes));
      CampaignGenerator.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignGenerator.__c__DisplayClass11_0>.NativeClassPtr, 100672860);
      CampaignGenerator.__c__DisplayClass11_0.NativeMethodInfoPtr__TryGenerate_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignGenerator.__c__DisplayClass11_0>.NativeClassPtr, 100672861);
    }

    public __c__DisplayClass11_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe List<CampaignGenerator.Node> nodes
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignGenerator.__c__DisplayClass11_0.NativeFieldInfoPtr_nodes));
        return pointer == System.IntPtr.Zero ? (List<CampaignGenerator.Node>) null : new List<CampaignGenerator.Node>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CampaignGenerator.__c__DisplayClass11_0.NativeFieldInfoPtr_nodes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("CampaignGenerator/<TryGenerate>d__11")]
  public sealed class _TryGenerate_d__11 : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;
    private static readonly System.IntPtr NativeFieldInfoPtr_nodes;
    private static readonly System.IntPtr NativeFieldInfoPtr_attempt;
    private static readonly System.IntPtr NativeFieldInfoPtr_campaign;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr_nodeDict;
    private static readonly System.IntPtr NativeFieldInfoPtr___8__1;
    private static readonly System.IntPtr NativeFieldInfoPtr___u__1;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105750, XrefRangeEnd = 105934, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CampaignGenerator._TryGenerate_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105934, XrefRangeEnd = 105937, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stateMachine)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CampaignGenerator._TryGenerate_d__11.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static _TryGenerate_d__11()
    {
      Il2CppClassPointerStore<CampaignGenerator._TryGenerate_d__11>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CampaignGenerator>.NativeClassPtr, "<TryGenerate>d__11");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CampaignGenerator._TryGenerate_d__11>.NativeClassPtr);
      CampaignGenerator._TryGenerate_d__11.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignGenerator._TryGenerate_d__11>.NativeClassPtr, "<>1__state");
      CampaignGenerator._TryGenerate_d__11.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignGenerator._TryGenerate_d__11>.NativeClassPtr, "<>t__builder");
      CampaignGenerator._TryGenerate_d__11.NativeFieldInfoPtr_nodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignGenerator._TryGenerate_d__11>.NativeClassPtr, nameof (nodes));
      CampaignGenerator._TryGenerate_d__11.NativeFieldInfoPtr_attempt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignGenerator._TryGenerate_d__11>.NativeClassPtr, nameof (attempt));
      CampaignGenerator._TryGenerate_d__11.NativeFieldInfoPtr_campaign = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignGenerator._TryGenerate_d__11>.NativeClassPtr, nameof (campaign));
      CampaignGenerator._TryGenerate_d__11.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignGenerator._TryGenerate_d__11>.NativeClassPtr, "<>4__this");
      CampaignGenerator._TryGenerate_d__11.NativeFieldInfoPtr_nodeDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignGenerator._TryGenerate_d__11>.NativeClassPtr, nameof (nodeDict));
      CampaignGenerator._TryGenerate_d__11.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignGenerator._TryGenerate_d__11>.NativeClassPtr, "<>8__1");
      CampaignGenerator._TryGenerate_d__11.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignGenerator._TryGenerate_d__11>.NativeClassPtr, "<>u__1");
      CampaignGenerator._TryGenerate_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignGenerator._TryGenerate_d__11>.NativeClassPtr, 100672862);
      CampaignGenerator._TryGenerate_d__11.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignGenerator._TryGenerate_d__11>.NativeClassPtr, 100672863);
    }

    public _TryGenerate_d__11(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public _TryGenerate_d__11()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CampaignGenerator._TryGenerate_d__11>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CampaignGenerator._TryGenerate_d__11>.NativeClassPtr, data));
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignGenerator._TryGenerate_d__11.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignGenerator._TryGenerate_d__11.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public AsyncTaskMethodBuilder<bool> __t__builder
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignGenerator._TryGenerate_d__11.NativeFieldInfoPtr___t__builder);
        return new AsyncTaskMethodBuilder<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<bool>>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignGenerator._TryGenerate_d__11.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<bool>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe List<CampaignGenerator.Node> nodes
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignGenerator._TryGenerate_d__11.NativeFieldInfoPtr_nodes));
        return pointer == System.IntPtr.Zero ? (List<CampaignGenerator.Node>) null : new List<CampaignGenerator.Node>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CampaignGenerator._TryGenerate_d__11.NativeFieldInfoPtr_nodes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int attempt
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignGenerator._TryGenerate_d__11.NativeFieldInfoPtr_attempt));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignGenerator._TryGenerate_d__11.NativeFieldInfoPtr_attempt)) = value;
      }
    }

    public unsafe Campaign campaign
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignGenerator._TryGenerate_d__11.NativeFieldInfoPtr_campaign));
        return pointer == System.IntPtr.Zero ? (Campaign) null : new Campaign(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CampaignGenerator._TryGenerate_d__11.NativeFieldInfoPtr_campaign), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CampaignGenerator __4__this
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignGenerator._TryGenerate_d__11.NativeFieldInfoPtr___4__this));
        return pointer == System.IntPtr.Zero ? (CampaignGenerator) null : new CampaignGenerator(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CampaignGenerator._TryGenerate_d__11.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe IReadOnlyDictionary<string, CampaignNodeType> nodeDict
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignGenerator._TryGenerate_d__11.NativeFieldInfoPtr_nodeDict));
        return pointer == System.IntPtr.Zero ? (IReadOnlyDictionary<string, CampaignNodeType>) null : new IReadOnlyDictionary<string, CampaignNodeType>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CampaignGenerator._TryGenerate_d__11.NativeFieldInfoPtr_nodeDict), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CampaignGenerator.__c__DisplayClass11_0 __8__1
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignGenerator._TryGenerate_d__11.NativeFieldInfoPtr___8__1));
        return pointer == System.IntPtr.Zero ? (CampaignGenerator.__c__DisplayClass11_0) null : new CampaignGenerator.__c__DisplayClass11_0(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CampaignGenerator._TryGenerate_d__11.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public TaskAwaiter __u__1
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignGenerator._TryGenerate_d__11.NativeFieldInfoPtr___u__1);
        return new TaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignGenerator._TryGenerate_d__11.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }

  [ObfuscatedName("CampaignGenerator/<>c__DisplayClass18_0")]
  public sealed class __c__DisplayClass18_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_c;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ShuffleNodes_b__0_Internal_Boolean_CampaignNode_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass18_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CampaignGenerator.__c__DisplayClass18_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CampaignGenerator.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe bool _ShuffleNodes_b__0(CampaignNode a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CampaignGenerator.__c__DisplayClass18_0.NativeMethodInfoPtr__ShuffleNodes_b__0_Internal_Boolean_CampaignNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c__DisplayClass18_0()
    {
      Il2CppClassPointerStore<CampaignGenerator.__c__DisplayClass18_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CampaignGenerator>.NativeClassPtr, "<>c__DisplayClass18_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CampaignGenerator.__c__DisplayClass18_0>.NativeClassPtr);
      CampaignGenerator.__c__DisplayClass18_0.NativeFieldInfoPtr_c = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CampaignGenerator.__c__DisplayClass18_0>.NativeClassPtr, nameof (c));
      CampaignGenerator.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignGenerator.__c__DisplayClass18_0>.NativeClassPtr, 100672864);
      CampaignGenerator.__c__DisplayClass18_0.NativeMethodInfoPtr__ShuffleNodes_b__0_Internal_Boolean_CampaignNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CampaignGenerator.__c__DisplayClass18_0>.NativeClassPtr, 100672865);
    }

    public __c__DisplayClass18_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe CampaignNode.Connection c
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CampaignGenerator.__c__DisplayClass18_0.NativeFieldInfoPtr_c));
        return pointer == System.IntPtr.Zero ? (CampaignNode.Connection) null : new CampaignNode.Connection(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CampaignGenerator.__c__DisplayClass18_0.NativeFieldInfoPtr_c), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
