// Decompiled with JetBrains decompiler
// Type: Console
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using Dead;
using Deadpan.Enums.Engine.Components.Modding;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.ResourceManagement.AsyncOperations;

#nullable disable
public class Console : MonoBehaviourSingleton<Console>
{
  [SerializeField]
  public KeyCode[] toggle = new KeyCode[2]
  {
    KeyCode.BackQuote,
    KeyCode.F12
  };
  [SerializeField]
  public KeyCode takePredict = KeyCode.Tab;
  [SerializeField]
  public Color logColor;
  [SerializeField]
  public Color logErrorColor;
  [SerializeField]
  public string unknownCommandFormat = "Unknown Command: {0}";
  [SerializeField]
  public Canvas canvas;
  [SerializeField]
  public TMP_InputField input;
  [SerializeField]
  public TMP_Text textPrefab;
  [SerializeField]
  public Transform log;
  [SerializeField]
  public GameObject helpWindow;
  [SerializeField]
  public TMP_Text helpText;
  [SerializeField]
  public ConsoleArgsDisplay argsDisplay;
  [Header("Saving Commands")]
  [SerializeField]
  public KeyCode[] saveKeys = new KeyCode[8]
  {
    KeyCode.F1,
    KeyCode.F2,
    KeyCode.F3,
    KeyCode.F4,
    KeyCode.F5,
    KeyCode.F6,
    KeyCode.F7,
    KeyCode.F8
  };
  [SerializeField]
  public string saveFileName = "commands.sav";
  [SerializeField]
  public string[] savedCommands;
  public static readonly List<string> previous = new List<string>();
  public int preIndex;
  public static List<Console.Command> commands;
  public static bool active;
  public static Entity hover;
  public static CardSlot slotHover;
  public bool promptUpdatePredict;

  public void Start()
  {
    this.LoadCommands();
    this.canvas.gameObject.SetActive(false);
    Console.Commands();
    this.PopulateHelp();
    this.helpWindow.SetActive(false);
    this.StartCoroutine(this.UpdatePredictRoutine());
  }

  public IEnumerator UpdatePredictRoutine()
  {
    while (true)
    {
      if (this.promptUpdatePredict)
      {
        this.promptUpdatePredict = false;
        yield return (object) this.PredictArgsRoutine(this.input.text);
      }
      yield return (object) null;
    }
  }

  public void OnEnable()
  {
    global::Events.OnEntityHover += new UnityAction<Entity>(Console.Hover);
    global::Events.OnSlotHover += new UnityAction<CardSlot>(Console.SlotHover);
  }

  public void OnDisable()
  {
    global::Events.OnEntityHover -= new UnityAction<Entity>(Console.Hover);
    global::Events.OnSlotHover -= new UnityAction<CardSlot>(Console.SlotHover);
  }

  public static void Hover(Entity entity) => Console.hover = entity;

  public static void SlotHover(CardSlot slot) => Console.slotHover = slot;

  public void Update()
  {
    if (this.CheckToggle())
      return;
    if (Console.active)
    {
      if (Input.GetKeyDown(KeyCode.Escape))
      {
        this.Toggle();
      }
      else
      {
        if (this.CheckTakePredict())
          return;
        this.CheckScrollPrevious();
        this.CheckRunCommand();
        this.CheckSaveCommand();
        this.KeepFocus();
      }
    }
    else
      this.CheckRunSavedCommands();
  }

  public bool CheckToggle()
  {
    if (!((IEnumerable<KeyCode>) this.toggle).Any<KeyCode>(new Func<KeyCode, bool>(Input.GetKeyDown)))
      return false;
    this.Toggle();
    return true;
  }

  public bool CheckTakePredict()
  {
    if (!Input.GetKeyDown(this.takePredict) || this.argsDisplay.Count <= 0)
      return false;
    Console.Command exactCommand = Console.GetExactCommand(this.input.text.TrimStart());
    this.input.text = exactCommand == null ? this.argsDisplay.TopCommand : exactCommand.id + " " + this.argsDisplay.TopArgument;
    this.input.MoveToEndOfLine(false, false);
    return true;
  }

  public void CheckScrollPrevious()
  {
    if (Input.GetKeyDown(KeyCode.UpArrow))
    {
      if (Console.previous.Count > 0)
      {
        this.preIndex = Mathf.Min(this.preIndex + 1, Console.previous.Count - 1);
        this.input.text = Console.previous[this.preIndex];
      }
      this.input.MoveToEndOfLine(false, false);
    }
    else
    {
      if (!Input.GetKeyDown(KeyCode.DownArrow))
        return;
      if (Console.previous.Count > 0)
      {
        this.preIndex = Mathf.Max(this.preIndex - 1, 0);
        this.input.text = Console.previous[this.preIndex];
      }
      this.input.MoveToEndOfLine(false, false);
    }
  }

  public void CheckRunCommand()
  {
    if (!Input.GetKeyDown(KeyCode.Return))
      return;
    string text = this.input.text.Trim();
    if (text.Length <= 0)
      return;
    Routine routine = new Routine(Console.HandleCommand(text));
    this.input.text = "";
    this.preIndex = -1;
  }

  public void CheckSaveCommand()
  {
    for (int index = 0; index < this.saveKeys.Length; ++index)
    {
      KeyCode saveKey = this.saveKeys[index];
      if (Input.GetKeyDown(saveKey))
      {
        string str = this.input.text.Trim();
        if (str.Length > 0)
        {
          this.savedCommands[index] = str;
          Console.Log(string.Format("Command '{0}' Saved to {1}", (object) str, (object) saveKey));
          this.SaveCommands();
          this.input.text = "";
          this.preIndex = -1;
        }
        else if (this.savedCommands.Length > index)
        {
          string savedCommand = this.savedCommands[index];
          if (savedCommand.Length > 0)
          {
            Routine routine = new Routine(Console.HandleCommand(savedCommand));
            this.input.text = "";
            this.preIndex = -1;
          }
        }
      }
    }
  }

  public void KeepFocus()
  {
    if (this.input.isFocused)
      return;
    EventSystem current = EventSystem.current;
    if (current == null)
      return;
    current.SetSelectedGameObject(this.input.gameObject, (BaseEventData) null);
    this.input.OnPointerClick(new PointerEventData(current));
  }

  public void CheckRunSavedCommands()
  {
    int num = Mathf.Min(this.saveKeys.Length, this.savedCommands.Length);
    for (int index = 0; index < num; ++index)
    {
      if (Input.GetKeyDown(this.saveKeys[index]))
      {
        string savedCommand = this.savedCommands[index];
        if (savedCommand.Length > 0)
        {
          Routine routine = new Routine(Console.HandleCommand(savedCommand));
        }
      }
    }
  }

