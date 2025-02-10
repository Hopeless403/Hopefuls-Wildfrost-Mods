// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectXActsLikeShell
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System.Collections;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Pokefrost
{
  internal class StatusEffectXActsLikeShell : StatusEffectData
  {
    public string targetType = "";
    public Sprite sprite;
    public bool active = true;

    public override void Init()
    {
      this.PostApplyStatus += new StatusEffectData.EffectApplyEventHandler(this.ChangeIcon);
      this.OnHit += new StatusEffectData.EffectHitEventHandler(this.BlockDamage);
      this.OnEffectBonusChanged += new StatusEffectData.EffectEventHandler(this.SilenceCheck);
    }

    private IEnumerator SilenceCheck()
    {
      StatusIcon snowIcon = this.target?.GetComponent<Card>()?.FindStatusIcon("snow");
      if (!((Object) snowIcon == (Object) null))
      {
        if (this.GetAmount() > 0)
        {
          snowIcon.GetComponent<Image>().sprite = this.sprite;
          snowIcon.transform.SetParent(snowIcon.transform.parent.parent.Find("HealthLayout"));
        }
        else
        {
          snowIcon.GetComponent<Image>().sprite = CardManager.cardIcons["snow"].GetComponent<Image>().sprite;
          snowIcon.transform.SetParent(snowIcon.transform.parent.parent.Find("CounterLayout"));
          yield break;
        }
      }
    }

    public override bool RunPostApplyStatusEvent(StatusEffectApply apply)
    {
      return (Object) this.target != (Object) null && (Object) apply?.target == (Object) this.target && this.GetAmount() > 0 && apply.effectData.type == this.targetType;
    }

    public IEnumerator ChangeIcon(StatusEffectApply apply)
    {
      StatusIcon snowIcon = apply.target.GetComponent<Card>().FindStatusIcon("snow");
      if ((Object) snowIcon != (Object) null && (Object) this.sprite != (Object) null)
      {
        snowIcon.GetComponent<Image>().sprite = this.sprite;
        snowIcon.transform.SetParent(snowIcon.transform.parent.parent.Find("HealthLayout"));
      }
      else
      {
        snowIcon = apply.target.GetComponent<Card>().SetStatusIcon("snow", "health", new Stat(apply.count, 0));
        snowIcon.GetComponent<Image>().sprite = this.sprite;
      }
      yield return (object) Sequences.Wait(apply.target.curveAnimator.Ping());
    }

    public override bool RunHitEvent(Hit hit)
    {
      return (Object) hit?.target == (Object) this.target && (bool) (Object) hit.target.FindStatus(this.targetType) && this.GetAmount() > 0 && hit.damage > 0;
    }

    public IEnumerator BlockDamage(Hit hit)
    {
      StatusEffectData targetEffect = hit.target.FindStatus(this.targetType);
      while (targetEffect.count > 0 && hit.damage > 0)
      {
        --targetEffect.count;
        --hit.damage;
        ++hit.damageBlocked;
      }
      if (targetEffect.count <= 0)
        yield return (object) targetEffect.Remove();
      this.target.PromptUpdate();
    }
  }
}
