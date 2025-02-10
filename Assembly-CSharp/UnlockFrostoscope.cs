// Decompiled with JetBrains decompiler
// Type: UnlockFrostoscope
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections.Generic;
using UnityEngine;

public class UnlockFrostoscope : MonoBehaviour
{
  public void Check(GameObject gameObject)
  {
    Building component = gameObject.GetComponent<Building>();
    if (component == null)
      return;
    this.Check(component);
  }

  private void Check(Building building)
  {
    List<string> unlockedList = MetaprogressionSystem.GetUnlockedList();
    UnlockData finished = building.type.finished;
    if (MetaprogressionSystem.IsUnlocked(finished, unlockedList) || SaveSystem.LoadProgressData<CardSaveData[]>("finalBossDeck") == null)
      return;
    unlockedList.Add(finished.name);
    SaveSystem.SaveProgressData<List<string>>("unlocked", unlockedList);
    MetaprogressionSystem.SetUnlocksReady(finished.name);
    building.CheckIfUnlocked();
  }
}
