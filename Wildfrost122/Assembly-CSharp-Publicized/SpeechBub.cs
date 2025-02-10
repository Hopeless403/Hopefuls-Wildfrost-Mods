// Decompiled with JetBrains decompiler
// Type: SpeechBub
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using NaughtyAttributes;
using System.Collections;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

#nullable disable
public class SpeechBub : MonoBehaviourRect
{
  [SerializeField]
  public TMP_Text textAsset;
  [SerializeField]
  public Transform tail;
  [SerializeField]
  public float minHeight = 1f;
  [SerializeField]
  public float tailOffsetX = -0.225f;
  [SerializeField]
  public float tailOffsetY = -0.125f;
  [SerializeField]
  public float tailAngleOffset = 45f;
  [SerializeField]
  public bool constantAngle = true;
  [SerializeField]
  public string highlightHex = "328AD7";
  [Header("Animations")]
  [SerializeField]
  public TweenUI destroyTween;
  [SerializeField]
  public AnimationCurve moveCurve;
  [SerializeField]
  public Vector2 moveDurRange = new Vector2(0.75f, 1f);
  public float tailAnchorX = 1f;
  public float tailAnchorY = -1f;
  public Transform target;
  public float duration;
  public float durationMax;
  public bool _hasTail = true;
  public bool destroying;
  [CompilerGenerated]
  public bool \u003CsizeUpdated\u003Ek__BackingField;

  public float durationFactor => this.duration / this.durationMax;

  public bool hasTail
  {
    get => this._hasTail;
    set
    {
      this._hasTail = value;
      this.tail.gameObject.SetActive(value);
    }
  }

  public bool sizeUpdated
  {
    get => this.\u003CsizeUpdated\u003Ek__BackingField;
    set => this.\u003CsizeUpdated\u003Ek__BackingField = value;
  }

  public void OnEnable() => SfxSystem.OneShot("event:/sfx/ui/speech_bubble");

  public void Set(SpeechBubbleData data)
  {
    this.textAsset.text = this.ProcessText(data.text);
    this.target = data.target;
    this.hasTail = (Object) this.target != (Object) null;
    this.duration = data.duration;
    this.durationMax = data.duration;
    this.StartCoroutine(this.UpdateSizeNextFrame());
  }

  public void SetPosition(Vector3 localPos)
  {
    this.sizeUpdated = false;
    LeanTween.cancel(this.gameObject);
    LeanTween.moveLocal(this.gameObject, localPos, this.moveDurRange.PettyRandom()).setEase(this.moveCurve);
  }

  [Button(null, EButtonEnableMode.Always)]
  public void UpdateSize()
  {
    this.rectTransform.sizeDelta = this.rectTransform.sizeDelta.WithY(Mathf.Max(this.minHeight, this.textAsset.textBounds.size.y + (this.textAsset.margin.y + this.textAsset.margin.w)));
    if (!this.hasTail)
      return;
    Vector2 sizeDelta = this.rectTransform.sizeDelta;
    this.tail.localPosition = (Vector3) new Vector2((float) ((double) this.tailAnchorX * 0.5 * (double) sizeDelta.x + (double) this.tailOffsetX * (double) this.tailAnchorX), (float) ((double) this.tailAnchorY * 0.5 * (double) sizeDelta.y + (double) this.tailOffsetY * (double) this.tailAnchorY));
  }

  public IEnumerator UpdateSizeNextFrame()
  {
    yield return (object) null;
    this.UpdateSize();
    this.sizeUpdated = true;
  }

  public void LateUpdate()
  {
    if (this.destroying)
      return;
    Transform transform = this.transform;
    if (this.constantAngle && (double) transform.eulerAngles.z != 0.0)
      transform.eulerAngles = transform.eulerAngles.WithZ(0.0f);
    this.duration -= Time.deltaTime;
    if ((double) this.duration <= 0.0)
    {
      this.destroying = true;
      this.StartCoroutine(this.Destroy());
    }
    if (!this.hasTail || !((Object) this.target != (Object) null))
      return;
    this.tail.eulerAngles = this.tail.eulerAngles.WithZ(SpeechBub.Angle((Vector2) this.tail.position, (Vector2) this.target.position) + this.tailAngleOffset);
  }

  public static float Angle(Vector2 from, Vector2 to)
  {
    Vector2 to1 = to - from;
    int num = (double) to1.y >= 0.0 ? 1 : -1;
    return Vector2.Angle(Vector2.right, to1) * (float) num;
  }

  public IEnumerator Destroy()
  {
    // ISSUE: reference to a compiler-generated field
    int num = this.\u003C\u003E1__state;
    SpeechBub speechBub = this;
    if (num != 0)
    {
      if (num != 1)
        return false;
      // ISSUE: reference to a compiler-generated field
      this.\u003C\u003E1__state = -1;
      speechBub.gameObject.Destroy();
      return false;
    }
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E1__state = -1;
    speechBub.destroyTween.Fire();
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E2__current = (object) new WaitForSeconds(speechBub.destroyTween.GetDuration());
    // ISSUE: reference to a compiler-generated field
    this.\u003C\u003E1__state = 1;
    return true;
  }

  public string ProcessText(string input)
  {
    string text = input.Trim();
    int length = text.Length;
    for (int index = 0; index < length; ++index)
    {
      if (text[index] == '<')
      {
        string str1 = Text.FindTag(text, index);
        if (str1.Length > 0)
        {
          string str2 = this.highlightHex;
          string str3 = text.Remove(index, str1.Length + 2);
          int num1 = str1.IndexOf(' ');
          if (num1 > 0)
          {
            string str4 = str1.Substring(0, num1);
            if (str4[0] == '#')
            {
              str2 = str4.Substring(1);
              str1 = str1.Substring(num1);
            }
          }
          string str5 = "<#" + str2 + ">" + str1 + "</color>";
          text = str3.Insert(index, str5);
          int num2 = index + str5.Length;
          length = text.Length;
          index = num2 - 1;
        }
      }
    }
    return text;
  }
}
