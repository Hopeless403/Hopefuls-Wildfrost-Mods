// Decompiled with JetBrains decompiler
// Type: LeanTween
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

#nullable disable
public class LeanTween : MonoBehaviour
{
  public static bool throwErrors = true;
  public static float tau = 6.28318548f;
  public static float PI_DIV2 = 1.57079637f;
  public static LTSeq[] sequences;
  public static LTDescr[] tweens;
  public static int[] tweensFinished;
  public static int[] tweensFinishedIds;
  public static LTDescr tween;
  public static int tweenMaxSearch = -1;
  public static int maxTweens = 400;
  public static int maxSequences = 400;
  public static int frameRendered = -1;
  public static GameObject _tweenEmpty;
  public static float dtEstimated = -1f;
  public static float dtManual;
  public static float dtActual;
  public static uint global_counter = 0;
  public static int i;
  public static int j;
  public static int finishedCnt;
  public static AnimationCurve punch = new AnimationCurve(new Keyframe[9]
  {
    new Keyframe(0.0f, 0.0f),
    new Keyframe(0.112586f, 0.9976035f),
    new Keyframe(0.3120486f, -0.1720615f),
    new Keyframe(0.4316337f, 0.07030682f),
    new Keyframe(0.5524869f, -0.03141804f),
    new Keyframe(0.6549395f, 0.003909959f),
    new Keyframe(0.770987f, -0.009817753f),
    new Keyframe(0.8838775f, 0.001939224f),
    new Keyframe(1f, 0.0f)
  });
  public static AnimationCurve shake = new AnimationCurve(new Keyframe[4]
  {
    new Keyframe(0.0f, 0.0f),
    new Keyframe(0.25f, 1f),
    new Keyframe(0.75f, -1f),
    new Keyframe(1f, 0.0f)
  });
  public static int maxTweenReached;
  public static int startSearch = 0;
  public static LTDescr d;
  public static Action<LTEvent>[] eventListeners;
  public static GameObject[] goListeners;
  public static int eventsMaxSearch = 0;
  public static int EVENTS_MAX = 10;
  public static int LISTENERS_MAX = 10;
  public static int INIT_LISTENERS_MAX = LeanTween.LISTENERS_MAX;

  public static void init() => LeanTween.init(LeanTween.maxTweens);

  public static int maxSearch => LeanTween.tweenMaxSearch;

  public static int maxSimulataneousTweens => LeanTween.maxTweens;

  public static int tweensRunning
  {
    get
    {
      int tweensRunning = 0;
      for (int index = 0; index <= LeanTween.tweenMaxSearch; ++index)
      {
        if (LeanTween.tweens[index].toggle)
          ++tweensRunning;
      }
      return tweensRunning;
    }
  }

  public static void init(int maxSimultaneousTweens)
  {
    LeanTween.init(maxSimultaneousTweens, LeanTween.maxSequences);
  }

  public static void init(int maxSimultaneousTweens, int maxSimultaneousSequences)
  {
    if (LeanTween.tweens != null)
      return;
    LeanTween.maxTweens = maxSimultaneousTweens;
    LeanTween.tweens = new LTDescr[LeanTween.maxTweens];
    LeanTween.tweensFinished = new int[LeanTween.maxTweens];
    LeanTween.tweensFinishedIds = new int[LeanTween.maxTweens];
    LeanTween._tweenEmpty = new GameObject();
    LeanTween._tweenEmpty.name = "~LeanTween";
    LeanTween._tweenEmpty.AddComponent(typeof (LeanTween));
    LeanTween._tweenEmpty.isStatic = true;
    LeanTween._tweenEmpty.hideFlags = HideFlags.HideAndDontSave;
    UnityEngine.Object.DontDestroyOnLoad((UnityEngine.Object) LeanTween._tweenEmpty);
    for (int index = 0; index < LeanTween.maxTweens; ++index)
      LeanTween.tweens[index] = new LTDescr();
    UnityEngine.SceneManagement.SceneManager.sceneLoaded += new UnityAction<Scene, LoadSceneMode>(LeanTween.onLevelWasLoaded54);
    LeanTween.sequences = new LTSeq[maxSimultaneousSequences];
    for (int index = 0; index < maxSimultaneousSequences; ++index)
      LeanTween.sequences[index] = new LTSeq();
  }

  public static void reset()
  {
    if (LeanTween.tweens != null)
    {
      for (int index = 0; index <= LeanTween.tweenMaxSearch; ++index)
      {
        if (LeanTween.tweens[index] != null)
          LeanTween.tweens[index].toggle = false;
      }
    }
    LeanTween.tweens = (LTDescr[]) null;
    UnityEngine.Object.Destroy((UnityEngine.Object) LeanTween._tweenEmpty);
  }

  public void Update() => LeanTween.update();

  public static void onLevelWasLoaded54(Scene scene, LoadSceneMode mode)
  {
    LeanTween.internalOnLevelWasLoaded(scene.buildIndex);
  }

  public static void internalOnLevelWasLoaded(int lvl) => LTGUI.reset();

  public static void update()
  {
    if (LeanTween.frameRendered == Time.frameCount)
      return;
    LeanTween.init();
    LeanTween.dtEstimated = (double) LeanTween.dtEstimated < 0.0 ? 0.0f : (LeanTween.dtEstimated = Time.unscaledDeltaTime);
    LeanTween.dtActual = Time.deltaTime;
    LeanTween.maxTweenReached = 0;
    LeanTween.finishedCnt = 0;
    for (int index = 0; index <= LeanTween.tweenMaxSearch && index < LeanTween.maxTweens; ++index)
    {
      LeanTween.tween = LeanTween.tweens[index];
      if (LeanTween.tween.toggle)
      {
        LeanTween.maxTweenReached = index;
        if (LeanTween.tween.updateInternal())
        {
          LeanTween.tweensFinished[LeanTween.finishedCnt] = index;
          LeanTween.tweensFinishedIds[LeanTween.finishedCnt] = LeanTween.tweens[index].id;
          ++LeanTween.finishedCnt;
        }
      }
    }
    LeanTween.tweenMaxSearch = LeanTween.maxTweenReached;
    LeanTween.frameRendered = Time.frameCount;
    for (int index = 0; index < LeanTween.finishedCnt; ++index)
    {
      LeanTween.j = LeanTween.tweensFinished[index];
      LeanTween.tween = LeanTween.tweens[LeanTween.j];
      if (LeanTween.tween.id == LeanTween.tweensFinishedIds[index])
      {
        LeanTween.removeTween(LeanTween.j);
        if (LeanTween.tween.hasExtraOnCompletes && (UnityEngine.Object) LeanTween.tween.trans != (UnityEngine.Object) null)
          LeanTween.tween.callOnCompletes();
      }
    }
  }

  public static void removeTween(int i, int uniqueId)
  {
    if (LeanTween.tweens[i].uniqueId != uniqueId)
      return;
    LeanTween.removeTween(i);
  }

  public static void removeTween(int i)
  {
    if (!LeanTween.tweens[i].toggle)
      return;
    LeanTween.tweens[i].toggle = false;
    LeanTween.tweens[i].counter = uint.MaxValue;
    if (LeanTween.tweens[i].destroyOnComplete)
    {
      if (LeanTween.tweens[i]._optional.ltRect != null)
        LTGUI.destroy(LeanTween.tweens[i]._optional.ltRect.id);
      else if ((UnityEngine.Object) LeanTween.tweens[i].trans != (UnityEngine.Object) null && (UnityEngine.Object) LeanTween.tweens[i].trans.gameObject != (UnityEngine.Object) LeanTween._tweenEmpty)
        UnityEngine.Object.Destroy((UnityEngine.Object) LeanTween.tweens[i].trans.gameObject);
    }
    LeanTween.startSearch = i;
    if (i + 1 < LeanTween.tweenMaxSearch)
      return;
    LeanTween.startSearch = 0;
  }

  public static Vector3[] add(Vector3[] a, Vector3 b)
  {
    Vector3[] vector3Array = new Vector3[a.Length];
    for (LeanTween.i = 0; LeanTween.i < a.Length; ++LeanTween.i)
      vector3Array[LeanTween.i] = a[LeanTween.i] + b;
    return vector3Array;
  }

  public static float closestRot(float from, float to)
  {
    float num1 = (float) (0.0 - (360.0 - (double) to));
    float num2 = 360f + to;
    float num3 = Mathf.Abs(to - from);
    float num4 = Mathf.Abs(num1 - from);
    float num5 = Mathf.Abs(num2 - from);
    if ((double) num3 < (double) num4 && (double) num3 < (double) num5)
      return to;
    return (double) num4 < (double) num5 ? num1 : num2;
  }

  public static void cancelAll() => LeanTween.cancelAll(false);

  public static void cancelAll(bool callComplete)
  {
    LeanTween.init();
    for (int i = 0; i <= LeanTween.tweenMaxSearch; ++i)
    {
      if ((UnityEngine.Object) LeanTween.tweens[i].trans != (UnityEngine.Object) null)
      {
        if (callComplete && LeanTween.tweens[i].optional.onComplete != null)
          LeanTween.tweens[i].optional.onComplete();
        LeanTween.removeTween(i);
      }
    }
  }

  public static void cancel(GameObject gameObject) => LeanTween.cancel(gameObject, false);

  public static void cancel(GameObject gameObject, bool callOnComplete)
  {
    LeanTween.init();
    Transform transform = gameObject.transform;
    for (int i = 0; i <= LeanTween.tweenMaxSearch; ++i)
    {
      LTDescr tween = LeanTween.tweens[i];
      if (tween != null && tween.toggle && (UnityEngine.Object) tween.trans == (UnityEngine.Object) transform)
      {
        if (callOnComplete && tween.optional.onComplete != null)
          tween.optional.onComplete();
        LeanTween.removeTween(i);
      }
    }
  }

  public static void cancel(RectTransform rect) => LeanTween.cancel(rect.gameObject, false);

