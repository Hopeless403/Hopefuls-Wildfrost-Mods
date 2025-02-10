// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectWhileExistingX
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

#nullable disable
namespace Pokefrost
{
  internal class StatusEffectWhileExistingX : StatusEffectWhileActiveX
  {
    public override bool CanActivate() => true;

    public override bool CheckActivateOnMove(
      CardContainer[] fromContainers,
      CardContainer[] toContainers)
    {
      return false;
    }

    public override bool CheckDeactivateOnMove(
      CardContainer[] fromContainers,
      CardContainer[] toContainers)
    {
      return false;
    }
  }
}
