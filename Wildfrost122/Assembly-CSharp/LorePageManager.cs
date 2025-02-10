// Decompiled with JetBrains decompiler
// Type: LorePageManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6CFD501E-4109-4C31-BEBD-DF2E7FCC442F
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Wildfrost\Modded\Wildfrost_Data\Managed\Assembly-CSharp.dll

using FMODUnity;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

#nullable disable
public class LorePageManager : MonoBehaviour
{
  [SerializeField]
  private GameObject focusLayer;
  [SerializeField]
  private Transform focusLayerPageHolder;
  [SerializeField]
  private AssetReferenceT<JournalPageData>[] pages;
  [SerializeField]
  private AddressableReleaser assetReleaser;
  [SerializeField]
  private EventReference selectSfxEvent;
  [SerializeField]
  private EventReference deselectSfxEvent;
  [SerializeField]
  private EventReference newSfxEvent;
  [SerializeField]
  private SfxLoop newLoop;
  private readonly List<GameObject> pageObjects = new List<GameObject>();
  private LorePage current;
  private Canvas focus;
  private bool focusLayerActive;
  private List<string> inspected;
  private int newCount;

  private void OnEnable()
  {
    this.inspected = SaveSystem.LoadProgressData<List<string>>("lorePagesInspected");
    if (this.inspected == null)
      this.inspected = new List<string>();
    this.Populate();
  }

  private void OnDisable()
  {
    foreach (GameObject pageObject in this.pageObjects)
      pageObject.Destroy();
    this.pageObjects.Clear();
    this.DisableFocusLayer();
  }

  private void Populate()
  {
    this.newCount = 0;
    List<string> unlockedList = MetaprogressionSystem.GetUnlockedList();
    foreach (AssetReferenceT<JournalPageData> page in this.pages)
    {
      AsyncOperationHandle<JournalPageData> handle1 = page.LoadAssetAsync();
      JournalPageData pageData = handle1.WaitForCompletion();
      AsyncOperationHandle<GameObject> handle2 = pageData.prefabRef.InstantiateAsync(this.transform);
      LorePage component = handle2.WaitForCompletion().GetComponent<LorePage>();
      component.manager = this;
      this.pageObjects.Add(component.gameObject);
      if (unlockedList.Contains(pageData.unlock.name))
      {
        bool flag = !this.inspected.Contains(pageData.unlock.name);
        component.SetUnlocked(pageData, true);
        component.SetNew(flag);
        if (flag)
          ++this.newCount;
      }
      this.assetReleaser.Add((AsyncOperationHandle) handle2);
      this.assetReleaser.Add((AsyncOperationHandle) handle1);
    }
    if (this.newCount <= 0)
      return;
    SfxSystem.OneShot(this.newSfxEvent);
    this.newLoop.Play();
  }

  public void Select(LorePage lorePage)
  {
    if (this.focusLayerActive || !lorePage.isUnlocked)
      return;
    this.current = lorePage;
    this.focus = lorePage.canvas;
    SfxSystem.OneShot(this.selectSfxEvent);
    if (lorePage.isNew)
    {
      lorePage.SetNew(false);
      this.inspected.Add(lorePage.pageData.unlock.name);
      SaveSystem.SaveProgressData<List<string>>("lorePagesInspected", this.inspected);
      if (--this.newCount <= 0)
        this.newLoop.Stop();
    }
    this.focusLayerActive = true;
    this.focusLayer.SetActive(true);
    this.focus.overrideSorting = true;
    this.focus.sortingLayerName = "PauseMenu";
    this.focus.sortingOrder = 11;
    this.focus.transform.SetParent(this.focusLayerPageHolder);
    LeanTween.cancel(this.focus.gameObject);
    LeanTween.moveLocal(this.focus.gameObject, Vector3.zero, 0.3f).setEaseOutQuint().setIgnoreTimeScale(true);
    LeanTween.scale(this.focus.gameObject, Vector3.one, 0.3f).setEaseOutQuint().setIgnoreTimeScale(true);
    LeanTween.rotateLocal(this.focus.gameObject, Vector3.zero, 0.6f).setEaseOutBack().setIgnoreTimeScale(true);
  }

  public void DisableFocusLayer()
  {
    if (!this.focusLayerActive)
      return;
    SfxSystem.OneShot(this.deselectSfxEvent);
    this.focus.overrideSorting = false;
    this.focus.sortingOrder = 1;
    this.focus.transform.SetParent(this.current.button.transform);
    LeanTween.cancel(this.focus.gameObject);
    LeanTween.moveLocal(this.focus.gameObject, Vector3.zero, 0.1f).setEaseOutQuad().setIgnoreTimeScale(true);
    LeanTween.scale(this.focus.gameObject, Vector3.one, 0.1f).setEaseOutQuad().setIgnoreTimeScale(true);
    LeanTween.rotateLocal(this.focus.gameObject, Vector3.zero, 0.1f).setEaseOutQuad().setIgnoreTimeScale(true);
    this.focusLayerActive = false;
    this.focusLayer.SetActive(false);
    this.current = (LorePage) null;
    this.focus = (Canvas) null;
  }
}
