// Decompiled with JetBrains decompiler
// Type: RewiredControllerManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using Rewired;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

#nullable disable
public class RewiredControllerManager : MonoBehaviour
{
  public static RewiredControllerManager instance;
  public int maxPlayers = 4;
  public static readonly List<RewiredControllerManager.PlayerMap> playerMaps = new List<RewiredControllerManager.PlayerMap>();
  public static int gamePlayerIdCounter = 0;
  public static Player leadPlayer;
  public const int maxJoysticksPerPlayer = 1;

  public void Awake()
  {
    if ((bool) (UnityEngine.Object) RewiredControllerManager.instance && (UnityEngine.Object) RewiredControllerManager.instance != (UnityEngine.Object) this)
    {
      UnityEngine.Object.Destroy((UnityEngine.Object) this);
    }
    else
    {
      RewiredControllerManager.instance = this;
      this.AssignNextPlayer(0);
    }
  }

  public void OnEnable()
  {
    ReInput.ControllerConnectedEvent += new Action<ControllerStatusChangedEventArgs>(RewiredControllerManager.ControllerConnected);
    ReInput.ControllerDisconnectedEvent += new Action<ControllerStatusChangedEventArgs>(RewiredControllerManager.ControllerDisconnected);
  }

  public void OnDisable()
  {
    ReInput.ControllerConnectedEvent -= new Action<ControllerStatusChangedEventArgs>(RewiredControllerManager.ControllerConnected);
    ReInput.ControllerDisconnectedEvent -= new Action<ControllerStatusChangedEventArgs>(RewiredControllerManager.ControllerDisconnected);
  }

  public static void ControllerConnected(ControllerStatusChangedEventArgs args)
  {
    Player playerController = RewiredControllerManager.GetPlayerController(0);
    bool flag = false;
    for (int index = playerController.controllers.joystickCount + 1; index > 1; --index)
    {
      playerController.controllers.RemoveController((Controller) playerController.controllers.Joysticks[0]);
      flag = true;
    }
    if (!playerController.controllers.ContainsController(args.controller))
    {
      playerController.controllers.AddController(args.controller, true);
      flag = true;
    }
    if (!flag)
      return;
    Debug.LogWarning((object) ("Rewired: [" + playerController.name + "] controllers → " + string.Join(", ", playerController.controllers.Controllers.Select<Controller, string>((Func<Controller, string>) (a => a.name)))));
    Events.InvokeControllerSwitched();
  }

  public static void ControllerDisconnected(ControllerStatusChangedEventArgs args)
  {
    Player playerController = RewiredControllerManager.GetPlayerController(0);
    bool flag = false;
    if (playerController.controllers.ContainsController(args.controller))
    {
      playerController.controllers.RemoveController(args.controller);
      flag = true;
    }
    int num = playerController.controllers.joystickCount - 1;
    if (num < 1)
    {
      foreach (Joystick joystick in (IEnumerable<Joystick>) ReInput.controllers.Joysticks)
      {
        if (!playerController.controllers.ContainsController((Controller) joystick))
        {
          playerController.controllers.AddController((Controller) joystick, true);
          flag = true;
          if (++num >= 1)
            break;
        }
      }
    }
    if (!flag)
      return;
    Debug.LogWarning((object) ("Rewired: [" + playerController.name + "] controllers → " + string.Join(", ", playerController.controllers.Controllers.Select<Controller, string>((Func<Controller, string>) (a => a.name)))));
    Events.InvokeControllerSwitched();
  }

