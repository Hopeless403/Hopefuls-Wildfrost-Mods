// Decompiled with JetBrains decompiler
// Type: ParticleSystemCreator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

#nullable disable
public class ParticleSystemCreator : MonoBehaviour
{
  [SerializeField]
  private ParticleSystem prefab;

  public void Create()
  {
    Object.Instantiate<ParticleSystem>(this.prefab, this.transform).transform.localPosition = Vector3.zero;
  }
}
