// Decompiled with JetBrains decompiler
// Type: GainCompanionSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;

#nullable disable
public class GainCompanionSequence : UISequence
{
  public Entity target;

  public void SetTarget(Entity target) => this.target = target;

  public override IEnumerator Run()
  {
    yield return (object) null;
  }
}
