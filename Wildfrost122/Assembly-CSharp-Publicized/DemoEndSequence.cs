// Decompiled with JetBrains decompiler
// Type: DemoEndSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;
using UnityEngine.UI;

#nullable disable
public class DemoEndSequence : MonoBehaviour
{
  [SerializeField]
  public GameObject[] pages;
  [SerializeField]
  public Image[] pageBlips;
  [SerializeField]
  public Sprite blipActive;
  [SerializeField]
  public Sprite blipInactive;
  [SerializeField]
  public OpenURL openURL;
  [SerializeField]
  public TweenUI nextPageTween;
  [SerializeField]
  public TweenUI previousPageTween;
  public int currentPage;
  public bool active = true;

  public void Awake()
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

  public void OpenPage(int number)
  {
    this.pages[number].SetActive(true);
    this.pageBlips[number].sprite = this.blipActive;
  }

  public void ClosePage(int number)
  {
    this.pages[this.currentPage].SetActive(false);
    this.pageBlips[this.currentPage].sprite = this.blipInactive;
  }
}
