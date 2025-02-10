﻿// Decompiled with JetBrains decompiler
// Type: Rewired.Data.UserDataStore_PlayerPrefs
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using Rewired.Utils.Libraries.TinyJson;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

#nullable disable
namespace Rewired.Data
{
  public class UserDataStore_PlayerPrefs : UserDataStore
  {
    public const string thisScriptName = "UserDataStore_PlayerPrefs";
    public const string logPrefix = "Rewired: ";
    public const string editorLoadedMessage = "\n***IMPORTANT:*** Changes made to the Rewired Input Manager configuration after the last time XML data was saved WILL NOT be used because the loaded old saved data has overwritten these values. If you change something in the Rewired Input Manager such as a Joystick Map or Input Behavior settings, you will not see these changes reflected in the current configuration. Clear PlayerPrefs using the inspector option on the UserDataStore_PlayerPrefs component.";
    public const string playerPrefsKeySuffix_controllerAssignments = "ControllerAssignments";
    public const int controllerMapPPKeyVersion_original = 0;
    public const int controllerMapPPKeyVersion_includeDuplicateJoystickIndex = 1;
    public const int controllerMapPPKeyVersion_supportDisconnectedControllers = 2;
    public const int controllerMapPPKeyVersion_includeFormatVersion = 2;
    public const int controllerMapPPKeyVersion = 2;
    [Tooltip("Should this script be used? If disabled, nothing will be saved or loaded.")]
    [SerializeField]
    public bool isEnabled = true;
    [Tooltip("Should saved data be loaded on start?")]
    [SerializeField]
    public bool loadDataOnStart = true;
    [Tooltip("Should Player Joystick assignments be saved and loaded? This is not totally reliable for all Joysticks on all platforms. Some platforms/input sources do not provide enough information to reliably save assignments from session to session and reboot to reboot.")]
    [SerializeField]
    public bool loadJoystickAssignments = true;
    [Tooltip("Should Player Keyboard assignments be saved and loaded?")]
    [SerializeField]
    public bool loadKeyboardAssignments = true;
    [Tooltip("Should Player Mouse assignments be saved and loaded?")]
    [SerializeField]
    public bool loadMouseAssignments = true;
    [Tooltip("The PlayerPrefs key prefix. Change this to change how keys are stored in PlayerPrefs. Changing this will make saved data already stored with the old key no longer accessible.")]
    [SerializeField]
    public string playerPrefsKeyPrefix = "RewiredSaveData";
    [NonSerialized]
    public bool allowImpreciseJoystickAssignmentMatching = true;
    [NonSerialized]
    public bool deferredJoystickAssignmentLoadPending;
    [NonSerialized]
    public bool wasJoystickEverDetected;
    [NonSerialized]
    public List<int> __allActionIds;
    [NonSerialized]
    public string __allActionIdsString;

    public bool IsEnabled
    {
      get => this.isEnabled;
      set => this.isEnabled = value;
    }

    public bool LoadDataOnStart
    {
      get => this.loadDataOnStart;
      set => this.loadDataOnStart = value;
    }

    public bool LoadJoystickAssignments
    {
      get => this.loadJoystickAssignments;
      set => this.loadJoystickAssignments = value;
    }

    public bool LoadKeyboardAssignments
    {
      get => this.loadKeyboardAssignments;
      set => this.loadKeyboardAssignments = value;
    }

    public bool LoadMouseAssignments
    {
      get => this.loadMouseAssignments;
      set => this.loadMouseAssignments = value;
    }

    public string PlayerPrefsKeyPrefix
    {
      get => this.playerPrefsKeyPrefix;
      set => this.playerPrefsKeyPrefix = value;
    }

    public string playerPrefsKey_controllerAssignments
    {
      get
      {
        return string.Format("{0}_{1}", (object) this.playerPrefsKeyPrefix, (object) "ControllerAssignments");
      }
    }

    public bool loadControllerAssignments
    {
      get
      {
        return this.loadKeyboardAssignments || this.loadMouseAssignments || this.loadJoystickAssignments;
      }
    }

    public List<int> allActionIds
    {
      get
      {
        if (this.__allActionIds != null)
          return this.__allActionIds;
        List<int> allActionIds = new List<int>();
        IList<InputAction> actions = ReInput.mapping.Actions;
        for (int index = 0; index < actions.Count; ++index)
          allActionIds.Add(actions[index].id);
        this.__allActionIds = allActionIds;
        return allActionIds;
      }
    }

    public string allActionIdsString
    {
      get
      {
        if (!string.IsNullOrEmpty(this.__allActionIdsString))
          return this.__allActionIdsString;
        StringBuilder stringBuilder = new StringBuilder();
        List<int> allActionIds = this.allActionIds;
        for (int index = 0; index < allActionIds.Count; ++index)
        {
          if (index > 0)
            stringBuilder.Append(",");
          stringBuilder.Append(allActionIds[index]);
        }
        this.__allActionIdsString = stringBuilder.ToString();
        return this.__allActionIdsString;
      }
    }

    public override void Save()
    {
      if (!this.isEnabled)
        Debug.LogWarning((object) "Rewired: UserDataStore_PlayerPrefs is disabled and will not save any data.", (UnityEngine.Object) this);
      else
        this.SaveAll();
    }

