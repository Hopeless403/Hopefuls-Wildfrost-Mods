// Decompiled with JetBrains decompiler
// Type: UINavigationLayer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class UINavigationLayer : MonoBehaviour
{
  private static readonly System.IntPtr NativeFieldInfoPtr_idMax;
  private static readonly System.IntPtr NativeFieldInfoPtr_id;
  private static readonly System.IntPtr NativeFieldInfoPtr_isOverrideLayer;
  private static readonly System.IntPtr NativeFieldInfoPtr_setStartingItem;
  private static readonly System.IntPtr NativeFieldInfoPtr_allowOutsideVisibleSelection;
  private static readonly System.IntPtr NativeFieldInfoPtr_allowLayerToBeAppliedAtRuntime;
  private static readonly System.IntPtr NativeFieldInfoPtr_forceHover;
  private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18456, XrefRangeEnd = 18458, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(UINavigationLayer.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18458, XrefRangeEnd = 18469, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(UINavigationLayer.NativeMethodInfoPtr_OnEnable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18469, XrefRangeEnd = 18475, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(UINavigationLayer.NativeMethodInfoPtr_OnDisable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18475, XrefRangeEnd = 18477, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe bool Equals(Il2CppSystem.Object other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UINavigationLayer.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18477, XrefRangeEnd = 18478, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UINavigationLayer()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UINavigationLayer>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(UINavigationLayer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static UINavigationLayer()
  {
    Il2CppClassPointerStore<UINavigationLayer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (UINavigationLayer));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UINavigationLayer>.NativeClassPtr);
    UINavigationLayer.NativeFieldInfoPtr_idMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINavigationLayer>.NativeClassPtr, nameof (idMax));
    UINavigationLayer.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINavigationLayer>.NativeClassPtr, nameof (id));
    UINavigationLayer.NativeFieldInfoPtr_isOverrideLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINavigationLayer>.NativeClassPtr, nameof (isOverrideLayer));
    UINavigationLayer.NativeFieldInfoPtr_setStartingItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINavigationLayer>.NativeClassPtr, nameof (setStartingItem));
    UINavigationLayer.NativeFieldInfoPtr_allowOutsideVisibleSelection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINavigationLayer>.NativeClassPtr, nameof (allowOutsideVisibleSelection));
    UINavigationLayer.NativeFieldInfoPtr_allowLayerToBeAppliedAtRuntime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINavigationLayer>.NativeClassPtr, nameof (allowLayerToBeAppliedAtRuntime));
    UINavigationLayer.NativeFieldInfoPtr_forceHover = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINavigationLayer>.NativeClassPtr, nameof (forceHover));
    UINavigationLayer.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINavigationLayer>.NativeClassPtr, 100663563);
    UINavigationLayer.NativeMethodInfoPtr_OnEnable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINavigationLayer>.NativeClassPtr, 100663564);
    UINavigationLayer.NativeMethodInfoPtr_OnDisable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINavigationLayer>.NativeClassPtr, 100663565);
    UINavigationLayer.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINavigationLayer>.NativeClassPtr, 100663566);
    UINavigationLayer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINavigationLayer>.NativeClassPtr, 100663567);
  }

  public UINavigationLayer(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe uint idMax
  {
    get
    {
      uint idMax;
      IL2CPP.il2cpp_field_static_get_value(UINavigationLayer.NativeFieldInfoPtr_idMax, (void*) &idMax);
      return idMax;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(UINavigationLayer.NativeFieldInfoPtr_idMax, (void*) &value);
    }
  }

  public unsafe uint id
  {
    get
    {
      return *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UINavigationLayer.NativeFieldInfoPtr_id));
    }
    [param: In] set
    {
      *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UINavigationLayer.NativeFieldInfoPtr_id)) = value;
    }
  }

  public unsafe bool isOverrideLayer
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UINavigationLayer.NativeFieldInfoPtr_isOverrideLayer));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UINavigationLayer.NativeFieldInfoPtr_isOverrideLayer)) = value;
    }
  }

  public unsafe bool setStartingItem
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UINavigationLayer.NativeFieldInfoPtr_setStartingItem));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UINavigationLayer.NativeFieldInfoPtr_setStartingItem)) = value;
    }
  }

  public unsafe bool allowOutsideVisibleSelection
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UINavigationLayer.NativeFieldInfoPtr_allowOutsideVisibleSelection));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UINavigationLayer.NativeFieldInfoPtr_allowOutsideVisibleSelection)) = value;
    }
  }

  public unsafe bool allowLayerToBeAppliedAtRuntime
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UINavigationLayer.NativeFieldInfoPtr_allowLayerToBeAppliedAtRuntime));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UINavigationLayer.NativeFieldInfoPtr_allowLayerToBeAppliedAtRuntime)) = value;
    }
  }

  public unsafe bool forceHover
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UINavigationLayer.NativeFieldInfoPtr_forceHover));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UINavigationLayer.NativeFieldInfoPtr_forceHover)) = value;
    }
  }
}
