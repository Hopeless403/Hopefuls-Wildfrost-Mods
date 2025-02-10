// Decompiled with JetBrains decompiler
// Type: BlockForMinibossesModifierSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
public class BlockForMinibossesModifierSystem : GameSystem
{
  private static readonly IntPtr NativeFieldInfoPtr_healthFactor;
  private static readonly IntPtr NativeFieldInfoPtr_blockPerHealthLost;
  private static readonly IntPtr NativeFieldInfoPtr__effect;
  private static readonly IntPtr NativeMethodInfoPtr_get_effect_Private_Static_get_StatusEffectData_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_CardDataCreated_Private_Static_Void_CardData_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  public static unsafe StatusEffectData effect
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64724, XrefRangeEnd = 64739, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(BlockForMinibossesModifierSystem.NativeMethodInfoPtr_get_effect_Private_Static_get_StatusEffectData_0, IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (StatusEffectData) null : new StatusEffectData(pointer);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64739, XrefRangeEnd = 64747, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BlockForMinibossesModifierSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64747, XrefRangeEnd = 64755, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BlockForMinibossesModifierSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64755, XrefRangeEnd = 64793, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void CardDataCreated(CardData cardData)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cardData)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BlockForMinibossesModifierSystem.NativeMethodInfoPtr_CardDataCreated_Private_Static_Void_CardData_0, IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 21168, RefRangeEnd = 21171, XrefRangeStart = 21168, XrefRangeEnd = 21171, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe BlockForMinibossesModifierSystem()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlockForMinibossesModifierSystem>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BlockForMinibossesModifierSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static BlockForMinibossesModifierSystem()
  {
    Il2CppClassPointerStore<BlockForMinibossesModifierSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (BlockForMinibossesModifierSystem));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlockForMinibossesModifierSystem>.NativeClassPtr);
    BlockForMinibossesModifierSystem.NativeFieldInfoPtr_healthFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlockForMinibossesModifierSystem>.NativeClassPtr, nameof (healthFactor));
    BlockForMinibossesModifierSystem.NativeFieldInfoPtr_blockPerHealthLost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlockForMinibossesModifierSystem>.NativeClassPtr, nameof (blockPerHealthLost));
    BlockForMinibossesModifierSystem.NativeFieldInfoPtr__effect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlockForMinibossesModifierSystem>.NativeClassPtr, nameof (_effect));
    BlockForMinibossesModifierSystem.NativeMethodInfoPtr_get_effect_Private_Static_get_StatusEffectData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlockForMinibossesModifierSystem>.NativeClassPtr, 100668596);
    BlockForMinibossesModifierSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlockForMinibossesModifierSystem>.NativeClassPtr, 100668597);
    BlockForMinibossesModifierSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlockForMinibossesModifierSystem>.NativeClassPtr, 100668598);
    BlockForMinibossesModifierSystem.NativeMethodInfoPtr_CardDataCreated_Private_Static_Void_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlockForMinibossesModifierSystem>.NativeClassPtr, 100668599);
    BlockForMinibossesModifierSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlockForMinibossesModifierSystem>.NativeClassPtr, 100668600);
  }

  public BlockForMinibossesModifierSystem(IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe float healthFactor
  {
    get
    {
      float healthFactor;
      IL2CPP.il2cpp_field_static_get_value(BlockForMinibossesModifierSystem.NativeFieldInfoPtr_healthFactor, (void*) &healthFactor);
      return healthFactor;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(BlockForMinibossesModifierSystem.NativeFieldInfoPtr_healthFactor, (void*) &value);
    }
  }

  public static unsafe float blockPerHealthLost
  {
    get
    {
      float blockPerHealthLost;
      IL2CPP.il2cpp_field_static_get_value(BlockForMinibossesModifierSystem.NativeFieldInfoPtr_blockPerHealthLost, (void*) &blockPerHealthLost);
      return blockPerHealthLost;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(BlockForMinibossesModifierSystem.NativeFieldInfoPtr_blockPerHealthLost, (void*) &value);
    }
  }

  public static unsafe StatusEffectData _effect
  {
    get
    {
      IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(BlockForMinibossesModifierSystem.NativeFieldInfoPtr__effect, (void*) &num);
      IntPtr pointer = num;
      return pointer == IntPtr.Zero ? (StatusEffectData) null : new StatusEffectData(pointer);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(BlockForMinibossesModifierSystem.NativeFieldInfoPtr__effect, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
