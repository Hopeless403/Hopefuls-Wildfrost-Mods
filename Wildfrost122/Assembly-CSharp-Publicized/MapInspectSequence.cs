// Decompiled with JetBrains decompiler
// Type: MapInspectSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Components;
using UnityEngine.UI;

#nullable disable
public class MapInspectSequence : MonoBehaviour
{
  [SerializeField]
  public LocalizeStringEvent title;
  [SerializeField]
  public LocalizeStringEvent desc;
  [SerializeField]
  public Image image;
  [SerializeField]
  public MapInspectSequence.Profile[] profiles;

  public void Inspect(int index) => this.Inspect(this.profiles[index]);

  public void Inspect(MapInspectSequence.Profile profile)
  {
    this.Inspect(profile.titleKey, profile.descKey, profile.icon);
  }

  public void Inspect(LocalizedString titleKey, LocalizedString descKey, Sprite icon)
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
