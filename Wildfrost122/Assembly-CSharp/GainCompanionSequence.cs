// Decompiled with JetBrains decompiler
// Type: GainCompanionSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;

#nullable disable
public class GainCompanionSequence : UISequence
{
  private Entity target;

  public void SetTarget(Entity target) => this.target = target;

  public override IEnumerator Run()
  {
    yield return (object) null;
  }
}
