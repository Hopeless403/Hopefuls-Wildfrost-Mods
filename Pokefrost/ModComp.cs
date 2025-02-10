// Decompiled with JetBrains decompiler
// Type: Pokefrost.ModComp
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System.Collections;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Pokefrost
{
  public static class ModComp
  {
    private static float tScale = 1f;
    private static float rScale = -30f;
    private static float dur = 1f;

    public static IEnumerator InspectCosmetic(RectTransform parent)
    {
      GameObject holder = new GameObject("Holder", new System.Type[1]
      {
        typeof (RectTransform)
      });
      holder.transform.SetParent(parent.transform, false);
      GameObject icon = new GameObject("Icon", new System.Type[1]
      {
        typeof (Image)
      });
      icon.transform.SetParent(holder.transform, false);
      icon.GetComponent<RectTransform>().sizeDelta = 5f * Vector2.one;
      icon.GetComponent<Image>().sprite = Pokefrost.Pokefrost.instance.IconSprite;
      AnimationCurve sineCurve = new AnimationCurve(new Keyframe[9]
      {
        new Keyframe(0.0f, 0.0f),
        new Keyframe(0.125f, 0.707f),
        new Keyframe(0.25f, 1f),
        new Keyframe(0.375f, 0.707f),
        new Keyframe(0.5f, 0.0f),
        new Keyframe(0.625f, -0.707f),
        new Keyframe(0.75f, -1f),
        new Keyframe(0.875f, -0.707f),
        new Keyframe(1f, 0.0f)
      });
      while (true)
      {
        yield return (object) Sequences.Wait(2f);
        LeanTween.moveLocalX(icon, ModComp.tScale, ModComp.dur).setEase(sineCurve);
        LeanTween.rotateZ(icon, ModComp.rScale, ModComp.dur).setEase(sineCurve);
        yield return (object) Sequences.Wait(ModComp.dur);
      }
    }
  }
}
