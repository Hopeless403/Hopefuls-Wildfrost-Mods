// Decompiled with JetBrains decompiler
// Type: EnableIfSetting
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using NaughtyAttributes;
using UnityEngine;

#nullable disable
public class EnableIfSetting : MonoBehaviour
{
  [SerializeField]
  private string key;
  [SerializeField]
  private EnableIfSetting.Type type;
  [SerializeField]
  [ShowIf("TypeBool")]
  private bool expectedBool = true;
  [SerializeField]
  [ShowIf("TypeBool")]
  private bool defaultBool;
  [SerializeField]
  [ShowIf("TypeString")]
  private string expectedString;
  [SerializeField]
  [ShowIf("TypeString")]
  private string defaultString;
  [SerializeField]
  [ShowIf("TypeInt")]
  private string expectedInt;
  [SerializeField]
  [ShowIf("TypeInt")]
  private string defaultInt;
  [SerializeField]
  [ShowIf("TypeFloatMin")]
  private float minFloat;
  [SerializeField]
  [ShowIf("TypeFloatMax")]
  private float maxFloat;
  [SerializeField]
  [ShowIf("TypeFloat")]
  private float defaultFloat;

  private bool TypeBool => this.type == EnableIfSetting.Type.Bool;

  private bool TypeString => this.type == EnableIfSetting.Type.String;

  private bool TypeInt => this.type == EnableIfSetting.Type.Int;

  private bool TypeFloat
  {
    get
    {
      EnableIfSetting.Type type = this.type;
      return (type == EnableIfSetting.Type.FloatMin ? 0 : (type != EnableIfSetting.Type.FloatMax ? 1 : 0)) == 0;
    }
  }

  private bool TypeFloatMin => this.type == EnableIfSetting.Type.FloatMin;

  private bool TypeFloatMax => this.type == EnableIfSetting.Type.FloatMax;

  private void Awake()
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

  private enum Type
  {
    Bool,
    String,
    Int,
    FloatMin,
    FloatMax,
  }
}