  public static void cancel(GameObject gameObject, int uniqueId, bool callOnComplete = false)
  {
    if (uniqueId < 0)
      return;
    LeanTween.init();
    int i = uniqueId & (int) ushort.MaxValue;
    int num = uniqueId >> 16;
    if (!((UnityEngine.Object) LeanTween.tweens[i].trans == (UnityEngine.Object) null) && (!((UnityEngine.Object) LeanTween.tweens[i].trans.gameObject == (UnityEngine.Object) gameObject) || (long) LeanTween.tweens[i].counter != (long) num))
      return;
    if (callOnComplete && LeanTween.tweens[i].optional.onComplete != null)
      LeanTween.tweens[i].optional.onComplete();
    LeanTween.removeTween(i);
  }

  public static void cancel(LTRect ltRect, int uniqueId)
  {
    if (uniqueId < 0)
      return;
    LeanTween.init();
    int i = uniqueId & (int) ushort.MaxValue;
    int num = uniqueId >> 16;
    if (LeanTween.tweens[i]._optional.ltRect != ltRect || (long) LeanTween.tweens[i].counter != (long) num)
      return;
    LeanTween.removeTween(i);
  }

  public static void cancel(int uniqueId) => LeanTween.cancel(uniqueId, false);

  public static void cancel(int uniqueId, bool callOnComplete)
  {
    if (uniqueId < 0)
      return;
    LeanTween.init();
    int i = uniqueId & (int) ushort.MaxValue;
    int num = uniqueId >> 16;
    if (i > LeanTween.tweens.Length - 1)
    {
      int index1 = i - LeanTween.tweens.Length;
      LTSeq sequence = LeanTween.sequences[index1];
      for (int index2 = 0; index2 < LeanTween.maxSequences; ++index2)
      {
        if (sequence.current.tween != null)
          LeanTween.removeTween(sequence.current.tween.uniqueId & (int) ushort.MaxValue);
        if (sequence.current.previous == null)
          break;
        sequence.current = sequence.current.previous;
      }
    }
    else
    {
      if ((long) LeanTween.tweens[i].counter != (long) num)
        return;
      if (callOnComplete && LeanTween.tweens[i].optional.onComplete != null)
        LeanTween.tweens[i].optional.onComplete();
      LeanTween.removeTween(i);
    }
  }

  public static LTDescr descr(int uniqueId)
  {
    LeanTween.init();
    int index1 = uniqueId & (int) ushort.MaxValue;
    int num = uniqueId >> 16;
    if (LeanTween.tweens[index1] != null && LeanTween.tweens[index1].uniqueId == uniqueId && (long) LeanTween.tweens[index1].counter == (long) num)
      return LeanTween.tweens[index1];
    for (int index2 = 0; index2 <= LeanTween.tweenMaxSearch; ++index2)
    {
      if (LeanTween.tweens[index2].uniqueId == uniqueId && (long) LeanTween.tweens[index2].counter == (long) num)
        return LeanTween.tweens[index2];
    }
    return (LTDescr) null;
  }

  public static LTDescr description(int uniqueId) => LeanTween.descr(uniqueId);

  public static LTDescr[] descriptions(GameObject gameObject = null)
  {
    if ((UnityEngine.Object) gameObject == (UnityEngine.Object) null)
      return (LTDescr[]) null;
    List<LTDescr> ltDescrList = new List<LTDescr>();
    Transform transform = gameObject.transform;
    for (int index = 0; index <= LeanTween.tweenMaxSearch; ++index)
    {
      if (LeanTween.tweens[index].toggle && (UnityEngine.Object) LeanTween.tweens[index].trans == (UnityEngine.Object) transform)
        ltDescrList.Add(LeanTween.tweens[index]);
    }
    return ltDescrList.ToArray();
  }

  [Obsolete("Use 'pause( id )' instead")]
  public static void pause(GameObject gameObject, int uniqueId) => LeanTween.pause(uniqueId);

  public static void pause(int uniqueId)
  {
    int index = uniqueId & (int) ushort.MaxValue;
    int num = uniqueId >> 16;
    if ((long) LeanTween.tweens[index].counter != (long) num)
      return;
    LeanTween.tweens[index].pause();
  }

  public static void pause(GameObject gameObject)
  {
    Transform transform = gameObject.transform;
    for (int index = 0; index <= LeanTween.tweenMaxSearch; ++index)
    {
      if ((UnityEngine.Object) LeanTween.tweens[index].trans == (UnityEngine.Object) transform)
        LeanTween.tweens[index].pause();
    }
  }

  public static void pauseAll()
  {
    LeanTween.init();
    for (int index = 0; index <= LeanTween.tweenMaxSearch; ++index)
      LeanTween.tweens[index].pause();
  }

  public static void resumeAll()
  {
    LeanTween.init();
    for (int index = 0; index <= LeanTween.tweenMaxSearch; ++index)
      LeanTween.tweens[index].resume();
  }

  [Obsolete("Use 'resume( id )' instead")]
  public static void resume(GameObject gameObject, int uniqueId) => LeanTween.resume(uniqueId);

  public static void resume(int uniqueId)
  {
    int index = uniqueId & (int) ushort.MaxValue;
    int num = uniqueId >> 16;
    if ((long) LeanTween.tweens[index].counter != (long) num)
      return;
    LeanTween.tweens[index].resume();
  }

  public static void resume(GameObject gameObject)
  {
    Transform transform = gameObject.transform;
    for (int index = 0; index <= LeanTween.tweenMaxSearch; ++index)
    {
      if ((UnityEngine.Object) LeanTween.tweens[index].trans == (UnityEngine.Object) transform)
        LeanTween.tweens[index].resume();
    }
  }

  public static bool isPaused(GameObject gameObject = null)
  {
    if ((UnityEngine.Object) gameObject == (UnityEngine.Object) null)
    {
      for (int index = 0; index <= LeanTween.tweenMaxSearch; ++index)
      {
        if (object.Equals((object) LeanTween.tweens[index].direction, (object) 0.0f))
          return true;
      }
      return false;
    }
    Transform transform = gameObject.transform;
    for (int index = 0; index <= LeanTween.tweenMaxSearch; ++index)
    {
      if (object.Equals((object) LeanTween.tweens[index].direction, (object) 0.0f) && (UnityEngine.Object) LeanTween.tweens[index].trans == (UnityEngine.Object) transform)
        return true;
    }
    return false;
  }

  public static bool isPaused(RectTransform rect) => LeanTween.isTweening(rect.gameObject);

  public static bool isPaused(int uniqueId)
  {
    int index = uniqueId & (int) ushort.MaxValue;
    int num = uniqueId >> 16;
    return index >= 0 && index < LeanTween.maxTweens && (long) LeanTween.tweens[index].counter == (long) num && object.Equals((object) LeanTween.tweens[LeanTween.i].direction, (object) 0.0f);
  }

  public static bool isTweening(GameObject gameObject = null)
  {
    if ((UnityEngine.Object) gameObject == (UnityEngine.Object) null)
    {
      for (int index = 0; index <= LeanTween.tweenMaxSearch; ++index)
      {
        if (LeanTween.tweens[index].toggle)
          return true;
      }
      return false;
    }
    Transform transform = gameObject.transform;
    for (int index = 0; index <= LeanTween.tweenMaxSearch; ++index)
    {
      if (LeanTween.tweens[index].toggle && (UnityEngine.Object) LeanTween.tweens[index].trans == (UnityEngine.Object) transform)
        return true;
    }
    return false;
  }

  public static bool isTweening(RectTransform rect) => LeanTween.isTweening(rect.gameObject);

  public static bool isTweening(int uniqueId)
  {
    int index = uniqueId & (int) ushort.MaxValue;
    int num = uniqueId >> 16;
    return index >= 0 && index < LeanTween.maxTweens && (long) LeanTween.tweens[index].counter == (long) num && LeanTween.tweens[index].toggle;
  }

  public static bool isTweening(LTRect ltRect)
  {
    for (int index = 0; index <= LeanTween.tweenMaxSearch; ++index)
    {
      if (LeanTween.tweens[index].toggle && LeanTween.tweens[index]._optional.ltRect == ltRect)
        return true;
    }
    return false;
  }

  public static void drawBezierPath(
    Vector3 a,
    Vector3 b,
    Vector3 c,
    Vector3 d,
    float arrowSize = 0.0f,
    Transform arrowTransform = null)
  {
    Vector3 vector3_1 = a;
    Vector3 vector3_2 = -a + 3f * (b - c) + d;
    Vector3 vector3_3 = 3f * (a + c) - 6f * b;
    Vector3 vector3_4 = 3f * (b - a);
    if ((double) arrowSize > 0.0)
    {
      Vector3 position = arrowTransform.position;
      Quaternion rotation = arrowTransform.rotation;
      float num1 = 0.0f;
      for (float num2 = 1f; (double) num2 <= 120.0; ++num2)
      {
        float num3 = num2 / 120f;
        Vector3 vector3_5 = ((vector3_2 * num3 + vector3_3) * num3 + vector3_4) * num3 + a;
        Gizmos.DrawLine(vector3_1, vector3_5);
        num1 += (vector3_5 - vector3_1).magnitude;
        if ((double) num1 > 1.0)
        {
          --num1;
          arrowTransform.position = vector3_5;
          arrowTransform.LookAt(vector3_1, Vector3.forward);
          Vector3 vector3_6 = arrowTransform.TransformDirection(Vector3.right);
          Vector3 normalized = (vector3_1 - vector3_5).normalized;
          Gizmos.DrawLine(vector3_5, vector3_5 + (vector3_6 + normalized) * arrowSize);
          Vector3 vector3_7 = arrowTransform.TransformDirection(-Vector3.right);
          Gizmos.DrawLine(vector3_5, vector3_5 + (vector3_7 + normalized) * arrowSize);
        }
        vector3_1 = vector3_5;
      }
      arrowTransform.position = position;
      arrowTransform.rotation = rotation;
    }
    else
    {
      for (float num4 = 1f; (double) num4 <= 30.0; ++num4)
      {
        float num5 = num4 / 30f;
        Vector3 to = ((vector3_2 * num5 + vector3_3) * num5 + vector3_4) * num5 + a;
        Gizmos.DrawLine(vector3_1, to);
        vector3_1 = to;
      }
    }
  }

