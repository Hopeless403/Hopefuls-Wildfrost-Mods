// Decompiled with JetBrains decompiler
// Type: LeanTest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

#nullable disable
public class LeanTest
{
  public static int expected = 0;
  private static int tests = 0;
  private static int passes = 0;
  public static float timeout = 15f;
  public static bool timeoutStarted = false;
  public static bool testsFinished = false;

  public static void debug(string name, bool didPass, string failExplaination = null)
  {
    LeanTest.expect(didPass, name, failExplaination);
  }

  public static void expect(bool didPass, string definition, string failExplaination = null)
  {
    string str = "".PadRight(40 - (int) ((double) LeanTest.printOutLength(definition) * 1.0499999523162842), "_"[0]);
    string message = LeanTest.formatB(definition) + " " + str + " [ " + (didPass ? LeanTest.formatC("pass", "green") : LeanTest.formatC("fail", "red")) + " ]";
    if (!didPass && failExplaination != null)
      message = message + " - " + failExplaination;
    Debug.Log((object) message);
    if (didPass)
      ++LeanTest.passes;
    ++LeanTest.tests;
    if (LeanTest.tests == LeanTest.expected && !LeanTest.testsFinished)
      LeanTest.overview();
    else if (LeanTest.tests > LeanTest.expected)
      Debug.Log((object) (LeanTest.formatB("Too many tests for a final report!") + " set LeanTest.expected = " + LeanTest.tests.ToString()));
    if (LeanTest.timeoutStarted)
      return;
    LeanTest.timeoutStarted = true;
    GameObject gameObject = new GameObject();
    gameObject.name = "~LeanTest";
    (gameObject.AddComponent(typeof (LeanTester)) as LeanTester).timeout = LeanTest.timeout;
    gameObject.hideFlags = HideFlags.HideAndDontSave;
  }

  public static string padRight(int len)
  {
    string str = "";
    for (int index = 0; index < len; ++index)
      str += "_";
    return str;
  }

  public static float printOutLength(string str)
  {
    float num = 0.0f;
    for (int index = 0; index < str.Length; ++index)
    {
      if ((int) str[index] == (int) "I"[0])
        num += 0.5f;
      else if ((int) str[index] == (int) "J"[0])
        num += 0.85f;
      else
        ++num;
    }
    return num;
  }

  public static string formatBC(string str, string color)
  {
    return LeanTest.formatC(LeanTest.formatB(str), color);
  }

  public static string formatB(string str) => "<b>" + str + "</b>";

  public static string formatC(string str, string color)
  {
    return "<color=" + color + ">" + str + "</color>";
  }

  public static void overview()
  {
    LeanTest.testsFinished = true;
    int num = LeanTest.expected - LeanTest.passes;
    string str = num > 0 ? LeanTest.formatBC(num.ToString() ?? "", "red") : num.ToString() ?? "";
    Debug.Log((object) (LeanTest.formatB("Final Report:") + " _____________________ PASSED: " + LeanTest.formatBC(LeanTest.passes.ToString() ?? "", "green") + " FAILED: " + str + " "));
  }
}
