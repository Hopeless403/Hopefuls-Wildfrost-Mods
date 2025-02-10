// Decompiled with JetBrains decompiler
// Type: CombineSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using Dead;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
public class CombineSystem : GameSystem
{
  public static CombineSystem instance;
  [SerializeField]
  private Fader fader;
  [SerializeField]
  private Graphic flash;
  [SerializeField]
  private AnimationCurve flashCurve;
  [SerializeField]
  private AnimationCurve bounceCurve;
  [SerializeField]
  private Transform group;
  [SerializeField]
  private Transform pointPrefab;
  [SerializeField]
  private ParticleSystem ps;
  private readonly List<Transform> points = new List<Transform>();
  private readonly Dictionary<Entity, Transform> originalParents = new Dictionary<Entity, Transform>();

  private void Awake() => CombineSystem.instance = this;

  public IEnumerator Combine(Entity[] entities, Entity finalEntity)
  {
    CombineSystem combineSystem = this;
    combineSystem.fader.In();
    Vector3 zero = Vector3.zero;
    foreach (Entity entity in entities)
      zero += entity.transform.position;
    Vector3 vector3 = zero / (float) entities.Length;
    combineSystem.group.position = vector3;
    foreach (Entity entity in entities)
    {
      Transform p = UnityEngine.Object.Instantiate<Transform>(combineSystem.pointPrefab, entity.transform.position, Quaternion.identity, combineSystem.group);
      p.gameObject.SetActive(true);
      combineSystem.originalParents[entity] = entity.transform.parent;
      entity.transform.SetParent(p);
      combineSystem.points.Add(p);
    }
    foreach (Transform point in combineSystem.points)
      LeanTween.moveLocal(point.gameObject, point.localPosition.normalized * 0.5f, 0.4f).setEaseInBack();
    yield return (object) new WaitForSeconds(0.4f);
    combineSystem.Flash(0.5f);
    Events.InvokeScreenShake();
    foreach (Entity entity in entities)
      entity.wobbler.WobbleRandom();
    foreach (Transform point in combineSystem.points)
      LeanTween.moveLocal(point.gameObject, point.localPosition.normalized * 3f, 1f).setEase(combineSystem.bounceCurve);
    LeanTween.moveLocal(combineSystem.group.gameObject, new Vector3(0.0f, 0.0f, -2f), 1f).setEaseInOutQuad();
    // ISSUE: reference to a compiler-generated method
    LeanTween.rotateZ(combineSystem.group.gameObject, PettyRandom.Range(160f, 180f), 1f).setOnUpdateVector3(new Action<Vector3>(combineSystem.\u003CCombine\u003Eb__11_0)).setEaseInOutQuad();
    yield return (object) new WaitForSeconds(1f);
    combineSystem.Flash();
    Events.InvokeScreenShake();
    if ((UnityEngine.Object) combineSystem.ps != (UnityEngine.Object) null)
      combineSystem.ps.Play();
    finalEntity.data = finalEntity.data.Clone(finalEntity.data.random3, finalEntity.data.id, false);
    finalEntity.data.forceTitle = finalEntity.data.title;
    Routine.Clump clump = new Routine.Clump();
    foreach (Entity entity in entities.Without<Entity>(finalEntity))
    {
      finalEntity.data.forceTitle += entity.data.title;
      clump.Add(CombineSystem.Combine(entity, finalEntity));
    }
    yield return (object) clump.WaitForEnd();
    foreach (Entity.TraitStacks traitStacks in finalEntity.traits.Where<Entity.TraitStacks>((Func<Entity.TraitStacks, bool>) (a => a.data.name == "Build")))
      traitStacks.count = 0;
    yield return (object) StatusEffectSystem.BuildEvent(finalEntity);
    yield return (object) finalEntity.UpdateTraits();
    double num = (double) finalEntity.curveAnimator.Ping();
    finalEntity.wobbler.WobbleRandom();
    finalEntity.counter.current = finalEntity.counter.max;
    finalEntity.alive = false;
    yield return (object) finalEntity.display.UpdateData();
    yield return (object) finalEntity.UpdateTraits();
    finalEntity.alive = true;
    yield return (object) StatusEffectSystem.EntityEnableEvent(finalEntity);
    combineSystem.fader.Out();
    yield return (object) new WaitForSeconds(1f);
    foreach (KeyValuePair<Entity, Transform> keyValuePair in combineSystem.originalParents.Where<KeyValuePair<Entity, Transform>>((Func<KeyValuePair<Entity, Transform>, bool>) (pair => (bool) (UnityEngine.Object) pair.Key && (bool) (UnityEngine.Object) pair.Value)))
    {
      keyValuePair.Key.transform.SetParent(keyValuePair.Value);
      keyValuePair.Key.TweenToContainer();
      keyValuePair.Key.wobbler.WobbleRandom();
    }
    combineSystem.originalParents.Clear();
    foreach (Component component in combineSystem.points.Where<Transform>((Func<Transform, bool>) (p => (bool) (UnityEngine.Object) p)))
      UnityEngine.Object.Destroy((UnityEngine.Object) component.gameObject);
    combineSystem.points.Clear();
    combineSystem.group.transform.localEulerAngles = Vector3.zero;
  }

  private static IEnumerator Combine(Entity entity, Entity inTo)
  {
    if (!inTo.data.hasAttack)
      inTo.data.hasAttack = entity.data.hasAttack;
    if (!inTo.data.hasHealth)
      inTo.data.hasHealth = entity.data.hasHealth;
    inTo.data.damage += entity.data.damage;
    inTo.data.hp += entity.data.hp;
    inTo.data.counter = Mathf.Max(inTo.data.counter, entity.data.counter);
    inTo.attackEffects = CardData.StatusEffectStacks.Stack((IEnumerable<CardData.StatusEffectStacks>) inTo.attackEffects, (IEnumerable<CardData.StatusEffectStacks>) entity.attackEffects).ToList<CardData.StatusEffectStacks>();
    List<StatusEffectData> statusEffectDataList = entity.statusEffects.Clone<StatusEffectData>();
    foreach (Entity.TraitStacks trait in entity.traits)
    {
      foreach (StatusEffectData passiveEffect in trait.passiveEffects)
        statusEffectDataList.Remove(passiveEffect);
      int count = trait.count - trait.tempCount;
      if (count > 0)
        inTo.GainTrait(trait.data, count);
    }
    Events.InvokeScreenShake();
    Routine.Clump clump = new Routine.Clump();
    foreach (StatusEffectData effectData in statusEffectDataList)
      clump.Add(StatusEffectSystem.Apply(inTo, effectData.applier, effectData, effectData.count));
    yield return (object) clump.WaitForEnd();
    entity.RemoveFromContainers();
    CardManager.ReturnToPool(entity);
  }

  private void Flash(float intensity = 1f, float duration = 0.1f)
  {
    this.flash.gameObject.SetActive(true);
    LeanTween.cancel(this.flash.gameObject);
    LeanTween.value(this.flash.gameObject, 0.0f, intensity, duration).setEase(this.flashCurve).setOnUpdate((Action<float>) (a => this.flash.color = this.flash.color.With(alpha: a))).setOnComplete((System.Action) (() => this.flash.gameObject.SetActive(false)));
  }
}
