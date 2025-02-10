// Decompiled with JetBrains decompiler
// Type: TribeHutSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using UnityEngine;

public class TribeHutSequence : BuildingSequence
{
  [SerializeField]
  public TribeFlagDisplay[] flags;
  public GameMode _gameMode;

  public GameMode gameMode => this._gameMode ?? (this._gameMode = AddressableLoader.Get<GameMode>("GameMode", "GameModeNormal"));

  public override IEnumerator Sequence()
  {
    this.SetupFlags();
    yield return (object) null;
  }

  public void SetupFlags()
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