  public static void Commands()
  {
    Console.commands = new List<Console.Command>()
    {
      (Console.Command) new Console.CommandHelp(),
      (Console.Command) new Console.CommandGainCard(),
      (Console.Command) new Console.CommandGainUpgrade(),
      (Console.Command) new Console.CommandGainGold(),
      (Console.Command) new Console.CommandSetHealth(),
      (Console.Command) new Console.CommandSetAttack(),
      (Console.Command) new Console.CommandSetCounter(),
      (Console.Command) new Console.CommandAddStatus(),
      (Console.Command) new Console.CommandAddUpgrade(),
      (Console.Command) new Console.CommandHit(),
      (Console.Command) new Console.CommandKill(),
      (Console.Command) new Console.CommandKillAll(),
      (Console.Command) new Console.CommandDestroy(),
      (Console.Command) new Console.CommandDestroyAll(),
      (Console.Command) new Console.CommandSpawn(),
      (Console.Command) new Console.CommandBattleWin(),
      (Console.Command) new Console.CommandBattleLose(),
      (Console.Command) new Console.CommandBattleSkip(),
      (Console.Command) new Console.CommandBattleAuto(),
      (Console.Command) new Console.CommandSkipTurn(),
      (Console.Command) new Console.CommandMapJump(),
      (Console.Command) new Console.CommandMapInfo(),
      (Console.Command) new Console.CommandSystemDisable(),
      (Console.Command) new Console.CommandSystemEnable(),
      (Console.Command) new Console.CommandGameSpeed(),
      (Console.Command) new Console.CommandSetSaveProfile(),
      (Console.Command) new Console.CommandVolume(),
      (Console.Command) new Console.CommandVolume("Music"),
      (Console.Command) new Console.CommandVolume("Sfx"),
      (Console.Command) new Console.CommandVolume("Ambience"),
      (Console.Command) new Console.CommandToggleHUD(),
      (Console.Command) new Console.CommandToggleFps(),
      (Console.Command) new Console.CommandToggleHandOverlay(),
      (Console.Command) new Console.CommandCursor(),
      (Console.Command) new Console.CommandReroll(),
      (Console.Command) new Console.CommandRepeat(),
      (Console.Command) new Console.CommandPrompt(),
      (Console.Command) new Console.CommandPromptHide(),
      (Console.Command) new Console.CommandErrorTest(),
      (Console.Command) new Console.CommandPanSpeed(),
      (Console.Command) new Console.CommandNextBattle(),
      (Console.Command) new Console.CommandProgressGain(),
      (Console.Command) new Console.CommandProgressReset(),
      (Console.Command) new Console.CommandScreenshot(),
      (Console.Command) new Console.CommandBlood(),
      (Console.Command) new Console.CommandRunFinalBossScript(),
      (Console.Command) new Console.CommandDailyReset(),
      (Console.Command) new Console.CommandDailyOffset(),
      (Console.Command) new Console.CommandEncrypt(),
      (Console.Command) new Console.CommandDecrypt(),
      (Console.Command) new Console.CommandDisplay(),
      (Console.Command) new Console.LoadModCommand(),
      (Console.Command) new Console.UnLoadModCommand(),
      (Console.Command) new Console.PublishMod()
    };
  }

  public void SaveCommands()
  {
    File.WriteAllLines(Application.persistentDataPath + "\\" + this.saveFileName, this.savedCommands);
  }

  public void LoadCommands()
  {
    string path = Application.persistentDataPath + "\\" + this.saveFileName;
    if (File.Exists(path))
    {
      this.savedCommands = File.ReadAllLines(path);
    }
    else
    {
      this.savedCommands = new string[this.saveKeys.Length];
      this.savedCommands[0] = "repeat";
    }
  }

  public static IEnumerator HandleCommand(string text)
  {
    Debug.Log((object) text);
    bool commandFound = false;
    if (Console.commands == null)
      Console.Commands();
    for (int index = Console.commands.Count - 1; index >= 0; --index)
    {
      Console.Command command = Console.commands[index];
      if (text.StartsWith(command.id))
      {
        commandFound = true;
        string args = text.Replace(command.id, "").Trim();
        command.success = true;
        if (command.IsRoutine)
          yield return (object) command.Routine(args);
        else
          command.Run(args);
        if (command.success && command.logOnSuccess)
        {
          Console.Log(text);
          break;
        }
        break;
      }
      command = (Console.Command) null;
    }
    if (!commandFound)
      Console.LogError(string.Format(MonoBehaviourSingleton<Console>.instance.unknownCommandFormat, (object) text));
    Console.previous.Insert(0, text);
  }

  public static void Log(string text)
  {
    TMP_Text tmpText = UnityEngine.Object.Instantiate<TMP_Text>(MonoBehaviourSingleton<Console>.instance.textPrefab, MonoBehaviourSingleton<Console>.instance.log);
    tmpText.text = text;
    tmpText.color = MonoBehaviourSingleton<Console>.instance.logColor;
    tmpText.gameObject.SetActive(true);
  }

  public static void LogError(string text)
  {
    TMP_Text tmpText = UnityEngine.Object.Instantiate<TMP_Text>(MonoBehaviourSingleton<Console>.instance.textPrefab, MonoBehaviourSingleton<Console>.instance.log);
    tmpText.text = text;
    tmpText.color = MonoBehaviourSingleton<Console>.instance.logErrorColor;
    tmpText.gameObject.SetActive(true);
  }

  public void PredictArgs() => this.promptUpdatePredict = true;

  public IEnumerator PredictArgsRoutine(string text)
  {
    text = text.TrimStart();
    if (text.Length > 0)
    {
      yield return (object) new WaitForEndOfFrame();
      yield return (object) null;
      Console.Command[] array1 = Console.commands.Where<Console.Command>((Func<Console.Command, bool>) (a => a.id.StartsWith(text))).ToArray<Console.Command>();
      int length = array1.Length;
      Bounds bounds = this.input.textComponent.textBounds;
      float x = 10f;
      if (length > 0)
      {
        this.argsDisplay.Show();
        this.argsDisplay.DisplayCommands(((IEnumerable<Console.Command>) array1).OrderByDescending<Console.Command, int>((Func<Console.Command, int>) (a => a.id.Length)).ToArray<Console.Command>());
        this.argsDisplay.MoveTo(x);
      }
      else
      {
        Console.Command exactCommand = Console.GetExactCommand(text);
        if (exactCommand != null)
        {
          string args = text.Replace(exactCommand.id + " ", "");
          yield return (object) exactCommand.GetArgOptions(args);
          if (exactCommand.predictedArgs != null && exactCommand.predictedArgs.Length != 0)
          {
            this.argsDisplay.Show();
            string[] array2 = ((IEnumerable<string>) exactCommand.predictedArgs).Where<string>((Func<string, bool>) (a => string.Equals(a, args, StringComparison.CurrentCultureIgnoreCase))).ToArray<string>();
            if (array2.Length != 0)
              this.argsDisplay.DisplayArgs(array2);
            else
              this.argsDisplay.DisplayArgs(((IEnumerable<string>) exactCommand.predictedArgs).OrderByDescending<string, int>((Func<string, int>) (a => a.Length)).ToArray<string>());
            this.argsDisplay.MoveTo(x + 10f + bounds.size.x);
          }
          else
            this.argsDisplay.Hide();
        }
        else
          this.argsDisplay.Hide();
        exactCommand = (Console.Command) null;
      }
      bounds = new Bounds();
    }
    else
      this.argsDisplay.Hide();
    yield return (object) null;
  }

  public static Console.Command GetExactCommand(string text)
  {
    return Console.commands.FirstOrDefault<Console.Command>((Func<Console.Command, bool>) (a => text.StartsWith(a.id + " ")));
  }

  public void Toggle()
  {
    Console.active = !Console.active;
    this.canvas.gameObject.SetActive(Console.active);
    if (Console.active)
    {
      this.preIndex = -1;
      InputSystem.Disable();
    }
    else
    {
      this.input.text = "";
      InputSystem.Enable();
    }
  }

  public static void ToggleHelp()
  {
    MonoBehaviourSingleton<Console>.instance.helpWindow.SetActive(!MonoBehaviourSingleton<Console>.instance.helpWindow.activeSelf);
  }

  public void PopulateHelp()
  {
    string str1 = "";
    foreach (Console.Command command in Console.commands)
    {
      if (!command.hidden)
      {
        string str2 = command.format;
        if (command.desc.Length > 0)
          str2 = str2 + " <i><#fffd>" + command.desc + "</color></i>";
        str1 = str1 + str2 + "\n";
      }
    }
    this.helpText.text = str1.TrimEnd();
  }

  public abstract class Command
  {
    public bool success;
    [CompilerGenerated]
    public string \u003CfailMessage\u003Ek__BackingField;
    public string[] predictedArgs;

    public virtual string id => "";

    public virtual string desc => "";

    public virtual string format => this.id;

    public virtual bool hidden => false;

    public virtual bool logOnSuccess => true;

    public string failMessage
    {
      get => this.\u003CfailMessage\u003Ek__BackingField;
      set => this.\u003CfailMessage\u003Ek__BackingField = value;
    }

    public virtual bool IsRoutine => false;

    public virtual void Run(string args)
    {
    }

    public virtual IEnumerator Routine(string args) => (IEnumerator) null;

