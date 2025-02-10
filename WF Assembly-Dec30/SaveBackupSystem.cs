// Decompiled with JetBrains decompiler
// Type: SaveBackupSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
public class SaveBackupSystem : GameSystem
{
  private static readonly IntPtr NativeFieldInfoPtr_backupCampaignTimer;
  private static readonly IntPtr NativeFieldInfoPtr_backupCampaignCooldown;
  private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_CampaignStart_Private_Static_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_CampaignSaved_Private_Static_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Backup_Private_Static_Void_String_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68798, XrefRangeEnd = 68812, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SaveBackupSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68812, XrefRangeEnd = 68826, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SaveBackupSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68826, XrefRangeEnd = 68834, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SaveBackupSystem.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68834, XrefRangeEnd = 68856, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void CampaignStart()
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SaveBackupSystem.NativeMethodInfoPtr_CampaignStart_Private_Static_Void_0, IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68856, XrefRangeEnd = 68885, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void CampaignSaved()
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SaveBackupSystem.NativeMethodInfoPtr_CampaignSaved_Private_Static_Void_0, IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 68902, RefRangeEnd = 68906, XrefRangeStart = 68885, XrefRangeEnd = 68902, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Backup(string filePath)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(filePath)
    };
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SaveBackupSystem.NativeMethodInfoPtr_Backup_Private_Static_Void_String_0, IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 21168, RefRangeEnd = 21171, XrefRangeStart = 21168, XrefRangeEnd = 21171, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SaveBackupSystem()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SaveBackupSystem>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(SaveBackupSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static SaveBackupSystem()
  {
    Il2CppClassPointerStore<SaveBackupSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (SaveBackupSystem));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SaveBackupSystem>.NativeClassPtr);
    SaveBackupSystem.NativeFieldInfoPtr_backupCampaignTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveBackupSystem>.NativeClassPtr, nameof (backupCampaignTimer));
    SaveBackupSystem.NativeFieldInfoPtr_backupCampaignCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveBackupSystem>.NativeClassPtr, nameof (backupCampaignCooldown));
    SaveBackupSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveBackupSystem>.NativeClassPtr, 100668947);
    SaveBackupSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveBackupSystem>.NativeClassPtr, 100668948);
    SaveBackupSystem.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveBackupSystem>.NativeClassPtr, 100668949);
    SaveBackupSystem.NativeMethodInfoPtr_CampaignStart_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveBackupSystem>.NativeClassPtr, 100668950);
    SaveBackupSystem.NativeMethodInfoPtr_CampaignSaved_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveBackupSystem>.NativeClassPtr, 100668951);
    SaveBackupSystem.NativeMethodInfoPtr_Backup_Private_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveBackupSystem>.NativeClassPtr, 100668952);
    SaveBackupSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveBackupSystem>.NativeClassPtr, 100668953);
  }

  public SaveBackupSystem(IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe float backupCampaignTimer
  {
    get
    {
      float backupCampaignTimer;
      IL2CPP.il2cpp_field_static_get_value(SaveBackupSystem.NativeFieldInfoPtr_backupCampaignTimer, (void*) &backupCampaignTimer);
      return backupCampaignTimer;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SaveBackupSystem.NativeFieldInfoPtr_backupCampaignTimer, (void*) &value);
    }
  }

  public static unsafe float backupCampaignCooldown
  {
    get
    {
      float campaignCooldown;
      IL2CPP.il2cpp_field_static_get_value(SaveBackupSystem.NativeFieldInfoPtr_backupCampaignCooldown, (void*) &campaignCooldown);
      return campaignCooldown;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SaveBackupSystem.NativeFieldInfoPtr_backupCampaignCooldown, (void*) &value);
    }
  }
}
