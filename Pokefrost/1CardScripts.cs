// Decompiled with JetBrains decompiler
// Type: Pokefrost.EntityCardScriptSwapTraits
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System.Collections;
using UnityEngine;

#nullable disable
namespace Pokefrost
{
  public class EntityCardScriptSwapTraits : EntityCardScript
  {
    protected TraitData traitA;
    protected TraitData traitB;

    public override IEnumerator Run(Entity target, int _)
    {
      int origStackA = 0;
      int origStackB = 0;
      foreach (Entity.TraitStacks stacks in target.traits)
      {
        if (stacks.data.name == this.traitA.name)
        {
          origStackA = stacks.count - stacks.tempCount;
          stacks.count -= origStackA;
        }
        if (stacks.data.name == this.traitB.name)
        {
          origStackB = stacks.count - stacks.tempCount;
          stacks.count -= origStackB;
        }
      }
      target.GainTrait(this.traitA, origStackB);
      target.GainTrait(this.traitB, origStackA);
      yield return (object) target.UpdateTraits();
    }

    public static EntityCardScriptSwapTraits Create(TraitData traitA, TraitData traitB)
    {
      EntityCardScriptSwapTraits instance = ScriptableObject.CreateInstance<EntityCardScriptSwapTraits>();
      instance.traitA = traitA;
      instance.traitB = traitB;
      return instance;
    }
  }
}