  public Player AssignNextPlayer(int rewiredPlayerId)
  {
    RewiredControllerManager.PlayerMap playerMap = RewiredControllerManager.playerMaps.FirstOrDefault<RewiredControllerManager.PlayerMap>((Func<RewiredControllerManager.PlayerMap, bool>) (a => a.rewiredPlayerId == rewiredPlayerId));
    if (playerMap != null)
      return ReInput.players.GetPlayer(playerMap.rewiredPlayerId);
    Debug.Log((object) string.Format("ControllerManager → Assigning Player {0}", (object) rewiredPlayerId));
    if (RewiredControllerManager.playerMaps.Count >= this.maxPlayers)
    {
      Debug.LogError((object) "Max player limit already reached!");
      return (Player) null;
    }
    int nextGamePlayerId = this.GetNextGamePlayerId();
    RewiredControllerManager.playerMaps.Add(new RewiredControllerManager.PlayerMap(rewiredPlayerId, nextGamePlayerId));
    Player player = ReInput.players.GetPlayer(rewiredPlayerId);
    Debug.Log((object) string.Format("Assigning Rewired Player id {0} to Game Player {1}", (object) rewiredPlayerId, (object) nextGamePlayerId));
    if (RewiredControllerManager.leadPlayer == null)
    {
      Debug.Log((object) string.Format("Player {0} set as lead player", (object) rewiredPlayerId));
      RewiredControllerManager.leadPlayer = player;
    }
    if (player.controllers.joystickCount < 1)
    {
      foreach (Joystick joystick in (IEnumerable<Joystick>) ReInput.controllers.Joysticks)
      {
        if (!player.controllers.Joysticks.Contains(joystick))
        {
          player.controllers.AddController((Controller) joystick, true);
          if (player.controllers.joystickCount >= 1)
            break;
        }
      }
    }
    Debug.LogWarning((object) ("Rewired: [" + player.name + "] controllers → " + string.Join(", ", player.controllers.Controllers.Select<Controller, string>((Func<Controller, string>) (a => a.name)))));
    return player;
  }

  public void AssignJoystickMap(Player rewiredPlayer, string newMap)
  {
    rewiredPlayer.controllers.maps.SetAllMapsEnabled(false);
    rewiredPlayer.controllers.maps.SetMapsEnabled(true, newMap);
  }

  public void AssignJoystickMap(int playerNumber, string newMap)
  {
    this.AssignJoystickMap(RewiredControllerManager.GetPlayerController(playerNumber), newMap);
  }

  public int GetNextGamePlayerId() => RewiredControllerManager.gamePlayerIdCounter++;

  public List<RewiredControllerManager.PlayerMap> GetActiveDevices()
  {
    return RewiredControllerManager.playerMaps;
  }

  public IList<Player> GetPlayers() => ReInput.players.GetPlayers(false);

  public static Player GetPlayerController(int gamePlayerId)
  {
    if (!ReInput.isReady)
      return (Player) null;
    if (!(bool) (UnityEngine.Object) RewiredControllerManager.instance)
    {
      Debug.LogError((object) "Not initialized. Do you have a PressStartToJoinPlayerSelector in your scene?");
      return (Player) null;
    }
    RewiredControllerManager.PlayerMap playerMap = RewiredControllerManager.playerMaps.FirstOrDefault<RewiredControllerManager.PlayerMap>((Func<RewiredControllerManager.PlayerMap, bool>) (a => a.gamePlayerId == gamePlayerId));
    return playerMap == null ? RewiredControllerManager.instance.AssignNextPlayer(gamePlayerId) : ReInput.players.GetPlayer(playerMap.rewiredPlayerId);
  }

  public static int GetPlayerID(int rewiredControllerID)
  {
    if (!ReInput.isReady)
      return -1;
    if ((UnityEngine.Object) RewiredControllerManager.instance == (UnityEngine.Object) null)
    {
      Debug.LogError((object) "Not initialized. Do you have a PressStartToJoinPlayerSelector in your scehe?");
      return -1;
    }
    foreach (RewiredControllerManager.PlayerMap playerMap in RewiredControllerManager.playerMaps)
    {
      if (playerMap.rewiredPlayerId == rewiredControllerID)
        return playerMap.gamePlayerId;
    }
    return -1;
  }

  public void ClearAssignedControllers()
  {
    foreach (RewiredControllerManager.PlayerMap playerMap in RewiredControllerManager.playerMaps)
      playerMap.gamePlayerId = -1;
  }

