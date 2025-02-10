// Decompiled with JetBrains decompiler
// Type: CardDestroyedConsume
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CC1DDE51-6D11-4F05-AA69-9B67FE9AC8DF
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Wildfrost_Data\Managed\Assembly-CSharp.dll

using System;
using System.Collections;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;

public class CardDestroyedConsume : MonoBehaviour, ICardDestroyed, IRemoveWhenPooled
{
  private IEnumerator Start()
  {
    CardDestroyedConsume destroyedConsume = this;
    Entity entity = destroyedConsume.GetComponent<Entity>();
    AsyncOperationHandle<GameObject> handle = AddressableLoader.InstantiateAsync("CardBreakFX", entity.offset.position, Quaternion.identity, destroyedConsume.transform);
    SfxSystem.OneShot("event:/sfx/card/consume");
    yield return (object) handle;
    LeanTween.scale(destroyedConsume.gameObject, Vector3.one * 0.6f, 0.25f).setEase(LeanTweenType.easeInBack);
    yield return (object) new WaitForSeconds(0.25f);
    LeanTween.scale(destroyedConsume.gameObject, Vector3.one * 1.2f, 0.25f).setEase(LeanTweenType.easeInBack);
    yield return (object) new WaitForSeconds(0.15f);
    ParticleSystem ps = handle.Result.GetComponent<ParticleSystem>();
    if (ps != null)
    {
      ps.Play();
      if (entity.display is Card display)
      {
        CanvasGroup canvasGroup = display.canvasGroup;
        if (canvasGroup != null)
          LeanTween.alphaCanvas(canvasGroup, 0.0f, 0.1f);
      }
      yield return (object) new WaitUntil((Func<bool>) (() => !(bool) (UnityEngine.Object) ps || !ps.isPlaying));
    }
    // ISSUE: explicit non-virtual call
    __nonvirtual (destroyedConsume.Final());
  }

  public void Final()
  {
    UnityEngine.Object.Destroy((UnityEngine.Object) this);
    CardManager.ReturnToPool(this.gameObject.GetComponent<Card>());
  }
}
