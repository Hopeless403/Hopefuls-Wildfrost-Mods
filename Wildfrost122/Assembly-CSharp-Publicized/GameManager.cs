// Decompiled with JetBrains decompiler
// Type: GameManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections;
using System.Globalization;
using System.Threading;
using UnityEngine;

#nullable disable
public class GameManager : MonoBehaviourSingleton<GameManager>
{
  public const float CARD_WIDTH = 3f;
  public const float CARD_HEIGHT = 4.5f;
  public static readonly Vector2 CARD_SIZE = new Vector2(3f, 4.5f);
  public const float LARGE_UI = 0.0f;
  [SerializeField]
  public int targetFrameRate = -1;
  [SerializeField]
  public int editorTargetFrameRate = 60;
  public static int tasksInProgress = 0;
  public static bool init;
  public static bool End;
  public static bool paused;
  public static readonly CultureInfo CultureInfo = CultureInfo.CreateSpecificCulture("en-GB");

  public static bool Busy => GameManager.tasksInProgress > 0 || !GameManager.init;

  public static bool Ready => GameManager.init;

  public IEnumerator Start()
  {
    Thread.CurrentThread.CurrentCulture = GameManager.CultureInfo;
    Application.targetFrameRate = this.targetFrameRate;
    UnityEngine.Random.InitState((int) DateTime.Now.Ticks);
    Debug.Log((object) "RELEASE = TRUE");
    yield return (object) null;
    yield return (object) new WaitUntil((Func<bool>) (() => Bootstrap.Count <= 0));
    GameManager.init = true;
    Events.InvokeGameStart();
  }

  public void OnApplicationQuit()
  {
    Debug.Log((object) ">>>> GAME END <<<<");
    GameManager.End = true;
    Events.InvokeGameEnd();
  }

  public static void Quit() => Application.Quit();
}
