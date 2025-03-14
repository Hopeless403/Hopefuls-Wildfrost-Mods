﻿// Decompiled with JetBrains decompiler
// Type: BuildingDisplay
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;
using UnityEngine.Events;

public class BuildingDisplay : MonoBehaviour
{
  [SerializeField]
  public UnityEvent onEnable;
  [SerializeField]
  public UnityEvent onDisable;
  [SerializeField]
  public int setSiblingIndex = 1;
  [SerializeField]
  public HelpPanelShower helpShower;
  public GameObject current;

  public void Create(GameObject prefab, Building building)
  {
    this.gameObject.SetActive(true);
    this.current = Object.Instantiate<GameObject>(prefab, this.transform);
    this.current.transform.SetSiblingIndex(this.setSiblingIndex);
    this.current.GetComponent<BuildingSequence>()?.Play(building);
    this.onEnable.Invoke();
    this.SetHelp(building.type);
  }

  public void SetHelp(BuildingType buildingType)
  {
    if (buildingType.helpKey.IsEmpty)
    {
      this.helpShower.gameObject.SetActive(false);
    }
    else
    {
      this.helpShower.gameObject.SetActive(true);
      this.helpShower.SetKey(buildingType.helpKey, new Prompt.Emote.Type?(buildingType.helpEmoteType));
    }
  }

  public void End()
  {
    this.current.GetComponent<BuildingSequence>()?.building?.RunUpdateEvent();
    this.current.Destroy();
    this.current = (GameObject) null;
    this.gameObject.SetActive(false);
    this.onDisable.Invoke();
  }
}
