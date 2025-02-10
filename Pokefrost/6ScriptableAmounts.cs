// Decompiled with JetBrains decompiler
// Type: Pokefrost.TargetConstraintHeight
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

#nullable disable
namespace Pokefrost
{
  public class TargetConstraintHeight : TargetConstraint
  {
    private int height = 1;

    public override bool Check(Entity entity)
    {
      return entity.height == this.height ? !this.not : this.not;
    }
  }
}
