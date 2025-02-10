// Decompiled with JetBrains decompiler
// Type: ClickParticleSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
public class ClickParticleSystem : GameSystem
{
  [SerializeField]
  public ParticleSystem fxPrefab;
  [SerializeField]
  public Transform group;
  public readonly List<ParticleSystem> pool = new List<ParticleSystem>();

  public void Update()
  {
    if (!InputSystem.IsSelectPressed())
      return;
    this.Pop();
  }

  public void Pop()
  {
    ParticleSystem ps = this.Get();
    ps.transform.position = Cursor3d.PositionWithZ;
    ps.Play(true);
    this.StartCoroutine(this.ReturnToPoolWhenFinished(ps));
  }

  public IEnumerator ReturnToPoolWhenFinished(ParticleSystem ps)
  {
    while (ps.isPlaying)
      yield return (object) null;
    ps.gameObject.SetActive(false);
    this.pool.Add(ps);
  }

  public ParticleSystem Get()
  {
    if (this.pool.Count <= 0)
      return Object.Instantiate<ParticleSystem>(this.fxPrefab, this.group);
    ParticleSystem particleSystem = this.pool[0];
    this.pool.RemoveAt(0);
    particleSystem.gameObject.SetActive(true);
    return particleSystem;
  }
}
