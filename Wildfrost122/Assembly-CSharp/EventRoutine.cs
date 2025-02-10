// Decompiled with JetBrains decompiler
// Type: EventRoutine
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
public class EventRoutine : SceneRoutine
{
  private Character _player;
  public CampaignNode node;

  protected Character player => this._player ?? (this._player = References.Player);

  protected Dictionary<string, object> data => this.node.data;

  public virtual IEnumerator Populate() => (IEnumerator) null;

  protected void CheckAddUpgrades(int cardIndex, CardData cardDataClone)
  {
    string key = string.Format("upgrades{0}", (object) cardIndex);
    if (!this.node.data.ContainsKey(key))
      return;
    foreach (string save in this.node.data.GetSaveCollection<string>(key))
    {
      CardUpgradeData cardUpgradeData = AddressableLoader.Get<CardUpgradeData>("CardUpgradeData", save);
      if ((bool) (Object) cardUpgradeData)
        cardUpgradeData.Clone().Assign(cardDataClone);
    }
  }
}
