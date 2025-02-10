// Decompiled with JetBrains decompiler
// Type: StatusEffectRedrawCards
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

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
