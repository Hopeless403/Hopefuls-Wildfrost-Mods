// Decompiled with JetBrains decompiler
// Type: ScriptableCardImage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

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