  public static object logError(string error)
  {
    if (LeanTween.throwErrors)
      Debug.LogError((object) error);
    else
      Debug.Log((object) error);
    return (object) null;
  }

  public static LTDescr options(LTDescr seed)
  {
    Debug.LogError((object) "error this function is no longer used");
    return (LTDescr) null;
  }

  public static LTDescr options()
  {
    LeanTween.init();
    bool flag = false;
    LeanTween.j = 0;
    LeanTween.i = LeanTween.startSearch;
    while (LeanTween.j <= LeanTween.maxTweens)
    {
      if (LeanTween.j >= LeanTween.maxTweens)
        return LeanTween.logError("LeanTween - You have run out of available spaces for tweening. To avoid this error increase the number of spaces to available for tweening when you initialize the LeanTween class ex: LeanTween.init( " + (LeanTween.maxTweens * 2).ToString() + " );") as LTDescr;
      if (LeanTween.i >= LeanTween.maxTweens)
        LeanTween.i = 0;
      if (!LeanTween.tweens[LeanTween.i].toggle)
      {
        if (LeanTween.i + 1 > LeanTween.tweenMaxSearch && LeanTween.i + 1 < LeanTween.maxTweens)
          LeanTween.tweenMaxSearch = LeanTween.i + 1;
        LeanTween.startSearch = LeanTween.i + 1;
        flag = true;
        break;
      }
      ++LeanTween.j;
      ++LeanTween.i;
    }
    if (!flag)
      LeanTween.logError("no available tween found!");
    LeanTween.tweens[LeanTween.i].reset();
    ++LeanTween.global_counter;
    if (LeanTween.global_counter > 32768U)
      LeanTween.global_counter = 0U;
    LeanTween.tweens[LeanTween.i].setId((uint) LeanTween.i, LeanTween.global_counter);
    return LeanTween.tweens[LeanTween.i];
  }

  public static GameObject tweenEmpty
  {
    get
    {
      LeanTween.init(LeanTween.maxTweens);
      return LeanTween._tweenEmpty;
    }
  }

  public static LTDescr pushNewTween(GameObject gameObject, Vector3 to, float time, LTDescr tween)
  {
    LeanTween.init(LeanTween.maxTweens);
    if ((UnityEngine.Object) gameObject == (UnityEngine.Object) null || tween == null)
      return (LTDescr) null;
    tween.trans = gameObject.transform;
    tween.to = to;
    tween.time = time;
    if ((double) tween.time <= 0.0)
      tween.updateInternal();
    return tween;
  }

  public static LTDescr play(RectTransform rectTransform, Sprite[] sprites)
  {
    float time = 0.25f * (float) sprites.Length;
    return LeanTween.pushNewTween(rectTransform.gameObject, new Vector3((float) sprites.Length - 1f, 0.0f, 0.0f), time, LeanTween.options().setCanvasPlaySprite().setSprites(sprites).setRepeat(-1));
  }

  public static LTSeq sequence(bool initSequence = true)
  {
    LeanTween.init(LeanTween.maxTweens);
    for (int index = 0; index < LeanTween.sequences.Length; ++index)
    {
      if ((LeanTween.sequences[index].tween == null || !LeanTween.sequences[index].tween.toggle) && !LeanTween.sequences[index].toggle)
      {
        LTSeq sequence = LeanTween.sequences[index];
        if (initSequence)
        {
          sequence.init((uint) (index + LeanTween.tweens.Length), LeanTween.global_counter);
          ++LeanTween.global_counter;
          if (LeanTween.global_counter > 32768U)
            LeanTween.global_counter = 0U;
        }
        else
          sequence.reset();
        return sequence;
      }
    }
    return (LTSeq) null;
  }

  public static LTDescr alpha(GameObject gameObject, float to, float time)
  {
    LTDescr ltDescr = LeanTween.pushNewTween(gameObject, new Vector3(to, 0.0f, 0.0f), time, LeanTween.options().setAlpha());
    ltDescr.spriteRen = gameObject.GetComponent<SpriteRenderer>();
    return ltDescr;
  }

  public static LTDescr alpha(LTRect ltRect, float to, float time)
  {
    ltRect.alphaEnabled = true;
    return LeanTween.pushNewTween(LeanTween.tweenEmpty, new Vector3(to, 0.0f, 0.0f), time, LeanTween.options().setGUIAlpha().setRect(ltRect));
  }

  public static LTDescr textAlpha(RectTransform rectTransform, float to, float time)
  {
    return LeanTween.pushNewTween(rectTransform.gameObject, new Vector3(to, 0.0f, 0.0f), time, LeanTween.options().setTextAlpha());
  }

  public static LTDescr alphaText(RectTransform rectTransform, float to, float time)
  {
    return LeanTween.pushNewTween(rectTransform.gameObject, new Vector3(to, 0.0f, 0.0f), time, LeanTween.options().setTextAlpha());
  }

  public static LTDescr alphaCanvas(CanvasGroup canvasGroup, float to, float time)
  {
    return LeanTween.pushNewTween(canvasGroup.gameObject, new Vector3(to, 0.0f, 0.0f), time, LeanTween.options().setCanvasGroupAlpha());
  }

  public static LTDescr alphaVertex(GameObject gameObject, float to, float time)
  {
    return LeanTween.pushNewTween(gameObject, new Vector3(to, 0.0f, 0.0f), time, LeanTween.options().setAlphaVertex());
  }

  public static LTDescr color(GameObject gameObject, Color to, float time)
  {
    LTDescr ltDescr = LeanTween.pushNewTween(gameObject, new Vector3(1f, to.a, 0.0f), time, LeanTween.options().setColor().setPoint(new Vector3(to.r, to.g, to.b)));
    ltDescr.spriteRen = gameObject.GetComponent<SpriteRenderer>();
    return ltDescr;
  }

  public static LTDescr textColor(RectTransform rectTransform, Color to, float time)
  {
    return LeanTween.pushNewTween(rectTransform.gameObject, new Vector3(1f, to.a, 0.0f), time, LeanTween.options().setTextColor().setPoint(new Vector3(to.r, to.g, to.b)));
  }

  public static LTDescr colorText(RectTransform rectTransform, Color to, float time)
  {
    return LeanTween.pushNewTween(rectTransform.gameObject, new Vector3(1f, to.a, 0.0f), time, LeanTween.options().setTextColor().setPoint(new Vector3(to.r, to.g, to.b)));
  }

  public static LTDescr delayedCall(float delayTime, System.Action callback)
  {
    return LeanTween.pushNewTween(LeanTween.tweenEmpty, Vector3.zero, delayTime, LeanTween.options().setCallback().setOnComplete(callback));
  }

  public static LTDescr delayedCall(float delayTime, Action<object> callback)
  {
    return LeanTween.pushNewTween(LeanTween.tweenEmpty, Vector3.zero, delayTime, LeanTween.options().setCallback().setOnComplete(callback));
  }

  public static LTDescr delayedCall(GameObject gameObject, float delayTime, System.Action callback)
  {
    return LeanTween.pushNewTween(gameObject, Vector3.zero, delayTime, LeanTween.options().setCallback().setOnComplete(callback));
  }

  public static LTDescr delayedCall(
    GameObject gameObject,
    float delayTime,
    Action<object> callback)
  {
    return LeanTween.pushNewTween(gameObject, Vector3.zero, delayTime, LeanTween.options().setCallback().setOnComplete(callback));
  }

  public static LTDescr destroyAfter(LTRect rect, float delayTime)
  {
    return LeanTween.pushNewTween(LeanTween.tweenEmpty, Vector3.zero, delayTime, LeanTween.options().setCallback().setRect(rect).setDestroyOnComplete(true));
  }

  public static LTDescr move(GameObject gameObject, Vector3 to, float time)
  {
    return LeanTween.pushNewTween(gameObject, to, time, LeanTween.options().setMove());
  }

  public static LTDescr move(GameObject gameObject, Vector2 to, float time)
  {
    return LeanTween.pushNewTween(gameObject, new Vector3(to.x, to.y, gameObject.transform.position.z), time, LeanTween.options().setMove());
  }

  public static LTDescr move(GameObject gameObject, Vector3[] to, float time)
  {
    LeanTween.d = LeanTween.options().setMoveCurved();
    if (LeanTween.d.optional.path == null)
      LeanTween.d.optional.path = new LTBezierPath(to);
    else
      LeanTween.d.optional.path.setPoints(to);
    return LeanTween.pushNewTween(gameObject, new Vector3(1f, 0.0f, 0.0f), time, LeanTween.d);
  }

  public static LTDescr move(GameObject gameObject, LTBezierPath to, float time)
  {
    LeanTween.d = LeanTween.options().setMoveCurved();
    LeanTween.d.optional.path = to;
    return LeanTween.pushNewTween(gameObject, new Vector3(1f, 0.0f, 0.0f), time, LeanTween.d);
  }

  public static LTDescr move(GameObject gameObject, LTSpline to, float time)
  {
    LeanTween.d = LeanTween.options().setMoveSpline();
    LeanTween.d.optional.spline = to;
    return LeanTween.pushNewTween(gameObject, new Vector3(1f, 0.0f, 0.0f), time, LeanTween.d);
  }

  public static LTDescr moveSpline(GameObject gameObject, Vector3[] to, float time)
  {
    LeanTween.d = LeanTween.options().setMoveSpline();
    LeanTween.d.optional.spline = new LTSpline(to);
    return LeanTween.pushNewTween(gameObject, new Vector3(1f, 0.0f, 0.0f), time, LeanTween.d);
  }

