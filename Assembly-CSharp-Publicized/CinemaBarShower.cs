// Decompiled with JetBrains decompiler
// Type: CinemaBarShower
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using NaughtyAttributes;
using UnityEngine;
using UnityEngine.Localization;

public class CinemaBarShower : MonoBehaviour
{
  [SerializeField]
  public bool showOnEnable;
  [Header("Sorting Order")]
  [SerializeField]
  public bool setSortingOrder;
  [SerializeField]
  [ShowIf("setSortingOrder")]
  public string sortingLayer = "CinemaBars";
  [SerializeField]
  [ShowIf("setSortingOrder")]
  public int orderInLayer;
  [Header("Top Bar")]
  [SerializeField]
  public bool topText;
  [SerializeField]
  [ShowIf("topText")]
  public LocalizedString topScript;
  [SerializeField]
  [ShowIf("topText")]
  public LocalizedString topPrompt;
  [SerializeField]
  [ShowIf("topText")]
  public string topAction;
  [Header("Bottom Bar")]
  [SerializeField]
  public bool bottomText;
  [SerializeField]
  [ShowIf("bottomText")]
  public LocalizedString bottomScript;
  [SerializeField]
  [ShowIf("bottomText")]
  public LocalizedString bottomPrompt;
  [SerializeField]
  [ShowIf("bottomText")]
  public string bottomAction;

  public void OnEnable()
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
