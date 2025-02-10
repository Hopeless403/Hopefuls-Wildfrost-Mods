// Decompiled with JetBrains decompiler
// Type: NexPlugin.StationURL
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

#nullable disable
namespace NexPlugin
{
  public class StationURL
  {
    public enum URLType
    {
      unknown,
      prudp,
      prudps,
      udp,
    }

    public enum Flags
    {
      BehindNAT = 1,
      Public = 2,
      DetectedByNatCheck = 4,
      DetectedByNgs = 8,
    }
  }
}
