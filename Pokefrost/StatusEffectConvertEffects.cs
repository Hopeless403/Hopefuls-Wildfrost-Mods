// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectConvertEffects
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System.Collections;

#nullable disable
namespace Pokefrost
{
  public class StatusEffectConvertEffects : StatusEffectInstant
  {
    public string effectA = "";
    public string effectB = "";
    public bool swap = false;
    protected int stackA = 0;
    protected int stackB = 0;

    public override IEnumerator Process()
    {
      Routine.Clump clump = new Routine.Clump();
      for (int i = this.target.statusEffects.Count - 1; i >= 0; --i)
      {
        if (this.target.statusEffects[i]?.name == this.effectA)
        {
          this.stackA = this.target.statusEffects[i].count;
          clump.Add(this.target.statusEffects[i].Remove());
        }
        if (this.swap && this.target.statusEffects[i]?.name == this.effectB)
        {
          this.stackB = this.target.statusEffects[i].count;
          clump.Add(this.target.statusEffects[i].Remove());
        }
      }
      yield return (object) clump.WaitForEnd();
      if (this.stackA > 0)
        clump.Add(StatusEffectSystem.Apply(this.target, this.applier, Pokefrost.Pokefrost.instance.Get<StatusEffectData>(this.effectB), this.stackA));
      if (this.swap && this.stackB > 0)
        clump.Add(StatusEffectSystem.Apply(this.target, this.applier, Pokefrost.Pokefrost.instance.Get<StatusEffectData>(this.effectA), this.stackB));
      yield return (object) clump.WaitForEnd();
      yield return (object) base.Process();
    }
  }
}
