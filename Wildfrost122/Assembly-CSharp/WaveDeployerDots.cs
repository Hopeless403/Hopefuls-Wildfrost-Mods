// Decompiled with JetBrains decompiler
// Type: WaveDeployerDots
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
public class WaveDeployerDots : MonoBehaviour
{
  [SerializeField]
  private float fanRadius = 0.5f;
  [SerializeField]
  private float startAngle = -90f;
  [SerializeField]
  private float arcMax = 90f;
  [SerializeField]
  private float arcGap = 20f;
  public List<WaveDot> dots;
  [SerializeField]
  private Transform dotContainer;
  [SerializeField]
  private WaveDot dotPrefab;
  [SerializeField]
  private WaveDot bigDotPrefab;

  public void Init(BattleWaveManager waveManager, int currentWaveIndex)
  {
    foreach (Component dot in this.dots)
      dot.gameObject.Destroy();
    this.dots = new List<WaveDot>();
    foreach (BattleWaveManager.Wave wave in waveManager.list)
    {
      WaveDot waveDot = UnityEngine.Object.Instantiate<WaveDot>(wave.isBossWave ? this.bigDotPrefab : this.dotPrefab, this.dotContainer);
      waveDot.gameObject.SetActive(true);
      this.dots.Add(waveDot);
    }
    this.SetPositions();
    this.UpdateDots(waveManager, currentWaveIndex);
  }

  public void UpdateDots(BattleWaveManager waveManager, int currentWaveIndex)
  {
    for (int index = 0; index < this.dots.Count; ++index)
    {
      if (waveManager.list[index].spawned && currentWaveIndex != index)
        this.dots[index].TurnOff();
    }
  }

  private void SetPositions()
  {
    for (int index = 0; index < this.dots.Count; ++index)
      this.dots[index].transform.localPosition = this.GetPosition(index);
  }

  private Vector3 GetPosition(int index)
  {
    return (Vector3) Lengthdir.ToVector2(this.fanRadius, (float) (((double) this.GetAngle(index) + (double) this.startAngle) * (Math.PI / 180.0)));
  }

  private float GetAngle(int index)
  {
    float angleAdd = this.GetAngleAdd();
    return (float) (-(double) angleAdd * (double) (this.dots.Count - 1) * 0.5 + (double) angleAdd * (double) index);
  }

  private float GetAngleAdd()
  {
    int num = this.dots.Count - 1;
    return Mathf.Min((float) num * this.arcGap, this.arcMax) / (float) num;
  }
}
