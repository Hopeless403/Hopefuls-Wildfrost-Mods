// Decompiled with JetBrains decompiler
// Type: LeanAudioStream
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

public class LeanAudioStream
{
  public int position;
  public AudioClip audioClip;
  public float[] audioArr;

  public LeanAudioStream(float[] audioArr) => this.audioArr = audioArr;

  public void OnAudioRead(float[] data)
  {
    for (int index = 0; index < data.Length; ++index)
    {
      data[index] = this.audioArr[this.position];
      ++this.position;
    }
  }

  public void OnAudioSetPosition(int newPosition) => this.position = newPosition;
}
