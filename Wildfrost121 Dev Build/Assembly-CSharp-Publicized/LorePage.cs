// Decompiled with JetBrains decompiler
// Type: LorePage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using Dead;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
public class LorePage : MonoBehaviour
{
  public LorePageManager manager;
  public JournalPageData pageData;
  [SerializeField]
  public GameObject lockedDisplay;
  [SerializeField]
  public GameObject unlockedDisplay;
  [SerializeField]
  public GameObject newDisplay;
  public Button button;
  public Canvas canvas;
  public bool isUnlocked;
  public bool isNew;
  [SerializeField]
  public TweenUI denyTween;
  [SerializeField]
  public TweenUI newTween;

  public void Awake()
  {
    this.button.transform.localEulerAngles = new Vector3(0.0f, 0.0f, PettyRandom.Range(-1f, 1f) * 2f);
  }

  public void SetUnlocked(JournalPageData pageData, bool value)
  {
    this.pageData = pageData;
    this.isUnlocked = value;
    this.button.interactable = value;
    this.lockedDisplay.SetActive(!value);
    this.unlockedDisplay.SetActive(value);
  }

  public void SetNew(bool value)
  {
    this.isNew = value;
    this.newDisplay.SetActive(value);
    if (!value)
      return;
    this.newTween.Fire();
  }

  public void Select()
  {
    if (this.isUnlocked)
    {
      this.manager.Select(this);
    }
    else
    {
      this.denyTween.Fire();
      SfxSystem.OneShot("event:/sfx/ui/deny");
    }
  }
}