    public override void SaveControllerData(
      int playerId,
      ControllerType controllerType,
      int controllerId)
    {
      if (!this.isEnabled)
        Debug.LogWarning((object) "Rewired: UserDataStore_PlayerPrefs is disabled and will not save any data.", (UnityEngine.Object) this);
      else
        this.SaveControllerDataNow(playerId, controllerType, controllerId);
    }

    public override void SaveControllerData(ControllerType controllerType, int controllerId)
    {
      if (!this.isEnabled)
        Debug.LogWarning((object) "Rewired: UserDataStore_PlayerPrefs is disabled and will not save any data.", (UnityEngine.Object) this);
      else
        this.SaveControllerDataNow(controllerType, controllerId);
    }

    public override void SavePlayerData(int playerId)
    {
      if (!this.isEnabled)
        Debug.LogWarning((object) "Rewired: UserDataStore_PlayerPrefs is disabled and will not save any data.", (UnityEngine.Object) this);
      else
        this.SavePlayerDataNow(playerId);
    }

    public override void SaveInputBehavior(int playerId, int behaviorId)
    {
      if (!this.isEnabled)
        Debug.LogWarning((object) "Rewired: UserDataStore_PlayerPrefs is disabled and will not save any data.", (UnityEngine.Object) this);
      else
        this.SaveInputBehaviorNow(playerId, behaviorId);
    }

    public override void Load()
    {
      if (!this.isEnabled)
        Debug.LogWarning((object) "Rewired: UserDataStore_PlayerPrefs is disabled and will not load any data.", (UnityEngine.Object) this);
      else
        this.LoadAll();
    }

    public override void LoadControllerData(
      int playerId,
      ControllerType controllerType,
      int controllerId)
    {
      if (!this.isEnabled)
        Debug.LogWarning((object) "Rewired: UserDataStore_PlayerPrefs is disabled and will not load any data.", (UnityEngine.Object) this);
      else
        this.LoadControllerDataNow(playerId, controllerType, controllerId);
    }

    public override void LoadControllerData(ControllerType controllerType, int controllerId)
    {
      if (!this.isEnabled)
        Debug.LogWarning((object) "Rewired: UserDataStore_PlayerPrefs is disabled and will not load any data.", (UnityEngine.Object) this);
      else
        this.LoadControllerDataNow(controllerType, controllerId);
    }

    public override void LoadPlayerData(int playerId)
    {
      if (!this.isEnabled)
        Debug.LogWarning((object) "Rewired: UserDataStore_PlayerPrefs is disabled and will not load any data.", (UnityEngine.Object) this);
      else
        this.LoadPlayerDataNow(playerId);
    }

    public override void LoadInputBehavior(int playerId, int behaviorId)
    {
      if (!this.isEnabled)
        Debug.LogWarning((object) "Rewired: UserDataStore_PlayerPrefs is disabled and will not load any data.", (UnityEngine.Object) this);
      else
        this.LoadInputBehaviorNow(playerId, behaviorId);
    }

    public override void OnInitialize()
    {
      if (!this.loadDataOnStart)
        return;
      this.Load();
      if (!this.loadControllerAssignments || ReInput.controllers.joystickCount <= 0)
        return;
      this.wasJoystickEverDetected = true;
      this.SaveControllerAssignments();
    }

    public override void OnControllerConnected(ControllerStatusChangedEventArgs args)
    {
      if (!this.isEnabled || args.controllerType != ControllerType.Joystick)
        return;
      this.LoadJoystickData(args.controllerId);
      if (this.loadDataOnStart && this.loadJoystickAssignments && !this.wasJoystickEverDetected)
        this.StartCoroutine(this.LoadJoystickAssignmentsDeferred());
      if (this.loadJoystickAssignments && !this.deferredJoystickAssignmentLoadPending)
        this.SaveControllerAssignments();
      this.wasJoystickEverDetected = true;
    }

    public override void OnControllerPreDisconnect(ControllerStatusChangedEventArgs args)
    {
      if (!this.isEnabled || args.controllerType != ControllerType.Joystick)
        return;
      this.SaveJoystickData(args.controllerId);
    }

    public override void OnControllerDisconnected(ControllerStatusChangedEventArgs args)
    {
      if (!this.isEnabled || !this.loadControllerAssignments)
        return;
      this.SaveControllerAssignments();
    }

    public override void SaveControllerMap(int playerId, ControllerMap controllerMap)
    {
      if (controllerMap == null)
        return;
      Player player = ReInput.players.GetPlayer(playerId);
      if (player == null)
        return;
      this.SaveControllerMap(player, controllerMap);
    }

    public override ControllerMap LoadControllerMap(
      int playerId,
      ControllerIdentifier controllerIdentifier,
      int categoryId,
      int layoutId)
    {
      Player player = ReInput.players.GetPlayer(playerId);
      return player == null ? (ControllerMap) null : this.LoadControllerMap(player, controllerIdentifier, categoryId, layoutId);
    }

    public int LoadAll()
    {
      int num = 0;
      if (this.loadControllerAssignments && this.LoadControllerAssignmentsNow())
        ++num;
      IList<Player> allPlayers = ReInput.players.AllPlayers;
      for (int index = 0; index < allPlayers.Count; ++index)
        num += this.LoadPlayerDataNow(allPlayers[index]);
      return num + this.LoadAllJoystickCalibrationData();
    }