    public virtual IEnumerator GetArgOptions(string currentArgs) => (IEnumerator) null;

    public void Fail(string message)
    {
      this.success = false;
      this.failMessage = this.failMessage;
      Console.LogError(message);
    }

    public void FailCannotUse() => this.Fail("Cannot use [" + this.id + "] command here");

    public bool TryGetPlayer(out Character player, bool doFail = true)
    {
      player = (Character) null;
      if (!(bool) (UnityEngine.Object) Campaign.instance)
      {
        if (doFail)
          this.FailCannotUse();
        return false;
      }
      player = References.Player;
      if ((bool) (UnityEngine.Object) player)
        return true;
      if (doFail)
        this.FailCannotUse();
      return false;
    }

    public static string[] Split(string text)
    {
      return text.Length <= 0 ? new string[1]{ "" } : text.Split(new char[1]
      {
        ' '
      }, StringSplitOptions.RemoveEmptyEntries);
    }
  }

  public class CommandHelp : Console.Command
  {
    public override string id => "help";

    public override bool hidden => true;

    public override bool logOnSuccess => false;

    public override void Run(string args) => Console.ToggleHelp();
  }

  public class CommandRepeat : Console.Command
  {
    public override string id => "repeat";

    public override string format => "repeat <times>";

    public override bool logOnSuccess => false;

    public override void Run(string args)
    {
      if (Console.previous.Count <= 0)
        return;
      int result = 1;
      if (args.Length > 0)
        int.TryParse(args, out result);
      Routine routine = new Routine(Console.CommandRepeat.Repeat(Console.previous[0], result));
    }

    public static IEnumerator Repeat(string command, int repeats)
    {
      while (repeats > 0)
      {
        --repeats;
        yield return (object) Console.HandleCommand(command);
      }
    }
  }

  public class CommandGainCard : Console.Command
  {
    public override string id => "gain card";

    public override string format => "gain card <name>";

    public override bool IsRoutine => true;

    public override IEnumerator Routine(string args)
    {
      Console.CommandGainCard commandGainCard = this;
      if (args.Length > 0)
      {
        Character player;
        if (commandGainCard.TryGetPlayer(out player))
        {
          yield return (object) AddressableLoader.LoadGroup("CardData");
          IEnumerable<CardData> source = AddressableLoader.GetGroup<CardData>("CardData").Where<CardData>((Func<CardData, bool>) (a => string.Equals(a.name, args, StringComparison.CurrentCultureIgnoreCase)));
          if (source.Any<CardData>())
          {
            CardData cardData = source.First<CardData>();
            if (cardData != null)
            {
              CardData data = cardData.Clone();
              player.data.inventory.deck.Add(data);
              if ((bool) (UnityEngine.Object) Battle.instance && (bool) (UnityEngine.Object) player.handContainer)
              {
                Card card = CardManager.Get(data, Battle.instance.playerCardController, player, true, true);
                card.entity.flipper.FlipDownInstant();
                card.transform.localPosition = new Vector3(-100f, 0.0f, 0.0f);
                yield return (object) card.UpdateData(false);
                player.handContainer.Add(card.entity);
                player.handContainer.TweenChildPositions();
                ActionQueue.Add((PlayAction) new ActionReveal(card.entity));
                ActionQueue.Add((PlayAction) new ActionRunEnableEvent(card.entity));
                yield return (object) ActionQueue.Wait();
                card = (Card) null;
                goto label_7;
              }
              else
                goto label_7;
            }
          }
          commandGainCard.Fail("Card [" + args + "] does not exist!");
        }
label_7:
        player = (Character) null;
      }
      else
        commandGainCard.Fail("You must provide a card name");
    }

    public override IEnumerator GetArgOptions(string currentArgs)
    {
      Console.CommandGainCard commandGainCard = this;
      yield return (object) AddressableLoader.LoadGroup("CardData");
      IEnumerable<CardData> source = AddressableLoader.GetGroup<CardData>("CardData").Where<CardData>((Func<CardData, bool>) (a => a.name.ToLower().Contains(currentArgs.ToLower())));
      commandGainCard.predictedArgs = source.Select<CardData, string>((Func<CardData, string>) (cardData => cardData.name)).ToArray<string>();
    }
  }

  public class CommandGainUpgrade : Console.Command
  {
    public override string id => "gain upgrade";

    public override string format => "gain upgrade <name>";

    public override bool IsRoutine => true;

    public override IEnumerator Routine(string args)
    {
      Console.CommandGainUpgrade commandGainUpgrade = this;
      if (args.Length > 0)
      {
        Character player;
        if (commandGainUpgrade.TryGetPlayer(out player, false))
        {
          yield return (object) AddressableLoader.LoadGroup("CardUpgradeData");
          try
          {
            player.data.inventory.upgrades.Add(AddressableLoader.GetGroup<CardUpgradeData>("CardUpgradeData").First<CardUpgradeData>((Func<CardUpgradeData, bool>) (a => string.Equals(a.name, args, StringComparison.CurrentCultureIgnoreCase))).Clone());
          }
          catch
          {
            commandGainUpgrade.Fail("Upgrade [" + args + "] does not exist!");
          }
        }
        else
        {
          GameObject withTag = GameObject.FindWithTag("CharmHolder");
          CardCharmHolder cardCharmHolder;
          if (withTag != null)
          {
            cardCharmHolder = withTag.GetComponent<CardCharmHolder>();
            if (cardCharmHolder != null)
            {
              yield return (object) AddressableLoader.LoadGroup("CardUpgradeData");
              try
              {
                cardCharmHolder.Create(AddressableLoader.GetGroup<CardUpgradeData>("CardUpgradeData").First<CardUpgradeData>((Func<CardUpgradeData, bool>) (a => string.Equals(a.name, args, StringComparison.CurrentCultureIgnoreCase))).Clone());
                cardCharmHolder.SetPositions();
              }
              catch
              {
                commandGainUpgrade.Fail("Upgrade [" + args + "] does not exist!");
              }
            }
          }
          cardCharmHolder = (CardCharmHolder) null;
        }
        player = (Character) null;
      }
      else
        commandGainUpgrade.Fail("You must provide an upgrade name");
    }

    public override IEnumerator GetArgOptions(string currentArgs)
    {
      Console.CommandGainUpgrade commandGainUpgrade = this;
      yield return (object) AddressableLoader.LoadGroup("CardUpgradeData");
      IEnumerable<CardUpgradeData> cardUpgradeDatas = AddressableLoader.GetGroup<CardUpgradeData>("CardUpgradeData").Where<CardUpgradeData>((Func<CardUpgradeData, bool>) (a => a.name.ToLower().Contains(currentArgs.ToLower())));
      List<string> stringList = new List<string>();
      foreach (CardUpgradeData cardUpgradeData in cardUpgradeDatas)
        stringList.Add(cardUpgradeData.name);
      commandGainUpgrade.predictedArgs = stringList.ToArray();
    }
  }

  public class CommandGainGold : Console.Command
  {
    public override string id => "gain blings";

    public override string format => "gain blings <amount>";

    public override void Run(string args)
    {
      int result = 10;
      if (args.Length > 0 && !int.TryParse(args, out result))
      {
        this.Fail("Invalid amount! (" + args + ")");
      }
      else
      {
        Character player;
        if (!this.TryGetPlayer(out player))
          return;
        player.GainGold(result);
      }
    }
  }

  public class CommandSpawn : Console.Command
  {
    public override string id => "spawn";

    public override string format => "spawn <unit>";

    public override bool IsRoutine => true;

