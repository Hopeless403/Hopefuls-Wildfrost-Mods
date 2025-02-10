// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectEvolveChingling
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using UnityEngine;

#nullable disable
namespace Pokefrost
{
  public class StatusEffectEvolveChingling : StatusEffectEvolveFromNode
  {
    public override bool NodeVisit(string nodeName, CardData cardData)
    {
      GameObject gameObject = GameObject.Find("Canvas/Padding/HUD/ModifierIcons");
      if ((Object) gameObject != (Object) null)
      {
        this.count = 0;
        foreach (Object allChild in gameObject.transform.GetAllChildren())
        {
          if (allChild.name == "BellModifierIcon(Clone)")
            ++this.count;
        }
        foreach (CardData.StatusEffectStacks startWithEffect in cardData.startWithEffects)
        {
          if (startWithEffect.data.name == this.name)
            return startWithEffect.count <= this.count;
        }
      }
      return false;
    }
  }
}