    public int LoadPlayerDataNow(int playerId)
    {
      return this.LoadPlayerDataNow(ReInput.players.GetPlayer(playerId));
    }

    public int LoadPlayerDataNow(Player player)
    {
      if (player == null)
        return 0;
      int num = 0 + this.LoadInputBehaviors(player.id) + this.LoadControllerMaps(player.id, ControllerType.Keyboard, 0) + this.LoadControllerMaps(player.id, ControllerType.Mouse, 0);
      foreach (Joystick joystick in (IEnumerable<Joystick>) player.controllers.Joysticks)
        num += this.LoadControllerMaps(player.id, ControllerType.Joystick, joystick.id);
      this.RefreshLayoutManager(player.id);
      return num;
    }

    public int LoadAllJoystickCalibrationData()
    {
      int num = 0;
      IList<Joystick> joysticks = ReInput.controllers.Joysticks;
      for (int index = 0; index < joysticks.Count; ++index)
        num += this.LoadJoystickCalibrationData(joysticks[index]);
      return num;
    }

    public int LoadJoystickCalibrationData(Joystick joystick)
    {
      return joystick == null || !joystick.ImportCalibrationMapFromXmlString(this.GetJoystickCalibrationMapXml(joystick)) ? 0 : 1;
    }

    public int LoadJoystickCalibrationData(int joystickId)
    {
      return this.LoadJoystickCalibrationData(ReInput.controllers.GetJoystick(joystickId));
    }

    public int LoadJoystickData(int joystickId)
    {
      int num = 0;
      IList<Player> allPlayers = ReInput.players.AllPlayers;
      for (int index = 0; index < allPlayers.Count; ++index)
      {
        Player player = allPlayers[index];
        if (player.controllers.ContainsController(ControllerType.Joystick, joystickId))
        {
          num += this.LoadControllerMaps(player.id, ControllerType.Joystick, joystickId);
          this.RefreshLayoutManager(player.id);
        }
      }
      return num + this.LoadJoystickCalibrationData(joystickId);
    }

    public int LoadControllerDataNow(int playerId, ControllerType controllerType, int controllerId)
    {
      int num1 = 0 + this.LoadControllerMaps(playerId, controllerType, controllerId);
      this.RefreshLayoutManager(playerId);
      int num2 = this.LoadControllerDataNow(controllerType, controllerId);
      return num1 + num2;
    }

    public int LoadControllerDataNow(ControllerType controllerType, int controllerId)
    {
      int num = 0;
      if (controllerType == ControllerType.Joystick)
        num += this.LoadJoystickCalibrationData(controllerId);
      return num;
    }

    public int LoadControllerMaps(int playerId, ControllerType controllerType, int controllerId)
    {
      int num = 0;
      Player player = ReInput.players.GetPlayer(playerId);
      if (player == null)
        return num;
      Controller controller = ReInput.controllers.GetController(controllerType, controllerId);
      if (controller == null)
        return num;
      IList<InputMapCategory> mapCategories = ReInput.mapping.MapCategories;
      for (int index1 = 0; index1 < mapCategories.Count; ++index1)
      {
        InputMapCategory inputMapCategory = mapCategories[index1];
        if (inputMapCategory.userAssignable)
        {
          IList<InputLayout> inputLayoutList = ReInput.mapping.MapLayouts(controller.type);
          for (int index2 = 0; index2 < inputLayoutList.Count; ++index2)
          {
            InputLayout inputLayout = inputLayoutList[index2];
            ControllerMap map = this.LoadControllerMap(player, controller.identifier, inputMapCategory.id, inputLayout.id);
            if (map != null)
            {
              player.controllers.maps.AddMap(controller, map);
              ++num;
            }
          }
        }
      }
      return num;
    }

    public ControllerMap LoadControllerMap(
      Player player,
      ControllerIdentifier controllerIdentifier,
      int categoryId,
      int layoutId)
    {
      if (player == null)
        return (ControllerMap) null;
      string controllerMapXml = this.GetControllerMapXml(player, controllerIdentifier, categoryId, layoutId);
      if (string.IsNullOrEmpty(controllerMapXml))
        return (ControllerMap) null;
      ControllerMap fromXml = ControllerMap.CreateFromXml(controllerIdentifier.controllerType, controllerMapXml);
      if (fromXml == null)
        return (ControllerMap) null;
      List<int> mapKnownActionIds = this.GetControllerMapKnownActionIds(player, controllerIdentifier, categoryId, layoutId);
      this.AddDefaultMappingsForNewActions(controllerIdentifier, fromXml, mapKnownActionIds);
      return fromXml;
    }

    public int LoadInputBehaviors(int playerId)
    {
      Player player = ReInput.players.GetPlayer(playerId);
      if (player == null)
        return 0;
      int num = 0;
      IList<InputBehavior> inputBehaviors = ReInput.mapping.GetInputBehaviors(player.id);
      for (int index = 0; index < inputBehaviors.Count; ++index)
        num += this.LoadInputBehaviorNow(player, inputBehaviors[index]);
      return num;
    }

