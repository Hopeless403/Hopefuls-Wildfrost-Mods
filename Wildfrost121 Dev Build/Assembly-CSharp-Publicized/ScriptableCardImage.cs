// Decompiled with JetBrains decompiler
// Type: ScriptableCardImage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

#nullable disable
public class ScriptableCardImage : MonoBehaviour
{
  public Entity entity;

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
