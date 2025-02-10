// Decompiled with JetBrains decompiler
// Type: CardDestroyed
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

public class CardDestroyed : FlyOffScreen, ICardDestroyed, IRemoveWhenPooled
{
  private AngleWobbler[] wobblers;

  protected override void Begin()
  {
    this.wobblers = this.GetComponentsInChildren<AngleWobbler>();
    foreach (AngleWobbler wobbler in this.wobblers)
      wobbler.globalSpace = false;
  }

  protected override void End() => this.Final();

  public void Final()
  {
    Object.Destroy((Object) this);
    CardManager.ReturnToPool(this.gameObject.GetComponent<Card>());
  }

  private void OnDisable()
  {
    foreach (AngleWobbler wobbler in this.wobblers)
      wobbler.globalSpace = true;
    this.wobblers = (AngleWobbler[]) null;
  }
}
