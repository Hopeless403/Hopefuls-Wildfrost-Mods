// Decompiled with JetBrains decompiler
// Type: CardDestroyedSacrifice
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using UnityEngine;

#nullable disable
public class CardDestroyedSacrifice : MonoBehaviour, ICardDestroyed, IRemoveWhenPooled
{
  public float dur = 0.5f;
  public const LeanTweenType ease = LeanTweenType.easeInBack;
  public Entity entity;

  public void Start()
  {
    this.entity = this.GetComponent<Entity>();
    this.entity.wobbler.WobbleRandom();
    Events.InvokeCameraAnimation("Droop");
    Events.InvokeScreenRumble(0.0f, 0.25f, 0.0f, 0.25f * this.dur, 0.5f * this.dur, 0.25f * this.dur);
    LeanTween.scale(this.gameObject, new Vector3(0.25f, 0.25f, 1f), this.dur).setEase(LeanTweenType.easeInBack).setOnComplete(new System.Action(this.Final));
    LeanTween.rotateY(this.gameObject, (float) 90.WithRandomSign(), this.dur).setEase(LeanTweenType.easeInBack);
    if (!(this.entity.display is Card display))
      return;
    CanvasGroup canvasGroup = display.canvasGroup;
    if (canvasGroup == null)
      return;
    LeanTween.alphaCanvas(canvasGroup, 0.0f, this.dur).setEase(LeanTweenType.easeInBack);
  }

  public void Final()
  {
    UnityEngine.Object.Destroy((UnityEngine.Object) this);
    CardManager.ReturnToPool(this.entity);
  }
}
