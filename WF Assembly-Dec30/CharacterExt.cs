// Decompiled with JetBrains decompiler
// Type: CharacterExt
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System.Runtime.InteropServices;

#nullable disable
public static class CharacterExt : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeMethodInfoPtr_OrderNextCards_Public_Static_Void_Character_Il2CppStringArray_0;

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 101555, RefRangeEnd = 101559, XrefRangeStart = 101513, XrefRangeEnd = 101555, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OrderNextCards(
    this Character character,
    Il2CppStringArray nextCardNames)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) character);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) nextCardNames);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CharacterExt.NativeMethodInfoPtr_OrderNextCards_Public_Static_Void_Character_Il2CppStringArray_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static CharacterExt()
  {
    Il2CppClassPointerStore<CharacterExt>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (CharacterExt));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterExt>.NativeClassPtr);
    CharacterExt.NativeMethodInfoPtr_OrderNextCards_Public_Static_Void_Character_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterExt>.NativeClassPtr, 100672406);
  }

  public CharacterExt(System.IntPtr pointer)
    : base(pointer)
  {
  }

  [ObfuscatedName("CharacterExt/<>c__DisplayClass0_0")]
  public sealed class __c__DisplayClass0_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_cardName;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__OrderNextCards_b__0_Internal_Boolean_Entity_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass0_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterExt.__c__DisplayClass0_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CharacterExt.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _OrderNextCards_b__0(Entity a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CharacterExt.__c__DisplayClass0_0.NativeMethodInfoPtr__OrderNextCards_b__0_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c__DisplayClass0_0()
    {
      Il2CppClassPointerStore<CharacterExt.__c__DisplayClass0_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterExt>.NativeClassPtr, "<>c__DisplayClass0_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterExt.__c__DisplayClass0_0>.NativeClassPtr);
      CharacterExt.__c__DisplayClass0_0.NativeFieldInfoPtr_cardName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterExt.__c__DisplayClass0_0>.NativeClassPtr, nameof (cardName));
      CharacterExt.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterExt.__c__DisplayClass0_0>.NativeClassPtr, 100672407);
      CharacterExt.__c__DisplayClass0_0.NativeMethodInfoPtr__OrderNextCards_b__0_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterExt.__c__DisplayClass0_0>.NativeClassPtr, 100672408);
    }

    public __c__DisplayClass0_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe string cardName
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterExt.__c__DisplayClass0_0.NativeFieldInfoPtr_cardName)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterExt.__c__DisplayClass0_0.NativeFieldInfoPtr_cardName), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }
}
