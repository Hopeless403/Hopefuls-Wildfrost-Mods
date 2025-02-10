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

namespace WildFlipper
{
    internal class StatusEffectExtraFrenzy : StatusEffectMultiHit
    {

    }


    public class WildFlipperModBehaviour : MonoBehaviour
    {
        internal void Start()
        {
        }

        void Update()
        {
            //Debug.Log("Updating");
            if (Input.GetKey(KeyCode.LeftAlt))
            {
            }

            if (Input.GetKey(KeyCode.LeftControl) && Input.GetKeyDown(KeyCode.T))
            {
                Debug.LogError("YIPEEE");
                RuntimeManager.LoadBank("Custom_UI");
                Debug.LogWarning(RuntimeManager.HasBankLoaded("Custom_UI"));

                FMODUnity.RuntimeManager.StudioSystem.getBankList(out FMOD.Studio.Bank[] banks);
                var nones = new Dictionary<FMOD.Studio.EventDescription, FMOD.GUID>();
                foreach (var bank in banks)
                {
                    bank.getEventList(out var events);
                    foreach (var e in events)
                    {
                        e.getID(out FMOD.GUID guid);
                        e.getLength(out int length);
                        e.getPath(out string path);
                        //Debug.Log((path, length, guid));
                        if (path.IsNullOrEmpty())
                            nones[e] = guid;
                    }
                }

                var choice = nones.Values.RandomItems(1).First();
                Debug.LogWarning(choice);
                RuntimeManager.PlayOneShot(nones.Values.RandomItems(1).First());
                /*Debug.Log(RuntimeManager.PathToGUID("event:/sfx/scream"));
                Debug.Log(RuntimeManager.PathToGUID("event:/sfx/scream"));
                RuntimeManager.PlayOneShot("event:/sfx/scream");*/
            }
        }
    }
}