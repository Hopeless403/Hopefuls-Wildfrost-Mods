// Decompiled with JetBrains decompiler
// Type: BlingParticle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using Dead;
using UnityEngine;

#nullable disable
[RequireComponent(typeof (SpriteRenderer))]
public class BlingParticle : MonoBehaviour
{
  public BlingParticleSystem system;
  public Character owner;
  public int value = 1;
  [SerializeField]
  public Vector2 sizeRange = new Vector2(0.7f, 0.9f);
  [SerializeField]
  public Vector2 angleRange = new Vector2(-20f, 20f);
  [SerializeField]
  public Vector3 groundRotation = new Vector3(20f, 0.0f, 0.0f);
  [SerializeField]
  public Vector2 bounceRange = new Vector2(0.35f, 0.45f);
  [SerializeField]
  public Vector2 bounceSlowdownRange = new Vector2(0.75f, 0.85f);
  [SerializeField]
  public Vector2 flyToBagRange = new Vector2(2f, 2.5f);
  [SerializeField]
  public Vector2 startSpeedRange = new Vector2(1f, 2f);
  [SerializeField]
  public Vector2 startUpSpeedRange = new Vector2(0.0f, 1f);
  [SerializeField]
  public Vector2 frictMultRange = new Vector2(0.94f, 0.96f);
  [SerializeField]
  public float grav = 10f;
  [SerializeField]
  public Vector2 groundOffsetRange = new Vector2(0.5f, 1f);
  [SerializeField]
  public bool startTimerWhenOnGround = true;
  [SerializeField]
  [Range(0.0f, 1f)]
  public float zInfluence = 0.5f;
  [SerializeField]
  public float flyToBagSpeed = 1f;
  [SerializeField]
  public float flyMaxSpeed = 10f;
  public float worldGroundY;
  public float bounce;
  public float bounceSlowdown;
  public float flyToBag;
  public Vector3 velocity;
  public float frictMult;
  public bool onGround;
  public GoldDisplay targetBag;
  public SpriteRenderer _spr;

  public SpriteRenderer spr => this._spr ?? (this._spr = this.GetComponent<SpriteRenderer>());

  public Sprite sprite
  {
    set => this.spr.sprite = value;
  }

  public string sortingLayer
  {
    set => this.spr.sortingLayerName = value;
  }

  public void OnEnable()
  {
    this.sortingLayer = "ParticlesBehind";
    this.onGround = false;
    this.targetBag = (GoldDisplay) null;
    float num = this.sizeRange.PettyRandom();
    this.bounce = this.bounceRange.PettyRandom();
    this.bounceSlowdown = this.bounceSlowdownRange.PettyRandom();
    this.flyToBag = this.flyToBagRange.PettyRandom();
    this.frictMult = this.frictMultRange.PettyRandom();
    this.transform.localScale = new Vector3(num, num, 1f);
    this.transform.localEulerAngles = this.groundRotation.WithZ(this.angleRange.PettyRandom());
    this.worldGroundY = this.transform.position.y - this.groundOffsetRange.PettyRandom();
    this.spr.flipX = (PettyRandom.Choose<bool>(true, false) ? 1 : 0) != 0;
    this.velocity = new Vector3(PettyRandom.Range(-1f, 1f), PettyRandom.Range(-1f, 1f), 0.0f).normalized * this.startSpeedRange.PettyRandom();
    this.velocity.y += this.startUpSpeedRange.PettyRandom();
  }

  public void Update()
  {
    Vector3 vector3_1 = this.transform.localPosition + this.velocity * Time.deltaTime;
    if ((bool) (Object) this.targetBag)
    {
      Vector3 vector3_2 = this.targetBag.transform.position - this.transform.position;
      this.velocity += vector3_2 * (this.flyToBagSpeed * Time.deltaTime);
      if ((double) vector3_2.sqrMagnitude < 0.10000000149011612)
        this.Collect();
      else if ((double) this.velocity.magnitude > (double) this.flyMaxSpeed)
        this.velocity = vector3_2.normalized * this.flyMaxSpeed;
    }
    else
    {
      if (!this.onGround && (double) this.velocity.y <= 0.0 && (double) vector3_1.y <= (double) this.worldGroundY)
      {
        this.velocity.y *= -this.bounce;
        this.velocity.x *= this.bounceSlowdown;
        if ((double) Mathf.Abs(this.velocity.y) < 0.05000000074505806)
        {
          this.velocity.y = 0.0f;
          this.onGround = true;
        }
        vector3_1.y = this.worldGroundY;
      }
      if ((double) this.zInfluence > 0.0)
        vector3_1.z -= this.velocity.y * this.zInfluence * Time.deltaTime;
      this.velocity.x = Delta.Multiply(this.velocity.x, this.frictMult, Time.deltaTime);
      if (!this.onGround)
        this.velocity.y -= this.grav * Time.deltaTime;
      else if ((double) vector3_1.y != (double) this.worldGroundY)
        this.onGround = false;
      if (!this.startTimerWhenOnGround || this.onGround)
      {
        this.flyToBag -= Time.deltaTime;
        if ((double) this.flyToBag <= 0.0)
          this.FlyToBag();
      }
    }
    this.transform.localPosition = vector3_1;
  }

  public void FlyToBag()
  {
    if (this.owner.entity.display is CharacterDisplay display && (Object) display.goldDisplay != (Object) null)
    {
      this.targetBag = display.goldDisplay;
      this.sortingLayer = "ParticlesFront";
      Events.InvokeGoldFlyToBag(this.value, this.owner, this.transform.position);
    }
    else
      this.Collect();
  }

  public void Collect()
  {
    this.owner.GainGold(this.value);
    this.ReturnToPool();
    Events.InvokeCollectGold(this.value);
  }

  public void ReturnToPool() => this.system.Pool(this);
}
