// Decompiled with JetBrains decompiler
// Type: FlyOffScreen
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using Dead;
using UnityEngine;

public class FlyOffScreen : MonoBehaviourCacheTransform
{
  [Header("Movement")]
  public Vector3 velocity;
  [SerializeField]
  private Vector3 grav = new Vector3(0.0f, -80f, 0.0f);
  [SerializeField]
  private Vector3 rotation = new Vector3(0.0f, 100f, 320f);
  [SerializeField]
  private Vector3 frictMult = new Vector3(0.95f, 1f, 0.92f);
  [Header("Fade")]
  public CanvasGroup canvasGroup;
  [SerializeField]
  private float alpha = 2f;
  [SerializeField]
  private float fade = 2f;
  [Header("Rotation Amount")]
  [SerializeField]
  private Vector2 rotateRangeX = new Vector2(1f, 2f);
  [SerializeField]
  private Vector2 rotateRangeY = new Vector2(0.0f, 1f);
  [SerializeField]
  private Vector2 rotateRangeZ = new Vector2(1f, 2f);

  private void Awake()
  {
    this.rotation.Scale(new Vector3(this.rotateRangeX.PettyRandom(), this.rotateRangeY.PettyRandom(), this.rotateRangeZ.PettyRandom()));
    this.Begin();
  }

  private void Update()
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

  protected virtual void Begin()
  {
  }

  protected virtual void End() => this.gameObject.Destroy();
}
