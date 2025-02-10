// Decompiled with JetBrains decompiler
// Type: ES3Types.ES3UserType_SplatterDataArray
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

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
