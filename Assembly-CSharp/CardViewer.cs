// Decompiled with JetBrains decompiler
// Type: CardViewer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CardViewer : MonoBehaviour
{
  [SerializeField]
  private Transform cardHolder;
  [SerializeField]
  private CardData startingData;
  [SerializeField]
  private InspectSystem inspectSystem;
  private int current;
  private List<CardData> cards;

  private void Start()
  {
    this.cards = AddressableLoader.GetGroup<CardData>("CardData").Where<CardData>((Func<CardData, bool>) (a => a.cardType.name != "Leader" && a.cardType.name != "Boss" && a.mainSprite.name != "Nothing")).ToList<CardData>();
    this.Set(this.startingData);
  }

  private void Update()
  {
    if (Input.GetKeyDown(KeyCode.LeftArrow))
    {
      this.Set(-1);
    }
    else
    {
      if (!Input.GetKeyDown(KeyCode.RightArrow))
        return;
      this.Set(1);
    }
  }

  private void Set(CardData data)
  {
    this.current = this.cards.IndexOf(data);
    this.StopAllCoroutines();
    this.StartCoroutine(this.SetRoutine(data));
  }

  private IEnumerator SetRoutine(CardData data)
  {
    this.cardHolder.DestroyAllChildren();
    Card card = CardManager.Get(data, (CardController) null, (Character) null, false, false);
    card.entity.returnToPool = false;
    yield return (object) card.UpdateData(false);
    card.transform.SetParent(this.cardHolder);
    card.imageIdleAnimator.FadeIn();
    card.imageIdleAnimator.SetSpeed(1f, 0.636619747f, 0.0f);
    card.backgroundIdleAnimator.FadeIn();
    card.backgroundIdleAnimator.SetSpeed(1f, 0.636619747f, 0.0f);
    Transform transform = card.transform;
    transform.localPosition = Vector3.zero;
    transform.localEulerAngles = Vector3.zero;
    transform.localScale = Vector3.one;
    if ((bool) (UnityEngine.Object) this.inspectSystem)
    {
      Events.InvokeEntityHover(card.entity);
      this.inspectSystem.ClearPopups();
      this.inspectSystem.inspect = card.entity;
      this.inspectSystem.CreatePopups();
    }
  }

  private void Set(int change)
  {
    int index = (this.current + change) % this.cards.Count;
    if (index < 0)
      index += this.cards.Count;
    this.Set(this.cards[index]);
  }
}
