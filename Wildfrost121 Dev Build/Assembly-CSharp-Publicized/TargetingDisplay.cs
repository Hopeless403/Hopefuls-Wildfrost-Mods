// Decompiled with JetBrains decompiler
// Type: TargetingDisplay
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

#nullable disable
public abstract class TargetingDisplay : MonoBehaviour
{
  public virtual void UpdatePosition(Transform target)
  {
  }

  public virtual void UpdatePosition(Vector3 start, Vector3 end)
  {
  }

  public virtual void Show(TargetingArrowSystem system)
  {
  }

  public virtual void Hide()
  {
  }

  public virtual void ResetStyle()
  {
  }

  public virtual void EntityHover(Entity entity)
  {
  }

  public virtual void ContainerHover(CardContainer cardContainer, TargetingArrowSystem system)
  {
  }

  public virtual void SlotHover(CardSlot slot, TargetingArrowSystem system)
  {
  }
}
