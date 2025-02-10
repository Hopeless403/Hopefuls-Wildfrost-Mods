// Decompiled with JetBrains decompiler
// Type: NewCardFramesChecker
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

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
