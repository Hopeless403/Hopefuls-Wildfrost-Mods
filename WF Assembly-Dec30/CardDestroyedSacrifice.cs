// Decompiled with JetBrains decompiler
// Type: CardDestroyedSacrifice
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class CardDestroyedSacrifice : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_dur;
  private static readonly IntPtr NativeFieldInfoPtr_ease;
  private static readonly IntPtr NativeFieldInfoPtr_entity;
  private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Final_Public_Virtual_Final_New_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35242, XrefRangeEnd = 35272, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardDestroyedSacrifice.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35272, XrefRangeEnd = 35291, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Final()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardDestroyedSacrifice.NativeMethodInfoPtr_Final_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35291, XrefRangeEnd = 35292, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CardDestroyedSacrifice()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardDestroyedSacrifice>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardDestroyedSacrifice.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static CardDestroyedSacrifice()
  {
    Il2CppClassPointerStore<CardDestroyedSacrifice>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (CardDestroyedSacrifice));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardDestroyedSacrifice>.NativeClassPtr);
    CardDestroyedSacrifice.NativeFieldInfoPtr_dur = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardDestroyedSacrifice>.NativeClassPtr, nameof (dur));
    CardDestroyedSacrifice.NativeFieldInfoPtr_ease = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardDestroyedSacrifice>.NativeClassPtr, nameof (ease));
    CardDestroyedSacrifice.NativeFieldInfoPtr_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardDestroyedSacrifice>.NativeClassPtr, nameof (entity));
    CardDestroyedSacrifice.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardDestroyedSacrifice>.NativeClassPtr, 100665600);
    CardDestroyedSacrifice.NativeMethodInfoPtr_Final_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardDestroyedSacrifice>.NativeClassPtr, 100665601);
    CardDestroyedSacrifice.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardDestroyedSacrifice>.NativeClassPtr, 100665602);
  }

  public CardDestroyedSacrifice(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe float dur
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardDestroyedSacrifice.NativeFieldInfoPtr_dur));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardDestroyedSacrifice.NativeFieldInfoPtr_dur)) = value;
    }
  }

  public static unsafe LeanTweenType ease
  {
    get
    {
      LeanTweenType ease;
      IL2CPP.il2cpp_field_static_get_value(CardDestroyedSacrifice.NativeFieldInfoPtr_ease, (void*) &ease);
      return ease;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CardDestroyedSacrifice.NativeFieldInfoPtr_ease, (void*) &value);
    }
  }

  public unsafe Entity entity
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardDestroyedSacrifice.NativeFieldInfoPtr_entity));
      return pointer == IntPtr.Zero ? (Entity) null : new Entity(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardDestroyedSacrifice.NativeFieldInfoPtr_entity), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
