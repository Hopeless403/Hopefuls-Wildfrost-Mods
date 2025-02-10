// Decompiled with JetBrains decompiler
// Type: Pokefrost.Commands
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

#nullable disable
namespace Pokefrost
{
  internal class Commands
  {
    public static IEnumerator AddCustomCommands()
    {
      yield return (object) new WaitUntil((Func<bool>) (() => SceneManager.Loaded.ContainsKey("MainMenu")));
      if (Console.commands != null)
        Commands.AddCommands();
    }

    public static void AddCommands()
    {
      Console.commands.Add((Console.Command) new Commands.CommandModifier());
      Console.commands.Add((Console.Command) new Commands.CommandEvent());
      Console.commands.Add((Console.Command) new Commands.CommandDebug());
    }

    public class CommandModifier : Console.Command
    {
      public override string id => "poke.modifier";

      public override string format => "poke.modifier <name>";

      public override string desc => "Gives the corresponding modifier";

      public override bool IsRoutine => false;

      public override void Run(string args)
      {
        GameModifierData modifier = AddressableLoader.GetGroup<GameModifierData>("GameModifierData").FirstOrDefault<GameModifierData>((Func<GameModifierData, bool>) (a => string.Equals(a.name, args, StringComparison.CurrentCultureIgnoreCase)));
        if ((UnityEngine.Object) modifier == (UnityEngine.Object) null)
          this.Fail("Upgrade [" + args + "] does not exist!");
        if ((UnityEngine.Object) Campaign.instance == (UnityEngine.Object) null)
          this.Fail("Must be in a run!");
        ModifierSystem.AddModifier(Campaign.Data, modifier);
        Routine.Clump clump = new Routine.Clump();
        foreach (Script startScript in modifier.startScripts)
          clump.Add(startScript.Run());
        foreach (Script setupScript in modifier.setupScripts)
          clump.Add(setupScript.Run());
        foreach (string componentName in modifier.systemsToAdd)
        {
          Debug.Log((object) string.Format("[{0}] adding system: {1}", (object) modifier, (object) componentName));
          Campaign.instance.gameObject.AddComponentByName(componentName);
        }
      }

      public override IEnumerator GetArgOptions(string currentArgs)
      {
        yield return (object) AddressableLoader.LoadGroup("CardUpgradeData");
        IEnumerable<GameModifierData> enumerable = AddressableLoader.GetGroup<GameModifierData>("GameModifierData").Where<GameModifierData>((Func<GameModifierData, bool>) (a => a.name.ToLower().Contains(currentArgs.ToLower())));
        List<string> list = new List<string>();
        foreach (GameModifierData item in enumerable)
          list.Add(item.name);
        this.predictedArgs = list.ToArray();
      }
    }

    public class CommandEvent : Console.Command
    {
      public override string id => "poke.event";

      public override string format => "poke.event <name>";

      public override string desc => "Guarantees the specific event";

      public override bool IsRoutine => false;

      public override void Run(string args)
      {
        if (EventBattleManager.battleList.ContainsKey(args))
        {
          foreach (string key in EventBattleManager.battleList.Keys.ToArray<string>())
          {
            if (key != args)
              EventBattleManager.battleList.Remove(key);
          }
        }
        else
          this.Fail("Could not find key [" + args + "]");
      }

      public override IEnumerator GetArgOptions(string currentArgs)
      {
        this.predictedArgs = EventBattleManager.battleList.Keys.ToArray<string>();
        yield break;
      }
    }

    public class CommandDebug : Console.Command
    {
      public override string id => "poke.debug";

      public override string format => "poke.debug";

      public override string desc => "Runs arbitrary code for debugging";

      public override bool IsRoutine => false;

      public override void Run(string args)
      {
        List<StatusEffectData> group = AddressableLoader.GetGroup<StatusEffectData>("StatusEffectData");
        Debug.Log((object) ("[Pokefrost] STARTING DEBUG: " + group.Count.ToString()));
        foreach (StatusEffectData statusEffectData in group)
        {
          if (statusEffectData.type == null)
            Debug.Log((object) ("[Pokefrost] " + statusEffectData.name));
        }
        Debug.Log((object) "[Pokefrost] ENDING DEBUG");
      }
    }
  }
}
