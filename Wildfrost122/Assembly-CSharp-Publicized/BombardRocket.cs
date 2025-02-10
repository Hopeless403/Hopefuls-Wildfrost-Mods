// Decompiled with JetBrains decompiler
// Type: BombardRocket
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using UnityEngine;

#nullable disable
public class BombardRocket : MonoBehaviour
{
  [SerializeField]
  public ParticleSystem rocketTrail;
  [SerializeField]
  public GameObject rocket;
  [SerializeField]
  public ParticleSystem explosion;
  [SerializeField]
  public float explosionShakeAmount = 2f;

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
