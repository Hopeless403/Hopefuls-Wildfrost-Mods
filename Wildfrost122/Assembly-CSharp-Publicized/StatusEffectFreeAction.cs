// Decompiled with JetBrains decompiler
// Type: StatusEffectFreeAction
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using Dead;
using System.Collections;
using UnityEngine;

#nullable disable
[CreateAssetMenu(menuName = "Status Effects/Traits/Free Action", fileName = "Free Action")]
public class StatusEffectFreeAction : StatusEffectData
{
  [SerializeField]
  public ItemHolderPet petPrefab;
  public bool hasEffect;

  public override void Init()
  {
    this.OnCardPlayed += new StatusEffectData.EffectCardPlayEventHandler(this.CardPlayed);
  }

  public override bool RunBeginEvent()
  {
    if (!this.target.inPlay || this.target.enabled)
    {
      this.hasEffect = true;
      if (!GameManager.paused && this.target.display is Card display)
      {
        display.itemHolderPet?.Create(this.petPrefab);
        Events.InvokeNoomlinShow(this.target);
      }
    }
    return false;
  }

  public override bool RunCardMoveEvent(Entity entity)
  {
    if ((Object) entity == (Object) this.target)
    {
      if (this.target.InHand())
        this.RunBeginEvent();
      else if (this.hasEffect && !Battle.IsOnBoard(entity.preContainers) && Battle.IsOnBoard(entity))
      {
        this.hasEffect = false;
        if (this.target.display is Card display)
          display.itemHolderPet?.Used();
        this.target.owner.freeAction = true;
      }
    }
    return false;
  }

  public override bool RunEnableEvent(Entity entity)
  {
    if ((Object) entity == (Object) this.target)
      this.RunBeginEvent();
    return false;
  }

  public override bool RunDisableEvent(Entity entity)
  {
    if ((Object) entity == (Object) this.target)
      this.RunEndEvent();
    return false;
  }

  public override bool RunEndEvent()
  {
    this.hasEffect = false;
    if ((Object) this.target != (Object) null && this.target.display is Card display)
      display.itemHolderPet?.DestroyCurrent();
    return false;
  }

  public override bool RunCardPlayedEvent(Entity entity, Entity[] targets)
  {
    return this.hasEffect && (Object) entity == (Object) this.target && !this.target.silenced;
  }

  public IEnumerator CardPlayed(Entity entity, Entity[] targets)
  {
    StatusEffectFreeAction effectFreeAction = this;
    effectFreeAction.hasEffect = false;
    if (effectFreeAction.target.display is Card display)
    {
      display.itemHolderPet?.Used();
      Events.InvokeNoomlinUsed(effectFreeAction.target);
      Mover mover = display.gameObject.AddComponent<Mover>();
      mover.velocity = new Vector3(PettyRandom.Range(0.0f, 1f).WithRandomSign(), -12f, 0.0f);
      mover.frictMult = 0.8f;
      effectFreeAction.target.wobbler?.WobbleRandom();
      yield return (object) Sequences.Wait(0.6f);
    }
    effectFreeAction.target.owner.freeAction = true;
  }
}
