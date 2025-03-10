﻿// Decompiled with JetBrains decompiler
// Type: Pokefrost.EyeDataAdder
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

#nullable disable
namespace Pokefrost
{
  public static class EyeDataAdder
  {
    private static Dictionary<string, (float, float, float, float, float)[]> eyeDictionary = new Dictionary<string, (float, float, float, float, float)[]>()
    {
      {
        "websiteofsites.wildfrost.pokefrost.alolansandslash",
        new (float, float, float, float, float)[2]
        {
          (0.6f, 0.8f, 0.8f, 1.2f, 45f),
          (1.1f, 0.8f, 0.4f, 0.7f, -10f)
        }
      }
    };

    public static void Eyes()
    {
      AddressableLoader.AddRangeToGroup<EyeData>("EyeData", (IEnumerable<EyeData>) new List<EyeData>()
      {
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.abomasnow", (0.36f, 1.9f, 1.2f, 1.2f, 0.0f), (-0.08f, 1.9f, 1.2f, 1.2f, 0.0f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.absol", (-0.32f, 1.47f, 0.8f, 0.8f, 0.0f), (-0.67f, 1.46f, 0.8f, 0.8f, 0.0f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.aggron", (0.67f, 1.94f, 0.7f, 0.7f, 0.0f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.alolanmarowak", (0.5f, 0.75f, 0.7f, 1.3f, 45f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.alolansandslash", (1.09f, 0.79f, 0.5f, 1.3f, 340f), (0.62f, 0.77f, 0.8f, 1.5f, 40f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.ambipom", (-0.25f, 1.17f, 0.7f, 0.9f, 0.0f), (0.22f, 1.16f, 0.7f, 0.9f, 0.0f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.bastiodon", (0.28f, 0.59f, 1f, 1f, 55f), (1.06f, 0.8f, 0.8f, 0.8f, 55f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.chandelure", (-0.03f, 0.82f, 1f, 1f, 0.0f), (0.58f, 0.71f, 0.4f, 0.8f, 0.0f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.chimecho", (0.22f, 1.84f, 0.6f, 0.6f, 0.0f), (0.57f, 1.74f, 0.5f, 0.5f, 0.0f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.cradily", (0.01f, 1.11f, 1f, 1.6f, 0.0f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.crustle", (0.39f, 0.41f, 0.6f, 0.9f, 10f), (0.75f, 0.39f, 0.5f, 0.9f, 345f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.dusclops", (0.44f, 1.57f, 1.3f, 1.3f, 0.0f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.electrode", (0.04f, 1.11f, 1f, 1.1f, 0.0f), (0.97f, 1.18f, 1f, 1.1f, 0.0f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.empoleon", (-0.21f, 1.9f, 0.5f, 0.5f, 0.0f), (0.06f, 1.9f, 0.4f, 0.4f, 0.0f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.espeon", (0.57f, 1.44f, 1f, 1f, 0.0f), (1.04f, 1.65f, 0.8f, 0.8f, 335f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.farfetchd", (-0.17f, 1.3f, 0.7f, 1f, 0.0f), (0.2f, 1.26f, 0.5f, 0.9f, 350f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.flareon", (0.75f, 0.57f, 0.9f, 0.9f, 350f), (1.14f, 0.65f, 0.3f, 0.6f, 0.0f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.furret", (-0.19f, 1.89f, 0.6f, 0.6f, 0.0f), (0.18f, 1.95f, 0.5f, 0.5f, 0.0f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.gallade", (-0.08f, 1.66f, 0.8f, 0.8f, 0.0f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.garbodor", (-0.43f, 1.49f, 0.9f, 0.9f, 0.0f), (0.33f, 1.57f, 0.8f, 0.9f, 20f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.gardevoir", (0.63f, 1.92f, 0.8f, 0.8f, 0.0f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.gengar", (-0.15f, 1.13f, 1.3f, 1.3f, 0.0f), (0.53f, 1.31f, 1.2f, 1.2f, 0.0f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.glaceon", (0.62f, 1.13f, 0.9f, 0.9f, 0.0f), (0.97f, 1.22f, 0.6f, 0.8f, 0.0f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.goomy", (0.36f, 0.94f, 1f, 1f, 0.0f), (0.69f, 0.9f, 1f, 1f, 0.0f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.gyarados", (1.04f, 1.17f, 0.8f, 1f, 0.0f), (1.31f, 1.2f, 0.6f, 1f, 0.0f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.hariyama", (0.08f, 1.63f, 1f, 1.2f, 0.0f), (0.55f, 1.73f, 0.8f, 1.1f, 0.0f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.hippowdon", (-0.15f, 1.25f, 0.7f, 1.2f, 0.0f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.hisuiansneasel", (0.22f, 1.26f, 1.2f, 1.2f, 0.0f), (0.78f, 1.31f, 0.9f, 0.9f, 0.0f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.honchkrow", (-0.19f, 1.35f, 1f, 1f, 0.0f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.jolteon", (0.93f, 1.23f, 1.2f, 1.2f, 0.0f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.kingambit", (0.03f, 1f, 0.6f, 0.6f, 0.0f), (0.23f, 1f, 0.6f, 0.6f, 0.0f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.kingdra", (0.53f, 1.42f, 1.2f, 1.2f, 0.0f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.klefki", (-0.22f, 0.69f, 0.6f, 0.8f, 0.0f), (0.06f, 0.71f, 0.6f, 0.8f, 0.0f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.leafeon", (0.56f, 1.16f, 1f, 1f, 0.0f), (0.97f, 1.17f, 1f, 1f, 0.0f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.lickilicky", (-0.14f, 2.02f, 1.1f, 1.1f, 0.0f), (0.49f, 2.03f, 1.1f, 1.1f, 0.0f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.ludicolo", (-0.07f, 1.41f, 0.9f, 1.2f, 15f), (0.26f, 1.48f, 0.9f, 1.2f, 10f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.lumineon", (0.59f, 0.57f, 1f, 1.4f, 0.0f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.machamp", (0.05f, 1.3f, 1f, 1f, 0.0f), (0.32f, 1.23f, 0.8f, 0.8f, 0.0f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.magcargo", (0.28f, 1.74f, 1.6f, 2.6f, 15f), (0.96f, 1.83f, 1.6f, 2.6f, 15f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.magneton", (0.03f, 1.4f, 2f, 2f, 0.0f), (-0.88f, 0.54f, 1.4f, 1.9f, 0.0f), (0.78f, 0.52f, 1.5f, 1.9f, 0.0f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.marowak", (0.64f, 0.96f, 1f, 2f, 50f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.muk", (0.06f, 1.23f, 1.2f, 0.4f, 15f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.musharna", (0.28f, 0.67f, 1.3f, 1.3f, 0.0f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.ninjask", (0.11f, 0.95f, 1.2f, 1.2f, 0.0f), (0.85f, 1.04f, 1.1f, 1.1f, 0.0f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.nosepass", (-0.33f, 1.53f, 2.5f, 1.6f, 30f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.persian", (0.52f, 1.96f, 0.8f, 1f, 30f), (0.99f, 1.96f, 1.3f, 1f, 30f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.polteageist", (-0.04f, 2.19f, 0.6f, 1f, 0.0f), (0.22f, 2.22f, 0.6f, 1f, 0.0f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.rotom", (-0.16f, 1.37f, 0.8f, 1.7f, 30f), (0.21f, 1.48f, 0.8f, 1.7f, 0.0f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.rotomfan", (0.02f, 0.46f, 0.9f, 1.6f, 30f), (0.4f, 0.49f, 0.9f, 1.6f, 355f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.rotomfrost", (-0.11f, 1.1f, 1.1f, 2f, 40f), (0.4f, 1.2f, 1.1f, 2f, 355f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.rotomheat", (-0.22f, 1.15f, 1.2f, 2f, 25f), (0.36f, 1.12f, 1.2f, 2f, 335f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.rotommow", (0.15f, 0.71f, 1.3f, 2.1f, 20f), (0.73f, 0.63f, 1.1f, 2f, 345f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.rotomwash", (-0.53f, 1.54f, 1f, 1.8f, 35f), (0.0f, 1.62f, 1f, 1.9f, 345f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.sableye", (-0.18f, 1.18f, 2.7f, 2.7f, 0.0f), (0.58f, 1.33f, 1.8f, 2.5f, 0.0f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.salazzle", (0.39f, 2.35f, 1.5f, 0.8f, 340f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.sharpedo", (0.24f, 1.41f, 1.3f, 1.3f, 0.0f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.slowbro", (0.14f, 1.82f, 1.4f, 1.4f, 0.0f), (0.8f, 1.84f, 1.4f, 1.4f, 0.0f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.slowking", (-0.56f, 1.63f, 1.2f, 1.2f, 0.0f), (-0.2f, 1.59f, 1.2f, 1.2f, 0.0f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.smeargle", (0.1f, 1.3f, 1.1f, 1.1f, 0.0f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.sneasel", (0.14f, 1.39f, 0.8f, 1f, 0.0f), (0.52f, 1.41f, 0.7f, 1f, 0.0f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.snorlax", (-0.28f, 1.2f, 1.3f, 1f, 0.0f), (0.35f, 1.22f, 1.3f, 1f, 0.0f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.spheal", (0.37f, 1.22f, 1.2f, 1.2f, 0.0f), (0.81f, 1.34f, 1.2f, 1.2f, 0.0f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.spinda", (-0.33f, 1.18f, 1f, 1f, 0.0f), (0.45f, 1.36f, 1f, 1f, 0.0f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.sylveon", (0.33f, 1.25f, 1f, 1.3f, 0.0f), (0.75f, 1.34f, 1f, 1.3f, 0.0f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.toxicroak", (0.1f, 1.73f, 1.3f, 1.1f, 0.0f), (0.74f, 1.77f, 1.2f, 1f, 0.0f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.tyrantrum", (0.75f, 1.24f, 1.2f, 1.2f, 0.0f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.umbreon", (0.76f, 1.41f, 1.4f, 0.8f, 0.0f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.vaporeon", (-0.15f, 1.71f, 1.2f, 1.2f, 0.0f), (0.35f, 1.81f, 1.2f, 1.2f, 0.0f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.volcarona", (0.3f, 1.57f, 1.1f, 0.6f, 310f), (0.53f, 1.52f, 0.8f, 0.2f, 55f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.weezing", (-0.87f, 1.42f, 1f, 1f, 0.0f), (-0.51f, 1.5f, 1f, 1f, 0.0f), (0.27f, 1.25f, 1.5f, 1.5f, 0.0f), (0.91f, 1.07f, 1.4f, 1.4f, 0.0f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.whimsicott", (0.04f, 1.03f, 0.7f, 1.4f, 0.0f), (0.44f, 1f, 0.7f, 1.4f, 0.0f)),
        EyeDataAdder.Eyes("websiteofsites.wildfrost.pokefrost.xatu", (0.05f, 1.9f, 1.7f, 1.1f, 0.0f))
      });
    }

    public static EyeData Eyes(string cardName, params (float, float, float, float, float)[] data)
    {
      EyeData instance = ScriptableObject.CreateInstance<EyeData>();
      instance.cardData = cardName;
      instance.name = instance.cardData + "_EyeData";
      instance.eyes = ((IEnumerable<(float, float, float, float, float)>) data).Select<(float, float, float, float, float), EyeData.Eye>((Func<(float, float, float, float, float), EyeData.Eye>) (e => new EyeData.Eye()
      {
        position = new Vector2(e.Item1, e.Item2),
        scale = new Vector2(e.Item3, e.Item4),
        rotation = e.Item5
      })).ToArray<EyeData.Eye>();
      return instance;
    }
  }
}
