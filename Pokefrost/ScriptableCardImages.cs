// Decompiled with JetBrains decompiler
// Type: Pokefrost.PalafinHero
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Pokefrost
{
  internal class PalafinHero : ScriptableCardImage
  {
    public Image image;
    private bool shiny = false;
    private List<Sprite> sprites = new List<Sprite>()
    {
      AddressableExtMethods.ASprite("palafin"),
      AddressableExtMethods.ASprite("shiny_palafin"),
      AddressableExtMethods.ASprite("palafinhero"),
      AddressableExtMethods.ASprite("shiny_palafinhero")
    };

    public override void AssignEvent()
    {
      this.image.sprite = this.sprites[0];
      foreach (CardData.StatusEffectStacks startWithEffect in this.entity.data.startWithEffects)
      {
        if (startWithEffect.data.type == "shiny")
        {
          this.shiny = true;
          this.image.sprite = this.sprites[1];
          break;
        }
      }
      base.AssignEvent();
    }

    public override void UpdateEvent()
    {
      if (this.entity.traits.FirstOrDefault<Entity.TraitStacks>((Func<Entity.TraitStacks, bool>) (t => t.data.name == "Hero")) != null)
        this.image.sprite = !this.shiny ? this.sprites[2] : this.sprites[3];
      base.UpdateEvent();
    }
  }
}
