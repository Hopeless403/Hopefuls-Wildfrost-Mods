// Decompiled with JetBrains decompiler
// Type: Collection`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using UnityEngine;

#nullable disable
public class Collection<T> : ScriptableObject where T : class
{
  public float nullWeight;
  [SerializeField]
  protected Collection<T>.Entry<T>[] weightedList;

  public T this[int index] => this.weightedList[index].value;

  public void AddWeight(int index, float weight) => this.weightedList[index].weight += weight;

  public T RandomItem()
  {
    int index = this.RandomIndex();
    return index >= 0 ? this.weightedList[index].value : default (T);
  }

  public virtual int RandomIndex()
  {
    int num1 = -1;
    if (this.weightedList.Length != 0)
    {
      float nullWeight = this.nullWeight;
      foreach (Collection<T>.Entry<T> weighted in this.weightedList)
      {
        if ((double) weighted.weight > 0.0)
          nullWeight += weighted.weight;
      }
      if ((double) nullWeight > 0.0)
      {
        float num2 = UnityEngine.Random.value * nullWeight;
        if ((double) num2 >= (double) this.nullWeight)
        {
          float num3 = num2 - this.nullWeight;
          for (int index = 0; index < this.weightedList.Length; ++index)
          {
            Collection<T>.Entry<T> weighted = this.weightedList[index];
            if ((double) weighted.weight > 0.0)
            {
              if ((double) num3 < (double) weighted.weight)
              {
                num1 = index;
                break;
              }
              num3 -= weighted.weight;
            }
          }
        }
      }
    }
    return num1;
  }

  [Serializable]
  public struct Entry<T1>
  {
    public T1 value;
    public float weight;
  }
}
