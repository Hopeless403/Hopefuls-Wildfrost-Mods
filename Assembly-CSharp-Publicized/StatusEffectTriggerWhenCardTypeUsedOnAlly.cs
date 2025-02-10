// Decompiled with JetBrains decompiler
// Type: StatusEffectTriggerWhenCardTypeUsedOnAlly
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

[CreateAssetMenu(menuName = "Status Effects/Reactions/Trigger When Card Type Used On Ally", fileName = "Trigger When Card Type Used On Ally")]
public class StatusEffectTriggerWhenCardTypeUsedOnAlly : StatusEffectReaction
{
  [SerializeField]
  public bool includeSelf;
  [SerializeField]
  public string[] cardTypeTriggers;

  public override bool RunCardPlayedEvent(Entity entity, Entity[] targets)
  {
    if (this.CheckCardType(entity) && this.CheckTargets(targets) && Battle.IsOnBoard(this.target) && this.CanTrigger())
      ActionQueue.Stack((PlayAction) new ActionTrigger(this.target, entity), true);
    return false;
  }

  public bool CheckCardType(Entity entity)
  {
    bool flag = false;
    string tag = entity.data?.cardType?.tag;
    if (tag != null)
    {
      foreach (string cardTypeTrigger in this.cardTypeTriggers)
      {
        if (tag.Equals(cardTypeTrigger))
        {
          flag = true;
          break;
        }
      }
    }
    return flag;
  }

  public bool CheckTargets(Entity[] targets)
  {
    bool flag = false;
    foreach (Entity target in targets)
    {
      if ((Object) target.owner == (Object) this.target.owner && ((Object) target != (Object) this.target || this.includeSelf))
      {
        flag = true;
        break;
      }
    }
    return flag;
  }
}
