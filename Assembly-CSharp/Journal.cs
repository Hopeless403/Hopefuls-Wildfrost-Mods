// Decompiled with JetBrains decompiler
// Type: Journal
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using FMODUnity;
using UnityEngine;
using UnityEngine.UI;

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
