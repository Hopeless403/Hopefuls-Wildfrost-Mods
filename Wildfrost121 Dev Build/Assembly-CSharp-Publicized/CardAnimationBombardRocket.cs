﻿// Decompiled with JetBrains decompiler
// Type: CardAnimationBombardRocket
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "BombardRocket", menuName = "Card Animation/Bombard Rocket")]
public class CardAnimationBombardRocket : CardAnimation
{
  [Header("Rocket")]
  [SerializeField]
  public BombardRocket rocketPrefab;
  [SerializeField]
  public float rocketDuration = 0.67f;
  [SerializeField]
  public Vector3 startPosOffset = new Vector3(0.0f, 10f, 0.0f);
  [SerializeField]
  public Vector3 endPosOffset = new Vector3(0.0f, 0.1f, 0.0f);
  [SerializeField]
  public AnimationCurve rocketMoveCurve;

  public override IEnumerator Routine(object data, float startDelay = 0.0f)
  {
    if (data is Vector3 vector3)
    {
      Vector3 to = vector3 + this.endPosOffset;
      BombardRocket rocket = Object.Instantiate<BombardRocket>(this.rocketPrefab, vector3 + this.startPosOffset, Quaternion.identity);
      LeanTween.move(rocket.gameObject, to, this.rocketDuration).setEase(this.rocketMoveCurve);
      Events.InvokeBombardRocketFall(rocket);
      yield return (object) new WaitForSeconds(this.rocketDuration);
      Events.InvokeBombardRocketExplode(rocket);
      rocket.Explode();
      rocket = (BombardRocket) null;
    }
  }
}
