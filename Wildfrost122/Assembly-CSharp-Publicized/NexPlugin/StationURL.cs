// Decompiled with JetBrains decompiler
// Type: NexPlugin.StationURL
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
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
