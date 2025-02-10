// Decompiled with JetBrains decompiler
// Type: CardAnimationProfile
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using NaughtyAttributes;
using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "CardAnimationProfile", menuName = "Card Animation Profile")]
public class CardAnimationProfile : ScriptableObject
{
  public float speedFactor;
  [Header("Movement")]
  public bool doMoveX;
  [ShowIf("doMoveX")]
  public AnimationCurve moveX;
  public bool doMoveY;
  [ShowIf("doMoveY")]
  public AnimationCurve moveY;
  public bool doMoveZ;
  [ShowIf("doMoveZ")]
  public AnimationCurve moveZ;
  public Vector3 moveAmount;
  [Header("Rotation")]
  public bool doRotateX;
  [ShowIf("doRotateX")]
  public AnimationCurve rotateX;
  public bool doRotateY;
  [ShowIf("doRotateY")]
  public AnimationCurve rotateY;
  public bool doRotateZ;
  [ShowIf("doRotateZ")]
  public AnimationCurve rotateZ;
  public Vector3 rotateAmount;
  [Header("Scale")]
  public bool doScaleX;
  [ShowIf("doScaleX")]
  public AnimationCurve ScaleX;
  public bool doScaleY;
  [ShowIf("doScaleY")]
  public AnimationCurve ScaleY;
  public bool doScaleZ;
  [ShowIf("doScaleZ")]
  public AnimationCurve ScaleZ;
  public Vector3 scaleAmount;
}
