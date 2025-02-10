// Decompiled with JetBrains decompiler
// Type: BloodProfile
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
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
