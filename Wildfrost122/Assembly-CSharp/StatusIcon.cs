// Decompiled with JetBrains decompiler
// Type: StatusIcon
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using NaughtyAttributes;
using System;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

#nullable disable
public class StatusIcon : MonoBehaviourRect
{
  public string type;
  public TMP_Text textElement;
  public bool persistent;
  [SerializeField]
  protected bool alterTextColours = true;
  [ShowIf("alterTextColours")]
  public Color textColour = Color.black;
  [ShowIf("alterTextColours")]
  public Color textColourAboveMax = Color.white;
  [ShowIf("alterTextColours")]
  public Color textColourBelowMax = Color.white;
  [ShowIf("alterTextColours")]
  public Material textMaterialAboveMax;
  public Image fill;
  private Stat value;
  [SerializeField]
  private string textFormat = "{0}";
  [SerializeField]
  private int textAdd;
  private Material normalMaterial;
  private bool currentMaterialIsNormal = true;
  public UnityEvent onCreate;
  public UnityEventStatStat onValueDown;
  public UnityEventStatStat onValueUp;
  public UnityEvent afterUpdate;
  public UnityEvent onDestroy;

  public Entity target { get; private set; }

  public virtual Stat GetValue() => this.value;

  public void SetValue(Stat value, bool doPing = true)
  {
    if (doPing)
      this.UpdateEvent(this.value, value);
    this.value = value;
    this.afterUpdate.Invoke();
    if (!(bool) (UnityEngine.Object) this.fill)
      return;
    this.fill.type = Image.Type.Filled;
    this.fill.fillAmount = Mathf.Clamp((float) value.current / (float) value.max, 0.0f, 1f);
  }

  public virtual void Assign(Entity entity) => this.target = entity;

  public void CreateEvent() => this.onCreate.Invoke();

  public void UpdateEvent(Stat previousValue, Stat newValue)
  {
    if (newValue.current < previousValue.current)
      this.onValueDown.Invoke(previousValue, newValue);
    else if (newValue.current > previousValue.current)
      this.onValueUp.Invoke(previousValue, newValue);
    global::Events.InvokeStatusIconChanged(this, previousValue, newValue);
  }

  public void DestroyEvent() => this.onDestroy.Invoke();

  public void SetText()
  {
    if (!(bool) (UnityEngine.Object) this.textElement)
      return;
    Stat stat = this.GetValue();
    this.textElement.text = string.Format(this.textFormat, (object) (stat.current + this.textAdd));
    if (!this.alterTextColours)
      return;
    this.textElement.color = stat.current > stat.max ? this.textColourAboveMax : (stat.current < stat.max ? this.textColourBelowMax : this.textColour);
    if (stat.current > stat.max)
    {
      if (!this.currentMaterialIsNormal || !(bool) (UnityEngine.Object) this.textMaterialAboveMax)
        return;
      this.normalMaterial = this.textElement.fontSharedMaterial;
      this.currentMaterialIsNormal = false;
      this.textElement.fontSharedMaterial = this.textMaterialAboveMax;
    }
    else
    {
      if (this.currentMaterialIsNormal || !(bool) (UnityEngine.Object) this.normalMaterial)
        return;
      this.currentMaterialIsNormal = true;
      this.textElement.fontSharedMaterial = this.normalMaterial;
    }
  }

  public void Ping()
  {
    if (!(bool) (UnityEngine.Object) this.rectTransform)
      return;
    this.rectTransform.LeanCancel();
    this.rectTransform.LeanScale(Vector3.one, 1f).setEaseOutElastic().setFrom(new Vector3(0.0f, 0.0f, 1f));
  }

  public virtual void CheckRemove()
  {
    if (this.persistent || (bool) (UnityEngine.Object) this.target.statusEffects.Find((Predicate<StatusEffectData>) (a => a.type == this.type)))
      return;
    this.SetValue(new Stat());
  }

  public void CheckDestroy(Stat previousValue, Stat newValue)
  {
    if (newValue.current > 0 || newValue.max > 0 || this.persistent)
      return;
    this.Destroy();
  }

  public void Destroy()
  {
    this.DestroyEvent();
    this.gameObject.Destroy();
  }
}
