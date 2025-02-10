using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.UI;

namespace WildfrostHopeMod.VFX
{
    public class TestingBehaviour : MonoBehaviour
    {
        private CardAnimationSFRumble anim;
        public void Start()
        {
            VFXMod.Mod.VFX.Initialize(GIFLoader.PlayType.applyEffect);
            Debug.Log("Started tests");/*
            anim = ScriptableObject.CreateInstance<CardAnimationSFRumble>();
            anim.name = "Test";
            anim.scaleTween = new CurveProfile()
            {
                duration = 1f,
                curve = new AnimationCurve()
                {
                    postWrapMode = WrapMode.Once,
                    preWrapMode = WrapMode.Once,
                    keys = new Keyframe[]
                    {
                        new Keyframe(0, 1)
                    }
                }
            };
            anim.rotateTween = new CurveProfile()
            {
                duration = 1f,
                curve = new AnimationCurve()
                {
                    postWrapMode = WrapMode.Once,
                    preWrapMode = WrapMode.Once,
                    keys = new Keyframe[]
                    {
                        new Keyframe(0, 0)
                    }
                }
            };
*/

            var moldPrefab = new GameObject("MoldPrefab");//, typeof(Moldbeast));
            GameObject.DontDestroyOnLoad(moldPrefab);

            var mb = moldPrefab.AddComponent<Moldbeast>();
            mb.originalID = moldPrefab.gameObject.GetInstanceID();
            Debug.LogWarning("test"+mb.originalID);
            ScriptableCardImage sc = AddressableLoader.GetGroup<CardData>("CardData").Find(a => a.name == "SnowGlobe").scriptableImagePrefab;
            foreach (var c in AddressableLoader.GetGroup<CardData>("CardData"))
            {
                if (sc) c.scriptableImagePrefab = sc;
                if (c.scriptableImagePrefab != null && c.cardType.name == "Leader")
                {
                    sc ??= c.scriptableImagePrefab;
                    c.scriptableImagePrefab.gameObject.AddComponent<ScriptableImageOverride>();
                    Debug.LogWarning($"{c.name} is moldy" + (c.scriptableImagePrefab != null));
                }
            }
        }
        public void Update()
        {
            if (Input.GetKey(KeyCode.LeftAlt) && Input.GetKeyDown(KeyCode.C))
            {
                Debug.LogWarning("Triggered!");
                if (Console.hover != null)
                {
                    Entity target = Console.hover;
                    Debug.LogWarning(target.display.name);
                    Events.InvokeEntityOffered(target);
                    //StartCoroutine(anim.Routine(target));
                }
            }
            
        }
    }

    public class NodeTestSequence : UISequence
    {
        private Entity target;
        public Character owner;
        [SerializeField]
        private TweenUI revealTween;
        [SerializeField]
        private TweenUI hideTween;
        [SerializeField]
        private CardContainer container;
        [SerializeField]
        private CardController controller;
        [SerializeField]
        private Button continueButton;

        /*private void OnEnable()
        {
            this.continueButton.interactable = true;
            this.controller.Enable();
        }

        private void OnDisable() => this.Clear();*/


        public void SetTarget(Entity target) => this.target = target;

        public override IEnumerator Run()
        {
            yield return null;
        }

    }










    public class ScriptableImageOverride : MonoBehaviour
    {
        public Image image;
        public Sprite[] frames;
        public float delay;
        private bool isOriginal;
        public int originalID = 0;
        private int currentFrameIndex = 1;
        private float frameTimer = 0;

        public void Start()
        {
            frames = VFXMod.Mod.VFX.prefabs["moldbeast"].GetComponent<GIFAnimator>().frames;
            image = GetComponent<Image>();
            isOriginal = gameObject.GetInstanceID() == originalID;
        }
        public void Update()
        {
            if (isOriginal || !image) return;
            frameTimer += Time.deltaTime;
            if (frameTimer > 0.01f)
            {
                frameTimer = 0f;
                image.sprite = frames[currentFrameIndex % frames.Length];
                currentFrameIndex++;
            }
        }
    }


    public class Moldbeast : ScriptableCardImage
    {
        public Image image;
        public Sprite[] sprites;
        public float delay = 0.1f;
        private bool isOriginal;
        public int originalID = 0;
        private GIFLoader VFX;
        public GameObject go;

        public void Start()
        {
            VFX = VFXMod.Mod.VFX;
            sprites = VFX.prefabs["vanish"].GetComponent<GIFAnimator>().frames;
            isOriginal = gameObject.GetInstanceID() == originalID;
            Debug.Log("someone is moldy????" + !isOriginal);
        }
        public override void AssignEvent()
        {
            Debug.LogWarning("woah, a sign");
            var tra = (this.entity.display as Card).mainImage.transform;
            Debug.LogWarning("the main image is at " + tra.position);
            image = Instantiate((this.entity.display as Card).mainImage, tra.position, Quaternion.identity);
            image.transform.localScale = tra.localScale;

        }

        public override void UpdateEvent()
        {
            if (this.entity.isActiveAndEnabled)
            {

                Debug.LogWarning("this guy exists, yep");
                if (!isOriginal && image)
                    Debug.LogWarning("Yep, image is here" + image);
                Debug.LogWarning(image.transform.position);
                Debug.LogWarning(image.sprite != null);
                Debug.LogWarning(image.isActiveAndEnabled);

            }
        }
        private void Update()
        {
            if (!isOriginal && image)
            {
                this.image.sprite = sprites.RandomItem();
            }
        }
    }

    public class CardAnimationSFRumble : CardAnimation
    {
        [SerializeField]
        private float rumbleAmount = 1f;
        [SerializeField]
        private float wobbleAmount = 1f;
        [SerializeField]
        public CurveProfile scaleTween;
        [SerializeField]
        private Vector3 scaleTo = new Vector3(1f, 1f, 1f);
        [SerializeField]
        public CurveProfile rotateTween;
        [SerializeField]
        private Vector3 rotateAmount = new Vector3(1f, 1f, 5f);

        public override IEnumerator Routine(object data, float startDelay = 0.0f)
        {
            if (data is Entity target)
            {
                yield return new WaitForSeconds(startDelay);
                float seconds = Mathf.Max(scaleTween.duration, rotateTween.duration);
                //float seconds = 1;
                Events.InvokeScreenRumble(0.0f, rumbleAmount, 0.0f, seconds * 0.5f, seconds * 0.5f, seconds * 0.5f);
                target.wobbler?.WobbleRandom(wobbleAmount);
                LeanTween.scale(target.gameObject, scaleTo, scaleTween.duration).setEase(scaleTween.curve);
                LeanTween.rotateLocal(target.gameObject, rotateAmount, rotateTween.duration).setEase(rotateTween.curve);
                yield return new WaitForSeconds(seconds);
            }
        }
    }
    
}
