// Decompiled with JetBrains decompiler
// Type: StatsSaveData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 488825E8-55A3-40B4-9121-88EE5E56834E
// Assembly location: C:\Users\harri\Downloads\Wildfrost\Wildfrost\steamapps\common\Wildfrost\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
[Serializable]
public class StatsSaveData : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr_playTime;
  private static readonly System.IntPtr NativeFieldInfoPtr_gamesPlayed;
  private static readonly System.IntPtr NativeFieldInfoPtr_wins;
  private static readonly System.IntPtr NativeFieldInfoPtr_trueWins;
  private static readonly System.IntPtr NativeFieldInfoPtr_cardsPlayed;
  private static readonly System.IntPtr NativeFieldInfoPtr_kills;
  private static readonly System.IntPtr NativeFieldInfoPtr_bossesKilled;
  private static readonly System.IntPtr NativeFieldInfoPtr_damageDealt;
  private static readonly System.IntPtr NativeFieldInfoPtr_damageTaken;
  private static readonly System.IntPtr NativeFieldInfoPtr_highestDamageHit;
  private static readonly System.IntPtr NativeFieldInfoPtr_battlesWon;
  private static readonly System.IntPtr NativeFieldInfoPtr_goldGained;
  private static readonly System.IntPtr NativeFieldInfoPtr_goldSpent;
  private static readonly System.IntPtr NativeFieldInfoPtr_quickestBattleWin;
  private static readonly System.IntPtr NativeFieldInfoPtr_bestScore;
  private static readonly System.IntPtr NativeFieldInfoPtr_bestTime;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(1959)]
  [CachedScanResults(RefRangeStart = 13288, RefRangeEnd = 15247, XrefRangeStart = 13288, XrefRangeEnd = 15247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe StatsSaveData()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatsSaveData>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(StatsSaveData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static StatsSaveData()
  {
    Il2CppClassPointerStore<StatsSaveData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (StatsSaveData));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatsSaveData>.NativeClassPtr);
    StatsSaveData.NativeFieldInfoPtr_playTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatsSaveData>.NativeClassPtr, nameof (playTime));
    StatsSaveData.NativeFieldInfoPtr_gamesPlayed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatsSaveData>.NativeClassPtr, nameof (gamesPlayed));
    StatsSaveData.NativeFieldInfoPtr_wins = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatsSaveData>.NativeClassPtr, nameof (wins));
    StatsSaveData.NativeFieldInfoPtr_trueWins = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatsSaveData>.NativeClassPtr, nameof (trueWins));
    StatsSaveData.NativeFieldInfoPtr_cardsPlayed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatsSaveData>.NativeClassPtr, nameof (cardsPlayed));
    StatsSaveData.NativeFieldInfoPtr_kills = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatsSaveData>.NativeClassPtr, nameof (kills));
    StatsSaveData.NativeFieldInfoPtr_bossesKilled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatsSaveData>.NativeClassPtr, nameof (bossesKilled));
    StatsSaveData.NativeFieldInfoPtr_damageDealt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatsSaveData>.NativeClassPtr, nameof (damageDealt));
    StatsSaveData.NativeFieldInfoPtr_damageTaken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatsSaveData>.NativeClassPtr, nameof (damageTaken));
    StatsSaveData.NativeFieldInfoPtr_highestDamageHit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatsSaveData>.NativeClassPtr, nameof (highestDamageHit));
    StatsSaveData.NativeFieldInfoPtr_battlesWon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatsSaveData>.NativeClassPtr, nameof (battlesWon));
    StatsSaveData.NativeFieldInfoPtr_goldGained = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatsSaveData>.NativeClassPtr, nameof (goldGained));
    StatsSaveData.NativeFieldInfoPtr_goldSpent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatsSaveData>.NativeClassPtr, nameof (goldSpent));
    StatsSaveData.NativeFieldInfoPtr_quickestBattleWin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatsSaveData>.NativeClassPtr, nameof (quickestBattleWin));
    StatsSaveData.NativeFieldInfoPtr_bestScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatsSaveData>.NativeClassPtr, nameof (bestScore));
    StatsSaveData.NativeFieldInfoPtr_bestTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatsSaveData>.NativeClassPtr, nameof (bestTime));
    StatsSaveData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatsSaveData>.NativeClassPtr, 100672691);
  }

  public StatsSaveData(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe float playTime
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatsSaveData.NativeFieldInfoPtr_playTime));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatsSaveData.NativeFieldInfoPtr_playTime)) = value;
    }
  }

  public unsafe int gamesPlayed
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatsSaveData.NativeFieldInfoPtr_gamesPlayed));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatsSaveData.NativeFieldInfoPtr_gamesPlayed)) = value;
    }
  }

  public unsafe int wins
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatsSaveData.NativeFieldInfoPtr_wins));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatsSaveData.NativeFieldInfoPtr_wins)) = value;
    }
  }

  public unsafe int trueWins
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatsSaveData.NativeFieldInfoPtr_trueWins));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatsSaveData.NativeFieldInfoPtr_trueWins)) = value;
    }
  }

  public unsafe int cardsPlayed
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatsSaveData.NativeFieldInfoPtr_cardsPlayed));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatsSaveData.NativeFieldInfoPtr_cardsPlayed)) = value;
    }
  }

  public unsafe int kills
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatsSaveData.NativeFieldInfoPtr_kills));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatsSaveData.NativeFieldInfoPtr_kills)) = value;
    }
  }

  public unsafe int bossesKilled
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatsSaveData.NativeFieldInfoPtr_bossesKilled));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatsSaveData.NativeFieldInfoPtr_bossesKilled)) = value;
    }
  }

  public unsafe int damageDealt
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatsSaveData.NativeFieldInfoPtr_damageDealt));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatsSaveData.NativeFieldInfoPtr_damageDealt)) = value;
    }
  }

  public unsafe int damageTaken
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatsSaveData.NativeFieldInfoPtr_damageTaken));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatsSaveData.NativeFieldInfoPtr_damageTaken)) = value;
    }
  }

  public unsafe int highestDamageHit
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatsSaveData.NativeFieldInfoPtr_highestDamageHit));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatsSaveData.NativeFieldInfoPtr_highestDamageHit)) = value;
    }
  }

  public unsafe int battlesWon
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatsSaveData.NativeFieldInfoPtr_battlesWon));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatsSaveData.NativeFieldInfoPtr_battlesWon)) = value;
    }
  }

  public unsafe int goldGained
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatsSaveData.NativeFieldInfoPtr_goldGained));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatsSaveData.NativeFieldInfoPtr_goldGained)) = value;
    }
  }

  public unsafe int goldSpent
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatsSaveData.NativeFieldInfoPtr_goldSpent));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatsSaveData.NativeFieldInfoPtr_goldSpent)) = value;
    }
  }

  public unsafe float quickestBattleWin
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatsSaveData.NativeFieldInfoPtr_quickestBattleWin));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatsSaveData.NativeFieldInfoPtr_quickestBattleWin)) = value;
    }
  }

  public unsafe int bestScore
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatsSaveData.NativeFieldInfoPtr_bestScore));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatsSaveData.NativeFieldInfoPtr_bestScore)) = value;
    }
  }

  public unsafe float bestTime
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatsSaveData.NativeFieldInfoPtr_bestTime));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatsSaveData.NativeFieldInfoPtr_bestTime)) = value;
    }
  }
}