    public override IEnumerator Routine(string args)
    {
      Console.CommandSpawn commandSpawn = this;
      if (!(bool) (UnityEngine.Object) References.Battle)
        commandSpawn.Fail("Must be in battle to use this command");
      else if (args.Length <= 0)
        commandSpawn.Fail("You must provide a card name");
      else if (!(bool) (UnityEngine.Object) Console.slotHover)
        commandSpawn.Fail("You must hover over a slot to use this command");
      else if (!Console.slotHover.Empty)
      {
        commandSpawn.Fail("That slot is not empty!");
      }
      else
      {
        yield return (object) AddressableLoader.LoadGroup("CardData");
        IEnumerable<CardData> source = AddressableLoader.GetGroup<CardData>("CardData").Where<CardData>((Func<CardData, bool>) (a => a.cardType.unit && string.Equals(a.name, args, StringComparison.CurrentCultureIgnoreCase)));
        if (source.Any<CardData>())
        {
          CardData cardData = source.First<CardData>();
          if (cardData != null)
          {
            Card card = CardManager.Get(cardData.Clone(), References.Battle.playerCardController, Console.slotHover.owner, true, Console.slotHover.owner.team == References.Player.team);
            card.entity.flipper.FlipDownInstant();
            card.transform.localPosition = new Vector3(-100f, 0.0f, 0.0f);
            yield return (object) card.UpdateData(false);
            Console.slotHover.Add(card.entity);
            Console.slotHover.TweenChildPositions();
            ActionQueue.Add((PlayAction) new ActionReveal(card.entity));
            ActionQueue.Add((PlayAction) new ActionRunEnableEvent(card.entity));
            yield return (object) ActionQueue.Wait();
            card = (Card) null;
            yield break;
          }
        }
        commandSpawn.Fail("Card [" + args + "] does not exist!");
      }
    }

    public override IEnumerator GetArgOptions(string currentArgs)
    {
      Console.CommandSpawn commandSpawn = this;
      yield return (object) AddressableLoader.LoadGroup("CardData");
      IEnumerable<CardData> source = AddressableLoader.GetGroup<CardData>("CardData").Where<CardData>((Func<CardData, bool>) (a => a.cardType.unit && a.name.ToLower().Contains(currentArgs.ToLower())));
      commandSpawn.predictedArgs = source.Select<CardData, string>((Func<CardData, string>) (cardData => cardData.name)).ToArray<string>();
    }
  }

  public class CommandBattleWin : Console.Command
  {
    public override string id => "battle win";

    public override void Run(string args)
    {
      if ((UnityEngine.Object) Battle.instance == (UnityEngine.Object) null)
        this.FailCannotUse();
      else if (Battle.instance.phase == Battle.Phase.End)
        this.Fail("The battle is already over!");
      else
        Battle.instance.PlayerWin();
    }
  }

  public class CommandBattleLose : Console.Command
  {
    public override string id => "battle lose";

    public override void Run(string args)
    {
      if ((UnityEngine.Object) Battle.instance == (UnityEngine.Object) null)
        this.FailCannotUse();
      else if (Battle.instance.phase == Battle.Phase.End)
        this.Fail("The battle is already over!");
      else
        Battle.instance.EnemyWin();
    }
  }

  public class CommandBattleSkip : Console.Command
  {
    public override string id => "battle skip";

    public override string desc => "to next wave";

    public override void Run(string args)
    {
      if ((UnityEngine.Object) Battle.instance == (UnityEngine.Object) null)
        this.FailCannotUse();
      else if (Battle.instance.phase == Battle.Phase.End)
      {
        this.Fail("The battle is already over!");
      }
      else
      {
        foreach (Entity entity in Battle.GetCardsOnBoard(Battle.instance.enemy))
        {
          entity.RemoveFromContainers();
          CardManager.ReturnToPool(entity);
        }
        ActionQueue.Add((PlayAction) new ActionEndTurn(Battle.instance.player));
        Battle.instance.playerCardController.Disable();
        CardPopUp.Clear();
      }
    }
  }

  public class CommandBattleAuto : Console.Command
  {
    public override string id => "battle auto";

    public override string desc => "play out the rest of the battle automatically";

    public override void Run(string args)
    {
      if (!(bool) (UnityEngine.Object) References.Battle)
        this.FailCannotUse();
      else if (References.Battle.phase == Battle.Phase.End)
        this.Fail("The battle is already over!");
      else
        References.Battle.auto = !References.Battle.auto;
    }
  }

  public class CommandSkipTurn : Console.Command
  {
    public override string id => "skip turn";

    public override void Run(string args)
    {
      if ((UnityEngine.Object) Battle.instance == (UnityEngine.Object) null)
        this.FailCannotUse();
      else if (Battle.instance.phase == Battle.Phase.End)
      {
        this.Fail("The battle is already over!");
      }
      else
      {
        ActionQueue.Add((PlayAction) new ActionEndTurn(Battle.instance.player));
        Battle.instance.playerCardController.Disable();
        CardPopUp.Clear();
      }
    }
  }

  public class CommandSetHealth : Console.Command
  {
    public override string id => "set health";

    public override string format => "set health <value>";

    public override void Run(string args)
    {
      if (args.Length < 1)
        this.Fail("You must provide a value");
      else if ((UnityEngine.Object) Console.hover == (UnityEngine.Object) null)
      {
        this.Fail("Please hover over a card to use this command");
      }
      else
      {
        int result;
        if (!int.TryParse(args, out result) || result <= 0)
          this.Fail("Invalid value! (" + args + ")");
        else if (!Console.hover.enabled || !Console.hover.data.hasHealth)
        {
          this.Fail("Cannot use on this card");
        }
        else
        {
          Console.hover.hp.current = result;
          Console.hover.hp.max = Mathf.Max(Console.hover.hp.max, Console.hover.hp.current);
          Console.hover.PromptUpdate();
        }
      }
    }
  }

  public class CommandSetAttack : Console.Command
  {
    public override string id => "set attack";

    public override string format => "set attack <value>";

    public override void Run(string args)
    {
      if (args.Length < 1)
        this.Fail("You must provide a value");
      else if ((UnityEngine.Object) Console.hover == (UnityEngine.Object) null)
      {
        this.Fail("Please hover over a card to use this command");
      }
      else
      {
        int result;
        if (!int.TryParse(args, out result) || result <= 0)
          this.Fail("Invalid value! (" + args + ")");
        else if (!Console.hover.enabled || !Console.hover.data.hasAttack)
        {
          this.Fail("Cannot use on this card");
        }
        else
        {
          Console.hover.damage.current = result;
          Console.hover.damage.max = result;
          Console.hover.PromptUpdate();
        }
      }
    }
  }

  public class CommandSetCounter : Console.Command
  {
    public override string id => "set counter";

    public override string format => "set counter <value>";

    public override void Run(string args)
    {
      if (args.Length < 1)
        this.Fail("You must provide a value");
      else if ((UnityEngine.Object) Console.hover == (UnityEngine.Object) null)
      {
        this.Fail("Please hover over a card to use this command");
      }
      else
      {
        int result;
        if (!int.TryParse(args, out result) || result <= 0)
          this.Fail("Invalid value! (" + args + ")");
        else if (!Console.hover.enabled || !Console.hover.data.hasAttack)
        {
          this.Fail("Cannot use on this card");
        }
        else
        {
          Console.hover.counter.current = result;
          Console.hover.counter.max = Mathf.Max(Console.hover.counter.max, result);
          Console.hover.PromptUpdate();
        }
      }
    }
  }

  public class CommandAddStatus : Console.Command
  {
    public override string id => "add status";

    public override string format => "add status <name>";

    public override bool IsRoutine => true;

    public override IEnumerator Routine(string args)
    {
      Console.CommandAddStatus commandAddStatus = this;
      if (args.Length > 0)
      {
        if ((UnityEngine.Object) Console.hover != (UnityEngine.Object) null)
        {
          if (Console.hover.enabled)
          {
            string[] strArray = Console.Command.Split(args);
            string statusName = strArray[0];
            int count = 1;
            if (strArray.Length > 1)
              int.TryParse(strArray[1], out count);
            yield return (object) AddressableLoader.LoadGroup("StatusEffectData");
            IEnumerable<StatusEffectData> source = AddressableLoader.GetGroup<StatusEffectData>("StatusEffectData").Where<StatusEffectData>((Func<StatusEffectData, bool>) (a => a.visible && !a.name.Contains(' ') && string.Equals(a.name, statusName, StringComparison.CurrentCultureIgnoreCase)));
            if (source.Any<StatusEffectData>())
            {
              StatusEffectData effectData = source.First<StatusEffectData>();
              if (effectData != null)
              {
                yield return (object) StatusEffectSystem.Apply(Console.hover, (Entity) null, effectData, count);
                goto label_9;
              }
            }
            commandAddStatus.Fail("StatusEffect [" + statusName + "] does not exist!");
label_9:;
          }
          else
            commandAddStatus.Fail("Cannot use on that card");
        }
        else
          commandAddStatus.Fail("Please hover over a card to use this command");
      }
      else
        commandAddStatus.Fail("You must provide a StatusEffect name");
    }

