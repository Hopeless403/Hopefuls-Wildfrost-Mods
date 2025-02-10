// Decompiled with JetBrains decompiler
// Type: CombineCardSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

#nullable disable
public class CombineCardSystem : GameSystem
{
  [SerializeField]
  private string combineSceneName;
  [SerializeField]
  private CombineCardSystem.Combo[] combos;

  private void OnEnable()
  {
    global::Events.OnEntityEnterBackpack += new UnityAction<Entity>(this.EntityEnterBackpack);
  }

  private void OnDisable()
  {
    global::Events.OnEntityEnterBackpack -= new UnityAction<Entity>(this.EntityEnterBackpack);
  }

  private void EntityEnterBackpack(Entity entity)
  {
    foreach (CombineCardSystem.Combo combo in this.combos)
    {
      if (combo.cardNames.Contains<string>(entity.data.name) && combo.AllCardsInDeck(References.PlayerData.inventory.deck))
      {
        this.StopAllCoroutines();
        this.StartCoroutine(this.CombineSequence(combo));
        break;
      }
    }
  }

  private IEnumerator CombineSequence(CombineCardSystem.Combo combo)
  {
    CombineCardSequence combineSequence = (CombineCardSequence) null;
    yield return (object) SceneManager.Load(this.combineSceneName, SceneType.Temporary, (Action<Scene>) (scene => combineSequence = scene.FindObjectOfType<CombineCardSequence>()));
    if ((bool) (UnityEngine.Object) combineSequence)
      yield return (object) combineSequence.Run(combo.cardNames, combo.resultingCardName);
    yield return (object) SceneManager.Unload(this.combineSceneName);
  }

  [Serializable]
  public struct Combo
  {
    public string[] cardNames;
    public string resultingCardName;

    public bool AllCardsInDeck(CardDataList deck)
    {
      bool flag = true;
      foreach (string cardName in this.cardNames)
      {
        if (!this.HasCard(cardName, deck))
        {
          flag = false;
          break;
        }
      }
      return flag;
    }

    private bool HasCard(string cardName, CardDataList deck)
    {
      foreach (UnityEngine.Object @object in deck)
      {
        if (@object.name == cardName)
          return true;
      }
      return false;
    }
  }
}
