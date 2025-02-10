// Decompiled with JetBrains decompiler
// Type: BloodProfile
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using NaughtyAttributes;
using UnityEngine;

#nullable disable
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
