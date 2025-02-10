// Decompiled with JetBrains decompiler
// Type: ScriptableCardImage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

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
