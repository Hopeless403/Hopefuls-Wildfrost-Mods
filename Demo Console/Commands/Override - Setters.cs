using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace WildfrostHopeMod.CommandsConsole
{
    public partial class ConsoleCustom
    {
        public class CommandCustomSetHealth : ConsoleCustom.Command
        {
            public override string id => "set health";
            public override string format => "set health <value>";

            public override void Run(string args)
            {
                if (args.Length < 1 || args == "null")
                    args = int.MinValue.ToString();
                //this.Fail("You must provide a value");
                if (Console.hover != null)
                {
                    int result;
                    if (!int.TryParse(args, out result) && args != "null")
                        this.Fail("Invalid value! (" + args + ")");
                    else if (References.Player == null)
                        this.Fail("Must be in a campaign to use this command");
                    else if (References.Player.entity.display is CharacterDisplay display && display.deckDisplay.gameObject.activeSelf)
                    {
                        if (Battle.instance != null)
                        {
                            this.FailCannotUse();
                            return;
                        }
                        if (result == int.MinValue) result = 0;
                        Console.hover.data.hasHealth = result >= 1 && args != int.MinValue.ToString();
                        if (!Console.hover.data.hasHealth)
                        {
                            Console.hover.display.healthIcon?.Destroy();
                            Console.hover.display.healthIcon = null;
                        }
                        Console.hover.data.hp = result;
                        CoroutineManager.Start(Console.hover.display.UpdateData(false));
                    }
                    else if (Console.hover.enabled)
                    {
                        Console.hover.data.hasHealth = result >= 1 && args != int.MinValue.ToString();
                        if (!Console.hover.data.hasHealth)
                        {
                            Console.hover.display.healthIcon?.Destroy();
                            Console.hover.display.healthIcon = null;
                        }
                        Console.hover.hp.current = result;
                        Console.hover.hp.max = Mathf.Max(Console.hover.hp.max, Console.hover.hp.current);
                        Console.hover.PromptUpdate();
                    }
                    else
                        this.Fail("Cannot use on this card");
                }
                else
                    Fail("Please hover over a card to use this command");
            }
            public override IEnumerator GetArgOptions(string currentArgs)
            {
                IEnumerable<string> source = new string[] {"null"}.Where(a => a.ToLower().Contains(currentArgs.ToLower()));
                predictedArgs = source.ToArray();
                yield break;
            }
        }
        public class CommandCustomSetAttack : ConsoleCustom.Command
        {
            public override string id => "set attack";

            public override string format => "set attack <value>";

            public override void Run(string args)
            {

                if (args.Length < 1 || args == "null")
                    args = int.MinValue.ToString();
                //this.Fail("You must provide a value");
                if (Console.hover != null)
                {
                    int result;
                    if (!int.TryParse(args, out result))
                        this.Fail("Invalid value! (" + args + ")");
                    else if (References.Player == null)
                        this.Fail("Must be in a campaign to use this command");
                    else if (References.Player.entity.display is CharacterDisplay display && display.deckDisplay.gameObject.activeSelf)
                    {
                        if (Battle.instance != null)
                        {
                            this.FailCannotUse();
                            return;
                        }
                        if (result == int.MinValue) result = 0;
                        Console.hover.data.hasAttack = result >= 0 && args != int.MinValue.ToString();
                        if (!Console.hover.data.hasAttack)
                        {
                            Console.hover.display.damageIcon?.gameObject.Destroy();
                            Console.hover.display.damageIcon = null;
                        }
                        Console.hover.data.damage = result;
                        CoroutineManager.Start(Console.hover.display.UpdateData(false));
                    }

                    else if (Console.hover.enabled)
                    {
                        Console.hover.data.hasAttack = result >= 0 && args != int.MinValue.ToString();
                        if (!Console.hover.data.hasAttack)
                        {
                            Console.hover.display.damageIcon?.gameObject.Destroy();
                            Console.hover.display.damageIcon = null;
                        }
                        Console.hover.damage.current = result;
                        Console.hover.damage.max = Mathf.Max(0, result);
                        Console.hover.PromptUpdate();
                    }
                    else
                        this.Fail("Cannot use on this card");
                }
                else
                    Fail("Please hover over a card to use this command");
            }
            public override IEnumerator GetArgOptions(string currentArgs)
            {
                IEnumerable<string> source = new string[] { "null" }.Where(a => a.ToLower().Contains(currentArgs.ToLower()));
                predictedArgs = source.ToArray();
                yield break;
            }
        }

        public class CommandCustomSetCounter : ConsoleCustom.Command
        {
            public override string id => "set counter";

            public override string format => "set counter <value>";

            public override void Run(string args)
            {
                if (args == "null")
                    args = "0";
                if (args.Length < 1)
                    this.Fail("You must provide a value");
                else if (Console.hover != null)
                {
                    int result;
                    if (!int.TryParse(args, out result) || result < 0)
                        this.Fail("Invalid value! (" + args + ")");
                    else if (References.Player == null)
                        this.Fail("Must be in a campaign to use this command");
                    else if (References.Player.entity.display is CharacterDisplay display && display.deckDisplay.gameObject.activeSelf)
                    {
                        if (Battle.instance != null)
                        {
                            this.FailCannotUse();
                            return;
                        }
                        Console.hover.display.counterIcon?.gameObject.SetActive(result > 0);
                        Console.hover.data.counter = result;
                        CoroutineManager.Start(Console.hover.display.UpdateDisplay(false));
                    }
                    else if (Console.hover.enabled)
                    {
                        Console.hover.display.counterIcon?.gameObject.SetActive(result > 0);
                        Console.hover.counter.current = result;
                        Console.hover.counter.max = result == 0 ? 0 : Mathf.Max(Console.hover.counter.max, result);
                        Console.hover.PromptUpdate();
                    }
                    else
                        this.Fail("Cannot use on this card");
                }
                else
                    this.Fail("Please hover over a card to use this command");
            }
            public override IEnumerator GetArgOptions(string currentArgs)
            {
                IEnumerable<string> source = new string[] { "null" }.Where(a => a.ToLower().Contains(currentArgs.ToLower()));
                predictedArgs = source.ToArray();
                yield break;
            }
        }
    }
}