// Decompiled with JetBrains decompiler
// Type: CombineCardSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

#nullable disable
public class CombineCardSystem : GameSystem
{
  [SerializeField]
  public string combineSceneName;
  [SerializeField]
  public CombineCardSystem.Combo[] combos;

  public void OnEnable()
  {
    global::Events.OnEntityEnterBackpack += new UnityAction<Entity>(this.EntityEnterBackpack);
  }

  public void OnDisable()
  {
    global::Events.OnEntityEnterBackpack -= new UnityAction<Entity>(this.EntityEnterBackpack);
  }

  public void EntityEnterBackpack(Entity entity)
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

  public IEnumerator CombineSequence(CombineCardSystem.Combo combo)
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

    public bool HasCard(string cardName, CardDataList deck)
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
