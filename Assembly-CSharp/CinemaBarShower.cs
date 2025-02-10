// Decompiled with JetBrains decompiler
// Type: CinemaBarShower
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using NaughtyAttributes;
using UnityEngine;
using UnityEngine.Localization;

public class CinemaBarShower : MonoBehaviour
{
  [SerializeField]
  private bool showOnEnable;
  [Header("Sorting Order")]
  [SerializeField]
  private bool setSortingOrder;
  [SerializeField]
  [ShowIf("setSortingOrder")]
  private string sortingLayer = "CinemaBars";
  [SerializeField]
  [ShowIf("setSortingOrder")]
  private int orderInLayer;
  [Header("Top Bar")]
  [SerializeField]
  private bool topText;
  [SerializeField]
  [ShowIf("topText")]
  private LocalizedString topScript;
  [SerializeField]
  [ShowIf("topText")]
  private LocalizedString topPrompt;
  [SerializeField]
  [ShowIf("topText")]
  private string topAction;
  [Header("Bottom Bar")]
  [SerializeField]
  private bool bottomText;
  [SerializeField]
  [ShowIf("bottomText")]
  private LocalizedString bottomScript;
  [SerializeField]
  [ShowIf("bottomText")]
  private LocalizedString bottomPrompt;
  [SerializeField]
  [ShowIf("bottomText")]
  private string bottomAction;

  private void OnEnable()
  {
    if (!this.showOnEnable)
      return;
    this.Show();
  }

  public void Show()
  {
    CinemaBarSystem.In();
    CinemaBarSystem.SetSortingLayer(this.sortingLayer, this.orderInLayer);
    if (this.topText)
    {
      if (!this.topScript.IsEmpty)
        CinemaBarSystem.Top.SetScript(this.topScript.GetLocalizedString());
      else if (!this.topPrompt.IsEmpty)
        CinemaBarSystem.Top.SetPrompt(this.topPrompt.GetLocalizedString(), this.topAction);
    }
    if (!this.bottomText)
      return;
    if (!this.bottomScript.IsEmpty)
    {
      CinemaBarSystem.Bottom.SetScript(this.bottomScript.GetLocalizedString());
    }
    else
    {
      if (this.bottomPrompt.IsEmpty)
        return;
      CinemaBarSystem.Bottom.SetPrompt(this.bottomPrompt.GetLocalizedString(), this.bottomAction);
    }
  }

  public void Hide()
  {
    CinemaBarSystem.Clear();
    CinemaBarSystem.Out();
  }
}