    public override IEnumerator GetArgOptions(string currentArgs)
    {
      Console.CommandAddStatus commandAddStatus = this;
      yield return (object) AddressableLoader.LoadGroup("StatusEffectData");
      IEnumerable<StatusEffectData> source = AddressableLoader.GetGroup<StatusEffectData>("StatusEffectData").Where<StatusEffectData>((Func<StatusEffectData, bool>) (a => a.visible && !a.name.Contains(' ') && a.name.ToLower().Contains(currentArgs.ToLower())));
      commandAddStatus.predictedArgs = source.Select<StatusEffectData, string>((Func<StatusEffectData, string>) (effectData => effectData.name)).ToArray<string>();
    }
  }

  public class CommandAddUpgrade : Console.Command
  {
    public override string id => "add upgrade";

    public override string format => "add upgrade <name>";

    public override bool IsRoutine => true;

    public override IEnumerator Routine(string args)
    {
      Console.CommandAddUpgrade commandAddUpgrade = this;
      if (args.Length > 0)
      {
        if ((UnityEngine.Object) Console.hover != (UnityEngine.Object) null)
        {
          yield return (object) AddressableLoader.LoadGroup("CardUpgradeData");
          IEnumerable<CardUpgradeData> source = AddressableLoader.GetGroup<CardUpgradeData>("CardUpgradeData").Where<CardUpgradeData>((Func<CardUpgradeData, bool>) (a => a.name.ToLower() == args.ToLower()));
          if (source.Any<CardUpgradeData>())
          {
            CardUpgradeData cardUpgradeData = source.First<CardUpgradeData>();
            if (cardUpgradeData != null)
            {
              if (cardUpgradeData.CanAssign(Console.hover))
              {
                yield return (object) cardUpgradeData.Clone().Assign(Console.hover);
                yield break;
              }
              else
              {
                commandAddUpgrade.Fail("Upgrade [" + cardUpgradeData.name + "] cannot be assigned to [" + Console.hover.data.title + "]");
                yield break;
              }
            }
          }
          commandAddUpgrade.Fail("Upgrade [" + args + "] does not exist!");
        }
        else
          commandAddUpgrade.Fail("Please hover over a card to use this command");
      }
      else
        commandAddUpgrade.Fail("You must provide an upgrade name");
    }

    public override IEnumerator GetArgOptions(string currentArgs)
    {
      Console.CommandAddUpgrade commandAddUpgrade = this;
      yield return (object) AddressableLoader.LoadGroup("CardUpgradeData");
      IEnumerable<CardUpgradeData> source = AddressableLoader.GetGroup<CardUpgradeData>("CardUpgradeData").Where<CardUpgradeData>((Func<CardUpgradeData, bool>) (a => a.name.ToLower().Contains(currentArgs.ToLower())));
      commandAddUpgrade.predictedArgs = source.Select<CardUpgradeData, string>((Func<CardUpgradeData, string>) (upgradeData => upgradeData.name)).ToArray<string>();
    }
  }

  public class CommandDestroy : Console.Command
  {
    public override string id => "destroy";

    public override void Run(string args)
    {
      if ((UnityEngine.Object) Console.hover == (UnityEngine.Object) null)
        this.Fail("Please hover over a card to use this command");
      else if (!Console.hover.enabled)
      {
        this.Fail("Cannot destroy this card");
      }
      else
      {
        Console.hover.RemoveFromContainers();
        CardManager.ReturnToPool(Console.hover);
        CardPopUp.Clear();
      }
    }
  }

  public class CommandDestroyAll : Console.Command
  {
    public override string id => "destroy all";

    public override void Run(string args)
    {
      if ((UnityEngine.Object) Battle.instance == (UnityEngine.Object) null)
      {
        this.Fail("Must be in battle to use this command");
      }
      else
      {
        foreach (Entity entity in Battle.GetCardsOnBoard(Battle.instance.enemy))
        {
          entity.RemoveFromContainers();
          CardManager.ReturnToPool(entity);
        }
        ActionQueue.Add((PlayAction) new ActionEndTurn(Battle.instance.player));
        Battle.instance.playerCardController.Disable();
        CardPopUp.Clear();
      }
    }
  }

  public class CommandHit : Console.Command
  {
    public override string id => "hit";

    public override string format => "hit <damage>";

    public override bool IsRoutine => true;

    public override IEnumerator Routine(string args)
    {
      Console.CommandHit commandHit = this;
      if (!(bool) (UnityEngine.Object) Console.hover)
      {
        commandHit.Fail("Please hover over a card to use this command");
      }
      else
      {
        int result = 1;
        if (args.Length > 0)
          int.TryParse(args, out result);
        Character player = References.Player;
        if (player != null && (bool) (UnityEngine.Object) player.entity)
          yield return (object) new Hit(player.entity, Console.hover, result)
          {
            canRetaliate = false
          }.Process();
        else
          commandHit.FailCannotUse();
      }
    }
  }

  public class CommandKill : Console.Command
  {
    public override string id => "kill";

    public override void Run(string args)
    {
      if ((UnityEngine.Object) Console.hover == (UnityEngine.Object) null)
        this.Fail("Please hover over a card to use this command");
      else if (!Console.hover.enabled)
      {
        this.Fail("Cannot kill this card");
      }
      else
      {
        Console.hover.forceKill = true;
        Console.hover.PromptUpdate();
      }
    }
  }

  public class CommandKillAll : Console.Command
  {
    public override string id => "kill all";

    public override void Run(string args)
    {
      if ((UnityEngine.Object) Battle.instance == (UnityEngine.Object) null)
      {
        this.Fail("Must be in battle to use this command");
      }
      else
      {
        foreach (Entity entity in Battle.GetCardsOnBoard(Battle.instance.enemy))
        {
          entity.forceKill = true;
          entity.PromptUpdate();
        }
        ActionQueue.Add((PlayAction) new ActionEndTurn(Battle.instance.player));
        Battle.instance.playerCardController.Disable();
      }
    }
  }

  public class CommandReroll : Console.Command
  {
    public override string id => "reroll";

    public override string desc => "new leaders, or card rewards";

    public override void Run(string args)
    {
      foreach (IRerollable rerollable in Enumerable.OfType<IRerollable>(UnityEngine.Object.FindObjectsOfType<MonoBehaviour>()))
      {
        Debug.Log((object) string.Format("Rerolling [{0}]", (object) rerollable));
        if (rerollable.Reroll())
          return;
      }
      this.Fail("Nothing to reroll");
    }
  }

  public class CommandSystemDisable : Console.Command
  {
    public override string id => "system disable";

    public override string format => "system disable <name>";

    public override void Run(string args)
    {
      if (args.Length <= 0)
      {
        this.Fail("You must provide a system name");
      }
      else
      {
        System.Type type = System.Type.GetType(args + ",Assembly-CSharp");
        if (type == (System.Type) null)
        {
          this.Fail("System '" + args + "' not found! (it's case sensitive)");
        }
        else
        {
          MonoBehaviour objectOfType = UnityEngine.Object.FindObjectOfType(type) as MonoBehaviour;
          if ((UnityEngine.Object) objectOfType == (UnityEngine.Object) null)
          {
            this.Fail("System '" + args + "' does not exist!");
          }
          else
          {
            if (!objectOfType.enabled)
              this.Fail("'" + args + "' is already disabled");
            objectOfType.enabled = false;
          }
        }
      }
    }

