// Decompiled with JetBrains decompiler
// Type: AudioSettingsSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using FMOD;
using FMODUnity;
using NaughtyAttributes;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Events;

public class AudioSettingsSystem : GameSystem
{
  public static bool Loading;
  [SerializeField]
  private AudioSettingsSystem.Bus[] buses;
  [SerializeField]
  [Range(0.0f, 1f)]
  private float slowmoPitchMin = 0.67f;
  [SerializeField]
  [Range(0.0f, 1f)]
  private float slowmoPitchLerp = 0.25f;
  [SerializeField]
  private bool slowmoLerpUseDelta = true;
  [InfoBox("Master.strings and Master MUST be loaded first!", EInfoBoxType.Normal)]
  [SerializeField]
  private AssetReference[] banksToLoad;
  private Dictionary<string, AudioSettingsSystem.Bus> busLookup;
  private float slowmoPitch = 1f;
  private float slowmoPitchTarget = 1f;

  private void Awake() => this.StartCoroutine(this.LoadBanks());

  private void OnEnable()
  {
    global::Events.OnAudioVolumeChange += new UnityAction<string, float>(this.SetVolume);
    global::Events.OnAudioPitchChange += new UnityAction<string, float>(this.SetPitch);
    global::Events.OnTimeScaleChange += new UnityAction<float>(this.TimeScaleChange);
  }

  private void OnDisable()
  {
    global::Events.OnAudioVolumeChange -= new UnityAction<string, float>(this.SetVolume);
    global::Events.OnAudioPitchChange -= new UnityAction<string, float>(this.SetPitch);
    global::Events.OnTimeScaleChange -= new UnityAction<float>(this.TimeScaleChange);
  }

  private IEnumerator LoadBanks()
  {
    AudioSettingsSystem.Loading = true;
    UnityEngine.Debug.Log((object) "Audio Settings System → Loading Banks");
    foreach (AssetReference assetReference in this.banksToLoad)
    {
      RuntimeManager.LoadBank(assetReference, true);
      UnityEngine.Debug.Log((object) string.Format("FMOD BANK {0} LOADED", (object) assetReference));
    }
    while (!RuntimeManager.HaveAllBanksLoaded)
      yield return (object) null;
    while (RuntimeManager.AnySampleDataLoading())
      yield return (object) null;
    this.busLookup = new Dictionary<string, AudioSettingsSystem.Bus>();
    foreach (AudioSettingsSystem.Bus bus in this.buses)
    {
      bus.Init();
      this.busLookup.Add(bus.name, bus);
    }
    AudioSettingsSystem.Loading = false;
  }

  private void Update()
  {
    if ((double) this.slowmoPitch == (double) this.slowmoPitchTarget)
      return;
    this.slowmoPitch = !this.slowmoLerpUseDelta ? Mathf.Lerp(this.slowmoPitch, this.slowmoPitchTarget, this.slowmoPitchLerp) : Delta.Lerp(this.slowmoPitch, this.slowmoPitchTarget, this.slowmoPitchLerp, Time.deltaTime);
    if ((double) Mathf.Abs(this.slowmoPitch - this.slowmoPitchTarget) < 0.0099999997764825821)
      this.slowmoPitch = this.slowmoPitchTarget;
    this.SetPitch("Master", this.slowmoPitch);
  }

  private void TimeScaleChange(float value)
  {
    this.slowmoPitchTarget = this.slowmoPitchMin + (1f - this.slowmoPitchMin) * value;
    AudioSettingsSystem.Bus bus = this.busLookup["Master"];
    if (bus == null)
      return;
    this.slowmoPitch = bus.pitch;
  }

  private void SetVolume(string busName, float value)
  {
    AudioSettingsSystem.Bus bus = this.busLookup[busName];
    if (bus == null)
      return;
    bus.volume = value;
    bus.UpdateVolume();
    Settings.Save<float>(bus.volumeSettingsKey, value);
  }

  public static void Volume(string busName, float value)
  {
    AudioSettingsSystem objectOfType = UnityEngine.Object.FindObjectOfType<AudioSettingsSystem>();
    if (objectOfType == null || !objectOfType.enabled)
      return;
    objectOfType.SetVolume(busName, Mathf.Clamp(value, 0.0f, 1f));
  }

  public static float GetVolume(string busName)
  {
    AudioSettingsSystem objectOfType = UnityEngine.Object.FindObjectOfType<AudioSettingsSystem>();
    if (objectOfType != null)
    {
      if (objectOfType.enabled)
      {
        try
        {
          AudioSettingsSystem.Bus bus = objectOfType.busLookup[busName];
          if (bus != null)
            return bus.volume;
        }
        catch (KeyNotFoundException ex)
        {
          throw new KeyNotFoundException("[" + busName + "] does not exist", ex.InnerException);
        }
      }
    }
    return 0.0f;
  }

  private void SetPitch(string busName, float value)
  {
    try
    {
      AudioSettingsSystem.Bus bus = this.busLookup[busName];
      if (bus == null)
        return;
      bus.pitch = value;
      bus.UpdatePitch();
    }
    catch (KeyNotFoundException ex)
    {
      throw new KeyNotFoundException("[" + busName + "] does not exist", ex.InnerException);
    }
  }

  [Button(null, EButtonEnableMode.Always)]
  private void PromptUpdate()
  {
    foreach (AudioSettingsSystem.Bus bus in this.buses)
    {
      bus.UpdateVolume();
      bus.UpdatePitch();
    }
  }

  [Serializable]
  public class Bus
  {
    public string name;
    public string path;
    public string volumeSettingsKey;
    [Range(0.0f, 2f)]
    public float volume = 1f;
    [Range(0.0f, 2f)]
    public float pitch = 1f;
    private FMOD.Studio.Bus bus;
    private ChannelGroup channelGroup;

    public void Init()
    {
      this.bus = RuntimeManager.GetBus(this.path);
      int num = (int) this.bus.lockChannelGroup();
      this.volume = Settings.Load<float>(this.volumeSettingsKey, 1f);
      this.UpdateVolume();
      this.UpdatePitch();
    }

    public void UpdateVolume()
    {
      int num = (int) this.bus.setVolume(this.volume);
    }

    public void UpdatePitch()
    {
      int channelGroup = (int) this.bus.getChannelGroup(out this.channelGroup);
      int num = (int) this.channelGroup.setPitch(this.pitch);
    }
  }
}
