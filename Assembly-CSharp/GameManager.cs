// Decompiled with JetBrains decompiler
// Type: GameManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections;
using System.Globalization;
using System.Threading;
using UnityEngine;

public class GameManager : MonoBehaviourSingleton<GameManager>
{
  public const float CARD_WIDTH = 3f;
  public const float CARD_HEIGHT = 4.5f;
  public static readonly Vector2 CARD_SIZE = new Vector2(3f, 4.5f);
  public const float LARGE_UI = 0.0f;
  [SerializeField]
  private int targetFrameRate = -1;
  [SerializeField]
  private int editorTargetFrameRate = 60;
  private static int tasksInProgress = 0;
  private static bool init;
  public static bool End;
  public static bool paused;
  public static readonly CultureInfo CultureInfo = CultureInfo.CreateSpecificCulture("en-GB");

  public static bool Busy => GameManager.tasksInProgress > 0 || !GameManager.init;

  public static bool Ready => GameManager.init;

  private IEnumerator Start()
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

  private void OnApplicationQuit()
  {
    Debug.Log((object) ">>>> GAME END <<<<");
    GameManager.End = true;
    Events.InvokeGameEnd();
  }

  public static void Quit() => Application.Quit();
}
