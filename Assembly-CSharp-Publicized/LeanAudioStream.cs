// Decompiled with JetBrains decompiler
// Type: LeanAudioStream
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

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
