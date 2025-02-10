// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectImmuneToDamage
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Pokefrost
{
  internal class StatusEffectImmuneToDamage : StatusEffectData
  {
    public List<string> immuneTypes;
    public bool reverse = false;
    public bool invis = false;
    public float invisFadeIn = 0.2f;
    public float invisFadeOut = 0.8f;
    protected Hit invisHit;
    public bool ignoreReactions;

    public override void Init()
    {
      this.OnHit += new StatusEffectData.EffectHitEventHandler(this.Check);
      if (!this.invis)
        return;
      this.OnHit += new StatusEffectData.EffectHitEventHandler(this.Invisible);
    }

    private IEnumerator Invisible(Hit hit)
    {
      this.invisHit = hit;
      yield return (object) this.Fade(1f, 0.5f, this.invisFadeIn);
    }

    public override bool RunHitEvent(Hit hit)
    {
      if ((UnityEngine.Object) hit.target == (UnityEngine.Object) this.target && hit.Offensive && hit.canBeNullified && !this.target.silenced)
      {
        Debug.Log((object) hit.damageType);
        if (this.reverse ^ this.immuneTypes.Contains(hit.damageType))
        {
          Debug.Log((object) "here");
          SfxSystem.OneShot("event:/sfx/status_icon/block_decrease");
          hit.damageBlocked = hit.damage;
          hit.damage = 0;
          this.target.PromptUpdate();
        }
      }
      if (!((UnityEngine.Object) hit.attacker == (UnityEngine.Object) this.target) || !this.ignoreReactions)
        return false;
      hit.canRetaliate = false;
      return this.invis;
    }

    public override bool RunPostHitEvent(Hit hit)
    {
      if (this.invis && hit == this.invisHit)
        this.target.StartCoroutine(this.Fade(0.5f, 1f, this.invisFadeOut));
      return false;
    }

    private IEnumerator Check(Hit hit)
    {
      if (!this.target.silenced)
      {
        Debug.Log((object) "here");
        SfxSystem.OneShot("event:/sfx/status_icon/block_decrease");
        hit.damageBlocked = hit.damage;
        hit.damage = 0;
        this.target.PromptUpdate();
        yield break;
      }
    }

    private IEnumerator Fade(float start, float end, float dur)
    {
      LeanTween.value(this.target.gameObject, start, end, dur).setEase(LeanTweenType.easeOutQuad).setOnUpdate(new Action<float>(this.UpdateFade));
      yield return (object) dur;
    }

    private void UpdateFade(float alpha) => (this.target.display as Card).canvasGroup.alpha = alpha;
  }
}
