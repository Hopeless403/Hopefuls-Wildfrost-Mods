// Decompiled with JetBrains decompiler
// Type: ParticleSystemCreator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

public class ParticleSystemCreator : MonoBehaviour
{
  [SerializeField]
  private ParticleSystem prefab;

  public void Create() => Object.Instantiate<ParticleSystem>(this.prefab, this.transform).transform.localPosition = Vector3.zero;
}
