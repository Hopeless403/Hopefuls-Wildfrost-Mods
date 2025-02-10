// Decompiled with JetBrains decompiler
// Type: BellRinger
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

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
