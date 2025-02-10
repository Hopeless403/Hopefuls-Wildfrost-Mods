// Decompiled with JetBrains decompiler
// Type: SpriteSetter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
public class SpriteSetter : MonoBehaviour
{
  [SerializeField]
  private Image image;
  [SerializeField]
  private Profile[] sprites;

  public void Set(string @in)
  {
    Profile profile = ((IEnumerable<Profile>) this.sprites).FirstOrDefault<Profile>((Func<Profile, bool>) (a => a.@string == @in));
    if (profile == null)
      return;
    this.image.sprite = profile.sprite;
  }
}
