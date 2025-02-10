// Decompiled with JetBrains decompiler
// Type: DeathSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;

#nullable disable
public class DeathSystem : GameSystem
{
  private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_EntityKilled_Private_Void_Entity_DeathType_0;
  private static readonly IntPtr NativeMethodInfoPtr_Destroy_Private_Void_Card_0;
  private static readonly IntPtr NativeMethodInfoPtr_Sacrifice_Private_Void_Card_0;
  private static readonly IntPtr NativeMethodInfoPtr_Consume_Private_Void_Card_0;
  private static readonly IntPtr NativeMethodInfoPtr_KilledByOwnTeam_Public_Static_Boolean_Entity_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58827, XrefRangeEnd = 58835, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DeathSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58835, XrefRangeEnd = 58843, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DeathSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58843, XrefRangeEnd = 58863, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EntityKilled(Entity entity, DeathType deathType)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &deathType;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DeathSystem.NativeMethodInfoPtr_EntityKilled_Private_Void_Entity_DeathType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58863, XrefRangeEnd = 58873, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Destroy(Card card)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) card)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DeathSystem.NativeMethodInfoPtr_Destroy_Private_Void_Card_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58873, XrefRangeEnd = 58881, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Sacrifice(Card card)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) card)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DeathSystem.NativeMethodInfoPtr_Sacrifice_Private_Void_Card_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58881, XrefRangeEnd = 58889, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Consume(Card card)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) card)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DeathSystem.NativeMethodInfoPtr_Consume_Private_Void_Card_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 58896, RefRangeEnd = 58899, XrefRangeStart = 58889, XrefRangeEnd = 58896, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool KilledByOwnTeam(Entity entity)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entity)
    };
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(DeathSystem.NativeMethodInfoPtr_KilledByOwnTeam_Public_Static_Boolean_Entity_0, IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 21168, RefRangeEnd = 21171, XrefRangeStart = 21168, XrefRangeEnd = 21171, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe DeathSystem()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeathSystem>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DeathSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static DeathSystem()
  {
    Il2CppClassPointerStore<DeathSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (DeathSystem));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeathSystem>.NativeClassPtr);
    DeathSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeathSystem>.NativeClassPtr, 100668105);
    DeathSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeathSystem>.NativeClassPtr, 100668106);
    DeathSystem.NativeMethodInfoPtr_EntityKilled_Private_Void_Entity_DeathType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeathSystem>.NativeClassPtr, 100668107);
    DeathSystem.NativeMethodInfoPtr_Destroy_Private_Void_Card_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeathSystem>.NativeClassPtr, 100668108);
    DeathSystem.NativeMethodInfoPtr_Sacrifice_Private_Void_Card_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeathSystem>.NativeClassPtr, 100668109);
    DeathSystem.NativeMethodInfoPtr_Consume_Private_Void_Card_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeathSystem>.NativeClassPtr, 100668110);
    DeathSystem.NativeMethodInfoPtr_KilledByOwnTeam_Public_Static_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeathSystem>.NativeClassPtr, 100668111);
    DeathSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeathSystem>.NativeClassPtr, 100668112);
  }

  public DeathSystem(IntPtr pointer)
    : base(pointer)
  {
  }
}
