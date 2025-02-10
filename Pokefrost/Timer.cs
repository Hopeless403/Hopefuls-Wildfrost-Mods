// Decompiled with JetBrains decompiler
// Type: Pokefrost.Timer
// Assembly: Pokefrost, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 34C2824D-C6CF-4C71-8687-C2C32B04080B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\workshop\content\1811990\3155028085\Pokefrost.dll

using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
namespace Pokefrost
{
  internal class Timer : MonoBehaviour
  {
    private float time;
    private float scale = -1f;
    public const string RED = "#ff4444";
    public const string YEL = "#ffca57";
    public const string WHT = "#ffffff";
    public const string GRN = "#3AF6CB";
    public const string BLU = "#7EDAFF";
    private string format = "<color={3}><mspace=0.4>{0}</mspace>:<mspace=0.4>{1}</mspace>.<mspace=0.3><size=0.6>{2}</size></mspace></color>";
    private string failFormat = "<color=#ff4444><mspace=0.4>XX</mspace>:<mspace=0.4>XX</mspace>.<mspace=0.3><size=0.6>XX</size></mspace></color>";
    public bool running = false;

    public float Time => this.time;

    private FloatingText Text => this.GetComponent<FloatingText>();

    public event UnityAction OnFinished;

    internal static Timer Create(float time)
    {
      Timer timer = UnityEngine.Object.FindObjectOfType<FloatingTextManager>().CreatePrefab().gameObject.AddComponent<Timer>();
      timer.SetTime(time);
      timer.Show();
      return timer;
    }

    public void Start()
    {
      this.Text.textAsset.outlineWidth = 0.05f;
      this.Text.textAsset.outlineColor = (Color32) Color.black;
    }

    public void SetTime(float time) => this.time = time;

    public void SetScale(float scale) => this.scale = scale;

    public void Show()
    {
      this.transform.position = new Vector3(0.0f, 5f, 0.0f);
      this.UpdateDisplay("#ffca57");
      this.gameObject.SetActive(true);
    }

    public void UpdateDisplay(string color = null)
    {
      if (color == null)
        color = this.running ? "#ffffff" : "#ffca57";
      if ((double) this.time <= 0.0)
      {
        this.Text.SetText(this.failFormat);
        this.time = 0.0f;
        this.running = false;
        UnityAction onFinished = this.OnFinished;
        if (onFinished == null)
          return;
        onFinished();
      }
      else
      {
        int time = (int) this.time;
        this.Text.SetText(string.Format(this.format, (object) (time / 60).ToString("00"), (object) (time % 60).ToString("00"), (object) Math.Floor((double) this.time % 1.0 * 100.0).ToString("00"), (object) color));
      }
    }

    public void Hide() => this.gameObject.SetActive(false);

    public void Play()
    {
      if (this.running || (double) this.time <= 0.0)
        return;
      this.running = true;
      this.StartCoroutine(this.Run());
    }

    public void Stop() => this.running = false;

    public void End() => this.gameObject.Destroy();

    public IEnumerator Run()
    {
      while (this.running)
      {
        this.time += this.scale * UnityEngine.Time.deltaTime;
        this.UpdateDisplay("#ffffff");
        yield return (object) null;
      }
      this.UpdateDisplay("#ffca57");
    }
  }
}
