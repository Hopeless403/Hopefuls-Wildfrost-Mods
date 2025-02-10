// Decompiled with JetBrains decompiler
// Type: BattleVictorySequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BattleVictorySequence : MonoBehaviour
{
  public CanvasGroup fade;
  public float fadeTime = 0.5f;
  public Transform rewardContainer;
  public CardContainer injuredContainer;
  public RectTransform injuredPanel;
  [SerializeField]
  public float startDelay;
  [SerializeField]
  public GameObject winLayout;
  [SerializeField]
  public GameObject injuriesLayout;
  [SerializeField]
  public GameObject[] disableGapsForInjuries;
  [SerializeField]
  public GameObject continueLayout;
  public bool active;

  public IEnumerator Run()
  {
    BattleVictorySequence battleVictorySequence = this;
    battleVictorySequence.active = true;
    yield return (object) new WaitForSeconds(battleVictorySequence.startDelay);
    battleVictorySequence.winLayout.SetActive(true);
    yield return (object) new WaitForSeconds(0.75f);
    yield return (object) battleVictorySequence.RevealInjuries();
    battleVictorySequence.continueLayout.SetActive(true);
    yield return (object) new WaitUntil(new Func<bool>(battleVictorySequence.\u003CRun\u003Eb__11_0));
  }

  public IEnumerator RevealInjuries()
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

  public bool CharacterDeckpackOpen(Character character)
  {
    bool flag = false;
    if ((UnityEngine.Object) character.entity?.display != (UnityEngine.Object) null && character.entity.display is CharacterDisplay display)
      flag = display.IsDeckpackOpen;
    return flag;
  }

  public void End() => this.active = false;

  [CompilerGenerated]
  public bool \u003CRun\u003Eb__11_0() => !this.active;
}
