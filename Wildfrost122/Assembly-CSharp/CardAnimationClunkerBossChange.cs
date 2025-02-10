// Decompiled with JetBrains decompiler
// Type: CardAnimationClunkerBossChange
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using Dead;
using System.Collections;
using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "ClunkerBossPhaseChange", menuName = "Card Animation/Clunker Boss Change")]
public class CardAnimationClunkerBossChange : CardAnimation
{
  [SerializeField]
  private Vector2Int explosionCountRange = new Vector2Int(3, 5);
  [SerializeField]
  private Vector2 explosionDelayRange = new Vector2(0.1f, 0.6f);
  [SerializeField]
  private ParticleSystem explosionStart;
  [SerializeField]
  private ParticleSystem explosion;
  [SerializeField]
  private ParticleSystem explosionEnd;
  [SerializeField]
  private float explosionPositionRandom = 1f;
  [SerializeField]
  private float duration = 1f;
  [SerializeField]
  private float rumbleAmount = 0.5f;
  [SerializeField]
  private float rumbleDurationIn = 0.5f;
  [SerializeField]
  private float rumbleDurationOut = 0.25f;

  public override IEnumerator Routine(object data, float startDelay = 0.0f)
  {
    if (data is Entity target)
    {
      SfxSystem.OneShot("event:/sfx/specific/boss_phase_change");
      float seconds = Mathf.Max(startDelay, this.duration);
      if ((double) this.rumbleAmount > 0.0)
        Events.InvokeScreenRumble(0.0f, this.rumbleAmount, 0.0f, this.rumbleDurationIn, Mathf.Max(0.0f, this.duration - this.rumbleDurationIn), this.rumbleDurationOut);
      if ((bool) (Object) this.explosionStart)
        this.Explode(this.explosionStart, target.transform.position + this.RandomOffset());
      int num1 = this.explosionCountRange.Random();
      global::Routine.Clump clump = new global::Routine.Clump();
      for (int index = 0; index < num1; ++index)
      {
        Vector3 position = target.transform.position + this.RandomOffset();
        clump.Add(this.ExplodeAfterDelay(seconds * this.explosionDelayRange.PettyRandom(), position));
      }
      clump.Add(Sequences.Wait(seconds));
      yield return (object) clump.WaitForEnd();
      this.Explode(this.explosionEnd, target.transform.position, 2f);
      CurveAnimator curveAnimator = target.curveAnimator;
      if (curveAnimator != null)
      {
        double num2 = (double) curveAnimator.Ping();
      }
    }
  }

  private Vector3 RandomOffset()
  {
    return new Vector3(PettyRandom.Range(-1f, 1f), PettyRandom.Range(-1f, 1f), 0.0f).normalized * PettyRandom.Range(0.0f, this.explosionPositionRandom);
  }

  private IEnumerator ExplodeAfterDelay(float delay, Vector3 position)
  {
    yield return (object) new WaitForSeconds(delay);
    this.Explode(this.explosion, position);
  }

  private void Explode(ParticleSystem prefab, Vector3 position, float screenShake = 1f)
  {
    Object.Instantiate<ParticleSystem>(prefab, position, Quaternion.identity);
    Events.InvokeScreenShake(screenShake);
  }
}
