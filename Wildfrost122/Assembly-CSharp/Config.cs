// Decompiled with JetBrains decompiler
// Type: Config
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using UnityEngine;

#nullable disable
public class Config : MonoBehaviourSingleton<Config>
{
  [SerializeField]
  private TextAsset configFile;
  private static Config.Data _data;

  public static Config.Data data
  {
    get
    {
      return Config._data ?? (Config._data = JsonUtility.FromJson<Config.Data>(MonoBehaviourSingleton<Config>.instance.configFile.text));
    }
  }

  protected override void Awake()
  {
    base.Awake();
    Debug.Log((object) (string.Format(Config.data.versionFormat, (object) Config.data.versionNotation) + " Build: " + Config.data.version));
  }

  [Serializable]
  public class Data
  {
    public string version;
    public string versionNotation;
    public string versionFormat;
    public bool beta;
  }
}
