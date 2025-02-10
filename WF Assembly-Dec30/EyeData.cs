// Decompiled with JetBrains decompiler
// Type: EyeData
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
public class EyeData : ScriptableObject
{
  private static readonly System.IntPtr NativeFieldInfoPtr_cardData;
  private static readonly System.IntPtr NativeFieldInfoPtr_eyes;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_Il2CppReferenceArray_1_EyePositionSaver_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109069, XrefRangeEnd = 109078, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(
    [Optional] Il2CppReferenceArray<EyePositionSaver> eyePositions)
  {
    if (eyePositions == null)
      eyePositions = new Il2CppReferenceArray<EyePositionSaver>(0L);
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eyePositions)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(EyeData.NativeMethodInfoPtr_Set_Public_Void_Il2CppReferenceArray_1_EyePositionSaver_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(110)]
  [CachedScanResults(RefRangeStart = 104608, RefRangeEnd = 104718, XrefRangeStart = 104608, XrefRangeEnd = 104718, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe EyeData()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EyeData>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(EyeData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  public void Set(params EyePositionSaver[] eyePositions)
  {
    this.Set(new Il2CppReferenceArray<EyePositionSaver>(eyePositions));
  }

  static EyeData()
  {
    Il2CppClassPointerStore<EyeData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (EyeData));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EyeData>.NativeClassPtr);
    EyeData.NativeFieldInfoPtr_cardData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeData>.NativeClassPtr, nameof (cardData));
    EyeData.NativeFieldInfoPtr_eyes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeData>.NativeClassPtr, nameof (eyes));
    EyeData.NativeMethodInfoPtr_Set_Public_Void_Il2CppReferenceArray_1_EyePositionSaver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeData>.NativeClassPtr, 100673365);
    EyeData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeData>.NativeClassPtr, 100673366);
  }

  public EyeData(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe string cardData
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EyeData.NativeFieldInfoPtr_cardData)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EyeData.NativeFieldInfoPtr_cardData), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe Il2CppStructArray<EyeData.Eye> eyes
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EyeData.NativeFieldInfoPtr_eyes));
      return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<EyeData.Eye>) null : new Il2CppStructArray<EyeData.Eye>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EyeData.NativeFieldInfoPtr_eyes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [Serializable]
  [StructLayout(LayoutKind.Explicit)]
  public struct Eye
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_position;
    private static readonly System.IntPtr NativeFieldInfoPtr_scale;
    private static readonly System.IntPtr NativeFieldInfoPtr_rotation;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Transform_0;
    [FieldOffset(0)]
    public Vector2 position;
    [FieldOffset(8)]
    public Vector2 scale;
    [FieldOffset(16)]
    public float rotation;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109066, XrefRangeEnd = 109069, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Eye(Transform transform)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transform)
      };
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EyeData.Eye.NativeMethodInfoPtr__ctor_Public_Void_Transform_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Eye()
    {
      Il2CppClassPointerStore<EyeData.Eye>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EyeData>.NativeClassPtr, nameof (Eye));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EyeData.Eye>.NativeClassPtr);
      EyeData.Eye.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeData.Eye>.NativeClassPtr, nameof (position));
      EyeData.Eye.NativeFieldInfoPtr_scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeData.Eye>.NativeClassPtr, nameof (scale));
      EyeData.Eye.NativeFieldInfoPtr_rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeData.Eye>.NativeClassPtr, nameof (rotation));
      EyeData.Eye.NativeMethodInfoPtr__ctor_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeData.Eye>.NativeClassPtr, 100673367);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EyeData.Eye>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