  public bool IsPlayerControllerConnected(int playerIndex)
  {
    return RewiredControllerManager.playerMaps.Count<RewiredControllerManager.PlayerMap>((Func<RewiredControllerManager.PlayerMap, bool>) (x => x.gamePlayerId == playerIndex)) > 0;
  }

  public bool IsControllerConnected(int controllerIndex)
  {
    return ReInput.players.Players.Count<Player>((Func<Player, bool>) (x => x.id == controllerIndex)) > 0;
  }

  public void AssignControllerToPlayer(int i, int controllerIndex)
  {
    RewiredControllerManager.playerMaps.First<RewiredControllerManager.PlayerMap>((Func<RewiredControllerManager.PlayerMap, bool>) (x => x.rewiredPlayerId == controllerIndex)).gamePlayerId = i;
  }

  public bool AnyControllerConnected() => RewiredControllerManager.playerMaps.Count > 0;

  public bool IsButtonPressed(string input = "", bool IsPositive = true)
  {
    if (!this.enabled)
      return false;
    int callingPlayer = -1;
    return this.IsButtonPressed(out callingPlayer, input, IsPositive);
  }

  public bool IsButtonPressed(out int callingPlayer, string input = "", bool IsPositive = true)
  {
    bool state = false;
    callingPlayer = -1;
    if (IsPositive)
    {
      foreach (Player player in (IEnumerable<Player>) ReInput.players.GetPlayers(false))
      {
        if ((input == "" ? (player.GetAnyButtonDown() ? 1 : 0) : (player.GetButtonDown(input) ? 1 : 0)) != 0)
        {
          RewiredControllerManager.instance.ReturnTrueWithPlayer(out callingPlayer, out state, player);
          break;
        }
      }
    }
    else
    {
      foreach (Player player in (IEnumerable<Player>) ReInput.players.GetPlayers(false))
      {
        if ((input == "" ? (player.GetAnyNegativeButtonDown() ? 1 : 0) : (player.GetNegativeButtonDown(input) ? 1 : 0)) != 0)
        {
          RewiredControllerManager.instance.ReturnTrueWithPlayer(out callingPlayer, out state, player);
          break;
        }
      }
    }
    return state;
  }

  public bool IsButtonHeld(string input = "", bool IsPositive = true)
  {
    if (!this.enabled)
      return false;
    int callingPlayer = -1;
    return this.IsButtonHeld(out callingPlayer, input, IsPositive);
  }

  public bool IsButtonHeld(out int callingPlayer, string input = "", bool IsPositive = true)
  {
    bool state = false;
    callingPlayer = -1;
    if (IsPositive)
    {
      foreach (Player player in (IEnumerable<Player>) ReInput.players.GetPlayers(false))
      {
        if ((input == "" ? (player.GetAnyButton() ? 1 : (player.GetAnyNegativeButton() ? 1 : 0)) : (player.GetButton(input) ? 1 : 0)) != 0)
        {
          this.ReturnTrueWithPlayer(out callingPlayer, out state, player);
          break;
        }
      }
    }
    else
    {
      foreach (Player player in (IEnumerable<Player>) ReInput.players.GetPlayers(false))
      {
        if ((input == "" ? (player.GetAnyButton() ? 1 : (player.GetAnyNegativeButton() ? 1 : 0)) : (player.GetNegativeButton(input) ? 1 : 0)) != 0)
        {
          this.ReturnTrueWithPlayer(out callingPlayer, out state, player);
          break;
        }
      }
    }
    return state;
  }

  public bool IsButtonLongHeld(string input = "", bool IsPositive = true)
  {
    if (!this.enabled)
      return false;
    int callingPlayer = -1;
    return this.IsButtonLongHeld(out callingPlayer, input, IsPositive);
  }

