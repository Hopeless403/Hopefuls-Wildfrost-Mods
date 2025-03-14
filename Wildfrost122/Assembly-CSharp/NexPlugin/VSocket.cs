﻿// Decompiled with JetBrains decompiler
// Type: NexPlugin.VSocket
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

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
