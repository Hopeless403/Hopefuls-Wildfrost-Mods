// Decompiled with JetBrains decompiler
// Type: NewCardFramesChecker
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;

public static class NewCardFramesChecker
{
  public static bool Check() => SaveSystem.LoadProgressData<bool>("newFinalBoss", false);

  public static IEnumerator Run()
  {
    SaveSystem.SaveProgressData<bool>("newFinalBoss", false);
    InputSystem.Disable();
    yield return (object) SceneManager.Load("NewFrostGuardian", SceneType.Temporary);
    InputSystem.Enable();
    yield return (object) SceneManager.WaitUntilUnloaded("NewFrostGuardian");
  }
}
