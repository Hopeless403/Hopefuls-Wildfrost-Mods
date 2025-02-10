// Decompiled with JetBrains decompiler
// Type: StatusEffectRedrawCards
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

#nullable disable
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
