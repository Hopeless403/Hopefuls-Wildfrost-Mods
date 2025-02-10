// Decompiled with JetBrains decompiler
// Type: DemoEndSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.UI;

public class DemoEndSequence : MonoBehaviour
{
  [SerializeField]
  private GameObject[] pages;
  [SerializeField]
  private Image[] pageBlips;
  [SerializeField]
  private Sprite blipActive;
  [SerializeField]
  private Sprite blipInactive;
  [SerializeField]
  private OpenURL openURL;
  [SerializeField]
  private TweenUI nextPageTween;
  [SerializeField]
  private TweenUI previousPageTween;
  private int currentPage;
  private bool active = true;

  private void Awake()
  {
    for (int index = 0; index < this.transform.childCount; ++index)
    {
      if (this.transform.GetChild(index).gameObject.activeSelf)
      {
        this.currentPage = index;
        break;
      }
    }
    if (!(bool) (Object) MonoBehaviourSingleton<Deckpack>.instance || !Deckpack.IsOpen)
      return;
    Deckpack.Close();
  }

  public void NextPage()
  {
    if (!this.active)
      return;
    this.ClosePage(this.currentPage);
    ++this.currentPage;
    if (this.currentPage >= this.pages.Length)
      this.currentPage = 0;
    this.OpenPage(this.currentPage);
    this.nextPageTween.Fire();
  }

  public void PreviousPage()
  {
    if (!this.active)
      return;
    this.ClosePage(this.currentPage);
    --this.currentPage;
    if (this.currentPage < 0)
      this.currentPage = this.pages.Length - 1;
    this.OpenPage(this.currentPage);
    this.previousPageTween.Fire();
  }

  public void Wishlist()
  {
    if (!this.active)
      return;
    this.openURL.Open();
  }

  public void Close()
  {
    if (!this.active)
      return;
    this.active = false;
    Routine routine = new Routine(SceneManager.Unload("DemoEnd"));
  }

  private void OpenPage(int number)
  {
    this.pages[number].SetActive(true);
    this.pageBlips[number].sprite = this.blipActive;
  }

  private void ClosePage(int number)
  {
    this.pages[this.currentPage].SetActive(false);
    this.pageBlips[this.currentPage].sprite = this.blipInactive;
  }
}
