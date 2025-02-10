// Decompiled with JetBrains decompiler
// Type: TargetingArrowHeadRow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections.Generic;
using UnityEngine;

public class TargetingArrowHeadRow : MonoBehaviour
{
  [SerializeField]
  private TargetingArrowSystem targetArrowSystem;
  [SerializeField]
  private Transform[] targetTransforms;
  [SerializeField]
  private SpriteRenderer[] targets;
  [SerializeField]
  private Sprite canTarget;
  [SerializeField]
  private Sprite cannotTarget;
  private List<CardSlot> slots;

  private void OnEnable()
  {
    if (!(this.targetArrowSystem.snapToContainer is CardSlotLane snapToContainer))
      return;
    this.slots = snapToContainer.slots;
    if (this.targetArrowSystem.target.data.playOnSlot)
    {
      for (int index = 0; index < this.targets.Length && index < this.slots.Count; ++index)
        this.targets[index].sprite = this.targetArrowSystem.target.CanPlayOn((CardContainer) this.slots[index], true) ? this.canTarget : this.cannotTarget;
    }
    else
    {
      for (int index = 0; index < this.targets.Length && index < this.slots.Count; ++index)
      {
        SpriteRenderer target = this.targets[index];
        CardSlot slot = this.slots[index];
        Sprite sprite = slot.Empty || !this.targetArrowSystem.target.CanPlayOn(slot.GetTop(), true) ? this.cannotTarget : this.canTarget;
        target.sprite = sprite;
      }
    }
  }

  private void LateUpdate()
  {
    for (int index = 0; index < this.targetTransforms.Length && index < this.slots.Count; ++index)
      this.targetTransforms[index].position = this.slots[index].holder.position;
  }
}
