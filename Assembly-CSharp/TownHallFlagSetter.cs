// Decompiled with JetBrains decompiler
// Type: TownHallFlagSetter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections.Generic;
using UnityEngine;

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
      this.flags[index].SetActive(flag);
    }
  }
}
