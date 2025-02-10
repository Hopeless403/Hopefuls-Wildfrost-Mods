// Decompiled with JetBrains decompiler
// Type: TargetingDisplay
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

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
