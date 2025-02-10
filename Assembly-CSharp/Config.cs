// Decompiled with JetBrains decompiler
// Type: Config
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using UnityEngine;

public class Config : MonoBehaviourSingleton<Config>
{
  [SerializeField]
  private TextAsset configFile;
  private static Config.Data _data;

  public static Config.Data data => Config._data ?? (Config._data = JsonUtility.FromJson<Config.Data>(MonoBehaviourSingleton<Config>.instance.configFile.text));

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
