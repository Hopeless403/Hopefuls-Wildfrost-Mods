using HarmonyLib;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using TMPro;
using UnityEngine;
using WildfrostHopeMod.SFX;
using WildfrostHopeMod.VFX;
using static WildfrostHopeMod.Text.PatchDescWhileTypewriting;

namespace WildfrostHopeMod.Text
{
    [HarmonyPatch(typeof(Card), "SetDescription")]
    public class PatchDescWhileTypewriting
    {
        static public HashSet<Card> talkers = new();
        static bool Prefix(Card __instance) => !talkers.Contains(__instance);
    }
    [HarmonyPatch(typeof(Console), nameof(Console.Commands))]
    internal class PatchAddCommandTalk 
    {
        static void Postfix()
        {
            var command = new CommandTalk();
            if (Console.commands.Any(c => c.id == command.id)) return;
            MonoBehaviour.print(command.id);
            Console.commands.Add(command);
        }
    }
    public class CommandTalk : Console.Command
    {
        public override string id => "talk";
        public override string format => "talk <text?>";
        public override void Run(string args)
        {
            if (Console.hover == null)
                Fail("Please hover over a card to use this command");
            else
            {
                var writer = Console.hover.gameObject.GetOrAdd<TypewriterController>();
                var revealHandler = () => writer.Untalk(delay: 1, delayAfter: 1);
                var hiddenHandler = writer.Reset;

                writer.OnCompleteTextRevealed -= revealHandler;
                writer.OnCompleteTextHidden -= hiddenHandler;

                writer.OnCompleteTextRevealed += revealHandler;
                writer.OnCompleteTextHidden += hiddenHandler;

                var text = args.IsNullOrWhitespace() ? (Console.hover.display as Card).descText.text : args;
                writer.Talk(text);
            }
        }
    }
    public class CardScriptAddComponentTypewriter : CardScript
    {
        public override void Run(CardData target) => 
            Events.OnEntityCreated += entity => entity.gameObject.GetOrAdd<TypewriterController>();
    }

    [RequireComponent(typeof(Card))]
    public class TypewriterController : MonoBehaviour
    {
        Card card => GetComponent<Card>();
        TextMeshProUGUI desc => card.descText;
        Entity entity => card.entity;

        public float charactersPerSecond = 20;
        public float simpleDelay => 1 / charactersPerSecond;
        public float interpunctuationDelay = 0.5f;
        public float hidePerSecond = 100;

        private bool _talking = false;
        public bool talking 
        { 
            get => _talking;
            private set => _ = (_talking = value) ? talkers.Add(card) : talkers.Remove(card);
        }
        Coroutine _typewriterCoroutine;

        public event Action OnCompleteTextRevealed;
        public event Action<char> OnCharacterRevealed;

        public event Action OnCompleteTextHidden;
        public event Action<char> OnCharacterHidden;

        public List<FMOD.Sound> talkSounds = new();


        public void Talk(string text, float delay = 0, float charactersPerSecond = 20, float interpunctuationDelay = 0.5f, float delayAfter = 0.25f)
        {
            /*if (talking)
                return;*/

            this.charactersPerSecond = charactersPerSecond;
            this.interpunctuationDelay = interpunctuationDelay;

            if (_typewriterCoroutine != null)
                StopCoroutine(_typewriterCoroutine);

            desc.text = text;
            _typewriterCoroutine = StartCoroutine(Appear(delay, delayAfter));
        }
        public void Talk(float delay = 0, float charactersPerSecond = 20, float interpunctuationDelay = 0.5f, float delayAfter = 0.25f) =>
            Talk(desc.text, delay, charactersPerSecond, interpunctuationDelay, delayAfter);
        public void Untalk(float delay = 0, float hidePerSecond = 100, float delayAfter = 0.25f)
        {
            /*if (talking)
                return;*/

            this.hidePerSecond = hidePerSecond;

            if (_typewriterCoroutine != null)
                StopCoroutine(_typewriterCoroutine);

            _typewriterCoroutine = StartCoroutine(Disappear(delay, delayAfter));
        }
        public void Reset()
        {
            if (_typewriterCoroutine != null)
                StopCoroutine(_typewriterCoroutine);
            talking = false;
            desc.maxVisibleCharacters = 99999;
            card.SetDescription();
        }
        private IEnumerator Appear(float delay = 0, float delayAfter = 0.25f)
        {
            if (delay > 0)
                yield return new WaitForSeconds(delay);
            talking = true;
            //Debug.LogWarning("Talking: " + card.titleText.text);
            desc.maxVisibleCharacters = 0;
            for (int i = 0; i < desc.GetParsedText().Length; ++i)
            {
                //char ch = Dead.Random.Choose(this.extraChars.RandomItem<char>(), text[Mathf.Max(0, i - 1)]);
                //desc.text = text.Remove(i, 1).Insert(i, string.Format("<#{0}>{1}</color>", this.extraCharColourHexes.RandomItem<string>(), ch));
                desc.maxVisibleCharacters = i;
                char character = desc.text[i];
                /*yield return new WaitForSeconds((character == '?' || character == '.' || character == ',' || character == ':' ||
                          character == ';' || character == '!' || character == '-') ?
                interpunctuationDelay : simpleDelay);*/

                OnCharacterRevealed?.Invoke(character);
                yield return new WaitForSeconds(1 / charactersPerSecond);
            }
            desc.maxVisibleCharacters = 99999;
            if (delayAfter > 0)
                yield return new WaitForSeconds(delayAfter);
            //Debug.LogWarning("Finished talking: " + card.titleText.text);
            OnCompleteTextRevealed?.Invoke();
            talking = false;
        }
        private IEnumerator Disappear(float delay = 0, float delayAfter = 0.25f)
        {
            if (delay > 0)
                yield return new WaitForSeconds(delay);
            talking = true;
            //Debug.LogWarning("UnTalking: " + card.titleText.text);
            desc.maxVisibleCharacters = desc.GetParsedText().Length;
            for (int i = desc.GetParsedText().Length-1; i > 0; --i)
            {
                desc.maxVisibleCharacters = i;
                char character = desc.text[i];

                OnCharacterHidden?.Invoke(character);
                if (character != ' ')
                    yield return new WaitForSeconds(1 / hidePerSecond);
            }
            desc.maxVisibleCharacters = 0;
            if (delayAfter > 0)
                yield return new WaitForSeconds(delayAfter);
            //Debug.LogWarning("Finished untalking: " + card.titleText.text);
            OnCompleteTextHidden?.Invoke();
            talking = false;
        }
        void Awake()
        {
            //talkSounds.Add(SFXLoader.LoadSoundFromPath(Path.Combine(VFXMod.Mod.ImagesDirectory, "sansfx.mp3")));
            OnCharacterRevealed += c => _ = c == ' ' ? default : SFXLoader.PlayRandomSound(talkSounds);
        }
        void OnDisable() => Reset();
    }
}
