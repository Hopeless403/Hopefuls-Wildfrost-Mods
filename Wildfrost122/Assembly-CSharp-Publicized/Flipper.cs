// Decompiled with JetBrains decompiler
// Type: Flipper
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using NaughtyAttributes;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
public class Flipper : MonoBehaviourCacheTransform, IPoolable
{
  public Flipper.State state;
  [SerializeField]
  public Entity entity;
  [SerializeField]
  public CardHover hover;
  public Vector2 flipUpDurationRand = new Vector2(0.5f, 0.6f);
  public Vector2 flipDownDurationRand = new Vector2(0.5f, 0.6f);
  public AnimationCurve flipUpCurve;
  public AnimationCurve flipDownCurve;
  public Vector3 flipPositionOffset = new Vector3(0.0f, 1f, -1f);
  public AnimationCurve flipPositionCurve;
  public UnityEvent onFlipUp;
  public UnityEvent onFlipDown;
  public float preAngle;
  public float angle;
  [ReadOnly]
  public bool flipped;
  public float t = 1f;
  public float duration;
  public bool isCompleteFired = true;

  public void Update()
  {
    if ((double) this.t > (double) this.duration)
      return;
    this.isCompleteFired = false;
    this.t += Time.deltaTime;
    float time = this.t / this.duration;
    switch (this.state)
    {
      case Flipper.State.FlipUp:
        this.UpdateAngle((float) ((1.0 - (double) this.flipUpCurve.Evaluate(time)) * 180.0));
        this.transform.localPosition = this.flipPositionCurve.Evaluate(time) * this.flipPositionOffset;
        break;
      case Flipper.State.FlipDown:
        this.UpdateAngle(this.flipDownCurve.Evaluate(time) * 180f);
        this.transform.localPosition = this.flipPositionCurve.Evaluate(time) * this.flipPositionOffset;
        break;
    }
    if ((double) this.t <= (double) this.duration)
      return;
    if (!this.isCompleteFired)
    {
      global::Events.InvokeEntityFlipComplete(this.entity);
      this.isCompleteFired = true;
    }
    this.state = Flipper.State.None;
  }

  public void UpdateAngle(float angle)
  {
    this.angle = angle;
    if ((double) this.preAngle < 90.0 && (double) angle >= 90.0)
    {
      this.flipped = true;
      this.onFlipDown.Invoke();
    }
    if ((double) this.preAngle > 90.0 && (double) angle <= 90.0)
    {
      this.flipped = false;
      this.onFlipUp.Invoke();
    }
    this.preAngle = angle;
    this.transform.localEulerAngles = this.transform.localEulerAngles.WithY(angle);
  }

  [Button(null, EButtonEnableMode.Always)]
  public void FlipUp(bool force = false)
  {
    if (!force && !this.flipped && this.state != Flipper.State.FlipDown)
      return;
    this.preAngle = this.angle;
    this.t = 0.0f;
    this.duration = this.flipUpDurationRand.PettyRandom();
    this.state = Flipper.State.FlipUp;
    this.hover.SetHoverable(true);
    global::Events.InvokeEntityFlipUp(this.entity);
  }

  public void FlipUpInstant()
  {
    this.transform.localEulerAngles = this.transform.localEulerAngles.WithY(0.0f);
    this.angle = 0.0f;
    this.preAngle = 0.0f;
    this.flipped = false;
    this.onFlipUp.Invoke();
    this.state = Flipper.State.None;
    this.hover.SetHoverable(true);
  }

  [Button(null, EButtonEnableMode.Always)]
  public void FlipDown(bool force = false)
  {
    if (!force && this.flipped && this.state != Flipper.State.FlipUp)
      return;
    this.preAngle = this.angle;
    this.t = 0.0f;
    this.duration = this.flipDownDurationRand.PettyRandom();
    this.state = Flipper.State.FlipDown;
    this.hover.SetHoverable(false);
    global::Events.InvokeEntityFlipDown(this.entity);
  }

  public void FlipDownInstant()
  {
    this.transform.localEulerAngles = this.transform.localEulerAngles.WithY(180f);
    this.angle = 180f;
    this.preAngle = 180f;
    this.flipped = true;
    this.onFlipDown.Invoke();
    this.state = Flipper.State.None;
    this.hover.SetHoverable(false);
  }

  public void OnGetFromPool()
  {
  }

  public void OnReturnToPool()
  {
    this.state = Flipper.State.None;
    this.preAngle = 0.0f;
    this.angle = 0.0f;
    this.flipped = false;
    this.t = 1f;
    this.duration = 0.0f;
    this.isCompleteFired = true;
    this.transform.localRotation = Quaternion.identity;
    this.transform.localPosition = Vector3.zero;
  }

  public enum State
  {
    None,
    FlipUp,
    FlipDown,
  }
}
