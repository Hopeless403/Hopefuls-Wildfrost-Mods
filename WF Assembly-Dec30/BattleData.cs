// Decompiled with JetBrains decompiler
// Type: BattleData
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
using UnityEngine.Localization;

#nullable disable
public class BattleData : DataFile
{
  private static readonly IntPtr NativeFieldInfoPtr_title;
  private static readonly IntPtr NativeFieldInfoPtr_pointFactor;
  private static readonly IntPtr NativeFieldInfoPtr_waveCounter;
  private static readonly IntPtr NativeFieldInfoPtr_pools;
  private static readonly IntPtr NativeFieldInfoPtr_bonusUnitPool;
  private static readonly IntPtr NativeFieldInfoPtr_bonusUnitRange;
  private static readonly IntPtr NativeFieldInfoPtr_goldGiverPool;
  private static readonly IntPtr NativeFieldInfoPtr_goldGivers;
  private static readonly IntPtr NativeFieldInfoPtr_generationScript;
  private static readonly IntPtr NativeFieldInfoPtr_setUpScript;
  private static readonly IntPtr NativeFieldInfoPtr_sprite;
  private static readonly IntPtr NativeFieldInfoPtr_nameRef;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104718, XrefRangeEnd = 104719, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe BattleData()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BattleData>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BattleData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static BattleData()
  {
    Il2CppClassPointerStore<BattleData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (BattleData));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BattleData>.NativeClassPtr);
    BattleData.NativeFieldInfoPtr_title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleData>.NativeClassPtr, nameof (title));
    BattleData.NativeFieldInfoPtr_pointFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleData>.NativeClassPtr, nameof (pointFactor));
    BattleData.NativeFieldInfoPtr_waveCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleData>.NativeClassPtr, nameof (waveCounter));
    BattleData.NativeFieldInfoPtr_pools = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleData>.NativeClassPtr, nameof (pools));
    BattleData.NativeFieldInfoPtr_bonusUnitPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleData>.NativeClassPtr, nameof (bonusUnitPool));
    BattleData.NativeFieldInfoPtr_bonusUnitRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleData>.NativeClassPtr, nameof (bonusUnitRange));
    BattleData.NativeFieldInfoPtr_goldGiverPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleData>.NativeClassPtr, nameof (goldGiverPool));
    BattleData.NativeFieldInfoPtr_goldGivers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleData>.NativeClassPtr, nameof (goldGivers));
    BattleData.NativeFieldInfoPtr_generationScript = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleData>.NativeClassPtr, nameof (generationScript));
    BattleData.NativeFieldInfoPtr_setUpScript = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleData>.NativeClassPtr, nameof (setUpScript));
    BattleData.NativeFieldInfoPtr_sprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleData>.NativeClassPtr, nameof (sprite));
    BattleData.NativeFieldInfoPtr_nameRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleData>.NativeClassPtr, nameof (nameRef));
    BattleData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleData>.NativeClassPtr, 100672776);
  }

  public BattleData(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe string title
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleData.NativeFieldInfoPtr_title)));
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleData.NativeFieldInfoPtr_title), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe float pointFactor
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleData.NativeFieldInfoPtr_pointFactor));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleData.NativeFieldInfoPtr_pointFactor)) = value;
    }
  }

  public unsafe int waveCounter
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleData.NativeFieldInfoPtr_waveCounter));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleData.NativeFieldInfoPtr_waveCounter)) = value;
    }
  }

  public unsafe Il2CppReferenceArray<BattleWavePoolData> pools
  {
    get
    {
      IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleData.NativeFieldInfoPtr_pools));
      return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<BattleWavePoolData>) null : new Il2CppReferenceArray<BattleWavePoolData>(nativeObject);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleData.NativeFieldInfoPtr_pools), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<CardData> bonusUnitPool
  {
    get
    {
      IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleData.NativeFieldInfoPtr_bonusUnitPool));
      return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<CardData>) null : new Il2CppReferenceArray<CardData>(nativeObject);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleData.NativeFieldInfoPtr_bonusUnitPool), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector2Int bonusUnitRange
  {
    get
    {
      return *(Vector2Int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleData.NativeFieldInfoPtr_bonusUnitRange));
    }
    [param: In] set
    {
      *(Vector2Int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleData.NativeFieldInfoPtr_bonusUnitRange)) = value;
    }
  }

  public unsafe Il2CppReferenceArray<CardData> goldGiverPool
  {
    get
    {
      IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleData.NativeFieldInfoPtr_goldGiverPool));
      return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<CardData>) null : new Il2CppReferenceArray<CardData>(nativeObject);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleData.NativeFieldInfoPtr_goldGiverPool), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int goldGivers
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleData.NativeFieldInfoPtr_goldGivers));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleData.NativeFieldInfoPtr_goldGivers)) = value;
    }
  }

  public unsafe BattleGenerationScript generationScript
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleData.NativeFieldInfoPtr_generationScript));
      return pointer == IntPtr.Zero ? (BattleGenerationScript) null : new BattleGenerationScript(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleData.NativeFieldInfoPtr_generationScript), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Script setUpScript
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleData.NativeFieldInfoPtr_setUpScript));
      return pointer == IntPtr.Zero ? (Script) null : new Script(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleData.NativeFieldInfoPtr_setUpScript), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Sprite sprite
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleData.NativeFieldInfoPtr_sprite));
      return pointer == IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleData.NativeFieldInfoPtr_sprite), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedString nameRef
  {
    get
    {
      IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BattleData.NativeFieldInfoPtr_nameRef));
      return pointer == IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BattleData.NativeFieldInfoPtr_nameRef), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
