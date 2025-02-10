// Decompiled with JetBrains decompiler
// Type: BattleGenerationScriptWaves
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
public class BattleGenerationScriptWaves : BattleGenerationScript
{
  private static readonly System.IntPtr NativeMethodInfoPtr_Run_Public_Virtual_SaveCollection_1_WaveData_BattleData_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105265, XrefRangeEnd = 105399, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe SaveCollection<BattleWaveManager.WaveData> Run(
    BattleData battleData,
    int points)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) battleData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &points;
    System.IntPtr exc;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BattleGenerationScriptWaves.NativeMethodInfoPtr_Run_Public_Virtual_SaveCollection_1_WaveData_BattleData_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return new SaveCollection<BattleWaveManager.WaveData>(pointer);
  }

  [CallerCount(110)]
  [CachedScanResults(RefRangeStart = 104608, RefRangeEnd = 104718, XrefRangeStart = 104608, XrefRangeEnd = 104718, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe BattleGenerationScriptWaves()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BattleGenerationScriptWaves>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(BattleGenerationScriptWaves.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static BattleGenerationScriptWaves()
  {
    Il2CppClassPointerStore<BattleGenerationScriptWaves>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (BattleGenerationScriptWaves));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BattleGenerationScriptWaves>.NativeClassPtr);
    BattleGenerationScriptWaves.NativeMethodInfoPtr_Run_Public_Virtual_SaveCollection_1_WaveData_BattleData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleGenerationScriptWaves>.NativeClassPtr, 100672804);
    BattleGenerationScriptWaves.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleGenerationScriptWaves>.NativeClassPtr, 100672805);
  }

  public BattleGenerationScriptWaves(System.IntPtr pointer)
    : base(pointer)
  {
  }

  [ObfuscatedName("BattleGenerationScriptWaves/<>c")]
  [Serializable]
  public sealed class __c : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__0_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Run_b__0_0_Internal_Card_String_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BattleGenerationScriptWaves.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BattleGenerationScriptWaves.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105261, XrefRangeEnd = 105265, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BattleWaveManager.Card _Run_b__0_0(string a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BattleGenerationScriptWaves.__c.NativeMethodInfoPtr__Run_b__0_0_Internal_Card_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (BattleWaveManager.Card) null : new BattleWaveManager.Card(pointer);
    }

    static __c()
    {
      Il2CppClassPointerStore<BattleGenerationScriptWaves.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BattleGenerationScriptWaves>.NativeClassPtr, "<>c");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BattleGenerationScriptWaves.__c>.NativeClassPtr);
      BattleGenerationScriptWaves.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleGenerationScriptWaves.__c>.NativeClassPtr, "<>9");
      BattleGenerationScriptWaves.__c.NativeFieldInfoPtr___9__0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleGenerationScriptWaves.__c>.NativeClassPtr, "<>9__0_0");
      BattleGenerationScriptWaves.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleGenerationScriptWaves.__c>.NativeClassPtr, 100672807);
      BattleGenerationScriptWaves.__c.NativeMethodInfoPtr__Run_b__0_0_Internal_Card_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleGenerationScriptWaves.__c>.NativeClassPtr, 100672808);
    }

    public __c(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe BattleGenerationScriptWaves.__c __9
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(BattleGenerationScriptWaves.__c.NativeFieldInfoPtr___9, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (BattleGenerationScriptWaves.__c) null : new BattleGenerationScriptWaves.__c(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(BattleGenerationScriptWaves.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<string, BattleWaveManager.Card> __9__0_0
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(BattleGenerationScriptWaves.__c.NativeFieldInfoPtr___9__0_0, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<string, BattleWaveManager.Card>) null : new Il2CppSystem.Func<string, BattleWaveManager.Card>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(BattleGenerationScriptWaves.__c.NativeFieldInfoPtr___9__0_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
