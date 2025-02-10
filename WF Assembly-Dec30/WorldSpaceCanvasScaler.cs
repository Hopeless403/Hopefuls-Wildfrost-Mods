// Decompiled with JetBrains decompiler
// Type: WorldSpaceCanvasScaler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
public class WorldSpaceCanvasScaler : WorldSpaceCanvasUpdater
{
  private static readonly IntPtr NativeFieldInfoPtr_invert;
  private static readonly IntPtr NativeFieldInfoPtr_scalePositionX;
  private static readonly IntPtr NativeFieldInfoPtr_basePositionX;
  private static readonly IntPtr NativeFieldInfoPtr_scalePositionY;
  private static readonly IntPtr NativeFieldInfoPtr_basePositionY;
  private static readonly IntPtr NativeFieldInfoPtr_scalePositionZ;
  private static readonly IntPtr NativeFieldInfoPtr_basePositionZ;
  private static readonly IntPtr NativeFieldInfoPtr_scaleX;
  private static readonly IntPtr NativeFieldInfoPtr_baseScaleX;
  private static readonly IntPtr NativeFieldInfoPtr_scaleY;
  private static readonly IntPtr NativeFieldInfoPtr_baseScaleY;
  private static readonly IntPtr NativeFieldInfoPtr_scaleZ;
  private static readonly IntPtr NativeFieldInfoPtr_baseScaleZ;
  private static readonly IntPtr NativeMethodInfoPtr_UpdateSize_Public_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetPosition_Private_Void_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetScale_Private_Void_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100593, XrefRangeEnd = 100614, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void UpdateSize()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), WorldSpaceCanvasScaler.NativeMethodInfoPtr_UpdateSize_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100614, XrefRangeEnd = 100621, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetPosition(float scale)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &scale
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(WorldSpaceCanvasScaler.NativeMethodInfoPtr_SetPosition_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100621, XrefRangeEnd = 100628, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetScale(float scale)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &scale
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(WorldSpaceCanvasScaler.NativeMethodInfoPtr_SetScale_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100628, XrefRangeEnd = 100629, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe WorldSpaceCanvasScaler()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorldSpaceCanvasScaler>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(WorldSpaceCanvasScaler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static WorldSpaceCanvasScaler()
  {
    Il2CppClassPointerStore<WorldSpaceCanvasScaler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (WorldSpaceCanvasScaler));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldSpaceCanvasScaler>.NativeClassPtr);
    WorldSpaceCanvasScaler.NativeFieldInfoPtr_invert = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldSpaceCanvasScaler>.NativeClassPtr, nameof (invert));
    WorldSpaceCanvasScaler.NativeFieldInfoPtr_scalePositionX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldSpaceCanvasScaler>.NativeClassPtr, nameof (scalePositionX));
    WorldSpaceCanvasScaler.NativeFieldInfoPtr_basePositionX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldSpaceCanvasScaler>.NativeClassPtr, nameof (basePositionX));
    WorldSpaceCanvasScaler.NativeFieldInfoPtr_scalePositionY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldSpaceCanvasScaler>.NativeClassPtr, nameof (scalePositionY));
    WorldSpaceCanvasScaler.NativeFieldInfoPtr_basePositionY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldSpaceCanvasScaler>.NativeClassPtr, nameof (basePositionY));
    WorldSpaceCanvasScaler.NativeFieldInfoPtr_scalePositionZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldSpaceCanvasScaler>.NativeClassPtr, nameof (scalePositionZ));
    WorldSpaceCanvasScaler.NativeFieldInfoPtr_basePositionZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldSpaceCanvasScaler>.NativeClassPtr, nameof (basePositionZ));
    WorldSpaceCanvasScaler.NativeFieldInfoPtr_scaleX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldSpaceCanvasScaler>.NativeClassPtr, nameof (scaleX));
    WorldSpaceCanvasScaler.NativeFieldInfoPtr_baseScaleX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldSpaceCanvasScaler>.NativeClassPtr, nameof (baseScaleX));
    WorldSpaceCanvasScaler.NativeFieldInfoPtr_scaleY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldSpaceCanvasScaler>.NativeClassPtr, nameof (scaleY));
    WorldSpaceCanvasScaler.NativeFieldInfoPtr_baseScaleY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldSpaceCanvasScaler>.NativeClassPtr, nameof (baseScaleY));
    WorldSpaceCanvasScaler.NativeFieldInfoPtr_scaleZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldSpaceCanvasScaler>.NativeClassPtr, nameof (scaleZ));
    WorldSpaceCanvasScaler.NativeFieldInfoPtr_baseScaleZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldSpaceCanvasScaler>.NativeClassPtr, nameof (baseScaleZ));
    WorldSpaceCanvasScaler.NativeMethodInfoPtr_UpdateSize_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldSpaceCanvasScaler>.NativeClassPtr, 100672339);
    WorldSpaceCanvasScaler.NativeMethodInfoPtr_SetPosition_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldSpaceCanvasScaler>.NativeClassPtr, 100672340);
    WorldSpaceCanvasScaler.NativeMethodInfoPtr_SetScale_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldSpaceCanvasScaler>.NativeClassPtr, 100672341);
    WorldSpaceCanvasScaler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldSpaceCanvasScaler>.NativeClassPtr, 100672342);
  }

  public WorldSpaceCanvasScaler(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe bool invert
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldSpaceCanvasScaler.NativeFieldInfoPtr_invert));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldSpaceCanvasScaler.NativeFieldInfoPtr_invert)) = value;
    }
  }

  public unsafe bool scalePositionX
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldSpaceCanvasScaler.NativeFieldInfoPtr_scalePositionX));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldSpaceCanvasScaler.NativeFieldInfoPtr_scalePositionX)) = value;
    }
  }

  public unsafe float basePositionX
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldSpaceCanvasScaler.NativeFieldInfoPtr_basePositionX));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldSpaceCanvasScaler.NativeFieldInfoPtr_basePositionX)) = value;
    }
  }

  public unsafe bool scalePositionY
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldSpaceCanvasScaler.NativeFieldInfoPtr_scalePositionY));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldSpaceCanvasScaler.NativeFieldInfoPtr_scalePositionY)) = value;
    }
  }

  public unsafe float basePositionY
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldSpaceCanvasScaler.NativeFieldInfoPtr_basePositionY));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldSpaceCanvasScaler.NativeFieldInfoPtr_basePositionY)) = value;
    }
  }

  public unsafe bool scalePositionZ
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldSpaceCanvasScaler.NativeFieldInfoPtr_scalePositionZ));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldSpaceCanvasScaler.NativeFieldInfoPtr_scalePositionZ)) = value;
    }
  }

  public unsafe float basePositionZ
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldSpaceCanvasScaler.NativeFieldInfoPtr_basePositionZ));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldSpaceCanvasScaler.NativeFieldInfoPtr_basePositionZ)) = value;
    }
  }

  public unsafe bool scaleX
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldSpaceCanvasScaler.NativeFieldInfoPtr_scaleX));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldSpaceCanvasScaler.NativeFieldInfoPtr_scaleX)) = value;
    }
  }

  public unsafe float baseScaleX
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldSpaceCanvasScaler.NativeFieldInfoPtr_baseScaleX));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldSpaceCanvasScaler.NativeFieldInfoPtr_baseScaleX)) = value;
    }
  }

  public unsafe bool scaleY
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldSpaceCanvasScaler.NativeFieldInfoPtr_scaleY));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldSpaceCanvasScaler.NativeFieldInfoPtr_scaleY)) = value;
    }
  }

  public unsafe float baseScaleY
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldSpaceCanvasScaler.NativeFieldInfoPtr_baseScaleY));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldSpaceCanvasScaler.NativeFieldInfoPtr_baseScaleY)) = value;
    }
  }

  public unsafe bool scaleZ
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldSpaceCanvasScaler.NativeFieldInfoPtr_scaleZ));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldSpaceCanvasScaler.NativeFieldInfoPtr_scaleZ)) = value;
    }
  }

  public unsafe float baseScaleZ
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldSpaceCanvasScaler.NativeFieldInfoPtr_baseScaleZ));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldSpaceCanvasScaler.NativeFieldInfoPtr_baseScaleZ)) = value;
    }
  }
}
