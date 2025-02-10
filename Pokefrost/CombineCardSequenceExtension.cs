// Decompiled with JetBrains decompiler
// Type: Pokefrost.CombineCardSequenceExtension
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using Dead;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Pokefrost
{
  public static class CombineCardSequenceExtension
  {
    public static IEnumerator Run2(
      this CombineCardSequence seq,
      List<Entity> cardsToCombine,
      string resultingCard)
    {
      CardData cardDataClone = AddressableLoader.GetCardDataClone(resultingCard);
      CardUpgradeData upgrade = Pokefrost.Pokefrost.instance.Get<CardUpgradeData>("CardUpgradeHunger").Clone();
      upgrade.Assign(cardDataClone);
      yield return (object) seq.Run2(cardsToCombine.ToArray(), cardDataClone);
    }

    public static IEnumerator Run2(
      this CombineCardSequence seq,
      Entity[] entities,
      CardData finalCard)
    {
      PauseMenu.Block();
      Card card = CardManager.Get(finalCard, Battle.instance.playerCardController, References.Player, false, true);
      card.transform.localScale = Vector3.one * 1f;
      card.transform.SetParent(seq.finalEntityParent);
      Entity finalEntity = card.entity;
      Routine.Clump clump = new Routine.Clump();
      Entity[] array = entities;
      Entity[] entityArray1 = array;
      for (int index = 0; index < entityArray1.Length; ++index)
      {
        Entity entity = entityArray1[index];
        clump.Add(entity.display.UpdateData());
        entity = (Entity) null;
      }
      entityArray1 = (Entity[]) null;
      clump.Add(finalEntity.display.UpdateData());
      clump.Add(Sequences.Wait(0.5f));
      yield return (object) clump.WaitForEnd();
      array = entities;
      Entity[] entityArray2 = array;
      for (int index = 0; index < entityArray2.Length; ++index)
      {
        Entity entity2 = entityArray2[index];
        entity2.RemoveFromContainers();
        entity2 = (Entity) null;
      }
      entityArray2 = (Entity[]) null;
      array = entities;
      for (int i = 0; i < array.Length; ++i)
        array[i].transform.localScale = Vector3.one * 0.8f;
      seq.fader.In();
      Vector3 zero = Vector3.zero;
      array = entities;
      Entity[] entityArray3 = array;
      for (int index = 0; index < entityArray3.Length; ++index)
      {
        Entity entity3 = entityArray3[index];
        zero += entity3.transform.position;
        entity3 = (Entity) null;
      }
      entityArray3 = (Entity[]) null;
      zero /= (float) entities.Length;
      seq.group.position = zero;
      array = entities;
      Entity[] entityArray4 = array;
      for (int index = 0; index < entityArray4.Length; ++index)
      {
        Entity entity4 = entityArray4[index];
        Transform transform = UnityEngine.Object.Instantiate<Transform>(seq.pointPrefab, entity4.transform.position, Quaternion.identity, seq.group);
        transform.gameObject.SetActive(true);
        entity4.transform.SetParent(transform);
        entity4.flipper.FlipUp();
        seq.points.Add(transform);
        LeanTween.alphaCanvas(((Card) entity4.display).canvasGroup, 1f, 0.4f).setEaseInQuad();
        transform = (Transform) null;
        entity4 = (Entity) null;
      }
      entityArray4 = (Entity[]) null;
      foreach (Transform point in seq.points)
        LeanTween.moveLocal(point.gameObject, point.localPosition.normalized, 0.4f).setEaseInQuart();
      yield return (object) new WaitForSeconds(0.4f);
      Events.InvokeScreenShake();
      array = entities;
      for (int i = 0; i < array.Length; ++i)
        array[i].wobbler.WobbleRandom();
      foreach (Transform point2 in seq.points)
        LeanTween.moveLocal(point2.gameObject, point2.localPosition.normalized * 3f, 1f).setEase(seq.bounceCurve);
      LeanTween.moveLocal(seq.group.gameObject, new Vector3(0.0f, 0.0f, -2f), 1f).setEaseInOutQuad();
      LeanTween.rotateZ(seq.group.gameObject, PettyRandom.Range(160f, 180f), 1f).setOnUpdateVector3((Action<Vector3>) (_param1 =>
      {
        foreach (Component point in seq.points)
          point.transform.eulerAngles = Vector3.zero;
      })).setEaseInOutQuad();
      yield return (object) new WaitForSeconds(1f);
      Events.InvokeScreenShake();
      if ((bool) (UnityEngine.Object) seq.ps)
        seq.ps.Play();
      seq.combinedFx.SetActive(true);
      finalEntity.transform.position = Vector3.zero;
      array = entities;
      for (int i = 0; i < array.Length; ++i)
        CardManager.ReturnToPool(array[i]);
      seq.group.transform.localRotation = Quaternion.identity;
      double num = (double) finalEntity.curveAnimator.Ping();
      finalEntity.wobbler.WobbleRandom();
      yield return (object) new WaitForSeconds(1f);
      seq.fader.gameObject.Destroy();
      PauseMenu.Unblock();
      yield return (object) Sequences.CardMove(finalEntity, new CardContainer[1]
      {
        References.Player.handContainer
      });
      References.Player.handContainer.TweenChildPositions();
      finalEntity.inPlay = true;
      ActionQueue.Stack((PlayAction) new ActionReveal(finalEntity));
      Debug.Log((object) "[Pokefrost] Fused Lumin Vase");
    }
  }
}
