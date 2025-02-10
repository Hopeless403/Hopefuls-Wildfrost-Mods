// Decompiled with JetBrains decompiler
// Type: Pokefrost.EvolutionPopUp
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using Deadpan.Enums.Engine.Components.Modding;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Localization;
using UnityEngine.Localization.Tables;
using UnityEngine.UI;

#nullable disable
namespace Pokefrost
{
  internal static class EvolutionPopUp
  {
    public static List<CardData> evolvedPokemonLastBattle = new List<CardData>(3);
    public static List<CardData> pokemonEvolvedIntoLastBattle = new List<CardData>(3);
    private static bool WaitingToPopUp = false;
    public static List<GameObject> silhouettes = new List<GameObject>();
    public static string EvoTitleKey1A = "websiteofsites.wildfrost.pokefrost.evo_title1a";
    public static string EvoTitleKey1B = "websiteofsites.wildfrost.pokefrost.evo_title1b";
    public static string EvoTitleKey2A = "websiteofsites.wildfrost.pokefrost.evo_title2a";
    public static string EvoTitleKey2B = "websiteofsites.wildfrost.pokefrost.evo_title2b";
    public static string EvoObserve = "websiteofsites.wildfrost.pokefrost.evo_observe";
    public static StringTable stringTable;
    private static CardFramesUnlockedSequence sequence;
    private static TextMeshProUGUI titleObject;
    private static Button continueButton;
    private static GameObject fader;
    private static int eventProgress = 0;
    private static bool startClosingSequence = false;
    private static LeanTweenType silTweenType = LeanTweenType.linear;
    private static float duration = 0.5f;
    private static float overlap = 0.2f;
    private static Vector3 translate = new Vector3(0.0f, -3f, 0.0f);
    private static Vector3 translate2 = new Vector3(0.0f, -0.5f, 0.0f);
    private static float fadeInDur = 0.75f;
    private static LeanTweenType fadeInType = LeanTweenType.easeInCubic;
    private static float hold = 0.25f;
    private static float fadeOutDur = 0.3f;
    private static LeanTweenType fadeOutType = LeanTweenType.easeOutCubic;
    private static float frequency = 0.05f;
    private static float endDelay = 0.3f;
    private static Vector3 gap = new Vector3(0.4f, 0.0f, 0.0f);

    private static WildfrostMod mod => (WildfrostMod) Pokefrost.Pokefrost.instance;

    private static void AddCommands()
    {
      Console.commands.Add((Console.Command) new CommandFillEvolves());
      Console.commands.Add((Console.Command) new CommandFillEvolveDebug1());
    }

    public static IEnumerator DelayedRun()
    {
      if (!EvolutionPopUp.WaitingToPopUp)
      {
        EvolutionPopUp.WaitingToPopUp = true;
        yield return (object) new WaitUntil((Func<bool>) (() => SceneManager.IsLoaded("MapNew") && !PickupRoutine.Active));
        ActionSequence action = new ActionSequence(EvolutionPopUp.Run());
        ActionQueue.Add((PlayAction) action);
        EvolutionPopUp.WaitingToPopUp = false;
      }
    }

