// Decompiled with JetBrains decompiler
// Type: TownHallFlagSetter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections.Generic;
using UnityEngine;

#nullable disable
[RequireComponent(typeof (Building))]
public class TownHallFlagSetter : MonoBehaviour
{
  [SerializeField]
  private GameObject[] flags;

  public void SetupFlags()
  {
    GameMode gameMode = AddressableLoader.Get<GameMode>("GameMode", "GameModeNormal");
    List<ClassData> lockedClasses = MetaprogressionSystem.GetLockedClasses();
    for (int index = 0; index < gameMode.classes.Length; ++index)
    {
      ClassData classData = gameMode.classes[index];
      bool flag = !lockedClasses.Contains(classData);
      if (this.flags.Length > index)
        this.flags[index].SetActive(flag);
    }
  }
}
