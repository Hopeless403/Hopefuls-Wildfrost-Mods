// Decompiled with JetBrains decompiler
// Type: CreateLeaderDisplay
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;

public class CreateLeaderDisplay : MonoBehaviour
{
  [SerializeField]
  private TweenUI startTween;
  [SerializeField]
  private float cardScale = 1f;

  private IEnumerator Start()
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
