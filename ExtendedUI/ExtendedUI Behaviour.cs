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
using UnityEngine.Events;
using UnityEngine.UI;

namespace ExtendedUI
{
    public class ExtendedUIModBehaviour : MonoBehaviour
    {
        public static UnityEvent lateUpdate = new UnityEvent();
        internal void Start()
        {

        }

        public static StormBellManager bellManager;
        void LateUpdate()
        {
            if (bellManager && bellManager.gameObject.activeInHierarchy)
            {
                foreach (var modifierIcon in bellManager.modifierIcons.Keys)
                {
                    modifierIcon.bellImage.material = modifierIcon.bellImage.defaultMaterial;
                    modifierIcon.dingerImage.material = modifierIcon.dingerImage.defaultMaterial;
                    modifierIcon.bellImage.maskable = true;
                    modifierIcon.dingerImage.maskable = true;
                }
            }

        }
    }
}