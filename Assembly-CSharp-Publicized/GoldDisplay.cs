// Decompiled with JetBrains decompiler
// Type: GoldDisplay
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using NaughtyAttributes;
using System.Collections;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GoldDisplay : MonoBehaviour
{
  [SerializeField]
  public Image icon;
  [SerializeField]
  public bool doPing = true;
  [SerializeField]
  public LeanTweenType pingEase = LeanTweenType.easeOutElastic;
  [SerializeField]
  [ShowIf("PingIsAnimationCurve")]
  public AnimationCurve pingCurve;
  [SerializeField]
  public float pingDur = 1f;
  [SerializeField]
  public TMP_Text textAsset;
  [SerializeField]
  [TextArea]
  public string format = "{0}";
  [SerializeField]
  [TextArea]
  public string formatAdd = "{0}<#ffff00>+{1}";
  [SerializeField]
  [TextArea]
  public string formatSub = "{0}<#e05822>-{1}";
  [SerializeField]
  [TextArea]
  public string formatChangeUp = "<s>{0}</s><#ffff00> {2}";
  [SerializeField]
  [TextArea]
  public string formatChangeDown = "<s>{0}</s><#e05822> {2}";
  [SerializeField]
  public float addDelay = 1f;
  [SerializeField]
  public float totalAddTime = 1f;
  [SerializeField]
  public float addBetweenTimeMax = 0.05f;
  public int goldPre;
  public float current;
  [CompilerGenerated]
  public float \u003Cadd\u003Ek__BackingField;
  public float change;

  public bool PingIsAnimationCurve => this.pingEase == LeanTweenType.animationCurve;

  public float add
  {
    get => this.\u003Cadd\u003Ek__BackingField;
    set => this.\u003Cadd\u003Ek__BackingField = value;
  }

  public void Set(int amount)
  {
    if (amount != this.goldPre)
    {
      this.add += (float) (amount - this.goldPre);
      this.UpdateText();
      this.ResolveAfter(this.addDelay);
      if (this.doPing && (double) this.pingDur > 0.0 && this.pingEase != LeanTweenType.notUsed)
        this.Ping();
    }
    this.goldPre = amount;
  }

  public void ShowChange(int change)
  {
    this.change = (float) change;
    this.UpdateText();
  }

  public void HideChange()
  {
    this.change = 0.0f;
    this.UpdateText();
  }

  public void Ping()
  {
    LeanTween.cancel(this.gameObject);
    LTDescr ltDescr = LeanTween.scale(this.gameObject, Vector3.one, this.pingDur).setFrom(Vector3.zero);
    if (this.PingIsAnimationCurve)
      ltDescr.setEase(this.pingCurve);
    else
      ltDescr.setEase(this.pingEase);
  }

  public void UpdateText()
  {
    if ((double) this.change == 0.0)
    {
      if ((double) this.add == 0.0)
        this.textAsset.text = string.Format(this.format, (object) this.current);
      else if ((double) this.add > 0.0)
      {
        this.textAsset.text = string.Format(this.formatAdd, (object) this.current, (object) this.add);
      }
      else
      {
        if ((double) this.add >= 0.0)
          return;
        this.textAsset.text = string.Format(this.formatSub, (object) this.current, (object) (float) -(double) this.add);
      }
    }
    else if ((double) this.change > 0.0)
    {
      this.textAsset.text = string.Format(this.formatChangeUp, (object) this.current, (object) this.change, (object) (float) ((double) this.current + (double) this.change));
    }
    else
    {
      if ((double) this.change >= 0.0)
        return;
      this.textAsset.text = string.Format(this.formatChangeDown, (object) this.current, (object) this.change, (object) (float) ((double) this.current + (double) this.change));
    }
  }

  public void ResolveAfter(float delay)
  {
    this.StopAllCoroutines();
    this.StartCoroutine(this.ResolveAdd(delay));
  }

  public IEnumerator ResolveAdd(float delay)
  {
    GoldDisplay goldDisplay = this;
    yield return (object) Sequences.Wait(delay);
    float timeBetween = Mathf.Min(goldDisplay.totalAddTime / Mathf.Abs(goldDisplay.add), goldDisplay.addBetweenTimeMax);
    Events.InvokeGoldCounterStart(goldDisplay, goldDisplay.add);
    while ((double) goldDisplay.add != 0.0)
    {
      if ((double) goldDisplay.add > 0.0)
      {
        goldDisplay.add--;
        ++goldDisplay.current;
      }
      else
      {
        goldDisplay.add++;
        --goldDisplay.current;
      }
      goldDisplay.UpdateText();
      yield return (object) Sequences.Wait(timeBetween);
    }
  }
}
