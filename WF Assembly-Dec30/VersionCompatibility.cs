// Decompiled with JetBrains decompiler
// Type: VersionCompatibility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class VersionCompatibility : MonoBehaviour
{
  private static readonly System.IntPtr NativeFieldInfoPtr_versionsGot;
  private static readonly System.IntPtr NativeFieldInfoPtr_previousVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_currentVersion;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetVersions_Public_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GameStart_Private_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateBetaProfile_Private_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CopyBetaProfile_Private_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CopyFileFromBetaProfile_Private_Static_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CopyFileData_Private_Static_Void_String_String_ES3Settings_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DeleteDefaultProfile_Private_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ResetProgress_Private_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ResetTownProgress_Private_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ConvertProgressSaveData_Private_Static_Void_ProgressSaveData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DeleteCampaignSave_Private_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100706, XrefRangeEnd = 100714, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(VersionCompatibility.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100714, XrefRangeEnd = 100722, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(VersionCompatibility.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 100741, RefRangeEnd = 100742, XrefRangeStart = 100722, XrefRangeEnd = 100741, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void GetVersions()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(VersionCompatibility.NativeMethodInfoPtr_GetVersions_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100742, XrefRangeEnd = 100985, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void GameStart()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(VersionCompatibility.NativeMethodInfoPtr_GameStart_Private_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100985, XrefRangeEnd = 100994, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void CreateBetaProfile()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(VersionCompatibility.NativeMethodInfoPtr_CreateBetaProfile_Private_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100994, XrefRangeEnd = 101074, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void CopyBetaProfile()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(VersionCompatibility.NativeMethodInfoPtr_CopyBetaProfile_Private_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 101089, RefRangeEnd = 101095, XrefRangeStart = 101074, XrefRangeEnd = 101089, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void CopyFileFromBetaProfile(string fileName)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(fileName)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(VersionCompatibility.NativeMethodInfoPtr_CopyFileFromBetaProfile_Private_Static_Void_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101095, XrefRangeEnd = 101098, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void CopyFileData(string fromPath, string toPath, ES3Settings settings)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(fromPath);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(toPath);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) settings);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(VersionCompatibility.NativeMethodInfoPtr_CopyFileData_Private_Static_Void_String_String_ES3Settings_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101098, XrefRangeEnd = 101104, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DeleteDefaultProfile()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(VersionCompatibility.NativeMethodInfoPtr_DeleteDefaultProfile_Private_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101104, XrefRangeEnd = 101122, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void ResetProgress()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(VersionCompatibility.NativeMethodInfoPtr_ResetProgress_Private_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101122, XrefRangeEnd = 101158, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void ResetTownProgress()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(VersionCompatibility.NativeMethodInfoPtr_ResetTownProgress_Private_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101158, XrefRangeEnd = 101183, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void ConvertProgressSaveData(ProgressSaveData data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(VersionCompatibility.NativeMethodInfoPtr_ConvertProgressSaveData_Private_Static_Void_ProgressSaveData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101183, XrefRangeEnd = 101197, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DeleteCampaignSave()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(VersionCompatibility.NativeMethodInfoPtr_DeleteCampaignSave_Private_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(212)]
  [CachedScanResults(RefRangeStart = 12749, RefRangeEnd = 12961, XrefRangeStart = 12749, XrefRangeEnd = 12961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe VersionCompatibility()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VersionCompatibility>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(VersionCompatibility.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static VersionCompatibility()
  {
    Il2CppClassPointerStore<VersionCompatibility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (VersionCompatibility));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VersionCompatibility>.NativeClassPtr);
    VersionCompatibility.NativeFieldInfoPtr_versionsGot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VersionCompatibility>.NativeClassPtr, nameof (versionsGot));
    VersionCompatibility.NativeFieldInfoPtr_previousVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VersionCompatibility>.NativeClassPtr, nameof (previousVersion));
    VersionCompatibility.NativeFieldInfoPtr_currentVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VersionCompatibility>.NativeClassPtr, nameof (currentVersion));
    VersionCompatibility.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionCompatibility>.NativeClassPtr, 100672347);
    VersionCompatibility.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionCompatibility>.NativeClassPtr, 100672348);
    VersionCompatibility.NativeMethodInfoPtr_GetVersions_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionCompatibility>.NativeClassPtr, 100672349);
    VersionCompatibility.NativeMethodInfoPtr_GameStart_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionCompatibility>.NativeClassPtr, 100672350);
    VersionCompatibility.NativeMethodInfoPtr_CreateBetaProfile_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionCompatibility>.NativeClassPtr, 100672351);
    VersionCompatibility.NativeMethodInfoPtr_CopyBetaProfile_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionCompatibility>.NativeClassPtr, 100672352);
    VersionCompatibility.NativeMethodInfoPtr_CopyFileFromBetaProfile_Private_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionCompatibility>.NativeClassPtr, 100672353);
    VersionCompatibility.NativeMethodInfoPtr_CopyFileData_Private_Static_Void_String_String_ES3Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionCompatibility>.NativeClassPtr, 100672354);
    VersionCompatibility.NativeMethodInfoPtr_DeleteDefaultProfile_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionCompatibility>.NativeClassPtr, 100672355);
    VersionCompatibility.NativeMethodInfoPtr_ResetProgress_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionCompatibility>.NativeClassPtr, 100672356);
    VersionCompatibility.NativeMethodInfoPtr_ResetTownProgress_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionCompatibility>.NativeClassPtr, 100672357);
    VersionCompatibility.NativeMethodInfoPtr_ConvertProgressSaveData_Private_Static_Void_ProgressSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionCompatibility>.NativeClassPtr, 100672358);
    VersionCompatibility.NativeMethodInfoPtr_DeleteCampaignSave_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionCompatibility>.NativeClassPtr, 100672359);
    VersionCompatibility.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionCompatibility>.NativeClassPtr, 100672360);
  }

  public VersionCompatibility(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe bool versionsGot
  {
    get
    {
      bool versionsGot;
      IL2CPP.il2cpp_field_static_get_value(VersionCompatibility.NativeFieldInfoPtr_versionsGot, (void*) &versionsGot);
      return versionsGot;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(VersionCompatibility.NativeFieldInfoPtr_versionsGot, (void*) &value);
    }
  }

  public static unsafe string previousVersion
  {
    get
    {
      System.IntPtr il2CppString;
      IL2CPP.il2cpp_field_static_get_value(VersionCompatibility.NativeFieldInfoPtr_previousVersion, (void*) &il2CppString);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(VersionCompatibility.NativeFieldInfoPtr_previousVersion, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string currentVersion
  {
    get
    {
      System.IntPtr il2CppString;
      IL2CPP.il2cpp_field_static_get_value(VersionCompatibility.NativeFieldInfoPtr_currentVersion, (void*) &il2CppString);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(VersionCompatibility.NativeFieldInfoPtr_currentVersion, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public sealed class Profile : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_name;
    private static readonly System.IntPtr NativeFieldInfoPtr_versionFrom;
    private static readonly System.IntPtr NativeFieldInfoPtr_versionTo;
    private static readonly System.IntPtr NativeFieldInfoPtr_incompatibleWithFrom;
    private static readonly System.IntPtr NativeFieldInfoPtr_incompatibleWithTo;
    private static readonly System.IntPtr NativeFieldInfoPtr_action;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_String_Action_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ProcessVersionString_Private_Static_Void_String_byref_Int32_byref_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InRange_Private_Static_Boolean_Int32_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Check_Public_Void_String_String_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100637, XrefRangeEnd = 100641, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Profile(string name, string version, string incompatibleWith, Il2CppSystem.Action action)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VersionCompatibility.Profile>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(name);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(version);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(incompatibleWith);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) action);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VersionCompatibility.Profile.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_Action_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(16)]
    [CachedScanResults(RefRangeStart = 100653, RefRangeEnd = 100669, XrefRangeStart = 100641, XrefRangeEnd = 100653, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void ProcessVersionString(string @in, out int lower, out int higher)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(@in);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref lower;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref higher;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VersionCompatibility.Profile.NativeMethodInfoPtr_ProcessVersionString_Private_Static_Void_String_byref_Int32_byref_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public static unsafe bool InRange(int x, int a, int b)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &x;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &a;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VersionCompatibility.Profile.NativeMethodInfoPtr_InRange_Private_Static_Boolean_Int32_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 100705, RefRangeEnd = 100706, XrefRangeStart = 100669, XrefRangeEnd = 100705, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Check(string currentVersion, string previousVersion)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(currentVersion);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(previousVersion);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VersionCompatibility.Profile.NativeMethodInfoPtr_Check_Public_Void_String_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Profile()
    {
      Il2CppClassPointerStore<VersionCompatibility.Profile>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VersionCompatibility>.NativeClassPtr, nameof (Profile));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VersionCompatibility.Profile>.NativeClassPtr);
      VersionCompatibility.Profile.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VersionCompatibility.Profile>.NativeClassPtr, nameof (name));
      VersionCompatibility.Profile.NativeFieldInfoPtr_versionFrom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VersionCompatibility.Profile>.NativeClassPtr, nameof (versionFrom));
      VersionCompatibility.Profile.NativeFieldInfoPtr_versionTo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VersionCompatibility.Profile>.NativeClassPtr, nameof (versionTo));
      VersionCompatibility.Profile.NativeFieldInfoPtr_incompatibleWithFrom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VersionCompatibility.Profile>.NativeClassPtr, nameof (incompatibleWithFrom));
      VersionCompatibility.Profile.NativeFieldInfoPtr_incompatibleWithTo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VersionCompatibility.Profile>.NativeClassPtr, nameof (incompatibleWithTo));
      VersionCompatibility.Profile.NativeFieldInfoPtr_action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VersionCompatibility.Profile>.NativeClassPtr, nameof (action));
      VersionCompatibility.Profile.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionCompatibility.Profile>.NativeClassPtr, 100672361);
      VersionCompatibility.Profile.NativeMethodInfoPtr_ProcessVersionString_Private_Static_Void_String_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionCompatibility.Profile>.NativeClassPtr, 100672362);
      VersionCompatibility.Profile.NativeMethodInfoPtr_InRange_Private_Static_Boolean_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionCompatibility.Profile>.NativeClassPtr, 100672363);
      VersionCompatibility.Profile.NativeMethodInfoPtr_Check_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionCompatibility.Profile>.NativeClassPtr, 100672364);
    }

    public Profile(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public Profile()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<VersionCompatibility.Profile>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VersionCompatibility.Profile>.NativeClassPtr, data));
    }

    public unsafe string name
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VersionCompatibility.Profile.NativeFieldInfoPtr_name)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VersionCompatibility.Profile.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe int versionFrom
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VersionCompatibility.Profile.NativeFieldInfoPtr_versionFrom));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VersionCompatibility.Profile.NativeFieldInfoPtr_versionFrom)) = value;
      }
    }

    public unsafe int versionTo
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VersionCompatibility.Profile.NativeFieldInfoPtr_versionTo));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VersionCompatibility.Profile.NativeFieldInfoPtr_versionTo)) = value;
      }
    }

    public unsafe int incompatibleWithFrom
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VersionCompatibility.Profile.NativeFieldInfoPtr_incompatibleWithFrom));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VersionCompatibility.Profile.NativeFieldInfoPtr_incompatibleWithFrom)) = value;
      }
    }

    public unsafe int incompatibleWithTo
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VersionCompatibility.Profile.NativeFieldInfoPtr_incompatibleWithTo));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VersionCompatibility.Profile.NativeFieldInfoPtr_incompatibleWithTo)) = value;
      }
    }

    public unsafe Il2CppSystem.Action action
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VersionCompatibility.Profile.NativeFieldInfoPtr_action));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action) null : new Il2CppSystem.Action(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VersionCompatibility.Profile.NativeFieldInfoPtr_action), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
