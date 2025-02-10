// Decompiled with JetBrains decompiler
// Type: LayoutFixer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using NaughtyAttributes;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class LayoutFixer : MonoBehaviourRect
{
  [SerializeField]
  private bool unlimitedDepth = true;
  [SerializeField]
  [HideIf("unlimitedDepth")]
  private int depth;
  private LayoutFixer.Prompt prompt;

  private void Update()
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

  private void DoAll()
  {
    if (this.unlimitedDepth)
      this.rectTransform.FixLayoutGroups();
    else
      this.rectTransform.FixLayoutGroups(this.depth);
  }

  private void DoHorizontal()
  {
    this.StopAllCoroutines();
    this.StartCoroutine(this.FixHorizontalRoutine());
  }

  private void DoVertical()
  {
    this.StopAllCoroutines();
    this.StartCoroutine(this.FixVerticalRoutine());
  }

  private IEnumerator FixHorizontalRoutine()
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

  private IEnumerator FixVerticalRoutine()
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

  private enum Prompt
  {
    None,
    All,
    Horizontal,
    Vertical,
  }
}
