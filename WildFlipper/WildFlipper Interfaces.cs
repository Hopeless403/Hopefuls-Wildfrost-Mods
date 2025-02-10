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
using static WildFlipper.Helpers;

namespace WildFlipper
{
    public interface IAttribute { }
    public interface IWater : IAttribute { } 

    public interface IRace { }
    public interface IHuman : IRace { }
    public interface ISprite : IRace { }

}