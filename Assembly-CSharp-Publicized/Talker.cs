// Decompiled with JetBrains decompiler
// Type: Talker
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using Dead;
using FMODUnity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Localization;

public class Talker : MonoBehaviour
{
  [SerializeField]
  public LocalizedString nameKey;
  [SerializeField]
  public Transform talkFrom;
  [SerializeField]
  public AvatarPoser poser;
  [SerializeField]
  public Talker.Speech[] speech;
  public readonly Dictionary<string, Talker.Speech> speechLookup = new Dictionary<string, Talker.Speech>();
  public readonly List<Talker.Store> stored = new List<Talker.Store>();

  public string GetName() => !this.nameKey.IsEmpty ? this.nameKey.GetLocalizedString() : "";

  public void Awake()
  {
    foreach (Talker.Speech speech in this.speech)
      this.speechLookup[speech.type] = speech;
  }

  public void OnEnable()
  {
    foreach (Talker.Store store in this.stored)
      this.Say(store.speechType, store.delay, store.inserts);
    this.stored.Clear();
  }

  public void OnDisable() => this.StopAllCoroutines();

  public void Say(string speechType, float delay = 0.0f, params object[] inserts)
  {
    if (!this.enabled || !this.gameObject.activeInHierarchy)
    {
      this.stored.Add(new Talker.Store(speechType, delay, inserts));
    }
    else
    {
      Talker.Speech speech;
      if (!this.Get(speechType, out speech))
        return;
      string str = speech.Pull();
      EventReference? sfxEvent = new EventReference?(speech.sfxEvent);
      if (inserts.Length != 0)
        str = string.Format(str, inserts);
      if (str.Contains('|'))
      {
        string[] strArray = str.Split('|', StringSplitOptions.None);
        float num = 0.0f;
        foreach (string text in strArray)
        {
          this.StartCoroutine(this.SayAfterDelay(text, sfxEvent, delay + num));
          if (speech.poseOptions.Length != 0 && (bool) (UnityEngine.Object) this.poser)
            this.StartCoroutine(this.PoseAfterDelay(speech.poseOptions.RandomItem<string>(), delay + num));
          num += Mathf.Max(1.25f, SpeechBubbleSystem.GetDuration(text) * 0.5f);
          sfxEvent = new EventReference?();
        }
      }
      else
      {
        this.StartCoroutine(this.SayAfterDelay(str, sfxEvent, delay));
        if (speech.poseOptions.Length == 0 || !(bool) (UnityEngine.Object) this.poser)
          return;
        this.StartCoroutine(this.PoseAfterDelay(speech.poseOptions.RandomItem<string>(), delay));
      }
    }
  }

  public bool Get(string type, out Talker.Speech speech)
  {
    bool flag = this.speechLookup.TryGetValue(type, out speech);
    if (!flag)
    {
      Talker.Speech[] array = ((IEnumerable<Talker.Speech>) this.speech).Where<Talker.Speech>((Func<Talker.Speech, bool>) (a => a.type == type)).ToArray<Talker.Speech>();
      if (array.Length != 0)
      {
        flag = true;
        speech = array[0];
      }
    }
    return flag;
  }

  public IEnumerator SayAfterDelay(string text, EventReference? sfxEvent, float delay = 0.0f)
  {
    if ((double) delay > 0.0)
      yield return (object) new WaitForSeconds(delay);
    if (sfxEvent.HasValue && !sfxEvent.GetValueOrDefault().IsNull)
      SfxSystem.OneShot(sfxEvent.Value);
    SpeechBubbleSystem.Create(new SpeechBubbleData(this.talkFrom, this.GetName(), text));
  }

  public IEnumerator PoseAfterDelay(string pose, float delay = 0.0f)
  {
    if ((double) delay > 0.0)
      yield return (object) new WaitForSeconds(delay);
    this.poser.Set(pose);
  }

  public struct Store
  {
    public string speechType;
    public float delay;
    public object[] inserts;

    public Store(string speechType, float delay, object[] inserts)
    {
      this.speechType = speechType;
      this.delay = delay;
      this.inserts = inserts;
    }
  }

  [Serializable]
  public struct Speech
  {
    public string type;
    public string[] poseOptions;
    public LocalizedString[] options;
    public EventReference sfxEvent;
    public List<LocalizedString> optionPool;

    public string Pull()
    {
      if (this.optionPool == null)
        this.optionPool = new List<LocalizedString>();
      if (this.optionPool.Count <= 0)
        this.optionPool.AddRange((IEnumerable<LocalizedString>) this.options);
      int index = PettyRandom.Range(0, this.optionPool.Count - 1);
      LocalizedString localizedString = this.optionPool[index];
      this.optionPool.RemoveAt(index);
      return localizedString.GetLocalizedString();
    }
  }
}
