﻿// Decompiled with JetBrains decompiler
// Type: NexPlugin.VSocket
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

#nullable disable
namespace NexPlugin
{
  public class VSocket
  {
    public const uint MAX_DATA_SIZE = 1250;
    public const uint MARGIN_SIZE = 12;
    public const uint DEFAULT_MAX_RECV_PACKTES = 128;
    public const uint TOTAL_NAT_TRAVERSAL_TIMEOUT_MS = 120000;

    public enum Result
    {
      Success,
      Error,
      WouldBlock,
      PacketBufferFull,
    }
  }
}
