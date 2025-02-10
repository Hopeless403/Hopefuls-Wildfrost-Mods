using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

namespace ExtendedUI
{
    public class TribeFlagsGrid
    {
        public static void OnSceneChanged(Scene scene)
        {
            if (scene.name != "CharacterSelect") return;
            CoroutineManager.Start(TribeFlagsAsGrid());
        }
        public static IEnumerator TribeFlagsAsGrid()
        {
            var go = GameObject.Find("Canvas/SafeArea/TribeSelect");
            yield return new WaitForFixedUpdate();
            yield return new WaitForFixedUpdate();

            // avoid messing with AnotherSnowfall (lazy solution)
            if (!go.TryGetComponent(out GridLayoutGroup grid))
            {
                go.GetComponent<LayoutGroup>()?.Destroy();
                yield return new WaitForFixedUpdate();
                var layout = go.GetOrAdd<GridLayoutGroup>();
                layout.cellSize = new Vector2(3.33f, 4.5f);
                layout.childAlignment = TextAnchor.MiddleCenter;
                layout.constraint = GridLayoutGroup.Constraint.FixedColumnCount;
                layout.constraintCount = 4;
                layout.padding.top = 2;
                layout.padding.bottom = 1;
            }

            go.AddScrollers();
            yield return null;
            var transform = go.transform as RectTransform;
            var y = transform?.GetAllChildren().FirstOrDefault()?.position.y ?? 0;
            go.GetComponent<Scroller>().Scroll(y);
        }
    }
}
