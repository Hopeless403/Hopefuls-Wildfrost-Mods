// Decompiled with JetBrains decompiler
// Type: SpriteSetter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

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
