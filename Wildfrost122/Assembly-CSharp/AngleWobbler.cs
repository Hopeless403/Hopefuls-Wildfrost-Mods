// Decompiled with JetBrains decompiler
// Type: AngleWobbler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using Dead;
using NaughtyAttributes;
using UnityEngine;

#nullable disable
public class AngleWobbler : MonoBehaviour
{
  public Transform holder;
  public Transform target;
  public bool globalSpace = true;
  [SerializeField]
  private Vector3 movementInfluence = new Vector3(-1f, 0.5f, 0.0f);
  [SerializeField]
  private float rotationMax = 45f;
  [SerializeField]
  private Vector2 wobbleFactorRange = new Vector2(4.5f, 5.5f);
  [SerializeField]
  private Vector2 wobbleDampingRange = new Vector2(0.9f, 0.95f);
  [SerializeField]
  private Vector2 wobbleAccRange = new Vector2(0.65f, 0.75f);
  [SerializeField]
  [ReadOnly]
  private float wobbleFactor;
  [SerializeField]
  [ReadOnly]
  private float wobbleDamping;
  [SerializeField]
  [ReadOnly]
  private float wobbleAcc;
  private Vector3 prePosition;
  private float rotation;
  private float rotationVelocity;
  private float startAngle;

  private Vector3 HolderPosition => this.holder.position;

  private void Awake()
  {
    this.SetAngle(this.target.localEulerAngles.z);
    this.wobbleFactor = this.wobbleFactorRange.PettyRandom();
    this.wobbleDamping = this.wobbleDampingRange.PettyRandom();
    this.wobbleAcc = this.wobbleAccRange.PettyRandom();
  }

  private void OnEnable()
  {
    if (!((Object) this.holder != (Object) null))
      return;
    this.prePosition = this.HolderPosition;
  }

  private void Update()
  {
    this.rotationVelocity -= this.rotation * this.wobbleAcc * Time.deltaTime;
    this.rotationVelocity = Delta.Multiply(this.rotationVelocity, this.wobbleDamping, Time.deltaTime);
    this.rotation += this.rotationVelocity * 200f * Time.deltaTime;
    if (this.globalSpace)
    {
      Vector3 eulerAngles = this.target.eulerAngles;
      this.target.eulerAngles = new Vector3(eulerAngles.x, eulerAngles.y, this.startAngle + this.rotation);
    }
    else
    {
      Vector3 localEulerAngles = this.target.localEulerAngles;
      this.target.localEulerAngles = new Vector3(localEulerAngles.x, localEulerAngles.y, this.startAngle + this.rotation);
    }
    Vector3 holderPosition = this.HolderPosition;
    this.Wobble(holderPosition - this.prePosition);
    this.prePosition = holderPosition;
  }

  public void Wobble(Vector3 movement)
  {
    this.rotation = Mathf.Clamp(this.rotation + Vector3.Scale(movement, this.movementInfluence).magnitude * this.wobbleFactor, -this.rotationMax, this.rotationMax);
  }

  public void WobbleRandom()
  {
    this.rotation = Mathf.Clamp(this.rotation + (this.rotationMax * PettyRandom.Range(0.5f, 1f)).WithRandomSign(), -this.rotationMax, this.rotationMax);
  }

  public void SetAngle(float angle) => this.startAngle = angle;
}
