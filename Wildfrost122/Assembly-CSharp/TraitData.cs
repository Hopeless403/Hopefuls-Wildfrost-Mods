// Decompiled with JetBrains decompiler
// Type: TraitData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "New Trait", menuName = "Trait")]
public class TraitData : DataFile
{
  public KeywordData keyword;
  public StatusEffectData[] effects;
  public TraitData[] overrides;
  public bool isReaction;
}
