// Decompiled with JetBrains decompiler
// Type: TribeHutSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;

public class TribeHutSequence : BuildingSequence
{
  [SerializeField]
  private TribeFlagDisplay[] flags;
  private GameMode _gameMode;

  private GameMode gameMode => this._gameMode ?? (this._gameMode = AddressableLoader.Get<GameMode>("GameMode", "GameModeNormal"));

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
