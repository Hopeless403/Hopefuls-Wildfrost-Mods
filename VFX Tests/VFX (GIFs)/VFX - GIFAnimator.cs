using System;
using System.Collections;
using System.Linq;
using UnityEngine;

namespace WildfrostHopeMod.VFX
{
    [RequireComponent(typeof(SpriteRenderer))]
    public class GIFAnimator : MonoBehaviour
    {
        SpriteRenderer renderer;
        public int originalID;
        public bool destroyOnEnd = true;
        public int loops = 1;
        public int currentLoop
        {
            get;
            private set;
        }
        public Sprite[] frames = new Sprite[0];

        public float[] delays = new float[0];

        public event Action<int> OnNextFrame;
        public event Action<int> OnCompletedLoop;
        public event Action OnEnd;

        void Awake()
        {
            renderer = GetComponent<SpriteRenderer>();
            enabled = originalID != 0 || gameObject.GetInstanceID() == originalID;
        }

        void OnEnable() => StartCoroutine(Routine());


        bool promptPause = false;
        public void Pause() => promptPause = true;
        public void Pause(float pauseTime) => StartCoroutine(PauseRoutine(pauseTime));
        IEnumerator PauseRoutine(float pauseTime)
        {
            Pause();
            yield return new WaitForSeconds(pauseTime);
            Unpause();
        }
        public void Unpause() => promptPause = false;
        public void Unpause(float unpauseTime) => StartCoroutine(UnpauseRoutine(unpauseTime));
        IEnumerator UnpauseRoutine(float unpauseTime)
        {
            Unpause();
            yield return new WaitForSeconds(unpauseTime);
            Pause();
        }

        IEnumerator Routine(float delayBefore = 0, float delayAfter = 0f)
        {
            if (gameObject.GetInstanceID() == originalID) yield break;
            if (delayBefore > 0)
                yield return new WaitForSeconds(delayBefore);
            Debug.LogWarning("[VFX Tools] Animating... ");
            currentLoop = 0;
            var watch = System.Diagnostics.Stopwatch.StartNew();
            var t = 0f;
            while (currentLoop != loops)
            {
                for (int i = 0; i < frames.Length; ++i)
                {
                    renderer.sprite = frames[i];
                    OnNextFrame?.Invoke(i);
                    //Debug.LogWarning(watch.ElapsedMilliseconds-t-delays[i]*1000);
                    t = watch.ElapsedMilliseconds;
                    yield return new WaitForSecondsRealtime(delays[i]);
                }
                currentLoop++;
                OnCompletedLoop?.Invoke(currentLoop);
            }
            if (delayAfter > 0) yield return new WaitForSeconds(delayAfter);
            OnEnd?.Invoke();
            if (destroyOnEnd)
                gameObject.Destroy();
        }
    }
}
