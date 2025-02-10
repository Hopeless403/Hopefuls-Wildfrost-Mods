// Decompiled with JetBrains decompiler
// Type: StatsPanelSplatters
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
using UnityEngine;

#nullable disable
public class StatsPanelSplatters : MonoBehaviour
{
  private static readonly System.IntPtr NativeFieldInfoPtr_splatterSprites;
  private static readonly System.IntPtr NativeFieldInfoPtr_splatters;
  private static readonly System.IntPtr NativeFieldInfoPtr_profiles;
  private static readonly System.IntPtr NativeFieldInfoPtr_spritePool;
  private static readonly System.IntPtr NativeFieldInfoPtr_profilePool;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PullProfile_Private_Profile_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PullSprite_Private_Sprite_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Private_Static_Void_ImageSprite_Profile_Sprite_Color_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95379, XrefRangeEnd = 95470, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatsPanelSplatters.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95470, XrefRangeEnd = 95481, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe StatsPanelSplatters.Profile PullProfile()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatsPanelSplatters.NativeMethodInfoPtr_PullProfile_Private_Profile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(StatsPanelSplatters.Profile*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95481, XrefRangeEnd = 95489, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Sprite PullSprite()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatsPanelSplatters.NativeMethodInfoPtr_PullSprite_Private_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95489, XrefRangeEnd = 95502, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Set(
    ImageSprite image,
    StatsPanelSplatters.Profile profile,
    Sprite sprite,
    Color color)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) image);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &profile;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sprite);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &color;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatsPanelSplatters.NativeMethodInfoPtr_Set_Private_Static_Void_ImageSprite_Profile_Sprite_Color_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95502, XrefRangeEnd = 95518, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe StatsPanelSplatters()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatsPanelSplatters>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatsPanelSplatters.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static StatsPanelSplatters()
  {
    Il2CppClassPointerStore<StatsPanelSplatters>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (StatsPanelSplatters));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatsPanelSplatters>.NativeClassPtr);
    StatsPanelSplatters.NativeFieldInfoPtr_splatterSprites = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatsPanelSplatters>.NativeClassPtr, nameof (splatterSprites));
    StatsPanelSplatters.NativeFieldInfoPtr_splatters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatsPanelSplatters>.NativeClassPtr, nameof (splatters));
    StatsPanelSplatters.NativeFieldInfoPtr_profiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatsPanelSplatters>.NativeClassPtr, nameof (profiles));
    StatsPanelSplatters.NativeFieldInfoPtr_spritePool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatsPanelSplatters>.NativeClassPtr, nameof (spritePool));
    StatsPanelSplatters.NativeFieldInfoPtr_profilePool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatsPanelSplatters>.NativeClassPtr, nameof (profilePool));
    StatsPanelSplatters.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatsPanelSplatters>.NativeClassPtr, 100671599);
    StatsPanelSplatters.NativeMethodInfoPtr_PullProfile_Private_Profile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatsPanelSplatters>.NativeClassPtr, 100671600);
    StatsPanelSplatters.NativeMethodInfoPtr_PullSprite_Private_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatsPanelSplatters>.NativeClassPtr, 100671601);
    StatsPanelSplatters.NativeMethodInfoPtr_Set_Private_Static_Void_ImageSprite_Profile_Sprite_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatsPanelSplatters>.NativeClassPtr, 100671602);
    StatsPanelSplatters.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatsPanelSplatters>.NativeClassPtr, 100671603);
  }

  public StatsPanelSplatters(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Il2CppReferenceArray<Sprite> splatterSprites
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatsPanelSplatters.NativeFieldInfoPtr_splatterSprites));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<Sprite>) null : new Il2CppReferenceArray<Sprite>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatsPanelSplatters.NativeFieldInfoPtr_splatterSprites), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<ImageSprite> splatters
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatsPanelSplatters.NativeFieldInfoPtr_splatters));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<ImageSprite>) null : new Il2CppReferenceArray<ImageSprite>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatsPanelSplatters.NativeFieldInfoPtr_splatters), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe Il2CppStructArray<StatsPanelSplatters.Profile> profiles
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(StatsPanelSplatters.NativeFieldInfoPtr_profiles, (void*) &num);
      System.IntPtr nativeObject = num;
      return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<StatsPanelSplatters.Profile>) null : new Il2CppStructArray<StatsPanelSplatters.Profile>(nativeObject);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(StatsPanelSplatters.NativeFieldInfoPtr_profiles, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<Sprite> spritePool
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatsPanelSplatters.NativeFieldInfoPtr_spritePool));
      return pointer == System.IntPtr.Zero ? (List<Sprite>) null : new List<Sprite>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatsPanelSplatters.NativeFieldInfoPtr_spritePool), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<StatsPanelSplatters.Profile> profilePool
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatsPanelSplatters.NativeFieldInfoPtr_profilePool));
      return pointer == System.IntPtr.Zero ? (List<StatsPanelSplatters.Profile>) null : new List<StatsPanelSplatters.Profile>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StatsPanelSplatters.NativeFieldInfoPtr_profilePool), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct Profile
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_anchorMin;
    private static readonly System.IntPtr NativeFieldInfoPtr_anchorMax;
    private static readonly System.IntPtr NativeFieldInfoPtr_moveRange;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_Single_Single_0;
    [FieldOffset(0)]
    public readonly Vector2 anchorMin;
    [FieldOffset(8)]
    public readonly Vector2 anchorMax;
    [FieldOffset(16)]
    public readonly Vector2 moveRange;

    [CallerCount(0)]
    public unsafe Profile(
      float minX,
      float minY,
      float maxX,
      float maxY,
      float moveX,
      float moveY)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) &minX;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &minY;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &maxX;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &maxY;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &moveX;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &moveY;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StatsPanelSplatters.Profile.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_Single_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Profile()
    {
      Il2CppClassPointerStore<StatsPanelSplatters.Profile>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatsPanelSplatters>.NativeClassPtr, nameof (Profile));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatsPanelSplatters.Profile>.NativeClassPtr);
      StatsPanelSplatters.Profile.NativeFieldInfoPtr_anchorMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatsPanelSplatters.Profile>.NativeClassPtr, nameof (anchorMin));
      StatsPanelSplatters.Profile.NativeFieldInfoPtr_anchorMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatsPanelSplatters.Profile>.NativeClassPtr, nameof (anchorMax));
      StatsPanelSplatters.Profile.NativeFieldInfoPtr_moveRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatsPanelSplatters.Profile>.NativeClassPtr, nameof (moveRange));
      StatsPanelSplatters.Profile.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatsPanelSplatters.Profile>.NativeClassPtr, 100671605);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StatsPanelSplatters.Profile>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [ObfuscatedName("StatsPanelSplatters/<>c")]
  [Serializable]
  public sealed class __c : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__5_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__OnEnable_b__5_0_Internal_Color_SplatterData_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatsPanelSplatters.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StatsPanelSplatters.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe Color _OnEnable_b__5_0(SplatterPersistenceSystem.SplatterData a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatsPanelSplatters.__c.NativeMethodInfoPtr__OnEnable_b__5_0_Internal_Color_SplatterData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Color*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c()
    {
      Il2CppClassPointerStore<StatsPanelSplatters.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatsPanelSplatters>.NativeClassPtr, "<>c");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatsPanelSplatters.__c>.NativeClassPtr);
      StatsPanelSplatters.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatsPanelSplatters.__c>.NativeClassPtr, "<>9");
      StatsPanelSplatters.__c.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatsPanelSplatters.__c>.NativeClassPtr, "<>9__5_0");
      StatsPanelSplatters.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatsPanelSplatters.__c>.NativeClassPtr, 100671607);
      StatsPanelSplatters.__c.NativeMethodInfoPtr__OnEnable_b__5_0_Internal_Color_SplatterData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatsPanelSplatters.__c>.NativeClassPtr, 100671608);
    }

    public __c(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe StatsPanelSplatters.__c __9
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(StatsPanelSplatters.__c.NativeFieldInfoPtr___9, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (StatsPanelSplatters.__c) null : new StatsPanelSplatters.__c(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(StatsPanelSplatters.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<SplatterPersistenceSystem.SplatterData, Color> __9__5_0
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(StatsPanelSplatters.__c.NativeFieldInfoPtr___9__5_0, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<SplatterPersistenceSystem.SplatterData, Color>) null : new Il2CppSystem.Func<SplatterPersistenceSystem.SplatterData, Color>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(StatsPanelSplatters.__c.NativeFieldInfoPtr___9__5_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
