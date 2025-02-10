// Decompiled with JetBrains decompiler
// Type: FinalBossEnemyGenerator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

[CreateAssetMenu(menuName = "Campaign/Final Boss Enemy Generator", fileName = "Final Boss Enemy Generator")]
public class FinalBossEnemyGenerator : ScriptableObject
{
  public CardData enemy;
  public CardData[] fromCards;
}
