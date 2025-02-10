// Decompiled with JetBrains decompiler
// Type: LayoutFixer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using NaughtyAttributes;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
public class LayoutFixer : MonoBehaviourRect
{
  [SerializeField]
  public bool unlimitedDepth = true;
  [SerializeField]
  [HideIf("unlimitedDepth")]
  public int depth;
  public LayoutFixer.Prompt prompt;

  public void Update()
  {
    if (this.prompt == LayoutFixer.Prompt.None)
      return;
    switch (this.prompt)
    {
      case LayoutFixer.Prompt.All:
        this.DoAll();
        break;
      case LayoutFixer.Prompt.Horizontal:
        this.DoHorizontal();
        break;
      case LayoutFixer.Prompt.Vertical:
        this.DoVertical();
        break;
    }
    this.prompt = LayoutFixer.Prompt.None;
  }

  public void Fix() => this.prompt = LayoutFixer.Prompt.All;

  public void FixHorizontal() => this.prompt = LayoutFixer.Prompt.Horizontal;

  public void FixVertical() => this.prompt = LayoutFixer.Prompt.Vertical;

  public void DoAll()
  {
    if (this.unlimitedDepth)
      this.rectTransform.FixLayoutGroups();
    else
      this.rectTransform.FixLayoutGroups(this.depth);
  }

  public void DoHorizontal()
  {
    this.StopAllCoroutines();
    this.StartCoroutine(this.FixHorizontalRoutine());
  }

  public void DoVertical()
  {
    this.StopAllCoroutines();
    this.StartCoroutine(this.FixVerticalRoutine());
  }

  public IEnumerator FixHorizontalRoutine()
  {
    LayoutFixer layoutFixer = this;
    if (layoutFixer.depth <= 0 && !layoutFixer.unlimitedDepth)
    {
      ContentSizeFitter fitter = layoutFixer.GetComponent<ContentSizeFitter>();
      if ((Object) fitter != (Object) null)
      {
        ContentSizeFitter.FitMode pre = fitter.horizontalFit;
        fitter.horizontalFit = ContentSizeFitter.FitMode.Unconstrained;
        yield return (object) null;
        fitter.horizontalFit = pre;
      }
      fitter = (ContentSizeFitter) null;
    }
    else
    {
      layoutFixer.rectTransform.DisableContentFitters();
      yield return (object) null;
      layoutFixer.rectTransform.EnableContentFitters();
    }
  }

  public IEnumerator FixVerticalRoutine()
  {
    LayoutFixer layoutFixer = this;
    if (layoutFixer.depth <= 0 && !layoutFixer.unlimitedDepth)
    {
      ContentSizeFitter fitter = layoutFixer.GetComponent<ContentSizeFitter>();
      if ((Object) fitter != (Object) null)
      {
        ContentSizeFitter.FitMode pre = fitter.verticalFit;
        fitter.verticalFit = ContentSizeFitter.FitMode.Unconstrained;
        yield return (object) null;
        fitter.verticalFit = pre;
      }
      fitter = (ContentSizeFitter) null;
    }
    else
    {
      layoutFixer.rectTransform.DisableContentFitters();
      yield return (object) null;
      layoutFixer.rectTransform.EnableContentFitters();
    }
  }

  public enum Prompt
  {
    None,
    All,
    Horizontal,
    Vertical,
  }
}
