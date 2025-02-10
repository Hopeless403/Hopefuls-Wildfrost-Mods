// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectInstantRunScript
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System.Collections;
using System.Collections.Generic;

#nullable disable
namespace Pokefrost
{
  public class StatusEffectInstantRunScript : StatusEffectInstant
  {
    public PlayAction action;
    public bool stack = true;
    public List<EntityCardScript> scriptList;

    public override IEnumerator Process()
    {
      if (this.action != null)
      {
        if (this.stack)
          ActionQueue.Stack(this.action);
        else
          ActionQueue.Add(this.action);
      }
      if (this.scriptList != null && this.scriptList.Count > 0)
      {
        foreach (EntityCardScript script in this.scriptList)
          yield return (object) script.Run(this.target, this.count);
      }
      this.target.display.promptUpdateDescription = true;
      this.target.PromptUpdate();
      yield return (object) base.Process();
    }
  }
}
