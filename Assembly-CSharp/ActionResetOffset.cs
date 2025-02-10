// Decompiled with JetBrains decompiler
// Type: ActionResetOffset
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using UnityEngine;

public class ActionResetOffset : PlayAction
{
  private readonly Entity entity;
  private const float dur = 0.33f;
  private const LeanTweenType ease = LeanTweenType.easeOutQuint;

  public ActionResetOffset(Entity entity) => this.entity = entity;

  public override bool IsRoutine => false;

  public override void Process()
  {
    if (!this.entity.IsAliveAndExists())
      return;
    GameObject gameObject = this.entity.offset.gameObject;
    LeanTween.cancel(gameObject);
    LeanTween.scale(gameObject, Vector3.one, 0.33f).setEase(LeanTweenType.easeOutQuint);
    LeanTween.moveLocal(gameObject, Vector3.zero, 0.33f).setEase(LeanTweenType.easeOutQuint);
    LeanTween.rotateLocal(gameObject, Vector3.zero, 0.33f).setEase(LeanTweenType.easeOutQuint);
    this.entity.ResetDrawOrder();
  }
}
