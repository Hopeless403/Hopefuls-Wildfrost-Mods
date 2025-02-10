// Decompiled with JetBrains decompiler
// Type: NexPlugin.Subscriber
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

#nullable disable
namespace NexPlugin
{
  public static class Subscriber
  {
    public const uint MAX_TOPIC_CONTENT_SIZE = 100;
    public const uint MAX_TIMELINE_CONTENT_SIZE = 100;
    public const uint MAX_FOLLOWING_SIZE = 20;
    public const uint NUM_RESERVED_TOPICS = 128;
    public const uint INVALID_RESERVED_TOPIC_NUM = 4294967295;
    public const uint MAX_GET_FOLLOWER_SIZE = 1000;
    public const uint MAX_CONTENT_MESSAGE_LEN = 140;
    public const uint MAX_CONTENT_BINARY_SIZE = 256;
    public const uint MAX_POST_CONTENT_TOPIC_SIZE = 10;
    public const uint MAX_GET_CONTENT_PARAMS_SIZE = 3;
    public const byte STATUS_KEY_SIZE = 8;
    public const uint MAX_STATUS_BINARY_SIZE = 128;
    public const uint MAX_GET_STATUS_USER_SIZE = 100;
    public const uint DEFAULT_RMC_INTERVAL = 5000;
  }
}