    public override IEnumerator GetArgOptions(string currentArgs)
    {
      Console.CommandSystemDisable commandSystemDisable = this;
      yield return (object) null;
      IEnumerable<GameSystem> source = ((IEnumerable<GameSystem>) UnityEngine.Object.FindObjectsOfType<GameSystem>()).Where<GameSystem>((Func<GameSystem, bool>) (a => a.enabled && ((object) a).GetType().ToString().ToLower().Contains(currentArgs.ToLower())));
      commandSystemDisable.predictedArgs = source.Select<GameSystem, string>((Func<GameSystem, string>) (s => ((object) s).GetType().ToString())).ToArray<string>();
    }
  }

  public class CommandSystemEnable : Console.Command
  {
    public override string id => "system enable";

    public override string format => "system enable <name>";

    public override void Run(string args)
    {
      if (args.Length <= 0)
      {
        this.Fail("You must provide a system name");
      }
      else
      {
        System.Type type = System.Type.GetType(args + ",Assembly-CSharp");
        if (type == (System.Type) null)
        {
          this.Fail("System '" + args + "' not found! (it's case sensitive)");
        }
        else
        {
          MonoBehaviour objectOfType = UnityEngine.Object.FindObjectOfType(type) as MonoBehaviour;
          if ((UnityEngine.Object) objectOfType == (UnityEngine.Object) null)
          {
            this.Fail("System '" + args + "' does not exist!");
          }
          else
          {
            if (objectOfType.enabled)
              this.Fail("'" + args + "' is already enabled");
            objectOfType.enabled = true;
          }
        }
      }
    }

    public override IEnumerator GetArgOptions(string currentArgs)
    {
      Console.CommandSystemEnable commandSystemEnable = this;
      yield return (object) null;
      IEnumerable<GameSystem> source = ((IEnumerable<GameSystem>) UnityEngine.Object.FindObjectsOfType<GameSystem>()).Where<GameSystem>((Func<GameSystem, bool>) (a => !a.enabled && ((object) a).GetType().ToString().ToLower().Contains(currentArgs.ToLower())));
      commandSystemEnable.predictedArgs = source.Select<GameSystem, string>((Func<GameSystem, string>) (s => ((object) s).GetType().ToString())).ToArray<string>();
    }
  }

  public class CommandGameSpeed : Console.Command
  {
    public override string id => "gamespeed";

    public override string format => "gamespeed <value>";

    public override void Run(string args)
    {
      if (args.Length <= 0)
      {
        this.Fail("You must provide a value (1 = normal speed, 2 = double speed, 0.5 = half speed)");
      }
      else
      {
        float result;
        if (float.TryParse(args, out result) && (double) result >= 0.0)
          global::Events.InvokeTimeScaleChange(result);
        else
          this.Fail("Invalid value! (" + args + ")");
      }
    }
  }

  public class CommandMapJump : Console.Command
  {
    public override string id => "map jump";

    public override string desc => "to the selected map node";

    public override void Run(string args)
    {
      MapNode[] objectsOfType = UnityEngine.Object.FindObjectsOfType<MapNode>();
      if (objectsOfType.Length == 0)
      {
        this.FailCannotUse();
      }
      else
      {
        MapNode node = ((IEnumerable<MapNode>) objectsOfType).FirstOrDefault<MapNode>((Func<MapNode, bool>) (n => n.IsHovered));
        if ((UnityEngine.Object) node == (UnityEngine.Object) null)
        {
          this.Fail("You must be hovering over a map node");
        }
        else
        {
          Character player = References.Player;
          if (player != null)
          {
            MapNew.MoveTo(player, node);
            if (!node.campaignNode.type.canSkip)
              node.campaignNode.SetCleared();
            node.map.Continue(true);
          }
          else
            this.Fail("Player does not exist!");
        }
      }
    }
  }

  public class CommandMapInfo : Console.Command
  {
    public override string id => "map info";

    public override string format => "map info";

    public override bool IsRoutine => false;

    public override void Run(string args)
    {
      MapNode[] objectsOfType = UnityEngine.Object.FindObjectsOfType<MapNode>();
      if (objectsOfType.Length == 0)
      {
        this.FailCannotUse();
      }
      else
      {
        MapNode mapNode = ((IEnumerable<MapNode>) objectsOfType).FirstOrDefault<MapNode>((Func<MapNode, bool>) (n => n.IsHovered));
        if (!(bool) (UnityEngine.Object) mapNode)
        {
          this.Fail("You must be hovering over a map node");
        }
        else
        {
          Debug.Log((object) string.Format("[{0} {1}] info:", (object) mapNode.campaignNode.name, (object) mapNode.campaignNode.id));
          foreach (KeyValuePair<string, object> keyValuePair in mapNode.campaignNode.data)
          {
            switch (keyValuePair.Value)
            {
              case ICollection<string> values:
                Debug.Log((object) (keyValuePair.Key + ": " + string.Join(", ", (IEnumerable<string>) values)));
                continue;
              case SaveCollection<string> saveCollection:
                Debug.Log((object) (keyValuePair.Key + ": " + string.Join(", ", saveCollection.collection)));
                continue;
              default:
                Debug.Log((object) string.Format("{0}: {1}", (object) keyValuePair.Key, keyValuePair.Value));
                continue;
            }
          }
        }
      }
    }
  }

  public class CommandSetSaveProfile : Console.Command
  {
    public override string id => "save profile";

    public override string format => "save profile <name>";

    public override string desc => "switch save profile";

    public override void Run(string args)
    {
      if ((UnityEngine.Object) Campaign.instance == (UnityEngine.Object) null)
        SaveSystem.SetProfile(args);
      else
        this.Fail("Cannot switch save profile here!");
    }
  }

  public class CommandVolume : Console.Command
  {
    public readonly string busName;
    public readonly string internalId = "volume";
    public readonly string internalFormat = "volume <0-1>";

    public override string id => this.internalId;

    public override string format => this.internalFormat;

    public CommandVolume(string busName = "Master")
    {
      string lower = busName.ToLower();
      this.busName = lower == "sfx" ? "SFX" : lower.ToUpperFirstLetter();
      if (!(lower != "master"))
        return;
      this.internalId = "volume " + lower;
      this.internalFormat = this.internalId + " <0-1>";
    }

    public override void Run(string args)
    {
      if (args.Length <= 0)
      {
        this.Fail("You must provide a value between 0 and 1");
      }
      else
      {
        float result;
        if (float.TryParse(args, out result))
          AudioSettingsSystem.Volume(this.busName, result);
        else
          this.Fail("Invalid value! (" + args + ")");
      }
    }
  }

  public abstract class CommandOptions : Console.Command
  {
    public override string format => this.id + " <" + string.Join("/", this.options) + ">";

    public virtual string[] options
    {
      get => new string[2]{ "on", "off" };
    }

    public override IEnumerator GetArgOptions(string currentArgs)
    {
      // ISSUE: reference to a compiler-generated field
      int num = this.\u003C\u003E1__state;
      Console.CommandOptions commandOptions = this;
      if (num != 0)
      {
        if (num != 1)
          return false;
        // ISSUE: reference to a compiler-generated field
        this.\u003C\u003E1__state = -1;
        return false;
      }
      // ISSUE: reference to a compiler-generated field
      this.\u003C\u003E1__state = -1;
      commandOptions.predictedArgs = ((IEnumerable<string>) commandOptions.options).Where<string>((Func<string, bool>) (a => a.Contains(currentArgs.ToLower()))).ToArray<string>();
      // ISSUE: reference to a compiler-generated field
      this.\u003C\u003E2__current = (object) null;
      // ISSUE: reference to a compiler-generated field
      this.\u003C\u003E1__state = 1;
      return true;
    }
  }

  public abstract class CommandToggle : Console.CommandOptions
  {
    public override void Run(string args)
    {
      switch (args.ToLower())
      {
        case "on":
          this.TurnOn();
          break;
        case "off":
          this.TurnOff();
          break;
        default:
          this.Fail("You must enter either 'on' or 'off'");
          break;
      }
    }

