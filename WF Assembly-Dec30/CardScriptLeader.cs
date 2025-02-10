// Decompiled with JetBrains decompiler
// Type: CardScriptLeader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System;
using System.Runtime.InteropServices;

#nullable disable
public class CardScriptLeader : CardScript
{
  private static readonly IntPtr NativeFieldInfoPtr_characterTypeOptions;
  private static readonly IntPtr NativeFieldInfoPtr_leaderProfileOptions;
  private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Void_CardData_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20438, XrefRangeEnd = 20460, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Run(CardData target)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CardScriptLeader.NativeMethodInfoPtr_Run_Public_Virtual_Void_CardData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CardScriptLeader()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardScriptLeader>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardScriptLeader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static CardScriptLeader()
  {
    Il2CppClassPointerStore<CardScriptLeader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (CardScriptLeader));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardScriptLeader>.NativeClassPtr);
    CardScriptLeader.NativeFieldInfoPtr_characterTypeOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardScriptLeader>.NativeClassPtr, nameof (characterTypeOptions));
    CardScriptLeader.NativeFieldInfoPtr_leaderProfileOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardScriptLeader>.NativeClassPtr, nameof (leaderProfileOptions));
    CardScriptLeader.NativeMethodInfoPtr_Run_Public_Virtual_Void_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardScriptLeader>.NativeClassPtr, 100663787);
    CardScriptLeader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardScriptLeader>.NativeClassPtr, 100663788);
  }

  public CardScriptLeader(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Il2CppReferenceArray<CharacterType> characterTypeOptions
  {
    get
    {
      IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardScriptLeader.NativeFieldInfoPtr_characterTypeOptions));
      return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<CharacterType>) null : new Il2CppReferenceArray<CharacterType>(nativeObject);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardScriptLeader.NativeFieldInfoPtr_characterTypeOptions), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<LeaderProfileData> leaderProfileOptions
  {
    get
    {
      IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CardScriptLeader.NativeFieldInfoPtr_leaderProfileOptions));
      return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<LeaderProfileData>) null : new Il2CppReferenceArray<LeaderProfileData>(nativeObject);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CardScriptLeader.NativeFieldInfoPtr_leaderProfileOptions), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
