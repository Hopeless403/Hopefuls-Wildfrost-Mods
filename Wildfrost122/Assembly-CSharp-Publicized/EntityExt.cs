// Decompiled with JetBrains decompiler
// Type: EntityExt
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.EventSystems;

#nullable disable
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
    bool flag = entity.HasAttackIcon() || entity.data.original.damage > 0;
    if (!flag && entity.attackEffects.Any<CardData.StatusEffectStacks>((Func<CardData.StatusEffectStacks, bool>) (s => s.data.offensive)))
      flag = true;
    if (!flag && entity.statusEffects.Any<StatusEffectData>((Func<StatusEffectData, bool>) (s => s.makesOffensive)))
      flag = true;
    return flag;
  }

  public static bool CanRecall(this Entity entity)
  {
    return entity.data.cardType.canRecall && entity.blockRecall <= 0 && (bool) (UnityEngine.Object) References.Battle && Battle.IsOnBoard(entity);
  }

  public static bool StillExists(this Entity entity)
  {
    return (bool) (UnityEngine.Object) entity && !entity.inCardPool;
  }

  public static bool IsAliveAndExists(this Entity entity)
  {
    return (bool) (UnityEngine.Object) entity && !entity.inCardPool && entity.alive;
  }

  public static bool HasAnyCharms(this Entity entity)
  {
    return entity.data.upgrades != null && entity.data.upgrades.Any<CardUpgradeData>((Func<CardUpgradeData, bool>) (a => a.type == CardUpgradeData.Type.Charm));
  }

  public static void ResetWhenHealthLostEffects(this Entity target)
  {
    foreach (StatusEffectData statusEffect in target.statusEffects)
    {
      if (statusEffect is StatusEffectApplyXWhenHealthLost applyXwhenHealthLost)
        applyXwhenHealthLost.currentHealth = target.hp.current;
    }
  }

  public static HashSet<KeywordData> GetHiddenKeywords(this Entity entity)
  {
    HashSet<KeywordData> hiddenKeywords = new HashSet<KeywordData>();
    foreach (CardData.StatusEffectStacks attackEffect in entity.attackEffects)
    {
      foreach (KeywordData hiddenKeyword in attackEffect.data.hiddenKeywords)
        hiddenKeywords.Add(hiddenKeyword);
    }
    foreach (StatusEffectData statusEffect in entity.statusEffects)
    {
      foreach (KeywordData hiddenKeyword in statusEffect.hiddenKeywords)
        hiddenKeywords.Add(hiddenKeyword);
    }
    return hiddenKeywords;
  }

  public static bool HasAttackIcon(this Entity entity)
  {
    if (entity.damage.max > 0 || entity.damage.current + entity.tempDamage > 0)
      return true;
    return (bool) (UnityEngine.Object) entity.data && entity.data.hasAttack;
  }
}
