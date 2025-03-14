﻿// Decompiled with JetBrains decompiler
// Type: EntityExt
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Linq;
using UnityEngine;
using UnityEngine.EventSystems;

public static class EntityExt
{
  public static Vector3 GetContainerWorldPosition(this Entity entity)
  {
    Vector3 zero = Vector3.zero;
    if (entity.actualContainers.Count > 0)
    {
      foreach (CardContainer actualContainer in entity.actualContainers)
        zero += actualContainer.holder.position + actualContainer.GetChildPosition(entity);
      zero /= (float) entity.actualContainers.Count;
    }
    return zero;
  }

  public static Vector3 GetContainerLocalPosition(this Entity entity)
  {
    Vector3 containerLocalPosition = Vector3.zero;
    if (entity.actualContainers.Count > 0)
    {
      Vector3 zero = Vector3.zero;
      foreach (CardContainer actualContainer in entity.actualContainers)
        zero += actualContainer.holder.position + actualContainer.GetChildPosition(entity);
      containerLocalPosition = zero / (float) entity.actualContainers.Count - entity.actualContainers[0].holder.position;
    }
    return containerLocalPosition;
  }

  public static Vector3 GetContainerWorldRotation(this Entity entity)
  {
    Vector3 containerWorldRotation = Vector3.zero;
    if (entity.actualContainers.Count > 0)
    {
      foreach (CardContainer actualContainer in entity.actualContainers)
        containerWorldRotation += actualContainer.GetChildRotation(entity);
      containerWorldRotation = containerWorldRotation / (float) entity.actualContainers.Count + entity.actualContainers[0].holder.eulerAngles;
    }
    return containerWorldRotation;
  }

  public static Vector3 GetContainerLocalRotation(this Entity entity)
  {
    Vector3 zero = Vector3.zero;
    if (entity.actualContainers.Count > 0)
    {
      foreach (CardContainer actualContainer in entity.actualContainers)
        zero += actualContainer.GetChildRotation(entity);
      zero /= (float) entity.actualContainers.Count;
    }
    return zero;
  }

  public static Vector3 GetContainerScale(this Entity entity)
  {
    Vector3 zero = Vector3.zero;
    if (entity.actualContainers.Count > 0)
    {
      foreach (CardContainer actualContainer in entity.actualContainers)
        zero += actualContainer.GetChildScale(entity);
      zero /= (float) entity.actualContainers.Count;
    }
    return zero;
  }

  public static void TweenToContainer(this Entity entity)
  {
    int count = entity.actualContainers.Count;
    if (count <= 0)
      return;
    CardContainer actualContainer1 = entity.actualContainers[0];
    if (count > 1)
    {
      Vector3 zero1 = Vector3.zero;
      Vector3 zero2 = Vector3.zero;
      Vector3 zero3 = Vector3.zero;
      foreach (CardContainer actualContainer2 in entity.actualContainers)
      {
        zero1 += actualContainer2.GetChildScale(entity);
        zero2 += actualContainer2.GetChildRotation(entity);
        zero3 += actualContainer2.holder.position + actualContainer2.GetChildPosition(entity);
      }
      Vector3 to1 = zero1 / (float) count;
      Vector3 to2 = zero2 / (float) count;
      Vector3 position = zero3 / (float) count;
      Vector3 to3 = actualContainer1.holder.InverseTransformPoint(position) * -1f;
      LeanTween.cancel(entity.gameObject);
      LeanTween.scale(entity.gameObject, to1, actualContainer1.scaleDurRand.PettyRandom()).setEase(actualContainer1.scaleEase);
      LeanTween.rotateLocal(entity.gameObject, to2, actualContainer1.movementDurRand.PettyRandom()).setEase(actualContainer1.movementEase);
      LeanTween.moveLocal(entity.gameObject, to3, actualContainer1.movementDurRand.PettyRandom()).setEase(actualContainer1.movementEase);
    }
    else
    {
      Vector3 childScale = actualContainer1.GetChildScale(entity);
      Vector3 childRotation = actualContainer1.GetChildRotation(entity);
      Vector3 childPosition = actualContainer1.GetChildPosition(entity);
      LeanTween.cancel(entity.gameObject);
      LeanTween.scale(entity.gameObject, childScale, actualContainer1.scaleDurRand.PettyRandom()).setEase(actualContainer1.scaleEase);
      LeanTween.rotateLocal(entity.gameObject, childRotation, actualContainer1.movementDurRand.PettyRandom()).setEase(actualContainer1.movementEase);
      LeanTween.moveLocal(entity.gameObject, childPosition, actualContainer1.movementDurRand.PettyRandom()).setEase(actualContainer1.movementEase);
    }
  }

  public static void ForceUnHover(this Entity entity)
  {
    EntityDisplay display = entity.display;
    if (!(display is Card))
      return;
    CardHover hover = display.hover;
    if (hover == null)
      return;
    hover.OnPointerExit((PointerEventData) null);
    hover.ForceUnHover();
  }

  public static bool IsOffensive(this Entity entity)
  {
    bool flag = entity.data.hasAttack || entity.damage.max > 0 || entity.damage.current + entity.tempDamage.Value > 0 || entity.data.original.damage > 0;
    if (!flag && entity.attackEffects.Any<CardData.StatusEffectStacks>((Func<CardData.StatusEffectStacks, bool>) (s => s.data.offensive)))
      flag = true;
    if (!flag && entity.statusEffects.Any<StatusEffectData>((Func<StatusEffectData, bool>) (s => s.makesOffensive)))
      flag = true;
    return flag;
  }

  public static bool CanRecall(this Entity entity) => entity.data.cardType.canRecall && entity.blockRecall <= 0 && (bool) (UnityEngine.Object) References.Battle && Battle.IsOnBoard(entity);

  public static bool StillExists(this Entity entity) => (bool) (UnityEngine.Object) entity && !entity.inCardPool;

  public static bool IsAliveAndExists(this Entity entity) => (bool) (UnityEngine.Object) entity && !entity.inCardPool && entity.alive;

  public static bool HasAnyCharms(this Entity entity) => entity.data.upgrades != null && entity.data.upgrades.Any<CardUpgradeData>((Func<CardUpgradeData, bool>) (a => a.type == CardUpgradeData.Type.Charm));
}
