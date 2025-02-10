// Decompiled with JetBrains decompiler
// Type: GainCompanionSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System.Collections;

public class GainCompanionSequence : UISequence
{
  private Entity target;

  public void SetTarget(Entity target) => this.target = target;

  public override IEnumerator Run()
  {
    yield return (object) null;
  }
}
