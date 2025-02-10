using System;
using TMPro;
using Unity.Burst;
using UnityEngine;
using UnityEngine.UI;

namespace WildfrostHopeMod.Configs
{
    public static class Templates
    {
        static JournalPage page;
        public static JournalPage Page => page ??= new Func<JournalPage>(() =>
        {
            GameObject obj = new GameObject("Template Page", typeof(RectTransform), typeof(VerticalLayoutGroup), typeof(ContentSizeFitter), typeof(JournalPageMenu));
            GameObject.DontDestroyOnLoad(obj);

            VerticalLayoutGroup layout = obj.GetComponent<VerticalLayoutGroup>();
            layout.childForceExpandHeight = false;
            layout.childForceExpandWidth = false;
            layout.childAlignment = TextAnchor.MiddleCenter;

            ContentSizeFitter fitter = obj.GetComponent<ContentSizeFitter>();
            fitter.verticalFit = ContentSizeFitter.FitMode.PreferredSize;
            fitter.horizontalFit = ContentSizeFitter.FitMode.PreferredSize;

            return obj.GetComponent<JournalPageMenu>();
        })();

        public static JournalPage CreatePage(Transform parent, string name)
        {
            if (!Page)
                return null;
            JournalPage page = Page.InstantiateKeepName();
            page.transform.SetParent(parent);
            page.name = name;
            return page;
        }




        static TextMeshProUGUI title;
        public static TextMeshProUGUI Title => title ??= new Func<TextMeshProUGUI>(() =>
        {
            GameObject obj = new GameObject("Title", typeof(RectTransform), typeof(TextMeshProUGUI), typeof(LayoutElement));
            GameObject.DontDestroyOnLoad(obj);

            TextMeshProUGUI title = obj.GetComponent<TextMeshProUGUI>();
            title.alignment = TextAlignmentOptions.Center;
            title.color = new Color(0.3882f, 0.2314f, 0.2157f);
            title.enableWordWrapping = true;
            title.fontSize = 0.5f;
            title.maskable = true;

            LayoutElement layout = obj.GetComponent<LayoutElement>();
            layout.preferredWidth = 6;

            return title;
        })();


        public static TextMeshProUGUI CreateTitle(Transform parent, string text, string name = "Title")
        {
            if (!Title)
                return null;
            TextMeshProUGUI title = Title.InstantiateKeepName();
            title.transform.SetParent(parent);
            title.text = text;
            title.name = name;
            return title;
        }
    }
}
