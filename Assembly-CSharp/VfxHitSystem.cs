// Decompiled with JetBrains decompiler
// Type: VfxHitSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using FMODUnity;
using System;
using UnityEngine;
using UnityEngine.Events;

public class VfxHitSystem : GameSystem
{
  [SerializeField]
  private AnimationCurve profileCurve;
  [SerializeField]
  private VfxHitSystem.Profile[] profiles;
  [SerializeField]
  private VfxHitSystem.WithStatusProfile[] withStatusProfiles;

  private VfxHitSystem.Profile GetProfile(int power) => this.profiles[Mathf.Clamp(Mathf.RoundToInt(this.profileCurve.Evaluate((float) power)), 0, this.profiles.Length - 1)];

  private static int GetHitPower(Hit hit) => hit.damage + hit.damageBlocked + hit.extraOffensiveness;

  private void OnEnable() => global::Events.OnEntityHit += new UnityAction<Hit>(this.EntityHit);

  private void OnDisable() => global::Events.OnEntityHit -= new UnityAction<Hit>(this.EntityHit);

  private void EntityHit(Hit hit)
  {
    if (!hit.Offensive || !hit.doAnimation || !hit.countsAsHit || !hit.BasicHit || VfxHitSystem.GetHitPower(hit) <= 0 || !(bool) (UnityEngine.Object) hit.target)
      return;
    this.TakeHit(hit);
  }

  private void TakeHit(Hit hit)
  {
    Vector3 position1 = hit.target.transform.position;
    Vector3 position2 = position1;
    if ((bool) (UnityEngine.Object) hit.attacker)
    {
      Vector3 normalized = (position2 - hit.attacker.transform.position).normalized;
      position2 += normalized * -1f;
      position2.z = hit.target.transform.position.z;
    }
    VfxHitSystem.Profile profile = this.GetProfile(VfxHitSystem.GetHitPower(hit));
    if ((bool) (UnityEngine.Object) profile.effectPrefab)
      this.CreateEffect(profile.effectPrefab, position2, hit.target.transform.lossyScale);
    foreach (VfxHitSystem.WithStatusProfile withStatusProfile in this.withStatusProfiles)
    {
      if ((bool) (UnityEngine.Object) hit.target.FindStatus(withStatusProfile.statusType))
      {
        this.CreateEffect(withStatusProfile.effectPrefab, position1, hit.target.transform.lossyScale);
        if (!withStatusProfile.sfxEvent.IsNull)
          SfxSystem.OneShot(withStatusProfile.sfxEvent);
      }
    }
  }

  private void CreateEffect(GameObject prefab, Vector3 position, Vector3 scale)
  {
    if (!(bool) (UnityEngine.Object) prefab)
      return;
    UnityEngine.Object.Instantiate<GameObject>(prefab, position, Quaternion.identity, this.transform).transform.localScale = scale;
  }

  [Serializable]
  private class Profile
  {
    public GameObject effectPrefab;
  }

  [Serializable]
  private class WithStatusProfile
  {
    public string statusType;
    public GameObject effectPrefab;
    public EventReference sfxEvent;
  }
}
