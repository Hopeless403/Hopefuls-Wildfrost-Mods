using UnityEngine;
using UnityEngine.UI;

namespace WildfrostHopeMod.MapleFrost
{
    /// <summary>
    /// textureRectOffset = padding of the texture sprite from the bottom left
    /// </summary>
    public class ScriptableImageSplitBoss : ScriptableCardImage
    {
        public static ScriptableCardImage image;
        public static ScriptableCardImage Build()
        {
            if (image == null)
            {
                // Create a new GameObject that will host the ScriptableImage
                var scriptObject = new GameObject("SplitBoss", typeof(RectTransform), typeof(ScriptableCardImage));
                // Ensure the GameObject is kept in memory this session
                GameObject.DontDestroyOnLoad(scriptObject);

                // Set the GameObject's size 
                RectTransform rectTransform = scriptObject.GetOrAdd<RectTransform>();
                rectTransform.sizeDelta = new Vector2(1, 1);
                rectTransform.localPosition = new Vector2(0.2f, 1.6f);
                rectTransform.localScale = new Vector2(0.8f, 0.8f);

                Debug.LogWarning("DOING LOWER");
                #region Lower
                // Create the root (lower section)
                var lowerObj = new GameObject("Lower", typeof(RectTransform), typeof(Image));//, typeof(AngleWobbler));
                lowerObj.SetActive(false);
                lowerObj.transform.SetParent(scriptObject.transform);

                RectTransform rectTransformLower = lowerObj.GetOrAdd<RectTransform>();
                rectTransformLower.sizeDelta = new Vector2(8, 10);
                rectTransformLower.localPosition = new Vector3(0.0449f, -2.82f, 0.3f);
                rectTransformLower.localScale = new Vector2(1f, 1f);

                Image imageLower = lowerObj.GetOrAdd<Image>();
                imageLower.preserveAspect = true;
                imageLower.raycastTarget = false;
                imageLower.sprite = CardEditorMod.Mod.IconSprite; // wip: replace with lower body sprite

                AngleWobbler wobblerLower = lowerObj.GetOrAdd<AngleWobbler>();
                // unsure if these are needed or are autofilled
                wobblerLower.holder = scriptObject.transform;
                wobblerLower.target = lowerObj.transform;

                wobblerLower.movementInfluence = new Vector2(-1, 0);
                wobblerLower.rotationMax = 3;
                wobblerLower.wobbleFactorRange = new Vector2(7, 9);
                wobblerLower.wobbleDampingRange = new Vector2(0.91f, 0.93f);
                wobblerLower.wobbleAccRange = new Vector2(0.65f, 0.75f);
                wobblerLower.wobbleFactor = 8.429f;
                wobblerLower.wobbleDamping = 0.911f;
                wobblerLower.wobbleAcc = 0.6752f;
                #endregion
                Debug.LogWarning("DOING UPPER");
                #region Upper
                // Create the root (upper section)
                var upperObj = new GameObject("Upper", typeof(RectTransform));//, typeof(AngleWobbler));
                upperObj.transform.SetParent(lowerObj.transform);
                upperObj.SetActive(false);

                RectTransform rectTransformUpper = upperObj.GetOrAdd<RectTransform>();
                rectTransformUpper.sizeDelta = new Vector2(8, 10);
                rectTransformUpper.localPosition = new Vector3(0.5267f, 0.9412f, -0.3f);
                rectTransformUpper.localScale = new Vector2(1f, 1f);

                AngleWobbler wobblerUpper = upperObj.GetOrAdd<AngleWobbler>();
                // unsure if these are needed or are autofilled
                wobblerUpper.holder = scriptObject.transform;
                wobblerUpper.target = upperObj.transform;

                wobblerUpper.movementInfluence = new Vector2(-1, 0.25f);
                wobblerUpper.rotationMax = 3;
                wobblerUpper.wobbleFactorRange = new Vector2(7, 9);
                wobblerUpper.wobbleDampingRange = new Vector2(0.91f, 0.93f);
                wobblerUpper.wobbleAccRange = new Vector2(0.65f, 0.75f);
                wobblerUpper.wobbleFactor = 7.2975f;
                wobblerUpper.wobbleDamping = 0.9279f;
                wobblerUpper.wobbleAcc = 0.739f;
                #endregion
                Debug.LogWarning("DOING MID");
                #region Mid
                // Create the root (lower section)
                var midObj = new GameObject("Mid", typeof(RectTransform), typeof(Image), typeof(CopyRectTransform));
                midObj.transform.SetParent(lowerObj.transform);

                RectTransform rectTransformMid = midObj.GetOrAdd<RectTransform>();
                rectTransformMid.sizeDelta = new Vector2(8, 10);
                rectTransformMid.localPosition = new Vector3(0.5267f, 0.9412f, -0.3f);
                rectTransformMid.localScale = new Vector2(1f, 1f);

                Image imageMid = midObj.GetOrAdd<Image>();
                imageMid.preserveAspect = true;
                imageMid.raycastTarget = false;
                imageMid.sprite = CardEditorMod.Mod.IconSprite; // wip: replace with mid body sprite

                CopyRectTransform copyMid = midObj.GetOrAdd<CopyRectTransform>();
                copyMid.target = rectTransformUpper;
                #endregion
                Debug.LogWarning("DOING HEAD");
                #region Head
                // Create the root (lower section)
                var headObj = new GameObject("Head", typeof(RectTransform), typeof(Image), typeof(CopyRectTransform));
                headObj.transform.SetParent(upperObj.transform);

                RectTransform rectTransformHead = headObj.GetOrAdd<RectTransform>();
                rectTransformHead.sizeDelta = new Vector2(8, 10);
                rectTransformHead.localPosition = new Vector3(-0.6141f, 1.2385f, -0.3f);
                rectTransformHead.localScale = new Vector2(1f, 1f);

                Image imageHead = headObj.GetOrAdd<Image>();
                imageHead.preserveAspect = true;
                imageHead.raycastTarget = false;
                imageHead.sprite = CardEditorMod.Mod.IconSprite; // wip: replace with mid body sprite

                AngleWobbler wobblerHead = headObj.GetOrAdd<AngleWobbler>();
                // unsure if these are needed or are autofilled
                wobblerHead.holder = scriptObject.transform;
                wobblerHead.target = headObj.transform;

                wobblerHead.movementInfluence = new Vector2(-2, 0.1f);
                wobblerHead.rotationMax = 3;
                wobblerHead.wobbleFactorRange = new Vector2(7, 9);
                wobblerHead.wobbleDampingRange = new Vector2(0.91f, 0.93f);
                wobblerHead.wobbleAccRange = new Vector2(0.65f, 0.75f);
                wobblerHead.wobbleFactor = 8.7973f;
                wobblerHead.wobbleDamping = 0.9291f;
                wobblerHead.wobbleAcc = 0.7323f;
                #endregion

                scriptObject.SetActive(true);
                image = scriptObject.GetOrAdd<ScriptableCardImage>();
            }
            return image;
        }
    }

}
