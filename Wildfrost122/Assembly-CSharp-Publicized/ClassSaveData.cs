// Decompiled with JetBrains decompiler
// Type: ClassSaveData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

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
