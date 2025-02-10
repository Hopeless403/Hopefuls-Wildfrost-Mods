// Decompiled with JetBrains decompiler
// Type: TurnOrderOverlay
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class TurnOrderOverlay : MonoBehaviour
{
  [SerializeField]
  public GameObject overlay;
  [SerializeField]
  public GameObject button;
  [SerializeField]
  public TMP_Text numberPrefab;
  public List<TMP_Text> numbers;

  public void OnEnable() => global::Events.OnBattlePhaseStart += new UnityAction<Battle.Phase>(this.BattlePhaseStart);

  public void OnDisable() => global::Events.OnBattlePhaseStart -= new UnityAction<Battle.Phase>(this.BattlePhaseStart);

  public void BattlePhaseStart(Battle.Phase phase)
  {
    switch (phase)
    {
      case Battle.Phase.Play:
        this.button.SetActive(true);
        break;
      case Battle.Phase.Battle:
      case Battle.Phase.End:
        this.button.SetActive(false);
        break;
    }
  }

  public void Toggle()
  {
    if (this.overlay.activeSelf)
      this.Deactivate();
    else
      this.Activate();
  }

  public void Activate()
  {
    this.overlay.SetActive(true);
    HashSet<Entity> allUnits = Battle.GetAllUnits();
    int num = 1;
    if (this.numbers == null)
      this.numbers = new List<TMP_Text>();
    foreach (Entity entity in allUnits)
    {
      TMP_Text tmpText = Object.Instantiate<TMP_Text>(this.numberPrefab, this.overlay.transform);
      tmpText.transform.localPosition = entity.transform.position;
      tmpText.text = num.ToString();
      tmpText.gameObject.SetActive(true);
      this.numbers.Add(tmpText);
      ++num;
    }
  }

  public void Deactivate()
  {
    foreach (Component number in this.numbers)
      number.gameObject.Destroy();
    this.numbers = (List<TMP_Text>) null;
    this.overlay.SetActive(false);
  }
}
