// Decompiled with JetBrains decompiler
// Type: CardRotator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using NaughtyAttributes;
using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

#nullable disable
[RequireComponent(typeof (Card))]
public class CardRotator : MonoBehaviour
{
  [SerializeField]
  [Required(null)]
  [OnValueChanged("DataChanged")]
  public CardData data;
  [SerializeField]
  public float rotateSpeed;
  [SerializeField]
  public Vector3 rotateAmount;
  [SerializeField]
  public bool startFlippedDown = true;
  public Entity entity;
  public Card card;
  public float internalRotateSpeed = 1f;
  public float t;

  public IEnumerator Start()
  {
    CardRotator cardRotator = this;
    cardRotator.entity = cardRotator.GetComponent<Entity>();
    cardRotator.entity.data = cardRotator.data;
    cardRotator.card = cardRotator.GetComponent<Card>();
    yield return (object) cardRotator.card.UpdateData(false);
    if (cardRotator.startFlippedDown)
    {
      cardRotator.entity.flipper.FlipDownInstant();
      cardRotator.internalRotateSpeed = 0.0f;
      cardRotator.transform.localEulerAngles = Vector3.zero;
    }
  }

  public void Update()
  {
    this.t += Time.deltaTime * this.rotateSpeed * this.internalRotateSpeed;
    this.transform.localEulerAngles = this.rotateAmount * Mathf.Sin(this.t);
  }

  public void DataChanged()
  {
    if (Application.isEditor)
      return;
    this.StartCoroutine(this.UpdateData(this.data));
  }

  public IEnumerator UpdateData(CardData data)
  {
    this.entity.data = data;
    yield return (object) this.entity.ClearStatuses();
    this.card.ClearStatusIcons();
    yield return (object) this.card.UpdateData(false);
  }

  [Button(null, EButtonEnableMode.Always)]
  public void Flip()
  {
    if (this.entity.flipper.flipped)
      this.StartCoroutine(this.FlipUpRoutine());
    else
      this.StartCoroutine(this.FlipDownRoutine());
  }

  public IEnumerator FlipUpRoutine()
  {
    CardRotator cardRotator = this;
    cardRotator.entity.flipper.FlipUp();
    float dur = cardRotator.entity.flipper.flipUpDurationRand.y;
    yield return (object) Sequences.Wait(dur / 2f);
    cardRotator.entity.wobbler.WobbleRandom();
    yield return (object) Sequences.Wait(dur / 2f);
    LeanTween.value(0.0f, 1f, 1f).setOnUpdate(new Action<float>(cardRotator.\u003CFlipUpRoutine\u003Eb__13_0));
  }

  public IEnumerator FlipDownRoutine()
  {
    CardRotator cardRotator = this;
    cardRotator.entity.flipper.FlipDown();
    float dur = cardRotator.entity.flipper.flipUpDurationRand.y;
    yield return (object) Sequences.Wait(dur / 2f);
    cardRotator.entity.wobbler.WobbleRandom();
    yield return (object) Sequences.Wait(dur / 2f);
    LeanTween.value(1f, 0.0f, 1f).setOnUpdate(new Action<float>(cardRotator.\u003CFlipDownRoutine\u003Eb__14_0));
  }

  [CompilerGenerated]
  public void \u003CFlipUpRoutine\u003Eb__13_0(float a) => this.internalRotateSpeed = a;

  [CompilerGenerated]
  public void \u003CFlipDownRoutine\u003Eb__14_0(float a) => this.internalRotateSpeed = a;
}
