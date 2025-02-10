// Decompiled with JetBrains decompiler
// Type: BattleData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;
using UnityEngine.Localization;

#nullable disable
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
