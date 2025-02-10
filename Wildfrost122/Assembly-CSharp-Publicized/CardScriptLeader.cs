// Decompiled with JetBrains decompiler
// Type: CardScriptLeader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

#nullable disable
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
