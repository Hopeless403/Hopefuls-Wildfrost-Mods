// Decompiled with JetBrains decompiler
// Type: JournalNameHistory
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public static class JournalNameHistory : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr_maxEntries;
  private static readonly System.IntPtr NativeFieldInfoPtr_fadePrevious;
  private static readonly System.IntPtr NativeFieldInfoPtr_startPos;
  private static readonly System.IntPtr NativeFieldInfoPtr_spacing;
  private static readonly System.IntPtr NativeFieldInfoPtr_bounds;
  private static readonly System.IntPtr NativeFieldInfoPtr_randomOffset;
  private static readonly System.IntPtr NativeFieldInfoPtr_randomAngle;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddName_Public_Static_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FadePrevious_Public_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MostRecentNameKilled_Public_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MostRecentNameMissing_Public_Static_Void_0;

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 115992, RefRangeEnd = 115993, XrefRangeStart = 115941, XrefRangeEnd = 115992, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void AddName(string name)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(name)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(JournalNameHistory.NativeMethodInfoPtr_AddName_Public_Static_Void_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 116026, RefRangeEnd = 116027, XrefRangeStart = 115993, XrefRangeEnd = 116026, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void FadePrevious()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(JournalNameHistory.NativeMethodInfoPtr_FadePrevious_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 116045, RefRangeEnd = 116050, XrefRangeStart = 116027, XrefRangeEnd = 116045, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void MostRecentNameKilled()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(JournalNameHistory.NativeMethodInfoPtr_MostRecentNameKilled_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 116068, RefRangeEnd = 116069, XrefRangeStart = 116050, XrefRangeEnd = 116068, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void MostRecentNameMissing()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(JournalNameHistory.NativeMethodInfoPtr_MostRecentNameMissing_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static JournalNameHistory()
  {
    Il2CppClassPointerStore<JournalNameHistory>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (JournalNameHistory));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JournalNameHistory>.NativeClassPtr);
    JournalNameHistory.NativeFieldInfoPtr_maxEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalNameHistory>.NativeClassPtr, nameof (maxEntries));
    JournalNameHistory.NativeFieldInfoPtr_fadePrevious = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalNameHistory>.NativeClassPtr, nameof (fadePrevious));
    JournalNameHistory.NativeFieldInfoPtr_startPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalNameHistory>.NativeClassPtr, nameof (startPos));
    JournalNameHistory.NativeFieldInfoPtr_spacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalNameHistory>.NativeClassPtr, nameof (spacing));
    JournalNameHistory.NativeFieldInfoPtr_bounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalNameHistory>.NativeClassPtr, nameof (bounds));
    JournalNameHistory.NativeFieldInfoPtr_randomOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalNameHistory>.NativeClassPtr, nameof (randomOffset));
    JournalNameHistory.NativeFieldInfoPtr_randomAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalNameHistory>.NativeClassPtr, nameof (randomAngle));
    JournalNameHistory.NativeMethodInfoPtr_AddName_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalNameHistory>.NativeClassPtr, 100674292);
    JournalNameHistory.NativeMethodInfoPtr_FadePrevious_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalNameHistory>.NativeClassPtr, 100674293);
    JournalNameHistory.NativeMethodInfoPtr_MostRecentNameKilled_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalNameHistory>.NativeClassPtr, 100674294);
    JournalNameHistory.NativeMethodInfoPtr_MostRecentNameMissing_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalNameHistory>.NativeClassPtr, 100674295);
  }

  public JournalNameHistory(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe int maxEntries
  {
    get
    {
      int maxEntries;
      IL2CPP.il2cpp_field_static_get_value(JournalNameHistory.NativeFieldInfoPtr_maxEntries, (void*) &maxEntries);
      return maxEntries;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(JournalNameHistory.NativeFieldInfoPtr_maxEntries, (void*) &value);
    }
  }

  public static unsafe float fadePrevious
  {
    get
    {
      float fadePrevious;
      IL2CPP.il2cpp_field_static_get_value(JournalNameHistory.NativeFieldInfoPtr_fadePrevious, (void*) &fadePrevious);
      return fadePrevious;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(JournalNameHistory.NativeFieldInfoPtr_fadePrevious, (void*) &value);
    }
  }

  public static unsafe Vector2 startPos
  {
    get
    {
      Vector2 startPos;
      IL2CPP.il2cpp_field_static_get_value(JournalNameHistory.NativeFieldInfoPtr_startPos, (void*) &startPos);
      return startPos;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(JournalNameHistory.NativeFieldInfoPtr_startPos, (void*) &value);
    }
  }

  public static unsafe Vector2 spacing
  {
    get
    {
      Vector2 spacing;
      IL2CPP.il2cpp_field_static_get_value(JournalNameHistory.NativeFieldInfoPtr_spacing, (void*) &spacing);
      return spacing;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(JournalNameHistory.NativeFieldInfoPtr_spacing, (void*) &value);
    }
  }

  public static unsafe Vector2 bounds
  {
    get
    {
      Vector2 bounds;
      IL2CPP.il2cpp_field_static_get_value(JournalNameHistory.NativeFieldInfoPtr_bounds, (void*) &bounds);
      return bounds;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(JournalNameHistory.NativeFieldInfoPtr_bounds, (void*) &value);
    }
  }

  public static unsafe Vector2 randomOffset
  {
    get
    {
      Vector2 randomOffset;
      IL2CPP.il2cpp_field_static_get_value(JournalNameHistory.NativeFieldInfoPtr_randomOffset, (void*) &randomOffset);
      return randomOffset;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(JournalNameHistory.NativeFieldInfoPtr_randomOffset, (void*) &value);
    }
  }

  public static unsafe float randomAngle
  {
    get
    {
      float randomAngle;
      IL2CPP.il2cpp_field_static_get_value(JournalNameHistory.NativeFieldInfoPtr_randomAngle, (void*) &randomAngle);
      return randomAngle;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(JournalNameHistory.NativeFieldInfoPtr_randomAngle, (void*) &value);
    }
  }

  [Serializable]
  public class Name : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_text;
    private static readonly System.IntPtr NativeFieldInfoPtr_killed;
    private static readonly System.IntPtr NativeFieldInfoPtr_missing;
    private static readonly System.IntPtr NativeFieldInfoPtr_opacity;
    private static readonly System.IntPtr NativeFieldInfoPtr_position;
    private static readonly System.IntPtr NativeFieldInfoPtr_offset;
    private static readonly System.IntPtr NativeFieldInfoPtr_angle;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Vector2_Single_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Name()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JournalNameHistory.Name>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(JournalNameHistory.Name.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115936, XrefRangeEnd = 115941, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Name(string text, Vector2 randomOffset, float randomAngle)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JournalNameHistory.Name>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(text);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &randomOffset;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &randomAngle;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(JournalNameHistory.Name.NativeMethodInfoPtr__ctor_Public_Void_String_Vector2_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Name()
    {
      Il2CppClassPointerStore<JournalNameHistory.Name>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JournalNameHistory>.NativeClassPtr, nameof (Name));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JournalNameHistory.Name>.NativeClassPtr);
      JournalNameHistory.Name.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalNameHistory.Name>.NativeClassPtr, nameof (text));
      JournalNameHistory.Name.NativeFieldInfoPtr_killed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalNameHistory.Name>.NativeClassPtr, nameof (killed));
      JournalNameHistory.Name.NativeFieldInfoPtr_missing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalNameHistory.Name>.NativeClassPtr, nameof (missing));
      JournalNameHistory.Name.NativeFieldInfoPtr_opacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalNameHistory.Name>.NativeClassPtr, nameof (opacity));
      JournalNameHistory.Name.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalNameHistory.Name>.NativeClassPtr, nameof (position));
      JournalNameHistory.Name.NativeFieldInfoPtr_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalNameHistory.Name>.NativeClassPtr, nameof (offset));
      JournalNameHistory.Name.NativeFieldInfoPtr_angle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalNameHistory.Name>.NativeClassPtr, nameof (angle));
      JournalNameHistory.Name.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalNameHistory.Name>.NativeClassPtr, 100674297);
      JournalNameHistory.Name.NativeMethodInfoPtr__ctor_Public_Void_String_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalNameHistory.Name>.NativeClassPtr, 100674298);
    }

    public Name(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe string text
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalNameHistory.Name.NativeFieldInfoPtr_text)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JournalNameHistory.Name.NativeFieldInfoPtr_text), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe bool killed
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalNameHistory.Name.NativeFieldInfoPtr_killed));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalNameHistory.Name.NativeFieldInfoPtr_killed)) = value;
      }
    }

    public unsafe bool missing
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalNameHistory.Name.NativeFieldInfoPtr_missing));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalNameHistory.Name.NativeFieldInfoPtr_missing)) = value;
      }
    }

    public unsafe float opacity
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalNameHistory.Name.NativeFieldInfoPtr_opacity));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalNameHistory.Name.NativeFieldInfoPtr_opacity)) = value;
      }
    }

    public unsafe Vector2 position
    {
      get
      {
        return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalNameHistory.Name.NativeFieldInfoPtr_position));
      }
      [param: In] set
      {
        *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalNameHistory.Name.NativeFieldInfoPtr_position)) = value;
      }
    }

    public unsafe Vector2 offset
    {
      get
      {
        return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalNameHistory.Name.NativeFieldInfoPtr_offset));
      }
      [param: In] set
      {
        *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalNameHistory.Name.NativeFieldInfoPtr_offset)) = value;
      }
    }

    public unsafe float angle
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalNameHistory.Name.NativeFieldInfoPtr_angle));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalNameHistory.Name.NativeFieldInfoPtr_angle)) = value;
      }
    }
  }
}
