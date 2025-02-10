// Decompiled with JetBrains decompiler
// Type: TargetingArrowHeadRow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections.Generic;
using UnityEngine;

public class TargetingArrowHeadRow : MonoBehaviour
{
  [SerializeField]
  public TargetingArrowSystem targetArrowSystem;
  [SerializeField]
  public Transform[] targetTransforms;
  [SerializeField]
  public SpriteRenderer[] targets;
  [SerializeField]
  public Sprite canTarget;
  [SerializeField]
  public Sprite cannotTarget;
  public List<CardSlot> slots;

  public void OnEnable()
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

  public void LateUpdate()
  {
    for (int index = 0; index < this.targetTransforms.Length && index < this.slots.Count; ++index)
      this.targetTransforms[index].position = this.slots[index].holder.position;
  }
}
