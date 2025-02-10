// Decompiled with JetBrains decompiler
// Type: Snowfall2.Classes.StatusEffects.StatusEffectDropNoGold
// Assembly: Snowfall, Version=0.0.1.0, Culture=neutral, PublicKeyToken=null
// MVID: 26AFE777-3FAB-4D6F-AF6C-494837402D4A
// Assembly location: C:\Users\harri\AppData\Local\Temp\Temp1_Snowfall_-_Alpha_2.1.2.zip\Snowfall.dll

using System.Collections;

namespace Snowfall2.Classes.StatusEffects
{
  public class StatusEffectDropNoGold : StatusEffectData
  {
    private int StoredValue = 0;

    public override void Init()
    {
      this.OnBegin += new StatusEffectData.EffectEventHandler(this.Begin);
      this.OnEnd += new StatusEffectData.EffectEventHandler(this.End);
    }

    public IEnumerator Begin()
    {
      this.StoredValue = this.target.data.value;
      this.target.data.value = 0;
      yield break;
    }

    public IEnumerator End()
    {
      this.target.data.value = this.StoredValue;
      yield break;
    }
  }
}
