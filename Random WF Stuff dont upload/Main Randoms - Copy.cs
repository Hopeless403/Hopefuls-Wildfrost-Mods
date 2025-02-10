using Deadpan.Enums.Engine.Components.Modding;
using HarmonyLib;
using System;
using UnityEngine;
using System.Linq;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using WildfrostHopeMod.Utils;
using UnityEngine.Localization;
using UnityEngine.Localization.Settings;
using System.Runtime.InteropServices;
using System.Diagnostics.Eventing.Reader;
using Steamworks.Ugc;
using UnityExplorer;
using UnityEngine.EventSystems;
using System.Collections;
using System.Runtime.InteropServices.ComTypes;
using static CardData;
using static Steamworks.InventoryItem;
using UnityEngine.Scripting;
using ES3Types;
//using Effect_Randomiser

namespace WildfrostHopeMod.Randoms
{
    [Preserve]
    [ES3Properties(new string[] { "sprite", "color", "offset", "scale", "angle" })]
    public class ES3UserType_SplatterDataS : ES3UserType_SplatterData
    {
        public static ES3Type Instance;
        
        public ES3UserType_SplatterDataS()
          : base()
        {
            ES3UserType_SplatterDataS.Instance = (ES3Type)this;
            this.priority = 1;
        }

        public override void WriteObject(object obj, ES3Writer writer)
        {
            SplatterPersistenceSystem.SplatterData objectContainingField = (SplatterPersistenceSystem.SplatterData)obj;
            writer.WritePrivateFieldByRef("sprite", objectContainingField);
            writer.WritePrivateField("color", objectContainingField);
            writer.WritePrivateField("offset", objectContainingField);
            writer.WritePrivateField("scale", objectContainingField);
            writer.WritePrivateField("angle", objectContainingField);
        }

        public override void ReadObject<T>(ES3Reader reader, object obj)
        {
            SplatterPersistenceSystem.SplatterData objectContainingField = (SplatterPersistenceSystem.SplatterData)obj;
            foreach (string property in reader.Properties)
            {
                switch (property)
                {
                    case "sprite":
                        reader.SetPrivateField("sprite", reader.Read<Sprite>(), objectContainingField);
                        continue;
                    case "color":
                        reader.SetPrivateField("color", reader.Read<Color>(), objectContainingField);
                        continue;
                    case "offset":
                        reader.SetPrivateField("offset", reader.Read<Vector3>(), objectContainingField);
                        continue;
                    case "scale":
                        reader.SetPrivateField("scale", reader.Read<Vector3>(), objectContainingField);
                        continue;
                    case "angle":
                        reader.SetPrivateField("angle", reader.Read<float>(), objectContainingField);
                        continue;
                    default:
                        reader.Skip();
                        continue;
                }
            }
        }

        public override object ReadObject<T>(ES3Reader reader)
        {
            SplatterPersistenceSystem.SplatterData splatterData = new SplatterPersistenceSystem.SplatterData();
            this.ReadObject<T>(reader, splatterData);
            return splatterData;
        }
    }
}