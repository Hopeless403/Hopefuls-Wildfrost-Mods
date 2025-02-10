// Decompiled with JetBrains decompiler
// Type: BombardRocket
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;

public class BombardRocket : MonoBehaviour
{
  [SerializeField]
  private ParticleSystem rocketTrail;
  [SerializeField]
  private GameObject rocket;
  [SerializeField]
  private ParticleSystem explosion;
  [SerializeField]
  private float explosionShakeAmount = 2f;

  public void Explode() => this.StartCoroutine(this.ExplodeRoutine());

  public IEnumerator ExplodeRoutine()
  {
    // ISSUE: reference to a compiler-generated field
    int num = this.\u003C\u003E1__state;
    BombardRocket bombardRocket = this;
    if (num != 0)
    {
      if (num != 1)
        return false;
      // ISSUE: reference to a compiler-generated field
      this.\u003C\u003E1__state = -1;
      bombardRocket.gameObject.Destroy();
      return false;
    }
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E1__state = -1;
    bombardRocket.rocketTrail.Stop(true, ParticleSystemStopBehavior.StopEmitting);
    bombardRocket.rocket.Destroy();
    bombardRocket.explosion.Play();
    Events.InvokeScreenShake(bombardRocket.explosionShakeAmount, new float?(180f));
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E2__current = (object) new WaitForSeconds(4f);
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E1__state = 1;
    return true;
  }
}
