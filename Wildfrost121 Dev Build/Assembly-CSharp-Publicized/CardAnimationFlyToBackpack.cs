// Decompiled with JetBrains decompiler
// Type: CardAnimationFlyToBackpack
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0418E061-3ED1-4467-97F2-4F1CA34BFCD4
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using NaughtyAttributes;
using System.Collections;
using UnityEngine;

#nullable disable
[CreateAssetMenu(fileName = "FlyToBackpack", menuName = "Card Animation/Fly To Backpack")]
public class CardAnimationFlyToBackpack : CardAnimation
{
  [SerializeField]
  public AnimationCurve xCurve;
  [SerializeField]
  public AnimationCurve yCurve;
  [SerializeField]
  public AnimationCurve zCurve;
  [SerializeField]
  public AnimationCurve spinCurve;
  [SerializeField]
  public AnimationCurve scaleCurve;
  [SerializeField]
  public bool destroyOnEnd = true;
  [Header("Duration")]
  [SerializeField]
  public bool fixedDuration;
  [SerializeField]
  [ShowIf("fixedDuration")]
  public float duration = 0.5f;
  [SerializeField]
  [HideIf("fixedDuration")]
  public AnimationCurve durationToDistance;
  [Header("Glows")]
  [SerializeField]
  public AnimationCurve glowMain;
  [SerializeField]
  public Vector2 glowMainSize = new Vector2(4f, 6f);
  [SerializeField]
  public AnimationCurve glowExtra;
  [SerializeField]
  public int glowExtraCount = 4;
  [SerializeField]
  public Rect glowExtraArea = new Rect(-0.7f, -1.3f, 1.4f, 2.6f);
  [SerializeField]
  public Vector2 glowExtraSizeRange = new Vector2(2f, 3f);
  [SerializeField]
  public Vector2 glowExtraDelay = new Vector2(0.0f, 0.5f);
  [SerializeField]
  public Glow glowPrefab;
  [Header("Jump")]
  [SerializeField]
  public AnimationCurve yUpCurve;
  [SerializeField]
  public float yUpAmount = 0.25f;

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
