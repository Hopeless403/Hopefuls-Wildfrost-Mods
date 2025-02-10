// Decompiled with JetBrains decompiler
// Type: CardCharm
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using NaughtyAttributes;
using UnityEngine;

#nullable disable
public class CardCharm : UpgradeDisplay
{
  public Transform holder;
  public Vector3 movementInfluence = new Vector3(-1f, 0.5f, 0.0f);
  public float rotationMax = 90f;
  public Vector2 wobbleFactorRange = (Vector2) new Vector3(4.5f, 5.5f);
  public Vector2 wobbleDampingRange = new Vector2(0.9f, 0.95f);
  public Vector2 wobbleAccRange = new Vector2(0.65f, 0.75f);
  [SerializeField]
  [ReadOnly]
  public float wobbleFactor;
  [SerializeField]
  [ReadOnly]
  public float wobbleDamping;
  [SerializeField]
  [ReadOnly]
  public float wobbleAcc;
  public Vector3 prePosition;
  public float rotation;
  public float rotationVelocity;
  public float startingZAngle;

  public void Start()
  {
    this.wobbleFactor = this.wobbleFactorRange.PettyRandom();
    this.wobbleDamping = this.wobbleDampingRange.PettyRandom();
    this.wobbleAcc = this.wobbleAccRange.PettyRandom();
  }

  public void OnEnable()
  {
    if (!((Object) this.holder != (Object) null))
      return;
    this.prePosition = this.holder.position;
  }

  public void Update()
  {
    this.rotationVelocity -= this.rotation * this.wobbleAcc * Time.deltaTime;
    this.rotationVelocity = Delta.Multiply(this.rotationVelocity, this.wobbleDamping, Time.deltaTime);
    this.rotation += this.rotationVelocity * 200f * Time.deltaTime;
    this.transform.eulerAngles = new Vector3(0.0f, 0.0f, this.startingZAngle + this.rotation);
    Vector3 position = this.holder.position;
    this.Wobble(position - this.prePosition);
    this.prePosition = position;
  }

  public void Wobble(Vector3 movement)
  {
    this.rotation = Mathf.Clamp(this.rotation + Vector3.Scale(movement, this.movementInfluence).magnitude * this.wobbleFactor, -this.rotationMax, this.rotationMax);
  }

  public void SetAngle(float angle) => this.startingZAngle = angle;

  public void StopWobble()
  {
    this.rotationVelocity = 0.0f;
    this.rotation = 0.0f;
    this.transform.eulerAngles = new Vector3(0.0f, 0.0f, this.startingZAngle);
  }
}
