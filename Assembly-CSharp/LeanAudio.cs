// Decompiled with JetBrains decompiler
// Type: LeanAudio
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

public class LeanAudio
{
  public static float MIN_FREQEUNCY_PERIOD = 0.000115f;
  public static int PROCESSING_ITERATIONS_MAX = 50000;
  public static float[] generatedWaveDistances;
  public static int generatedWaveDistancesCount = 0;
  private static float[] longList;

  public static LeanAudioOptions options()
  {
    if (LeanAudio.generatedWaveDistances == null)
    {
      LeanAudio.generatedWaveDistances = new float[LeanAudio.PROCESSING_ITERATIONS_MAX];
      LeanAudio.longList = new float[LeanAudio.PROCESSING_ITERATIONS_MAX];
    }
    return new LeanAudioOptions();
  }

  public static LeanAudioStream createAudioStream(
    AnimationCurve volume,
    AnimationCurve frequency,
    LeanAudioOptions options = null)
  {
    if (options == null)
      options = new LeanAudioOptions();
    options.useSetData = false;
    LeanAudio.createAudioFromWave(LeanAudio.createAudioWave(volume, frequency, options), options);
    return options.stream;
  }

  public static AudioClip createAudio(
    AnimationCurve volume,
    AnimationCurve frequency,
    LeanAudioOptions options = null)
  {
    if (options == null)
      options = new LeanAudioOptions();
    return LeanAudio.createAudioFromWave(LeanAudio.createAudioWave(volume, frequency, options), options);
  }

  private static int createAudioWave(
    AnimationCurve volume,
    AnimationCurve frequency,
    LeanAudioOptions options)
  {
    float time1 = volume[volume.length - 1].time;
    int index1 = 0;
    float time2 = 0.0f;
    for (int index2 = 0; index2 < LeanAudio.PROCESSING_ITERATIONS_MAX; ++index2)
    {
      float minFreqeuncyPeriod = frequency.Evaluate(time2);
      if ((double) minFreqeuncyPeriod < (double) LeanAudio.MIN_FREQEUNCY_PERIOD)
        minFreqeuncyPeriod = LeanAudio.MIN_FREQEUNCY_PERIOD;
      float num1 = volume.Evaluate(time2 + 0.5f * minFreqeuncyPeriod);
      if (options.vibrato != null)
      {
        for (int index3 = 0; index3 < options.vibrato.Length; ++index3)
        {
          float num2 = Mathf.Abs(Mathf.Sin((float) (1.5707999467849731 + (double) time2 * (1.0 / (double) options.vibrato[index3][0]) * 3.1415927410125732)));
          float num3 = 1f - options.vibrato[index3][1];
          float num4 = options.vibrato[index3][1] + num3 * num2;
          num1 *= num4;
        }
      }
      if ((double) time2 + 0.5 * (double) minFreqeuncyPeriod < (double) time1)
      {
        if (index1 >= LeanAudio.PROCESSING_ITERATIONS_MAX - 1)
        {
          Debug.LogError((object) ("LeanAudio has reached it's processing cap. To avoid this error increase the number of iterations ex: LeanAudio.PROCESSING_ITERATIONS_MAX = " + (LeanAudio.PROCESSING_ITERATIONS_MAX * 2).ToString()));
          break;
        }
        int index4 = index1 / 2;
        time2 += minFreqeuncyPeriod;
        LeanAudio.generatedWaveDistances[index4] = time2;
        LeanAudio.longList[index1] = time2;
        LeanAudio.longList[index1 + 1] = index2 % 2 == 0 ? -num1 : num1;
        index1 += 2;
      }
      else
        break;
    }
    int audioWave = index1 - 2;
    LeanAudio.generatedWaveDistancesCount = audioWave / 2;
    return audioWave;
  }

