// Decompiled with JetBrains decompiler
// Type: DailyTimer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
public class DailyTimer : MonoBehaviour
{
  [SerializeField]
  public TMP_Text textElement;
  [SerializeField]
  public UnityEvent action;
  public int secondsRemaining;
  public float secondTimer;

  public void OnEnable()
  {
    DateTime dateTime = DailyFetcher.GetDateTime();
    float totalSeconds = (float) (DailyFetcher.GetNextDateTime() - dateTime).TotalSeconds;
    this.secondsRemaining = Mathf.FloorToInt(totalSeconds);
    this.secondTimer = totalSeconds - (float) this.secondsRemaining;
    this.UpdateText();
  }

  public void Update()
  {
    this.secondTimer -= Time.deltaTime;
    if ((double) this.secondTimer >= 0.0)
      return;
    for (; (double) this.secondTimer < 0.0; ++this.secondTimer)
      --this.secondsRemaining;
    if (this.secondsRemaining <= 0)
      this.action?.Invoke();
    this.UpdateText();
  }

  public void UpdateText()
  {
    TimeSpan timeSpan = TimeSpan.FromSeconds((double) Mathf.Max(0, this.secondsRemaining));
    this.textElement.text = string.Format("{0:D2}:{1:D2}:{2:D2}", (object) timeSpan.Hours, (object) timeSpan.Minutes, (object) timeSpan.Seconds);
  }
}
