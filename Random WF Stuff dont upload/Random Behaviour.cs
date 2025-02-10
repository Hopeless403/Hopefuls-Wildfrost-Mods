using UnityEngine;
using System.Linq;
using TMPro;
using UnityEngine.AddressableAssets;
using UnityEngine.Localization.Components;
//using Effect_Randomiser

namespace WildfrostHopeMod.Randoms
{
    public partial class HopeModBehaviour : MonoBehaviour
    {
        public RectTransform buttonPrefab = null;
        /*void Start()
        {
            Debug.LogWarning("starting");
            Debug.LogWarning(buttonPrefab = Addressables.LoadAssetAsync<GameObject>("Event-Item").WaitForCompletion().GetComponent<ItemEventRoutine>().skipButton.transform.parent.parent as RectTransform);

            if (GameObject.Find("Canvas/Safe Area/Menu/ButtonLayout"))
            {
                var button = Instantiate(buttonPrefab, GameObject.Find("Canvas/Safe Area/Menu/ButtonLayout").transform);
                button.gameObject.GetOrAdd<LayoutLink>().enabled = false;
                button.gameObject.GetOrAdd<LinkEnable>().enabled = false;
                //button.gameObject.GetComponent<TweenUI>().enabled = true ? true : false;

                var fitter = button.GetComponentInChildren<TextMeshProUGUI>().gameObject.GetOrAdd<TextFitter>();
                fitter.transforms = [button.transform as RectTransform];

                var textAsset = button.Find("Animator/Button").GetComponentInChildren<TextMeshProUGUI>();
                textAsset.gameObject.GetOrAdd<LocalizeStringEvent>().enabled = false;
                textAsset.text = "Button";
                StartCoroutine(fitter.FitRoutine());

                button.GetComponentInChildren<ButtonAnimator>().interactable = true;
                button.gameObject.SetActive(true);
            }

        }*/

        static MinibossIntroSystem system = null;
        internal void Update()
        {
            /*if (Battle.instance)
                Debug.Log(Battle.instance.playerMinibossCount);*/

            if (Input.GetKey(KeyCode.LeftAlt))
            {
                 if (Input.GetKeyDown(KeyCode.A))
                {
                    Battle.GetCards(Battle.instance.enemy)
                        .Update(ally => References.Battle.GetRows(Battle.instance.enemy)
                            .Where(row => row.Contains(ally))
                            .Select(row => row as CardSlotLane)
                            .ToList()
                            .Update(lane => Debug.LogWarning($"[{ally.name}] is in {string.Join(", ", ally.actualContainers)}")));
                }
                if (Input.GetKeyDown(KeyCode.D))
                {
                    system ??= GameObject.FindObjectOfType<MinibossIntroSystem>();
                    var source = Resources.FindObjectsOfTypeAll<BattleMusicSystem>();
                    if (source.Any())
                        Debug.LogWarning(SfxSystem.OneShot(source.First().minibossIntros.RandomItem().introEvent));
                    //Debug.LogWarning(SfxSystem.OneShot(system.zoomSfx));
                }
            }
        }
    }
}