// Decompiled with JetBrains decompiler
// Type: ClassSaveData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;

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
