// Decompiled with JetBrains decompiler
// Type: LeaderNameHistoryDisplay
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using Dead;
using NaughtyAttributes;
using System.Collections.Generic;
using UnityEngine;

public class LeaderNameHistoryDisplay : MonoBehaviour
{
  [SerializeField]
  public LeaderNameHistoryEntry namePrefab;

  public void OnEnable() => this.Populate();

  public void OnDisable() => this.transform.DestroyAllChildren();

  public void Populate()
  {
    List<JournalNameHistory.Name> nameList = SaveSystem.LoadProgressData<List<JournalNameHistory.Name>>("leaderNameHistory");
    if (nameList == null)
      return;
    Transform transform = this.transform;
    foreach (JournalNameHistory.Name name in nameList)
    {
      LeaderNameHistoryEntry nameHistoryEntry = Object.Instantiate<LeaderNameHistoryEntry>(this.namePrefab, transform);
      nameHistoryEntry.transform.localPosition = (Vector3) name.position;
      nameHistoryEntry.Assign(name);
    }
  }

  [Button(null, EButtonEnableMode.Always)]
  public void AddName()
  {
    if ((double) PettyRandom.Range(0.0f, 1f) > 0.25)
      JournalNameHistory.MostRecentNameKilled();
    else
      JournalNameHistory.MostRecentNameMissing();
    JournalNameHistory.FadePrevious();
    JournalNameHistory.AddName(Names.Pull("SnowdwellerMale"));
    this.Repopulate();
  }

  public void Repopulate()
  {
    this.transform.DestroyAllChildren();
    this.Populate();
  }
}
