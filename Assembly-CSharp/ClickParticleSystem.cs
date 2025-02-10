// Decompiled with JetBrains decompiler
// Type: ClickParticleSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickParticleSystem : GameSystem
{
  [SerializeField]
  private ParticleSystem fxPrefab;
  [SerializeField]
  private Transform group;
  private readonly List<ParticleSystem> pool = new List<ParticleSystem>();

  private void Update()
  {
    if (!InputSystem.IsSelectPressed())
      return;
    this.Pop();
  }

  private void Pop()
  {
    ParticleSystem ps = this.Get();
    ps.transform.position = Cursor3d.PositionWithZ;
    ps.Play(true);
    this.StartCoroutine(this.ReturnToPoolWhenFinished(ps));
  }

  private IEnumerator ReturnToPoolWhenFinished(ParticleSystem ps)
  {
    while (ps.isPlaying)
      yield return (object) null;
    ps.gameObject.SetActive(false);
    this.pool.Add(ps);
  }

  private ParticleSystem Get()
  {
    if (this.pool.Count <= 0)
      return Object.Instantiate<ParticleSystem>(this.fxPrefab, this.group);
    ParticleSystem particleSystem = this.pool[0];
    this.pool.RemoveAt(0);
    particleSystem.gameObject.SetActive(true);
    return particleSystem;
  }
}
