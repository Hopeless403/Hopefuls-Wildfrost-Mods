// Decompiled with JetBrains decompiler
// Type: StatusEffectRedrawCards
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

[CreateAssetMenu(menuName = "Status Effects/Traits/Redraw Cards", fileName = "Redraw Cards")]
public class StatusEffectRedrawCards : StatusEffectData
{
  public override bool RunCardPlayedEvent(Entity entity, Entity[] targets)
  {
    if ((Object) entity == (Object) this.target && !this.target.silenced)
      ActionQueue.Stack((PlayAction) new ActionRedraw(this.target.owner));
    return false;
  }
}
