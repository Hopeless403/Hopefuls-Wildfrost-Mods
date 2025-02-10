// Decompiled with JetBrains decompiler
// Type: Pokefrost.Furret
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using Deadpan.Enums.Engine.Components.Modding;
using HarmonyLib;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Pokefrost
{
  internal class Furret
  {
    [HarmonyPatch(typeof (InjuredCompanionEventSystem), "CampaignLoadPreset")]
    public class FurretCompanionEventSystem1
    {
      internal static bool Prefix(ref string[] lines)
      {
        string path = Path.Combine(Pokefrost.Pokefrost.instance.ModDirectory, "furret.txt");
        if (Campaign.Data.GameMode.mainGameMode && !Campaign.Data.GameMode.tutorialRun && File.Exists(path))
        {
          Debug.Log((object) "[Pokefrost] Adding Furret To Injured Companion Event");
          string[] strArray = File.ReadAllLines(path);
          int result;
          if (strArray.Length > 3 && int.TryParse(strArray[2], out result))
          {
            int num = result;
            int startIndex = num >= 6 ? 23 : (num >= 3 ? 11 : 2);
            lines[0] = lines[0].Insert(startIndex, "#");
            lines[1] = lines[1].Insert(startIndex, " ");
            lines[2] = lines[2].Insert(startIndex, lines[2][startIndex - 1].ToString());
            lines[3] = lines[3].Insert(startIndex, lines[3][startIndex - 1].ToString());
            return false;
          }
        }
        return true;
      }
    }

    [HarmonyPatch(typeof (InjuredCompanionEventSystem), "GetEligibleCompanions")]
    public class FurretCompanionEventSystem2
    {
      internal static bool Prefix(ref List<CardSaveData> __result)
      {
        string path = Path.Combine(Pokefrost.Pokefrost.instance.ModDirectory, "furret.txt");
        if (!File.Exists(path))
          return true;
        string[] strArray = File.ReadAllLines(path);
        if (strArray.Length <= 4)
          return true;
        CardData cardData = Pokefrost.Pokefrost.instance.Get<CardData>("furret").Clone();
        cardData.forceTitle = strArray[0].Trim();
        cardData.startWithEffects = new CardData.StatusEffectStacks[0];
        for (int index = 5; index < strArray.Length; ++index)
        {
          CardUpgradeData cardUpgradeData = Pokefrost.Pokefrost.instance.Get<CardUpgradeData>(strArray[index].Trim());
          if ((Object) cardUpgradeData != (Object) null && cardUpgradeData.CanAssign(cardData))
            cardUpgradeData.Clone().Assign(cardData);
        }
        CardUpgradeData cardUpgradeData1 = Pokefrost.Pokefrost.instance.Get<CardUpgradeData>("CardUpgradeRemoveCharmLimit");
        if (cardUpgradeData1.CanAssign(cardData))
          cardUpgradeData1.Clone().Assign(cardData);
        List<CardUpgradeData> group = AddressableLoader.GetGroup<CardUpgradeData>("CardUpgradeData");
        int num = Dead.Random.Range(20, 25);
        Debug.Log((object) ("[Pokefrost] Furret rolled " + num.ToString() + " charms"));
        for (int index1 = 0; index1 < num; ++index1)
        {
          int index2 = Dead.Random.Range(0, group.Count - 1);
          CardUpgradeData cardUpgradeData2 = group[index2].Clone();
          if (cardUpgradeData2.CanAssign(cardData) && cardUpgradeData2.tier > 0 && cardUpgradeData2.name != "CardUpgradeMuncher")
            cardUpgradeData2.Assign(cardData);
        }
        if (strArray[4].Trim() == "Hasty")
          Pokefrost.Pokefrost.instance.Shinify(cardData);
        __result = new List<CardSaveData>()
        {
          cardData.Save()
        };
        return false;
      }
    }

    [HarmonyPatch(typeof (EventRoutineInjuredCompanion), "Populate")]
    public class FurretCompanionEventSystem3
    {
      internal static IEnumerator Postfix(IEnumerator __result)
      {
        yield return (object) __result;
        string fileName = Path.Combine(Pokefrost.Pokefrost.instance.ModDirectory, "furret.txt");
        if (File.Exists(fileName))
        {
          string[] furretData = File.ReadAllLines(fileName);
          GameObject furretPanel = UICollector.PullPrefab("Box", "FurretBox", GameObject.Find("Canvas/SafeArea/EventManager/Event-InjuredCompanion(Clone)/EnterTweener/Zoomer/Inspect Companion/"));
          furretPanel.GetComponent<RectTransform>().sizeDelta = new Vector2(5f, 3f);
          furretPanel.transform.localPosition = new Vector3(5.3f, 1.9f, 0.0f);
          Sprite sprite = Pokefrost.Pokefrost.instance.ImagePath("FurretPanel.png").ToSprite();
          Debug.Log((object) "[Pokefrost] Made Sprite");
          Image image = furretPanel.GetComponent<Image>();
          if ((Object) image == (Object) null)
            Debug.Log((object) "[Pokefrost] Image null");
          Debug.Log((object) "[Pokefrost] Made Image");
          image.sprite = sprite;
          GameObject furretText = new GameObject("Paneltext");
          furretText.transform.SetParent(furretPanel.transform, false);
          TextMeshProUGUI text = furretText.AddComponent<TextMeshProUGUI>();
          furretText.GetComponent<RectTransform>().sizeDelta = new Vector2(4.5f, 2f);
          text.alignment = TextAlignmentOptions.Top;
          text.text = "<color=#FF8>" + furretData[1] + "'s</color> <color=#940>" + furretData[0] + "</color> is back!\n<color=#888><size=0.2>" + furretData[0] + " has been missing since " + furretData[3] + "</size></color>";
          File.Delete(fileName);
          furretData = (string[]) null;
          furretPanel = (GameObject) null;
          sprite = (Sprite) null;
          image = (Image) null;
          furretText = (GameObject) null;
          text = (TextMeshProUGUI) null;
        }
      }
    }
  }
}
