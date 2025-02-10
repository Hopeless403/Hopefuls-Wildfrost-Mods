// Decompiled with JetBrains decompiler
// Type: SpriteSetter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
public class SpriteSetter : MonoBehaviour
{
  [SerializeField]
  public Image image;
  [SerializeField]
  public Profile[] sprites;

  public void Set(string @in)
  {
    Profile profile = ((IEnumerable<Profile>) this.sprites).FirstOrDefault<Profile>((Func<Profile, bool>) (a => a.@string == @in));
    if (profile == null)
      return;
    this.image.sprite = profile.sprite;
  }
}
