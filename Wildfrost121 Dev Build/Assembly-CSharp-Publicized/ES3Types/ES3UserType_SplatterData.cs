// Decompiled with JetBrains decompiler
// Type: ES3Types.ES3UserType_SplatterData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;
using UnityEngine.Scripting;

#nullable disable
namespace ES3Types
{
  [Preserve]
  [ES3Properties(new string[] {"sprite", "color", "offset", "scale", "angle"})]
  public class ES3UserType_SplatterData : ES3ObjectType
  {
    public static ES3Type Instance;

    public ES3UserType_SplatterData()
      : base(typeof (SplatterPersistenceSystem.SplatterData))
    {
      ES3UserType_SplatterData.Instance = (ES3Type) this;
      this.priority = 1;
    }

    public override void WriteObject(object obj, ES3Writer writer)
    {
      SplatterPersistenceSystem.SplatterData objectContainingField = (SplatterPersistenceSystem.SplatterData) obj;
      writer.WritePrivateFieldByRef("sprite", (object) objectContainingField);
      writer.WritePrivateField("color", (object) objectContainingField);
      writer.WritePrivateField("offset", (object) objectContainingField);
      writer.WritePrivateField("scale", (object) objectContainingField);
      writer.WritePrivateField("angle", (object) objectContainingField);
    }

    public override void ReadObject<T>(ES3Reader reader, object obj)
    {
      SplatterPersistenceSystem.SplatterData objectContainingField = (SplatterPersistenceSystem.SplatterData) obj;
      foreach (string property in reader.Properties)
      {
        switch (property)
        {
          case "sprite":
            reader.SetPrivateField("sprite", (object) reader.Read<Sprite>(), (object) objectContainingField);
            continue;
          case "color":
            reader.SetPrivateField("color", (object) reader.Read<Color>(), (object) objectContainingField);
            continue;
          case "offset":
            reader.SetPrivateField("offset", (object) reader.Read<Vector3>(), (object) objectContainingField);
            continue;
          case "scale":
            reader.SetPrivateField("scale", (object) reader.Read<Vector3>(), (object) objectContainingField);
            continue;
          case "angle":
            reader.SetPrivateField("angle", (object) reader.Read<float>(), (object) objectContainingField);
            continue;
          default:
            reader.Skip();
            continue;
        }
      }
    }

    public override object ReadObject<T>(ES3Reader reader)
    {
      SplatterPersistenceSystem.SplatterData splatterData = new SplatterPersistenceSystem.SplatterData();
      this.ReadObject<T>(reader, (object) splatterData);
      return (object) splatterData;
    }
  }
}
