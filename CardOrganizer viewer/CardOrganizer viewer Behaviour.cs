using Deadpan.Enums.Engine.Components.Modding;
using FMODUnity;
using HarmonyLib;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace WildfrostHopeMod.CardOrganizerMod
{
    public class CardOrganizerBehaviour : MonoBehaviour
    {
        Transform t => Camera.main.transform;
        void Update()
        {
            if (!CardOrganizerMod.backButton)
                return;

            if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
                t.Translate(t.up);

            if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
                t.Translate(-t.up);

            if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
                t.Translate(-t.right);

            if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
                t.Translate(t.right);

            var transform = CardOrganizerMod.backButton.transform as RectTransform;
            if (transform)
            {
                HelpPanelSystem.instance.gameObject.SetActive(true);
                transform.position = (Camera.main.transform.position + HelpPanelSystem.instance.backButton.transform.position)
                    .WithZ(transform.position.z);
                var safeArea = HelpPanelSystem.instance.GetComponentInChildren<WorldSpaceCanvasSafeArea>();
                safeArea.waitForParent = true;
                safeArea.LateUpdate();
                HelpPanelSystem.instance.gameObject.SetActive(false);
            }
        }
    }
}