  public static LTDescr moveSpline(GameObject gameObject, LTSpline to, float time)
  {
    LeanTween.d = LeanTween.options().setMoveSpline();
    LeanTween.d.optional.spline = to;
    return LeanTween.pushNewTween(gameObject, new Vector3(1f, 0.0f, 0.0f), time, LeanTween.d);
  }

  public static LTDescr moveSplineLocal(GameObject gameObject, Vector3[] to, float time)
  {
    LeanTween.d = LeanTween.options().setMoveSplineLocal();
    LeanTween.d.optional.spline = new LTSpline(to);
    return LeanTween.pushNewTween(gameObject, new Vector3(1f, 0.0f, 0.0f), time, LeanTween.d);
  }

  public static LTDescr move(LTRect ltRect, Vector2 to, float time)
  {
    return LeanTween.pushNewTween(LeanTween.tweenEmpty, (Vector3) to, time, LeanTween.options().setGUIMove().setRect(ltRect));
  }

  public static LTDescr moveMargin(LTRect ltRect, Vector2 to, float time)
  {
    return LeanTween.pushNewTween(LeanTween.tweenEmpty, (Vector3) to, time, LeanTween.options().setGUIMoveMargin().setRect(ltRect));
  }

  public static LTDescr moveX(GameObject gameObject, float to, float time)
  {
    return LeanTween.pushNewTween(gameObject, new Vector3(to, 0.0f, 0.0f), time, LeanTween.options().setMoveX());
  }

  public static LTDescr moveY(GameObject gameObject, float to, float time)
  {
    return LeanTween.pushNewTween(gameObject, new Vector3(to, 0.0f, 0.0f), time, LeanTween.options().setMoveY());
  }

  public static LTDescr moveZ(GameObject gameObject, float to, float time)
  {
    return LeanTween.pushNewTween(gameObject, new Vector3(to, 0.0f, 0.0f), time, LeanTween.options().setMoveZ());
  }

  public static LTDescr moveLocal(GameObject gameObject, Vector3 to, float time)
  {
    return LeanTween.pushNewTween(gameObject, to, time, LeanTween.options().setMoveLocal());
  }

  public static LTDescr moveLocal(GameObject gameObject, Vector3[] to, float time)
  {
    LeanTween.d = LeanTween.options().setMoveCurvedLocal();
    if (LeanTween.d.optional.path == null)
      LeanTween.d.optional.path = new LTBezierPath(to);
    else
      LeanTween.d.optional.path.setPoints(to);
    return LeanTween.pushNewTween(gameObject, new Vector3(1f, 0.0f, 0.0f), time, LeanTween.d);
  }

  public static LTDescr moveLocalX(GameObject gameObject, float to, float time)
  {
    return LeanTween.pushNewTween(gameObject, new Vector3(to, 0.0f, 0.0f), time, LeanTween.options().setMoveLocalX());
  }

  public static LTDescr moveLocalY(GameObject gameObject, float to, float time)
  {
    return LeanTween.pushNewTween(gameObject, new Vector3(to, 0.0f, 0.0f), time, LeanTween.options().setMoveLocalY());
  }

  public static LTDescr moveLocalZ(GameObject gameObject, float to, float time)
  {
    return LeanTween.pushNewTween(gameObject, new Vector3(to, 0.0f, 0.0f), time, LeanTween.options().setMoveLocalZ());
  }

  public static LTDescr moveLocal(GameObject gameObject, LTBezierPath to, float time)
  {
    LeanTween.d = LeanTween.options().setMoveCurvedLocal();
    LeanTween.d.optional.path = to;
    return LeanTween.pushNewTween(gameObject, new Vector3(1f, 0.0f, 0.0f), time, LeanTween.d);
  }

  public static LTDescr moveLocal(GameObject gameObject, LTSpline to, float time)
  {
    LeanTween.d = LeanTween.options().setMoveSplineLocal();
    LeanTween.d.optional.spline = to;
    return LeanTween.pushNewTween(gameObject, new Vector3(1f, 0.0f, 0.0f), time, LeanTween.d);
  }

  public static LTDescr move(GameObject gameObject, Transform to, float time)
  {
    return LeanTween.pushNewTween(gameObject, Vector3.zero, time, LeanTween.options().setTo(to).setMoveToTransform());
  }

  public static LTDescr rotate(GameObject gameObject, Vector3 to, float time)
  {
    return LeanTween.pushNewTween(gameObject, to, time, LeanTween.options().setRotate());
  }

  public static LTDescr rotate(LTRect ltRect, float to, float time)
  {
    return LeanTween.pushNewTween(LeanTween.tweenEmpty, new Vector3(to, 0.0f, 0.0f), time, LeanTween.options().setGUIRotate().setRect(ltRect));
  }

  public static LTDescr rotateLocal(GameObject gameObject, Vector3 to, float time)
  {
    return LeanTween.pushNewTween(gameObject, to, time, LeanTween.options().setRotateLocal());
  }

  public static LTDescr rotateX(GameObject gameObject, float to, float time)
  {
    return LeanTween.pushNewTween(gameObject, new Vector3(to, 0.0f, 0.0f), time, LeanTween.options().setRotateX());
  }

  public static LTDescr rotateY(GameObject gameObject, float to, float time)
  {
    return LeanTween.pushNewTween(gameObject, new Vector3(to, 0.0f, 0.0f), time, LeanTween.options().setRotateY());
  }

  public static LTDescr rotateZ(GameObject gameObject, float to, float time)
  {
    return LeanTween.pushNewTween(gameObject, new Vector3(to, 0.0f, 0.0f), time, LeanTween.options().setRotateZ());
  }

  public static LTDescr rotateAround(GameObject gameObject, Vector3 axis, float add, float time)
  {
    return LeanTween.pushNewTween(gameObject, new Vector3(add, 0.0f, 0.0f), time, LeanTween.options().setAxis(axis).setRotateAround());
  }

  public static LTDescr rotateAroundLocal(
    GameObject gameObject,
    Vector3 axis,
    float add,
    float time)
  {
    return LeanTween.pushNewTween(gameObject, new Vector3(add, 0.0f, 0.0f), time, LeanTween.options().setRotateAroundLocal().setAxis(axis));
  }

  public static LTDescr scale(GameObject gameObject, Vector3 to, float time)
  {
    return LeanTween.pushNewTween(gameObject, to, time, LeanTween.options().setScale());
  }

  public static LTDescr scale(LTRect ltRect, Vector2 to, float time)
  {
    return LeanTween.pushNewTween(LeanTween.tweenEmpty, (Vector3) to, time, LeanTween.options().setGUIScale().setRect(ltRect));
  }

  public static LTDescr scaleX(GameObject gameObject, float to, float time)
  {
    return LeanTween.pushNewTween(gameObject, new Vector3(to, 0.0f, 0.0f), time, LeanTween.options().setScaleX());
  }

  public static LTDescr scaleY(GameObject gameObject, float to, float time)
  {
    return LeanTween.pushNewTween(gameObject, new Vector3(to, 0.0f, 0.0f), time, LeanTween.options().setScaleY());
  }

  public static LTDescr scaleZ(GameObject gameObject, float to, float time)
  {
    return LeanTween.pushNewTween(gameObject, new Vector3(to, 0.0f, 0.0f), time, LeanTween.options().setScaleZ());
  }

  public static LTDescr value(GameObject gameObject, float from, float to, float time)
  {
    return LeanTween.pushNewTween(gameObject, new Vector3(to, 0.0f, 0.0f), time, LeanTween.options().setCallback().setFrom(new Vector3(from, 0.0f, 0.0f)));
  }

  public static LTDescr value(float from, float to, float time)
  {
    return LeanTween.pushNewTween(LeanTween.tweenEmpty, new Vector3(to, 0.0f, 0.0f), time, LeanTween.options().setCallback().setFrom(new Vector3(from, 0.0f, 0.0f)));
  }

  public static LTDescr value(GameObject gameObject, Vector2 from, Vector2 to, float time)
  {
    return LeanTween.pushNewTween(gameObject, new Vector3(to.x, to.y, 0.0f), time, LeanTween.options().setValue3().setTo(new Vector3(to.x, to.y, 0.0f)).setFrom(new Vector3(from.x, from.y, 0.0f)));
  }

  public static LTDescr value(GameObject gameObject, Vector3 from, Vector3 to, float time)
  {
    return LeanTween.pushNewTween(gameObject, to, time, LeanTween.options().setValue3().setFrom(from));
  }

  public static LTDescr value(GameObject gameObject, Color from, Color to, float time)
  {
    LTDescr ltDescr = LeanTween.pushNewTween(gameObject, new Vector3(1f, to.a, 0.0f), time, LeanTween.options().setCallbackColor().setPoint(new Vector3(to.r, to.g, to.b)).setFromColor(from).setHasInitialized(false));
    ltDescr.spriteRen = gameObject.GetComponent<SpriteRenderer>();
    return ltDescr;
  }

  public static LTDescr value(
    GameObject gameObject,
    Action<float> callOnUpdate,
    float from,
    float to,
    float time)
  {
    return LeanTween.pushNewTween(gameObject, new Vector3(to, 0.0f, 0.0f), time, LeanTween.options().setCallback().setTo(new Vector3(to, 0.0f, 0.0f)).setFrom(new Vector3(from, 0.0f, 0.0f)).setOnUpdate(callOnUpdate));
  }

  public static LTDescr value(
    GameObject gameObject,
    Action<float, float> callOnUpdateRatio,
    float from,
    float to,
    float time)
  {
    return LeanTween.pushNewTween(gameObject, new Vector3(to, 0.0f, 0.0f), time, LeanTween.options().setCallback().setTo(new Vector3(to, 0.0f, 0.0f)).setFrom(new Vector3(from, 0.0f, 0.0f)).setOnUpdateRatio(callOnUpdateRatio));
  }

