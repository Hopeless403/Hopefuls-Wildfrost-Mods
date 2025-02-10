// Decompiled with JetBrains decompiler
// Type: CardAnimationBombardRocketShoot
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections;
using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "BombardRocketShoot", menuName = "Card Animation/Bombard Rocket Shoot")]
public class CardAnimationBombardRocketShoot : CardAnimation
{
  [Header("Shoot Particles")]
  [SerializeField]
  public ParticleSystem shootFxPrefab;
  [SerializeField]
  public Vector3 shootAngle = new Vector3(0.0f, 0.0f, 135f);
  [SerializeField]
  public Vector3 shootFxOffset = new Vector3(0.0f, 1f, 0.0f);
  [SerializeField]
  public float shootScreenShake = 1f;
  [Header("Recoil Animation")]
  [SerializeField]
  public Vector3 recoilOffset = new Vector3(1f, -1f, 0.0f);
  [SerializeField]
  public AnimationCurve recoilCurve;
  [SerializeField]
  public float recoilDuration = 1f;

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
