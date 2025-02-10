// Decompiled with JetBrains decompiler
// Type: Pokefrost.CommandFillEvolveDebug1
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

#nullable disable
namespace Pokefrost
{
  public class CommandFillEvolveDebug1 : Console.Command
  {
    public override string id => "evo1";

    public override string format => "evo1";

    public override void Run(string args)
    {
      MonoBehaviourSingleton<References>.instance.StartCoroutine(EvolutionPopUp.Run());
    }
  }
}
