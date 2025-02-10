// Decompiled with JetBrains decompiler
// Type: NewFinalBossChecker
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;

#nullable disable
public static class NewFinalBossChecker
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
