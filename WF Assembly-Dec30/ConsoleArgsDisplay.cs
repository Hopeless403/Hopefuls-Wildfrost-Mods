// Decompiled with JetBrains decompiler
// Type: ConsoleArgsDisplay
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;

#nullable disable
public class ConsoleArgsDisplay : MonoBehaviourRect
{
  private static readonly System.IntPtr NativeFieldInfoPtr_textPrefab;
  private static readonly System.IntPtr NativeFieldInfoPtr_poolStartSize;
  private static readonly System.IntPtr NativeFieldInfoPtr_maxItems;
  private static readonly System.IntPtr NativeFieldInfoPtr_pool;
  private static readonly System.IntPtr NativeFieldInfoPtr_outOfPool;
  private static readonly System.IntPtr NativeFieldInfoPtr_commands;
  private static readonly System.IntPtr NativeFieldInfoPtr_current;
  private static readonly System.IntPtr NativeFieldInfoPtr_targetPos;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_TopArgument_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_TopCommand_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Show_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Hide_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MoveTo_Public_Void_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DisplayCommands_Public_Void_Il2CppReferenceArray_1_Command_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DisplayArgs_Public_Void_Il2CppStringArray_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Create_Private_Void_Il2CppStringArray_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Create_Private_Boolean_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Pool_Private_Void_TMP_Text_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  public unsafe int Count
  {
    [CallerCount(5), CachedScanResults(RefRangeStart = 42359, RefRangeEnd = 42364, XrefRangeStart = 42359, XrefRangeEnd = 42359, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConsoleArgsDisplay.NativeMethodInfoPtr_get_Count_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  public unsafe string TopArgument
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 42367, RefRangeEnd = 42368, XrefRangeStart = 42364, XrefRangeEnd = 42367, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(ConsoleArgsDisplay.NativeMethodInfoPtr_get_TopArgument_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }
  }

  public unsafe string TopCommand
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 42382, RefRangeEnd = 42383, XrefRangeStart = 42368, XrefRangeEnd = 42382, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(ConsoleArgsDisplay.NativeMethodInfoPtr_get_TopCommand_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42383, XrefRangeEnd = 42395, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ConsoleArgsDisplay.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42395, XrefRangeEnd = 42405, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ConsoleArgsDisplay.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42405, XrefRangeEnd = 42408, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Show()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ConsoleArgsDisplay.NativeMethodInfoPtr_Show_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 42411, RefRangeEnd = 42412, XrefRangeStart = 42408, XrefRangeEnd = 42411, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Hide()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ConsoleArgsDisplay.NativeMethodInfoPtr_Hide_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 42413, RefRangeEnd = 42414, XrefRangeStart = 42412, XrefRangeEnd = 42413, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void MoveTo(float x)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &x
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ConsoleArgsDisplay.NativeMethodInfoPtr_MoveTo_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42414, XrefRangeEnd = 42442, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void DisplayCommands(Il2CppReferenceArray<Console.Command> commands)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) commands)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ConsoleArgsDisplay.NativeMethodInfoPtr_DisplayCommands_Public_Void_Il2CppReferenceArray_1_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 42448, RefRangeEnd = 42449, XrefRangeStart = 42442, XrefRangeEnd = 42448, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void DisplayArgs(Il2CppStringArray items)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) items)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ConsoleArgsDisplay.NativeMethodInfoPtr_DisplayArgs_Public_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 42470, RefRangeEnd = 42473, XrefRangeStart = 42449, XrefRangeEnd = 42470, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Clear()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ConsoleArgsDisplay.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42473, XrefRangeEnd = 42475, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Create(Il2CppStringArray items)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) items)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ConsoleArgsDisplay.NativeMethodInfoPtr_Create_Private_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 42499, RefRangeEnd = 42502, XrefRangeStart = 42475, XrefRangeEnd = 42499, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool Create(string item)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(item)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConsoleArgsDisplay.NativeMethodInfoPtr_Create_Private_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42502, XrefRangeEnd = 42508, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Pool(TMP_Text inst)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) inst)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ConsoleArgsDisplay.NativeMethodInfoPtr_Pool_Private_Void_TMP_Text_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42508, XrefRangeEnd = 42524, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ConsoleArgsDisplay()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConsoleArgsDisplay>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ConsoleArgsDisplay.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static ConsoleArgsDisplay()
  {
    Il2CppClassPointerStore<ConsoleArgsDisplay>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (ConsoleArgsDisplay));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConsoleArgsDisplay>.NativeClassPtr);
    ConsoleArgsDisplay.NativeFieldInfoPtr_textPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsoleArgsDisplay>.NativeClassPtr, nameof (textPrefab));
    ConsoleArgsDisplay.NativeFieldInfoPtr_poolStartSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsoleArgsDisplay>.NativeClassPtr, nameof (poolStartSize));
    ConsoleArgsDisplay.NativeFieldInfoPtr_maxItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsoleArgsDisplay>.NativeClassPtr, nameof (maxItems));
    ConsoleArgsDisplay.NativeFieldInfoPtr_pool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsoleArgsDisplay>.NativeClassPtr, nameof (pool));
    ConsoleArgsDisplay.NativeFieldInfoPtr_outOfPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsoleArgsDisplay>.NativeClassPtr, nameof (outOfPool));
    ConsoleArgsDisplay.NativeFieldInfoPtr_commands = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsoleArgsDisplay>.NativeClassPtr, nameof (commands));
    ConsoleArgsDisplay.NativeFieldInfoPtr_current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsoleArgsDisplay>.NativeClassPtr, nameof (current));
    ConsoleArgsDisplay.NativeFieldInfoPtr_targetPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsoleArgsDisplay>.NativeClassPtr, nameof (targetPos));
    ConsoleArgsDisplay.NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleArgsDisplay>.NativeClassPtr, 100666430);
    ConsoleArgsDisplay.NativeMethodInfoPtr_get_TopArgument_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleArgsDisplay>.NativeClassPtr, 100666431);
    ConsoleArgsDisplay.NativeMethodInfoPtr_get_TopCommand_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleArgsDisplay>.NativeClassPtr, 100666432);
    ConsoleArgsDisplay.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleArgsDisplay>.NativeClassPtr, 100666433);
    ConsoleArgsDisplay.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleArgsDisplay>.NativeClassPtr, 100666434);
    ConsoleArgsDisplay.NativeMethodInfoPtr_Show_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleArgsDisplay>.NativeClassPtr, 100666435);
    ConsoleArgsDisplay.NativeMethodInfoPtr_Hide_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleArgsDisplay>.NativeClassPtr, 100666436);
    ConsoleArgsDisplay.NativeMethodInfoPtr_MoveTo_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleArgsDisplay>.NativeClassPtr, 100666437);
    ConsoleArgsDisplay.NativeMethodInfoPtr_DisplayCommands_Public_Void_Il2CppReferenceArray_1_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleArgsDisplay>.NativeClassPtr, 100666438);
    ConsoleArgsDisplay.NativeMethodInfoPtr_DisplayArgs_Public_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleArgsDisplay>.NativeClassPtr, 100666439);
    ConsoleArgsDisplay.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleArgsDisplay>.NativeClassPtr, 100666440);
    ConsoleArgsDisplay.NativeMethodInfoPtr_Create_Private_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleArgsDisplay>.NativeClassPtr, 100666441);
    ConsoleArgsDisplay.NativeMethodInfoPtr_Create_Private_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleArgsDisplay>.NativeClassPtr, 100666442);
    ConsoleArgsDisplay.NativeMethodInfoPtr_Pool_Private_Void_TMP_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleArgsDisplay>.NativeClassPtr, 100666443);
    ConsoleArgsDisplay.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleArgsDisplay>.NativeClassPtr, 100666444);
  }

  public ConsoleArgsDisplay(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe TMP_Text textPrefab
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConsoleArgsDisplay.NativeFieldInfoPtr_textPrefab));
      return pointer == System.IntPtr.Zero ? (TMP_Text) null : new TMP_Text(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ConsoleArgsDisplay.NativeFieldInfoPtr_textPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int poolStartSize
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConsoleArgsDisplay.NativeFieldInfoPtr_poolStartSize));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConsoleArgsDisplay.NativeFieldInfoPtr_poolStartSize)) = value;
    }
  }

  public unsafe int maxItems
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConsoleArgsDisplay.NativeFieldInfoPtr_maxItems));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConsoleArgsDisplay.NativeFieldInfoPtr_maxItems)) = value;
    }
  }

  public unsafe Queue<TMP_Text> pool
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConsoleArgsDisplay.NativeFieldInfoPtr_pool));
      return pointer == System.IntPtr.Zero ? (Queue<TMP_Text>) null : new Queue<TMP_Text>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ConsoleArgsDisplay.NativeFieldInfoPtr_pool), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<TMP_Text> outOfPool
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConsoleArgsDisplay.NativeFieldInfoPtr_outOfPool));
      return pointer == System.IntPtr.Zero ? (List<TMP_Text>) null : new List<TMP_Text>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ConsoleArgsDisplay.NativeFieldInfoPtr_outOfPool), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<Console.Command> commands
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConsoleArgsDisplay.NativeFieldInfoPtr_commands));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<Console.Command>) null : new Il2CppReferenceArray<Console.Command>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ConsoleArgsDisplay.NativeFieldInfoPtr_commands), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppStringArray current
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConsoleArgsDisplay.NativeFieldInfoPtr_current));
      return pointer == System.IntPtr.Zero ? (Il2CppStringArray) null : new Il2CppStringArray(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ConsoleArgsDisplay.NativeFieldInfoPtr_current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector2 targetPos
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConsoleArgsDisplay.NativeFieldInfoPtr_targetPos));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConsoleArgsDisplay.NativeFieldInfoPtr_targetPos)) = value;
    }
  }

  [ObfuscatedName("ConsoleArgsDisplay/<>c")]
  [Serializable]
  public sealed class __c : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__19_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__DisplayCommands_b__19_0_Internal_String_Command_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConsoleArgsDisplay.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ConsoleArgsDisplay.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42358, XrefRangeEnd = 42359, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string _DisplayCommands_b__19_0(Console.Command a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(ConsoleArgsDisplay.__c.NativeMethodInfoPtr__DisplayCommands_b__19_0_Internal_String_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    static __c()
    {
      Il2CppClassPointerStore<ConsoleArgsDisplay.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConsoleArgsDisplay>.NativeClassPtr, "<>c");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConsoleArgsDisplay.__c>.NativeClassPtr);
      ConsoleArgsDisplay.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsoleArgsDisplay.__c>.NativeClassPtr, "<>9");
      ConsoleArgsDisplay.__c.NativeFieldInfoPtr___9__19_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsoleArgsDisplay.__c>.NativeClassPtr, "<>9__19_0");
      ConsoleArgsDisplay.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleArgsDisplay.__c>.NativeClassPtr, 100666446);
      ConsoleArgsDisplay.__c.NativeMethodInfoPtr__DisplayCommands_b__19_0_Internal_String_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleArgsDisplay.__c>.NativeClassPtr, 100666447);
    }

    public __c(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe ConsoleArgsDisplay.__c __9
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(ConsoleArgsDisplay.__c.NativeFieldInfoPtr___9, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (ConsoleArgsDisplay.__c) null : new ConsoleArgsDisplay.__c(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ConsoleArgsDisplay.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<Console.Command, string> __9__19_0
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(ConsoleArgsDisplay.__c.NativeFieldInfoPtr___9__19_0, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<Console.Command, string>) null : new Il2CppSystem.Func<Console.Command, string>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ConsoleArgsDisplay.__c.NativeFieldInfoPtr___9__19_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