    public int LoadInputBehaviorNow(int playerId, int behaviorId)
    {
      Player player = ReInput.players.GetPlayer(playerId);
      if (player == null)
        return 0;
      InputBehavior inputBehavior = ReInput.mapping.GetInputBehavior(playerId, behaviorId);
      return inputBehavior == null ? 0 : this.LoadInputBehaviorNow(player, inputBehavior);
    }

    public int LoadInputBehaviorNow(Player player, InputBehavior inputBehavior)
    {
      if (player == null || inputBehavior == null)
        return 0;
      string inputBehaviorXml = this.GetInputBehaviorXml(player, inputBehavior.id);
      return inputBehaviorXml == null || inputBehaviorXml == string.Empty || !inputBehavior.ImportXmlString(inputBehaviorXml) ? 0 : 1;
    }

    public bool LoadControllerAssignmentsNow()
    {
      try
      {
        UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo data = this.LoadControllerAssignmentData();
        if (data == null)
          return false;
        if (this.loadKeyboardAssignments || this.loadMouseAssignments)
          this.LoadKeyboardAndMouseAssignmentsNow(data);
        if (this.loadJoystickAssignments)
          this.LoadJoystickAssignmentsNow(data);
      }
      catch
      {
      }
      return true;
    }

    public bool LoadKeyboardAndMouseAssignmentsNow(
      UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo data)
    {
      try
      {
        if (data == null && (data = this.LoadControllerAssignmentData()) == null)
          return false;
        foreach (Player allPlayer in (IEnumerable<Player>) ReInput.players.AllPlayers)
        {
          if (data.ContainsPlayer(allPlayer.id))
          {
            UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.PlayerInfo player = data.players[data.IndexOfPlayer(allPlayer.id)];
            if (this.loadKeyboardAssignments)
              allPlayer.controllers.hasKeyboard = player.hasKeyboard;
            if (this.loadMouseAssignments)
              allPlayer.controllers.hasMouse = player.hasMouse;
          }
        }
      }
      catch
      {
      }
      return true;
    }

    public bool LoadJoystickAssignmentsNow(
      UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo data)
    {
      try
      {
        if (ReInput.controllers.joystickCount == 0 || data == null && (data = this.LoadControllerAssignmentData()) == null)
          return false;
        foreach (Player allPlayer in (IEnumerable<Player>) ReInput.players.AllPlayers)
          allPlayer.controllers.ClearControllersOfType(ControllerType.Joystick);
        List<UserDataStore_PlayerPrefs.JoystickAssignmentHistoryInfo> assignmentHistoryInfoList = this.loadJoystickAssignments ? new List<UserDataStore_PlayerPrefs.JoystickAssignmentHistoryInfo>() : (List<UserDataStore_PlayerPrefs.JoystickAssignmentHistoryInfo>) null;
        foreach (Player allPlayer in (IEnumerable<Player>) ReInput.players.AllPlayers)
        {
          if (data.ContainsPlayer(allPlayer.id))
          {
            UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.PlayerInfo player = data.players[data.IndexOfPlayer(allPlayer.id)];
            for (int index = 0; index < player.joystickCount; ++index)
            {
              UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.JoystickInfo joystick1 = player.joysticks[index];
              if (joystick1 != null)
              {
                Joystick joystick = this.FindJoystickPrecise(joystick1);
                if (joystick != null)
                {
                  if (assignmentHistoryInfoList.Find((Predicate<UserDataStore_PlayerPrefs.JoystickAssignmentHistoryInfo>) (x => x.joystick == joystick)) == null)
                    assignmentHistoryInfoList.Add(new UserDataStore_PlayerPrefs.JoystickAssignmentHistoryInfo(joystick, joystick1.id));
                  allPlayer.controllers.AddController((Controller) joystick, false);
                }
              }
            }
          }
        }
        if (this.allowImpreciseJoystickAssignmentMatching)
        {
          foreach (Player allPlayer in (IEnumerable<Player>) ReInput.players.AllPlayers)
          {
            if (data.ContainsPlayer(allPlayer.id))
            {
              UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.PlayerInfo player = data.players[data.IndexOfPlayer(allPlayer.id)];
              for (int index1 = 0; index1 < player.joystickCount; ++index1)
              {
                UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.JoystickInfo joystickInfo = player.joysticks[index1];
                if (joystickInfo != null)
                {
                  Joystick joystick2 = (Joystick) null;
                  int index2 = assignmentHistoryInfoList.FindIndex((Predicate<UserDataStore_PlayerPrefs.JoystickAssignmentHistoryInfo>) (x => x.oldJoystickId == joystickInfo.id));
                  if (index2 >= 0)
                  {
                    joystick2 = assignmentHistoryInfoList[index2].joystick;
                  }
                  else
                  {
                    List<Joystick> matches;
                    if (this.TryFindJoysticksImprecise(joystickInfo, out matches))
                    {
                      foreach (Joystick joystick3 in matches)
                      {
                        Joystick match = joystick3;
                        if (assignmentHistoryInfoList.Find((Predicate<UserDataStore_PlayerPrefs.JoystickAssignmentHistoryInfo>) (x => x.joystick == match)) == null)
                        {
                          joystick2 = match;
                          break;
                        }
                      }
                      if (joystick2 != null)
                        assignmentHistoryInfoList.Add(new UserDataStore_PlayerPrefs.JoystickAssignmentHistoryInfo(joystick2, joystickInfo.id));
                      else
                        continue;
                    }
                    else
                      continue;
                  }
                  allPlayer.controllers.AddController((Controller) joystick2, false);
                }
              }
            }
          }
        }
      }
      catch
      {
      }
      if (ReInput.configuration.autoAssignJoysticks)
        ReInput.controllers.AutoAssignJoysticks();
      return true;
    }

