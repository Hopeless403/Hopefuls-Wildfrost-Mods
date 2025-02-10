// Decompiled with JetBrains decompiler
// Type: TribeHutSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using UnityEngine;

#nullable disable
public class TribeHutSequence : BuildingSequence
{
  [SerializeField]
  public TribeFlagDisplay[] flags;
  public GameMode _gameMode;

  public GameMode gameMode
  {
    get
    {
      return this._gameMode ?? (this._gameMode = AddressableLoader.Get<GameMode>("GameMode", "GameModeNormal"));
    }
  }

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
