// Decompiled with JetBrains decompiler
// Type: UnlockFrostoscope
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections.Generic;
using UnityEngine;

#nullable disable
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
