// Decompiled with JetBrains decompiler
// Type: JournalIconGroup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
public class JournalIconGroup : MonoBehaviour
{
  private static readonly System.IntPtr NativeFieldInfoPtr_buttons;
  private static readonly System.IntPtr NativeFieldInfoPtr_icons;
  private static readonly System.IntPtr NativeFieldInfoPtr_baseColour;
  private static readonly System.IntPtr NativeFieldInfoPtr_highlightColour;
  private static readonly System.IntPtr NativeFieldInfoPtr_currentHover;
  private static readonly System.IntPtr NativeFieldInfoPtr_highlightedIcon;
  private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Changed_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91299, XrefRangeEnd = 91300, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(JournalIconGroup.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91300, XrefRangeEnd = 91311, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(JournalIconGroup.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 91322, RefRangeEnd = 91323, XrefRangeStart = 91311, XrefRangeEnd = 91322, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Changed()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(JournalIconGroup.NativeMethodInfoPtr_Changed_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91323, XrefRangeEnd = 91324, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe JournalIconGroup()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JournalIconGroup>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(JournalIconGroup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static JournalIconGroup()
  {
    Il2CppClassPointerStore<JournalIconGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (JournalIconGroup));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JournalIconGroup>.NativeClassPtr);
    JournalIconGroup.NativeFieldInfoPtr_buttons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalIconGroup>.NativeClassPtr, nameof (buttons));
    JournalIconGroup.NativeFieldInfoPtr_icons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalIconGroup>.NativeClassPtr, nameof (icons));
    JournalIconGroup.NativeFieldInfoPtr_baseColour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalIconGroup>.NativeClassPtr, nameof (baseColour));
    JournalIconGroup.NativeFieldInfoPtr_highlightColour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalIconGroup>.NativeClassPtr, nameof (highlightColour));
    JournalIconGroup.NativeFieldInfoPtr_currentHover = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalIconGroup>.NativeClassPtr, nameof (currentHover));
    JournalIconGroup.NativeFieldInfoPtr_highlightedIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalIconGroup>.NativeClassPtr, nameof (highlightedIcon));
    JournalIconGroup.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalIconGroup>.NativeClassPtr, 100671144);
    JournalIconGroup.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalIconGroup>.NativeClassPtr, 100671145);
    JournalIconGroup.NativeMethodInfoPtr_Changed_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalIconGroup>.NativeClassPtr, 100671146);
    JournalIconGroup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalIconGroup>.NativeClassPtr, 100671147);
  }

  public JournalIconGroup(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe List<ButtonAnimator> buttons
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalIconGroup.NativeFieldInfoPtr_buttons));
      return pointer == System.IntPtr.Zero ? (List<ButtonAnimator>) null : new List<ButtonAnimator>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JournalIconGroup.NativeFieldInfoPtr_buttons), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<Image> icons
  {
    get
    {
      System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalIconGroup.NativeFieldInfoPtr_icons));
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<Image>) null : new Il2CppReferenceArray<Image>(nativeObject);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JournalIconGroup.NativeFieldInfoPtr_icons), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Color baseColour
  {
    get
    {
      return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalIconGroup.NativeFieldInfoPtr_baseColour));
    }
    [param: In] set
    {
      *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalIconGroup.NativeFieldInfoPtr_baseColour)) = value;
    }
  }

  public unsafe Color highlightColour
  {
    get
    {
      return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalIconGroup.NativeFieldInfoPtr_highlightColour));
    }
    [param: In] set
    {
      *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalIconGroup.NativeFieldInfoPtr_highlightColour)) = value;
    }
  }

  public unsafe ButtonAnimator currentHover
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalIconGroup.NativeFieldInfoPtr_currentHover));
      return pointer == System.IntPtr.Zero ? (ButtonAnimator) null : new ButtonAnimator(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JournalIconGroup.NativeFieldInfoPtr_currentHover), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Image highlightedIcon
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalIconGroup.NativeFieldInfoPtr_highlightedIcon));
      return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JournalIconGroup.NativeFieldInfoPtr_highlightedIcon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [ObfuscatedName("JournalIconGroup/<>c")]
  [Serializable]
  public sealed class __c : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__7_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Update_b__7_0_Internal_Boolean_ButtonAnimator_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JournalIconGroup.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(JournalIconGroup.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91297, XrefRangeEnd = 91299, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _Update_b__7_0(ButtonAnimator a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(JournalIconGroup.__c.NativeMethodInfoPtr__Update_b__7_0_Internal_Boolean_ButtonAnimator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c()
    {
      Il2CppClassPointerStore<JournalIconGroup.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JournalIconGroup>.NativeClassPtr, "<>c");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JournalIconGroup.__c>.NativeClassPtr);
      JournalIconGroup.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalIconGroup.__c>.NativeClassPtr, "<>9");
      JournalIconGroup.__c.NativeFieldInfoPtr___9__7_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalIconGroup.__c>.NativeClassPtr, "<>9__7_0");
      JournalIconGroup.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalIconGroup.__c>.NativeClassPtr, 100671149);
      JournalIconGroup.__c.NativeMethodInfoPtr__Update_b__7_0_Internal_Boolean_ButtonAnimator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalIconGroup.__c>.NativeClassPtr, 100671150);
    }

    public __c(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe JournalIconGroup.__c __9
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(JournalIconGroup.__c.NativeFieldInfoPtr___9, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (JournalIconGroup.__c) null : new JournalIconGroup.__c(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(JournalIconGroup.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<ButtonAnimator, bool> __9__7_0
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(JournalIconGroup.__c.NativeFieldInfoPtr___9__7_0, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<ButtonAnimator, bool>) null : new Il2CppSystem.Func<ButtonAnimator, bool>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(JournalIconGroup.__c.NativeFieldInfoPtr___9__7_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
