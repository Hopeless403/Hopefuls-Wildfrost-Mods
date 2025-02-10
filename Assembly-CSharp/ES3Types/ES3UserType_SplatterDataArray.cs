// Decompiled with JetBrains decompiler
// Type: ES3Types.ES3UserType_SplatterDataArray
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

namespace ES3Types
{
  public class ES3UserType_SplatterDataArray : ES3ArrayType
  {
    public static ES3Type Instance;

    public ES3UserType_SplatterDataArray()
      : base(typeof (SplatterPersistenceSystem.SplatterData[]), ES3UserType_SplatterData.Instance)
    {
      ES3UserType_SplatterDataArray.Instance = (ES3Type) this;
    }
  }
}
