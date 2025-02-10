using System.Collections;
using System.Text;
using System.Threading.Tasks;
using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.UI;

namespace WildfrostHopeMod.Configs
{
    public class EventTriggerDescription : EventTrigger
    {
        public string desc;
        public GameObject button;
        public CardPopUpPanel panel;
        public bool overridePreprocessing = false;
        public override void OnPointerEnter(PointerEventData eventData)
        {
            CoroutineManager.Start(WhileHover());
        }
        public IEnumerator WhileHover()
        {
            if (!panel)
            {
                panel = CardPopUp.AddPanel(button.name + ".Description", "", desc).InstantiateKeepName();
                CardPopUp.RemovePanel(button.name + ".Description");
                panel.transform.SetParent(button.transform, true);
                panel.transform.localPosition = new Vector2(-2, 0);
                panel.transform.localScale = Vector3.one;
                panel.transform.ToRectTransform().pivot = new(1, 0.5f);
                panel.GetComponent<CanvasGroup>().alpha = 1;
            }
            if (overridePreprocessing)
            {
                panel.bodyText = desc;
                panel.BuildTextElement();
            }
            else panel.SetBody(desc, CardPopUpPanel.defaultBodyColor);
            yield return null;
            panel.GetComponentsInChildren<MaskableGraphic>().Update(e => e.maskable = false);
            yield return null;
            panel.gameObject.SetActive(true);
            yield return new WaitUntil(() => button.GetComponentInChildren<Image>().color.a < 0.5f);
            panel.gameObject.SetActive(false);
        }
    }



}