    public static IEnumerator Run()
    {
      if (EvolutionPopUp.evolvedPokemonLastBattle.Count != 0)
      {
        EvolutionPopUp.stringTable = LocalizationHelper.GetCollection("UI Text", (LocaleIdentifier) SystemLanguage.English);
        EvolutionPopUp.eventProgress = 0;
        yield return (object) SceneManager.WaitUntilUnloaded("CardFramesUnlocked");
        yield return (object) SceneManager.Load("CardFramesUnlocked", SceneType.Temporary);
        EvolutionPopUp.sequence = UnityEngine.Object.FindObjectOfType<CardFramesUnlockedSequence>();
        EvolutionPopUp.sequence.container1.transform.Translate(EvolutionPopUp.translate2);
        EvolutionPopUp.titleObject = EvolutionPopUp.sequence.GetComponentInChildren<TextMeshProUGUI>(true);
        EvolutionPopUp.fader = UICollector.PullPrefab("Box", "Fader", EvolutionPopUp.sequence.gameObject);
        EvolutionPopUp.fader.GetComponent<Image>().color = new Color(1f, 1f, 1f, 0.0f);
        EvolutionPopUp.fader.SetActive(false);
        Button back = EvolutionPopUp.sequence.group.GetComponentInChildren<Button>();
        back.onClick.SetPersistentListenerState(0, UnityEventCallState.Off);
        back.onClick.AddListener((UnityAction) (() => EvolutionPopUp.End()));
        yield return (object) new WaitForSeconds(0.3f);
        GameObject obj = UICollector.PullPrefab("Button", "Continue Button", EvolutionPopUp.sequence.gameObject);
        obj.transform.position = EvolutionPopUp.translate;
        EvolutionPopUp.continueButton = obj.GetComponentInChildren<Button>();
        EvolutionPopUp.continueButton.onClick.SetPersistentListenerState(0, UnityEventCallState.Off);
        EvolutionPopUp.continueButton.onClick.AddListener(new UnityAction(EvolutionPopUp.ProgressEvent));
        EvolutionPopUp.fader.transform.SetAsLastSibling();
        yield return (object) EvolutionPopUp.Preevos();
        yield return (object) new WaitUntil((Func<bool>) (() => EvolutionPopUp.eventProgress > 0));
        if (EvolutionPopUp.eventProgress == 1)
        {
          EvolutionPopUp.fader.SetActive(true);
          yield return (object) new WaitForSeconds(EvolutionPopUp.duration - EvolutionPopUp.overlap);
          EvolutionPopUp.BackgroundFade(0.0f, 1f, EvolutionPopUp.fadeInDur, EvolutionPopUp.fadeInType);
          yield return (object) new WaitForSeconds(EvolutionPopUp.fadeInDur);
          yield return (object) EvolutionPopUp.Evos();
          SfxSystem.OneShot("event:/sfx/inventory/charm_assign");
          EvolutionPopUp.continueButton.gameObject.SetActive(false);
          yield return (object) new WaitForSeconds(EvolutionPopUp.hold);
          EvolutionPopUp.BackgroundFade(1f, 0.0f, EvolutionPopUp.fadeOutDur, EvolutionPopUp.fadeOutType);
          yield return (object) new WaitForSeconds(EvolutionPopUp.fadeOutDur);
          EvolutionPopUp.fader.SetActive(false);
          Pokefrost.Pokefrost.fx.TryPlaySound("evolution");
        }
        yield return (object) new WaitUntil((Func<bool>) (() => EvolutionPopUp.eventProgress > 1));
        if (EvolutionPopUp.eventProgress == 2)
        {
          Routine.Clump clump = new Routine.Clump();
          for (int i = EvolutionPopUp.sequence.container1.Count - 1; i >= 0; --i)
          {
            clump.Add(new Routine(AssetLoader.Lookup<CardAnimation>("CardAnimations", "FlyToBackpack").Routine((object) EvolutionPopUp.sequence.container1[i])));
            yield return (object) new WaitForSeconds(EvolutionPopUp.frequency);
          }
          yield return (object) clump.WaitForEnd();
          yield return (object) new WaitForSeconds(EvolutionPopUp.endDelay);
          clump = (Routine.Clump) null;
        }
        EvolutionPopUp.evolvedPokemonLastBattle.Clear();
        EvolutionPopUp.pokemonEvolvedIntoLastBattle.Clear();
        EvolutionPopUp.sequence.End();
      }
    }

    public static void End()
    {
      if (EvolutionPopUp.eventProgress == 0)
      {
        EvolutionPopUp.eventProgress = 3;
      }
      else
      {
        if (EvolutionPopUp.eventProgress != 1)
          return;
        EvolutionPopUp.eventProgress = 2;
      }
    }

    public static void MoveCardToDeck(Entity entity)
    {
      global::Events.InvokeEntityEnterBackpack(entity);
      entity.transform.parent = References.Player.entity.display.transform;
      entity.display?.hover?.Disable();
      Routine routine = new Routine(AssetLoader.Lookup<CardAnimation>("CardAnimations", "FlyToBackpack").Routine((object) entity));
    }

