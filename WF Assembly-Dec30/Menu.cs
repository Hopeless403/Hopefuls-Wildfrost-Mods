// Decompiled with JetBrains decompiler
// Type: Menu
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class Menu : MonoBehaviour
{
  private static readonly System.IntPtr NativeFieldInfoPtr_retryTutorialHelp;
  private static readonly System.IntPtr NativeFieldInfoPtr_active;
  private static readonly System.IntPtr NativeMethodInfoPtr_GoTo_Public_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_StartGameOrContinue_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_StartGameOrContinue_Public_Void_String_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_StartGame_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_StartGame_Public_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_StartGame_Public_Void_GameMode_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GoToTown_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ExitGame_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Open_Public_Virtual_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Close_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Toggle_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 92348, RefRangeEnd = 92352, XrefRangeStart = 92343, XrefRangeEnd = 92348, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void GoTo(string sceneName)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(sceneName)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Menu.NativeMethodInfoPtr_GoTo_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92352, XrefRangeEnd = 92355, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void StartGameOrContinue()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Menu.NativeMethodInfoPtr_StartGameOrContinue_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 92402, RefRangeEnd = 92404, XrefRangeStart = 92355, XrefRangeEnd = 92402, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void StartGameOrContinue(string gameModeName, bool skipTutorial = false)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(gameModeName);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &skipTutorial;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Menu.NativeMethodInfoPtr_StartGameOrContinue_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92404, XrefRangeEnd = 92407, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void StartGame()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Menu.NativeMethodInfoPtr_StartGame_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 92416, RefRangeEnd = 92419, XrefRangeStart = 92407, XrefRangeEnd = 92416, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void StartGame(string gameModeName)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(gameModeName)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Menu.NativeMethodInfoPtr_StartGame_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 92434, RefRangeEnd = 92435, XrefRangeStart = 92419, XrefRangeEnd = 92434, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void StartGame(GameMode gameMode)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameMode)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Menu.NativeMethodInfoPtr_StartGame_Public_Void_GameMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92435, XrefRangeEnd = 92438, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void GoToTown()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Menu.NativeMethodInfoPtr_GoToTown_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92438, XrefRangeEnd = 92442, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ExitGame()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Menu.NativeMethodInfoPtr_ExitGame_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92442, XrefRangeEnd = 92444, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Open()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Menu.NativeMethodInfoPtr_Open_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92444, XrefRangeEnd = 92446, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Close()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Menu.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92446, XrefRangeEnd = 92450, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Toggle()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Menu.NativeMethodInfoPtr_Toggle_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Menu()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Menu>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(Menu.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static Menu()
  {
    Il2CppClassPointerStore<Menu>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (Menu));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Menu>.NativeClassPtr);
    Menu.NativeFieldInfoPtr_retryTutorialHelp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Menu>.NativeClassPtr, nameof (retryTutorialHelp));
    Menu.NativeFieldInfoPtr_active = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Menu>.NativeClassPtr, nameof (active));
    Menu.NativeMethodInfoPtr_GoTo_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Menu>.NativeClassPtr, 100671271);
    Menu.NativeMethodInfoPtr_StartGameOrContinue_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Menu>.NativeClassPtr, 100671272);
    Menu.NativeMethodInfoPtr_StartGameOrContinue_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Menu>.NativeClassPtr, 100671273);
    Menu.NativeMethodInfoPtr_StartGame_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Menu>.NativeClassPtr, 100671274);
    Menu.NativeMethodInfoPtr_StartGame_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Menu>.NativeClassPtr, 100671275);
    Menu.NativeMethodInfoPtr_StartGame_Public_Void_GameMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Menu>.NativeClassPtr, 100671276);
    Menu.NativeMethodInfoPtr_GoToTown_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Menu>.NativeClassPtr, 100671277);
    Menu.NativeMethodInfoPtr_ExitGame_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Menu>.NativeClassPtr, 100671278);
    Menu.NativeMethodInfoPtr_Open_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Menu>.NativeClassPtr, 100671279);
    Menu.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Menu>.NativeClassPtr, 100671280);
    Menu.NativeMethodInfoPtr_Toggle_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Menu>.NativeClassPtr, 100671281);
    Menu.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Menu>.NativeClassPtr, 100671282);
  }

  public Menu(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe HelpPanelShower retryTutorialHelp
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Menu.NativeFieldInfoPtr_retryTutorialHelp));
      return pointer == System.IntPtr.Zero ? (HelpPanelShower) null : new HelpPanelShower(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Menu.NativeFieldInfoPtr_retryTutorialHelp), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool active
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Menu.NativeFieldInfoPtr_active));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Menu.NativeFieldInfoPtr_active)) = value;
    }
  }

  [ObfuscatedName("Menu/<>c__DisplayClass4_0")]
  public sealed class __c__DisplayClass4_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr_gameModeName;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__StartGameOrContinue_b__0_Internal_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__StartGameOrContinue_b__1_Internal_Void_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass4_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Menu.__c__DisplayClass4_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Menu.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92328, XrefRangeEnd = 92332, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _StartGameOrContinue_b__0()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Menu.__c__DisplayClass4_0.NativeMethodInfoPtr__StartGameOrContinue_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92332, XrefRangeEnd = 92343, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _StartGameOrContinue_b__1()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Menu.__c__DisplayClass4_0.NativeMethodInfoPtr__StartGameOrContinue_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static __c__DisplayClass4_0()
    {
      Il2CppClassPointerStore<Menu.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Menu>.NativeClassPtr, "<>c__DisplayClass4_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Menu.__c__DisplayClass4_0>.NativeClassPtr);
      Menu.__c__DisplayClass4_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Menu.__c__DisplayClass4_0>.NativeClassPtr, "<>4__this");
      Menu.__c__DisplayClass4_0.NativeFieldInfoPtr_gameModeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Menu.__c__DisplayClass4_0>.NativeClassPtr, nameof (gameModeName));
      Menu.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Menu.__c__DisplayClass4_0>.NativeClassPtr, 100671283);
      Menu.__c__DisplayClass4_0.NativeMethodInfoPtr__StartGameOrContinue_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Menu.__c__DisplayClass4_0>.NativeClassPtr, 100671284);
      Menu.__c__DisplayClass4_0.NativeMethodInfoPtr__StartGameOrContinue_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Menu.__c__DisplayClass4_0>.NativeClassPtr, 100671285);
    }

    public __c__DisplayClass4_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Menu __4__this
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Menu.__c__DisplayClass4_0.NativeFieldInfoPtr___4__this));
        return pointer == System.IntPtr.Zero ? (Menu) null : new Menu(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Menu.__c__DisplayClass4_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe string gameModeName
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Menu.__c__DisplayClass4_0.NativeFieldInfoPtr_gameModeName)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Menu.__c__DisplayClass4_0.NativeFieldInfoPtr_gameModeName), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }
}
