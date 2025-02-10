// Decompiled with JetBrains decompiler
// Type: NexPlugin.Subscriber
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace NexPlugin
{
  public static class Subscriber : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MAX_TOPIC_CONTENT_SIZE;
    private static readonly System.IntPtr NativeFieldInfoPtr_MAX_TIMELINE_CONTENT_SIZE;
    private static readonly System.IntPtr NativeFieldInfoPtr_MAX_FOLLOWING_SIZE;
    private static readonly System.IntPtr NativeFieldInfoPtr_NUM_RESERVED_TOPICS;
    private static readonly System.IntPtr NativeFieldInfoPtr_INVALID_RESERVED_TOPIC_NUM;
    private static readonly System.IntPtr NativeFieldInfoPtr_MAX_GET_FOLLOWER_SIZE;
    private static readonly System.IntPtr NativeFieldInfoPtr_MAX_CONTENT_MESSAGE_LEN;
    private static readonly System.IntPtr NativeFieldInfoPtr_MAX_CONTENT_BINARY_SIZE;
    private static readonly System.IntPtr NativeFieldInfoPtr_MAX_POST_CONTENT_TOPIC_SIZE;
    private static readonly System.IntPtr NativeFieldInfoPtr_MAX_GET_CONTENT_PARAMS_SIZE;
    private static readonly System.IntPtr NativeFieldInfoPtr_STATUS_KEY_SIZE;
    private static readonly System.IntPtr NativeFieldInfoPtr_MAX_STATUS_BINARY_SIZE;
    private static readonly System.IntPtr NativeFieldInfoPtr_MAX_GET_STATUS_USER_SIZE;
    private static readonly System.IntPtr NativeFieldInfoPtr_DEFAULT_RMC_INTERVAL;

    static Subscriber()
    {
      Il2CppClassPointerStore<Subscriber>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NexPlugin", nameof (Subscriber));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Subscriber>.NativeClassPtr);
      Subscriber.NativeFieldInfoPtr_MAX_TOPIC_CONTENT_SIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Subscriber>.NativeClassPtr, nameof (MAX_TOPIC_CONTENT_SIZE));
      Subscriber.NativeFieldInfoPtr_MAX_TIMELINE_CONTENT_SIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Subscriber>.NativeClassPtr, nameof (MAX_TIMELINE_CONTENT_SIZE));
      Subscriber.NativeFieldInfoPtr_MAX_FOLLOWING_SIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Subscriber>.NativeClassPtr, nameof (MAX_FOLLOWING_SIZE));
      Subscriber.NativeFieldInfoPtr_NUM_RESERVED_TOPICS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Subscriber>.NativeClassPtr, nameof (NUM_RESERVED_TOPICS));
      Subscriber.NativeFieldInfoPtr_INVALID_RESERVED_TOPIC_NUM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Subscriber>.NativeClassPtr, nameof (INVALID_RESERVED_TOPIC_NUM));
      Subscriber.NativeFieldInfoPtr_MAX_GET_FOLLOWER_SIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Subscriber>.NativeClassPtr, nameof (MAX_GET_FOLLOWER_SIZE));
      Subscriber.NativeFieldInfoPtr_MAX_CONTENT_MESSAGE_LEN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Subscriber>.NativeClassPtr, nameof (MAX_CONTENT_MESSAGE_LEN));
      Subscriber.NativeFieldInfoPtr_MAX_CONTENT_BINARY_SIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Subscriber>.NativeClassPtr, nameof (MAX_CONTENT_BINARY_SIZE));
      Subscriber.NativeFieldInfoPtr_MAX_POST_CONTENT_TOPIC_SIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Subscriber>.NativeClassPtr, nameof (MAX_POST_CONTENT_TOPIC_SIZE));
      Subscriber.NativeFieldInfoPtr_MAX_GET_CONTENT_PARAMS_SIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Subscriber>.NativeClassPtr, nameof (MAX_GET_CONTENT_PARAMS_SIZE));
      Subscriber.NativeFieldInfoPtr_STATUS_KEY_SIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Subscriber>.NativeClassPtr, nameof (STATUS_KEY_SIZE));
      Subscriber.NativeFieldInfoPtr_MAX_STATUS_BINARY_SIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Subscriber>.NativeClassPtr, nameof (MAX_STATUS_BINARY_SIZE));
      Subscriber.NativeFieldInfoPtr_MAX_GET_STATUS_USER_SIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Subscriber>.NativeClassPtr, nameof (MAX_GET_STATUS_USER_SIZE));
      Subscriber.NativeFieldInfoPtr_DEFAULT_RMC_INTERVAL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Subscriber>.NativeClassPtr, nameof (DEFAULT_RMC_INTERVAL));
    }

    public Subscriber(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe uint MAX_TOPIC_CONTENT_SIZE
    {
      get
      {
        uint topicContentSize;
        IL2CPP.il2cpp_field_static_get_value(Subscriber.NativeFieldInfoPtr_MAX_TOPIC_CONTENT_SIZE, (void*) &topicContentSize);
        return topicContentSize;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Subscriber.NativeFieldInfoPtr_MAX_TOPIC_CONTENT_SIZE, (void*) &value);
      }
    }

    public static unsafe uint MAX_TIMELINE_CONTENT_SIZE
    {
      get
      {
        uint timelineContentSize;
        IL2CPP.il2cpp_field_static_get_value(Subscriber.NativeFieldInfoPtr_MAX_TIMELINE_CONTENT_SIZE, (void*) &timelineContentSize);
        return timelineContentSize;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Subscriber.NativeFieldInfoPtr_MAX_TIMELINE_CONTENT_SIZE, (void*) &value);
      }
    }

    public static unsafe uint MAX_FOLLOWING_SIZE
    {
      get
      {
        uint maxFollowingSize;
        IL2CPP.il2cpp_field_static_get_value(Subscriber.NativeFieldInfoPtr_MAX_FOLLOWING_SIZE, (void*) &maxFollowingSize);
        return maxFollowingSize;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Subscriber.NativeFieldInfoPtr_MAX_FOLLOWING_SIZE, (void*) &value);
      }
    }

    public static unsafe uint NUM_RESERVED_TOPICS
    {
      get
      {
        uint numReservedTopics;
        IL2CPP.il2cpp_field_static_get_value(Subscriber.NativeFieldInfoPtr_NUM_RESERVED_TOPICS, (void*) &numReservedTopics);
        return numReservedTopics;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Subscriber.NativeFieldInfoPtr_NUM_RESERVED_TOPICS, (void*) &value);
      }
    }

    public static unsafe uint INVALID_RESERVED_TOPIC_NUM
    {
      get
      {
        uint reservedTopicNum;
        IL2CPP.il2cpp_field_static_get_value(Subscriber.NativeFieldInfoPtr_INVALID_RESERVED_TOPIC_NUM, (void*) &reservedTopicNum);
        return reservedTopicNum;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Subscriber.NativeFieldInfoPtr_INVALID_RESERVED_TOPIC_NUM, (void*) &value);
      }
    }

    public static unsafe uint MAX_GET_FOLLOWER_SIZE
    {
      get
      {
        uint maxGetFollowerSize;
        IL2CPP.il2cpp_field_static_get_value(Subscriber.NativeFieldInfoPtr_MAX_GET_FOLLOWER_SIZE, (void*) &maxGetFollowerSize);
        return maxGetFollowerSize;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Subscriber.NativeFieldInfoPtr_MAX_GET_FOLLOWER_SIZE, (void*) &value);
      }
    }

    public static unsafe uint MAX_CONTENT_MESSAGE_LEN
    {
      get
      {
        uint contentMessageLen;
        IL2CPP.il2cpp_field_static_get_value(Subscriber.NativeFieldInfoPtr_MAX_CONTENT_MESSAGE_LEN, (void*) &contentMessageLen);
        return contentMessageLen;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Subscriber.NativeFieldInfoPtr_MAX_CONTENT_MESSAGE_LEN, (void*) &value);
      }
    }

    public static unsafe uint MAX_CONTENT_BINARY_SIZE
    {
      get
      {
        uint contentBinarySize;
        IL2CPP.il2cpp_field_static_get_value(Subscriber.NativeFieldInfoPtr_MAX_CONTENT_BINARY_SIZE, (void*) &contentBinarySize);
        return contentBinarySize;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Subscriber.NativeFieldInfoPtr_MAX_CONTENT_BINARY_SIZE, (void*) &value);
      }
    }

    public static unsafe uint MAX_POST_CONTENT_TOPIC_SIZE
    {
      get
      {
        uint contentTopicSize;
        IL2CPP.il2cpp_field_static_get_value(Subscriber.NativeFieldInfoPtr_MAX_POST_CONTENT_TOPIC_SIZE, (void*) &contentTopicSize);
        return contentTopicSize;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Subscriber.NativeFieldInfoPtr_MAX_POST_CONTENT_TOPIC_SIZE, (void*) &value);
      }
    }

    public static unsafe uint MAX_GET_CONTENT_PARAMS_SIZE
    {
      get
      {
        uint contentParamsSize;
        IL2CPP.il2cpp_field_static_get_value(Subscriber.NativeFieldInfoPtr_MAX_GET_CONTENT_PARAMS_SIZE, (void*) &contentParamsSize);
        return contentParamsSize;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Subscriber.NativeFieldInfoPtr_MAX_GET_CONTENT_PARAMS_SIZE, (void*) &value);
      }
    }

    public static unsafe byte STATUS_KEY_SIZE
    {
      get
      {
        byte statusKeySize;
        IL2CPP.il2cpp_field_static_get_value(Subscriber.NativeFieldInfoPtr_STATUS_KEY_SIZE, (void*) &statusKeySize);
        return statusKeySize;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Subscriber.NativeFieldInfoPtr_STATUS_KEY_SIZE, (void*) &value);
      }
    }

    public static unsafe uint MAX_STATUS_BINARY_SIZE
    {
      get
      {
        uint statusBinarySize;
        IL2CPP.il2cpp_field_static_get_value(Subscriber.NativeFieldInfoPtr_MAX_STATUS_BINARY_SIZE, (void*) &statusBinarySize);
        return statusBinarySize;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Subscriber.NativeFieldInfoPtr_MAX_STATUS_BINARY_SIZE, (void*) &value);
      }
    }

    public static unsafe uint MAX_GET_STATUS_USER_SIZE
    {
      get
      {
        uint getStatusUserSize;
        IL2CPP.il2cpp_field_static_get_value(Subscriber.NativeFieldInfoPtr_MAX_GET_STATUS_USER_SIZE, (void*) &getStatusUserSize);
        return getStatusUserSize;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Subscriber.NativeFieldInfoPtr_MAX_GET_STATUS_USER_SIZE, (void*) &value);
      }
    }

    public static unsafe uint DEFAULT_RMC_INTERVAL
    {
      get
      {
        uint defaultRmcInterval;
        IL2CPP.il2cpp_field_static_get_value(Subscriber.NativeFieldInfoPtr_DEFAULT_RMC_INTERVAL, (void*) &defaultRmcInterval);
        return defaultRmcInterval;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Subscriber.NativeFieldInfoPtr_DEFAULT_RMC_INTERVAL, (void*) &value);
      }
    }
  }
}
