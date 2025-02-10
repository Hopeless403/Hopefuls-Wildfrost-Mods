// Decompiled with JetBrains decompiler
// Type: Pokefrost.EntityCardScriptReturnProphCard
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System.Collections;
using System.Collections.Generic;

#nullable disable
namespace Pokefrost
{
  public class EntityCardScriptReturnProphCard : EntityCardScript
  {
    public override IEnumerator Run(Entity entity, int stack)
    {
      string name = this.ProphCard(entity);
      List<Entity> targets = References.Player.discardContainer.entities.Clone<Entity>();
      targets.AddRange((IEnumerable<Entity>) References.Player.drawContainer);
      for (int i = targets.Count - 1; i >= 0; --i)
      {
        if (targets[i].data.name == name)
        {
          yield return (object) Sequences.CardMove(targets[i], new CardContainer[1]
          {
            References.Player.handContainer
          });
          if (--stack <= 0)
            break;
        }
        ActionQueue.Stack((PlayAction) new ActionRevealAll(new CardContainer[1]
        {
          References.Player.handContainer
        }));
      }
    }

    public string ProphCard(Entity entity)
    {
      string str;
      entity.data.TryGetCustomData<string>("Future Sight", out str, "");
      return str;
    }
  }
}
