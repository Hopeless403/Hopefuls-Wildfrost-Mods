// Decompiled with JetBrains decompiler
// Type: NexPlugin.DataStore
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Runtime;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace NexPlugin
{
  public static class DataStore : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_INVALID_DATAID;
    private static readonly System.IntPtr NativeFieldInfoPtr_INVALID_DATA_TYPE;
    private static readonly System.IntPtr NativeFieldInfoPtr_INVALID_PASSWORD;
    private static readonly System.IntPtr NativeFieldInfoPtr_MAX_NAME_LENGTH;
    private static readonly System.IntPtr NativeFieldInfoPtr_MAX_SEARCH_RESULT_SIZE;
    private static readonly System.IntPtr NativeFieldInfoPtr_MAX_SEARCH_ANY_RESULT_SIZE;
    private static readonly System.IntPtr NativeFieldInfoPtr_MAX_SEARCH_DATA_TYPE_SIZE;
    private static readonly System.IntPtr NativeFieldInfoPtr_NUM_TAG_SLOT;
    private static readonly System.IntPtr NativeFieldInfoPtr_RATING_SLOT_MAX;
    private static readonly System.IntPtr NativeFieldInfoPtr_NUM_RATING_SLOT;
    private static readonly System.IntPtr NativeFieldInfoPtr_MAX_TAG_LENGTH;
    private static readonly System.IntPtr NativeFieldInfoPtr_DEFAULT_PERIOD;
    private static readonly System.IntPtr NativeFieldInfoPtr_DEFAULT_HTTP_THREAD_PRIORITY;
    private static readonly System.IntPtr NativeFieldInfoPtr_DEFAULT_RELAY_BUFFER_SIZE;
    private static readonly System.IntPtr NativeFieldInfoPtr_DEFAULT_HTTP_BUFFER_SIZE;
    private static readonly System.IntPtr NativeFieldInfoPtr_DEFAULT_DATA_TRANSFER_TIMEOUT_BYTES_PER_SECOND;
    private static readonly System.IntPtr NativeFieldInfoPtr_DEFAULT_DATA_TRANSFER_MINIMUM_TIMEOUT;
    private static readonly System.IntPtr NativeFieldInfoPtr_DEFAULT_HTTP_SEND_SOCKET_BUFFER_SIZE;
    private static readonly System.IntPtr NativeFieldInfoPtr_DEFAULT_HTTP_RECV_SOCKET_BUFFER_SIZE;
    private static readonly System.IntPtr NativeFieldInfoPtr_INVALID_PERSISTENCE_SLOT_ID;
    private static readonly System.IntPtr NativeFieldInfoPtr_NUM_PERSISTENCE_SLOT;
    private static readonly System.IntPtr NativeFieldInfoPtr_BATCH_PROCESSING_CAPACITY_POST_OBJECT;
    private static readonly System.IntPtr NativeFieldInfoPtr_BATCH_PROCESSING_CAPACITY;
    private static readonly System.IntPtr NativeFieldInfoPtr_RESULTRANGE_ANY_OFFSET;
    private static readonly System.IntPtr NativeFieldInfoPtr_RESULTRANGE_DEFAULT_SIZE;

    static DataStore()
    {
      Il2CppClassPointerStore<DataStore>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NexPlugin", nameof (DataStore));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataStore>.NativeClassPtr);
      DataStore.NativeFieldInfoPtr_INVALID_DATAID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataStore>.NativeClassPtr, nameof (INVALID_DATAID));
      DataStore.NativeFieldInfoPtr_INVALID_DATA_TYPE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataStore>.NativeClassPtr, nameof (INVALID_DATA_TYPE));
      DataStore.NativeFieldInfoPtr_INVALID_PASSWORD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataStore>.NativeClassPtr, nameof (INVALID_PASSWORD));
      DataStore.NativeFieldInfoPtr_MAX_NAME_LENGTH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataStore>.NativeClassPtr, nameof (MAX_NAME_LENGTH));
      DataStore.NativeFieldInfoPtr_MAX_SEARCH_RESULT_SIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataStore>.NativeClassPtr, nameof (MAX_SEARCH_RESULT_SIZE));
      DataStore.NativeFieldInfoPtr_MAX_SEARCH_ANY_RESULT_SIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataStore>.NativeClassPtr, nameof (MAX_SEARCH_ANY_RESULT_SIZE));
      DataStore.NativeFieldInfoPtr_MAX_SEARCH_DATA_TYPE_SIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataStore>.NativeClassPtr, nameof (MAX_SEARCH_DATA_TYPE_SIZE));
      DataStore.NativeFieldInfoPtr_NUM_TAG_SLOT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataStore>.NativeClassPtr, nameof (NUM_TAG_SLOT));
      DataStore.NativeFieldInfoPtr_RATING_SLOT_MAX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataStore>.NativeClassPtr, nameof (RATING_SLOT_MAX));
      DataStore.NativeFieldInfoPtr_NUM_RATING_SLOT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataStore>.NativeClassPtr, nameof (NUM_RATING_SLOT));
      DataStore.NativeFieldInfoPtr_MAX_TAG_LENGTH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataStore>.NativeClassPtr, nameof (MAX_TAG_LENGTH));
      DataStore.NativeFieldInfoPtr_DEFAULT_PERIOD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataStore>.NativeClassPtr, nameof (DEFAULT_PERIOD));
      DataStore.NativeFieldInfoPtr_DEFAULT_HTTP_THREAD_PRIORITY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataStore>.NativeClassPtr, nameof (DEFAULT_HTTP_THREAD_PRIORITY));
      DataStore.NativeFieldInfoPtr_DEFAULT_RELAY_BUFFER_SIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataStore>.NativeClassPtr, nameof (DEFAULT_RELAY_BUFFER_SIZE));
      DataStore.NativeFieldInfoPtr_DEFAULT_HTTP_BUFFER_SIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataStore>.NativeClassPtr, nameof (DEFAULT_HTTP_BUFFER_SIZE));
      DataStore.NativeFieldInfoPtr_DEFAULT_DATA_TRANSFER_TIMEOUT_BYTES_PER_SECOND = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataStore>.NativeClassPtr, nameof (DEFAULT_DATA_TRANSFER_TIMEOUT_BYTES_PER_SECOND));
      DataStore.NativeFieldInfoPtr_DEFAULT_DATA_TRANSFER_MINIMUM_TIMEOUT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataStore>.NativeClassPtr, nameof (DEFAULT_DATA_TRANSFER_MINIMUM_TIMEOUT));
      DataStore.NativeFieldInfoPtr_DEFAULT_HTTP_SEND_SOCKET_BUFFER_SIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataStore>.NativeClassPtr, nameof (DEFAULT_HTTP_SEND_SOCKET_BUFFER_SIZE));
      DataStore.NativeFieldInfoPtr_DEFAULT_HTTP_RECV_SOCKET_BUFFER_SIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataStore>.NativeClassPtr, nameof (DEFAULT_HTTP_RECV_SOCKET_BUFFER_SIZE));
      DataStore.NativeFieldInfoPtr_INVALID_PERSISTENCE_SLOT_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataStore>.NativeClassPtr, nameof (INVALID_PERSISTENCE_SLOT_ID));
      DataStore.NativeFieldInfoPtr_NUM_PERSISTENCE_SLOT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataStore>.NativeClassPtr, nameof (NUM_PERSISTENCE_SLOT));
      DataStore.NativeFieldInfoPtr_BATCH_PROCESSING_CAPACITY_POST_OBJECT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataStore>.NativeClassPtr, nameof (BATCH_PROCESSING_CAPACITY_POST_OBJECT));
      DataStore.NativeFieldInfoPtr_BATCH_PROCESSING_CAPACITY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataStore>.NativeClassPtr, nameof (BATCH_PROCESSING_CAPACITY));
      DataStore.NativeFieldInfoPtr_RESULTRANGE_ANY_OFFSET = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataStore>.NativeClassPtr, nameof (RESULTRANGE_ANY_OFFSET));
      DataStore.NativeFieldInfoPtr_RESULTRANGE_DEFAULT_SIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataStore>.NativeClassPtr, nameof (RESULTRANGE_DEFAULT_SIZE));
    }

    public DataStore(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe ulong INVALID_DATAID
    {
      get
      {
        ulong invalidDataid;
        IL2CPP.il2cpp_field_static_get_value(DataStore.NativeFieldInfoPtr_INVALID_DATAID, (void*) &invalidDataid);
        return invalidDataid;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(DataStore.NativeFieldInfoPtr_INVALID_DATAID, (void*) &value);
      }
    }

    public static unsafe ushort INVALID_DATA_TYPE
    {
      get
      {
        ushort invalidDataType;
        IL2CPP.il2cpp_field_static_get_value(DataStore.NativeFieldInfoPtr_INVALID_DATA_TYPE, (void*) &invalidDataType);
        return invalidDataType;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(DataStore.NativeFieldInfoPtr_INVALID_DATA_TYPE, (void*) &value);
      }
    }

    public static unsafe ulong INVALID_PASSWORD
    {
      get
      {
        ulong invalidPassword;
        IL2CPP.il2cpp_field_static_get_value(DataStore.NativeFieldInfoPtr_INVALID_PASSWORD, (void*) &invalidPassword);
        return invalidPassword;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(DataStore.NativeFieldInfoPtr_INVALID_PASSWORD, (void*) &value);
      }
    }

    public static unsafe uint MAX_NAME_LENGTH
    {
      get
      {
        uint maxNameLength;
        IL2CPP.il2cpp_field_static_get_value(DataStore.NativeFieldInfoPtr_MAX_NAME_LENGTH, (void*) &maxNameLength);
        return maxNameLength;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(DataStore.NativeFieldInfoPtr_MAX_NAME_LENGTH, (void*) &value);
      }
    }

    public static unsafe uint MAX_SEARCH_RESULT_SIZE
    {
      get
      {
        uint searchResultSize;
        IL2CPP.il2cpp_field_static_get_value(DataStore.NativeFieldInfoPtr_MAX_SEARCH_RESULT_SIZE, (void*) &searchResultSize);
        return searchResultSize;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(DataStore.NativeFieldInfoPtr_MAX_SEARCH_RESULT_SIZE, (void*) &value);
      }
    }

    public static unsafe uint MAX_SEARCH_ANY_RESULT_SIZE
    {
      get
      {
        uint searchAnyResultSize;
        IL2CPP.il2cpp_field_static_get_value(DataStore.NativeFieldInfoPtr_MAX_SEARCH_ANY_RESULT_SIZE, (void*) &searchAnyResultSize);
        return searchAnyResultSize;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(DataStore.NativeFieldInfoPtr_MAX_SEARCH_ANY_RESULT_SIZE, (void*) &value);
      }
    }

    public static unsafe uint MAX_SEARCH_DATA_TYPE_SIZE
    {
      get
      {
        uint searchDataTypeSize;
        IL2CPP.il2cpp_field_static_get_value(DataStore.NativeFieldInfoPtr_MAX_SEARCH_DATA_TYPE_SIZE, (void*) &searchDataTypeSize);
        return searchDataTypeSize;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(DataStore.NativeFieldInfoPtr_MAX_SEARCH_DATA_TYPE_SIZE, (void*) &value);
      }
    }

    public static unsafe uint NUM_TAG_SLOT
    {
      get
      {
        uint numTagSlot;
        IL2CPP.il2cpp_field_static_get_value(DataStore.NativeFieldInfoPtr_NUM_TAG_SLOT, (void*) &numTagSlot);
        return numTagSlot;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(DataStore.NativeFieldInfoPtr_NUM_TAG_SLOT, (void*) &value);
      }
    }

    public static unsafe uint RATING_SLOT_MAX
    {
      get
      {
        uint ratingSlotMax;
        IL2CPP.il2cpp_field_static_get_value(DataStore.NativeFieldInfoPtr_RATING_SLOT_MAX, (void*) &ratingSlotMax);
        return ratingSlotMax;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(DataStore.NativeFieldInfoPtr_RATING_SLOT_MAX, (void*) &value);
      }
    }

    public static unsafe uint NUM_RATING_SLOT
    {
      get
      {
        uint numRatingSlot;
        IL2CPP.il2cpp_field_static_get_value(DataStore.NativeFieldInfoPtr_NUM_RATING_SLOT, (void*) &numRatingSlot);
        return numRatingSlot;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(DataStore.NativeFieldInfoPtr_NUM_RATING_SLOT, (void*) &value);
      }
    }

    public static unsafe uint MAX_TAG_LENGTH
    {
      get
      {
        uint maxTagLength;
        IL2CPP.il2cpp_field_static_get_value(DataStore.NativeFieldInfoPtr_MAX_TAG_LENGTH, (void*) &maxTagLength);
        return maxTagLength;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(DataStore.NativeFieldInfoPtr_MAX_TAG_LENGTH, (void*) &value);
      }
    }

    public static unsafe ushort DEFAULT_PERIOD
    {
      get
      {
        ushort defaultPeriod;
        IL2CPP.il2cpp_field_static_get_value(DataStore.NativeFieldInfoPtr_DEFAULT_PERIOD, (void*) &defaultPeriod);
        return defaultPeriod;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(DataStore.NativeFieldInfoPtr_DEFAULT_PERIOD, (void*) &value);
      }
    }

    public static unsafe uint DEFAULT_HTTP_THREAD_PRIORITY
    {
      get
      {
        uint httpThreadPriority;
        IL2CPP.il2cpp_field_static_get_value(DataStore.NativeFieldInfoPtr_DEFAULT_HTTP_THREAD_PRIORITY, (void*) &httpThreadPriority);
        return httpThreadPriority;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(DataStore.NativeFieldInfoPtr_DEFAULT_HTTP_THREAD_PRIORITY, (void*) &value);
      }
    }

    public static unsafe uint DEFAULT_RELAY_BUFFER_SIZE
    {
      get
      {
        uint defaultRelayBufferSize;
        IL2CPP.il2cpp_field_static_get_value(DataStore.NativeFieldInfoPtr_DEFAULT_RELAY_BUFFER_SIZE, (void*) &defaultRelayBufferSize);
        return defaultRelayBufferSize;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(DataStore.NativeFieldInfoPtr_DEFAULT_RELAY_BUFFER_SIZE, (void*) &value);
      }
    }

    public static unsafe uint DEFAULT_HTTP_BUFFER_SIZE
    {
      get
      {
        uint defaultHttpBufferSize;
        IL2CPP.il2cpp_field_static_get_value(DataStore.NativeFieldInfoPtr_DEFAULT_HTTP_BUFFER_SIZE, (void*) &defaultHttpBufferSize);
        return defaultHttpBufferSize;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(DataStore.NativeFieldInfoPtr_DEFAULT_HTTP_BUFFER_SIZE, (void*) &value);
      }
    }

    public static unsafe uint DEFAULT_DATA_TRANSFER_TIMEOUT_BYTES_PER_SECOND
    {
      get
      {
        uint timeoutBytesPerSecond;
        IL2CPP.il2cpp_field_static_get_value(DataStore.NativeFieldInfoPtr_DEFAULT_DATA_TRANSFER_TIMEOUT_BYTES_PER_SECOND, (void*) &timeoutBytesPerSecond);
        return timeoutBytesPerSecond;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(DataStore.NativeFieldInfoPtr_DEFAULT_DATA_TRANSFER_TIMEOUT_BYTES_PER_SECOND, (void*) &value);
      }
    }

    public static unsafe int DEFAULT_DATA_TRANSFER_MINIMUM_TIMEOUT
    {
      get
      {
        int transferMinimumTimeout;
        IL2CPP.il2cpp_field_static_get_value(DataStore.NativeFieldInfoPtr_DEFAULT_DATA_TRANSFER_MINIMUM_TIMEOUT, (void*) &transferMinimumTimeout);
        return transferMinimumTimeout;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(DataStore.NativeFieldInfoPtr_DEFAULT_DATA_TRANSFER_MINIMUM_TIMEOUT, (void*) &value);
      }
    }

    public static unsafe uint DEFAULT_HTTP_SEND_SOCKET_BUFFER_SIZE
    {
      get
      {
        uint socketBufferSize;
        IL2CPP.il2cpp_field_static_get_value(DataStore.NativeFieldInfoPtr_DEFAULT_HTTP_SEND_SOCKET_BUFFER_SIZE, (void*) &socketBufferSize);
        return socketBufferSize;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(DataStore.NativeFieldInfoPtr_DEFAULT_HTTP_SEND_SOCKET_BUFFER_SIZE, (void*) &value);
      }
    }

    public static unsafe uint DEFAULT_HTTP_RECV_SOCKET_BUFFER_SIZE
    {
      get
      {
        uint socketBufferSize;
        IL2CPP.il2cpp_field_static_get_value(DataStore.NativeFieldInfoPtr_DEFAULT_HTTP_RECV_SOCKET_BUFFER_SIZE, (void*) &socketBufferSize);
        return socketBufferSize;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(DataStore.NativeFieldInfoPtr_DEFAULT_HTTP_RECV_SOCKET_BUFFER_SIZE, (void*) &value);
      }
    }

    public static unsafe ushort INVALID_PERSISTENCE_SLOT_ID
    {
      get
      {
        ushort persistenceSlotId;
        IL2CPP.il2cpp_field_static_get_value(DataStore.NativeFieldInfoPtr_INVALID_PERSISTENCE_SLOT_ID, (void*) &persistenceSlotId);
        return persistenceSlotId;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(DataStore.NativeFieldInfoPtr_INVALID_PERSISTENCE_SLOT_ID, (void*) &value);
      }
    }

    public static unsafe ushort NUM_PERSISTENCE_SLOT
    {
      get
      {
        ushort numPersistenceSlot;
        IL2CPP.il2cpp_field_static_get_value(DataStore.NativeFieldInfoPtr_NUM_PERSISTENCE_SLOT, (void*) &numPersistenceSlot);
        return numPersistenceSlot;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(DataStore.NativeFieldInfoPtr_NUM_PERSISTENCE_SLOT, (void*) &value);
      }
    }

    public static unsafe uint BATCH_PROCESSING_CAPACITY_POST_OBJECT
    {
      get
      {
        uint capacityPostObject;
        IL2CPP.il2cpp_field_static_get_value(DataStore.NativeFieldInfoPtr_BATCH_PROCESSING_CAPACITY_POST_OBJECT, (void*) &capacityPostObject);
        return capacityPostObject;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(DataStore.NativeFieldInfoPtr_BATCH_PROCESSING_CAPACITY_POST_OBJECT, (void*) &value);
      }
    }

    public static unsafe uint BATCH_PROCESSING_CAPACITY
    {
      get
      {
        uint processingCapacity;
        IL2CPP.il2cpp_field_static_get_value(DataStore.NativeFieldInfoPtr_BATCH_PROCESSING_CAPACITY, (void*) &processingCapacity);
        return processingCapacity;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(DataStore.NativeFieldInfoPtr_BATCH_PROCESSING_CAPACITY, (void*) &value);
      }
    }

    public static unsafe ulong RESULTRANGE_ANY_OFFSET
    {
      get
      {
        ulong resultrangeAnyOffset;
        IL2CPP.il2cpp_field_static_get_value(DataStore.NativeFieldInfoPtr_RESULTRANGE_ANY_OFFSET, (void*) &resultrangeAnyOffset);
        return resultrangeAnyOffset;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(DataStore.NativeFieldInfoPtr_RESULTRANGE_ANY_OFFSET, (void*) &value);
      }
    }

    public static unsafe uint RESULTRANGE_DEFAULT_SIZE
    {
      get
      {
        uint resultrangeDefaultSize;
        IL2CPP.il2cpp_field_static_get_value(DataStore.NativeFieldInfoPtr_RESULTRANGE_DEFAULT_SIZE, (void*) &resultrangeDefaultSize);
        return resultrangeDefaultSize;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(DataStore.NativeFieldInfoPtr_RESULTRANGE_DEFAULT_SIZE, (void*) &value);
      }
    }

    public enum Permission
    {
      PERMISSION_PUBLIC,
      PERMISSION_FRIEND,
      PERMISSION_SPECIFIED,
      PERMISSION_PRIVATE,
      PERMISSION_SPECIFIED_FRIEND,
    }

    [Flags]
    public enum DataFlag
    {
      DATA_FLAG_NONE = 0,
      DATA_FLAG_NEED_REVIEW = 1,
      DATA_FLAG_PERIOD_FROM_LAST_REFERRED = 2,
      DATA_FLAG_USE_READ_LOCK = 4,
      DATA_FLAG_USE_NOTIFICATION_ON_POST = 8,
      DATA_FLAG_USE_NOTIFICATION_ON_UPDATE = 16, // 0x00000010
      DATA_FLAG_NOT_USE_FILESERVER = 32, // 0x00000020
      DATA_FLAG_NEED_COMPLETION = 64, // 0x00000040
    }

    [Flags]
    public enum ModificationFlag
    {
      MODIFICATION_FLAG_NONE = 0,
      MODIFICATION_FLAG_NAME = 1,
      MODIFICATION_FLAG_ACCESS_PERMISSION = 2,
      MODIFICATION_FLAG_UPDATE_PERMISSION = 4,
      MODIFICATION_FLAG_PERIOD = 8,
      MODIFICATION_FLAG_METABINARY = 16, // 0x00000010
      MODIFICATION_FLAG_TAGS = 32, // 0x00000020
      MODIFICATION_FLAG_UPDATED_TIME = 64, // 0x00000040
      MODIFICATION_FLAG_DATA_TYPE = 128, // 0x00000080
      MODIFICATION_FLAG_STATUS = 512, // 0x00000200
    }

    public enum DataStatus
    {
      DATA_STATUS_NONE = 0,
      DATA_STATUS_PENDING = 2,
      DATA_STATUS_REJECTED = 5,
    }

    [Flags]
    public enum ComparisonFlag
    {
      COMPARISON_FLAG_NONE = 0,
      COMPARISON_FLAG_NAME = 1,
      COMPARISON_FLAG_ACCESS_PERMISSION = 2,
      COMPARISON_FLAG_UPDATE_PERMISSION = 4,
      COMPARISON_FLAG_PERIOD = 8,
      COMPARISON_FLAG_METABINARY = 16, // 0x00000010
      COMPARISON_FLAG_TAGS = 32, // 0x00000020
      COMPARISON_FLAG_DATA_TYPE = 64, // 0x00000040
      COMPARISON_FLAG_STATUS = 256, // 0x00000100
      COMPARISON_FLAG_ALL = 65535, // 0x0000FFFF
    }

    public enum SearchType
    {
      SEARCH_TYPE_PUBLIC = 1,
      SEARCH_TYPE_SEND_FRIEND = 2,
      SEARCH_TYPE_SEND_SPECIFIED = 3,
      SEARCH_TYPE_SEND_SPECIFIED_FRIEND = 4,
      SEARCH_TYPE_SEND = 5,
      SEARCH_TYPE_FRIEND = 6,
      SEARCH_TYPE_RECEIVED_SPECIFIED = 7,
      SEARCH_TYPE_RECEIVED = 8,
      SEARCH_TYPE_PRIVATE = 9,
      SEARCH_TYPE_OWN = 10, // 0x0000000A
      SEARCH_TYPE_OWN_PENDING = 12, // 0x0000000C
      SEARCH_TYPE_OWN_REJECTED = 13, // 0x0000000D
      SEARCH_TYPE_OWN_ALL = 14, // 0x0000000E
    }

    public enum SearchTarget
    {
      SEARCH_TARGET_ANYBODY,
      SEARCH_TARGET_FRIEND,
    }

    public enum SearchSortColumn
    {
      SEARCH_SORT_COLUMN_DATAID = 0,
      SEARCH_SORT_COLUMN_CREATED_TIME = 5,
      SEARCH_SORT_COLUMN_UPDATED_TIME = 6,
      SEARCH_SORT_COLUMN_RATING0 = 64, // 0x00000040
      SEARCH_SORT_COLUMN_RATING1 = 65, // 0x00000041
      SEARCH_SORT_COLUMN_RATING2 = 66, // 0x00000042
      SEARCH_SORT_COLUMN_RATING3 = 67, // 0x00000043
      SEARCH_SORT_COLUMN_RATING4 = 68, // 0x00000044
      SEARCH_SORT_COLUMN_RATING5 = 69, // 0x00000045
      SEARCH_SORT_COLUMN_RATING6 = 70, // 0x00000046
      SEARCH_SORT_COLUMN_RATING7 = 71, // 0x00000047
      SEARCH_SORT_COLUMN_RATING8 = 72, // 0x00000048
      SEARCH_SORT_COLUMN_RATING9 = 73, // 0x00000049
      SEARCH_SORT_COLUMN_RATING10 = 74, // 0x0000004A
      SEARCH_SORT_COLUMN_RATING11 = 75, // 0x0000004B
      SEARCH_SORT_COLUMN_RATING12 = 76, // 0x0000004C
      SEARCH_SORT_COLUMN_RATING13 = 77, // 0x0000004D
      SEARCH_SORT_COLUMN_RATING14 = 78, // 0x0000004E
      SEARCH_SORT_COLUMN_RATING15 = 79, // 0x0000004F
      SEARCH_SORT_COLUMN_RATING_AVERAGE0 = 96, // 0x00000060
      SEARCH_SORT_COLUMN_RATING_AVERAGE1 = 97, // 0x00000061
      SEARCH_SORT_COLUMN_RATING_AVERAGE2 = 98, // 0x00000062
      SEARCH_SORT_COLUMN_RATING_AVERAGE3 = 99, // 0x00000063
      SEARCH_SORT_COLUMN_RATING_AVERAGE4 = 100, // 0x00000064
      SEARCH_SORT_COLUMN_RATING_AVERAGE5 = 101, // 0x00000065
      SEARCH_SORT_COLUMN_RATING_AVERAGE6 = 102, // 0x00000066
      SEARCH_SORT_COLUMN_RATING_AVERAGE7 = 103, // 0x00000067
      SEARCH_SORT_COLUMN_RATING_AVERAGE8 = 104, // 0x00000068
      SEARCH_SORT_COLUMN_RATING_AVERAGE9 = 105, // 0x00000069
      SEARCH_SORT_COLUMN_RATING_AVERAGE10 = 106, // 0x0000006A
      SEARCH_SORT_COLUMN_RATING_AVERAGE11 = 107, // 0x0000006B
      SEARCH_SORT_COLUMN_RATING_AVERAGE12 = 108, // 0x0000006C
      SEARCH_SORT_COLUMN_RATING_AVERAGE13 = 109, // 0x0000006D
      SEARCH_SORT_COLUMN_RATING_AVERAGE14 = 110, // 0x0000006E
      SEARCH_SORT_COLUMN_RATING_AVERAGE15 = 111, // 0x0000006F
    }

    public enum SearchSortOrder
    {
      SEARCH_SORT_ORDER_ASC,
      SEARCH_SORT_ORDER_DESC,
    }

    [Flags]
    public enum ResultFlag
    {
      RESULT_FLAG_TAGS = 1,
      RESULT_FLAG_RATINGS = 2,
      RESULT_FLAG_METABINARY = 4,
      RESULT_FLAG_PERMITTED_IDS = 8,
    }

    public enum RatingLockType
    {
      RATING_LOCK_NONE,
      RATING_LOCK_INTERVAL,
      RATING_LOCK_PERIOD,
      RATING_LOCK_PERMANENT,
    }

    public enum RatingFlag
    {
      RATING_FLAG_MODIFIABLE = 4,
      RATING_FLAG_ROUND_MINUS = 8,
      RATING_FLAG_DISABLE_SELF_RATING = 16, // 0x00000010
    }

    [Flags]
    public enum RatingInternalFlag
    {
      RATING_INTERNAL_FLAG_USE_RANGE_MIN = 2,
      RATING_INTERNAL_FLAG_USE_RANGE_MAX = 4,
    }

    public enum RatingLockPeriod
    {
      RATING_LOCK_PERIOD_DAY1 = -17, // 0xFFFFFFEF
      RATING_LOCK_PERIOD_SUN = -7, // 0xFFFFFFF9
      RATING_LOCK_PERIOD_SAT = -6, // 0xFFFFFFFA
      RATING_LOCK_PERIOD_FRI = -5, // 0xFFFFFFFB
      RATING_LOCK_PERIOD_THU = -4, // 0xFFFFFFFC
      RATING_LOCK_PERIOD_WED = -3, // 0xFFFFFFFD
      RATING_LOCK_PERIOD_TUE = -2, // 0xFFFFFFFE
      RATING_LOCK_PERIOD_MON = -1, // 0xFFFFFFFF
    }

    public enum SearchResultTotalCountType
    {
      SEARCH_RESULT_TOTAL_EXACT,
      SEARCH_RESULT_TOTAL_MINIMUM,
      SEARCH_RESULT_TOTAL_ESTIMATE,
      SEARCH_RESULT_TOTAL_DISABLED,
    }
  }
}
