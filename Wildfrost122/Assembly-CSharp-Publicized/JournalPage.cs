// Decompiled with JetBrains decompiler
// Type: JournalPage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
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
