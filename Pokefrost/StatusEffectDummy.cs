// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectDummy
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System.Collections;

#nullable disable
namespace Pokefrost
{
  public class StatusEffectDummy : StatusEffectData
  {
    public bool dummy = true;
    public string truename = string.Empty;

    public override void Init()
    {
      this.temporary = 99;
      this.OnTurnEnd += new StatusEffectData.EffectEntityEventHandler(this.Decrease);
    }

    public IEnumerator Decrease(Entity entity)
    {
      int amount = 1;
      Events.InvokeStatusEffectCountDown((StatusEffectData) this, ref amount);
      if (amount != 0)
        yield return (object) this.CountDown(entity, amount);
    }
  }
}
