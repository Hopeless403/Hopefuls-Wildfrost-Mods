// Decompiled with JetBrains decompiler
// Type: EventRoutine
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventRoutine : SceneRoutine
{
  public Character _player;
  public CampaignNode node;

  public Character player => this._player ?? (this._player = References.Player);

  public Dictionary<string, object> data => this.node.data;

  public virtual IEnumerator Populate() => (IEnumerator) null;

  public void CheckAddUpgrades(int cardIndex, CardData cardDataClone)
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
