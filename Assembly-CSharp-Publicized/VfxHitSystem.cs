// Decompiled with JetBrains decompiler
// Type: VfxHitSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using FMODUnity;
using System;
using UnityEngine;
using UnityEngine.Events;

public class VfxHitSystem : GameSystem
{
  [SerializeField]
  public AnimationCurve profileCurve;
  [SerializeField]
  public VfxHitSystem.Profile[] profiles;
  [SerializeField]
  public VfxHitSystem.WithStatusProfile[] withStatusProfiles;

  public VfxHitSystem.Profile GetProfile(int power) => this.profiles[Mathf.Clamp(Mathf.RoundToInt(this.profileCurve.Evaluate((float) power)), 0, this.profiles.Length - 1)];

  public static int GetHitPower(Hit hit) => hit.damage + hit.damageBlocked + hit.extraOffensiveness;

  public void OnEnable() => global::Events.OnEntityHit += new UnityAction<Hit>(this.EntityHit);

  public void OnDisable() => global::Events.OnEntityHit -= new UnityAction<Hit>(this.EntityHit);

  public void EntityHit(Hit hit)
  {
    if (!hit.Offensive || !hit.doAnimation || !hit.countsAsHit || !hit.BasicHit || VfxHitSystem.GetHitPower(hit) <= 0 || !(bool) (UnityEngine.Object) hit.target)
      return;
    this.TakeHit(hit);
  }

  public void TakeHit(Hit hit)
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

  public void CreateEffect(GameObject prefab, Vector3 position, Vector3 scale)
  {
    if (!(bool) (UnityEngine.Object) prefab)
      return;
    UnityEngine.Object.Instantiate<GameObject>(prefab, position, Quaternion.identity, this.transform).transform.localScale = scale;
  }

  [Serializable]
  public class Profile
  {
    public GameObject effectPrefab;
  }

  [Serializable]
  public class WithStatusProfile
  {
    public string statusType;
    public GameObject effectPrefab;
    public EventReference sfxEvent;
  }
}
