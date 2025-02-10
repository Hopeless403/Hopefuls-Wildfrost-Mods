// Decompiled with JetBrains decompiler
// Type: PromptShower
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Localization;

#nullable disable
public class PromptShower : MonoBehaviour
{
  private static readonly System.IntPtr NativeFieldInfoPtr_showOnEnable;
  private static readonly System.IntPtr NativeFieldInfoPtr_showOnce;
  private static readonly System.IntPtr NativeFieldInfoPtr_saveDataString;
  private static readonly System.IntPtr NativeFieldInfoPtr_anchor;
  private static readonly System.IntPtr NativeFieldInfoPtr_position;
  private static readonly System.IntPtr NativeFieldInfoPtr_width;
  private static readonly System.IntPtr NativeFieldInfoPtr_emote;
  private static readonly System.IntPtr NativeFieldInfoPtr_localizedString;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Show_Public_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Hide_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53398, XrefRangeEnd = 53399, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(PromptShower.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 53429, RefRangeEnd = 53430, XrefRangeStart = 53399, XrefRangeEnd = 53429, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Show(Il2CppSystem.Object insert)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) insert)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(PromptShower.NativeMethodInfoPtr_Show_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 40865, RefRangeEnd = 40866, XrefRangeStart = 40865, XrefRangeEnd = 40866, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Hide()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(PromptShower.NativeMethodInfoPtr_Hide_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53430, XrefRangeEnd = 53431, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe PromptShower()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PromptShower>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(PromptShower.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static PromptShower()
  {
    Il2CppClassPointerStore<PromptShower>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (PromptShower));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PromptShower>.NativeClassPtr);
    PromptShower.NativeFieldInfoPtr_showOnEnable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PromptShower>.NativeClassPtr, nameof (showOnEnable));
    PromptShower.NativeFieldInfoPtr_showOnce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PromptShower>.NativeClassPtr, nameof (showOnce));
    PromptShower.NativeFieldInfoPtr_saveDataString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PromptShower>.NativeClassPtr, nameof (saveDataString));
    PromptShower.NativeFieldInfoPtr_anchor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PromptShower>.NativeClassPtr, nameof (anchor));
    PromptShower.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PromptShower>.NativeClassPtr, nameof (position));
    PromptShower.NativeFieldInfoPtr_width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PromptShower>.NativeClassPtr, nameof (width));
    PromptShower.NativeFieldInfoPtr_emote = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PromptShower>.NativeClassPtr, nameof (emote));
    PromptShower.NativeFieldInfoPtr_localizedString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PromptShower>.NativeClassPtr, nameof (localizedString));
    PromptShower.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PromptShower>.NativeClassPtr, 100667618);
    PromptShower.NativeMethodInfoPtr_Show_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PromptShower>.NativeClassPtr, 100667619);
    PromptShower.NativeMethodInfoPtr_Hide_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PromptShower>.NativeClassPtr, 100667620);
    PromptShower.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PromptShower>.NativeClassPtr, 100667621);
  }

  public PromptShower(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe bool showOnEnable
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PromptShower.NativeFieldInfoPtr_showOnEnable));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PromptShower.NativeFieldInfoPtr_showOnEnable)) = value;
    }
  }

  public unsafe bool showOnce
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PromptShower.NativeFieldInfoPtr_showOnce));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PromptShower.NativeFieldInfoPtr_showOnce)) = value;
    }
  }

  public unsafe string saveDataString
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PromptShower.NativeFieldInfoPtr_saveDataString)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PromptShower.NativeFieldInfoPtr_saveDataString), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe Prompt.Anchor anchor
  {
    get
    {
      return *(Prompt.Anchor*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PromptShower.NativeFieldInfoPtr_anchor));
    }
    [param: In] set
    {
      *(Prompt.Anchor*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PromptShower.NativeFieldInfoPtr_anchor)) = value;
    }
  }

  public unsafe Vector2 position
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PromptShower.NativeFieldInfoPtr_position));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PromptShower.NativeFieldInfoPtr_position)) = value;
    }
  }

  public unsafe float width
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PromptShower.NativeFieldInfoPtr_width));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PromptShower.NativeFieldInfoPtr_width)) = value;
    }
  }

  public unsafe Prompt.Emote.Type emote
  {
    get
    {
      return *(Prompt.Emote.Type*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PromptShower.NativeFieldInfoPtr_emote));
    }
    [param: In] set
    {
      *(Prompt.Emote.Type*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PromptShower.NativeFieldInfoPtr_emote)) = value;
    }
  }

  public unsafe LocalizedString localizedString
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PromptShower.NativeFieldInfoPtr_localizedString));
      return pointer == System.IntPtr.Zero ? (LocalizedString) null : new LocalizedString(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PromptShower.NativeFieldInfoPtr_localizedString), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [ObfuscatedName("PromptShower/<>c__DisplayClass9_0")]
  public sealed class __c__DisplayClass9_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr_insert;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Show_b__0_Internal_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Show_b__1_Internal_String_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass9_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PromptShower.__c__DisplayClass9_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PromptShower.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53361, XrefRangeEnd = 53364, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string _Show_b__0()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(PromptShower.__c__DisplayClass9_0.NativeMethodInfoPtr__Show_b__0_Internal_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53364, XrefRangeEnd = 53398, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string _Show_b__1()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(PromptShower.__c__DisplayClass9_0.NativeMethodInfoPtr__Show_b__1_Internal_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    static __c__DisplayClass9_0()
    {
      Il2CppClassPointerStore<PromptShower.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PromptShower>.NativeClassPtr, "<>c__DisplayClass9_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PromptShower.__c__DisplayClass9_0>.NativeClassPtr);
      PromptShower.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PromptShower.__c__DisplayClass9_0>.NativeClassPtr, "<>4__this");
      PromptShower.__c__DisplayClass9_0.NativeFieldInfoPtr_insert = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PromptShower.__c__DisplayClass9_0>.NativeClassPtr, nameof (insert));
      PromptShower.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PromptShower.__c__DisplayClass9_0>.NativeClassPtr, 100667622);
      PromptShower.__c__DisplayClass9_0.NativeMethodInfoPtr__Show_b__0_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PromptShower.__c__DisplayClass9_0>.NativeClassPtr, 100667623);
      PromptShower.__c__DisplayClass9_0.NativeMethodInfoPtr__Show_b__1_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PromptShower.__c__DisplayClass9_0>.NativeClassPtr, 100667624);
    }

    public __c__DisplayClass9_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe PromptShower __4__this
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PromptShower.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this));
        return pointer == System.IntPtr.Zero ? (PromptShower) null : new PromptShower(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PromptShower.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppSystem.Object insert
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PromptShower.__c__DisplayClass9_0.NativeFieldInfoPtr_insert));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PromptShower.__c__DisplayClass9_0.NativeFieldInfoPtr_insert), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
