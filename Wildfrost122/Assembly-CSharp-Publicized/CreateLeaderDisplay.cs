﻿// Decompiled with JetBrains decompiler
// Type: CreateLeaderDisplay
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using UnityEngine;

#nullable disable
public class CreateLeaderDisplay : MonoBehaviour
{
  [SerializeField]
  public TweenUI startTween;
  [SerializeField]
  public float cardScale = 1f;

  public IEnumerator Start()
  {
    CreateLeaderDisplay createLeaderDisplay = this;
    Card card = CardManager.Get(References.LeaderData, (CardController) null, References.Player, false, true);
    card.entity.returnToPool = false;
    Transform transform = card.transform;
    transform.localScale = Vector3.one * createLeaderDisplay.cardScale;
    card.entity.flipper.FlipUpInstant();
    card.hover.Disable();
    card.entity.uINavigationItem.enabled = false;
    transform.SetParent(createLeaderDisplay.transform);
    transform.localPosition = Vector3.zero;
    transform.localRotation = Quaternion.identity;
    card.entity.wobbler.WobbleRandom();
    yield return (object) card.UpdateData(false);
    if ((bool) (Object) createLeaderDisplay.startTween)
      createLeaderDisplay.startTween.Fire();
  }
}
