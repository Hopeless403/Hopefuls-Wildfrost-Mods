using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace WildfrostHopeMod.KeyboardSupport
{
    public class FixScrollToNavigations : MonoBehaviour
    {
        public readonly Type componentType = typeof(ScrollToNavigation);
        public readonly Type[] scrollerTypes = [typeof(Scroller), typeof(SmoothScrollRect)];

        public readonly string[] scenesToFix = ["Mods"];
        public void OnEnable()
        {
            Events.OnSceneLoaded += FixScene;
        }
        public void OnDisable()
        {
            Events.OnSceneLoaded -= FixScene;
        }
        public void FixScene(Scene scene)
        {
            if (!scenesToFix.Contains(scene.name)) return;
            foreach (var scroller in Resources.FindObjectsOfTypeAll<Scroller>())
                scroller.gameObject.GetOrAdd<ScrollToNavigation>().scroller = scroller;
            foreach (var scrollRect in Resources.FindObjectsOfTypeAll<SmoothScrollRect>())
                scrollRect.gameObject.GetOrAdd<ScrollToNavigation>().scrollRect = scrollRect;
        }
    }
}