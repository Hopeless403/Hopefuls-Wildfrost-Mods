// Decompiled with JetBrains decompiler
// Type: BattleVictorySequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections;
using UnityEngine;

public class BattleVictorySequence : MonoBehaviour
{
  public CanvasGroup fade;
  public float fadeTime = 0.5f;
  public Transform rewardContainer;
  public CardContainer injuredContainer;
  public RectTransform injuredPanel;
  [SerializeField]
  private float startDelay;
  [SerializeField]
  private GameObject winLayout;
  [SerializeField]
  private GameObject injuriesLayout;
  [SerializeField]
  private GameObject[] disableGapsForInjuries;
  [SerializeField]
  private GameObject continueLayout;
  private bool active;

  public IEnumerator Run()
  {
    BattleVictorySequence battleVictorySequence = this;
    battleVictorySequence.active = true;
    yield return (object) new WaitForSeconds(battleVictorySequence.startDelay);
    battleVictorySequence.winLayout.SetActive(true);
    yield return (object) new WaitForSeconds(0.75f);
    yield return (object) battleVictorySequence.RevealInjuries();
    battleVictorySequence.continueLayout.SetActive(true);
    // ISSUE: reference to a compiler-generated method
    yield return (object) new WaitUntil(new Func<bool>(battleVictorySequence.\u003CRun\u003Eb__11_0));
  }

  private IEnumerator RevealInjuries()
  {
    CardData[] injuriesThisBattle = InjurySystem.GetInjuriesThisBattle();
    if (injuriesThisBattle != null && injuriesThisBattle.Length > 0)
    {
      SfxSystem.OneShot("event:/sfx/ui/injuries_showup");
      this.injuredContainer.SetSize(injuriesThisBattle.Length, 0.6f);
      CardData[] cardDataArray = injuriesThisBattle;
      for (int index = 0; index < cardDataArray.Length; ++index)
      {
        Card card = CardManager.Get(cardDataArray[index], (CardController) null, (Character) null, false, true);
        this.injuredContainer.Add(card.entity);
        yield return (object) card.UpdateData(false);
      }
      cardDataArray = (CardData[]) null;
      this.injuredPanel.sizeDelta = this.injuredContainer.GetComponent<RectTransform>().sizeDelta + new Vector2(6f, 1.5f);
      this.injuredContainer.SetChildPositions();
      foreach (GameObject disableGapsForInjury in this.disableGapsForInjuries)
        disableGapsForInjury.SetActive(false);
      this.injuriesLayout.SetActive(true);
      yield return (object) new WaitForSeconds(0.75f);
    }
  }

  private bool CharacterDeckpackOpen(Character character)
  {
    bool flag = false;
    if ((UnityEngine.Object) character.entity?.display != (UnityEngine.Object) null && character.entity.display is CharacterDisplay display)
      flag = display.IsDeckpackOpen;
    return flag;
  }

  public void End() => this.active = false;
}
