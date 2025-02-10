// Decompiled with JetBrains decompiler
// Type: Journal
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using FMODUnity;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
[ExecuteInEditMode]
public class Journal : MonoBehaviour
{
  [SerializeField]
  public JournalTab openOnEnable;
  [SerializeField]
  public Transform leftPageGroup;
  [SerializeField]
  public Transform rightPageGroup;
  [SerializeField]
  public Image page;
  [SerializeField]
  public EventReference closeSfxRef;

  public void OnEnable()
  {
    if (!Application.isPlaying)
      return;
    if ((bool) (Object) this.openOnEnable)
      this.openOnEnable.Select();
    SfxSystem.OneShot("event:/sfx/ui/journal_open");
  }

  public void PagedOpened(JournalPage page)
  {
    if (!((Object) page.transform.parent == (Object) this.leftPageGroup))
      return;
    foreach (Component component1 in this.rightPageGroup)
    {
      JournalPage component2 = component1.GetComponent<JournalPage>();
      if (component2 != null && component2.gameObject.activeSelf)
        component2.Close();
    }
  }

  public void SetPageImage(Sprite sprite) => this.page.sprite = sprite;

  public void Close() => SfxSystem.OneShot(this.closeSfxRef);
}
