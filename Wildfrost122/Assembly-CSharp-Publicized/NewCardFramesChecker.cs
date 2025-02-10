// Decompiled with JetBrains decompiler
// Type: NewCardFramesChecker
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;

#nullable disable
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
