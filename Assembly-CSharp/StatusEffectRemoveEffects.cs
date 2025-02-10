// Decompiled with JetBrains decompiler
// Type: StatusEffectRemoveEffects
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.Localization.Tables;

[CreateAssetMenu(menuName = "Status Effects/Specific/Remove Effects", fileName = "Remove Effects")]
public class StatusEffectRemoveEffects : StatusEffectData
{
  public override bool RunBeginEvent()
  {
    if (this.target.data.playType != Card.PlayType.Place)
    {
      this.target.data.playType = Card.PlayType.Play;
      this.target.data.needsTarget = true;
      this.target.data.canPlayOnBoard = true;
      this.target.data.canPlayOnHand = false;
      this.target.data.canPlayOnFriendly = true;
      this.target.data.canPlayOnEnemy = true;
      this.target.data.playOnSlot = false;
      this.target.data.defaultPlayPosition = CardData.PlayPosition.None;
      this.target.data.targetConstraints = (TargetConstraint[]) null;
      this.target.data.textKey.TableReference = new TableReference();
      this.target.data.desc = "";
      this.target.display.promptUpdateDescription = true;
      this.target.PromptUpdate();
    }
    return false;
  }
}
