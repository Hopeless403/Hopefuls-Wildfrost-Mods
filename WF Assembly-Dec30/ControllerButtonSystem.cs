// Decompiled with JetBrains decompiler
// Type: ControllerButtonSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Rewired;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Localization;

#nullable disable
public class ControllerButtonSystem : GameSystem
{
  private static readonly System.IntPtr NativeFieldInfoPtr_instance;
  private static readonly System.IntPtr NativeFieldInfoPtr_style;
  private static readonly System.IntPtr NativeFieldInfoPtr_defaultControllerStyle;
  private static readonly System.IntPtr NativeFieldInfoPtr_mouseStyle;
  private static readonly System.IntPtr NativeFieldInfoPtr_touchStyle;
  private static readonly System.IntPtr NativeFieldInfoPtr_styles;
  private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ControllerSwitched_Private_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetMouseStyle_Public_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetTouchStyle_Public_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetControllerStyle_Public_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Static_Sprite_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetElement_Public_Static_ElementButton_Player_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ProcessActionTags_Public_Static_String_LocalizedString_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ProcessActionTags_Public_Static_String_String_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58475, XrefRangeEnd = 58479, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ControllerButtonSystem.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58479, XrefRangeEnd = 58487, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ControllerButtonSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58487, XrefRangeEnd = 58495, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ControllerButtonSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58495, XrefRangeEnd = 58500, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void ControllerSwitched()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ControllerButtonSystem.NativeMethodInfoPtr_ControllerSwitched_Private_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 58506, RefRangeEnd = 58507, XrefRangeStart = 58500, XrefRangeEnd = 58506, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetMouseStyle()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ControllerButtonSystem.NativeMethodInfoPtr_SetMouseStyle_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 58513, RefRangeEnd = 58514, XrefRangeStart = 58507, XrefRangeEnd = 58513, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetTouchStyle()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ControllerButtonSystem.NativeMethodInfoPtr_SetTouchStyle_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 58571, RefRangeEnd = 58573, XrefRangeStart = 58514, XrefRangeEnd = 58571, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetControllerStyle()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ControllerButtonSystem.NativeMethodInfoPtr_SetControllerStyle_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 58581, RefRangeEnd = 58583, XrefRangeStart = 58573, XrefRangeEnd = 58581, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Sprite Get(string action)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(action)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ControllerButtonSystem.NativeMethodInfoPtr_Get_Public_Static_Sprite_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (Sprite) null : new Sprite(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 58587, RefRangeEnd = 58588, XrefRangeStart = 58583, XrefRangeEnd = 58587, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe JoystickButtonStyle.ElementButton GetElement(
    Player player,
    string actionName)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) player);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(actionName);
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ControllerButtonSystem.NativeMethodInfoPtr_GetElement_Public_Static_ElementButton_Player_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (JoystickButtonStyle.ElementButton) null : new JoystickButtonStyle.ElementButton(pointer);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 58591, RefRangeEnd = 58596, XrefRangeStart = 58588, XrefRangeEnd = 58591, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string ProcessActionTags(LocalizedString key, bool preferTextActions = true)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) key);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &preferTextActions;
    System.IntPtr exc;
    System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(ControllerButtonSystem.NativeMethodInfoPtr_ProcessActionTags_Public_Static_String_LocalizedString_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return IL2CPP.Il2CppStringToManaged(il2CppString);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 58649, RefRangeEnd = 58650, XrefRangeStart = 58596, XrefRangeEnd = 58649, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string ProcessActionTags(string text, bool preferTextActions)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(text);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &preferTextActions;
    System.IntPtr exc;
    System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(ControllerButtonSystem.NativeMethodInfoPtr_ProcessActionTags_Public_Static_String_String_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return IL2CPP.Il2CppStringToManaged(il2CppString);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 21168, RefRangeEnd = 21171, XrefRangeStart = 21168, XrefRangeEnd = 21171, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ControllerButtonSystem()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerButtonSystem>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ControllerButtonSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static ControllerButtonSystem()
  {
    Il2CppClassPointerStore<ControllerButtonSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (ControllerButtonSystem));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControllerButtonSystem>.NativeClassPtr);
    ControllerButtonSystem.NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerButtonSystem>.NativeClassPtr, nameof (instance));
    ControllerButtonSystem.NativeFieldInfoPtr_style = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerButtonSystem>.NativeClassPtr, nameof (style));
    ControllerButtonSystem.NativeFieldInfoPtr_defaultControllerStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerButtonSystem>.NativeClassPtr, nameof (defaultControllerStyle));
    ControllerButtonSystem.NativeFieldInfoPtr_mouseStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerButtonSystem>.NativeClassPtr, nameof (mouseStyle));
    ControllerButtonSystem.NativeFieldInfoPtr_touchStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerButtonSystem>.NativeClassPtr, nameof (touchStyle));
    ControllerButtonSystem.NativeFieldInfoPtr_styles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerButtonSystem>.NativeClassPtr, nameof (styles));
    ControllerButtonSystem.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerButtonSystem>.NativeClassPtr, 100668081);
    ControllerButtonSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerButtonSystem>.NativeClassPtr, 100668082);
    ControllerButtonSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerButtonSystem>.NativeClassPtr, 100668083);
    ControllerButtonSystem.NativeMethodInfoPtr_ControllerSwitched_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerButtonSystem>.NativeClassPtr, 100668084);
    ControllerButtonSystem.NativeMethodInfoPtr_SetMouseStyle_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerButtonSystem>.NativeClassPtr, 100668085);
    ControllerButtonSystem.NativeMethodInfoPtr_SetTouchStyle_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerButtonSystem>.NativeClassPtr, 100668086);
    ControllerButtonSystem.NativeMethodInfoPtr_SetControllerStyle_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerButtonSystem>.NativeClassPtr, 100668087);
    ControllerButtonSystem.NativeMethodInfoPtr_Get_Public_Static_Sprite_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerButtonSystem>.NativeClassPtr, 100668088);
    ControllerButtonSystem.NativeMethodInfoPtr_GetElement_Public_Static_ElementButton_Player_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerButtonSystem>.NativeClassPtr, 100668089);
    ControllerButtonSystem.NativeMethodInfoPtr_ProcessActionTags_Public_Static_String_LocalizedString_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerButtonSystem>.NativeClassPtr, 100668090);
    ControllerButtonSystem.NativeMethodInfoPtr_ProcessActionTags_Public_Static_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerButtonSystem>.NativeClassPtr, 100668091);
    ControllerButtonSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerButtonSystem>.NativeClassPtr, 100668092);
  }

  public ControllerButtonSystem(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe ControllerButtonSystem instance
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ControllerButtonSystem.NativeFieldInfoPtr_instance, (void*) &num);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (ControllerButtonSystem) null : new ControllerButtonSystem(pointer);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ControllerButtonSystem.NativeFieldInfoPtr_instance, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe JoystickButtonStyle style
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ControllerButtonSystem.NativeFieldInfoPtr_style, (void*) &num);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (JoystickButtonStyle) null : new JoystickButtonStyle(pointer);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ControllerButtonSystem.NativeFieldInfoPtr_style, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe JoystickButtonStyle defaultControllerStyle
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControllerButtonSystem.NativeFieldInfoPtr_defaultControllerStyle));
      return pointer == System.IntPtr.Zero ? (JoystickButtonStyle) null : new JoystickButtonStyle(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ControllerButtonSystem.NativeFieldInfoPtr_defaultControllerStyle), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe JoystickButtonStyle mouseStyle
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControllerButtonSystem.NativeFieldInfoPtr_mouseStyle));
      return pointer == System.IntPtr.Zero ? (JoystickButtonStyle) null : new JoystickButtonStyle(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ControllerButtonSystem.NativeFieldInfoPtr_mouseStyle), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe JoystickButtonStyle touchStyle
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControllerButtonSystem.NativeFieldInfoPtr_touchStyle));
      return pointer == System.IntPtr.Zero ? (JoystickButtonStyle) null : new JoystickButtonStyle(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ControllerButtonSystem.NativeFieldInfoPtr_touchStyle), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<JoystickButtonStyle> styles
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControllerButtonSystem.NativeFieldInfoPtr_styles));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<JoystickButtonStyle>) null : new Il2CppReferenceArray<JoystickButtonStyle>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ControllerButtonSystem.NativeFieldInfoPtr_styles), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [ObfuscatedName("ControllerButtonSystem/<>c__DisplayClass12_0")]
  public sealed class __c__DisplayClass12_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_controller;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__SetControllerStyle_b__0_Internal_Boolean_JoystickButtonStyle_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass12_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerButtonSystem.__c__DisplayClass12_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ControllerButtonSystem.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58470, XrefRangeEnd = 58475, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _SetControllerStyle_b__0(JoystickButtonStyle a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ControllerButtonSystem.__c__DisplayClass12_0.NativeMethodInfoPtr__SetControllerStyle_b__0_Internal_Boolean_JoystickButtonStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c__DisplayClass12_0()
    {
      Il2CppClassPointerStore<ControllerButtonSystem.__c__DisplayClass12_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ControllerButtonSystem>.NativeClassPtr, "<>c__DisplayClass12_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControllerButtonSystem.__c__DisplayClass12_0>.NativeClassPtr);
      ControllerButtonSystem.__c__DisplayClass12_0.NativeFieldInfoPtr_controller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerButtonSystem.__c__DisplayClass12_0>.NativeClassPtr, nameof (controller));
      ControllerButtonSystem.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerButtonSystem.__c__DisplayClass12_0>.NativeClassPtr, 100668093);
      ControllerButtonSystem.__c__DisplayClass12_0.NativeMethodInfoPtr__SetControllerStyle_b__0_Internal_Boolean_JoystickButtonStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerButtonSystem.__c__DisplayClass12_0>.NativeClassPtr, 100668094);
    }

    public __c__DisplayClass12_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Controller controller
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControllerButtonSystem.__c__DisplayClass12_0.NativeFieldInfoPtr_controller));
        return pointer == System.IntPtr.Zero ? (Controller) null : new Controller(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ControllerButtonSystem.__c__DisplayClass12_0.NativeFieldInfoPtr_controller), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
