using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UniverseLib.UI;

namespace CardEditor.UI.Panels
{
    public class AsciiPanel : UniverseLib.UI.Panels.PanelBase
    {
        public AsciiPanel(UIBase owner) : base(owner) { }

        public override string Name => "Ascii Panel";
        public override int MinWidth => 100;
        public override int MinHeight => 200;
        public override Vector2 DefaultAnchorMin => new(0.25f, 0.25f);
        public override Vector2 DefaultAnchorMax => new(0.75f, 0.75f);
        public override bool CanDragAndResize => true;

        internal string frameText = "Hello world";
        internal TextMeshProUGUI panelText;
        public override void ConstructUI()
        {
            Debug.LogWarning("UI STARTED!");
            base.ConstructUI();
            Debug.LogWarning("UI CREATED!");
            CoroutineManager.Start(Play(CardEditorMod.instance.ImagePath("play.txt")));
        }
        protected override void ConstructPanelContent()
        {
            panelText ??= /*UIFactory.*/CreateLabel(ContentRoot, "myText", frameText);
            panelText.text = frameText;
            UIFactory.SetLayoutElement(panelText.gameObject, minWidth: 200, minHeight: 25);

            Debug.LogWarning("UI PANEL CREATED!\n" + frameText);
        }

        // override other methods as desired
        public static TextMeshProUGUI CreateLabel(GameObject parent, string name, string defaultText, TextAlignmentOptions alignment = TextAlignmentOptions.MidlineLeft, Color color = default(Color), bool supportRichText = true, int fontSize = 14)
        {
            GameObject gameObject = UIFactory.CreateUIObject(name, parent);
            TextMeshProUGUI text = gameObject.AddComponent<TextMeshProUGUI>();
            text.text = defaultText;
            text.color = ((color == default(Color)) ? Color.white : color);
            text.alignment = alignment;
            text.fontSize = fontSize;
            return text;
        }
        public IEnumerator Play(string txtPath)
        {
            string raw = File.ReadAllText(txtPath, Encoding.UTF8).Replace('.', ' ');
            string[] frames = raw.Split(["SPLIT"], StringSplitOptions.RemoveEmptyEntries);
            foreach (string frame in frames)
            {
                //<mspace=0.25>
                frameText = "<sprite=snow><keyword=snow 1><mspace=5>";// + frame;
                frameText = Text.Process(frameText);
                //ConstructPanelContent();
                yield return new WaitForSecondsRealtime(0.05f);
                yield return new WaitUntil(() => this.Enabled && !true);
            }
        }
    }
}
