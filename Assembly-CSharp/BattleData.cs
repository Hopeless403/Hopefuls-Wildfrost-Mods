// Decompiled with JetBrains decompiler
// Type: BattleData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.Localization;

[CreateAssetMenu(fileName = "BattleData", menuName = "Battle")]
public class BattleData : DataFile
{
  public string title;
  public float pointFactor = 1f;
  public int waveCounter = 4;
  public BattleWavePoolData[] pools;
  public CardData[] bonusUnitPool;
  public Vector2Int bonusUnitRange;
  public CardData[] goldGiverPool;
  public int goldGivers = 1;
  public BattleGenerationScript generationScript;
  public Script setUpScript;
  public Sprite sprite;
  public LocalizedString nameRef;
}
