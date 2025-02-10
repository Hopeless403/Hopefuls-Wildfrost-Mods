// Decompiled with JetBrains decompiler
// Type: BuildingDisplay
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.Events;

public class BuildingDisplay : MonoBehaviour
{
  [SerializeField]
  private UnityEvent onEnable;
  [SerializeField]
  private UnityEvent onDisable;
  [SerializeField]
  private int setSiblingIndex = 1;
  [SerializeField]
  private HelpPanelShower helpShower;
  private GameObject current;

  public void Create(GameObject prefab, Building building)
  {
    this.gameObject.SetActive(true);
    this.current = Object.Instantiate<GameObject>(prefab, this.transform);
    this.current.transform.SetSiblingIndex(this.setSiblingIndex);
    this.current.GetComponent<BuildingSequence>()?.Play(building);
    this.onEnable.Invoke();
    this.SetHelp(building.type);
  }

  private void SetHelp(BuildingType buildingType)
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
