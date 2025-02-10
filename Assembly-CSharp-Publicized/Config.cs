// Decompiled with JetBrains decompiler
// Type: Config
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using UnityEngine;

public class Config : MonoBehaviourSingleton<Config>
{
  [SerializeField]
  public TextAsset configFile;
  public static Config.Data _data;

  public static Config.Data data => Config._data ?? (Config._data = JsonUtility.FromJson<Config.Data>(MonoBehaviourSingleton<Config>.instance.configFile.text));

  public override void Awake()
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