    public UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo LoadControllerAssignmentData()
    {
      try
      {
        if (!PlayerPrefs.HasKey(this.playerPrefsKey_controllerAssignments))
          return (UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo) null;
        string json = PlayerPrefs.GetString(this.playerPrefsKey_controllerAssignments);
        if (string.IsNullOrEmpty(json))
          return (UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo) null;
        UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo assignmentSaveInfo = JsonParser.FromJson<UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo>(json);
        return assignmentSaveInfo == null || assignmentSaveInfo.playerCount == 0 ? (UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo) null : assignmentSaveInfo;
      }
      catch
      {
        return (UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo) null;
      }
    }

    public IEnumerator LoadJoystickAssignmentsDeferred()
    {
      this.deferredJoystickAssignmentLoadPending = true;
      yield return (object) new WaitForEndOfFrame();
      if (ReInput.isReady)
      {
        this.LoadJoystickAssignmentsNow((UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo) null);
        this.SaveControllerAssignments();
        this.deferredJoystickAssignmentLoadPending = false;
      }
    }

    public void SaveAll()
    {
      IList<Player> allPlayers = ReInput.players.AllPlayers;
      for (int index = 0; index < allPlayers.Count; ++index)
        this.SavePlayerDataNow(allPlayers[index]);
      this.SaveAllJoystickCalibrationData();
      if (this.loadControllerAssignments)
        this.SaveControllerAssignments();
      PlayerPrefs.Save();
    }

    public void SavePlayerDataNow(int playerId)
    {
      this.SavePlayerDataNow(ReInput.players.GetPlayer(playerId));
      PlayerPrefs.Save();
    }

    public void SavePlayerDataNow(Player player)
    {
      if (player == null)
        return;
      PlayerSaveData saveData = player.GetSaveData(true);
      this.SaveInputBehaviors(player, saveData);
      this.SaveControllerMaps(player, saveData);
    }

    public void SaveAllJoystickCalibrationData()
    {
      IList<Joystick> joysticks = ReInput.controllers.Joysticks;
      for (int index = 0; index < joysticks.Count; ++index)
        this.SaveJoystickCalibrationData(joysticks[index]);
    }

    public void SaveJoystickCalibrationData(int joystickId)
    {
      this.SaveJoystickCalibrationData(ReInput.controllers.GetJoystick(joystickId));
    }

    public void SaveJoystickCalibrationData(Joystick joystick)
    {
      if (joystick == null)
        return;
      JoystickCalibrationMapSaveData calibrationMapSaveData = joystick.GetCalibrationMapSaveData();
      PlayerPrefs.SetString(this.GetJoystickCalibrationMapPlayerPrefsKey(joystick), calibrationMapSaveData.map.ToXmlString());
    }

    public void SaveJoystickData(int joystickId)
    {
      IList<Player> allPlayers = ReInput.players.AllPlayers;
      for (int index = 0; index < allPlayers.Count; ++index)
      {
        Player player = allPlayers[index];
        if (player.controllers.ContainsController(ControllerType.Joystick, joystickId))
          this.SaveControllerMaps(player.id, ControllerType.Joystick, joystickId);
      }
      this.SaveJoystickCalibrationData(joystickId);
    }

    public void SaveControllerDataNow(
      int playerId,
      ControllerType controllerType,
      int controllerId)
    {
      this.SaveControllerMaps(playerId, controllerType, controllerId);
      this.SaveControllerDataNow(controllerType, controllerId);
      PlayerPrefs.Save();
    }

    public void SaveControllerDataNow(ControllerType controllerType, int controllerId)
    {
      if (controllerType == ControllerType.Joystick)
        this.SaveJoystickCalibrationData(controllerId);
      PlayerPrefs.Save();
    }

    public void SaveControllerMaps(Player player, PlayerSaveData playerSaveData)
    {
      foreach (ControllerMapSaveData controllerMapSaveData in playerSaveData.AllControllerMapSaveData)
        this.SaveControllerMap(player, controllerMapSaveData.map);
    }

    public void SaveControllerMaps(int playerId, ControllerType controllerType, int controllerId)
    {
      Player player = ReInput.players.GetPlayer(playerId);
      if (player == null || !player.controllers.ContainsController(controllerType, controllerId))
        return;
      ControllerMapSaveData[] mapSaveData = player.controllers.maps.GetMapSaveData(controllerType, controllerId, true);
      if (mapSaveData == null)
        return;
      for (int index = 0; index < mapSaveData.Length; ++index)
        this.SaveControllerMap(player, mapSaveData[index].map);
    }

    public void SaveControllerMap(Player player, ControllerMap controllerMap)
    {
      PlayerPrefs.SetString(this.GetControllerMapPlayerPrefsKey(player, controllerMap.controller.identifier, controllerMap.categoryId, controllerMap.layoutId, 2), controllerMap.ToXmlString());
      PlayerPrefs.SetString(this.GetControllerMapKnownActionIdsPlayerPrefsKey(player, controllerMap.controller.identifier, controllerMap.categoryId, controllerMap.layoutId, 2), this.allActionIdsString);
    }

