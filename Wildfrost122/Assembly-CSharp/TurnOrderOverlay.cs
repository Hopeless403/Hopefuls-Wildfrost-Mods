// Decompiled with JetBrains decompiler
// Type: TurnOrderOverlay
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
public class TurnOrderOverlay : MonoBehaviour
{
  [SerializeField]
  private GameObject overlay;
  [SerializeField]
  private GameObject button;
  [SerializeField]
  private TMP_Text numberPrefab;
  private List<TMP_Text> numbers;

  private void OnEnable()
  {
    global::Events.OnBattlePhaseStart += new UnityAction<Battle.Phase>(this.BattlePhaseStart);
  }

  private void OnDisable()
  {
    global::Events.OnBattlePhaseStart -= new UnityAction<Battle.Phase>(this.BattlePhaseStart);
  }

  private void BattlePhaseStart(Battle.Phase phase)
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
