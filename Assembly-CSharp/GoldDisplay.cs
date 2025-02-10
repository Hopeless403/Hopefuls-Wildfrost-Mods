// Decompiled with JetBrains decompiler
// Type: GoldDisplay
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using NaughtyAttributes;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GoldDisplay : MonoBehaviour
{
  [SerializeField]
  private Image icon;
  [SerializeField]
  private bool doPing = true;
  [SerializeField]
  private LeanTweenType pingEase = LeanTweenType.easeOutElastic;
  [SerializeField]
  [ShowIf("PingIsAnimationCurve")]
  private AnimationCurve pingCurve;
  [SerializeField]
  private float pingDur = 1f;
  [SerializeField]
  private TMP_Text textAsset;
  [SerializeField]
  [TextArea]
  private string format = "{0}";
  [SerializeField]
  [TextArea]
  private string formatAdd = "{0}<#ffff00>+{1}";
  [SerializeField]
  [TextArea]
  private string formatSub = "{0}<#e05822>-{1}";
  [SerializeField]
  [TextArea]
  private string formatChangeUp = "<s>{0}</s><#ffff00> {2}";
  [SerializeField]
  [TextArea]
  private string formatChangeDown = "<s>{0}</s><#e05822> {2}";
  [SerializeField]
  private float addDelay = 1f;
  [SerializeField]
  private float totalAddTime = 1f;
  [SerializeField]
  private float addBetweenTimeMax = 0.05f;
  private int goldPre;
  private float current;
  private float change;

  private bool PingIsAnimationCurve => this.pingEase == LeanTweenType.animationCurve;

  public float add { get; private set; }

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

  private void Ping()
  {
    LeanTween.cancel(this.gameObject);
    LTDescr ltDescr = LeanTween.scale(this.gameObject, Vector3.one, this.pingDur).setFrom(Vector3.zero);
    if (this.PingIsAnimationCurve)
      ltDescr.setEase(this.pingCurve);
    else
      ltDescr.setEase(this.pingEase);
  }

  private void UpdateText()
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

  private IEnumerator ResolveAdd(float delay)
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
