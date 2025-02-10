// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectShiny
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using UnityEngine;

#nullable disable
namespace Pokefrost
{
  public class StatusEffectShiny : StatusEffectData
  {
    public override bool HasBeginRoutine => true;

    public override bool RunBeginEvent()
    {
      if ((Object) this.target != (Object) null && this.target.data.name.Contains("websiteofsites.wildfrost.pokefrost"))
      {
        Sprite sprite = Pokefrost.Pokefrost.instance.ApplyShinySprite(this.target.data);
        this.target.data.mainSprite = sprite;
        this.target.GetComponent<Card>().mainImage.sprite = sprite;
      }
      return false;
    }
  }
}
