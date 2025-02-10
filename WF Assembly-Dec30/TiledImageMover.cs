// Decompiled with JetBrains decompiler
// Type: TiledImageMover
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
public class TiledImageMover : MonoBehaviourCacheTransform
{
  private static readonly IntPtr NativeFieldInfoPtr_moveX;
  private static readonly IntPtr NativeFieldInfoPtr_resetPosX;
  private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83266, XrefRangeEnd = 83273, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TiledImageMover.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83273, XrefRangeEnd = 83274, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe TiledImageMover()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TiledImageMover>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TiledImageMover.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static TiledImageMover()
  {
    Il2CppClassPointerStore<TiledImageMover>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (TiledImageMover));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TiledImageMover>.NativeClassPtr);
    TiledImageMover.NativeFieldInfoPtr_moveX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TiledImageMover>.NativeClassPtr, nameof (moveX));
    TiledImageMover.NativeFieldInfoPtr_resetPosX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TiledImageMover>.NativeClassPtr, nameof (resetPosX));
    TiledImageMover.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TiledImageMover>.NativeClassPtr, 100670188);
    TiledImageMover.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TiledImageMover>.NativeClassPtr, 100670189);
  }

  public TiledImageMover(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe float moveX
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TiledImageMover.NativeFieldInfoPtr_moveX));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TiledImageMover.NativeFieldInfoPtr_moveX)) = value;
    }
  }

  public unsafe float resetPosX
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TiledImageMover.NativeFieldInfoPtr_resetPosX));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TiledImageMover.NativeFieldInfoPtr_resetPosX)) = value;
    }
  }
}
