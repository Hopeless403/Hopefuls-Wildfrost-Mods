// Decompiled with JetBrains decompiler
// Type: ClassSaveData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;

#nullable disable
[Serializable]
public class ClassSaveData : ILoadable<ClassData>
{
  public string name;

  public ClassSaveData()
  {
  }

  public ClassSaveData(string name) => this.name = name;

  public ClassData Load() => AddressableLoader.Get<ClassData>("ClassData", this.name);
}
