﻿// Decompiled with JetBrains decompiler
// Type: ActionFlee
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using Dead;
using System.Collections;
using UnityEngine;

public class ActionFlee : PlayAction
{
  public readonly Entity entity;

  public ActionFlee(Entity entity) => this.entity = entity;

  public override IEnumerator Run()
  {
    if (this.entity.IsAliveAndExists())
    {
      Debug.Log((object) ("[" + this.entity.name + "] Fleeing!"));
      yield return (object) Sequences.CardMove(this.entity, new CardContainer[1]
      {
        this.entity.owner.reserveContainer
      }, tweenAll: false);
      CardContainer actualContainer = this.entity.actualContainers[0];
      Vector3 localPosition = this.entity.transform.localPosition;
      Entity entity = this.entity;
      LeanTween.moveLocalX(this.entity.gameObject, actualContainer.GetChildPosition(entity).x, 0.8f).setEase(LeanTweenType.linear);
      LeanTween.moveLocalY(this.entity.gameObject, localPosition.y + 0.5f, 0.2f).setEase(Curves.Get("Jump")).setLoopPingPong(4);
      Events.InvokeEntityFlee(this.entity);
      yield return (object) new WaitForSeconds(PettyRandom.Range(0.15f, 0.25f));
    }
  }
}
