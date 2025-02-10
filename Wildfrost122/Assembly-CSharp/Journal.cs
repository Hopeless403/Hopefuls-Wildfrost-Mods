// Decompiled with JetBrains decompiler
// Type: Journal
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using FMODUnity;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
[ExecuteInEditMode]
public class Journal : MonoBehaviour
{
  [SerializeField]
  private JournalTab openOnEnable;
  [SerializeField]
  private Transform leftPageGroup;
  [SerializeField]
  private Transform rightPageGroup;
  [SerializeField]
  private Image page;
  [SerializeField]
  private EventReference closeSfxRef;

  private void OnEnable()
  {
    if (!Application.isPlaying)
      return;
    if ((bool) (Object) this.openOnEnable)
      this.openOnEnable.Select();
    SfxSystem.OneShot("event:/sfx/ui/journal_open");
  }

  private void OnDisable()
  {
    if (!(bool) (Object) this.openOnEnable)
      return;
    this.openOnEnable.Select();
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