  public static LTDescr value(
    GameObject gameObject,
    Action<Color> callOnUpdate,
    Color from,
    Color to,
    float time)
  {
    return LeanTween.pushNewTween(gameObject, new Vector3(1f, to.a, 0.0f), time, LeanTween.options().setCallbackColor().setPoint(new Vector3(to.r, to.g, to.b)).setAxis(new Vector3(from.r, from.g, from.b)).setFrom(new Vector3(0.0f, from.a, 0.0f)).setHasInitialized(false).setOnUpdateColor(callOnUpdate));
  }

  public static LTDescr value(
    GameObject gameObject,
    Action<Color, object> callOnUpdate,
    Color from,
    Color to,
    float time)
  {
    return LeanTween.pushNewTween(gameObject, new Vector3(1f, to.a, 0.0f), time, LeanTween.options().setCallbackColor().setPoint(new Vector3(to.r, to.g, to.b)).setAxis(new Vector3(from.r, from.g, from.b)).setFrom(new Vector3(0.0f, from.a, 0.0f)).setHasInitialized(false).setOnUpdateColor(callOnUpdate));
  }

  public static LTDescr value(
    GameObject gameObject,
    Action<Vector2> callOnUpdate,
    Vector2 from,
    Vector2 to,
    float time)
  {
    return LeanTween.pushNewTween(gameObject, new Vector3(to.x, to.y, 0.0f), time, LeanTween.options().setValue3().setTo(new Vector3(to.x, to.y, 0.0f)).setFrom(new Vector3(from.x, from.y, 0.0f)).setOnUpdateVector2(callOnUpdate));
  }

  public static LTDescr value(
    GameObject gameObject,
    Action<Vector3> callOnUpdate,
    Vector3 from,
    Vector3 to,
    float time)
  {
    return LeanTween.pushNewTween(gameObject, to, time, LeanTween.options().setValue3().setTo(to).setFrom(from).setOnUpdateVector3(callOnUpdate));
  }

  public static LTDescr value(
    GameObject gameObject,
    Action<float, object> callOnUpdate,
    float from,
    float to,
    float time)
  {
    return LeanTween.pushNewTween(gameObject, new Vector3(to, 0.0f, 0.0f), time, LeanTween.options().setCallback().setTo(new Vector3(to, 0.0f, 0.0f)).setFrom(new Vector3(from, 0.0f, 0.0f)).setOnUpdate(callOnUpdate, (object) gameObject));
  }

  public static LTDescr delayedSound(AudioClip audio, Vector3 pos, float volume)
  {
    return LeanTween.pushNewTween(LeanTween.tweenEmpty, pos, 0.0f, LeanTween.options().setDelayedSound().setTo(pos).setFrom(new Vector3(volume, 0.0f, 0.0f)).setAudio((object) audio));
  }

  public static LTDescr delayedSound(
    GameObject gameObject,
    AudioClip audio,
    Vector3 pos,
    float volume)
  {
    return LeanTween.pushNewTween(gameObject, pos, 0.0f, LeanTween.options().setDelayedSound().setTo(pos).setFrom(new Vector3(volume, 0.0f, 0.0f)).setAudio((object) audio));
  }

  public static LTDescr move(RectTransform rectTrans, Vector3 to, float time)
  {
    return LeanTween.pushNewTween(rectTrans.gameObject, to, time, LeanTween.options().setCanvasMove().setRect(rectTrans));
  }

  public static LTDescr moveX(RectTransform rectTrans, float to, float time)
  {
    return LeanTween.pushNewTween(rectTrans.gameObject, new Vector3(to, 0.0f, 0.0f), time, LeanTween.options().setCanvasMoveX().setRect(rectTrans));
  }

  public static LTDescr moveY(RectTransform rectTrans, float to, float time)
  {
    return LeanTween.pushNewTween(rectTrans.gameObject, new Vector3(to, 0.0f, 0.0f), time, LeanTween.options().setCanvasMoveY().setRect(rectTrans));
  }

  public static LTDescr moveZ(RectTransform rectTrans, float to, float time)
  {
    return LeanTween.pushNewTween(rectTrans.gameObject, new Vector3(to, 0.0f, 0.0f), time, LeanTween.options().setCanvasMoveZ().setRect(rectTrans));
  }

  public static LTDescr rotate(RectTransform rectTrans, float to, float time)
  {
    return LeanTween.pushNewTween(rectTrans.gameObject, new Vector3(to, 0.0f, 0.0f), time, LeanTween.options().setCanvasRotateAround().setRect(rectTrans).setAxis(Vector3.forward));
  }

  public static LTDescr rotate(RectTransform rectTrans, Vector3 to, float time)
  {
    return LeanTween.pushNewTween(rectTrans.gameObject, to, time, LeanTween.options().setCanvasRotateAround().setRect(rectTrans).setAxis(Vector3.forward));
  }

  public static LTDescr rotateAround(RectTransform rectTrans, Vector3 axis, float to, float time)
  {
    return LeanTween.pushNewTween(rectTrans.gameObject, new Vector3(to, 0.0f, 0.0f), time, LeanTween.options().setCanvasRotateAround().setRect(rectTrans).setAxis(axis));
  }

  public static LTDescr rotateAroundLocal(
    RectTransform rectTrans,
    Vector3 axis,
    float to,
    float time)
  {
    return LeanTween.pushNewTween(rectTrans.gameObject, new Vector3(to, 0.0f, 0.0f), time, LeanTween.options().setCanvasRotateAroundLocal().setRect(rectTrans).setAxis(axis));
  }

  public static LTDescr scale(RectTransform rectTrans, Vector3 to, float time)
  {
    return LeanTween.pushNewTween(rectTrans.gameObject, to, time, LeanTween.options().setCanvasScale().setRect(rectTrans));
  }

  public static LTDescr size(RectTransform rectTrans, Vector2 to, float time)
  {
    return LeanTween.pushNewTween(rectTrans.gameObject, (Vector3) to, time, LeanTween.options().setCanvasSizeDelta().setRect(rectTrans));
  }

  public static LTDescr alpha(RectTransform rectTrans, float to, float time)
  {
    return LeanTween.pushNewTween(rectTrans.gameObject, new Vector3(to, 0.0f, 0.0f), time, LeanTween.options().setCanvasAlpha().setRect(rectTrans));
  }

  public static LTDescr color(RectTransform rectTrans, Color to, float time)
  {
    return LeanTween.pushNewTween(rectTrans.gameObject, new Vector3(1f, to.a, 0.0f), time, LeanTween.options().setCanvasColor().setRect(rectTrans).setPoint(new Vector3(to.r, to.g, to.b)));
  }

  public static float tweenOnCurve(LTDescr tweenDescr, float ratioPassed)
  {
    return tweenDescr.from.x + tweenDescr.diff.x * tweenDescr.optional.animationCurve.Evaluate(ratioPassed);
  }

  public static Vector3 tweenOnCurveVector(LTDescr tweenDescr, float ratioPassed)
  {
    return new Vector3(tweenDescr.from.x + tweenDescr.diff.x * tweenDescr.optional.animationCurve.Evaluate(ratioPassed), tweenDescr.from.y + tweenDescr.diff.y * tweenDescr.optional.animationCurve.Evaluate(ratioPassed), tweenDescr.from.z + tweenDescr.diff.z * tweenDescr.optional.animationCurve.Evaluate(ratioPassed));
  }

  public static float easeOutQuadOpt(float start, float diff, float ratioPassed)
  {
    return (float) (-(double) diff * (double) ratioPassed * ((double) ratioPassed - 2.0)) + start;
  }

  public static float easeInQuadOpt(float start, float diff, float ratioPassed)
  {
    return diff * ratioPassed * ratioPassed + start;
  }

  public static float easeInOutQuadOpt(float start, float diff, float ratioPassed)
  {
    ratioPassed /= 0.5f;
    if ((double) ratioPassed < 1.0)
      return diff / 2f * ratioPassed * ratioPassed + start;
    --ratioPassed;
    return (float) (-(double) diff / 2.0 * ((double) ratioPassed * ((double) ratioPassed - 2.0) - 1.0)) + start;
  }

  public static Vector3 easeInOutQuadOpt(Vector3 start, Vector3 diff, float ratioPassed)
  {
    ratioPassed /= 0.5f;
    if ((double) ratioPassed < 1.0)
      return diff / 2f * ratioPassed * ratioPassed + start;
    --ratioPassed;
    return -diff / 2f * (float) ((double) ratioPassed * ((double) ratioPassed - 2.0) - 1.0) + start;
  }

  public static float linear(float start, float end, float val) => Mathf.Lerp(start, end, val);

  public static float clerp(float start, float end, float val)
  {
    float num1 = 0.0f;
    float num2 = 360f;
    float num3 = Mathf.Abs((float) (((double) num2 - (double) num1) / 2.0));
    float num4;
    if ((double) end - (double) start < -(double) num3)
    {
      float num5 = (num2 - start + end) * val;
      num4 = start + num5;
    }
    else if ((double) end - (double) start > (double) num3)
    {
      float num6 = (float) -((double) num2 - (double) end + (double) start) * val;
      num4 = start + num6;
    }
    else
      num4 = start + (end - start) * val;
    return num4;
  }

  public static float spring(float start, float end, float val)
  {
    val = Mathf.Clamp01(val);
    val = (float) (((double) Mathf.Sin((float) ((double) val * 3.1415927410125732 * (0.20000000298023224 + 2.5 * (double) val * (double) val * (double) val))) * (double) Mathf.Pow(1f - val, 2.2f) + (double) val) * (1.0 + 1.2000000476837158 * (1.0 - (double) val)));
    return start + (end - start) * val;
  }

  public static float easeInQuad(float start, float end, float val)
  {
    end -= start;
    return end * val * val + start;
  }

  public static float easeOutQuad(float start, float end, float val)
  {
    end -= start;
    return (float) (-(double) end * (double) val * ((double) val - 2.0)) + start;
  }

