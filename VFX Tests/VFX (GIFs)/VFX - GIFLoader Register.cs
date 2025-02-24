using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace WildfrostHopeMod.VFX;
public partial class GIFLoader
{
    public void RegisterAllAsApplyEffect() =>
        prefabs.Values.RegisterAsApplyEffectMany();
    public void RegisterAllAsDamageEffect() =>
        prefabs.Select(p => p.Value.RegisterAsDamageEffect(p.Key));
}

public static class GIFLoaderExt
{
    static VfxStatusSystem vfxSystem;
    /// <summary>
    /// Register this prefab in the global VfxStatusSystem to play on applying a status with defined .type
    /// </summary>
    /// <param name="applyEffectPrefab"></param>
    /// <param name="type">type of the StatusEffectApply this should play for</param>
    /// <returns></returns>
    public static VfxStatusSystem.Profile RegisterAsApplyEffect(this GameObject applyEffectPrefab, string type)
    {
        VfxStatusSystem.Profile profile;

        vfxSystem ??= GameObject.FindObjectOfType<VfxStatusSystem>();
        profile = vfxSystem.profiles.FirstOrDefault(p => p.type == type);

        if (profile != default)
            profile.applyEffectPrefab = applyEffectPrefab;
        else
        {
            profile = new VfxStatusSystem.Profile()
            {
                type = type,
                applyEffectPrefab = applyEffectPrefab
            };
            vfxSystem.profiles = vfxSystem.profiles.With(profile);
            vfxSystem.profileLookup[type] = profile;
            //Debug.LogWarning($"Registered [{type}] to VfxStatusSystem.profiles");
        }
        return profile;
    }
    public static List<VfxStatusSystem.Profile> RegisterAsApplyEffectMany(this IEnumerable<GameObject> applyEffectPrefabs) =>
        applyEffectPrefabs.Select(p => RegisterAsApplyEffect(p, p.name)).ToList();


    static VfxHitSystem hitSystem;
    /// <summary>
    /// Register this prefab in the global VfxHitSystem to play on hitting an entity affected by this status type (eg Bom)
    /// </summary>
    /// <param name="hitEffectPrefab"></param>
    /// <param name="type">type of the StatusEffectApply this should play for</param>
    /// <returns></returns>
    public static VfxHitSystem.WithStatusProfile RegisterAsHitEffect(this GameObject hitEffectPrefab, string type)
    {
        VfxHitSystem.WithStatusProfile profile;

        hitSystem ??= GameObject.FindObjectOfType<VfxHitSystem>();
        profile = hitSystem.withStatusProfiles.FirstOrDefault(p => p.statusType == type);

        if (profile != default)
            profile.effectPrefab = hitEffectPrefab;
        else
        {
            profile = new VfxHitSystem.WithStatusProfile()
            {
                statusType = type,
                effectPrefab = hitEffectPrefab
            };
            hitSystem.withStatusProfiles = hitSystem.withStatusProfiles.With(profile);
            //Debug.LogWarning($"Registered [{type}] to VfxStatusSystem.profiles");
        }
        return profile;
    }
    public static List<VfxHitSystem.WithStatusProfile> RegisterAsHitEffectMany(this IEnumerable<GameObject> hitEffectPrefabs) =>
        hitEffectPrefabs.Select(p => RegisterAsHitEffect(p, p.name)).ToList();


    /// <summary>
    /// Register this prefab in the global VfxStatusSystem to play on taking damage from a status with defined .type
    /// </summary>
    /// <param name="damageEffectPrefab"></param>
    /// <param name="damageType">type of the damaging Status this should play for</param>
    /// <returns></returns>
    public static VfxStatusSystem.DamageProfile RegisterAsDamageEffect(this GameObject damageEffectPrefab, string damageType)
    {
        var profile = new VfxStatusSystem.DamageProfile()
        {
            damageType = damageType,
            damageEffectPrefab = damageEffectPrefab
        };
        vfxSystem ??= GameObject.FindObjectOfType<VfxStatusSystem>();
        vfxSystem.damageProfiles = vfxSystem.damageProfiles.With(profile);
        vfxSystem.damageProfileLookup[damageType] = profile;
        //Debug.LogWarning($"Registered [{damageType}] to VfxStatusSystem.damageProfiles");
        return profile;
    }
    public static List<VfxStatusSystem.DamageProfile> RegisterAsDamageEffectMany(this IEnumerable<GameObject> damageEffectPrefabs) =>
        damageEffectPrefabs.Select(p => RegisterAsDamageEffect(p, p.name)).ToList();

}