    public void SaveInputBehaviors(Player player, PlayerSaveData playerSaveData)
    {
      if (player == null)
        return;
      foreach (InputBehavior inputBehavior in playerSaveData.inputBehaviors)
        this.SaveInputBehaviorNow(player, inputBehavior);
    }

    public void SaveInputBehaviorNow(int playerId, int behaviorId)
    {
      Player player = ReInput.players.GetPlayer(playerId);
      if (player == null)
        return;
      InputBehavior inputBehavior = ReInput.mapping.GetInputBehavior(playerId, behaviorId);
      if (inputBehavior == null)
        return;
      this.SaveInputBehaviorNow(player, inputBehavior);
      PlayerPrefs.Save();
    }

    public void SaveInputBehaviorNow(Player player, InputBehavior inputBehavior)
    {
      if (player == null || inputBehavior == null)
        return;
      PlayerPrefs.SetString(this.GetInputBehaviorPlayerPrefsKey(player, inputBehavior.id), inputBehavior.ToXmlString());
    }

    public bool SaveControllerAssignments()
    {
      try
      {
        UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo assignmentSaveInfo = new UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo(ReInput.players.allPlayerCount);
        for (int index1 = 0; index1 < ReInput.players.allPlayerCount; ++index1)
        {
          Player allPlayer = ReInput.players.AllPlayers[index1];
          UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.PlayerInfo playerInfo = new UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.PlayerInfo();
          assignmentSaveInfo.players[index1] = playerInfo;
          playerInfo.id = allPlayer.id;
          playerInfo.hasKeyboard = allPlayer.controllers.hasKeyboard;
          playerInfo.hasMouse = allPlayer.controllers.hasMouse;
          UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.JoystickInfo[] joystickInfoArray = new UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.JoystickInfo[allPlayer.controllers.joystickCount];
          playerInfo.joysticks = joystickInfoArray;
          for (int index2 = 0; index2 < allPlayer.controllers.joystickCount; ++index2)
          {
            Joystick joystick = allPlayer.controllers.Joysticks[index2];
            joystickInfoArray[index2] = new UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.JoystickInfo()
            {
              instanceGuid = ((Controller) joystick).deviceInstanceGuid,
              id = joystick.id,
              hardwareIdentifier = joystick.hardwareIdentifier
            };
          }
        }
        PlayerPrefs.SetString(this.playerPrefsKey_controllerAssignments, JsonWriter.ToJson((object) assignmentSaveInfo));
        PlayerPrefs.Save();
      }
      catch
      {
      }
      return true;
    }

    public bool ControllerAssignmentSaveDataExists()
    {
      return PlayerPrefs.HasKey(this.playerPrefsKey_controllerAssignments) && !string.IsNullOrEmpty(PlayerPrefs.GetString(this.playerPrefsKey_controllerAssignments));
    }

    public string GetBasePlayerPrefsKey(Player player)
    {
      return this.playerPrefsKeyPrefix + "|playerName=" + player.name;
    }

    public string GetControllerMapPlayerPrefsKey(
      Player player,
      ControllerIdentifier controllerIdentifier,
      int categoryId,
      int layoutId,
      int ppKeyVersion)
    {
      return this.GetBasePlayerPrefsKey(player) + "|dataType=ControllerMap" + UserDataStore_PlayerPrefs.GetControllerMapPlayerPrefsKeyCommonSuffix(player, controllerIdentifier, categoryId, layoutId, ppKeyVersion);
    }

    public string GetControllerMapKnownActionIdsPlayerPrefsKey(
      Player player,
      ControllerIdentifier controllerIdentifier,
      int categoryId,
      int layoutId,
      int ppKeyVersion)
    {
      return this.GetBasePlayerPrefsKey(player) + "|dataType=ControllerMap_KnownActionIds" + UserDataStore_PlayerPrefs.GetControllerMapPlayerPrefsKeyCommonSuffix(player, controllerIdentifier, categoryId, layoutId, ppKeyVersion);
    }

    public static string GetControllerMapPlayerPrefsKeyCommonSuffix(
      Player player,
      ControllerIdentifier controllerIdentifier,
      int categoryId,
      int layoutId,
      int ppKeyVersion)
    {
      string str1 = "";
      if (ppKeyVersion >= 2)
        str1 = str1 + "|kv=" + ppKeyVersion.ToString();
      string str2 = str1 + "|controllerMapType=" + UserDataStore_PlayerPrefs.GetControllerMapType(controllerIdentifier.controllerType).Name + "|categoryId=" + categoryId.ToString() + "|layoutId=" + layoutId.ToString();
      string prefsKeyCommonSuffix;
      if (ppKeyVersion >= 2)
      {
        prefsKeyCommonSuffix = str2 + "|hardwareGuid=" + controllerIdentifier.hardwareTypeGuid.ToString();
        if (controllerIdentifier.hardwareTypeGuid == Guid.Empty)
          prefsKeyCommonSuffix = prefsKeyCommonSuffix + "|hardwareIdentifier=" + controllerIdentifier.hardwareIdentifier;
        if (controllerIdentifier.controllerType == ControllerType.Joystick)
          prefsKeyCommonSuffix = prefsKeyCommonSuffix + "|duplicate=" + UserDataStore_PlayerPrefs.GetDuplicateIndex(player, controllerIdentifier).ToString();
      }
      else
      {
        prefsKeyCommonSuffix = str2 + "|hardwareIdentifier=" + controllerIdentifier.hardwareIdentifier;
        if (controllerIdentifier.controllerType == ControllerType.Joystick)
        {
          prefsKeyCommonSuffix = prefsKeyCommonSuffix + "|hardwareGuid=" + controllerIdentifier.hardwareTypeGuid.ToString();
          if (ppKeyVersion >= 1)
            prefsKeyCommonSuffix = prefsKeyCommonSuffix + "|duplicate=" + UserDataStore_PlayerPrefs.GetDuplicateIndex(player, controllerIdentifier).ToString();
        }
      }
      return prefsKeyCommonSuffix;
    }

