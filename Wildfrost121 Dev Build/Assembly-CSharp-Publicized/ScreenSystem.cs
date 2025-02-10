// Decompiled with JetBrains decompiler
// Type: ScreenSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
public class ScreenSystem : GameSystem
{
  public static ScreenSystem instance;
  public int windowedWidth = 1920;
  public int windowedHeight = 1080;
  public FullScreenMode windowedMode = FullScreenMode.Windowed;
  public FullScreenMode fullMode = FullScreenMode.FullScreenWindow;
  public int _displayIndex;
  public int current;
  public int vsync;
  public int targetFramerate;

  public int fullScreenWidth => this.display.systemWidth;

  public int fullScreenHeight => this.display.systemHeight;

  public int displayIndex
  {
    get
    {
      if (this._displayIndex >= Display.displays.Length)
        this._displayIndex = Display.displays.Length - 1;
      return this._displayIndex;
    }
  }

  public Display display => Display.displays[this.displayIndex];

  public static bool IsWindowed
  {
    get
    {
      return Screen.fullScreenMode == FullScreenMode.Windowed || Screen.fullScreenMode == FullScreenMode.MaximizedWindow;
    }
  }

  public void OnEnable()
  {
    ScreenSystem.instance = this;
    switch (Screen.fullScreenMode)
    {
      case FullScreenMode.ExclusiveFullScreen:
        this.current = 1;
        break;
      case FullScreenMode.FullScreenWindow:
        this.current = 2;
        break;
      case FullScreenMode.MaximizedWindow:
      case FullScreenMode.Windowed:
        this.current = 0;
        break;
    }
    global::Events.OnSettingChanged += new UnityAction<string, object>(this.SettingChanged);
    int mode = Settings.Load<int>("DisplayMode", 2);
    if (mode != this.current)
      this.Set(mode);
    this.vsync = Settings.Load<int>("Vsync", 1);
    ScreenSystem.SetVsync(this.vsync);
    this.targetFramerate = Settings.Load<int>("TargetFramerate", 2);
    ScreenSystem.SetTargetFramerate(this.targetFramerate);
  }

  public void OnDisable()
  {
    global::Events.OnSettingChanged -= new UnityAction<string, object>(this.SettingChanged);
  }

  public void SettingChanged(string key, object value)
  {
    if (!(value is int mode))
      return;
    switch (key)
    {
      case "DisplayMode":
        this.Set(mode);
        break;
      case "TargetFramerate":
        ScreenSystem.SetTargetFramerate(mode);
        break;
      case "Vsync":
        ScreenSystem.SetVsync(mode);
        break;
    }
  }

  public void Update()
  {
    if (!Input.GetKeyDown(KeyCode.Return) || !Input.GetKey(KeyCode.LeftAlt))
      return;
    if (ScreenSystem.IsWindowed)
      Settings.Save<int>("DisplayMode", this.fullMode == FullScreenMode.ExclusiveFullScreen ? 1 : 2);
    else
      Settings.Save<int>("DisplayMode", 0);
    SetSettingInt setSettingInt = ((IEnumerable<SetSettingInt>) UnityEngine.Object.FindObjectsOfType<SetSettingInt>()).FirstOrDefault<SetSettingInt>((Func<SetSettingInt, bool>) (a => a.Key == "DisplayMode"));
    if (setSettingInt == null)
      return;
    setSettingInt.enabled = false;
    setSettingInt.enabled = true;
  }

  public void Set(int mode)
  {
    this.current = mode;
    switch (mode.Mod(3))
    {
      case 0:
        this.SetWindowed();
        break;
      case 1:
        this.SetFull();
        break;
      case 2:
        this.SetBorderless();
        break;
    }
  }

  public void SetWindowed(int forceWidth = 0, int forceHeight = 0)
  {
    Debug.Log((object) "Screen Mode: Windowed");
    if (!ScreenSystem.IsWindowed)
      this.fullMode = Screen.fullScreenMode;
    Screen.fullScreenMode = this.windowedMode;
    Screen.SetResolution(forceWidth > 0 ? forceWidth : this.windowedWidth, forceHeight > 0 ? forceHeight : this.windowedHeight, this.windowedMode);
  }

  public void SetFull(int forceWidth = 0, int forceHeight = 0)
  {
    Debug.Log((object) "Screen Mode: Fullscreen");
    if (ScreenSystem.IsWindowed)
    {
      this.windowedWidth = Screen.width;
      this.windowedHeight = Screen.height;
      this.windowedMode = Screen.fullScreenMode;
    }
    Screen.fullScreenMode = FullScreenMode.ExclusiveFullScreen;
    Screen.SetResolution(forceWidth > 0 ? forceWidth : this.fullScreenWidth, forceHeight > 0 ? forceHeight : this.fullScreenHeight, FullScreenMode.ExclusiveFullScreen);
  }

  public void SetBorderless(int forceWidth = 0, int forceHeight = 0)
  {
    Debug.Log((object) "Screen Mode: Borderless");
    if (ScreenSystem.IsWindowed)
    {
      this.windowedWidth = Screen.width;
      this.windowedHeight = Screen.height;
      this.windowedMode = Screen.fullScreenMode;
    }
    Screen.fullScreenMode = FullScreenMode.FullScreenWindow;
    Screen.SetResolution(forceWidth > 0 ? forceWidth : this.fullScreenWidth, forceHeight > 0 ? forceHeight : this.fullScreenHeight, FullScreenMode.FullScreenWindow);
  }

  public static void SetTargetFramerate(int mode)
  {
    mode = Mathf.Clamp(mode, 0, 4);
    int num;
    switch (mode)
    {
      case 0:
        num = -1;
        break;
      case 1:
        num = 30;
        break;
      case 2:
        num = 60;
        break;
      case 3:
        num = 120;
        break;
      case 4:
        num = 240;
        break;
      default:
        num = Application.targetFrameRate;
        break;
    }
    Application.targetFrameRate = num;
  }

  public static void SetVsync(int mode) => QualitySettings.vSyncCount = Mathf.Clamp(mode, 0, 1);

  public static void SetResolutionFullscreen(int width, int height)
  {
    ScreenSystem.instance.SetFull(width, height);
  }

  public static void SetResolutionBorderless(int width, int height)
  {
    ScreenSystem.instance.SetBorderless(width, height);
  }

  public static void SetResolutionWindowed(int width, int height)
  {
    ScreenSystem.instance.SetWindowed(width, height);
  }
}
