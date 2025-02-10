// Decompiled with JetBrains decompiler
// Type: ClassSaveData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

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
