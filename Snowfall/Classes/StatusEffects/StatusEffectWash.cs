// Decompiled with JetBrains decompiler
// Type: Snowfall2.Classes.StatusEffects.StatusEffectWash
// Assembly: Snowfall, Version=0.0.1.0, Culture=neutral, PublicKeyToken=null
// MVID: 26AFE777-3FAB-4D6F-AF6C-494837402D4A
// Assembly location: C:\Users\harri\AppData\Local\Temp\Temp1_Snowfall_-_Alpha_2.1.2.zip\Snowfall.dll

using System.Collections;

namespace Snowfall2.Classes.StatusEffects
{
  public class StatusEffectWash : StatusEffectInstant
  {
    public override IEnumerator Process()
    {
      int num = this.target.statusEffects.Count;
      for (int i = num - 1; i >= 0; --i)
      {
        StatusEffectData statusEffectData = this.target.statusEffects[i];
        if (statusEffectData.visible && statusEffectData.isStatus && statusEffectData.name != "MultiHit")
          yield return (object) statusEffectData.Remove();
        statusEffectData = (StatusEffectData) null;
      }
      this.target.PromptUpdate();
      yield return (object) base.Process();
    }
  }
}
