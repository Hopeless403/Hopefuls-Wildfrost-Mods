// Decompiled with JetBrains decompiler
// Type: VfxStatusSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
public class VfxStatusSystem : GameSystem
{
  [SerializeField]
  public VfxStatusSystem.Profile[] profiles;
  [SerializeField]
  public VfxStatusSystem.DamageProfile[] damageProfiles;
  public Dictionary<string, VfxStatusSystem.Profile> profileLookup;
  public Dictionary<string, VfxStatusSystem.DamageProfile> damageProfileLookup;

  public void OnEnable()
  {
    global::Events.OnStatusEffectApplied += new UnityAction<StatusEffectApply>(this.StatusApplied);
    global::Events.OnEntityHit += new UnityAction<Hit>(this.EntityHit);
    this.profileLookup = new Dictionary<string, VfxStatusSystem.Profile>();
    foreach (VfxStatusSystem.Profile profile in this.profiles)
      this.profileLookup[profile.type] = profile;
    this.damageProfileLookup = new Dictionary<string, VfxStatusSystem.DamageProfile>();
    foreach (VfxStatusSystem.DamageProfile damageProfile in this.damageProfiles)
      this.damageProfileLookup[damageProfile.damageType] = damageProfile;
  }

  public void OnDisable()
  {
    global::Events.OnStatusEffectApplied -= new UnityAction<StatusEffectApply>(this.StatusApplied);
    global::Events.OnEntityHit -= new UnityAction<Hit>(this.EntityHit);
  }

  public void StatusApplied(StatusEffectApply apply)
  {
    if (!(bool) (UnityEngine.Object) apply?.effectData || !apply.target.display.init || !apply.target.startingEffectsApplied || Transition.Running || !this.profileLookup.ContainsKey(apply.effectData.type))
      return;
    VfxStatusSystem.Profile profile = this.profileLookup[apply.effectData.type];
    if (profile == null || !(bool) (UnityEngine.Object) profile.applyEffectPrefab)
      return;
    Transform transform = apply.target.transform;
    this.CreateEffect(profile.applyEffectPrefab, transform.position, transform.lossyScale);
  }

  public void EntityHit(Hit hit)
  {
    if (hit.BasicHit || !this.damageProfileLookup.ContainsKey(hit.damageType))
      return;
    VfxStatusSystem.DamageProfile damageProfile = this.damageProfileLookup[hit.damageType];
    if (damageProfile == null || !((UnityEngine.Object) damageProfile.damageEffectPrefab != (UnityEngine.Object) null))
      return;
    this.CreateEffect(damageProfile.damageEffectPrefab, hit.target.transform.position, hit.target.transform.lossyScale);
  }

  public void CreateEffect(GameObject prefab, Vector3 position, Vector3 scale)
  {
    UnityEngine.Object.Instantiate<GameObject>(prefab, position, Quaternion.identity, this.transform).transform.localScale = scale;
  }

  [Serializable]
  public class Profile
  {
    public string type;
    public GameObject applyEffectPrefab;
  }

  [Serializable]
  public class DamageProfile
  {
    public string damageType;
    public GameObject damageEffectPrefab;
  }
}