  public bool IsButtonLongHeld(out int callingPlayer, string input = "", bool IsPositive = true)
  {
    bool state = false;
    callingPlayer = -1;
    if (IsPositive)
    {
      foreach (Player player in (IEnumerable<Player>) ReInput.players.GetPlayers(false))
      {
        if ((input == "" ? (player.GetAnyButton() ? 1 : 0) : (player.GetButtonLongPress(input) ? 1 : 0)) != 0)
        {
          this.ReturnTrueWithPlayer(out callingPlayer, out state, player);
          break;
        }
      }
    }
    else
    {
      foreach (Player player in (IEnumerable<Player>) ReInput.players.GetPlayers(false))
      {
        if ((input == "" ? (player.GetAnyNegativeButton() ? 1 : 0) : (player.GetNegativeButtonLongPress(input) ? 1 : 0)) != 0)
        {
          this.ReturnTrueWithPlayer(out callingPlayer, out state, player);
          break;
        }
      }
    }
    return state;
  }

  public bool IsButtonReleased(string input = "", bool IsPositive = true)
  {
    if (!this.enabled)
      return false;
    int callingPlayer = -1;
    return this.IsButtonReleased(out callingPlayer, input, IsPositive);
  }

  public bool IsButtonReleased(out int callingPlayer, string input = "", bool IsPositive = true)
  {
    bool state = false;
    callingPlayer = -1;
    if (IsPositive)
    {
      foreach (Player player in (IEnumerable<Player>) ReInput.players.GetPlayers(false))
      {
        if ((input == "" ? (player.GetAnyButtonUp() ? 1 : 0) : (player.GetButtonUp(input) ? 1 : 0)) != 0)
        {
          this.ReturnTrueWithPlayer(out callingPlayer, out state, player);
          break;
        }
      }
    }
    else
    {
      foreach (Player player in (IEnumerable<Player>) ReInput.players.GetPlayers(false))
      {
        if ((input == "" ? (player.GetAnyNegativeButtonUp() ? 1 : 0) : (player.GetNegativeButtonUp(input) ? 1 : 0)) != 0)
        {
          this.ReturnTrueWithPlayer(out callingPlayer, out state, player);
          break;
        }
      }
    }
    return state;
  }

  public bool WasButtonReleased(string input = "", bool IsPositive = true)
  {
    int callingPlayer = -1;
    return this.WasButtonReleased(out callingPlayer, input, IsPositive);
  }

  public bool WasButtonReleased(out int callingPlayer, string input = "", bool IsPositive = true)
  {
    bool state = false;
    callingPlayer = -1;
    if (IsPositive)
    {
      foreach (Player player in (IEnumerable<Player>) ReInput.players.GetPlayers(false))
      {
        if ((input == "" ? (!player.GetAnyButtonPrev() ? 1 : 0) : (!player.GetButtonPrev(input) ? 1 : 0)) != 0)
        {
          this.ReturnTrueWithPlayer(out callingPlayer, out state, player);
          break;
        }
      }
    }
    else
    {
      foreach (Player player in (IEnumerable<Player>) ReInput.players.GetPlayers(false))
      {
        if ((input == "" ? (!player.GetAnyNegativeButtonPrev() ? 1 : 0) : (!player.GetNegativeButtonPrev(input) ? 1 : 0)) != 0)
        {
          this.ReturnTrueWithPlayer(out callingPlayer, out state, player);
          break;
        }
      }
    }
    return state;
  }

  public bool WasButtonPressed(string input = "", bool IsPositive = true)
  {
    int callingPlayer = -1;
    return this.WasButtonPressed(out callingPlayer, input, IsPositive);
  }

  public bool WasButtonPressed(out int callingPlayer, string input = "", bool IsPositive = true)
  {
    bool state = false;
    callingPlayer = -1;
    if (IsPositive)
    {
      foreach (Player player in (IEnumerable<Player>) ReInput.players.GetPlayers(false))
      {
        if ((input == "" ? (player.GetAnyButtonPrev() ? 1 : 0) : (player.GetButtonPrev(input) ? 1 : 0)) != 0)
        {
          this.ReturnTrueWithPlayer(out callingPlayer, out state, player);
          break;
        }
      }
    }
    else
    {
      foreach (Player player in (IEnumerable<Player>) ReInput.players.GetPlayers(false))
      {
        if ((input == "" ? (player.GetAnyNegativeButtonPrev() ? 1 : 0) : (player.GetNegativeButtonPrev(input) ? 1 : 0)) != 0)
        {
          this.ReturnTrueWithPlayer(out callingPlayer, out state, player);
          break;
        }
      }
    }
    return state;
  }