  public static float easeInOutQuad(float start, float end, float val)
  {
    val /= 0.5f;
    end -= start;
    if ((double) val < 1.0)
      return end / 2f * val * val + start;
    --val;
    return (float) (-(double) end / 2.0 * ((double) val * ((double) val - 2.0) - 1.0)) + start;
  }

  public static float easeInOutQuadOpt2(float start, float diffBy2, float val, float val2)
  {
    val /= 0.5f;
    if ((double) val < 1.0)
      return diffBy2 * val2 + start;
    --val;
    return (float) (-(double) diffBy2 * ((double) val2 - 2.0 - 1.0)) + start;
  }

  public static float easeInCubic(float start, float end, float val)
  {
    end -= start;
    return end * val * val * val + start;
  }

  public static float easeOutCubic(float start, float end, float val)
  {
    --val;
    end -= start;
    return end * (float) ((double) val * (double) val * (double) val + 1.0) + start;
  }

  public static float easeInOutCubic(float start, float end, float val)
  {
    val /= 0.5f;
    end -= start;
    if ((double) val < 1.0)
      return end / 2f * val * val * val + start;
    val -= 2f;
    return (float) ((double) end / 2.0 * ((double) val * (double) val * (double) val + 2.0)) + start;
  }

  public static float easeInQuart(float start, float end, float val)
  {
    end -= start;
    return end * val * val * val * val + start;
  }

  public static float easeOutQuart(float start, float end, float val)
  {
    --val;
    end -= start;
    return (float) (-(double) end * ((double) val * (double) val * (double) val * (double) val - 1.0)) + start;
  }

  public static float easeInOutQuart(float start, float end, float val)
  {
    val /= 0.5f;
    end -= start;
    if ((double) val < 1.0)
      return end / 2f * val * val * val * val + start;
    val -= 2f;
    return (float) (-(double) end / 2.0 * ((double) val * (double) val * (double) val * (double) val - 2.0)) + start;
  }

  public static float easeInQuint(float start, float end, float val)
  {
    end -= start;
    return end * val * val * val * val * val + start;
  }

  public static float easeOutQuint(float start, float end, float val)
  {
    --val;
    end -= start;
    return end * (float) ((double) val * (double) val * (double) val * (double) val * (double) val + 1.0) + start;
  }

  public static float easeInOutQuint(float start, float end, float val)
  {
    val /= 0.5f;
    end -= start;
    if ((double) val < 1.0)
      return end / 2f * val * val * val * val * val + start;
    val -= 2f;
    return (float) ((double) end / 2.0 * ((double) val * (double) val * (double) val * (double) val * (double) val + 2.0)) + start;
  }

  public static float easeInSine(float start, float end, float val)
  {
    end -= start;
    return -end * Mathf.Cos((float) ((double) val / 1.0 * 1.5707963705062866)) + end + start;
  }

  public static float easeOutSine(float start, float end, float val)
  {
    end -= start;
    return end * Mathf.Sin((float) ((double) val / 1.0 * 1.5707963705062866)) + start;
  }

  public static float easeInOutSine(float start, float end, float val)
  {
    end -= start;
    return (float) (-(double) end / 2.0 * ((double) Mathf.Cos((float) (3.1415927410125732 * (double) val / 1.0)) - 1.0)) + start;
  }

  public static float easeInExpo(float start, float end, float val)
  {
    end -= start;
    return end * Mathf.Pow(2f, (float) (10.0 * ((double) val / 1.0 - 1.0))) + start;
  }

  public static float easeOutExpo(float start, float end, float val)
  {
    end -= start;
    return end * (float) (-(double) Mathf.Pow(2f, (float) (-10.0 * (double) val / 1.0)) + 1.0) + start;
  }

  public static float easeInOutExpo(float start, float end, float val)
  {
    val /= 0.5f;
    end -= start;
    if ((double) val < 1.0)
      return end / 2f * Mathf.Pow(2f, (float) (10.0 * ((double) val - 1.0))) + start;
    --val;
    return (float) ((double) end / 2.0 * (-(double) Mathf.Pow(2f, -10f * val) + 2.0)) + start;
  }

  public static float easeInCirc(float start, float end, float val)
  {
    end -= start;
    return (float) (-(double) end * ((double) Mathf.Sqrt((float) (1.0 - (double) val * (double) val)) - 1.0)) + start;
  }

  public static float easeOutCirc(float start, float end, float val)
  {
    --val;
    end -= start;
    return end * Mathf.Sqrt((float) (1.0 - (double) val * (double) val)) + start;
  }

  public static float easeInOutCirc(float start, float end, float val)
  {
    val /= 0.5f;
    end -= start;
    if ((double) val < 1.0)
      return (float) (-(double) end / 2.0 * ((double) Mathf.Sqrt((float) (1.0 - (double) val * (double) val)) - 1.0)) + start;
    val -= 2f;
    return (float) ((double) end / 2.0 * ((double) Mathf.Sqrt((float) (1.0 - (double) val * (double) val)) + 1.0)) + start;
  }

  public static float easeInBounce(float start, float end, float val)
  {
    end -= start;
    float num = 1f;
    return end - LeanTween.easeOutBounce(0.0f, end, num - val) + start;
  }

  public static float easeOutBounce(float start, float end, float val)
  {
    val /= 1f;
    end -= start;
    if ((double) val < 0.36363637447357178)
      return end * (121f / 16f * val * val) + start;
    if ((double) val < 0.72727274894714355)
    {
      val -= 0.545454562f;
      return end * (float) (121.0 / 16.0 * (double) val * (double) val + 0.75) + start;
    }
    if ((double) val < 10.0 / 11.0)
    {
      val -= 0.8181818f;
      return end * (float) (121.0 / 16.0 * (double) val * (double) val + 15.0 / 16.0) + start;
    }
    val -= 0.954545438f;
    return end * (float) (121.0 / 16.0 * (double) val * (double) val + 63.0 / 64.0) + start;
  }

  public static float easeInOutBounce(float start, float end, float val)
  {
    end -= start;
    float num = 1f;
    return (double) val < (double) num / 2.0 ? LeanTween.easeInBounce(0.0f, end, val * 2f) * 0.5f + start : (float) ((double) LeanTween.easeOutBounce(0.0f, end, val * 2f - num) * 0.5 + (double) end * 0.5) + start;
  }

  public static float easeInBack(float start, float end, float val, float overshoot = 1f)
  {
    end -= start;
    val /= 1f;
    float num = 1.70158f * overshoot;
    return (float) ((double) end * (double) val * (double) val * (((double) num + 1.0) * (double) val - (double) num)) + start;
  }

  public static float easeOutBack(float start, float end, float val, float overshoot = 1f)
  {
    float num = 1.70158f * overshoot;
    end -= start;
    val = (float) ((double) val / 1.0 - 1.0);
    return end * (float) ((double) val * (double) val * (((double) num + 1.0) * (double) val + (double) num) + 1.0) + start;
  }

  public static float easeInOutBack(float start, float end, float val, float overshoot = 1f)
  {
    float num1 = 1.70158f * overshoot;
    end -= start;
    val /= 0.5f;
    if ((double) val < 1.0)
    {
      float num2 = num1 * (1.525f * overshoot);
      return (float) ((double) end / 2.0 * ((double) val * (double) val * (((double) num2 + 1.0) * (double) val - (double) num2))) + start;
    }
    val -= 2f;
    float num3 = num1 * (1.525f * overshoot);
    return (float) ((double) end / 2.0 * ((double) val * (double) val * (((double) num3 + 1.0) * (double) val + (double) num3) + 2.0)) + start;
  }

  public static float easeInElastic(
    float start,
    float end,
    float val,
    float overshoot = 1f,
    float period = 0.3f)
  {
    end -= start;
    float num1 = period;
    float num2 = 0.0f;
    if ((double) val == 0.0)
      return start;
    if ((double) val == 1.0)
      return start + end;
    float num3;
    if ((double) num2 == 0.0 || (double) num2 < (double) Mathf.Abs(end))
    {
      num2 = end;
      num3 = num1 / 4f;
    }
    else
      num3 = num1 / 6.28318548f * Mathf.Asin(end / num2);
    if ((double) overshoot > 1.0 && (double) val > 0.60000002384185791)
      overshoot = (float) (1.0 + (1.0 - (double) val) / 0.40000000596046448 * ((double) overshoot - 1.0));
    --val;
    return start - num2 * Mathf.Pow(2f, 10f * val) * Mathf.Sin((float) (((double) val - (double) num3) * 6.2831854820251465) / num1) * overshoot;
  }

  public static float easeOutElastic(
    float start,
    float end,
    float val,
    float overshoot = 1f,
    float period = 0.3f)
  {
    end -= start;
    float num1 = period;
    float num2 = 0.0f;
    if ((double) val == 0.0)
      return start;
    if ((double) val == 1.0)
      return start + end;
    float num3;
    if ((double) num2 == 0.0 || (double) num2 < (double) Mathf.Abs(end))
    {
      num2 = end;
      num3 = num1 / 4f;
    }
    else
      num3 = num1 / 6.28318548f * Mathf.Asin(end / num2);
    if ((double) overshoot > 1.0 && (double) val < 0.40000000596046448)
      overshoot = (float) (1.0 + (double) val / 0.40000000596046448 * ((double) overshoot - 1.0));
    return (float) ((double) start + (double) end + (double) num2 * (double) Mathf.Pow(2f, -10f * val) * (double) Mathf.Sin((float) (((double) val - (double) num3) * 6.2831854820251465) / num1) * (double) overshoot);
  }

