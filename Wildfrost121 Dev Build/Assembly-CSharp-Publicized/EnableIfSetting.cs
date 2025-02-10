// Decompiled with JetBrains decompiler
// Type: EnableIfSetting
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using NaughtyAttributes;
using UnityEngine;

#nullable disable
public class EnableIfSetting : MonoBehaviour
{
  [SerializeField]
  public string key;
  [SerializeField]
  public EnableIfSetting.Type type;
  [SerializeField]
  [ShowIf("TypeBool")]
  public bool expectedBool = true;
  [SerializeField]
  [ShowIf("TypeBool")]
  public bool defaultBool;
  [SerializeField]
  [ShowIf("TypeString")]
  public string expectedString;
  [SerializeField]
  [ShowIf("TypeString")]
  public string defaultString;
  [SerializeField]
  [ShowIf("TypeInt")]
  public string expectedInt;
  [SerializeField]
  [ShowIf("TypeInt")]
  public string defaultInt;
  [SerializeField]
  [ShowIf("TypeFloatMin")]
  public float minFloat;
  [SerializeField]
  [ShowIf("TypeFloatMax")]
  public float maxFloat;
  [SerializeField]
  [ShowIf("TypeFloat")]
  public float defaultFloat;

  public bool TypeBool => this.type == EnableIfSetting.Type.Bool;

  public bool TypeString => this.type == EnableIfSetting.Type.String;

  public bool TypeInt => this.type == EnableIfSetting.Type.Int;

  public bool TypeFloat
  {
    get
    {
      EnableIfSetting.Type type = this.type;
      return (type == EnableIfSetting.Type.FloatMin ? 0 : (type != EnableIfSetting.Type.FloatMax ? 1 : 0)) == 0;
    }
  }

  public bool TypeFloatMin => this.type == EnableIfSetting.Type.FloatMin;

  public bool TypeFloatMax => this.type == EnableIfSetting.Type.FloatMax;

  public void Awake()
  {
    switch (this.type)
    {
      case EnableIfSetting.Type.Bool:
        this.gameObject.SetActive(Settings.Load<bool>(this.key, this.defaultBool) == this.expectedBool);
        break;
      case EnableIfSetting.Type.String:
        this.gameObject.SetActive(Settings.Load<string>(this.key, this.defaultString) == this.expectedString);
        break;
      case EnableIfSetting.Type.Int:
        this.gameObject.SetActive(Settings.Load<string>(this.key, this.defaultInt) == this.expectedInt);
        break;
      case EnableIfSetting.Type.FloatMin:
        this.gameObject.SetActive((double) Settings.Load<float>(this.key, this.defaultFloat) >= (double) this.minFloat);
        break;
      case EnableIfSetting.Type.FloatMax:
        this.gameObject.SetActive((double) Settings.Load<float>(this.key, this.defaultFloat) <= (double) this.maxFloat);
        break;
    }
  }

  public enum Type
  {
    Bool,
    String,
    Int,
    FloatMin,
    FloatMax,
  }
}
