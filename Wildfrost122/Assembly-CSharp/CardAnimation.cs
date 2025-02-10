// Decompiled with JetBrains decompiler
// Type: CardAnimation
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;

#nullable disable
public abstract class CardAnimation : ScriptableObject
{
  public virtual IEnumerator Routine(object data, float startDelay = 0.0f) => (IEnumerator) null;
}
