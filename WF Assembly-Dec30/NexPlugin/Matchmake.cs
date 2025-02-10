// Decompiled with JetBrains decompiler
// Type: NexPlugin.Matchmake
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Runtime;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace NexPlugin
{
  public static class Matchmake : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_INVALID_GATHERINGID;
    private static readonly System.IntPtr NativeFieldInfoPtr_NUM_MATCHMAKE_SESSION_ATTRIBUTES;
    private static readonly System.IntPtr NativeFieldInfoPtr_MATCHMAKE_SESSION_NEAREST_NEIGHBOR_ATTRIBUTE_INDEX;
    private static readonly System.IntPtr NativeFieldInfoPtr_MATCHMAKE_SESSION_BROADEN_RANGE_ATTRIBUTE_INDEX;
    private static readonly System.IntPtr NativeFieldInfoPtr_INVALID_PERSISTENT_GATHERING_CODE;
    private static readonly System.IntPtr NativeFieldInfoPtr_PERSISTENT_GATHERING_CREATION_MAX;
    private static readonly System.IntPtr NativeFieldInfoPtr_PERSISTENT_GATHERING_PARTICIPATION_MAX;
    private static readonly System.IntPtr NativeFieldInfoPtr_PERSISTENT_GATHERING_CHAT_PARTICIPANTS_MAX;
    private static readonly System.IntPtr NativeFieldInfoPtr_SETATTIBUTE_VECTOR_SIZE_MAX;
    private static readonly System.IntPtr NativeFieldInfoPtr_MAX_PROGRESS_SCORE;
    private static readonly System.IntPtr NativeFieldInfoPtr_UPDATE_PROGRESS_SCORE_MINIMUM_INTERVAL_TIME;
    private static readonly System.IntPtr NativeFieldInfoPtr_MAX_MATCHMAKE_SESSION_USER_PASSWORD_LENGTH;
    private static readonly System.IntPtr NativeFieldInfoPtr_MATCHMAKE_SESSION_SYSTEM_PASSWORD_LENGTH;
    private static readonly System.IntPtr NativeFieldInfoPtr_MAX_MATCHMAKE_BROWSE_SIZE;
    private static readonly System.IntPtr NativeFieldInfoPtr_MAX_PRINCIPALID_SIZE_TO_FIND_MATCHMAKE_SESSION;
    private static readonly System.IntPtr NativeFieldInfoPtr_MAX_MATCHMAKE_BROWSE_SIZE_BY_PARTICIPANT;
    private static readonly System.IntPtr NativeFieldInfoPtr_MAX_MATCHMAKE_SESSION_BY_PARTICIPANT;
    private static readonly System.IntPtr NativeFieldInfoPtr_MAX_EXTRA_PARTICIPANTS;
    private static readonly System.IntPtr NativeFieldInfoPtr_MAX_P2P_SIGNATURE_KEY_LEN;
    private static readonly System.IntPtr NativeFieldInfoPtr_RESULTRANGE_ANY_OFFSET;
    private static readonly System.IntPtr NativeFieldInfoPtr_MATCHMAKE_STRING_MAX_LENGTH;
    private static readonly System.IntPtr NativeFieldInfoPtr_MATCHMAKE_BUFFER_MAX_LENGTH;

    static Matchmake()
    {
      Il2CppClassPointerStore<Matchmake>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NexPlugin", nameof (Matchmake));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Matchmake>.NativeClassPtr);
      Matchmake.NativeFieldInfoPtr_INVALID_GATHERINGID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Matchmake>.NativeClassPtr, nameof (INVALID_GATHERINGID));
      Matchmake.NativeFieldInfoPtr_NUM_MATCHMAKE_SESSION_ATTRIBUTES = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Matchmake>.NativeClassPtr, nameof (NUM_MATCHMAKE_SESSION_ATTRIBUTES));
      Matchmake.NativeFieldInfoPtr_MATCHMAKE_SESSION_NEAREST_NEIGHBOR_ATTRIBUTE_INDEX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Matchmake>.NativeClassPtr, nameof (MATCHMAKE_SESSION_NEAREST_NEIGHBOR_ATTRIBUTE_INDEX));
      Matchmake.NativeFieldInfoPtr_MATCHMAKE_SESSION_BROADEN_RANGE_ATTRIBUTE_INDEX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Matchmake>.NativeClassPtr, nameof (MATCHMAKE_SESSION_BROADEN_RANGE_ATTRIBUTE_INDEX));
      Matchmake.NativeFieldInfoPtr_INVALID_PERSISTENT_GATHERING_CODE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Matchmake>.NativeClassPtr, nameof (INVALID_PERSISTENT_GATHERING_CODE));
      Matchmake.NativeFieldInfoPtr_PERSISTENT_GATHERING_CREATION_MAX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Matchmake>.NativeClassPtr, nameof (PERSISTENT_GATHERING_CREATION_MAX));
      Matchmake.NativeFieldInfoPtr_PERSISTENT_GATHERING_PARTICIPATION_MAX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Matchmake>.NativeClassPtr, nameof (PERSISTENT_GATHERING_PARTICIPATION_MAX));
      Matchmake.NativeFieldInfoPtr_PERSISTENT_GATHERING_CHAT_PARTICIPANTS_MAX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Matchmake>.NativeClassPtr, nameof (PERSISTENT_GATHERING_CHAT_PARTICIPANTS_MAX));
      Matchmake.NativeFieldInfoPtr_SETATTIBUTE_VECTOR_SIZE_MAX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Matchmake>.NativeClassPtr, nameof (SETATTIBUTE_VECTOR_SIZE_MAX));
      Matchmake.NativeFieldInfoPtr_MAX_PROGRESS_SCORE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Matchmake>.NativeClassPtr, nameof (MAX_PROGRESS_SCORE));
      Matchmake.NativeFieldInfoPtr_UPDATE_PROGRESS_SCORE_MINIMUM_INTERVAL_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Matchmake>.NativeClassPtr, nameof (UPDATE_PROGRESS_SCORE_MINIMUM_INTERVAL_TIME));
      Matchmake.NativeFieldInfoPtr_MAX_MATCHMAKE_SESSION_USER_PASSWORD_LENGTH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Matchmake>.NativeClassPtr, nameof (MAX_MATCHMAKE_SESSION_USER_PASSWORD_LENGTH));
      Matchmake.NativeFieldInfoPtr_MATCHMAKE_SESSION_SYSTEM_PASSWORD_LENGTH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Matchmake>.NativeClassPtr, nameof (MATCHMAKE_SESSION_SYSTEM_PASSWORD_LENGTH));
      Matchmake.NativeFieldInfoPtr_MAX_MATCHMAKE_BROWSE_SIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Matchmake>.NativeClassPtr, nameof (MAX_MATCHMAKE_BROWSE_SIZE));
      Matchmake.NativeFieldInfoPtr_MAX_PRINCIPALID_SIZE_TO_FIND_MATCHMAKE_SESSION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Matchmake>.NativeClassPtr, nameof (MAX_PRINCIPALID_SIZE_TO_FIND_MATCHMAKE_SESSION));
      Matchmake.NativeFieldInfoPtr_MAX_MATCHMAKE_BROWSE_SIZE_BY_PARTICIPANT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Matchmake>.NativeClassPtr, nameof (MAX_MATCHMAKE_BROWSE_SIZE_BY_PARTICIPANT));
      Matchmake.NativeFieldInfoPtr_MAX_MATCHMAKE_SESSION_BY_PARTICIPANT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Matchmake>.NativeClassPtr, nameof (MAX_MATCHMAKE_SESSION_BY_PARTICIPANT));
      Matchmake.NativeFieldInfoPtr_MAX_EXTRA_PARTICIPANTS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Matchmake>.NativeClassPtr, nameof (MAX_EXTRA_PARTICIPANTS));
      Matchmake.NativeFieldInfoPtr_MAX_P2P_SIGNATURE_KEY_LEN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Matchmake>.NativeClassPtr, nameof (MAX_P2P_SIGNATURE_KEY_LEN));
      Matchmake.NativeFieldInfoPtr_RESULTRANGE_ANY_OFFSET = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Matchmake>.NativeClassPtr, nameof (RESULTRANGE_ANY_OFFSET));
      Matchmake.NativeFieldInfoPtr_MATCHMAKE_STRING_MAX_LENGTH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Matchmake>.NativeClassPtr, nameof (MATCHMAKE_STRING_MAX_LENGTH));
      Matchmake.NativeFieldInfoPtr_MATCHMAKE_BUFFER_MAX_LENGTH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Matchmake>.NativeClassPtr, nameof (MATCHMAKE_BUFFER_MAX_LENGTH));
    }

    public Matchmake(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe uint INVALID_GATHERINGID
    {
      get
      {
        uint invalidGatheringid;
        IL2CPP.il2cpp_field_static_get_value(Matchmake.NativeFieldInfoPtr_INVALID_GATHERINGID, (void*) &invalidGatheringid);
        return invalidGatheringid;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Matchmake.NativeFieldInfoPtr_INVALID_GATHERINGID, (void*) &value);
      }
    }

    public static unsafe uint NUM_MATCHMAKE_SESSION_ATTRIBUTES
    {
      get
      {
        uint sessionAttributes;
        IL2CPP.il2cpp_field_static_get_value(Matchmake.NativeFieldInfoPtr_NUM_MATCHMAKE_SESSION_ATTRIBUTES, (void*) &sessionAttributes);
        return sessionAttributes;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Matchmake.NativeFieldInfoPtr_NUM_MATCHMAKE_SESSION_ATTRIBUTES, (void*) &value);
      }
    }

    public static unsafe uint MATCHMAKE_SESSION_NEAREST_NEIGHBOR_ATTRIBUTE_INDEX
    {
      get
      {
        uint neighborAttributeIndex;
        IL2CPP.il2cpp_field_static_get_value(Matchmake.NativeFieldInfoPtr_MATCHMAKE_SESSION_NEAREST_NEIGHBOR_ATTRIBUTE_INDEX, (void*) &neighborAttributeIndex);
        return neighborAttributeIndex;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Matchmake.NativeFieldInfoPtr_MATCHMAKE_SESSION_NEAREST_NEIGHBOR_ATTRIBUTE_INDEX, (void*) &value);
      }
    }

    public static unsafe uint MATCHMAKE_SESSION_BROADEN_RANGE_ATTRIBUTE_INDEX
    {
      get
      {
        uint rangeAttributeIndex;
        IL2CPP.il2cpp_field_static_get_value(Matchmake.NativeFieldInfoPtr_MATCHMAKE_SESSION_BROADEN_RANGE_ATTRIBUTE_INDEX, (void*) &rangeAttributeIndex);
        return rangeAttributeIndex;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Matchmake.NativeFieldInfoPtr_MATCHMAKE_SESSION_BROADEN_RANGE_ATTRIBUTE_INDEX, (void*) &value);
      }
    }

    public static unsafe ulong INVALID_PERSISTENT_GATHERING_CODE
    {
      get
      {
        ulong persistentGatheringCode;
        IL2CPP.il2cpp_field_static_get_value(Matchmake.NativeFieldInfoPtr_INVALID_PERSISTENT_GATHERING_CODE, (void*) &persistentGatheringCode);
        return persistentGatheringCode;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Matchmake.NativeFieldInfoPtr_INVALID_PERSISTENT_GATHERING_CODE, (void*) &value);
      }
    }

    public static unsafe uint PERSISTENT_GATHERING_CREATION_MAX
    {
      get
      {
        uint gatheringCreationMax;
        IL2CPP.il2cpp_field_static_get_value(Matchmake.NativeFieldInfoPtr_PERSISTENT_GATHERING_CREATION_MAX, (void*) &gatheringCreationMax);
        return gatheringCreationMax;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Matchmake.NativeFieldInfoPtr_PERSISTENT_GATHERING_CREATION_MAX, (void*) &value);
      }
    }

    public static unsafe uint PERSISTENT_GATHERING_PARTICIPATION_MAX
    {
      get
      {
        uint participationMax;
        IL2CPP.il2cpp_field_static_get_value(Matchmake.NativeFieldInfoPtr_PERSISTENT_GATHERING_PARTICIPATION_MAX, (void*) &participationMax);
        return participationMax;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Matchmake.NativeFieldInfoPtr_PERSISTENT_GATHERING_PARTICIPATION_MAX, (void*) &value);
      }
    }

    public static unsafe ulong PERSISTENT_GATHERING_CHAT_PARTICIPANTS_MAX
    {
      get
      {
        ulong chatParticipantsMax;
        IL2CPP.il2cpp_field_static_get_value(Matchmake.NativeFieldInfoPtr_PERSISTENT_GATHERING_CHAT_PARTICIPANTS_MAX, (void*) &chatParticipantsMax);
        return chatParticipantsMax;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Matchmake.NativeFieldInfoPtr_PERSISTENT_GATHERING_CHAT_PARTICIPANTS_MAX, (void*) &value);
      }
    }

    public static unsafe uint SETATTIBUTE_VECTOR_SIZE_MAX
    {
      get
      {
        uint setattibuteVectorSizeMax;
        IL2CPP.il2cpp_field_static_get_value(Matchmake.NativeFieldInfoPtr_SETATTIBUTE_VECTOR_SIZE_MAX, (void*) &setattibuteVectorSizeMax);
        return setattibuteVectorSizeMax;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Matchmake.NativeFieldInfoPtr_SETATTIBUTE_VECTOR_SIZE_MAX, (void*) &value);
      }
    }

    public static unsafe byte MAX_PROGRESS_SCORE
    {
      get
      {
        byte maxProgressScore;
        IL2CPP.il2cpp_field_static_get_value(Matchmake.NativeFieldInfoPtr_MAX_PROGRESS_SCORE, (void*) &maxProgressScore);
        return maxProgressScore;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Matchmake.NativeFieldInfoPtr_MAX_PROGRESS_SCORE, (void*) &value);
      }
    }

    public static unsafe uint UPDATE_PROGRESS_SCORE_MINIMUM_INTERVAL_TIME
    {
      get
      {
        uint minimumIntervalTime;
        IL2CPP.il2cpp_field_static_get_value(Matchmake.NativeFieldInfoPtr_UPDATE_PROGRESS_SCORE_MINIMUM_INTERVAL_TIME, (void*) &minimumIntervalTime);
        return minimumIntervalTime;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Matchmake.NativeFieldInfoPtr_UPDATE_PROGRESS_SCORE_MINIMUM_INTERVAL_TIME, (void*) &value);
      }
    }

    public static unsafe uint MAX_MATCHMAKE_SESSION_USER_PASSWORD_LENGTH
    {
      get
      {
        uint userPasswordLength;
        IL2CPP.il2cpp_field_static_get_value(Matchmake.NativeFieldInfoPtr_MAX_MATCHMAKE_SESSION_USER_PASSWORD_LENGTH, (void*) &userPasswordLength);
        return userPasswordLength;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Matchmake.NativeFieldInfoPtr_MAX_MATCHMAKE_SESSION_USER_PASSWORD_LENGTH, (void*) &value);
      }
    }

    public static unsafe uint MATCHMAKE_SESSION_SYSTEM_PASSWORD_LENGTH
    {
      get
      {
        uint systemPasswordLength;
        IL2CPP.il2cpp_field_static_get_value(Matchmake.NativeFieldInfoPtr_MATCHMAKE_SESSION_SYSTEM_PASSWORD_LENGTH, (void*) &systemPasswordLength);
        return systemPasswordLength;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Matchmake.NativeFieldInfoPtr_MATCHMAKE_SESSION_SYSTEM_PASSWORD_LENGTH, (void*) &value);
      }
    }

    public static unsafe uint MAX_MATCHMAKE_BROWSE_SIZE
    {
      get
      {
        uint matchmakeBrowseSize;
        IL2CPP.il2cpp_field_static_get_value(Matchmake.NativeFieldInfoPtr_MAX_MATCHMAKE_BROWSE_SIZE, (void*) &matchmakeBrowseSize);
        return matchmakeBrowseSize;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Matchmake.NativeFieldInfoPtr_MAX_MATCHMAKE_BROWSE_SIZE, (void*) &value);
      }
    }

    public static unsafe uint MAX_PRINCIPALID_SIZE_TO_FIND_MATCHMAKE_SESSION
    {
      get
      {
        uint matchmakeSession;
        IL2CPP.il2cpp_field_static_get_value(Matchmake.NativeFieldInfoPtr_MAX_PRINCIPALID_SIZE_TO_FIND_MATCHMAKE_SESSION, (void*) &matchmakeSession);
        return matchmakeSession;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Matchmake.NativeFieldInfoPtr_MAX_PRINCIPALID_SIZE_TO_FIND_MATCHMAKE_SESSION, (void*) &value);
      }
    }

    public static unsafe uint MAX_MATCHMAKE_BROWSE_SIZE_BY_PARTICIPANT
    {
      get
      {
        uint sizeByParticipant;
        IL2CPP.il2cpp_field_static_get_value(Matchmake.NativeFieldInfoPtr_MAX_MATCHMAKE_BROWSE_SIZE_BY_PARTICIPANT, (void*) &sizeByParticipant);
        return sizeByParticipant;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Matchmake.NativeFieldInfoPtr_MAX_MATCHMAKE_BROWSE_SIZE_BY_PARTICIPANT, (void*) &value);
      }
    }

    public static unsafe uint MAX_MATCHMAKE_SESSION_BY_PARTICIPANT
    {
      get
      {
        uint sessionByParticipant;
        IL2CPP.il2cpp_field_static_get_value(Matchmake.NativeFieldInfoPtr_MAX_MATCHMAKE_SESSION_BY_PARTICIPANT, (void*) &sessionByParticipant);
        return sessionByParticipant;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Matchmake.NativeFieldInfoPtr_MAX_MATCHMAKE_SESSION_BY_PARTICIPANT, (void*) &value);
      }
    }

    public static unsafe uint MAX_EXTRA_PARTICIPANTS
    {
      get
      {
        uint extraParticipants;
        IL2CPP.il2cpp_field_static_get_value(Matchmake.NativeFieldInfoPtr_MAX_EXTRA_PARTICIPANTS, (void*) &extraParticipants);
        return extraParticipants;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Matchmake.NativeFieldInfoPtr_MAX_EXTRA_PARTICIPANTS, (void*) &value);
      }
    }

    public static unsafe uint MAX_P2P_SIGNATURE_KEY_LEN
    {
      get
      {
        uint pSignatureKeyLen;
        IL2CPP.il2cpp_field_static_get_value(Matchmake.NativeFieldInfoPtr_MAX_P2P_SIGNATURE_KEY_LEN, (void*) &pSignatureKeyLen);
        return pSignatureKeyLen;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Matchmake.NativeFieldInfoPtr_MAX_P2P_SIGNATURE_KEY_LEN, (void*) &value);
      }
    }

    public static unsafe ulong RESULTRANGE_ANY_OFFSET
    {
      get
      {
        ulong resultrangeAnyOffset;
        IL2CPP.il2cpp_field_static_get_value(Matchmake.NativeFieldInfoPtr_RESULTRANGE_ANY_OFFSET, (void*) &resultrangeAnyOffset);
        return resultrangeAnyOffset;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Matchmake.NativeFieldInfoPtr_RESULTRANGE_ANY_OFFSET, (void*) &value);
      }
    }

    public static unsafe uint MATCHMAKE_STRING_MAX_LENGTH
    {
      get
      {
        uint matchmakeStringMaxLength;
        IL2CPP.il2cpp_field_static_get_value(Matchmake.NativeFieldInfoPtr_MATCHMAKE_STRING_MAX_LENGTH, (void*) &matchmakeStringMaxLength);
        return matchmakeStringMaxLength;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Matchmake.NativeFieldInfoPtr_MATCHMAKE_STRING_MAX_LENGTH, (void*) &value);
      }
    }

    public static unsafe uint MATCHMAKE_BUFFER_MAX_LENGTH
    {
      get
      {
        uint matchmakeBufferMaxLength;
        IL2CPP.il2cpp_field_static_get_value(Matchmake.NativeFieldInfoPtr_MATCHMAKE_BUFFER_MAX_LENGTH, (void*) &matchmakeBufferMaxLength);
        return matchmakeBufferMaxLength;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Matchmake.NativeFieldInfoPtr_MATCHMAKE_BUFFER_MAX_LENGTH, (void*) &value);
      }
    }

    public enum MatchmakeGeoIpResult
    {
      MATCHMAKE_GEO_IP_RESULT_INVALID,
      MATCHMAKE_GEO_IP_RESULT_FOUND,
      MATCHMAKE_GEO_IP_RESULT_NOT_FOUND,
      MATCHMAKE_GEO_IP_RESULT_UNUSED,
    }

    public enum MatchmakeSystemType
    {
      MATCHMAKE_SYSTEM_TYPE_INVALID = 0,
      MATCHMAKE_SYSTEM_TYPE_ANYBODY = 1,
      MATCHMAKE_SYSTEM_TYPE_PERSISTENT_GATHERING = 5,
    }

    public enum MatchmakeSelectionMethod
    {
      MATCHMAKE_SELECTION_METHOD_RANDOM,
      MATCHMAKE_SELECTION_METHOD_NEAREST_NEIGHBOR,
      MATCHMAKE_SELECTION_METHOD_BROADEN_RANGE,
      MATCHMAKE_SELECTION_METHOD_PROGRESS_SCORE,
      MATCHMAKE_SELECTION_METHOD_BROADEN_RANGE_WITH_PROGRESS_SCORE,
      MATCHMAKE_SELECTION_METHOD_SCORE_BASED,
    }

    [Flags]
    public enum GatheringFlags
    {
      Nothing = 0,
      MigrateOwner = 16, // 0x00000010
      NoPersistentParticipation = 64, // 0x00000040
      AllowNoParticipant = 128, // 0x00000080
      ChangeOwnerByOtherHost = 512, // 0x00000200
      NotifyParticipationEventsToAllParticipants = 1024, // 0x00000400
      NotifyParticipationEventsToAllParticipantsReproducibly = 2048, // 0x00000800
    }

    [Flags]
    public enum MatchmakeSessionOption0 : long
    {
      MATCHMAKE_SESSION_OPTION0_NONE = 0,
      MATCHMAKE_SESSION_OPTION0_FORCE_AUTOMATCH_DELAY = 1,
      MATCHMAKE_SESSION_OPTION0_FORCE_AUTOMATCH_NODELAY = 2,
    }

    public enum MatchmakeOption
    {
      MATCHMAKE_OPTION_NONE,
      MATCHMAKE_OPTION_RECORD_LAST_GID_FOR_PARTICIPATION_CHECK,
      MATCHMAKE_OPTION_RESERVED_1,
    }

    public enum AutoMatchmakeOption
    {
      AUTO_MATCHMAKE_OPTION_NONE,
      AUTO_MATCHMAKE_OPTION_RECORD_LAST_GID_FOR_PARTICIPATION_CHECK,
      AUTO_MATCHMAKE_OPTION_UNIQUE_GATHERING_BY_CODEWORD,
    }

    public enum JoinMatchmakeSessionBehavior
    {
      JOIN_MATCHMAKE_SESSION_BEHAVIOR_JOIN_MYSELF,
      JOIN_MATCHMAKE_SESSION_BEHAVIOR_IM_ALREADY_JOINED,
    }

    [Flags]
    public enum FindMatchmakeSessionResultOption
    {
      FIND_MATCHMAKESESSION_RESULT_OPTION_NONE = 0,
      FIND_MATCHMAKESESSION_RESULT_OPTION_APPLICATION_BUFFER = 1,
      FIND_MATCHMAKESESSION_RESULT_OPTION_MATCHMAKE_PARAM = 2,
    }

    public enum PersistentGatheringType
    {
      Open,
      PasswordLocked,
      Official,
    }

    [Flags]
    public enum MatchmakeSessionModificationFlag
    {
      MATCHMAKE_SESSION_MODIFICATION_FLAG_NONE = 0,
      MATCHMAKE_SESSION_MODIFICATION_FLAG_ATTRIBUTES = 1,
      MATCHMAKE_SESSION_MODIFICATION_FLAG_OPEN_PARTICIPATION = 2,
      MATCHMAKE_SESSION_MODIFICATION_FLAG_APPLICATION_BUFFER = 4,
      MATCHMAKE_SESSION_MODIFICATION_FLAG_PROGRESS_SCORE = 8,
      MATCHMAKE_SESSION_MODIFICATION_FLAG_OPTION0 = 16, // 0x00000010
      MATCHMAKE_SESSION_MODIFICATION_FLAG_MATCHMAKE_PARAM = 32, // 0x00000020
      MATCHMAKE_SESSION_MODIFICATION_FLAG_MATCHMAKE_PARAM_OVERRIDE = 64, // 0x00000040
      MATCHMAKE_SESSION_MODIFICATION_FLAG_STARTED_TIME = 128, // 0x00000080
      MATCHMAKE_SESSION_MODIFICATION_FLAG_USER_PASSWORD = 256, // 0x00000100
      MATCHMAKE_SESSION_MODIFICATION_FLAG_GAME_MODE = 512, // 0x00000200
      MATCHMAKE_SESSION_MODIFICATION_FLAG_DESCRIPTION = 1024, // 0x00000400
      MATCHMAKE_SESSION_MODIFICATION_FLAG_MIN_PARTICIPANTS = 2048, // 0x00000800
      MATCHMAKE_SESSION_MODIFICATION_FLAG_MAX_PARTICIPANTS = 4096, // 0x00001000
      MATCHMAKE_SESSION_MODIFICATION_FLAG_MATCHMAKE_SYSTEM_TYPE = 8192, // 0x00002000
      MATCHMAKE_SESSION_MODIFICATION_FLAG_CODEWORD = 16384, // 0x00004000
    }

    public enum AnybodyParticipationPolicyArgument
    {
      WithoutClose,
      CloseOnOwnerMigration,
    }
  }
}
