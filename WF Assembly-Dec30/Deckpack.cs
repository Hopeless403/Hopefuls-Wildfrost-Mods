// Decompiled with JetBrains decompiler
// Type: Deckpack
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine.UI;

#nullable disable
public class Deckpack : MonoBehaviourSingleton<Deckpack>
{
  private static readonly IntPtr NativeFieldInfoPtr_animator;
  private static readonly IntPtr NativeFieldInfoPtr_button;
  private static readonly IntPtr NativeFieldInfoPtr_open;
  private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_Static_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Static_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Static_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Ping_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  public static unsafe bool IsOpen
  {
    [CallerCount(19), CachedScanResults(RefRangeStart = 89602, RefRangeEnd = 89621, XrefRangeStart = 89598, XrefRangeEnd = 89602, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(Deckpack.NativeMethodInfoPtr_get_IsOpen_Public_Static_get_Boolean_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 89632, RefRangeEnd = 89633, XrefRangeStart = 89621, XrefRangeEnd = 89632, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Open()
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Deckpack.NativeMethodInfoPtr_Open_Public_Static_Void_0, IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 89644, RefRangeEnd = 89646, XrefRangeStart = 89633, XrefRangeEnd = 89644, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Close()
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Deckpack.NativeMethodInfoPtr_Close_Public_Static_Void_0, IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 89650, RefRangeEnd = 89651, XrefRangeStart = 89646, XrefRangeEnd = 89650, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Ping()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Deckpack.NativeMethodInfoPtr_Ping_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89651, XrefRangeEnd = 89654, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Deckpack()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Deckpack>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Deckpack.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static Deckpack()
  {
    Il2CppClassPointerStore<Deckpack>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (Deckpack));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Deckpack>.NativeClassPtr);
    Deckpack.NativeFieldInfoPtr_animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Deckpack>.NativeClassPtr, nameof (animator));
    Deckpack.NativeFieldInfoPtr_button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Deckpack>.NativeClassPtr, nameof (button));
    Deckpack.NativeFieldInfoPtr_open = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Deckpack>.NativeClassPtr, nameof (open));
    Deckpack.NativeMethodInfoPtr_get_IsOpen_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Deckpack>.NativeClassPtr, 100670923);
    Deckpack.NativeMethodInfoPtr_Open_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Deckpack>.NativeClassPtr, 100670924);
    Deckpack.NativeMethodInfoPtr_Close_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Deckpack>.NativeClassPtr, 100670925);
    Deckpack.NativeMethodInfoPtr_Ping_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Deckpack>.NativeClassPtr, 100670926);
    Deckpack.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Deckpack>.NativeClassPtr, 100670927);
  }

  public Deckpack(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe UnityEngine.Animator animator
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Deckpack.NativeFieldInfoPtr_animator));
      return pointer == IntPtr.Zero ? (UnityEngine.Animator) null : new UnityEngine.Animator(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Deckpack.NativeFieldInfoPtr_animator), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Button button
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Deckpack.NativeFieldInfoPtr_button));
      return pointer == IntPtr.Zero ? (Button) null : new Button(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Deckpack.NativeFieldInfoPtr_button), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool open
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Deckpack.NativeFieldInfoPtr_open));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Deckpack.NativeFieldInfoPtr_open)) = value;
    }
  }
}