    public virtual void TurnOn()
    {
    }

    public virtual void TurnOff()
    {
    }
  }

  public class CommandToggleHUD : Console.CommandToggle
  {
    public override string id => "hud";

    public override void TurnOn() => Settings.Save<float>("HudAlpha", 1f);

    public override void TurnOff() => Settings.Save<float>("HudAlpha", 0.0f);
  }

  public class CommandToggleFps : Console.CommandToggle
  {
    public override string id => "fps";

    public override void TurnOn() => Settings.Save<bool>("ShowFps", true);

    public override void TurnOff() => Settings.Save<bool>("ShowFps", false);
  }

  public class CommandCursor : Console.CommandOptions
  {
    public override string id => "cursor";

    public override string[] options
    {
      get => new string[3]{ "off", "game", "system" };
    }

    public override void Run(string args)
    {
      switch (args)
      {
        case "off":
          CustomCursor.visible = false;
          CustomCursor.UpdateState();
          break;
        case "game":
          CustomCursor.visible = true;
          CustomCursor.SetStyle("default");
          CustomCursor.UpdateState();
          break;
        case "system":
          CustomCursor.visible = true;
          CustomCursor.SetStyle("system");
          CustomCursor.UpdateState();
          break;
        default:
          this.Fail("Invalid cursor option");
          break;
      }
    }
  }

  public class CommandToggleHandOverlay : Console.CommandToggle
  {
    public override string id => "handoverlay";

    public override void TurnOn() => Settings.Save<bool>("HideHandOverlay", false);

    public override void TurnOff() => Settings.Save<bool>("HideHandOverlay", true);
  }

  public class CommandPrompt : Console.Command
  {
    public override string id => "prompt";

    public override string format => "prompt <anchor> <x> <y> <maxWidth> <text>";

    public override void Run(string args)
    {
      List<string> list = args.Split(' ', StringSplitOptions.None).ToList<string>();
      if (list.Count <= 4)
        return;
      Prompt.Anchor result1;
      float result2;
      float result3;
      float result4;
      if (Enum.TryParse<Prompt.Anchor>(list[0].ToUpperFirstLetter(), out result1) && float.TryParse(list[1], out result2) && float.TryParse(list[2], out result3) && float.TryParse(list[3], out result4))
      {
        list.RemoveRange(0, 4);
        string.Join(" ", (IEnumerable<string>) list);
        PromptSystem.Create(result1, result2, result3, result4);
      }
      else
        this.Fail("Invalid arguments");
    }
  }

  public class CommandPromptHide : Console.Command
  {
    public override string id => "prompthide";

    public override void Run(string args) => PromptSystem.Hide();
  }

  public class CommandErrorTest : Console.Command
  {
    public override string id => "errortest";

    public override string format => "errortest <message>";

    public override void Run(string args)
    {
      MonoBehaviourSingleton<Console>.instance.Toggle();
      throw new Exception(args);
    }
  }

  public class CommandPanSpeed : Console.Command
  {
    public override string id => "pan speed";

    public override string format => "pan speed <value (default 5)>";

    public override void Run(string args)
    {
      Scroller objectOfType = UnityEngine.Object.FindObjectOfType<Scroller>();
      if (objectOfType != null)
      {
        List<string> list = args.Split(' ', StringSplitOptions.None).ToList<string>();
        float result;
        if (list.Count > 0 && float.TryParse(list[0], out result))
          objectOfType.panSpeed = result;
        else
          this.Fail("Please enter a value");
      }
      else
        this.Fail("You must be in the town scene to use this command");
    }
  }

  public class CommandNextBattle : Console.Command
  {
    public override string id => "next battle";

    public override string format => "next battle <battle>";

    public override bool IsRoutine => true;

    public override IEnumerator Routine(string args)
    {
      Console.CommandNextBattle commandNextBattle = this;
      Campaign campaign = References.Campaign;
      if (campaign != null)
      {
        if (args.Length > 0)
        {
          yield return (object) AddressableLoader.LoadGroup("BattleData");
          BattleData battleData = AddressableLoader.GetGroup<BattleData>("BattleData").FirstOrDefault<BattleData>((Func<BattleData, bool>) (a => string.Equals(a.name, args.Trim(), StringComparison.CurrentCultureIgnoreCase)));
          if ((bool) (UnityEngine.Object) battleData)
          {
            int num = campaign.nodes.IndexOf(Campaign.FindCharacterNode(References.Player));
            CampaignNode campaignNode = (CampaignNode) null;
            for (int index = num; index < campaign.nodes.Count; ++index)
            {
              CampaignNode node = campaign.nodes[index];
              if (!node.cleared && node.type.isBattle)
              {
                campaignNode = node;
                break;
              }
            }
            if (campaignNode != null)
              campaignNode.data = new Dictionary<string, object>()
              {
                ["battle"] = (object) battleData.name,
                ["waves"] = (object) battleData.generationScript.Run(battleData, 1000)
              };
            else
              commandNextBattle.Fail("There are no more battles!");
          }
          else
            commandNextBattle.Fail("Battle [" + args + "] does not exist!");
        }
        else
          commandNextBattle.Fail("You must provide a battle name");
      }
      else
        commandNextBattle.Fail("You must be mid-run to use this command");
    }

    public override IEnumerator GetArgOptions(string currentArgs)
    {
      Console.CommandNextBattle commandNextBattle = this;
      yield return (object) AddressableLoader.LoadGroup("BattleData");
      IEnumerable<BattleData> source = AddressableLoader.GetGroup<BattleData>("BattleData").Where<BattleData>((Func<BattleData, bool>) (a => a.name.ToLower().Contains(currentArgs.ToLower())));
      commandNextBattle.predictedArgs = source.Select<BattleData, string>((Func<BattleData, string>) (upgradeData => upgradeData.name)).ToArray<string>();
    }
  }

  public class CommandProgressGain : Console.Command
  {
    public override string id => "progress gain";

    public override string format => "progress gain <amount>";

    public override bool IsRoutine => false;

    public override void Run(string args)
    {
      MetaprogressSequence objectOfType = UnityEngine.Object.FindObjectOfType<MetaprogressSequence>();
      if ((UnityEngine.Object) objectOfType == (UnityEngine.Object) null)
        this.Fail("You must be on the end screen to use this command");
      else if (objectOfType.running)
      {
        this.Fail("Wait for current progress sequence to end please");
      }
      else
      {
        float result;
        if (float.TryParse(args.Trim(), out result))
          objectOfType.StartCoroutine(objectOfType.Sequence(new float?(result)));
        else
          this.Fail("Invalid progress amount");
      }
    }
  }

  public class CommandProgressReset : Console.Command
  {
    public override string id => "progress reset";

    public override bool IsRoutine => false;

    public override void Run(string args) => SaveSystem.DeleteProgress();
  }

  public class LoadModCommand : Console.Command
  {
    public override string format => "loadmod modguid";

    public override string id => "loadmod";

    public override bool IsRoutine => false;

    public override void Run(string args)
    {
      string str = args.Split(' ', StringSplitOptions.None)[0];
      foreach (WildfrostMod mod in Bootstrap.Mods)
      {
        if (mod.GUID == str)
        {
          mod.ModLoad();
          break;
        }
      }
    }
  }

  public class PublishMod : Console.Command
  {
    public override string format => "publish modguid";

    public override string id => "publish";

    public override bool IsRoutine => false;

    public override async void Run(string args)
    {
      string str = args.Split(' ', StringSplitOptions.None)[0];
      foreach (WildfrostMod mod in Bootstrap.Mods)
      {
        if (mod.GUID == str)
        {
          mod.UpdateOrPublishWorkshop();
          break;
        }
      }
    }
  }

  public class UnLoadModCommand : Console.Command
  {
    public override string format => "unloadmod modguid";

    public override string id => "unloadmod";

    public override bool IsRoutine => false;

