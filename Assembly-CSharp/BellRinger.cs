// Decompiled with JetBrains decompiler
// Type: BellRinger
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using Dead;
using FMODUnity;
using NaughtyAttributes;
using UnityEngine;

public class BellRinger : MonoBehaviour
{
  public TweenUI[] ringTweens;
  public bool playRingSfx = true;
  [SerializeField]
  [ShowIf("playRingSfx")]
  private EventReference ringSfxEvent;
  [SerializeField]
  [ShowIf("playRingSfx")]
  private Vector2 ringSfxPitch = new Vector2(1f, 1f);

  public void Ring()
  {
    foreach (TweenUI ringTween in this.ringTweens)
      ringTween.Fire();
    if (!this.playRingSfx)
      return;
    this.PlayRingSfx();
  }

  public void PlayRingSfx()
  {
    if (this.ringSfxEvent.IsNull)
      return;
    int num = (int) SfxSystem.OneShot(this.ringSfxEvent).setPitch(this.ringSfxPitch.PettyRandom() * PettyRandom.Range(0.95f, 1.05f));
  }
}
