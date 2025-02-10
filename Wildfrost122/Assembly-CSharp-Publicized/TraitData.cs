// Decompiled with JetBrains decompiler
// Type: TraitData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

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
