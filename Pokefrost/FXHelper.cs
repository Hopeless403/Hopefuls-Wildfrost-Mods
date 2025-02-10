// Decompiled with JetBrains decompiler
// Type: Pokefrost.FXHelper
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using Deadpan.Enums.Engine.Components.Modding;
using UnityEngine;
using WildfrostHopeMod.SFX;
using WildfrostHopeMod.VFX;

#nullable disable
namespace Pokefrost
{
  public class FXHelper
  {
    public GIFLoader giffy;
    public SFXLoader silly;
    public WildfrostMod mod;

    public FXHelper(WildfrostMod mod, string animLocation, string soundLocation)
    {
      this.giffy = new GIFLoader((WildfrostMod) null, mod.ImagePath(animLocation));
      this.giffy.RegisterAllAsApplyEffect();
      this.silly = new SFXLoader(mod.ImagePath(soundLocation));
      this.silly.LoadSoundsFromDir(this.silly.Directory);
    }

    public void TryPlaySound(string key, SFXLoader.PlayAs playAs = SFXLoader.PlayAs.SFX)
    {
      this.silly.TryPlaySound(key, playAs);
    }

    public GameObject TryPlayEffect(
      string key,
      Vector3 position = default (Vector3),
      Vector3 scale = default (Vector3),
      GIFLoader.PlayType playAs = GIFLoader.PlayType.applyEffect)
    {
      return this.giffy.TryPlayEffect(key, position, scale, playAs);
    }
  }
}