  private static AudioClip createAudioFromWave(int waveLength, LeanAudioOptions options)
  {
    float num1 = LeanAudio.longList[waveLength - 2];
    float[] numArray = new float[(int) ((double) options.frequencyRate * (double) num1)];
    int index1 = 0;
    float num2 = LeanAudio.longList[index1];
    float num3 = 0.0f;
    double num4 = (double) LeanAudio.longList[index1];
    float num5 = LeanAudio.longList[index1 + 1];
    for (int index2 = 0; index2 < numArray.Length; ++index2)
    {
      float num6 = (float) index2 / (float) options.frequencyRate;
      if ((double) num6 > (double) LeanAudio.longList[index1])
      {
        num3 = LeanAudio.longList[index1];
        index1 += 2;
        num2 = LeanAudio.longList[index1] - LeanAudio.longList[index1 - 2];
        num5 = LeanAudio.longList[index1 + 1];
      }
      float num7 = (num6 - num3) / num2;
      float num8 = Mathf.Sin(num7 * 3.14159274f);
      if (options.waveStyle == LeanAudioOptions.LeanAudioWaveStyle.Square)
      {
        if ((double) num8 > 0.0)
          num8 = 1f;
        if ((double) num8 < 0.0)
          num8 = -1f;
      }
      else if (options.waveStyle == LeanAudioOptions.LeanAudioWaveStyle.Sawtooth)
      {
        float num9 = (double) num8 > 0.0 ? 1f : -1f;
        num8 = (double) num7 >= 0.5 ? (float) ((1.0 - (double) num7) * 2.0) * num9 : num7 * 2f * num9;
      }
      else if (options.waveStyle == LeanAudioOptions.LeanAudioWaveStyle.Noise)
      {
        float num10 = (float) (1.0 - (double) options.waveNoiseInfluence + (double) Mathf.PerlinNoise(0.0f, num6 * options.waveNoiseScale) * (double) options.waveNoiseInfluence);
        num8 *= num10;
      }
      float num11 = num8 * num5;
      if (options.modulation != null)
      {
        for (int index3 = 0; index3 < options.modulation.Length; ++index3)
        {
          float num12 = Mathf.Abs(Mathf.Sin((float) (1.5707999467849731 + (double) num6 * (1.0 / (double) options.modulation[index3][0]) * 3.1415927410125732)));
          float num13 = 1f - options.modulation[index3][1];
          float num14 = options.modulation[index3][1] + num13 * num12;
          num11 *= num14;
        }
      }
      numArray[index2] = num11;
    }
    int length = numArray.Length;
    AudioClip audioFromWave;
    if (options.useSetData)
    {
      audioFromWave = AudioClip.Create("Generated Audio", length, 1, options.frequencyRate, false, (AudioClip.PCMReaderCallback) null, new AudioClip.PCMSetPositionCallback(LeanAudio.OnAudioSetPosition));
      audioFromWave.SetData(numArray, 0);
    }
    else
    {
      options.stream = new LeanAudioStream(numArray);
      audioFromWave = AudioClip.Create("Generated Audio", length, 1, options.frequencyRate, false, new AudioClip.PCMReaderCallback(options.stream.OnAudioRead), new AudioClip.PCMSetPositionCallback(options.stream.OnAudioSetPosition));
      options.stream.audioClip = audioFromWave;
    }
    return audioFromWave;
  }

  private static void OnAudioSetPosition(int newPosition)
  {
  }

  public static AudioClip generateAudioFromCurve(AnimationCurve curve, int frequencyRate = 44100)
  {
    float time1 = curve[curve.length - 1].time;
    float[] data = new float[(int) ((double) frequencyRate * (double) time1)];
    for (int index = 0; index < data.Length; ++index)
    {
      float time2 = (float) index / (float) frequencyRate;
      data[index] = curve.Evaluate(time2);
    }
    AudioClip audioFromCurve = AudioClip.Create("Generated Audio", data.Length, 1, frequencyRate, false);
    audioFromCurve.SetData(data, 0);
    return audioFromCurve;
  }

  public static AudioSource play(AudioClip audio, float volume)
  {
    AudioSource audioSource = LeanAudio.playClipAt(audio, Vector3.zero);
    audioSource.volume = volume;
    return audioSource;
  }

  public static AudioSource play(AudioClip audio) => LeanAudio.playClipAt(audio, Vector3.zero);

  public static AudioSource play(AudioClip audio, Vector3 pos) => LeanAudio.playClipAt(audio, pos);

  public static AudioSource play(AudioClip audio, Vector3 pos, float volume)
  {
    AudioSource audioSource = LeanAudio.playClipAt(audio, pos);
    audioSource.minDistance = 1f;
    audioSource.volume = volume;
    return audioSource;
  }

  public static AudioSource playClipAt(AudioClip clip, Vector3 pos)
  {
    GameObject gameObject = new GameObject();
    gameObject.transform.position = pos;
    AudioSource audioSource = gameObject.AddComponent<AudioSource>();
    audioSource.clip = clip;
    audioSource.Play();
    Object.Destroy((Object) gameObject, clip.length);
    return audioSource;
  }

  public static void printOutAudioClip(AudioClip audioClip, ref AnimationCurve curve, float scaleX = 1f)
  {
    float[] data = new float[audioClip.samples * audioClip.channels];
    audioClip.GetData(data, 0);
    int index = 0;
    Keyframe[] keyframeArray = new Keyframe[data.Length];
    for (; index < data.Length; ++index)
      keyframeArray[index] = new Keyframe((float) index * scaleX, data[index]);
    curve = new AnimationCurve(keyframeArray);
  }
}
