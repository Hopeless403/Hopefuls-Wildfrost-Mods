// Decompiled with JetBrains decompiler
// Type: BloodProfile
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using NaughtyAttributes;
using UnityEngine;

[CreateAssetMenu(fileName = "Blood Profile", menuName = "Blood Profile")]
public class BloodProfile : ScriptableObject
{
  public bool variableColor;
  [HideIf("variableColor")]
  public Color color;
  [ShowIf("variableColor")]
  public Gradient colorRange;
  [Range(0.0f, 2f)]
  public float bleedFactor = 1f;
  public SplatterParticle splatterParticlePrefab;
}
