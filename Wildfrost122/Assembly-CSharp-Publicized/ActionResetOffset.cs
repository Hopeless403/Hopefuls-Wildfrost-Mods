// Decompiled with JetBrains decompiler
// Type: ActionResetOffset
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

#nullable disable
public class ActionResetOffset : PlayAction
{
  public readonly Entity entity;
  public const float dur = 0.33f;
  public const LeanTweenType ease = LeanTweenType.easeOutQuint;

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
