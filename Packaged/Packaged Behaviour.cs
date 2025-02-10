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

namespace WildfrostHopeMod.Packaged
{
    public class PackagedModBehaviour : MonoBehaviour
    {
        internal void Start()
        {
        }

        void Update()
        {
            if (Input.GetKey(KeyCode.LeftAlt))
            {
            }

            if (Input.GetKey(KeyCode.LeftControl) && Input.GetKeyDown(KeyCode.T))
            {
            }
        }
    }
}