    public string GetJoystickCalibrationMapPlayerPrefsKey(Joystick joystick)
    {
      return this.playerPrefsKeyPrefix + "|dataType=CalibrationMap" + "|controllerType=" + joystick.type.ToString() + "|hardwareIdentifier=" + joystick.hardwareIdentifier + "|hardwareGuid=" + joystick.hardwareTypeGuid.ToString();
    }

    public string GetInputBehaviorPlayerPrefsKey(Player player, int inputBehaviorId)
    {
      return this.GetBasePlayerPrefsKey(player) + "|dataType=InputBehavior" + "|id=" + inputBehaviorId.ToString();
    }

    public string GetControllerMapXml(
      Player player,
      ControllerIdentifier controllerIdentifier,
      int categoryId,
      int layoutId)
    {
      for (int ppKeyVersion = 2; ppKeyVersion >= 0; --ppKeyVersion)
      {
        string mapPlayerPrefsKey = this.GetControllerMapPlayerPrefsKey(player, controllerIdentifier, categoryId, layoutId, ppKeyVersion);
        if (PlayerPrefs.HasKey(mapPlayerPrefsKey))
          return PlayerPrefs.GetString(mapPlayerPrefsKey);
      }
      return (string) null;
    }

    public List<int> GetControllerMapKnownActionIds(
      Player player,
      ControllerIdentifier controllerIdentifier,
      int categoryId,
      int layoutId)
    {
      List<int> mapKnownActionIds = new List<int>();
      string key = (string) null;
      bool flag = false;
      for (int ppKeyVersion = 2; ppKeyVersion >= 0; --ppKeyVersion)
      {
        key = this.GetControllerMapKnownActionIdsPlayerPrefsKey(player, controllerIdentifier, categoryId, layoutId, ppKeyVersion);
        if (PlayerPrefs.HasKey(key))
        {
          flag = true;
          break;
        }
      }
      if (!flag)
        return mapKnownActionIds;
      string str = PlayerPrefs.GetString(key);
      if (string.IsNullOrEmpty(str))
        return mapKnownActionIds;
      string[] strArray = str.Split(',', StringSplitOptions.None);
      for (int index = 0; index < strArray.Length; ++index)
      {
        int result;
        if (!string.IsNullOrEmpty(strArray[index]) && int.TryParse(strArray[index], out result))
          mapKnownActionIds.Add(result);
      }
      return mapKnownActionIds;
    }

    public string GetJoystickCalibrationMapXml(Joystick joystick)
    {
      string mapPlayerPrefsKey = this.GetJoystickCalibrationMapPlayerPrefsKey(joystick);
      return !PlayerPrefs.HasKey(mapPlayerPrefsKey) ? string.Empty : PlayerPrefs.GetString(mapPlayerPrefsKey);
    }

    public string GetInputBehaviorXml(Player player, int id)
    {
      string behaviorPlayerPrefsKey = this.GetInputBehaviorPlayerPrefsKey(player, id);
      return !PlayerPrefs.HasKey(behaviorPlayerPrefsKey) ? string.Empty : PlayerPrefs.GetString(behaviorPlayerPrefsKey);
    }

    public void AddDefaultMappingsForNewActions(
      ControllerIdentifier controllerIdentifier,
      ControllerMap controllerMap,
      List<int> knownActionIds)
    {
      if (controllerMap == null || knownActionIds == null || knownActionIds == null || knownActionIds.Count == 0)
        return;
      ControllerMap controllerMapInstance = ReInput.mapping.GetControllerMapInstance(controllerIdentifier, controllerMap.categoryId, controllerMap.layoutId);
      if (controllerMapInstance == null)
        return;
      List<int> intList = new List<int>();
      foreach (int allActionId in this.allActionIds)
      {
        if (!knownActionIds.Contains(allActionId))
          intList.Add(allActionId);
      }
      if (intList.Count == 0)
        return;
      foreach (ActionElementMap allMap in (IEnumerable<ActionElementMap>) controllerMapInstance.AllMaps)
      {
        if (intList.Contains(allMap.actionId) && !controllerMap.DoesElementAssignmentConflict(allMap))
        {
          ElementAssignment elementAssignment = new ElementAssignment(controllerMap.controllerType, allMap.elementType, allMap.elementIdentifierId, allMap.axisRange, allMap.keyCode, allMap.modifierKeyFlags, allMap.actionId, allMap.axisContribution, allMap.invert);
          controllerMap.CreateElementMap(elementAssignment);
        }
      }
    }

