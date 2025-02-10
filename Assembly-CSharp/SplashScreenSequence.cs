// Decompiled with JetBrains decompiler
// Type: SplashScreenSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using FMOD.Studio;
using FMODUnity;
using System;
using System.Collections;
using UnityEngine;

public class SplashScreenSequence : MonoBehaviour
{
  [SerializeField]
  private SplashScreenSequence.Phase[] phases;
  private int phase;
  private EventInstance sfxInstance;

  public IEnumerator Run()
  {
    PauseMenu.Block();
    while (this.phase < this.phases.Length)
    {
      this.phases[this.phase].gameObject.SetActive(true);
      if (!this.phases[this.phase].sfxEvent.IsNull)
        this.sfxInstance = SfxSystem.OneShot(this.phases[this.phase].sfxEvent);
      float time = 0.0f;
      while ((double) time < (double) this.phases[this.phase].autoSkipTime)
      {
        yield return (object) null;
        time += Time.deltaTime;
        if ((double) time > (double) this.phases[this.phase].canSkipTime && InputSystem.Enabled && SplashScreenSequence.AnyButtonPressed())
          break;
      }
      ++this.phase;
      if (this.sfxInstance.isValid())
      {
        int num = (int) this.sfxInstance.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
      }
    }
    PauseMenu.Unblock();
  }

  private static bool AnyButtonPressed() => Input.anyKeyDown || Input.GetMouseButtonDown(0) || InputSystem.IsSelectPressed();

  [Serializable]
  public struct Phase
  {
    public GameObject gameObject;
    public float canSkipTime;
    public float autoSkipTime;
    public EventReference sfxEvent;
  }
}
