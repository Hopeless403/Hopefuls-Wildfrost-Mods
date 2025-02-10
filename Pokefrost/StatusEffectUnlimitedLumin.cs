// Decompiled with JetBrains decompiler
// Type: Pokefrost.StatusEffectUnlimitedLumin
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using HarmonyLib;

#nullable disable
namespace Pokefrost
{
  internal class StatusEffectUnlimitedLumin : StatusEffectData
  {
    public bool added = false;

    public override bool RunBeginEvent()
    {
      this.Activate();
      return false;
    }

    public void OnDestroy() => this.Deactivate();

    public override bool RunEffectBonusChangedEvent()
    {
      if (this.GetAmount() == 0)
        this.Deactivate();
      else
        this.Activate();
      return false;
    }

    protected void Activate()
    {
      if (this.added)
        return;
      ++StatusEffectUnlimitedLumin.PatchLumin.active;
      this.added = true;
    }

    protected void Deactivate()
    {
      if (!this.added)
        return;
      --StatusEffectUnlimitedLumin.PatchLumin.active;
      this.added = false;
    }

    [HarmonyPatch(typeof (StatusEffectLumin), "RunPostApplyStatusEvent")]
    private class PatchLumin
    {
      public static int active;

      public static bool Active => StatusEffectUnlimitedLumin.PatchLumin.active != 0;

      private static bool Prefix() => !StatusEffectUnlimitedLumin.PatchLumin.Active;
    }
  }
}
