// Decompiled with JetBrains decompiler
// Type: CardScriptLeader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

[CreateAssetMenu(fileName = "Leader", menuName = "Card Scripts/Leader")]
public class CardScriptLeader : CardScript
{
  [SerializeField]
  private CharacterType[] characterTypeOptions;
  [SerializeField]
  private LeaderProfileData[] leaderProfileOptions;

  public override void Run(CardData target)
  {
    CharacterType type = this.characterTypeOptions.RandomItem<CharacterType>();
    CharacterData characterData = new CharacterData()
    {
      race = type.race,
      gender = type.gender
    };
    LeaderProfileData leaderProfileData = this.leaderProfileOptions.RandomItem<LeaderProfileData>();
    leaderProfileData.Apply(type);
    target.backgroundSprite = leaderProfileData.GetRandomBackground();
    characterData.Randomize(type);
    leaderProfileData.UnApply(type);
    target.forceTitle = characterData.title;
    target.SetCustomData("CharacterData", (object) characterData);
  }
}
