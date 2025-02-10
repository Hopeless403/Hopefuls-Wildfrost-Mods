// Decompiled with JetBrains decompiler
// Type: BellRinger
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using Dead;
using FMODUnity;
using NaughtyAttributes;
using UnityEngine;

#nullable disable
public class BellRinger : MonoBehaviour
{
  public TweenUI[] ringTweens;
  public bool playRingSfx = true;
  [SerializeField]
  [ShowIf("playRingSfx")]
  public EventReference ringSfxEvent;
  [SerializeField]
  [ShowIf("playRingSfx")]
  public Vector2 ringSfxPitch = new Vector2(1f, 1f);

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
