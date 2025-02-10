// Decompiled with JetBrains decompiler
// Type: ClassSaveData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
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
