// Decompiled with JetBrains decompiler
// Type: StatusEffectRemoveEffects
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;
using UnityEngine.Localization.Tables;

#nullable disable
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
