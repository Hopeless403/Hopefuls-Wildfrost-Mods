// Decompiled with JetBrains decompiler
// Type: References
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Linq;
using UnityEngine;

public class References : MonoBehaviourSingleton<References>
{
  public static PlayerData PlayerData;
  public static Character Player;
  public static MapNew Map;
  public static Campaign Campaign;
  public static Battle Battle;
  public ClassData[] classes;
  public AreaData[] areas;
  public HardModeModifierData[] hardModeModifiers;
  public static Transform _minibossCameraMover;
  public const string DefaultGameModeName = "GameModeNormal";
  public const string TutorialGameModeName = "GameModeTutorial";

  public static CardData LeaderData => References.PlayerData.inventory.deck.First<CardData>((Func<CardData, bool>) (a => a.cardType.miniboss));

  public static ClassData[] Classes => MonoBehaviourSingleton<References>.instance.classes;

  public static AreaData[] Areas => MonoBehaviourSingleton<References>.instance.areas;

  public static Transform MinibossCameraMover
  {
    get
    {
      if ((bool) (UnityEngine.Object) References._minibossCameraMover)
        return References._minibossCameraMover;
      GameObject withTag = GameObject.FindWithTag("MinibossCameraTransform");
      if (withTag != null)
        References._minibossCameraMover = withTag.transform;
      return References._minibossCameraMover;
    }
  }

  public static AreaData GetCurrentArea() => References.Areas[Campaign.FindCharacterNode(References.Player).areaIndex];
}
