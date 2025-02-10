// Decompiled with JetBrains decompiler
// Type: CardDestroyedConsume
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E3D557CA-1D5E-4EC4-9B70-89DC4A0B7277
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp-Publicized.dll

using System;
using System.Collections;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;

#nullable disable
public class CardDestroyedConsume : MonoBehaviour, ICardDestroyed, IRemoveWhenPooled
{
  public string sortingLayer = "Default";
  public int sortingOrder = 10;

  public IEnumerator Start()
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
      foreach (ParticleSystemRenderer componentsInChild in ps.GetComponentsInChildren<ParticleSystemRenderer>())
      {
        componentsInChild.sortingLayerName = destroyedConsume.sortingLayer;
        componentsInChild.sortingOrder = destroyedConsume.sortingOrder;
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
