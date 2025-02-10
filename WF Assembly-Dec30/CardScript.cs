// Decompiled with JetBrains decompiler
// Type: CardScript
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using UnityEngine;

#nullable disable
public class CardScript : ScriptableObject
{
  private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_New_Void_CardData_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

  [CallerCount(12611)]
  [CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12665, XrefRangeStart = 54, XrefRangeEnd = 12665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Run(CardData target)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CardScript.NativeMethodInfoPtr_Run_Public_Virtual_New_Void_CardData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(110)]
  [CachedScanResults(RefRangeStart = 104608, RefRangeEnd = 104718, XrefRangeStart = 104608, XrefRangeEnd = 104718, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CardScript()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardScript>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(CardScript.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static CardScript()
  {
    Il2CppClassPointerStore<CardScript>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (CardScript));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardScript>.NativeClassPtr);
    CardScript.NativeMethodInfoPtr_Run_Public_Virtual_New_Void_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardScript>.NativeClassPtr, 100673242);
    CardScript.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardScript>.NativeClassPtr, 100673243);
  }

  public CardScript(IntPtr pointer)
    : base(pointer)
  {
  }
}
