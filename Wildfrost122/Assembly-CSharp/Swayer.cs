﻿// Decompiled with JetBrains decompiler
// Type: Swayer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using Dead;
using NaughtyAttributes;
using UnityEngine;

#nullable disable
public class Swayer : MonoBehaviour
{
  [SerializeField]
  private bool randomStart;
  [Header("Position")]
  [OnValueChanged("SwayPositionToggled")]
  public bool swayPosition;
  [ShowIf("swayPosition")]
  public Vector3 positionInfluence = Vector3.one;
  [ShowIf("swayPosition")]
  public Vector3 positionSway = Vector3.one;
  [Header("Rotation")]
  [OnValueChanged("SwayRotationToggled")]
  public bool swayRotation;
  [ShowIf("swayRotation")]
  public Vector3 rotationInfluence = Vector3.one;
  [ShowIf("swayRotation")]
  public Vector3 rotationSway = Vector3.one;
  private Vector3 startPosition;
  private Vector3 startRotation;
  private float t;
  private Transform transform;

  private void Awake()
  {
    this.transform = this.GetComponent<Transform>();
    this.startPosition = this.transform.localPosition;
    this.startRotation = this.transform.localEulerAngles;
    if (!this.randomStart)
      return;
    this.t = PettyRandom.Range(0.0f, 10f);
  }

  private void Update()
  {
    float num = Time.timeSinceLevelLoad + this.t;
    if (this.swayPosition)
      this.transform.localPosition = this.startPosition + Vector3.Scale(new Vector3(Mathf.Sin(num * this.positionSway.x), Mathf.Sin(num * this.positionSway.y), Mathf.Sin(num * this.positionSway.z)), this.positionInfluence);
    if (!this.swayRotation)
      return;
    this.transform.localEulerAngles = this.startRotation + Vector3.Scale(new Vector3(Mathf.Sin(num * this.rotationSway.x), Mathf.Sin(num * this.rotationSway.y), Mathf.Sin(num * this.rotationSway.z)), this.rotationInfluence);
  }

  private void SwayPositionToggled()
  {
    if (this.swayPosition)
      return;
    this.transform.localPosition = this.startPosition;
  }

  private void SwayRotationToggled()
  {
    if (this.swayRotation)
      return;
    this.transform.localEulerAngles = this.startRotation;
  }
}
