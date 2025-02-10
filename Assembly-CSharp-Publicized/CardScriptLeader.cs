// Decompiled with JetBrains decompiler
// Type: CardScriptLeader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

[CreateAssetMenu(fileName = "Leader", menuName = "Card Scripts/Leader")]
public class CardScriptLeader : CardScript
{
  [SerializeField]
  public CharacterType[] characterTypeOptions;
  [SerializeField]
  public LeaderProfileData[] leaderProfileOptions;

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
