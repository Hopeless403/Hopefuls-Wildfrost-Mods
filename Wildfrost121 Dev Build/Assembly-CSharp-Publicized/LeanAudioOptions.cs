// Decompiled with JetBrains decompiler
// Type: LeanAudioOptions
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

#nullable disable
public class LeanAudioOptions
{
  public LeanAudioOptions.LeanAudioWaveStyle waveStyle;
  public Vector3[] vibrato;
  public Vector3[] modulation;
  public int frequencyRate = 44100;
  public float waveNoiseScale = 1000f;
  public float waveNoiseInfluence = 1f;
  public bool useSetData = true;
  public LeanAudioStream stream;

  public LeanAudioOptions setFrequency(int frequencyRate)
  {
    this.frequencyRate = frequencyRate;
    return this;
  }

  public LeanAudioOptions setVibrato(Vector3[] vibrato)
  {
    this.vibrato = vibrato;
    return this;
  }

  public LeanAudioOptions setWaveSine()
  {
    this.waveStyle = LeanAudioOptions.LeanAudioWaveStyle.Sine;
    return this;
  }

  public LeanAudioOptions setWaveSquare()
  {
    this.waveStyle = LeanAudioOptions.LeanAudioWaveStyle.Square;
    return this;
  }

  public LeanAudioOptions setWaveSawtooth()
  {
    this.waveStyle = LeanAudioOptions.LeanAudioWaveStyle.Sawtooth;
    return this;
  }

  public LeanAudioOptions setWaveNoise()
  {
    this.waveStyle = LeanAudioOptions.LeanAudioWaveStyle.Noise;
    return this;
  }

  public LeanAudioOptions setWaveStyle(LeanAudioOptions.LeanAudioWaveStyle style)
  {
    this.waveStyle = style;
    return this;
  }

  public LeanAudioOptions setWaveNoiseScale(float waveScale)
  {
    this.waveNoiseScale = waveScale;
    return this;
  }

  public LeanAudioOptions setWaveNoiseInfluence(float influence)
  {
    this.waveNoiseInfluence = influence;
    return this;
  }

  public enum LeanAudioWaveStyle
  {
    Sine,
    Square,
    Sawtooth,
    Noise,
  }
}