  public float GetAnalogPositive(string input = "")
  {
    if (!this.enabled)
      return 0.0f;
    int callingPlayer = -1;
    return this.GetAnalog(out callingPlayer, input, true);
  }

  public float GetAnalogNegative(string input = "")
  {
    if (!this.enabled)
      return 0.0f;
    int callingPlayer = -1;
    return this.GetAnalog(out callingPlayer, input, false);
  }

  public float GetAnalog(string input = "")
  {
    if (!this.enabled)
      return 0.0f;
    float f = 0.0f;
    foreach (Player player in (IEnumerable<Player>) ReInput.players.GetPlayers(false))
    {
      float axis = player.GetAxis(input);
      if ((double) Mathf.Abs(axis) > (double) Mathf.Abs(f))
        f = axis;
    }
    return f;
  }

  public float GetAnalog(out int callingPlayer, string input, bool lookingForPositive)
  {
    float analog = 0.0f;
    callingPlayer = -1;
    foreach (Player player in (IEnumerable<Player>) ReInput.players.GetPlayers(false))
    {
      Player x = player;
      if (lookingForPositive)
      {
        if ((double) x.GetAxis(input) > (double) analog)
        {
          callingPlayer = RewiredControllerManager.playerMaps.Count<RewiredControllerManager.PlayerMap>((Func<RewiredControllerManager.PlayerMap, bool>) (y => y.rewiredPlayerId == x.id)) <= 0 ? -1 : RewiredControllerManager.playerMaps.First<RewiredControllerManager.PlayerMap>((Func<RewiredControllerManager.PlayerMap, bool>) (y => y.rewiredPlayerId == x.id)).gamePlayerId;
          analog = x.GetAxis(input);
        }
      }
      else if ((double) x.GetAxis(input) < (double) analog)
      {
        callingPlayer = RewiredControllerManager.playerMaps.Count<RewiredControllerManager.PlayerMap>((Func<RewiredControllerManager.PlayerMap, bool>) (y => y.rewiredPlayerId == x.id)) <= 0 ? -1 : RewiredControllerManager.playerMaps.First<RewiredControllerManager.PlayerMap>((Func<RewiredControllerManager.PlayerMap, bool>) (y => y.rewiredPlayerId == x.id)).gamePlayerId;
        analog = x.GetAxis(input);
      }
    }
    return analog;
  }

  public void ReturnTrueWithPlayer(out int callingPlayer, out bool state, Player x)
  {
    callingPlayer = RewiredControllerManager.playerMaps.Count<RewiredControllerManager.PlayerMap>((Func<RewiredControllerManager.PlayerMap, bool>) (y => y.rewiredPlayerId == x.id)) <= 0 ? -1 : RewiredControllerManager.playerMaps.First<RewiredControllerManager.PlayerMap>((Func<RewiredControllerManager.PlayerMap, bool>) (y => y.rewiredPlayerId == x.id)).gamePlayerId;
    state = true;
  }

  public int GetDeviceCount()
  {
    return RewiredControllerManager.playerMaps.Count<RewiredControllerManager.PlayerMap>();
  }

  public void SetActiveControllersToMap(string newControllerMap)
  {
    foreach (RewiredControllerManager.PlayerMap activeDevice in RewiredControllerManager.instance.GetActiveDevices())
      RewiredControllerManager.instance.AssignJoystickMap(activeDevice.gamePlayerId, newControllerMap);
  }

  public class PlayerMap
  {
    public int rewiredPlayerId;
    public int gamePlayerId;

    public PlayerMap(int rewiredPlayerId, int gamePlayerId)
    {
      this.rewiredPlayerId = rewiredPlayerId;
      this.gamePlayerId = gamePlayerId;
    }
  }
}
