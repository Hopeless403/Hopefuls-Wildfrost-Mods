// Decompiled with JetBrains decompiler
// Type: InputSwitcher
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class InputSwitcher : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_justSwitchedCount;
  private static readonly IntPtr NativeFieldInfoPtr_maxJustSwitchedCount;
  private static readonly IntPtr NativeFieldInfoPtr_justSwitched;
  private static readonly IntPtr NativeFieldInfoPtr_currentIndex;
  private static readonly IntPtr NativeFieldInfoPtr_startingInput;
  private static readonly IntPtr NativeFieldInfoPtr_switchers;
  private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_SwitchTo_Private_Void_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15453, XrefRangeEnd = 15456, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(InputSwitcher.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15456, XrefRangeEnd = 15460, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(InputSwitcher.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15460, XrefRangeEnd = 15469, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(InputSwitcher.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15469, XrefRangeEnd = 15476, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SwitchTo(int profileIndex)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &profileIndex
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(InputSwitcher.NativeMethodInfoPtr_SwitchTo_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15476, XrefRangeEnd = 15477, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe InputSwitcher()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputSwitcher>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(InputSwitcher.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static InputSwitcher()
  {
    Il2CppClassPointerStore<InputSwitcher>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (InputSwitcher));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputSwitcher>.NativeClassPtr);
    InputSwitcher.NativeFieldInfoPtr_justSwitchedCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputSwitcher>.NativeClassPtr, nameof (justSwitchedCount));
    InputSwitcher.NativeFieldInfoPtr_maxJustSwitchedCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputSwitcher>.NativeClassPtr, nameof (maxJustSwitchedCount));
    InputSwitcher.NativeFieldInfoPtr_justSwitched = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputSwitcher>.NativeClassPtr, nameof (justSwitched));
    InputSwitcher.NativeFieldInfoPtr_currentIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputSwitcher>.NativeClassPtr, nameof (currentIndex));
    InputSwitcher.NativeFieldInfoPtr_startingInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputSwitcher>.NativeClassPtr, nameof (startingInput));
    InputSwitcher.NativeFieldInfoPtr_switchers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputSwitcher>.NativeClassPtr, nameof (switchers));
    InputSwitcher.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSwitcher>.NativeClassPtr, 100663341);
    InputSwitcher.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSwitcher>.NativeClassPtr, 100663342);
    InputSwitcher.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSwitcher>.NativeClassPtr, 100663343);
    InputSwitcher.NativeMethodInfoPtr_SwitchTo_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSwitcher>.NativeClassPtr, 100663344);
    InputSwitcher.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSwitcher>.NativeClassPtr, 100663345);
  }

  public InputSwitcher(IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe int justSwitchedCount
  {
    get
    {
      int justSwitchedCount;
      IL2CPP.il2cpp_field_static_get_value(InputSwitcher.NativeFieldInfoPtr_justSwitchedCount, (void*) &justSwitchedCount);
      return justSwitchedCount;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(InputSwitcher.NativeFieldInfoPtr_justSwitchedCount, (void*) &value);
    }
  }

  public static unsafe int maxJustSwitchedCount
  {
    get
    {
      int justSwitchedCount;
      IL2CPP.il2cpp_field_static_get_value(InputSwitcher.NativeFieldInfoPtr_maxJustSwitchedCount, (void*) &justSwitchedCount);
      return justSwitchedCount;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(InputSwitcher.NativeFieldInfoPtr_maxJustSwitchedCount, (void*) &value);
    }
  }

  public static unsafe bool justSwitched
  {
    get
    {
      bool justSwitched;
      IL2CPP.il2cpp_field_static_get_value(InputSwitcher.NativeFieldInfoPtr_justSwitched, (void*) &justSwitched);
      return justSwitched;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(InputSwitcher.NativeFieldInfoPtr_justSwitched, (void*) &value);
    }
  }

  public unsafe int currentIndex
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputSwitcher.NativeFieldInfoPtr_currentIndex));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputSwitcher.NativeFieldInfoPtr_currentIndex)) = value;
    }
  }

  public unsafe BaseInputSwitcher startingInput
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputSwitcher.NativeFieldInfoPtr_startingInput));
      return pointer == IntPtr.Zero ? (BaseInputSwitcher) null : new BaseInputSwitcher(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InputSwitcher.NativeFieldInfoPtr_startingInput), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<BaseInputSwitcher> switchers
  {
    get
    {
      IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputSwitcher.NativeFieldInfoPtr_switchers));
      return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<BaseInputSwitcher>) null : new Il2CppReferenceArray<BaseInputSwitcher>(nativeObject);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InputSwitcher.NativeFieldInfoPtr_switchers), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
