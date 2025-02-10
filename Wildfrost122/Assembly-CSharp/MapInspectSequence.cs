// Decompiled with JetBrains decompiler
// Type: MapInspectSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Components;
using UnityEngine.UI;

#nullable disable
public class MapInspectSequence : MonoBehaviour
{
  [SerializeField]
  private LocalizeStringEvent title;
  [SerializeField]
  private LocalizeStringEvent desc;
  [SerializeField]
  private Image image;
  [SerializeField]
  private MapInspectSequence.Profile[] profiles;

  public void Inspect(int index) => this.Inspect(this.profiles[index]);

  private void Inspect(MapInspectSequence.Profile profile)
  {
    this.Inspect(profile.titleKey, profile.descKey, profile.icon);
  }

  private void Inspect(LocalizedString titleKey, LocalizedString descKey, Sprite icon)
  {
    this.title.StringReference = titleKey;
    this.desc.StringReference = descKey;
    this.image.sprite = icon;
    this.gameObject.SetActive(true);
  }

  [Serializable]
  public struct Profile
  {
    public LocalizedString titleKey;
    public LocalizedString descKey;
    public Sprite icon;
  }
}
