using System;
using System.Collections.Generic;
using System.Linq;
using Deadpan.Enums.Engine.Components.Modding;
using HarmonyLib;
using UnityEngine;
using UnityEngine.UI;

namespace GooglyEye
{
    public class GooglyEyeMod : WildfrostMod
    {
        public GooglyEyeMod(string modDirectory) : base(modDirectory)
        {
        }

        public override string GUID => "kopie.wildfrost.googlyeye";
        public override string[] Depends => new string[] { };
        public override string Title => "Googly eyes mod";
        public override string Description => "Makes every card(if possible) to have googly eyes";

        public static GameObject GooglyEyePrefab;

        protected override void Load()
        {
            base.Load();
            
            
            GooglyEyePrefab = new GameObject("GooglyEye");
            GameObject.DontDestroyOnLoad(GooglyEyePrefab);
            GooglyEyePrefab.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontUnloadUnusedAsset |
                                        HideFlags.HideInInspector | HideFlags.NotEditable;
            GooglyEyePrefab.layer = 8;
            var pupil = new GameObject("GooglyEyePupil");
            GameObject.DontDestroyOnLoad(pupil);
            pupil.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontUnloadUnusedAsset |
                              HideFlags.HideInInspector | HideFlags.NotEditable;
            pupil.layer = 8;
            pupil.transform.SetParent(GooglyEyePrefab.transform);
         
            
            var img = GooglyEyePrefab.AddComponent<Image>();
            img.sprite = this.ImagePath("eye.png").ToSprite();
            img.rectTransform.sizeDelta = new Vector2(0.5f, 0.5f);
            var img2 = pupil.AddComponent<Image>();
            img2.sprite = this.ImagePath("pupil.png").ToSprite();
            img2.rectTransform.sizeDelta = new Vector2(0.15f, 0.15f);
            var e=GooglyEyePrefab.AddComponent<GooglyEye>();
            e.Eye = pupil.transform;
            e.Start();
        }

        public class GooglyEye : MonoBehaviour
        {
            public Transform Eye;
            [Range(0.5f, 10f)] public float Speed = 4.57f;
            [Range(0f, 5f)] public float GravityMultiplier = 0.48f;
            [Range(0.01f, 0.98f)] public float Bounciness = 0.4f;
            public float maxDistance = 0.1f;

            private Vector3 _origin;
            private Vector3 _velocity;
            private Vector3 _lastPosition;

            internal void Start()
            {
                if (!Eye) return;
                _origin = Eye.localPosition;
                _lastPosition = transform.position;
            }

            void Update()
            {
                if (!Eye) return;

                var currentPosition = transform.position;

                var gravity = transform.InverseTransformDirection(Physics.gravity);

                _velocity += gravity * GravityMultiplier * Time.deltaTime;
                _velocity += transform.InverseTransformVector((_lastPosition - currentPosition)) * 500f *
                             Time.deltaTime;
                _velocity.z = 0f;

                var position = Eye.localPosition;

                position += _velocity * Speed * Time.deltaTime;

                var direction = new Vector2(position.x, position.y);
                var angle = Mathf.Atan2(direction.y, direction.x);

                if (direction.magnitude > maxDistance)
                {
                    var normal = -direction.normalized;

                    _velocity = Vector2.Reflect(new Vector2(_velocity.x, _velocity.y), normal) * Bounciness;

                    position = new Vector3(
                        Mathf.Cos(angle) * maxDistance,
                        Mathf.Sin(angle) * maxDistance,
                        0f
                    );
                }

                position.z = Eye.localPosition.z;
                Eye.localPosition = position;
                _lastPosition = transform.position;
            }
        }

        protected override void Unload()
        {
            base.Unload();
            GameObject.Destroy(GooglyEyePrefab);
            GooglyEyePrefab = null;
            foreach (var eye in PatchTest1.Eyes)
            {
                eye.Value.ForEach(GameObject.Destroy);
            }
        }

        [HarmonyPatch(typeof(Card), nameof(Card.OnGetFromPool))]
        internal class PatchTest2
        {
            [HarmonyPostfix]
            static void TestPatch(Card __instance)
            {
                if (PatchTest1.Eyes.TryGetValue(__instance, out var existnig))
                {
                    foreach (var g in existnig)
                    {
                        GameObject.Destroy(g);
                    }
                }
            }
        }

        [HarmonyPatch(typeof(Card), nameof(Card.SetName), new Type[] { typeof(string) })]
        internal class PatchTest1
        {
            internal static Dictionary<Card, List<GameObject>> Eyes =
                new();

            [HarmonyPostfix]
            static void TestPatch(Card __instance)
            {
                Debug.LogWarning($"Googly eyes {nameof(Card.SetName)} patch");

                var data = __instance.entity.data;
                var eyeData = Extensions.GetEyeDataForCard(data);
                if (eyeData)
                {
                    if (Eyes.TryGetValue(__instance, out var existnig))
                    {
                        foreach (var g in existnig)
                        {
                            GameObject.Destroy(g);
                        }
                    }

                    Eyes[__instance] = new List<GameObject>();
                    foreach (var eye in eyeData.eyes)
                    {
                        var g = GooglyEyePrefab.gameObject.InstantiateKeepName();
                        var pr = __instance.gameObject.GetComponentInChildren<Canvas>().transform;
                        g.transform.SetParent(pr);
                        g.transform.localPosition = eye.position; ;
                        g.transform.localEulerAngles = new Vector3(0, 0, eye.rotation);
                        var img = g.GetComponent<Image>();
                        var sc = eye.scale;
                        float bigSize = sc.x > sc.y ? sc.x : sc.y;
                        img.rectTransform.sizeDelta = new Vector2(bigSize, bigSize) / 3f;
                        

                        Eyes[__instance].Add(g);
                    }
                }
            }
        }
    }
}