    public override void Run(string args)
    {
      string str = args.Split(' ', StringSplitOptions.None)[0];
      foreach (WildfrostMod mod in Bootstrap.Mods)
      {
        if (mod.GUID == str)
        {
          mod.ModUnload();
          break;
        }
      }
    }
  }

  public class CommandScreenshot : Console.Command
  {
    public override string id => "screenshot";

    public override bool IsRoutine => false;

    public override void Run(string args)
    {
      string path = Application.persistentDataPath + "/Screenshots";
      if (!System.IO.Directory.Exists(path))
        System.IO.Directory.CreateDirectory(path);
      string[] files = System.IO.Directory.GetFiles(path, "screen*.png");
      int a = 0;
      foreach (string str in files)
      {
        string[] separator = new string[1]{ "screen" };
        int result;
        if (int.TryParse(str.Split(separator, StringSplitOptions.None)[1].Replace(".png", ""), out result))
          a = Mathf.Max(a, result);
      }
      ScreenCapture.CaptureScreenshot(string.Format("{0}/screen{1}.png", (object) path, (object) (a + 1)));
    }
  }

  public class CommandBlood : Console.Command
  {
    public readonly Dictionary<string, string> colours = new Dictionary<string, string>()
    {
      {
        "red",
        "#E04141"
      },
      {
        "berry",
        "#FD557E"
      },
      {
        "black",
        "#222929"
      },
      {
        "blue",
        "#639FF1"
      },
      {
        "green",
        "#B8CC4B"
      },
      {
        "purple",
        "#392463"
      },
      {
        "pink",
        "#FE69FF"
      },
      {
        "snow",
        "#A9D5E9"
      }
    };

    public override string id => "blood";

    public override string format => "blood <color> <amount>";

    public override bool IsRoutine => true;

    public override IEnumerator Routine(string args)
    {
      string[] strArray = args.Split(' ', StringSplitOptions.None);
      string htmlString1 = strArray.Length != 0 ? (this.colours.ContainsKey(strArray[0]) ? this.colours[strArray[0]] : strArray[0]) : "";
      int result = 1;
      if (strArray.Length > 1)
        int.TryParse(strArray[1].Trim(), out result);
      if (result < 1)
        result = 1;
      float num = Mathf.Min((float) (result - 1) * 0.05f, 1f);
      Color color;
      ref Color local = ref color;
      bool htmlString2 = ColorUtility.TryParseHtmlString(htmlString1, out local);
      Routine.Clump clump = new Routine.Clump();
      for (int index = 0; index < result; ++index)
      {
        Vector3 pos = Cursor3d.Position + PettyRandom.Vector3() * num;
        clump.Add(Console.CommandBlood.Create(pos, htmlString2, color));
      }
      yield return (object) clump.WaitForEnd();
    }

    public static IEnumerator Create(Vector3 pos, bool setColor, Color color)
    {
      AsyncOperationHandle<GameObject> handle = AddressableLoader.InstantiateAsync("SplatterParticle", pos, Quaternion.identity);
      yield return (object) handle;
      if (setColor && (bool) (UnityEngine.Object) handle.Result)
      {
        SplatterParticle component = handle.Result.GetComponent<SplatterParticle>();
        if (component != null)
          component.color = color;
      }
    }

    public override IEnumerator GetArgOptions(string currentArgs)
    {
      // ISSUE: reference to a compiler-generated field
      int num = this.\u003C\u003E1__state;
      Console.CommandBlood commandBlood = this;
      if (num != 0)
        return false;
      // ISSUE: reference to a compiler-generated field
      this.\u003C\u003E1__state = -1;
      commandBlood.predictedArgs = commandBlood.colours.Keys.Where<string>((Func<string, bool>) (a => a.Contains(currentArgs.ToLower()))).ToArray<string>();
      return false;
    }
  }

  public class CommandRunFinalBossScript : Console.Command
  {
    public override string id => "finalbosstest";

    public override bool IsRoutine => false;

    public override void Run(string args)
    {
      PlayerData playerData = References.PlayerData;
      if (playerData != null)
        FinalBossDeckGenerationSystem.SetNewBoss(playerData);
      else
        this.Fail("Cannot use this command here");
    }
  }

  public class CommandDailyReset : Console.Command
  {
    public override string id => "daily reset";

    public override bool IsRoutine => false;

    public override void Run(string args) => SaveSystem.DeleteProgressData("dailyPlayed");
  }

  public class CommandDailyOffset : Console.Command
  {
    public override string id => "daily offset";

    public override string format => "daily offset <days>";

    public override bool IsRoutine => false;

    public override void Run(string args)
    {
      int result;
      if (int.TryParse(args, out result))
      {
        DailyFetcher.DayOffset = result;
        UnityEngine.Object.FindObjectOfType<BalloonSequence>()?.Close();
      }
      else
        this.Fail("Pls provide number of offset days");
    }
  }

  public class CommandEncrypt : Console.Command
  {
    public override string id => "encrypt";

    public override string format => "encrypt";

    public override bool IsRoutine => false;

    public override void Run(string args)
    {
      Console.CommandEncrypt.Encrypt("Save.sav");
      Console.CommandEncrypt.Encrypt("Campaign.sav");
      Console.CommandEncrypt.Encrypt("CampaignDemo.sav");
      Console.CommandEncrypt.Encrypt("CampaignDaily.sav");
      Console.CommandEncrypt.Encrypt("Stats.sav");
      Console.CommandEncrypt.Encrypt("History.sav");
    }

    public static void Encrypt(string fileName)
    {
      string filePath = SaveSystem.folderName + "/Decrypt/" + fileName;
      if (ES3.FileExists(filePath, ES3Settings.defaultSettings))
      {
        ES3.SaveRaw(ES3.LoadRawBytes(filePath, ES3Settings.defaultSettings), SaveSystem.folderName + "/" + fileName, SaveSystem.settings);
        Debug.Log((object) ("Re-encrypted [" + fileName + "]"));
      }
      else
        Debug.Log((object) ("[" + filePath + "] does not exist!"));
    }
  }

  public class CommandDecrypt : Console.Command
  {
    public override string id => "decrypt";

    public override string format => "decrypt";

    public override bool IsRoutine => false;

    public override void Run(string args)
    {
      Console.CommandDecrypt.Decrypt("Save.sav");
      Console.CommandDecrypt.Decrypt("Campaign.sav");
      Console.CommandDecrypt.Decrypt("CampaignDemo.sav");
      Console.CommandDecrypt.Decrypt("CampaignDaily.sav");
      Console.CommandDecrypt.Decrypt("CampaignTutorial.sav");
      Console.CommandDecrypt.Decrypt("Stats.sav");
      Console.CommandDecrypt.Decrypt("History.sav");
    }

    public static void Decrypt(string fileName)
    {
      string filePath1 = SaveSystem.folderName + "/" + fileName;
      if (ES3.FileExists(filePath1, SaveSystem.settings))
      {
        byte[] bytes = ES3.LoadRawBytes(filePath1, SaveSystem.settings);
        string str = SaveSystem.folderName + "/Decrypt/" + fileName;
        string filePath2 = str;
        ES3Settings defaultSettings = ES3Settings.defaultSettings;
        ES3.SaveRaw(bytes, filePath2, defaultSettings);
        Debug.Log((object) ("Decrypted [" + fileName + "] to [" + str + "]"));
      }
      else
        Debug.Log((object) ("[" + filePath1 + "] does not exist!"));
    }
  }

  public class CommandDisplay : Console.Command
  {
    public override string id => "resolution";

    public override string format => "resolution <width> <height>";

    public override bool IsRoutine => false;

    public override void Run(string args)
    {
      string[] strArray = args.Split(' ', StringSplitOptions.None);
      int result1;
      int result2;
      if (strArray.Length > 1 && int.TryParse(strArray[0].Trim(), out result1) && int.TryParse(strArray[1].Trim(), out result2))
        ScreenSystem.SetResolutionWindowed(result1, result2);
      else
        this.Fail("Incorrect format. Should be written as \"resolution <width> <height>\"");
    }
  }
}