  public static float easeInOutElastic(
    float start,
    float end,
    float val,
    float overshoot = 1f,
    float period = 0.3f)
  {
    end -= start;
    float num1 = period;
    float num2 = 0.0f;
    if ((double) val == 0.0)
      return start;
    val /= 0.5f;
    if ((double) val == 2.0)
      return start + end;
    float num3;
    if ((double) num2 == 0.0 || (double) num2 < (double) Mathf.Abs(end))
    {
      num2 = end;
      num3 = num1 / 4f;
    }
    else
      num3 = num1 / 6.28318548f * Mathf.Asin(end / num2);
    if ((double) overshoot > 1.0)
    {
      if ((double) val < 0.20000000298023224)
        overshoot = (float) (1.0 + (double) val / 0.20000000298023224 * ((double) overshoot - 1.0));
      else if ((double) val > 0.800000011920929)
        overshoot = (float) (1.0 + (1.0 - (double) val) / 0.20000000298023224 * ((double) overshoot - 1.0));
    }
    if ((double) val < 1.0)
    {
      --val;
      return start - (float) (0.5 * ((double) num2 * (double) Mathf.Pow(2f, 10f * val) * (double) Mathf.Sin((float) (((double) val - (double) num3) * 6.2831854820251465) / num1))) * overshoot;
    }
    --val;
    return (float) ((double) end + (double) start + (double) num2 * (double) Mathf.Pow(2f, -10f * val) * (double) Mathf.Sin((float) (((double) val - (double) num3) * 6.2831854820251465) / num1) * 0.5 * (double) overshoot);
  }

  public static LTDescr followDamp(
    Transform trans,
    Transform target,
    LeanProp prop,
    float smoothTime,
    float maxSpeed = -1f)
  {
    LTDescr d = LeanTween.pushNewTween(trans.gameObject, Vector3.zero, float.MaxValue, LeanTween.options().setFollow().setTarget(target));
    switch (prop)
    {
      case LeanProp.position:
        d.diff = d.trans.position;
        d.easeInternal = (LTDescr.ActionMethodDelegate) (() =>
        {
          d.optional.axis = LeanSmooth.damp(d.optional.axis, d.toTrans.position, ref d.fromInternal, smoothTime, maxSpeed, Time.deltaTime);
          d.trans.position = d.optional.axis + d.toInternal;
        });
        break;
      case LeanProp.localPosition:
        d.optional.axis = d.trans.localPosition;
        d.easeInternal = (LTDescr.ActionMethodDelegate) (() =>
        {
          d.optional.axis = LeanSmooth.damp(d.optional.axis, d.toTrans.localPosition, ref d.fromInternal, smoothTime, maxSpeed, Time.deltaTime);
          d.trans.localPosition = d.optional.axis + d.toInternal;
        });
        break;
      case LeanProp.x:
        d.easeInternal = (LTDescr.ActionMethodDelegate) (() => d.trans.LeanSetPosX(LeanSmooth.damp(d.trans.position.x, d.toTrans.position.x, ref d.fromInternal.x, smoothTime, maxSpeed, Time.deltaTime)));
        break;
      case LeanProp.y:
        d.easeInternal = (LTDescr.ActionMethodDelegate) (() => d.trans.LeanSetPosY(LeanSmooth.damp(d.trans.position.y, d.toTrans.position.y, ref d.fromInternal.y, smoothTime, maxSpeed, Time.deltaTime)));
        break;
      case LeanProp.z:
        d.easeInternal = (LTDescr.ActionMethodDelegate) (() => d.trans.LeanSetPosZ(LeanSmooth.damp(d.trans.position.z, d.toTrans.position.z, ref d.fromInternal.z, smoothTime, maxSpeed, Time.deltaTime)));
        break;
      case LeanProp.localX:
        d.easeInternal = (LTDescr.ActionMethodDelegate) (() => d.trans.LeanSetLocalPosX(LeanSmooth.damp(d.trans.localPosition.x, d.toTrans.localPosition.x, ref d.fromInternal.x, smoothTime, maxSpeed, Time.deltaTime)));
        break;
      case LeanProp.localY:
        d.easeInternal = (LTDescr.ActionMethodDelegate) (() => d.trans.LeanSetLocalPosY(LeanSmooth.damp(d.trans.localPosition.y, d.toTrans.localPosition.y, ref d.fromInternal.y, smoothTime, maxSpeed, Time.deltaTime)));
        break;
      case LeanProp.localZ:
        d.easeInternal = (LTDescr.ActionMethodDelegate) (() => d.trans.LeanSetLocalPosZ(LeanSmooth.damp(d.trans.localPosition.z, d.toTrans.localPosition.z, ref d.fromInternal.z, smoothTime, maxSpeed, Time.deltaTime)));
        break;
      case LeanProp.scale:
        d.easeInternal = (LTDescr.ActionMethodDelegate) (() => d.trans.localScale = LeanSmooth.damp(d.trans.localScale, d.toTrans.localScale, ref d.fromInternal, smoothTime, maxSpeed, Time.deltaTime));
        break;
      case LeanProp.color:
        d.easeInternal = (LTDescr.ActionMethodDelegate) (() =>
        {
          Color color = LeanSmooth.damp(d.trans.LeanColor(), d.toTrans.LeanColor(), ref d.optional.color, smoothTime, maxSpeed, Time.deltaTime);
          d.trans.GetComponent<Renderer>().material.color = color;
        });
        break;
    }
    return d;
  }

  public static LTDescr followSpring(
    Transform trans,
    Transform target,
    LeanProp prop,
    float smoothTime,
    float maxSpeed = -1f,
    float friction = 2f,
    float accelRate = 0.5f)
  {
    LTDescr d = LeanTween.pushNewTween(trans.gameObject, Vector3.zero, float.MaxValue, LeanTween.options().setFollow().setTarget(target));
    switch (prop)
    {
      case LeanProp.position:
        d.diff = d.trans.position;
        d.easeInternal = (LTDescr.ActionMethodDelegate) (() =>
        {
          d.diff = LeanSmooth.spring(d.diff, d.toTrans.position, ref d.fromInternal, smoothTime, maxSpeed, Time.deltaTime, friction, accelRate);
          d.trans.position = d.diff;
        });
        break;
      case LeanProp.localPosition:
        d.optional.axis = d.trans.localPosition;
        d.easeInternal = (LTDescr.ActionMethodDelegate) (() =>
        {
          d.optional.axis = LeanSmooth.spring(d.optional.axis, d.toTrans.localPosition, ref d.fromInternal, smoothTime, maxSpeed, Time.deltaTime, friction, accelRate);
          d.trans.localPosition = d.optional.axis + d.toInternal;
        });
        break;
      case LeanProp.x:
        d.easeInternal = (LTDescr.ActionMethodDelegate) (() => d.trans.LeanSetPosX(LeanSmooth.spring(d.trans.position.x, d.toTrans.position.x, ref d.fromInternal.x, smoothTime, maxSpeed, Time.deltaTime, friction, accelRate)));
        break;
      case LeanProp.y:
        d.easeInternal = (LTDescr.ActionMethodDelegate) (() => d.trans.LeanSetPosY(LeanSmooth.spring(d.trans.position.y, d.toTrans.position.y, ref d.fromInternal.y, smoothTime, maxSpeed, Time.deltaTime, friction, accelRate)));
        break;
      case LeanProp.z:
        d.easeInternal = (LTDescr.ActionMethodDelegate) (() => d.trans.LeanSetPosZ(LeanSmooth.spring(d.trans.position.z, d.toTrans.position.z, ref d.fromInternal.z, smoothTime, maxSpeed, Time.deltaTime, friction, accelRate)));
        break;
      case LeanProp.localX:
        d.easeInternal = (LTDescr.ActionMethodDelegate) (() => d.trans.LeanSetLocalPosX(LeanSmooth.spring(d.trans.localPosition.x, d.toTrans.localPosition.x, ref d.fromInternal.x, smoothTime, maxSpeed, Time.deltaTime, friction, accelRate)));
        break;
      case LeanProp.localY:
        d.easeInternal = (LTDescr.ActionMethodDelegate) (() => d.trans.LeanSetLocalPosY(LeanSmooth.spring(d.trans.localPosition.y, d.toTrans.localPosition.y, ref d.fromInternal.y, smoothTime, maxSpeed, Time.deltaTime, friction, accelRate)));
        break;
      case LeanProp.localZ:
        d.easeInternal = (LTDescr.ActionMethodDelegate) (() => d.trans.LeanSetLocalPosZ(LeanSmooth.spring(d.trans.localPosition.z, d.toTrans.localPosition.z, ref d.fromInternal.z, smoothTime, maxSpeed, Time.deltaTime, friction, accelRate)));
        break;
      case LeanProp.scale:
        d.easeInternal = (LTDescr.ActionMethodDelegate) (() => d.trans.localScale = LeanSmooth.spring(d.trans.localScale, d.toTrans.localScale, ref d.fromInternal, smoothTime, maxSpeed, Time.deltaTime, friction, accelRate));
        break;
      case LeanProp.color:
        d.easeInternal = (LTDescr.ActionMethodDelegate) (() =>
        {
          Color color = LeanSmooth.spring(d.trans.LeanColor(), d.toTrans.LeanColor(), ref d.optional.color, smoothTime, maxSpeed, Time.deltaTime, friction, accelRate);
          d.trans.GetComponent<Renderer>().material.color = color;
        });
        break;
    }
    return d;
  }

