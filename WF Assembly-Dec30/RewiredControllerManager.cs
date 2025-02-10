// Decompiled with JetBrains decompiler
// Type: RewiredControllerManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using Rewired;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class RewiredControllerManager : MonoBehaviour
{
  private static readonly System.IntPtr NativeFieldInfoPtr_instance;
  private static readonly System.IntPtr NativeFieldInfoPtr_maxPlayers;
  private static readonly System.IntPtr NativeFieldInfoPtr_playerMaps;
  private static readonly System.IntPtr NativeFieldInfoPtr_gamePlayerIdCounter;
  private static readonly System.IntPtr NativeFieldInfoPtr_leadPlayer;
  private static readonly System.IntPtr NativeFieldInfoPtr_maxJoysticksPerPlayer;
  private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ControllerConnected_Private_Static_Void_ControllerStatusChangedEventArgs_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ControllerDisconnected_Private_Static_Void_ControllerStatusChangedEventArgs_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AssignNextPlayer_Public_Player_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AssignJoystickMap_Public_Void_Player_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AssignJoystickMap_Public_Void_Int32_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetNextGamePlayerId_Private_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetActiveDevices_Internal_List_1_PlayerMap_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetPlayers_Internal_IList_1_Player_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetPlayerController_Public_Static_Player_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetPlayerID_Public_Static_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ClearAssignedControllers_Internal_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsPlayerControllerConnected_Public_Boolean_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsControllerConnected_Public_Boolean_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AssignControllerToPlayer_Internal_Void_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AnyControllerConnected_Public_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsButtonPressed_Internal_Boolean_String_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsButtonPressed_Internal_Boolean_byref_Int32_String_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsButtonHeld_Internal_Boolean_String_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsButtonHeld_Internal_Boolean_byref_Int32_String_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsButtonLongHeld_Internal_Boolean_String_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsButtonLongHeld_Internal_Boolean_byref_Int32_String_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsButtonReleased_Internal_Boolean_String_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsButtonReleased_Internal_Boolean_byref_Int32_String_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_WasButtonReleased_Internal_Boolean_String_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_WasButtonReleased_Internal_Boolean_byref_Int32_String_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_WasButtonPressed_Internal_Boolean_String_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_WasButtonPressed_Internal_Boolean_byref_Int32_String_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetAnalogPositive_Internal_Single_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetAnalogNegative_Internal_Single_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetAnalog_Internal_Single_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetAnalog_Internal_Single_byref_Int32_String_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ReturnTrueWithPlayer_Private_Void_byref_Int32_byref_Boolean_Player_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetDeviceCount_Internal_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetActiveControllersToMap_Internal_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16271, XrefRangeEnd = 16294, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(RewiredControllerManager.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16294, XrefRangeEnd = 16311, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(RewiredControllerManager.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16311, XrefRangeEnd = 16328, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(RewiredControllerManager.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16328, XrefRangeEnd = 16377, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void ControllerConnected(ControllerStatusChangedEventArgs args)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) args)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(RewiredControllerManager.NativeMethodInfoPtr_ControllerConnected_Private_Static_Void_ControllerStatusChangedEventArgs_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16377, XrefRangeEnd = 16444, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void ControllerDisconnected(ControllerStatusChangedEventArgs args)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) args)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(RewiredControllerManager.NativeMethodInfoPtr_ControllerDisconnected_Private_Static_Void_ControllerStatusChangedEventArgs_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 16580, RefRangeEnd = 16583, XrefRangeStart = 16444, XrefRangeEnd = 16580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Player AssignNextPlayer(int rewiredPlayerId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &rewiredPlayerId
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RewiredControllerManager.NativeMethodInfoPtr_AssignNextPlayer_Public_Player_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (Player) null : new Player(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16583, XrefRangeEnd = 16586, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AssignJoystickMap(Player rewiredPlayer, string newMap)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) rewiredPlayer);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(newMap);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(RewiredControllerManager.NativeMethodInfoPtr_AssignJoystickMap_Public_Void_Player_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16586, XrefRangeEnd = 16593, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AssignJoystickMap(int playerNumber, string newMap)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &playerNumber;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(newMap);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(RewiredControllerManager.NativeMethodInfoPtr_AssignJoystickMap_Public_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16593, XrefRangeEnd = 16597, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe int GetNextGamePlayerId()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RewiredControllerManager.NativeMethodInfoPtr_GetNextGamePlayerId_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(int*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16597, XrefRangeEnd = 16601, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe List<RewiredControllerManager.PlayerMap> GetActiveDevices()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RewiredControllerManager.NativeMethodInfoPtr_GetActiveDevices_Internal_List_1_PlayerMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (List<RewiredControllerManager.PlayerMap>) null : new List<RewiredControllerManager.PlayerMap>(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16601, XrefRangeEnd = 16607, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IList<Player> GetPlayers()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RewiredControllerManager.NativeMethodInfoPtr_GetPlayers_Internal_IList_1_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (IList<Player>) null : new IList<Player>(pointer);
  }

  [CallerCount(8)]
  [CachedScanResults(RefRangeStart = 16652, RefRangeEnd = 16660, XrefRangeStart = 16607, XrefRangeEnd = 16652, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Player GetPlayerController(int gamePlayerId)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &gamePlayerId
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RewiredControllerManager.NativeMethodInfoPtr_GetPlayerController_Public_Static_Player_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    System.IntPtr pointer = num;
    return pointer == System.IntPtr.Zero ? (Player) null : new Player(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16660, XrefRangeEnd = 16690, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int GetPlayerID(int rewiredControllerID)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &rewiredControllerID
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RewiredControllerManager.NativeMethodInfoPtr_GetPlayerID_Public_Static_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(int*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16690, XrefRangeEnd = 16708, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ClearAssignedControllers()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(RewiredControllerManager.NativeMethodInfoPtr_ClearAssignedControllers_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16708, XrefRangeEnd = 16725, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool IsPlayerControllerConnected(int playerIndex)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &playerIndex
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RewiredControllerManager.NativeMethodInfoPtr_IsPlayerControllerConnected_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16725, XrefRangeEnd = 16743, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool IsControllerConnected(int controllerIndex)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &controllerIndex
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RewiredControllerManager.NativeMethodInfoPtr_IsControllerConnected_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16743, XrefRangeEnd = 16760, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AssignControllerToPlayer(int i, int controllerIndex)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &i;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &controllerIndex;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(RewiredControllerManager.NativeMethodInfoPtr_AssignControllerToPlayer_Internal_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16760, XrefRangeEnd = 16765, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool AnyControllerConnected()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RewiredControllerManager.NativeMethodInfoPtr_AnyControllerConnected_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 16767, RefRangeEnd = 16769, XrefRangeStart = 16765, XrefRangeEnd = 16767, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool IsButtonPressed(string input = "", bool IsPositive = true)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(input);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &IsPositive;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RewiredControllerManager.NativeMethodInfoPtr_IsButtonPressed_Internal_Boolean_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 16830, RefRangeEnd = 16831, XrefRangeStart = 16769, XrefRangeEnd = 16830, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool IsButtonPressed(out int callingPlayer, string input = "", bool IsPositive = true)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) ref callingPlayer;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(input);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &IsPositive;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RewiredControllerManager.NativeMethodInfoPtr_IsButtonPressed_Internal_Boolean_byref_Int32_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 16833, RefRangeEnd = 16834, XrefRangeStart = 16831, XrefRangeEnd = 16833, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool IsButtonHeld(string input = "", bool IsPositive = true)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(input);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &IsPositive;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RewiredControllerManager.NativeMethodInfoPtr_IsButtonHeld_Internal_Boolean_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 16890, RefRangeEnd = 16891, XrefRangeStart = 16834, XrefRangeEnd = 16890, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool IsButtonHeld(out int callingPlayer, string input = "", bool IsPositive = true)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) ref callingPlayer;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(input);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &IsPositive;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RewiredControllerManager.NativeMethodInfoPtr_IsButtonHeld_Internal_Boolean_byref_Int32_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16891, XrefRangeEnd = 16893, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool IsButtonLongHeld(string input = "", bool IsPositive = true)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(input);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &IsPositive;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RewiredControllerManager.NativeMethodInfoPtr_IsButtonLongHeld_Internal_Boolean_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 16947, RefRangeEnd = 16948, XrefRangeStart = 16893, XrefRangeEnd = 16947, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool IsButtonLongHeld(out int callingPlayer, string input = "", bool IsPositive = true)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) ref callingPlayer;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(input);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &IsPositive;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RewiredControllerManager.NativeMethodInfoPtr_IsButtonLongHeld_Internal_Boolean_byref_Int32_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 16950, RefRangeEnd = 16952, XrefRangeStart = 16948, XrefRangeEnd = 16950, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool IsButtonReleased(string input = "", bool IsPositive = true)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(input);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &IsPositive;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RewiredControllerManager.NativeMethodInfoPtr_IsButtonReleased_Internal_Boolean_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 17006, RefRangeEnd = 17007, XrefRangeStart = 16952, XrefRangeEnd = 17006, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool IsButtonReleased(out int callingPlayer, string input = "", bool IsPositive = true)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) ref callingPlayer;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(input);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &IsPositive;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RewiredControllerManager.NativeMethodInfoPtr_IsButtonReleased_Internal_Boolean_byref_Int32_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17007, XrefRangeEnd = 17008, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool WasButtonReleased(string input = "", bool IsPositive = true)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(input);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &IsPositive;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RewiredControllerManager.NativeMethodInfoPtr_WasButtonReleased_Internal_Boolean_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 17062, RefRangeEnd = 17063, XrefRangeStart = 17008, XrefRangeEnd = 17062, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool WasButtonReleased(out int callingPlayer, string input = "", bool IsPositive = true)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) ref callingPlayer;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(input);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &IsPositive;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RewiredControllerManager.NativeMethodInfoPtr_WasButtonReleased_Internal_Boolean_byref_Int32_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17063, XrefRangeEnd = 17064, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool WasButtonPressed(string input = "", bool IsPositive = true)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(input);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &IsPositive;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RewiredControllerManager.NativeMethodInfoPtr_WasButtonPressed_Internal_Boolean_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 17118, RefRangeEnd = 17119, XrefRangeStart = 17064, XrefRangeEnd = 17118, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool WasButtonPressed(out int callingPlayer, string input = "", bool IsPositive = true)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) ref callingPlayer;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(input);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &IsPositive;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RewiredControllerManager.NativeMethodInfoPtr_WasButtonPressed_Internal_Boolean_byref_Int32_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17119, XrefRangeEnd = 17121, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe float GetAnalogPositive(string input = "")
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(input)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RewiredControllerManager.NativeMethodInfoPtr_GetAnalogPositive_Internal_Single_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17121, XrefRangeEnd = 17123, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe float GetAnalogNegative(string input = "")
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(input)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RewiredControllerManager.NativeMethodInfoPtr_GetAnalogNegative_Internal_Single_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(10)]
  [CachedScanResults(RefRangeStart = 17148, RefRangeEnd = 17158, XrefRangeStart = 17123, XrefRangeEnd = 17148, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe float GetAnalog(string input = "")
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(input)
    };
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RewiredControllerManager.NativeMethodInfoPtr_GetAnalog_Internal_Single_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 17236, RefRangeEnd = 17238, XrefRangeStart = 17158, XrefRangeEnd = 17236, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe float GetAnalog(out int callingPlayer, string input, bool lookingForPositive)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) ref callingPlayer;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(input);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &lookingForPositive;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RewiredControllerManager.NativeMethodInfoPtr_GetAnalog_Internal_Single_byref_Int32_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(float*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(12)]
  [CachedScanResults(RefRangeStart = 17268, RefRangeEnd = 17280, XrefRangeStart = 17238, XrefRangeEnd = 17268, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ReturnTrueWithPlayer(out int callingPlayer, out bool state, Player x)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) ref callingPlayer;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref state;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) x);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(RewiredControllerManager.NativeMethodInfoPtr_ReturnTrueWithPlayer_Private_Void_byref_Int32_byref_Boolean_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17280, XrefRangeEnd = 17287, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe int GetDeviceCount()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RewiredControllerManager.NativeMethodInfoPtr_GetDeviceCount_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
    return *(int*) IL2CPP.il2cpp_object_unbox(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17287, XrefRangeEnd = 17318, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetActiveControllersToMap(string newControllerMap)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(newControllerMap)
    };
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(RewiredControllerManager.NativeMethodInfoPtr_SetActiveControllersToMap_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17318, XrefRangeEnd = 17319, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe RewiredControllerManager()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RewiredControllerManager>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(RewiredControllerManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static RewiredControllerManager()
  {
    Il2CppClassPointerStore<RewiredControllerManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (RewiredControllerManager));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RewiredControllerManager>.NativeClassPtr);
    RewiredControllerManager.NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredControllerManager>.NativeClassPtr, nameof (instance));
    RewiredControllerManager.NativeFieldInfoPtr_maxPlayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredControllerManager>.NativeClassPtr, nameof (maxPlayers));
    RewiredControllerManager.NativeFieldInfoPtr_playerMaps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredControllerManager>.NativeClassPtr, nameof (playerMaps));
    RewiredControllerManager.NativeFieldInfoPtr_gamePlayerIdCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredControllerManager>.NativeClassPtr, nameof (gamePlayerIdCounter));
    RewiredControllerManager.NativeFieldInfoPtr_leadPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredControllerManager>.NativeClassPtr, nameof (leadPlayer));
    RewiredControllerManager.NativeFieldInfoPtr_maxJoysticksPerPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredControllerManager>.NativeClassPtr, nameof (maxJoysticksPerPlayer));
    RewiredControllerManager.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredControllerManager>.NativeClassPtr, 100663402);
    RewiredControllerManager.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredControllerManager>.NativeClassPtr, 100663403);
    RewiredControllerManager.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredControllerManager>.NativeClassPtr, 100663404);
    RewiredControllerManager.NativeMethodInfoPtr_ControllerConnected_Private_Static_Void_ControllerStatusChangedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredControllerManager>.NativeClassPtr, 100663405);
    RewiredControllerManager.NativeMethodInfoPtr_ControllerDisconnected_Private_Static_Void_ControllerStatusChangedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredControllerManager>.NativeClassPtr, 100663406);
    RewiredControllerManager.NativeMethodInfoPtr_AssignNextPlayer_Public_Player_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredControllerManager>.NativeClassPtr, 100663407);
    RewiredControllerManager.NativeMethodInfoPtr_AssignJoystickMap_Public_Void_Player_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredControllerManager>.NativeClassPtr, 100663408);
    RewiredControllerManager.NativeMethodInfoPtr_AssignJoystickMap_Public_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredControllerManager>.NativeClassPtr, 100663409);
    RewiredControllerManager.NativeMethodInfoPtr_GetNextGamePlayerId_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredControllerManager>.NativeClassPtr, 100663410);
    RewiredControllerManager.NativeMethodInfoPtr_GetActiveDevices_Internal_List_1_PlayerMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredControllerManager>.NativeClassPtr, 100663411);
    RewiredControllerManager.NativeMethodInfoPtr_GetPlayers_Internal_IList_1_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredControllerManager>.NativeClassPtr, 100663412);
    RewiredControllerManager.NativeMethodInfoPtr_GetPlayerController_Public_Static_Player_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredControllerManager>.NativeClassPtr, 100663413);
    RewiredControllerManager.NativeMethodInfoPtr_GetPlayerID_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredControllerManager>.NativeClassPtr, 100663414);
    RewiredControllerManager.NativeMethodInfoPtr_ClearAssignedControllers_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredControllerManager>.NativeClassPtr, 100663415);
    RewiredControllerManager.NativeMethodInfoPtr_IsPlayerControllerConnected_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredControllerManager>.NativeClassPtr, 100663416);
    RewiredControllerManager.NativeMethodInfoPtr_IsControllerConnected_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredControllerManager>.NativeClassPtr, 100663417);
    RewiredControllerManager.NativeMethodInfoPtr_AssignControllerToPlayer_Internal_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredControllerManager>.NativeClassPtr, 100663418);
    RewiredControllerManager.NativeMethodInfoPtr_AnyControllerConnected_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredControllerManager>.NativeClassPtr, 100663419);
    RewiredControllerManager.NativeMethodInfoPtr_IsButtonPressed_Internal_Boolean_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredControllerManager>.NativeClassPtr, 100663420);
    RewiredControllerManager.NativeMethodInfoPtr_IsButtonPressed_Internal_Boolean_byref_Int32_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredControllerManager>.NativeClassPtr, 100663421);
    RewiredControllerManager.NativeMethodInfoPtr_IsButtonHeld_Internal_Boolean_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredControllerManager>.NativeClassPtr, 100663422);
    RewiredControllerManager.NativeMethodInfoPtr_IsButtonHeld_Internal_Boolean_byref_Int32_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredControllerManager>.NativeClassPtr, 100663423);
    RewiredControllerManager.NativeMethodInfoPtr_IsButtonLongHeld_Internal_Boolean_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredControllerManager>.NativeClassPtr, 100663424);
    RewiredControllerManager.NativeMethodInfoPtr_IsButtonLongHeld_Internal_Boolean_byref_Int32_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredControllerManager>.NativeClassPtr, 100663425);
    RewiredControllerManager.NativeMethodInfoPtr_IsButtonReleased_Internal_Boolean_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredControllerManager>.NativeClassPtr, 100663426);
    RewiredControllerManager.NativeMethodInfoPtr_IsButtonReleased_Internal_Boolean_byref_Int32_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredControllerManager>.NativeClassPtr, 100663427);
    RewiredControllerManager.NativeMethodInfoPtr_WasButtonReleased_Internal_Boolean_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredControllerManager>.NativeClassPtr, 100663428);
    RewiredControllerManager.NativeMethodInfoPtr_WasButtonReleased_Internal_Boolean_byref_Int32_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredControllerManager>.NativeClassPtr, 100663429);
    RewiredControllerManager.NativeMethodInfoPtr_WasButtonPressed_Internal_Boolean_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredControllerManager>.NativeClassPtr, 100663430);
    RewiredControllerManager.NativeMethodInfoPtr_WasButtonPressed_Internal_Boolean_byref_Int32_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredControllerManager>.NativeClassPtr, 100663431);
    RewiredControllerManager.NativeMethodInfoPtr_GetAnalogPositive_Internal_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredControllerManager>.NativeClassPtr, 100663432);
    RewiredControllerManager.NativeMethodInfoPtr_GetAnalogNegative_Internal_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredControllerManager>.NativeClassPtr, 100663433);
    RewiredControllerManager.NativeMethodInfoPtr_GetAnalog_Internal_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredControllerManager>.NativeClassPtr, 100663434);
    RewiredControllerManager.NativeMethodInfoPtr_GetAnalog_Internal_Single_byref_Int32_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredControllerManager>.NativeClassPtr, 100663435);
    RewiredControllerManager.NativeMethodInfoPtr_ReturnTrueWithPlayer_Private_Void_byref_Int32_byref_Boolean_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredControllerManager>.NativeClassPtr, 100663436);
    RewiredControllerManager.NativeMethodInfoPtr_GetDeviceCount_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredControllerManager>.NativeClassPtr, 100663437);
    RewiredControllerManager.NativeMethodInfoPtr_SetActiveControllersToMap_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredControllerManager>.NativeClassPtr, 100663438);
    RewiredControllerManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredControllerManager>.NativeClassPtr, 100663439);
  }

  public RewiredControllerManager(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe RewiredControllerManager instance
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(RewiredControllerManager.NativeFieldInfoPtr_instance, (void*) &num);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (RewiredControllerManager) null : new RewiredControllerManager(pointer);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RewiredControllerManager.NativeFieldInfoPtr_instance, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int maxPlayers
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredControllerManager.NativeFieldInfoPtr_maxPlayers));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredControllerManager.NativeFieldInfoPtr_maxPlayers)) = value;
    }
  }

  public static unsafe List<RewiredControllerManager.PlayerMap> playerMaps
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(RewiredControllerManager.NativeFieldInfoPtr_playerMaps, (void*) &num);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (List<RewiredControllerManager.PlayerMap>) null : new List<RewiredControllerManager.PlayerMap>(pointer);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RewiredControllerManager.NativeFieldInfoPtr_playerMaps, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe int gamePlayerIdCounter
  {
    get
    {
      int gamePlayerIdCounter;
      IL2CPP.il2cpp_field_static_get_value(RewiredControllerManager.NativeFieldInfoPtr_gamePlayerIdCounter, (void*) &gamePlayerIdCounter);
      return gamePlayerIdCounter;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RewiredControllerManager.NativeFieldInfoPtr_gamePlayerIdCounter, (void*) &value);
    }
  }

  public static unsafe Player leadPlayer
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(RewiredControllerManager.NativeFieldInfoPtr_leadPlayer, (void*) &num);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Player) null : new Player(pointer);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RewiredControllerManager.NativeFieldInfoPtr_leadPlayer, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe int maxJoysticksPerPlayer
  {
    get
    {
      int joysticksPerPlayer;
      IL2CPP.il2cpp_field_static_get_value(RewiredControllerManager.NativeFieldInfoPtr_maxJoysticksPerPlayer, (void*) &joysticksPerPlayer);
      return joysticksPerPlayer;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RewiredControllerManager.NativeFieldInfoPtr_maxJoysticksPerPlayer, (void*) &value);
    }
  }

  public class PlayerMap : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_rewiredPlayerId;
    private static readonly System.IntPtr NativeFieldInfoPtr_gamePlayerId;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 16266, RefRangeEnd = 16267, XrefRangeStart = 16265, XrefRangeEnd = 16266, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PlayerMap(int rewiredPlayerId, int gamePlayerId)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RewiredControllerManager.PlayerMap>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &rewiredPlayerId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &gamePlayerId;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RewiredControllerManager.PlayerMap.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static PlayerMap()
    {
      Il2CppClassPointerStore<RewiredControllerManager.PlayerMap>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RewiredControllerManager>.NativeClassPtr, nameof (PlayerMap));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RewiredControllerManager.PlayerMap>.NativeClassPtr);
      RewiredControllerManager.PlayerMap.NativeFieldInfoPtr_rewiredPlayerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredControllerManager.PlayerMap>.NativeClassPtr, nameof (rewiredPlayerId));
      RewiredControllerManager.PlayerMap.NativeFieldInfoPtr_gamePlayerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredControllerManager.PlayerMap>.NativeClassPtr, nameof (gamePlayerId));
      RewiredControllerManager.PlayerMap.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredControllerManager.PlayerMap>.NativeClassPtr, 100663441);
    }

    public PlayerMap(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int rewiredPlayerId
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredControllerManager.PlayerMap.NativeFieldInfoPtr_rewiredPlayerId));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredControllerManager.PlayerMap.NativeFieldInfoPtr_rewiredPlayerId)) = value;
      }
    }

    public unsafe int gamePlayerId
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredControllerManager.PlayerMap.NativeFieldInfoPtr_gamePlayerId));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredControllerManager.PlayerMap.NativeFieldInfoPtr_gamePlayerId)) = value;
      }
    }
  }

  [ObfuscatedName("RewiredControllerManager/<>c")]
  [Serializable]
  public sealed class __c : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__10_0;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__11_0;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__12_1;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ControllerConnected_b__10_0_Internal_String_Controller_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ControllerDisconnected_b__11_0_Internal_String_Controller_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__AssignNextPlayer_b__12_1_Internal_String_Controller_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RewiredControllerManager.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RewiredControllerManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16267, XrefRangeEnd = 16269, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string _ControllerConnected_b__10_0(Controller a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(RewiredControllerManager.__c.NativeMethodInfoPtr__ControllerConnected_b__10_0_Internal_String_Controller_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string _ControllerDisconnected_b__11_0(Controller a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(RewiredControllerManager.__c.NativeMethodInfoPtr__ControllerDisconnected_b__11_0_Internal_String_Controller_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string _AssignNextPlayer_b__12_1(Controller a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(RewiredControllerManager.__c.NativeMethodInfoPtr__AssignNextPlayer_b__12_1_Internal_String_Controller_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    static __c()
    {
      Il2CppClassPointerStore<RewiredControllerManager.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RewiredControllerManager>.NativeClassPtr, "<>c");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RewiredControllerManager.__c>.NativeClassPtr);
      RewiredControllerManager.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredControllerManager.__c>.NativeClassPtr, "<>9");
      RewiredControllerManager.__c.NativeFieldInfoPtr___9__10_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredControllerManager.__c>.NativeClassPtr, "<>9__10_0");
      RewiredControllerManager.__c.NativeFieldInfoPtr___9__11_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredControllerManager.__c>.NativeClassPtr, "<>9__11_0");
      RewiredControllerManager.__c.NativeFieldInfoPtr___9__12_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredControllerManager.__c>.NativeClassPtr, "<>9__12_1");
      RewiredControllerManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredControllerManager.__c>.NativeClassPtr, 100663443);
      RewiredControllerManager.__c.NativeMethodInfoPtr__ControllerConnected_b__10_0_Internal_String_Controller_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredControllerManager.__c>.NativeClassPtr, 100663444);
      RewiredControllerManager.__c.NativeMethodInfoPtr__ControllerDisconnected_b__11_0_Internal_String_Controller_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredControllerManager.__c>.NativeClassPtr, 100663445);
      RewiredControllerManager.__c.NativeMethodInfoPtr__AssignNextPlayer_b__12_1_Internal_String_Controller_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredControllerManager.__c>.NativeClassPtr, 100663446);
    }

    public __c(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe RewiredControllerManager.__c __9
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(RewiredControllerManager.__c.NativeFieldInfoPtr___9, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (RewiredControllerManager.__c) null : new RewiredControllerManager.__c(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RewiredControllerManager.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<Controller, string> __9__10_0
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(RewiredControllerManager.__c.NativeFieldInfoPtr___9__10_0, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<Controller, string>) null : new Il2CppSystem.Func<Controller, string>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RewiredControllerManager.__c.NativeFieldInfoPtr___9__10_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<Controller, string> __9__11_0
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(RewiredControllerManager.__c.NativeFieldInfoPtr___9__11_0, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<Controller, string>) null : new Il2CppSystem.Func<Controller, string>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RewiredControllerManager.__c.NativeFieldInfoPtr___9__11_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<Controller, string> __9__12_1
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(RewiredControllerManager.__c.NativeFieldInfoPtr___9__12_1, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<Controller, string>) null : new Il2CppSystem.Func<Controller, string>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RewiredControllerManager.__c.NativeFieldInfoPtr___9__12_1, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("RewiredControllerManager/<>c__DisplayClass12_0")]
  public sealed class __c__DisplayClass12_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_rewiredPlayerId;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__AssignNextPlayer_b__0_Internal_Boolean_PlayerMap_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass12_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RewiredControllerManager.__c__DisplayClass12_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RewiredControllerManager.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe bool _AssignNextPlayer_b__0(RewiredControllerManager.PlayerMap a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RewiredControllerManager.__c__DisplayClass12_0.NativeMethodInfoPtr__AssignNextPlayer_b__0_Internal_Boolean_PlayerMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c__DisplayClass12_0()
    {
      Il2CppClassPointerStore<RewiredControllerManager.__c__DisplayClass12_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RewiredControllerManager>.NativeClassPtr, "<>c__DisplayClass12_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RewiredControllerManager.__c__DisplayClass12_0>.NativeClassPtr);
      RewiredControllerManager.__c__DisplayClass12_0.NativeFieldInfoPtr_rewiredPlayerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredControllerManager.__c__DisplayClass12_0>.NativeClassPtr, nameof (rewiredPlayerId));
      RewiredControllerManager.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredControllerManager.__c__DisplayClass12_0>.NativeClassPtr, 100663447);
      RewiredControllerManager.__c__DisplayClass12_0.NativeMethodInfoPtr__AssignNextPlayer_b__0_Internal_Boolean_PlayerMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredControllerManager.__c__DisplayClass12_0>.NativeClassPtr, 100663448);
    }

    public __c__DisplayClass12_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int rewiredPlayerId
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredControllerManager.__c__DisplayClass12_0.NativeFieldInfoPtr_rewiredPlayerId));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredControllerManager.__c__DisplayClass12_0.NativeFieldInfoPtr_rewiredPlayerId)) = value;
      }
    }
  }

  [ObfuscatedName("RewiredControllerManager/<>c__DisplayClass18_0")]
  public sealed class __c__DisplayClass18_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_gamePlayerId;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__GetPlayerController_b__0_Internal_Boolean_PlayerMap_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass18_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RewiredControllerManager.__c__DisplayClass18_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RewiredControllerManager.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe bool _GetPlayerController_b__0(RewiredControllerManager.PlayerMap a)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RewiredControllerManager.__c__DisplayClass18_0.NativeMethodInfoPtr__GetPlayerController_b__0_Internal_Boolean_PlayerMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c__DisplayClass18_0()
    {
      Il2CppClassPointerStore<RewiredControllerManager.__c__DisplayClass18_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RewiredControllerManager>.NativeClassPtr, "<>c__DisplayClass18_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RewiredControllerManager.__c__DisplayClass18_0>.NativeClassPtr);
      RewiredControllerManager.__c__DisplayClass18_0.NativeFieldInfoPtr_gamePlayerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredControllerManager.__c__DisplayClass18_0>.NativeClassPtr, nameof (gamePlayerId));
      RewiredControllerManager.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredControllerManager.__c__DisplayClass18_0>.NativeClassPtr, 100663449);
      RewiredControllerManager.__c__DisplayClass18_0.NativeMethodInfoPtr__GetPlayerController_b__0_Internal_Boolean_PlayerMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredControllerManager.__c__DisplayClass18_0>.NativeClassPtr, 100663450);
    }

    public __c__DisplayClass18_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int gamePlayerId
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredControllerManager.__c__DisplayClass18_0.NativeFieldInfoPtr_gamePlayerId));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredControllerManager.__c__DisplayClass18_0.NativeFieldInfoPtr_gamePlayerId)) = value;
      }
    }
  }

  [ObfuscatedName("RewiredControllerManager/<>c__DisplayClass21_0")]
  public sealed class __c__DisplayClass21_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_playerIndex;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__IsPlayerControllerConnected_b__0_Internal_Boolean_PlayerMap_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass21_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RewiredControllerManager.__c__DisplayClass21_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RewiredControllerManager.__c__DisplayClass21_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe bool _IsPlayerControllerConnected_b__0(RewiredControllerManager.PlayerMap x)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) x)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RewiredControllerManager.__c__DisplayClass21_0.NativeMethodInfoPtr__IsPlayerControllerConnected_b__0_Internal_Boolean_PlayerMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c__DisplayClass21_0()
    {
      Il2CppClassPointerStore<RewiredControllerManager.__c__DisplayClass21_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RewiredControllerManager>.NativeClassPtr, "<>c__DisplayClass21_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RewiredControllerManager.__c__DisplayClass21_0>.NativeClassPtr);
      RewiredControllerManager.__c__DisplayClass21_0.NativeFieldInfoPtr_playerIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredControllerManager.__c__DisplayClass21_0>.NativeClassPtr, nameof (playerIndex));
      RewiredControllerManager.__c__DisplayClass21_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredControllerManager.__c__DisplayClass21_0>.NativeClassPtr, 100663451);
      RewiredControllerManager.__c__DisplayClass21_0.NativeMethodInfoPtr__IsPlayerControllerConnected_b__0_Internal_Boolean_PlayerMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredControllerManager.__c__DisplayClass21_0>.NativeClassPtr, 100663452);
    }

    public __c__DisplayClass21_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int playerIndex
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredControllerManager.__c__DisplayClass21_0.NativeFieldInfoPtr_playerIndex));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredControllerManager.__c__DisplayClass21_0.NativeFieldInfoPtr_playerIndex)) = value;
      }
    }
  }

  [ObfuscatedName("RewiredControllerManager/<>c__DisplayClass22_0")]
  public sealed class __c__DisplayClass22_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_controllerIndex;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__IsControllerConnected_b__0_Internal_Boolean_Player_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass22_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RewiredControllerManager.__c__DisplayClass22_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RewiredControllerManager.__c__DisplayClass22_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16269, XrefRangeEnd = 16270, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _IsControllerConnected_b__0(Player x)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) x)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RewiredControllerManager.__c__DisplayClass22_0.NativeMethodInfoPtr__IsControllerConnected_b__0_Internal_Boolean_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c__DisplayClass22_0()
    {
      Il2CppClassPointerStore<RewiredControllerManager.__c__DisplayClass22_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RewiredControllerManager>.NativeClassPtr, "<>c__DisplayClass22_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RewiredControllerManager.__c__DisplayClass22_0>.NativeClassPtr);
      RewiredControllerManager.__c__DisplayClass22_0.NativeFieldInfoPtr_controllerIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredControllerManager.__c__DisplayClass22_0>.NativeClassPtr, nameof (controllerIndex));
      RewiredControllerManager.__c__DisplayClass22_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredControllerManager.__c__DisplayClass22_0>.NativeClassPtr, 100663453);
      RewiredControllerManager.__c__DisplayClass22_0.NativeMethodInfoPtr__IsControllerConnected_b__0_Internal_Boolean_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredControllerManager.__c__DisplayClass22_0>.NativeClassPtr, 100663454);
    }

    public __c__DisplayClass22_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int controllerIndex
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredControllerManager.__c__DisplayClass22_0.NativeFieldInfoPtr_controllerIndex));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredControllerManager.__c__DisplayClass22_0.NativeFieldInfoPtr_controllerIndex)) = value;
      }
    }
  }

  [ObfuscatedName("RewiredControllerManager/<>c__DisplayClass23_0")]
  public sealed class __c__DisplayClass23_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_controllerIndex;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__AssignControllerToPlayer_b__0_Internal_Boolean_PlayerMap_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass23_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RewiredControllerManager.__c__DisplayClass23_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RewiredControllerManager.__c__DisplayClass23_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe bool _AssignControllerToPlayer_b__0(RewiredControllerManager.PlayerMap x)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) x)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RewiredControllerManager.__c__DisplayClass23_0.NativeMethodInfoPtr__AssignControllerToPlayer_b__0_Internal_Boolean_PlayerMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c__DisplayClass23_0()
    {
      Il2CppClassPointerStore<RewiredControllerManager.__c__DisplayClass23_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RewiredControllerManager>.NativeClassPtr, "<>c__DisplayClass23_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RewiredControllerManager.__c__DisplayClass23_0>.NativeClassPtr);
      RewiredControllerManager.__c__DisplayClass23_0.NativeFieldInfoPtr_controllerIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredControllerManager.__c__DisplayClass23_0>.NativeClassPtr, nameof (controllerIndex));
      RewiredControllerManager.__c__DisplayClass23_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredControllerManager.__c__DisplayClass23_0>.NativeClassPtr, 100663455);
      RewiredControllerManager.__c__DisplayClass23_0.NativeMethodInfoPtr__AssignControllerToPlayer_b__0_Internal_Boolean_PlayerMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredControllerManager.__c__DisplayClass23_0>.NativeClassPtr, 100663456);
    }

    public __c__DisplayClass23_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int controllerIndex
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredControllerManager.__c__DisplayClass23_0.NativeFieldInfoPtr_controllerIndex));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredControllerManager.__c__DisplayClass23_0.NativeFieldInfoPtr_controllerIndex)) = value;
      }
    }
  }

  [ObfuscatedName("RewiredControllerManager/<>c__DisplayClass40_0")]
  public sealed class __c__DisplayClass40_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_x;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__GetAnalog_b__0_Internal_Boolean_PlayerMap_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__GetAnalog_b__1_Internal_Boolean_PlayerMap_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__GetAnalog_b__2_Internal_Boolean_PlayerMap_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__GetAnalog_b__3_Internal_Boolean_PlayerMap_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass40_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RewiredControllerManager.__c__DisplayClass40_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RewiredControllerManager.__c__DisplayClass40_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16270, XrefRangeEnd = 16271, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _GetAnalog_b__0(RewiredControllerManager.PlayerMap y)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) y)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RewiredControllerManager.__c__DisplayClass40_0.NativeMethodInfoPtr__GetAnalog_b__0_Internal_Boolean_PlayerMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _GetAnalog_b__1(RewiredControllerManager.PlayerMap y)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) y)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RewiredControllerManager.__c__DisplayClass40_0.NativeMethodInfoPtr__GetAnalog_b__1_Internal_Boolean_PlayerMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _GetAnalog_b__2(RewiredControllerManager.PlayerMap y)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) y)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RewiredControllerManager.__c__DisplayClass40_0.NativeMethodInfoPtr__GetAnalog_b__2_Internal_Boolean_PlayerMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _GetAnalog_b__3(RewiredControllerManager.PlayerMap y)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) y)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RewiredControllerManager.__c__DisplayClass40_0.NativeMethodInfoPtr__GetAnalog_b__3_Internal_Boolean_PlayerMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c__DisplayClass40_0()
    {
      Il2CppClassPointerStore<RewiredControllerManager.__c__DisplayClass40_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RewiredControllerManager>.NativeClassPtr, "<>c__DisplayClass40_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RewiredControllerManager.__c__DisplayClass40_0>.NativeClassPtr);
      RewiredControllerManager.__c__DisplayClass40_0.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredControllerManager.__c__DisplayClass40_0>.NativeClassPtr, nameof (x));
      RewiredControllerManager.__c__DisplayClass40_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredControllerManager.__c__DisplayClass40_0>.NativeClassPtr, 100663457);
      RewiredControllerManager.__c__DisplayClass40_0.NativeMethodInfoPtr__GetAnalog_b__0_Internal_Boolean_PlayerMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredControllerManager.__c__DisplayClass40_0>.NativeClassPtr, 100663458);
      RewiredControllerManager.__c__DisplayClass40_0.NativeMethodInfoPtr__GetAnalog_b__1_Internal_Boolean_PlayerMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredControllerManager.__c__DisplayClass40_0>.NativeClassPtr, 100663459);
      RewiredControllerManager.__c__DisplayClass40_0.NativeMethodInfoPtr__GetAnalog_b__2_Internal_Boolean_PlayerMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredControllerManager.__c__DisplayClass40_0>.NativeClassPtr, 100663460);
      RewiredControllerManager.__c__DisplayClass40_0.NativeMethodInfoPtr__GetAnalog_b__3_Internal_Boolean_PlayerMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredControllerManager.__c__DisplayClass40_0>.NativeClassPtr, 100663461);
    }

    public __c__DisplayClass40_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Player x
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredControllerManager.__c__DisplayClass40_0.NativeFieldInfoPtr_x));
        return pointer == System.IntPtr.Zero ? (Player) null : new Player(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RewiredControllerManager.__c__DisplayClass40_0.NativeFieldInfoPtr_x), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("RewiredControllerManager/<>c__DisplayClass41_0")]
  public sealed class __c__DisplayClass41_0 : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_x;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ReturnTrueWithPlayer_b__0_Internal_Boolean_PlayerMap_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ReturnTrueWithPlayer_b__1_Internal_Boolean_PlayerMap_0;

    [CallerCount(1959)]
    [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass41_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RewiredControllerManager.__c__DisplayClass41_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RewiredControllerManager.__c__DisplayClass41_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _ReturnTrueWithPlayer_b__0(RewiredControllerManager.PlayerMap y)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) y)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RewiredControllerManager.__c__DisplayClass41_0.NativeMethodInfoPtr__ReturnTrueWithPlayer_b__0_Internal_Boolean_PlayerMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _ReturnTrueWithPlayer_b__1(RewiredControllerManager.PlayerMap y)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) y)
      };
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RewiredControllerManager.__c__DisplayClass41_0.NativeMethodInfoPtr__ReturnTrueWithPlayer_b__1_Internal_Boolean_PlayerMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static __c__DisplayClass41_0()
    {
      Il2CppClassPointerStore<RewiredControllerManager.__c__DisplayClass41_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RewiredControllerManager>.NativeClassPtr, "<>c__DisplayClass41_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RewiredControllerManager.__c__DisplayClass41_0>.NativeClassPtr);
      RewiredControllerManager.__c__DisplayClass41_0.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredControllerManager.__c__DisplayClass41_0>.NativeClassPtr, nameof (x));
      RewiredControllerManager.__c__DisplayClass41_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredControllerManager.__c__DisplayClass41_0>.NativeClassPtr, 100663462);
      RewiredControllerManager.__c__DisplayClass41_0.NativeMethodInfoPtr__ReturnTrueWithPlayer_b__0_Internal_Boolean_PlayerMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredControllerManager.__c__DisplayClass41_0>.NativeClassPtr, 100663463);
      RewiredControllerManager.__c__DisplayClass41_0.NativeMethodInfoPtr__ReturnTrueWithPlayer_b__1_Internal_Boolean_PlayerMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredControllerManager.__c__DisplayClass41_0>.NativeClassPtr, 100663464);
    }

    public __c__DisplayClass41_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Player x
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredControllerManager.__c__DisplayClass41_0.NativeFieldInfoPtr_x));
        return pointer == System.IntPtr.Zero ? (Player) null : new Player(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RewiredControllerManager.__c__DisplayClass41_0.NativeFieldInfoPtr_x), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
