// Decompiled with JetBrains decompiler
// Type: EntityDisplay
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using NaughtyAttributes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public abstract class EntityDisplay : MonoBehaviourCacheTransform, IPoolable
{
  public Entity entity;
  public CardHover hover;
  [BoxGroup("Icon Groups")]
  public RectTransform healthLayoutGroup;
  [BoxGroup("Icon Groups")]
  public RectTransform damageLayoutGroup;
  [BoxGroup("Icon Groups")]
  public RectTransform counterLayoutGroup;
  [BoxGroup("Icon Groups")]
  public RectTransform crownLayoutGroup;
  protected Dictionary<string, RectTransform> iconGroups;
  protected StatusIcon healthIcon;
  protected StatusIcon damageIcon;
  public StatusIcon counterIcon;
  public StatusIcon reactionIcon;
  [ReadOnly]
  public bool init;
  public bool promptUpdateDescription;

  protected virtual void Awake()
  {
    this.iconGroups = new Dictionary<string, RectTransform>();
    if ((UnityEngine.Object) this.healthLayoutGroup != (UnityEngine.Object) null)
      this.iconGroups["health"] = this.healthLayoutGroup;
    if ((UnityEngine.Object) this.damageLayoutGroup != (UnityEngine.Object) null)
      this.iconGroups["damage"] = this.damageLayoutGroup;
    if ((UnityEngine.Object) this.counterLayoutGroup != (UnityEngine.Object) null)
      this.iconGroups["counter"] = this.counterLayoutGroup;
    if (!((UnityEngine.Object) this.crownLayoutGroup != (UnityEngine.Object) null))
      return;
    this.iconGroups["crown"] = this.crownLayoutGroup;
  }

  public virtual void Reset() => this.init = false;

  public virtual IEnumerator UpdateData(bool doPing = false)
  {
    yield return (object) this.UpdateDisplay(doPing);
    this.init = true;
    Events.InvokeEntityDataUpdated(this.entity);
  }

  public virtual IEnumerator UpdateDisplay(bool doPing = true)
  {
    if ((bool) (UnityEngine.Object) this.healthLayoutGroup)
    {
      if (!(bool) (UnityEngine.Object) this.healthIcon)
      {
        if (this.entity.hp.max > 0 || this.entity.hp.current > 0 || (bool) (UnityEngine.Object) this.entity.data && this.entity.data.hasHealth)
          this.healthIcon = this.SetStatusIcon("health", "health", this.entity.hp, doPing);
      }
      else
        EntityDisplay.UpdateStatusIcon(this.healthIcon, this.entity.hp, doPing);
    }
    if ((bool) (UnityEngine.Object) this.damageLayoutGroup)
    {
      if (!(bool) (UnityEngine.Object) this.damageIcon)
      {
        if (this.entity.damage.max > 0 || this.entity.damage.current + this.entity.tempDamage > 0 || (bool) (UnityEngine.Object) this.entity.data && this.entity.data.hasAttack)
          this.damageIcon = this.SetStatusIcon("damage", "damage", this.entity.damage + this.entity.tempDamage, doPing);
      }
      else
        EntityDisplay.UpdateStatusIcon(this.damageIcon, this.entity.damage + this.entity.tempDamage, doPing);
    }
    if ((bool) (UnityEngine.Object) this.counterLayoutGroup)
    {
      if (!(bool) (UnityEngine.Object) this.counterIcon)
      {
        if (this.entity.counter.max > 0)
          this.counterIcon = this.SetStatusIcon("counter", "counter", this.entity.counter, doPing);
      }
      else
        EntityDisplay.UpdateStatusIcon(this.counterIcon, this.entity.counter, doPing);
      if (!(bool) (UnityEngine.Object) this.reactionIcon)
      {
        if (this.entity.statusEffects.Any<StatusEffectData>((Func<StatusEffectData, bool>) (a => a.isReaction)))
          this.reactionIcon = this.SetStatusIcon("reaction", "counter", Stat.Default, doPing);
      }
      else
        EntityDisplay.UpdateStatusIcon(this.reactionIcon, Stat.Default, doPing);
    }
    foreach (StatusEffectData statusEffect in this.entity.statusEffects)
    {
      if (statusEffect.visible && !statusEffect.iconGroupName.IsNullOrEmpty())
        this.SetStatusIcon(statusEffect.type, statusEffect.iconGroupName, new Stat(statusEffect.count, 0), doPing);
    }
    foreach (KeyValuePair<string, RectTransform> iconGroup in this.iconGroups)
    {
      foreach (Component component1 in (Transform) iconGroup.Value)
      {
        StatusIcon component2 = component1.GetComponent<StatusIcon>();
        if ((bool) (UnityEngine.Object) component2)
          component2.CheckRemove();
      }
    }
    Events.InvokeEntityDisplayUpdated(this.entity);
    yield return (object) null;
  }

  public virtual Canvas GetCanvas() => (Canvas) null;

  protected StatusIcon FindStatusIcon(string type)
  {
    StatusIcon statusIcon = (StatusIcon) null;
    foreach (KeyValuePair<string, RectTransform> iconGroup in this.iconGroups)
    {
      foreach (Component component1 in (Transform) iconGroup.Value)
      {
        StatusIcon component2 = component1.GetComponent<StatusIcon>();
        if ((bool) (UnityEngine.Object) component2 && component2.type == type)
        {
          statusIcon = component2;
          break;
        }
      }
      if ((bool) (UnityEngine.Object) statusIcon)
        break;
    }
    return statusIcon;
  }

  protected StatusIcon SetStatusIcon(string type, string iconGroupName, Stat value, bool doPing = true)
  {
    StatusIcon icon = this.FindStatusIcon(type);
    if ((bool) (UnityEngine.Object) icon)
    {
      EntityDisplay.UpdateStatusIcon(icon, value, doPing);
    }
    else
    {
      icon = CardManager.NewStatusIcon(type, (Transform) this.iconGroups[iconGroupName]);
      if (!(bool) (UnityEngine.Object) icon)
      {
        Debug.LogError((object) ("Status Icon for [" + type + "] NOT FOUND!"));
      }
      else
      {
        if ((bool) (UnityEngine.Object) this.hover)
        {
          CardHover component = icon.GetComponent<CardHover>();
          component.master = this.hover;
          component.enabled = true;
        }
        icon.Assign(this.entity);
        icon.SetValue(value, doPing);
        if (doPing)
        {
          icon.CreateEvent();
          Events.InvokeStatusIconCreated(icon);
        }
      }
    }
    return icon;
  }

  private static void UpdateStatusIcon(StatusIcon icon, Stat value, bool doPing = true) => icon.SetValue(value, doPing);

  protected void RemoveStatusIcon(string type, string iconGroupName)
  {
    StatusIcon statusIcon = this.FindStatusIcon(type);
    if (!((UnityEngine.Object) statusIcon != (UnityEngine.Object) null))
      return;
    statusIcon.Destroy();
  }

  public void ClearStatusIcons()
  {
    foreach (KeyValuePair<string, RectTransform> iconGroup in this.iconGroups)
      iconGroup.Value.DestroyAllChildren();
  }

  public virtual void OnGetFromPool()
  {
    this.init = false;
    this.promptUpdateDescription = false;
  }

  public virtual void OnReturnToPool() => this.ClearStatusIcons();
}
