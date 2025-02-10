// Decompiled with JetBrains decompiler
// Type: Pokefrost.QuestSystem
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using Deadpan.Enums.Engine.Components.Modding;
using UnityEngine;
using UnityEngine.Localization;

#nullable disable
namespace Pokefrost
{
  public abstract class QuestSystem : GameSystem
  {
    public int progress = 0;
    public static string Key_GeneralFail = "websiteofsites.wildfrost.pokefrost.generalquestfailed";

    public virtual string ProgressName => "Quest";

    public virtual string GetFailureText(string key)
    {
      return LocalizationHelper.GetCollection("UI Text", (LocaleIdentifier) SystemLanguage.English).GetString(key).GetLocalizedString();
    }

    [PokeLocalizer]
    public static void DefineStrings()
    {
      LocalizationHelper.GetCollection("UI Text", (LocaleIdentifier) SystemLanguage.English).SetString(QuestSystem.Key_GeneralFail, "Conditions not met...");
    }

    public virtual void UpdateProgress(int value)
    {
      this.progress = value;
      EventSaveSystem.Add(this.ProgressName, value);
    }

    public virtual void FindProgress()
    {
      int num = EventSaveSystem.Get(this.ProgressName);
      if (num != -1)
        this.progress = num;
      else
        this.UpdateProgress(this.progress);
    }

    public abstract bool CheckConditions(out string failureText);

    public virtual void QuestBattleStart()
    {
    }

    public virtual void QuestBattleFinish()
    {
    }
  }
}
