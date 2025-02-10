// Decompiled with JetBrains decompiler
// Type: JournalPage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

#nullable disable
[ExecuteInEditMode]
public class JournalPage : MonoBehaviour
{
  [SerializeField]
  private Journal journal;
  [SerializeField]
  private Sprite pageSprite;
  [SerializeField]
  private JournalPage alsoOpen;

  public void Open()
  {
    if (this.gameObject.activeSelf)
      return;
    foreach (Component component in this.transform.parent)
      component.gameObject.SetActive(false);
    this.gameObject.SetActive(true);
    this.journal.PagedOpened(this);
    if ((bool) (Object) this.pageSprite)
      this.journal.SetPageImage(this.pageSprite);
    if (!((Object) this.alsoOpen != (Object) null))
      return;
    this.alsoOpen.Open();
  }

  public void Close() => this.gameObject.SetActive(false);
}
