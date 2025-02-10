// Decompiled with JetBrains decompiler
// Type: JournalPage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

#nullable disable
[ExecuteInEditMode]
public class JournalPage : MonoBehaviour
{
  [SerializeField]
  public Journal journal;
  [SerializeField]
  public Sprite pageSprite;
  [SerializeField]
  public JournalPage alsoOpen;

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
