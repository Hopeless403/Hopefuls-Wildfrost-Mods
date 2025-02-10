// Decompiled with JetBrains decompiler
// Type: ModifierSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
public class ModifierSystem : GameSystem
{
  public void OnEnable()
  {
    global::Events.OnCampaignInit += new global::Events.RoutineAction(ModifierSystem.RunInitScripts);
    global::Events.OnCampaignStart += new UnityAction(ModifierSystem.AddSystems);
    global::Events.OnCampaignLoaded += new UnityAction(ModifierSystem.AddSystems);
    global::Events.OnCampaignGenerated += new global::Events.AsyncAction(this.RunStartScripts);
  }

  public void OnDisable()
  {
    global::Events.OnCampaignInit -= new global::Events.RoutineAction(ModifierSystem.RunInitScripts);
    global::Events.OnCampaignStart -= new UnityAction(ModifierSystem.AddSystems);
    global::Events.OnCampaignLoaded -= new UnityAction(ModifierSystem.AddSystems);
    global::Events.OnCampaignGenerated -= new global::Events.AsyncAction(this.RunStartScripts);
  }

  public static void AddModifier(CampaignData data, GameModifierData modifier)
  {
    CampaignData campaignData = data;
    if (campaignData.Modifiers == null)
    {
      List<GameModifierData> gameModifierDataList;
      campaignData.Modifiers = gameModifierDataList = new List<GameModifierData>();
    }
    data.Modifiers.Add(modifier);
  }

  public static void RemoveModifier(CampaignData data, GameModifierData modifier)
  {
    data.Modifiers?.Remove(modifier);
  }

  public static void AddSystems()
  {
    if (Campaign.Data.Modifiers == null)
      return;
    foreach (GameModifierData gameModifierData in (IEnumerable<GameModifierData>) Campaign.Data.Modifiers.OrderByDescending<GameModifierData, int>((Func<GameModifierData, int>) (m => m.scriptPriority)))
    {
      foreach (string str in gameModifierData.systemsToAdd)
      {
        if (Campaign.instance.systems.GetComponent(str) is GameSystem component)
        {
          Debug.Log((object) string.Format("[{0}] enabling system: {1}", (object) gameModifierData, (object) component));
          component.enabled = true;
        }
        else
        {
          Debug.Log((object) string.Format("[{0}] adding system: {1}", (object) gameModifierData, (object) str));
          Campaign.instance.systems.AddComponentByName(str);
        }
      }
    }
  }

  public static IEnumerator RunInitScripts()
  {
    return ModifierSystem.RunInitScripts((IReadOnlyCollection<GameModifierData>) Campaign.Data.Modifiers);
  }

  public async Task RunStartScripts()
  {
    ModifierSystem modifierSystem = this;
    Routine routine = new Routine(ModifierSystem.RunCampaignStartScripts((IReadOnlyCollection<GameModifierData>) Campaign.Data.Modifiers));
    while (routine.IsRunning)
    {
      if ((bool) (UnityEngine.Object) modifierSystem)
      {
        await Task.Delay(5);
      }
      else
      {
        routine = (Routine) null;
        return;
      }
    }
    routine = (Routine) null;
  }

  public static IEnumerator RunInitScripts(IReadOnlyCollection<GameModifierData> modifiers)
  {
    if (modifiers != null)
    {
      Debug.Log((object) string.Format("Running [{0}] Modifier Set Up Scripts", (object) modifiers.Count));
      foreach (GameModifierData gameModifierData in (IEnumerable<GameModifierData>) modifiers.OrderByDescending<GameModifierData, int>((Func<GameModifierData, int>) (m => m.scriptPriority)))
      {
        Debug.Log((object) string.Format("Running [{0}] Setup Scripts", (object) gameModifierData));
        Script[] scriptArray = gameModifierData.setupScripts;
        for (int index = 0; index < scriptArray.Length; ++index)
          yield return (object) scriptArray[index].Run();
        scriptArray = (Script[]) null;
      }
    }
  }

  public static IEnumerator RunCampaignStartScripts(IReadOnlyCollection<GameModifierData> modifiers)
  {
    if (modifiers != null)
    {
      Debug.Log((object) string.Format("Running [{0}] Modifier Campaign Start Scripts", (object) modifiers.Count));
      foreach (GameModifierData gameModifierData in (IEnumerable<GameModifierData>) modifiers.OrderByDescending<GameModifierData, int>((Func<GameModifierData, int>) (m => m.scriptPriority)))
      {
        Debug.Log((object) string.Format("Running [{0}] Campaign Start Scripts", (object) gameModifierData));
        Script[] scriptArray = gameModifierData.startScripts;
        for (int index = 0; index < scriptArray.Length; ++index)
          yield return (object) scriptArray[index].Run();
        scriptArray = (Script[]) null;
      }
    }
  }
}
