// Decompiled with JetBrains decompiler
// Type: CardAnimationFlyToBackpack
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using NaughtyAttributes;
using System.Collections;
using UnityEngine;

[CreateAssetMenu(fileName = "FlyToBackpack", menuName = "Card Animation/Fly To Backpack")]
public class CardAnimationFlyToBackpack : CardAnimation
{
  [SerializeField]
  private AnimationCurve xCurve;
  [SerializeField]
  private AnimationCurve yCurve;
  [SerializeField]
  private AnimationCurve zCurve;
  [SerializeField]
  private AnimationCurve spinCurve;
  [SerializeField]
  private AnimationCurve scaleCurve;
  [SerializeField]
  private bool destroyOnEnd = true;
  [Header("Duration")]
  [SerializeField]
  private bool fixedDuration;
  [SerializeField]
  [ShowIf("fixedDuration")]
  private float duration = 0.5f;
  [SerializeField]
  [HideIf("fixedDuration")]
  private AnimationCurve durationToDistance;
  [Header("Glows")]
  [SerializeField]
  private AnimationCurve glowMain;
  [SerializeField]
  private Vector2 glowMainSize = new Vector2(4f, 6f);
  [SerializeField]
  private AnimationCurve glowExtra;
  [SerializeField]
  private int glowExtraCount = 4;
  [SerializeField]
  private Rect glowExtraArea = new Rect(-0.7f, -1.3f, 1.4f, 2.6f);
  [SerializeField]
  private Vector2 glowExtraSizeRange = new Vector2(2f, 3f);
  [SerializeField]
  private Vector2 glowExtraDelay = new Vector2(0.0f, 0.5f);
  [SerializeField]
  private Glow glowPrefab;
  [Header("Jump")]
  [SerializeField]
  private AnimationCurve yUpCurve;
  [SerializeField]
  private float yUpAmount = 0.25f;

  public override IEnumerator Routine(object data, float startDelay = 0.0f)
  {
    if (data is Entity entity)
    {
      Transform target = entity.transform;
      if (target != null)
      {
        yield return (object) new WaitForSeconds(startDelay);
        Deckpack deckpack = MonoBehaviourSingleton<Deckpack>.instance;
        if (deckpack != null)
        {
          target.SetParent(deckpack.transform, true);
          AngleWobbler[] wobblers = target.GetComponentsInChildren<AngleWobbler>();
          foreach (AngleWobbler angleWobbler in wobblers)
            angleWobbler.globalSpace = false;
          Vector3 start = target.localPosition;
          Vector3 offset = Vector3.zero - start;
          float t = 0.0f;
          float z = target.localEulerAngles.z;
          Vector3 scale = target.localScale;
          float dur = this.fixedDuration ? this.duration : this.durationToDistance.Evaluate(offset.WithZ(0.0f).magnitude);
          Object.Instantiate<Glow>(this.glowPrefab, target).SetColor(Color.white).SetPosition(Vector2.zero).SetSize(this.glowMainSize).Fade(this.glowMain, dur);
          for (int index = 0; index < this.glowExtraCount; ++index)
          {
            float delay = this.glowExtraDelay.PettyRandom();
            float duration = dur - delay;
            Object.Instantiate<Glow>(this.glowPrefab, target).RandomColor().SetPosition(this.glowExtraArea.RandomPosition()).SetSize(Vector2.one * this.glowExtraSizeRange.PettyRandom()).Fade(this.glowExtra, duration, delay);
          }
          yield return (object) null;
          while ((double) t < 1.0 && (bool) (Object) target)
          {
            t += Time.deltaTime / dur;
            target.localPosition = start + offset.Multiply(this.xCurve.Evaluate(t), this.yCurve.Evaluate(t), this.zCurve.Evaluate(t)) + Vector3.up * this.yUpCurve.Evaluate(t) * this.yUpAmount;
            target.localEulerAngles = target.localEulerAngles.WithZ(z + this.spinCurve.Evaluate(t));
            target.localScale = scale * this.scaleCurve.Evaluate(t);
            yield return (object) null;
          }
          if (this.destroyOnEnd && (bool) (Object) target)
          {
            entity.RemoveFromContainers();
            CardManager.ReturnToPool(entity);
            foreach (AngleWobbler angleWobbler in wobblers)
            {
              if ((bool) (Object) angleWobbler)
                angleWobbler.globalSpace = true;
            }
          }
          if ((bool) (Object) deckpack)
            deckpack.Ping();
          wobblers = (AngleWobbler[]) null;
          start = new Vector3();
          offset = new Vector3();
          scale = new Vector3();
        }
        deckpack = (Deckpack) null;
      }
    }
  }
}
