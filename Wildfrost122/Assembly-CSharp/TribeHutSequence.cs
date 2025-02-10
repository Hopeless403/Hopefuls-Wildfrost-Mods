// Decompiled with JetBrains decompiler
// Type: TribeHutSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;

#nullable disable
public class TribeHutSequence : BuildingSequence
{
  [SerializeField]
  private TribeFlagDisplay[] flags;
  private GameMode _gameMode;

  private GameMode gameMode
  {
    get
    {
      return this._gameMode ?? (this._gameMode = AddressableLoader.Get<GameMode>("GameMode", "GameModeNormal"));
    }
  }

  protected override IEnumerator Sequence()
  {
    this.SetupFlags();
    yield return (object) null;
  }

  private void SetupFlags()
  {
    int? count = this.building.checkedUnlocks?.Count;
    int valueOrDefault = (count.HasValue ? new int?(1 + count.GetValueOrDefault()) : new int?()).GetValueOrDefault();
    int length = this.gameMode.classes.Length;
    for (int index = 0; index < this.flags.Length; ++index)
    {
      if (index < length)
      {
        this.flags[index].SetAvailable();
        if (index < valueOrDefault)
          this.flags[index].SetUnlocked();
      }
    }
  }
}
