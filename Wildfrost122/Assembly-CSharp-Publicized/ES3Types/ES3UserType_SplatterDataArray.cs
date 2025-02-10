// Decompiled with JetBrains decompiler
// Type: ES3Types.ES3UserType_SplatterDataArray
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

#nullable disable
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