    public Joystick FindJoystickPrecise(
      UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.JoystickInfo joystickInfo)
    {
      if (joystickInfo == null)
        return (Joystick) null;
      if (joystickInfo.instanceGuid == Guid.Empty)
        return (Joystick) null;
      IList<Joystick> joysticks = ReInput.controllers.Joysticks;
      for (int index = 0; index < joysticks.Count; ++index)
      {
        if (((Controller) joysticks[index]).deviceInstanceGuid == joystickInfo.instanceGuid)
          return joysticks[index];
      }
      return (Joystick) null;
    }

    public bool TryFindJoysticksImprecise(
      UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.JoystickInfo joystickInfo,
      out List<Joystick> matches)
    {
      matches = (List<Joystick>) null;
      if (joystickInfo == null || string.IsNullOrEmpty(joystickInfo.hardwareIdentifier))
        return false;
      IList<Joystick> joysticks = ReInput.controllers.Joysticks;
      for (int index = 0; index < joysticks.Count; ++index)
      {
        if (string.Equals(joysticks[index].hardwareIdentifier, joystickInfo.hardwareIdentifier, StringComparison.OrdinalIgnoreCase))
        {
          if (matches == null)
            matches = new List<Joystick>();
          matches.Add(joysticks[index]);
        }
      }
      return matches != null;
    }

    public static int GetDuplicateIndex(Player player, ControllerIdentifier controllerIdentifier)
    {
      Controller controller1 = ReInput.controllers.GetController(controllerIdentifier);
      if (controller1 == null)
        return 0;
      int duplicateIndex = 0;
      foreach (Controller controller2 in player.controllers.Controllers)
      {
        if (controller2.type == controller1.type)
        {
          bool flag = false;
          if (controller1.type == ControllerType.Joystick)
          {
            if (!((controller2 as Joystick).hardwareTypeGuid != controller1.hardwareTypeGuid))
            {
              if (controller1.hardwareTypeGuid != Guid.Empty)
                flag = true;
            }
            else
              continue;
          }
          if (flag || !(controller2.hardwareIdentifier != controller1.hardwareIdentifier))
          {
            if (controller2 == controller1)
              return duplicateIndex;
            ++duplicateIndex;
          }
        }
      }
      return duplicateIndex;
    }

    public void RefreshLayoutManager(int playerId)
    {
      ReInput.players.GetPlayer(playerId)?.controllers.maps.layoutManager.Apply();
    }

    public static System.Type GetControllerMapType(ControllerType controllerType)
    {
      switch (controllerType)
      {
        case ControllerType.Keyboard:
          return typeof (KeyboardMap);
        case ControllerType.Mouse:
          return typeof (MouseMap);
        case ControllerType.Joystick:
          return typeof (JoystickMap);
        case ControllerType.Custom:
          return typeof (CustomControllerMap);
        default:
          Debug.LogWarning((object) ("Rewired: Unknown ControllerType " + controllerType.ToString()));
          return (System.Type) null;
      }
    }

    public class ControllerAssignmentSaveInfo
    {
      public UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.PlayerInfo[] players;

      public int playerCount => this.players == null ? 0 : this.players.Length;

      public ControllerAssignmentSaveInfo()
      {
      }

      public ControllerAssignmentSaveInfo(int playerCount)
      {
        this.players = new UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.PlayerInfo[playerCount];
        for (int index = 0; index < playerCount; ++index)
          this.players[index] = new UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.PlayerInfo();
      }

      public int IndexOfPlayer(int playerId)
      {
        for (int index = 0; index < this.playerCount; ++index)
        {
          if (this.players[index] != null && this.players[index].id == playerId)
            return index;
        }
        return -1;
      }

      public bool ContainsPlayer(int playerId) => this.IndexOfPlayer(playerId) >= 0;

      public class PlayerInfo
      {
        public int id;
        public bool hasKeyboard;
        public bool hasMouse;
        public UserDataStore_PlayerPrefs.ControllerAssignmentSaveInfo.JoystickInfo[] joysticks;

        public int joystickCount => this.joysticks == null ? 0 : this.joysticks.Length;

        public int IndexOfJoystick(int joystickId)
        {
          for (int index = 0; index < this.joystickCount; ++index)
          {
            if (this.joysticks[index] != null && this.joysticks[index].id == joystickId)
              return index;
          }
          return -1;
        }

        public bool ContainsJoystick(int joystickId) => this.IndexOfJoystick(joystickId) >= 0;
      }

      public class JoystickInfo
      {
        public Guid instanceGuid;
        public string hardwareIdentifier;
        public int id;
      }
    }

    public class JoystickAssignmentHistoryInfo
    {
      public readonly Joystick joystick;
      public readonly int oldJoystickId;

      public JoystickAssignmentHistoryInfo(Joystick joystick, int oldJoystickId)
      {
        this.joystick = joystick != null ? joystick : throw new ArgumentNullException(nameof (joystick));
        this.oldJoystickId = oldJoystickId;
      }
    }
  }
}
