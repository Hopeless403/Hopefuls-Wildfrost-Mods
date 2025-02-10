// Decompiled with JetBrains decompiler
// Type: GainCompanionSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 47C9391B-2D31-46A1-B2AD-EF073E28C56A
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System.Collections;

public class GainCompanionSequence : UISequence
{
  public Entity target;

  public void SetTarget(Entity target) => this.target = target;

  public override IEnumerator Run()
  {
    yield return (object) null;
  }
}