    public static IEnumerator Preevos()
    {
      if (EvolutionPopUp.evolvedPokemonLastBattle.Count == 1)
      {
        string preEvo = EvolutionPopUp.evolvedPokemonLastBattle[0].title;
        string evo = EvolutionPopUp.pokemonEvolvedIntoLastBattle[0].title;
        EvolutionPopUp.titleObject.fontSize = 0.55f;
        string text = EvolutionPopUp.stringTable.GetString(EvolutionPopUp.EvoTitleKey1A).GetLocalizedString();
        EvolutionPopUp.titleObject.text = string.Format(text, (object) preEvo);
        preEvo = (string) null;
        evo = (string) null;
        text = (string) null;
      }
      else
      {
        string text = EvolutionPopUp.stringTable.GetString(EvolutionPopUp.EvoTitleKey1B).GetLocalizedString();
        EvolutionPopUp.titleObject.text = string.Format(text, (object) EvolutionPopUp.evolvedPokemonLastBattle.Count);
        text = (string) null;
      }
      yield return (object) EvolutionPopUp.CreateCardsAlt(EvolutionPopUp.evolvedPokemonLastBattle);
      string text2 = EvolutionPopUp.stringTable.GetString(EvolutionPopUp.EvoObserve).GetLocalizedString();
      EvolutionPopUp.continueButton.GetComponentInChildren<TextMeshProUGUI>().SetText(text2);
    }

    public static IEnumerator Evos()
    {
      if (EvolutionPopUp.evolvedPokemonLastBattle.Count == 1)
      {
        string preEvo = EvolutionPopUp.evolvedPokemonLastBattle[0].title;
        string evo = Pokefrost.Pokefrost.instance.Get<CardData>(EvolutionPopUp.pokemonEvolvedIntoLastBattle[0].name)?.title ?? EvolutionPopUp.pokemonEvolvedIntoLastBattle[0].name;
        string text = EvolutionPopUp.stringTable.GetString(EvolutionPopUp.EvoTitleKey2A).GetLocalizedString();
        EvolutionPopUp.titleObject.text = string.Format(text, (object) preEvo, (object) evo);
        preEvo = (string) null;
        evo = (string) null;
        text = (string) null;
      }
      else
      {
        string text = EvolutionPopUp.stringTable.GetString(EvolutionPopUp.EvoTitleKey2B).GetLocalizedString();
        EvolutionPopUp.titleObject.text = string.Format(text, (object) EvolutionPopUp.pokemonEvolvedIntoLastBattle.Count);
        text = (string) null;
      }
      EvolutionPopUp.sequence.container1.ClearAndDestroyAllImmediately();
      yield return (object) EvolutionPopUp.CreateCardsAlt(EvolutionPopUp.pokemonEvolvedIntoLastBattle, true);
    }

    public static IEnumerator CreateCardsAlt(List<CardData> cards, bool flipped = false)
    {
      EvolutionPopUp.sequence.SetScaleAndPosition(cards.Count);
      Routine.Clump clump = new Routine.Clump();
      int num = Math.Min(cards.Count, 4);
      EvolutionPopUp.sequence.container1.gap = EvolutionPopUp.gap;
      EvolutionPopUp.sequence.container1.SetSize(num, 0.8f);
      foreach (CardData card in cards)
        clump.Add(EvolutionPopUp.sequence.CreateCard(card, (CardContainer) EvolutionPopUp.sequence.container1, flipped));
      yield return (object) clump.WaitForEnd();
      EvolutionPopUp.sequence.group.SetActive(true);
      EvolutionPopUp.sequence.container1.SetChildPositions();
    }

    public static void ProgressEvent()
    {
      ++EvolutionPopUp.eventProgress;
      EvolutionPopUp.continueButton.interactable = false;
    }

    public static void BackgroundFade(float from, float to, float dur, LeanTweenType type)
    {
      LeanTween.cancel(EvolutionPopUp.fader);
      LeanTween.value(EvolutionPopUp.fader, from, to, dur).setEase(type).setOnUpdate((Action<float>) (a => EvolutionPopUp.fader.GetComponent<Image>().color = Color.white.WithAlpha(a)));
    }
  }
}
