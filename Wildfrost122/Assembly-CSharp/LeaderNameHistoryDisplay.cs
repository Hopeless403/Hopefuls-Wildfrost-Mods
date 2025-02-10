// Decompiled with JetBrains decompiler
// Type: LeaderNameHistoryDisplay
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using Dead;
using NaughtyAttributes;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
public class LeaderNameHistoryDisplay : MonoBehaviour
{
  [SerializeField]
  private LeaderNameHistoryEntry namePrefab;

  private void OnEnable() => this.Populate();

  private void OnDisable() => this.transform.DestroyAllChildren();

  private void Populate()
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
  private void AddName()
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
