// Decompiled with JetBrains decompiler
// Type: TraitData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

[CreateAssetMenu(fileName = "New Trait", menuName = "Trait")]
public class TraitData : DataFile
{
  public KeywordData keyword;
  public StatusEffectData[] effects;
  public TraitData[] overrides;
  public bool isReaction;
}
