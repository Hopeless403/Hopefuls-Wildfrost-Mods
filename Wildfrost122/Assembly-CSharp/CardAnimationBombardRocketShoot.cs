// Decompiled with JetBrains decompiler
// Type: CardAnimationBombardRocketShoot
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections;
using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "BombardRocketShoot", menuName = "Card Animation/Bombard Rocket Shoot")]
public class CardAnimationBombardRocketShoot : CardAnimation
{
  [Header("Shoot Particles")]
  [SerializeField]
  private ParticleSystem shootFxPrefab;
  [SerializeField]
  private Vector3 shootAngle = new Vector3(0.0f, 0.0f, 135f);
  [SerializeField]
  private Vector3 shootFxOffset = new Vector3(0.0f, 1f, 0.0f);
  [SerializeField]
  private float shootScreenShake = 1f;
  [Header("Recoil Animation")]
  [SerializeField]
  private Vector3 recoilOffset = new Vector3(1f, -1f, 0.0f);
  [SerializeField]
  private AnimationCurve recoilCurve;
  [SerializeField]
  private float recoilDuration = 1f;

  public override IEnumerator Routine(object data, float startDelay = 0.0f)
  {
    if (data is Entity entity)
    {
      ParticleSystem shootFx = UnityEngine.Object.Instantiate<ParticleSystem>(this.shootFxPrefab, entity.transform.position + this.shootFxOffset, Quaternion.Euler(this.shootAngle));
      Events.InvokeScreenShake(this.shootScreenShake, new float?(this.shootAngle.z + 180f));
      Events.InvokeBombardShoot(entity);
      CurveAnimator curveAnimator = entity.curveAnimator;
      if (curveAnimator != null)
      {
        double num = (double) curveAnimator.Move(this.recoilOffset, this.recoilCurve, duration: 1f);
      }
      yield return (object) new WaitUntil((Func<bool>) (() => !(bool) (UnityEngine.Object) shootFx));
    }
  }
}
