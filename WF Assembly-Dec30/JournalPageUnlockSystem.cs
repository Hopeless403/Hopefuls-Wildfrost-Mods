// Decompiled with JetBrains decompiler
// Type: JournalPageUnlockSystem
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
public class JournalPageUnlockSystem : GameSystem
{
  private static readonly IntPtr NativeFieldInfoPtr_pages;
  private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_InsertJournalPages_Private_Void_byref_Il2CppStringArray_0;
  private static readonly IntPtr NativeMethodInfoPtr_IsLegal_Private_Static_Boolean_JournalPageData_0;
  private static readonly IntPtr NativeMethodInfoPtr_HasRequiredStormPoints_Private_Static_Boolean_JournalPageData_0;
  private static readonly IntPtr NativeMethodInfoPtr_HasRequiredModifiers_Private_Static_Boolean_JournalPageData_0;
  private static readonly IntPtr NativeMethodInfoPtr_CreateNode_Private_Static_Node_Single_Single_String_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62704, XrefRangeEnd = 62712, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(JournalPageUnlockSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62712, XrefRangeEnd = 62720, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(JournalPageUnlockSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62720, XrefRangeEnd = 62752, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void InsertJournalPages(ref Il2CppStringArray lines)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr1 = stackalloc IntPtr[1];
    IntPtr* numPtr2 = numPtr1;
    IntPtr il2Cpp = IL2CPP.ManagedStringToIl2Cpp((string) lines);
    IntPtr* numPtr3 = &il2Cpp;
    *numPtr2 = (IntPtr) numPtr3;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(JournalPageUnlockSystem.NativeMethodInfoPtr_InsertJournalPages_Private_Void_byref_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    ref Il2CppStringArray local = ref lines;
    IntPtr pointer = il2Cpp;
    Il2CppStringArray il2CppStringArray = pointer == IntPtr.Zero ? (Il2CppStringArray) null : new Il2CppStringArray(pointer);
    local = il2CppStringArray;
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 62770, RefRangeEnd = 62771, XrefRangeStart = 62752, XrefRangeEnd = 62770, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool IsLegal(JournalPageData page)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) page)
    };
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(JournalPageUnlockSystem.NativeMethodInfoPtr_IsLegal_Private_Static_Boolean_JournalPageData_0, IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62771, XrefRangeEnd = 62773, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool HasRequiredStormPoints(JournalPageData page)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) page)
    };
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(JournalPageUnlockSystem.NativeMethodInfoPtr_HasRequiredStormPoints_Private_Static_Boolean_JournalPageData_0, IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62773, XrefRangeEnd = 62777, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool HasRequiredModifiers(JournalPageData page)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) page)
    };
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(JournalPageUnlockSystem.NativeMethodInfoPtr_HasRequiredModifiers_Private_Static_Boolean_JournalPageData_0, IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62777, XrefRangeEnd = 62782, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe CampaignGenerator.Node CreateNode(
    float x,
    float y,
    string type,
    int positionIndex)
  {
    IntPtr* numPtr = stackalloc IntPtr[4];
    numPtr[0] = (IntPtr) &x;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &y;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(type);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &positionIndex;
    IntPtr exc;
    IntPtr num = IL2CPP.il2cpp_runtime_invoke(JournalPageUnlockSystem.NativeMethodInfoPtr_CreateNode_Private_Static_Node_Single_Single_String_Int32_0, IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    IntPtr pointer = num;
    return pointer == IntPtr.Zero ? (CampaignGenerator.Node) null : new CampaignGenerator.Node(pointer);
  }

  [CallerCount(212)]
  [CachedScanResults(RefRangeStart = 12749, RefRangeEnd = 12961, XrefRangeStart = 12749, XrefRangeEnd = 12961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe JournalPageUnlockSystem()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JournalPageUnlockSystem>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(JournalPageUnlockSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static JournalPageUnlockSystem()
  {
    Il2CppClassPointerStore<JournalPageUnlockSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (JournalPageUnlockSystem));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JournalPageUnlockSystem>.NativeClassPtr);
    JournalPageUnlockSystem.NativeFieldInfoPtr_pages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalPageUnlockSystem>.NativeClassPtr, nameof (pages));
    JournalPageUnlockSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalPageUnlockSystem>.NativeClassPtr, 100668410);
    JournalPageUnlockSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalPageUnlockSystem>.NativeClassPtr, 100668411);
    JournalPageUnlockSystem.NativeMethodInfoPtr_InsertJournalPages_Private_Void_byref_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalPageUnlockSystem>.NativeClassPtr, 100668412);
    JournalPageUnlockSystem.NativeMethodInfoPtr_IsLegal_Private_Static_Boolean_JournalPageData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalPageUnlockSystem>.NativeClassPtr, 100668413);
    JournalPageUnlockSystem.NativeMethodInfoPtr_HasRequiredStormPoints_Private_Static_Boolean_JournalPageData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalPageUnlockSystem>.NativeClassPtr, 100668414);
    JournalPageUnlockSystem.NativeMethodInfoPtr_HasRequiredModifiers_Private_Static_Boolean_JournalPageData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalPageUnlockSystem>.NativeClassPtr, 100668415);
    JournalPageUnlockSystem.NativeMethodInfoPtr_CreateNode_Private_Static_Node_Single_Single_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalPageUnlockSystem>.NativeClassPtr, 100668416);
    JournalPageUnlockSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalPageUnlockSystem>.NativeClassPtr, 100668417);
  }

  public JournalPageUnlockSystem(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Il2CppReferenceArray<JournalPageData> pages
  {
    get
    {
      IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalPageUnlockSystem.NativeFieldInfoPtr_pages));
      return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<JournalPageData>) null : new Il2CppReferenceArray<JournalPageData>(nativeObject);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JournalPageUnlockSystem.NativeFieldInfoPtr_pages), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