  public static LTDescr followBounceOut(
    Transform trans,
    Transform target,
    LeanProp prop,
    float smoothTime,
    float maxSpeed = -1f,
    float friction = 2f,
    float accelRate = 0.5f,
    float hitDamping = 0.9f)
  {
    LTDescr d = LeanTween.pushNewTween(trans.gameObject, Vector3.zero, float.MaxValue, LeanTween.options().setFollow().setTarget(target));
    switch (prop)
    {
      case LeanProp.position:
        d.easeInternal = (LTDescr.ActionMethodDelegate) (() =>
        {
          d.optional.axis = LeanSmooth.bounceOut(d.optional.axis, d.toTrans.position, ref d.fromInternal, smoothTime, maxSpeed, Time.deltaTime, friction, accelRate, hitDamping);
          d.trans.position = d.optional.axis + d.toInternal;
        });
        break;
      case LeanProp.localPosition:
        d.optional.axis = d.trans.localPosition;
        d.easeInternal = (LTDescr.ActionMethodDelegate) (() =>
        {
          d.optional.axis = LeanSmooth.bounceOut(d.optional.axis, d.toTrans.localPosition, ref d.fromInternal, smoothTime, maxSpeed, Time.deltaTime, friction, accelRate, hitDamping);
          d.trans.localPosition = d.optional.axis + d.toInternal;
        });
        break;
      case LeanProp.x:
        d.easeInternal = (LTDescr.ActionMethodDelegate) (() => d.trans.LeanSetPosX(LeanSmooth.bounceOut(d.trans.position.x, d.toTrans.position.x, ref d.fromInternal.x, smoothTime, maxSpeed, Time.deltaTime, friction, accelRate, hitDamping)));
        break;
      case LeanProp.y:
        d.easeInternal = (LTDescr.ActionMethodDelegate) (() => d.trans.LeanSetPosY(LeanSmooth.bounceOut(d.trans.position.y, d.toTrans.position.y, ref d.fromInternal.y, smoothTime, maxSpeed, Time.deltaTime, friction, accelRate, hitDamping)));
        break;
      case LeanProp.z:
        d.easeInternal = (LTDescr.ActionMethodDelegate) (() => d.trans.LeanSetPosZ(LeanSmooth.bounceOut(d.trans.position.z, d.toTrans.position.z, ref d.fromInternal.z, smoothTime, maxSpeed, Time.deltaTime, friction, accelRate, hitDamping)));
        break;
      case LeanProp.localX:
        d.easeInternal = (LTDescr.ActionMethodDelegate) (() => d.trans.LeanSetLocalPosX(LeanSmooth.bounceOut(d.trans.localPosition.x, d.toTrans.localPosition.x, ref d.fromInternal.x, smoothTime, maxSpeed, Time.deltaTime, friction, accelRate, hitDamping)));
        break;
      case LeanProp.localY:
        d.easeInternal = (LTDescr.ActionMethodDelegate) (() => d.trans.LeanSetLocalPosY(LeanSmooth.bounceOut(d.trans.localPosition.y, d.toTrans.localPosition.y, ref d.fromInternal.y, smoothTime, maxSpeed, Time.deltaTime, friction, accelRate, hitDamping)));
        break;
      case LeanProp.localZ:
        d.easeInternal = (LTDescr.ActionMethodDelegate) (() => d.trans.LeanSetLocalPosZ(LeanSmooth.bounceOut(d.trans.localPosition.z, d.toTrans.localPosition.z, ref d.fromInternal.z, smoothTime, maxSpeed, Time.deltaTime, friction, accelRate, hitDamping)));
        break;
      case LeanProp.scale:
        d.easeInternal = (LTDescr.ActionMethodDelegate) (() => d.trans.localScale = LeanSmooth.bounceOut(d.trans.localScale, d.toTrans.localScale, ref d.fromInternal, smoothTime, maxSpeed, Time.deltaTime, friction, accelRate, hitDamping));
        break;
      case LeanProp.color:
        d.easeInternal = (LTDescr.ActionMethodDelegate) (() =>
        {
          Color color = LeanSmooth.bounceOut(d.trans.LeanColor(), d.toTrans.LeanColor(), ref d.optional.color, smoothTime, maxSpeed, Time.deltaTime, friction, accelRate, hitDamping);
          d.trans.GetComponent<Renderer>().material.color = color;
        });
        break;
    }
    return d;
  }

  public static LTDescr followLinear(
    Transform trans,
    Transform target,
    LeanProp prop,
    float moveSpeed)
  {
    LTDescr d = LeanTween.pushNewTween(trans.gameObject, Vector3.zero, float.MaxValue, LeanTween.options().setFollow().setTarget(target));
    switch (prop)
    {
      case LeanProp.position:
        d.easeInternal = (LTDescr.ActionMethodDelegate) (() => d.trans.position = LeanSmooth.linear(d.trans.position, d.toTrans.position, moveSpeed));
        break;
      case LeanProp.localPosition:
        d.optional.axis = d.trans.localPosition;
        d.easeInternal = (LTDescr.ActionMethodDelegate) (() =>
        {
          d.optional.axis = LeanSmooth.linear(d.optional.axis, d.toTrans.localPosition, moveSpeed);
          d.trans.localPosition = d.optional.axis + d.toInternal;
        });
        break;
      case LeanProp.x:
        d.easeInternal = (LTDescr.ActionMethodDelegate) (() => d.trans.LeanSetPosX(LeanSmooth.linear(d.trans.position.x, d.toTrans.position.x, moveSpeed)));
        break;
      case LeanProp.y:
        d.easeInternal = (LTDescr.ActionMethodDelegate) (() => d.trans.LeanSetPosY(LeanSmooth.linear(d.trans.position.y, d.toTrans.position.y, moveSpeed)));
        break;
      case LeanProp.z:
        d.easeInternal = (LTDescr.ActionMethodDelegate) (() => d.trans.LeanSetPosZ(LeanSmooth.linear(d.trans.position.z, d.toTrans.position.z, moveSpeed)));
        break;
      case LeanProp.localX:
        d.easeInternal = (LTDescr.ActionMethodDelegate) (() => d.trans.LeanSetLocalPosX(LeanSmooth.linear(d.trans.localPosition.x, d.toTrans.localPosition.x, moveSpeed)));
        break;
      case LeanProp.localY:
        d.easeInternal = (LTDescr.ActionMethodDelegate) (() => d.trans.LeanSetLocalPosY(LeanSmooth.linear(d.trans.localPosition.y, d.toTrans.localPosition.y, moveSpeed)));
        break;
      case LeanProp.localZ:
        d.easeInternal = (LTDescr.ActionMethodDelegate) (() => d.trans.LeanSetLocalPosZ(LeanSmooth.linear(d.trans.localPosition.z, d.toTrans.localPosition.z, moveSpeed)));
        break;
      case LeanProp.scale:
        d.easeInternal = (LTDescr.ActionMethodDelegate) (() => d.trans.localScale = LeanSmooth.linear(d.trans.localScale, d.toTrans.localScale, moveSpeed));
        break;
      case LeanProp.color:
        d.easeInternal = (LTDescr.ActionMethodDelegate) (() =>
        {
          Color color = LeanSmooth.linear(d.trans.LeanColor(), d.toTrans.LeanColor(), moveSpeed);
          d.trans.GetComponent<Renderer>().material.color = color;
        });
        break;
    }
    return d;
  }

  public static void addListener(int eventId, Action<LTEvent> callback)
  {
    LeanTween.addListener(LeanTween.tweenEmpty, eventId, callback);
  }

  public static void addListener(GameObject caller, int eventId, Action<LTEvent> callback)
  {
    if (LeanTween.eventListeners == null)
    {
      LeanTween.INIT_LISTENERS_MAX = LeanTween.LISTENERS_MAX;
      LeanTween.eventListeners = new Action<LTEvent>[LeanTween.EVENTS_MAX * LeanTween.LISTENERS_MAX];
      LeanTween.goListeners = new GameObject[LeanTween.EVENTS_MAX * LeanTween.LISTENERS_MAX];
    }
    for (LeanTween.i = 0; LeanTween.i < LeanTween.INIT_LISTENERS_MAX; ++LeanTween.i)
    {
      int index = eventId * LeanTween.INIT_LISTENERS_MAX + LeanTween.i;
      if ((UnityEngine.Object) LeanTween.goListeners[index] == (UnityEngine.Object) null || LeanTween.eventListeners[index] == null)
      {
        LeanTween.eventListeners[index] = callback;
        LeanTween.goListeners[index] = caller;
        if (LeanTween.i < LeanTween.eventsMaxSearch)
          return;
        LeanTween.eventsMaxSearch = LeanTween.i + 1;
        return;
      }
      if ((UnityEngine.Object) LeanTween.goListeners[index] == (UnityEngine.Object) caller && object.Equals((object) LeanTween.eventListeners[index], (object) callback))
        return;
    }
    Debug.LogError((object) ("You ran out of areas to add listeners, consider increasing LISTENERS_MAX, ex: LeanTween.LISTENERS_MAX = " + (LeanTween.LISTENERS_MAX * 2).ToString()));
  }

  public static bool removeListener(int eventId, Action<LTEvent> callback)
  {
    return LeanTween.removeListener(LeanTween.tweenEmpty, eventId, callback);
  }

  public static bool removeListener(int eventId)
  {
    int index = eventId * LeanTween.INIT_LISTENERS_MAX + LeanTween.i;
    LeanTween.eventListeners[index] = (Action<LTEvent>) null;
    LeanTween.goListeners[index] = (GameObject) null;
    return true;
  }

  public static bool removeListener(GameObject caller, int eventId, Action<LTEvent> callback)
  {
    for (LeanTween.i = 0; LeanTween.i < LeanTween.eventsMaxSearch; ++LeanTween.i)
    {
      int index = eventId * LeanTween.INIT_LISTENERS_MAX + LeanTween.i;
      if ((UnityEngine.Object) LeanTween.goListeners[index] == (UnityEngine.Object) caller && object.Equals((object) LeanTween.eventListeners[index], (object) callback))
      {
        LeanTween.eventListeners[index] = (Action<LTEvent>) null;
        LeanTween.goListeners[index] = (GameObject) null;
        return true;
      }
    }
    return false;
  }

  public static void dispatchEvent(int eventId) => LeanTween.dispatchEvent(eventId, (object) null);

  public static void dispatchEvent(int eventId, object data)
  {
    for (int index1 = 0; index1 < LeanTween.eventsMaxSearch; ++index1)
    {
      int index2 = eventId * LeanTween.INIT_LISTENERS_MAX + index1;
      if (LeanTween.eventListeners[index2] != null)
      {
        if ((bool) (UnityEngine.Object) LeanTween.goListeners[index2])
          LeanTween.eventListeners[index2](new LTEvent(eventId, data));
        else
          LeanTween.eventListeners[index2] = (Action<LTEvent>) null;
      }
    }
  }
}
