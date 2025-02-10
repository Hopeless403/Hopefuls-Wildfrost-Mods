// Decompiled with JetBrains decompiler
// Type: SpeechBubbleSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
public class SpeechBubbleSystem : GameSystem
{
  private static SpeechBubbleSystem instance;
  public SpeechBub bubblePrefab;
  public AnimationCurve wordToDurationCurve;
  public float durationFactor = 1f;
  private List<SpeechBubbleSpawn> spawnPoints;
  private List<SpeechBubbleData> queue;
  private SpeechBub current;

  public static event SpeechBubbleSystem.NotifyCreate OnCreate;

  public static void Create(SpeechBubbleData data)
  {
    SpeechBubbleSystem.NotifyCreate onCreate = SpeechBubbleSystem.OnCreate;
    if (onCreate == null)
      return;
    onCreate(data);
  }

  private void OnEnable()
  {
    SpeechBubbleSystem.instance = this;
    this.spawnPoints = new List<SpeechBubbleSpawn>();
    this.queue = new List<SpeechBubbleData>();
    SpeechBubbleSystem.OnCreate += new SpeechBubbleSystem.NotifyCreate(this.QueueBubble);
  }

  private void OnDisable()
  {
    SpeechBubbleSystem.OnCreate -= new SpeechBubbleSystem.NotifyCreate(this.QueueBubble);
    this.StopAllCoroutines();
  }

  private void Update()
  {
    if (this.queue.Count <= 0 || (bool) (UnityEngine.Object) this.current && (double) this.current.durationFactor >= 0.5)
      return;
    this.CreateBubble(this.queue[0]);
    this.queue.RemoveAt(0);
  }

  private void QueueBubble(SpeechBubbleData data) => this.queue.Add(data);

  private void CreateBubble(SpeechBubbleData data)
  {
    if ((double) data.delay > 0.0)
      this.StartCoroutine(this.CreateBubbleAfter(data, data.delay));
    else if (this.spawnPoints.Count > 0)
    {
      SpeechBubbleSpawn speechBubbleSpawn = (SpeechBubbleSpawn) null;
      data.SetDuration(SpeechBubbleSystem.GetDuration(data.text));
      if (!(bool) (UnityEngine.Object) data.target)
      {
        speechBubbleSpawn = this.spawnPoints.RandomItem<SpeechBubbleSpawn>();
      }
      else
      {
        Vector3 position = data.target.position;
        float num1 = float.MaxValue;
        foreach (SpeechBubbleSpawn spawnPoint in this.spawnPoints)
        {
          float num2 = spawnPoint.transform.position.DistanceTo(position);
          if ((double) num2 < (double) num1)
          {
            num1 = num2;
            speechBubbleSpawn = spawnPoint;
          }
        }
      }
      if (!(bool) (UnityEngine.Object) speechBubbleSpawn)
        return;
      this.current = speechBubbleSpawn.Create(this.bubblePrefab, data);
    }
    else
      Debug.LogWarning((object) "Speech Bubble could not be created: No anchor points in scene!");
  }

  private IEnumerator CreateBubbleAfter(SpeechBubbleData data, float delay)
  {
    yield return (object) new WaitForSeconds(delay);
    data.delay = 0.0f;
    this.CreateBubble(data);
  }

  public static float GetDuration(string text)
  {
    string[] strArray = text.Split(new char[1]{ ' ' }, StringSplitOptions.RemoveEmptyEntries);
    return SpeechBubbleSystem.instance.wordToDurationCurve.Evaluate((float) strArray.Length) * SpeechBubbleSystem.instance.durationFactor;
  }

  public void AddSpawnPoint(SpeechBubbleSpawn spawnPoint) => this.spawnPoints.Add(spawnPoint);

  public void RemoveSpawnPoint(SpeechBubbleSpawn spawnPoint) => this.spawnPoints.Remove(spawnPoint);

  public delegate void NotifyCreate(SpeechBubbleData data);
}
