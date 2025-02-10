// Decompiled with JetBrains decompiler
// Type: FlyOffScreen
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using Dead;
using UnityEngine;

#nullable disable
public class FlyOffScreen : MonoBehaviourCacheTransform
{
  [Header("Movement")]
  public Vector3 velocity;
  [SerializeField]
  public Vector3 grav = new Vector3(0.0f, -80f, 0.0f);
  [SerializeField]
  public Vector3 rotation = new Vector3(0.0f, 100f, 320f);
  [SerializeField]
  public Vector3 frictMult = new Vector3(0.95f, 1f, 0.92f);
  [Header("Fade")]
  public CanvasGroup canvasGroup;
  [SerializeField]
  public float alpha = 2f;
  [SerializeField]
  public float fade = 2f;
  [Header("Rotation Amount")]
  [SerializeField]
  public Vector2 rotateRangeX = new Vector2(1f, 2f);
  [SerializeField]
  public Vector2 rotateRangeY = new Vector2(0.0f, 1f);
  [SerializeField]
  public Vector2 rotateRangeZ = new Vector2(1f, 2f);

  public void Awake()
  {
    this.rotation.Scale(new Vector3(this.rotateRangeX.PettyRandom(), this.rotateRangeY.PettyRandom(), this.rotateRangeZ.PettyRandom()));
    this.Begin();
  }

  public void Update()
  {
    this.velocity += this.grav * Time.deltaTime;
    this.velocity = Delta.Multiply(this.velocity, this.frictMult, Time.deltaTime);
    this.transform.position = this.transform.position + this.velocity * Time.deltaTime;
    this.transform.localEulerAngles = this.transform.localEulerAngles + this.rotation * (Mathf.Sign(this.velocity.x) * Time.deltaTime);
    this.alpha -= this.fade * Time.deltaTime;
    if ((double) this.alpha <= 0.0)
      this.End();
    else
      this.canvasGroup.alpha = Mathf.Min(1f, this.alpha);
  }

  public void Knockback(Hit lastHit)
  {
    Vector3 normalized = (lastHit == null || !(bool) (Object) lastHit.attacker ? Vector3.up.WithX(PettyRandom.Range(-1f, 1f)) : (this.transform.position - lastHit.attacker.transform.position).WithZ(0.0f)).normalized;
    Debug.Log((object) string.Format("knockback dir: {0}", (object) normalized));
    this.Knockback(new Vector3(Mathf.Clamp(normalized.x * PettyRandom.Range(5f, 10f), -1f, 1f), PettyRandom.Range(15f, 25f), -PettyRandom.Range(10f, 30f)));
  }

  public void Knockback(Vector3 dir) => this.velocity = dir;

  public virtual void Begin()
  {
  }

  public virtual void End() => this.gameObject.Destroy();
}
