// Decompiled with JetBrains decompiler
// Type: SpeechBub
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using NaughtyAttributes;
using System.Collections;
using TMPro;
using UnityEngine;

#nullable disable
public class SpeechBub : MonoBehaviourRect
{
  [SerializeField]
  private TMP_Text textAsset;
  [SerializeField]
  private Transform tail;
  [SerializeField]
  private float minHeight = 1f;
  [SerializeField]
  private float tailOffsetX = -0.225f;
  [SerializeField]
  private float tailOffsetY = -0.125f;
  [SerializeField]
  private float tailAngleOffset = 45f;
  [SerializeField]
  private bool constantAngle = true;
  [SerializeField]
  private string highlightHex = "328AD7";
  [Header("Animations")]
  [SerializeField]
  private TweenUI destroyTween;
  [SerializeField]
  private AnimationCurve moveCurve;
  [SerializeField]
  private Vector2 moveDurRange = new Vector2(0.75f, 1f);
  private float tailAnchorX = 1f;
  private float tailAnchorY = -1f;
  private Transform target;
  private float duration;
  private float durationMax;
  private bool _hasTail = true;
  private bool destroying;

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

  public bool sizeUpdated { get; private set; }

  private void OnEnable() => SfxSystem.OneShot("event:/sfx/ui/speech_bubble");

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
  private void UpdateSize()
  {
    this.rectTransform.sizeDelta = this.rectTransform.sizeDelta.WithY(Mathf.Max(this.minHeight, this.textAsset.textBounds.size.y + (this.textAsset.margin.y + this.textAsset.margin.w)));
    if (!this.hasTail)
      return;
    Vector2 sizeDelta = this.rectTransform.sizeDelta;
    this.tail.localPosition = (Vector3) new Vector2((float) ((double) this.tailAnchorX * 0.5 * (double) sizeDelta.x + (double) this.tailOffsetX * (double) this.tailAnchorX), (float) ((double) this.tailAnchorY * 0.5 * (double) sizeDelta.y + (double) this.tailOffsetY * (double) this.tailAnchorY));
  }

  private IEnumerator UpdateSizeNextFrame()
  {
    yield return (object) null;
    this.UpdateSize();
    this.sizeUpdated = true;
  }

  private void LateUpdate()
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

  private static float Angle(Vector2 from, Vector2 to)
  {
    Vector2 to1 = to - from;
    int num = (double) to1.y >= 0.0 ? 1 : -1;
    return Vector2.Angle(Vector2.right, to1) * (float) num;
  }

  private IEnumerator Destroy()
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

  private string ProcessText(string input)
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
