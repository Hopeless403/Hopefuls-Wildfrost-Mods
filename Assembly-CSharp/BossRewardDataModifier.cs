// Decompiled with JetBrains decompiler
// Type: BossRewardDataModifier
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using UnityEngine;

[CreateAssetMenu(menuName = "Boss Rewards/Modifier", fileName = "Modifier")]
public class BossRewardDataModifier : BossRewardData
{
  public override BossRewardData.Data Pull()
  {
    string name = References.Player.GetComponent<CharacterRewards>().Pull<GameModifierData>((object) this, "Modifiers").name;
    BossRewardDataModifier.Data data = new BossRewardDataModifier.Data();
    data.type = BossRewardData.Type.Modifier;
    data.modifierName = name;
    return (BossRewardData.Data) data;
  }

  [Serializable]
  public new class Data : BossRewardData.Data
  {
    public string modifierName;

    public GameModifierData GetModifier() => AddressableLoader.Get<GameModifierData>("GameModifierData", this.modifierName);

    public override void Select()
    {
      GameModifierData modifier = this.GetModifier();
      ModifierSystem.AddModifier(Campaign.Data, modifier);
      Routine.Clump clump = new Routine.Clump();
      foreach (Script startScript in modifier.startScripts)
        clump.Add(startScript.Run());
      foreach (Script setupScript in modifier.setupScripts)
        clump.Add(setupScript.Run());
      foreach (string componentName in modifier.systemsToAdd)
      {
        Debug.Log((object) string.Format("[{0}] adding system: {1}", (object) modifier, (object) componentName));
        Campaign.instance.gameObject.AddComponentByName(componentName);
      }
    }
  }
}
