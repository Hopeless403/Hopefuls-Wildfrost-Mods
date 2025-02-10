// Decompiled with JetBrains decompiler
// Type: TargetingDisplay
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

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
