// Decompiled with JetBrains decompiler
// Type: ScriptableCardImage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

#nullable disable
public class ScriptableCardImage : MonoBehaviour
{
  protected Entity entity;

  public void Assign(Entity entity)
  {
    this.entity = entity;
    this.AssignEvent();
  }

  public virtual void AssignEvent()
  {
  }

  public virtual void UpdateEvent()
  {
  }
}
