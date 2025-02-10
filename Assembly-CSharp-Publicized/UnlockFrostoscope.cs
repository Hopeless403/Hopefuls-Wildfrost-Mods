// Decompiled with JetBrains decompiler
// Type: UnlockFrostoscope
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

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

  public void Check(Building building)
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
