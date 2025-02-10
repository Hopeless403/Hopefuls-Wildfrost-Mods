// Decompiled with JetBrains decompiler
// Type: CardIdleAnimation
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using Dead;
using UnityEngine;

#nullable disable
public class CardIdleAnimation : MonoBehaviourCacheTransform, IPoolable
{
  public CardAnimationProfile profile;
  public Entity _entity;
  public bool alwaysOn;
  public float strength = 1f;
  public float speedFactor = 1f;
  public float fadeInTime = 0.4f;
  public float fadeInStrength = 1f;
  public float speed;
  public float offset;
  public Vector3 basePosition;
  public Vector3 baseRotation;
  public Vector3 baseScale;
  [SerializeField]
  public CardAnimationProfile setProfile;
  [SerializeField]
  public CardIdleAnimation.Action currentAction;

  public Entity entity
  {
    get => this._entity;
    set
    {
      this._entity = value;
      this.SetProfile(this._entity.data.idleAnimationProfile);
    }
  }

  public void Awake()
  {
    this.basePosition = this.transform.localPosition;
    this.baseRotation = this.transform.localEulerAngles;
    this.baseScale = this.transform.localScale;
    this.speed = 1f / PettyRandom.Range(2f, 3f);
  }

  public void OnEnable()
  {
    if (!this.alwaysOn)
      return;
    this.StartAction(CardIdleAnimation.Action.FadeIn);
  }

  public void OnDisable()
  {
    if (this.alwaysOn)
      return;
    this.fadeInStrength = 0.0f;
    this.enabled = false;
    this.currentAction = CardIdleAnimation.Action.None;
  }

  public void Update()
  {
    if ((bool) (Object) this.profile && (double) this.strength != 0.0)
    {
      float time = (float) (((double) Time.timeSinceLevelLoad * (double) this.speed * (double) this.speedFactor + (double) this.offset) % 1.0);
      if (this.profile.doMoveX || this.profile.doMoveY || this.profile.doMoveZ)
        this.transform.localPosition = new Vector3(this.basePosition.x + (this.profile.doMoveX ? this.profile.moveX.Evaluate(time) * this.profile.moveAmount.x * this.strength * this.fadeInStrength : 0.0f), this.basePosition.y + (this.profile.doMoveY ? this.profile.moveY.Evaluate(time) * this.profile.moveAmount.y * this.strength * this.fadeInStrength : 0.0f), this.basePosition.z + (this.profile.doMoveZ ? this.profile.moveZ.Evaluate(time) * this.profile.moveAmount.z * this.strength * this.fadeInStrength : 0.0f));
      if (this.profile.doRotateX || this.profile.doRotateY || this.profile.doRotateZ)
        this.transform.localEulerAngles = new Vector3(this.baseRotation.x + (this.profile.doRotateX ? this.profile.rotateX.Evaluate(time) * this.profile.rotateAmount.x * this.strength * this.fadeInStrength : 0.0f), this.baseRotation.y + (this.profile.doRotateY ? this.profile.rotateY.Evaluate(time) * this.profile.rotateAmount.y * this.strength * this.fadeInStrength : 0.0f), this.baseRotation.z + (this.profile.doRotateZ ? this.profile.rotateZ.Evaluate(time) * this.profile.rotateAmount.z * this.strength * this.fadeInStrength : 0.0f));
      if (this.profile.doScaleX || this.profile.doScaleY || this.profile.doScaleZ)
        this.transform.localScale = new Vector3(this.baseScale.x + (this.profile.doScaleX ? this.profile.ScaleX.Evaluate(time) * this.profile.scaleAmount.x * this.strength * this.fadeInStrength : 0.0f), this.baseScale.y + (this.profile.doScaleY ? this.profile.ScaleY.Evaluate(time) * this.profile.scaleAmount.y * this.strength * this.fadeInStrength : 0.0f), this.baseScale.z + (this.profile.doScaleZ ? this.profile.ScaleZ.Evaluate(time) * this.profile.scaleAmount.z * this.strength * this.fadeInStrength : 0.0f));
    }
    if ((bool) (Object) this.setProfile)
    {
      this.SetProfile(this.setProfile);
      this.setProfile = (CardAnimationProfile) null;
    }
    if (this.currentAction == CardIdleAnimation.Action.None)
      return;
    this.RunAction();
  }

  public void SetSpeed(float speed, float speedFactor, float offset)
  {
    this.speed = speed;
    this.speedFactor = speedFactor;
    this.offset = offset;
  }

  public void SetProfile(CardAnimationProfile profile)
  {
    this.profile = profile;
    this.speed = ((bool) (Object) this._entity ? (float) (1.0 / (2.0 + (double) Mathf.Abs(this._entity.random3.x))) : 0.5f) * profile.speedFactor;
    this.offset = (bool) (Object) this._entity ? Mathf.Abs(this._entity.random3.y) : 0.0f;
  }

  public void StartAction(CardIdleAnimation.Action action)
  {
    this.currentAction = action;
    switch (action)
    {
      case CardIdleAnimation.Action.FadeIn:
        this.enabled = true;
        this.fadeInStrength = 0.0f;
        break;
      case CardIdleAnimation.Action.FadeOut:
        if (this.gameObject.activeInHierarchy)
          break;
        this.enabled = false;
        this.fadeInStrength = 0.0f;
        this.StartAction(CardIdleAnimation.Action.None);
        break;
    }
  }

  public void RunAction()
  {
    switch (this.currentAction)
    {
      case CardIdleAnimation.Action.FadeIn:
        if ((double) this.fadeInStrength < 1.0)
        {
          this.fadeInStrength += 1f / this.fadeInTime * Time.deltaTime;
          break;
        }
        this.fadeInStrength = 1f;
        this.StartAction(CardIdleAnimation.Action.None);
        break;
      case CardIdleAnimation.Action.FadeOut:
        if ((double) this.fadeInStrength > 0.0)
        {
          this.fadeInStrength -= 1f / this.fadeInTime * Time.deltaTime;
          break;
        }
        this.enabled = false;
        this.fadeInStrength = 0.0f;
        this.StartAction(CardIdleAnimation.Action.None);
        break;
    }
  }

  public void FadeIn() => this.StartAction(CardIdleAnimation.Action.FadeIn);

  public void FadeOut() => this.StartAction(CardIdleAnimation.Action.FadeOut);

  public void Clear()
  {
    this.fadeInStrength = 0.0f;
    this.currentAction = CardIdleAnimation.Action.None;
  }

  public void OnGetFromPool()
  {
  }

  public void OnReturnToPool() => this.Clear();

  public enum Action
  {
    None,
    FadeIn,
    FadeOut,
  }
}
